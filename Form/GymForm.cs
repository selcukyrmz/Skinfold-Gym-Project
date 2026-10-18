using MySql.Data.MySqlClient;
using SkinFold_Gym_Project;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Skinfold_Gym_Project
{
    public partial class GymForm : Form
    {
        GymBLL islem;
        DbBaglanti selcuksql = new DbBaglanti();

        public GymForm()
        {
            InitializeComponent();
            islem = new GymBLL();
        }

        private void GymForm_Load(object sender, EventArgs e)
        {
            SutunlariOlustur();
            Uyeler();
            Listele();
        }

        // Üye sayılarını gösterir
        public void Uyeler()
        {
            // using: hata olsa bile bağlantı kapanır
            using (MySqlConnection conn = selcuksql.baglanti())
            {
                conn.Open();

                MySqlCommand uyeToplam = new MySqlCommand(
                    "SELECT COUNT(*) FROM VucutOlcumleri", conn);

                MySqlCommand erkekToplam = new MySqlCommand(
                    "SELECT COUNT(*) FROM VucutOlcumleri WHERE cinsiyet='Erkek'", conn);

                MySqlCommand kadinToplam = new MySqlCommand(
                    "SELECT COUNT(*) FROM VucutOlcumleri WHERE cinsiyet='Kadın'", conn);

                lblErkekUyeler.Text = "Erkek Üye Sayısı: " + erkekToplam.ExecuteScalar().ToString();
                lblKadinUyeler.Text = "Kadın Üye Sayısı: " + kadinToplam.ExecuteScalar().ToString();
                lblToplamUyeler.Text = "Toplam Üye Sayısı: " + uyeToplam.ExecuteScalar().ToString();
            }
        }

        void SutunlariOlustur()
        {
            dgwKayitlar.Columns.Clear();

            dgwKayitlar.Columns.Add("id", "ID");
            dgwKayitlar.Columns.Add("uye_no", "Üye No");
            dgwKayitlar.Columns.Add("tarih", "Tarih");
            dgwKayitlar.Columns.Add("ad", "Ad");
            dgwKayitlar.Columns.Add("soyad", "Soyad");
            dgwKayitlar.Columns.Add("yas", "Yaş");
            dgwKayitlar.Columns.Add("cinsiyet", "Cinsiyet");
            dgwKayitlar.Columns.Add("protokol", "Protokol");
            dgwKayitlar.Columns.Add("toplam", "Toplam Deri Kıvrımı");
            dgwKayitlar.Columns.Add("vy", "Vücut Ağırlığı (kg)");
            dgwKayitlar.Columns.Add("yy", "Yağ Yüzdesi");
            dgwKayitlar.Columns.Add("yk", "Yağ Kütlesi");
            dgwKayitlar.Columns.Add("kk", "Kas Kütlesi");
            dgwKayitlar.Columns.Add("kategori", "Kategori");
        }

        // Reader'daki kayıtları tabloya yazar (14 sütun, sırası SutunlariOlustur ile aynı)
        void TabloyuDoldur(MySqlDataReader kayitlar)
        {
            dgwKayitlar.Rows.Clear();

            while (kayitlar.Read())
            {
                dgwKayitlar.Rows.Add(
                    kayitlar["id"],
                    kayitlar["uye_no"],
                    kayitlar["tarih"],
                    kayitlar["ad"],
                    kayitlar["soyad"],
                    kayitlar["yas"],
                    kayitlar["cinsiyet"],
                    kayitlar["protokol"],
                    kayitlar["toplam_sf_mm"],
                    kayitlar["vucut_agirligi"],
                    kayitlar["yag_yuzdesi"],
                    kayitlar["yag_kg"],
                    kayitlar["kas_kg"],
                    kayitlar["kategori"]
                );
            }

            kayitlar.Close(); // bağlantıyı da kapatır
        }

        void Listele()
        {
            TabloyuDoldur(islem.TumKayitlar());
        }

        // Cinsiyete göre listeler
        void CinsiyetListele(string cinsiyet)
        {
            using (MySqlConnection conn = selcuksql.baglanti())
            {
                conn.Open();

                MySqlCommand komut = new MySqlCommand(
                    "SELECT * FROM VucutOlcumleri WHERE cinsiyet=@cinsiyet", conn);
                komut.Parameters.AddWithValue("@cinsiyet", cinsiyet);

                using (MySqlDataReader kayitlar = komut.ExecuteReader())
                {
                    TabloyuDoldur(kayitlar);
                }
            }
        }

        private void btnKayitEkle_Click(object sender, EventArgs e)
        {
            KayitEkle frm = new KayitEkle();

            this.Hide();
            frm.ShowDialog();

            // Pencere kapanınca ana formu tekrar göster ve yenile
            this.Show();
            Uyeler();
            Listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgwKayitlar.CurrentRow == null)
                {
                    MessageBox.Show("Önce silinecek kaydı seçin!");
                    return;
                }

                DialogResult cevap = MessageBox.Show("Kayıt silinsin mi?", "Onay",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (cevap != DialogResult.Yes)
                    return;

                int id = Convert.ToInt32(dgwKayitlar.CurrentRow.Cells[0].Value);

                islem.VeriSil(id);

                MessageBox.Show("Kayıt Silindi!", "Sistem Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Uyeler();
                Listele();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KayitDuzenle duzen = new KayitDuzenle();

            this.Hide();
            duzen.ShowDialog();

            this.Show();
            Uyeler();
            Listele();
        }

        private void txtKisiAra_TextChanged(object sender, EventArgs e)
        {
            TabloyuDoldur(islem.VeriAra(txtKisiAra.Text));
        }

        // Radio butonlar hem seçilince hem seçim kalkınca çalışır,
        // o yüzden sadece seçiliyken işlem yapıyoruz
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbErkekUyeler.Checked)
                CinsiyetListele("Erkek");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbKadinUyeler.Checked)
                CinsiyetListele("Kadın");
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSifirla.Checked)
                Listele();
        }
    }
}