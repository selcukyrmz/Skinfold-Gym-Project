using MySql.Data.MySqlClient;
using Skinfold_Gym_Project;
using System;
using System.Data;

public class GymBLL
{
    DbBaglanti selcuksql = new DbBaglanti();

    // Tüm Kayıtlar
    // Reader kapanınca bağlantı da kapanır.
    public MySqlDataReader TumKayitlar()
    {
        MySqlConnection conn = selcuksql.baglanti();
        conn.Open();

        MySqlCommand komut = new MySqlCommand(
            "SELECT * FROM VucutOlcumleri", conn);

        return komut.ExecuteReader(CommandBehavior.CloseConnection);
    }

    // EKLE
    public void VeriEkle(
        string uye_no,
        string ad,
        string soyad,
        int yas,
        string cinsiyet,
        string protokol,
        int toplam_sf_mm,
        double vucut_agirligi
    )
    {
        // Önce hesaplamalar
        double yag_yuzdesi = YagYuzdesiHesapla(protokol, toplam_sf_mm);
        double yag_kg = YagKgHesapla(vucut_agirligi, yag_yuzdesi);
        double kas_kg = KasKgHesapla(vucut_agirligi, yag_kg);
        string kategori = KategoriHesapla(yag_yuzdesi, kas_kg);

        // using: hata olsa bile bağlantı kapanır
        using (MySqlConnection conn = selcuksql.baglanti())
        {
            conn.Open();

            MySqlCommand ekle = new MySqlCommand(@"INSERT INTO VucutOlcumleri
            (uye_no, ad, soyad, yas, cinsiyet, protokol, toplam_sf_mm, vucut_agirligi, yag_yuzdesi, yag_kg, kas_kg, kategori)
            VALUES
            (@uye_no, @ad, @soyad, @yas, @cinsiyet, @protokol, @toplam, @vy, @yy, @yk, @kk, @kat)", conn);

            ekle.Parameters.AddWithValue("@uye_no", uye_no);
            ekle.Parameters.AddWithValue("@ad", ad);
            ekle.Parameters.AddWithValue("@soyad", soyad);
            ekle.Parameters.AddWithValue("@yas", yas);
            ekle.Parameters.AddWithValue("@cinsiyet", cinsiyet);
            ekle.Parameters.AddWithValue("@protokol", protokol);
            ekle.Parameters.AddWithValue("@toplam", toplam_sf_mm);
            ekle.Parameters.AddWithValue("@vy", vucut_agirligi);
            ekle.Parameters.AddWithValue("@yy", yag_yuzdesi);
            ekle.Parameters.AddWithValue("@yk", yag_kg);
            ekle.Parameters.AddWithValue("@kk", kas_kg);
            ekle.Parameters.AddWithValue("@kat", kategori);

            ekle.ExecuteNonQuery();
        }
    }

    // SİL
    public void VeriSil(int id)
    {
        using (MySqlConnection conn = selcuksql.baglanti())
        {
            conn.Open();

            MySqlCommand sil = new MySqlCommand(
                "DELETE FROM VucutOlcumleri WHERE id=@id", conn);

            sil.Parameters.AddWithValue("@id", id);

            sil.ExecuteNonQuery();
        }
    }

    // ARA
    public MySqlDataReader VeriAra(string ad)
    {
        MySqlConnection conn = selcuksql.baglanti();
        conn.Open();

        MySqlCommand arama = new MySqlCommand(
            "SELECT * FROM VucutOlcumleri WHERE ad LIKE @ad", conn);

        arama.Parameters.AddWithValue("@ad", "%" + ad + "%");

        return arama.ExecuteReader(CommandBehavior.CloseConnection);
    }

    // VERİ GÜNCELLE
    public void VeriGuncelle(
        int id,
        string uye_no,
        string ad,
        string soyad,
        int yas,
        string cinsiyet,
        string protokol,
        int toplam_sf_mm,
        double vucut_agirligi
    )
    {
        double yag_yuzdesi = YagYuzdesiHesapla(protokol, toplam_sf_mm);
        double yag_kg = YagKgHesapla(vucut_agirligi, yag_yuzdesi);
        double kas_kg = KasKgHesapla(vucut_agirligi, yag_kg);
        string kategori = KategoriHesapla(yag_yuzdesi, kas_kg);

        using (MySqlConnection conn = selcuksql.baglanti())
        {
            conn.Open();

            MySqlCommand guncelle = new MySqlCommand(@"UPDATE VucutOlcumleri SET
            uye_no=@uye_no, ad=@ad, soyad=@soyad, yas=@yas,
            cinsiyet=@cinsiyet, protokol=@protokol, toplam_sf_mm=@toplam,
            vucut_agirligi=@vy, yag_yuzdesi=@yy, yag_kg=@yk, kas_kg=@kk, kategori=@kat
            WHERE id=@id", conn);

            guncelle.Parameters.AddWithValue("@id", id);
            guncelle.Parameters.AddWithValue("@uye_no", uye_no);
            guncelle.Parameters.AddWithValue("@ad", ad);
            guncelle.Parameters.AddWithValue("@soyad", soyad);
            guncelle.Parameters.AddWithValue("@yas", yas);
            guncelle.Parameters.AddWithValue("@cinsiyet", cinsiyet);
            guncelle.Parameters.AddWithValue("@protokol", protokol);
            guncelle.Parameters.AddWithValue("@toplam", toplam_sf_mm);
            guncelle.Parameters.AddWithValue("@vy", vucut_agirligi);
            guncelle.Parameters.AddWithValue("@yy", yag_yuzdesi);
            guncelle.Parameters.AddWithValue("@yk", yag_kg);
            guncelle.Parameters.AddWithValue("@kk", kas_kg);
            guncelle.Parameters.AddWithValue("@kat", kategori);

            guncelle.ExecuteNonQuery();
        }
    }

    // YAĞ YÜZDESİ
    public double YagYuzdesiHesapla(string protokol, int toplam_sf_mm)
    {
        double yuzde;

        if (protokol == "JP3E")
            yuzde = (toplam_sf_mm * 0.143) + 5.0;
        else if (protokol == "JP3K")
            yuzde = (toplam_sf_mm * 0.155) + 4.0;
        else
            yuzde = (toplam_sf_mm * 0.150) + 5.0;

        return Math.Round(yuzde, 2);
    }

    // YAĞ KG
    public double YagKgHesapla(double vucut_agirligi, double yag_yuzdesi)
    {
        return Math.Round((yag_yuzdesi / 100.0) * vucut_agirligi, 2);
    }

    // KAS KG (yağsız kütle)
    public double KasKgHesapla(double vucut_agirligi, double yag_kg)
    {
        return Math.Round(vucut_agirligi - yag_kg, 2);
    }

    // KATEGORİ
    public string KategoriHesapla(double yag_yuzdesi, double kas_kg)
    {
        if (yag_yuzdesi < 10)
            return "Atlet";

        if (yag_yuzdesi < 15)
            return "Fit";

        if (yag_yuzdesi < 25)
            return "Sporcu";

        if (yag_yuzdesi < 35)
            return "Kilolu";

        return "Obez";
    }
}