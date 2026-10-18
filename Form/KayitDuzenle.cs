using MySql.Data.MySqlClient;
using Skinfold_Gym_Project;
using System;
using System.Windows.Forms;

namespace SkinFold_Gym_Project
{
    public partial class KayitDuzenle : Form
    {
        GymBLL islem;
        DbBaglanti selcuksql = new DbBaglanti();

        public KayitDuzenle()
        {
            InitializeComponent();
            islem = new GymBLL();

            // Tabloda bir satıra tıklayınca bilgiler kutulara dolsun
            dgwKayitlar.CellClick += dgwKayitlar_CellClick;
        }

        private void KayitDuzenle_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.Items.Clear();
            cmbCinsiyet.Items.Add("Erkek");
            cmbCinsiyet.Items.Add("Kadın");
            cmbCinsiyet.SelectedIndex = 0;

            cmbProtokol.Items.Clear();
            cmbProtokol.Items.Add("JP3E");
            cmbProtokol.Items.Add("JP3K");
            cmbProtokol.SelectedIndex = 0;

            SutunlariOlustur();
            Uyeler();
            Listele();
        }

        private void btnKayitlaraGeriDon_Click(object sender, EventArgs e)
        {
            // Bu formu kapatınca ana form (GymForm) tekrar gösterilir ve yenilenir
            this.Close();
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

                lblErkek.Text = "Erkek Üye Sayısı: " + erkekToplam.ExecuteScalar().ToString();
                lblKadin.Text = "Kadın Üye Sayısı: " + kadinToplam.ExecuteScalar().ToString();
                lblToplam.Text = "Toplam Üye Sayısı: " + uyeToplam.ExecuteScalar().ToString();
            }
        }

        void SutunlariOlustur()
        {
            dgwKayitlar.Columns.Clear();

            dgwKayitlar.Columns.Add("id", "ID");                       // 0
            dgwKayitlar.Columns.Add("tarih", "Tarih");                 // 1
            dgwKayitlar.Columns.Add("uye_no", "Üye Numarası");         // 2
            dgwKayitlar.Columns.Add("ad", "Ad");                       // 3
            dgwKayitlar.Columns.Add("soyad", "Soyad");                 // 4
            dgwKayitlar.Columns.Add("yas", "Yaş");                     // 5
            dgwKayitlar.Columns.Add("cinsiyet", "Cinsiyet");           // 6
            dgwKayitlar.Columns.Add("protokol", "Protokol");           // 7
            dgwKayitlar.Columns.Add("toplam", "Toplam Deri Kıvrımı");  // 8
            dgwKayitlar.Columns.Add("vy", "Vücut Ağırlığı (kg)");      // 9
            dgwKayitlar.Columns.Add("yy", "Yağ Yüzdesi");              // 10
            dgwKayitlar.Columns.Add("yk", "Yağ Kütlesi");              // 11
            dgwKayitlar.Columns.Add("kk", "Kas Kütlesi");              // 12
            dgwKayitlar.Columns.Add("kategori", "Kategori");           // 13
        }

        // Reader'daki kayıtları tabloya yazar (14 sütun, sırası SutunlariOlustur ile aynı)
        void TabloyuDoldur(MySqlDataReader kayitlar)
        {
            dgwKayitlar.Rows.Clear();

            while (kayitlar.Read())
            {
                dgwKayitlar.Rows.Add(
                    kayitlar["id"],
                    kayitlar["tarih"],
                    kayitlar["uye_no"],
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

        // Tablodaki hücrenin değerini yazı olarak verir (boşsa "")
        string Hucre(DataGridViewRow satir, int sutun)
        {
            object deger = satir.Cells[sutun].Value;
            if (deger == null)
                return "";
            return deger.ToString();
        }

        // Satıra tıklanınca bilgileri kutulara doldurur
        private void dgwKayitlar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow satir = dgwKayitlar.Rows[e.RowIndex];

            txtUyeNo.Text = Hucre(satir, 2);
            txtAd.Text = Hucre(satir, 3);
            txtSoyad.Text = Hucre(satir, 4);
            txtYas.Text = Hucre(satir, 5);
            cmbCinsiyet.Text = Hucre(satir, 6);
            cmbProtokol.Text = Hucre(satir, 7);
            txtDeriKivrimi.Text = Hucre(satir, 8);
            txtVucutYogunlugu.Text = Hucre(satir, 9);
        }

        private void btnKayitDuzenle_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgwKayitlar.CurrentRow == null)
                {
                    MessageBox.Show("Önce tablodan düzenlenecek kaydı seçin!", "Sistem Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(txtYas.Text, out int yas) ||
                    !int.TryParse(txtDeriKivrimi.Text, out int mm) ||
                    !double.TryParse(txtVucutYogunlugu.Text, out double vy))
                {
                    MessageBox.Show("Sayısal alanları doğru giriniz!", "Sistem Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (cmbCinsiyet.SelectedItem == null)
                {
                    MessageBox.Show("Cinsiyet seçmediniz!", "Sistem Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (cmbProtokol.SelectedItem == null)
                {
                    MessageBox.Show("Protokol seçmediniz!", "Sistem Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (txtAd.Text.Trim() == "" || txtSoyad.Text.Trim() == "")
                {
                    MessageBox.Show("Ad ve soyad boş bırakılamaz!", "Sistem Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (yas <= 0 || yas > 75)
                {
                    MessageBox.Show("Yaş 1 ile 75 arasında olmalıdır, lütfen tekrar deneyiniz!", "Sistem Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (mm < 0 || vy <= 0)
                {
                    MessageBox.Show("Deri kıvrımı negatif, vücut ağırlığı sıfır veya negatif olamaz!", "Sistem Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 0. sütun id'dir
                int id = Convert.ToInt32(dgwKayitlar.CurrentRow.Cells[0].Value);

                islem.VeriGuncelle(
                    id,
                    txtUyeNo.Text,
                    txtAd.Text,
                    txtSoyad.Text,
                    yas,
                    cmbCinsiyet.Text,
                    cmbProtokol.Text,
                    mm,
                    vy
                );

                MessageBox.Show("Kayıt Güncellendi!", "Sistem Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Uyeler();
                Listele();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TabloyuDoldur(islem.VeriAra(txtKisiAra.Text));
        }

        // Radio butonlar hem seçilince hem seçim kalkınca çalışır,
        // o yüzden sadece seçiliyken işlem yapıyoruz
        private void rdbErkekler_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdbErkekUyeler.Checked)
                CinsiyetListele("Erkek");
        }

        private void rdbKadinlar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbKadinUyeler.Checked)
                CinsiyetListele("Kadın");
        }

        private void rdbSifirla_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSifirla.Checked)
                Listele();
        }
    }
}