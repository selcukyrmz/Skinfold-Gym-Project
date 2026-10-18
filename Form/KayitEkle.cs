using System;
using System.Windows.Forms;

namespace Skinfold_Gym_Project
{
    public partial class KayitEkle : Form
    {
        GymBLL islem;

        public event Action KayitEklendi;

        public KayitEkle()
        {
            InitializeComponent();
            islem = new GymBLL();

            cmbCinsiyet.Items.Clear();
            cmbCinsiyet.Items.Add("Erkek");
            cmbCinsiyet.Items.Add("Kadın");
            cmbCinsiyet.SelectedIndex = 0;

            cmbProtokol.Items.Clear();
            cmbProtokol.Items.Add("JP3E");
            cmbProtokol.Items.Add("JP3K");
            cmbProtokol.SelectedIndex = 0;
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            try
            {
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

                string cinsiyet = cmbCinsiyet.SelectedItem.ToString();
                string protokol = cmbProtokol.SelectedItem.ToString();

                islem.VeriEkle(
                    txtUyeNo.Text,
                    txtAd.Text,
                    txtSoyad.Text,
                    yas,
                    cinsiyet,
                    protokol,
                    mm,
                    vy
                );

                MessageBox.Show("Kayıt Eklendi!", "Sistem Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Yeni kayıt için kutuları temizle
                txtUyeNo.Clear();
                txtAd.Clear();
                txtSoyad.Clear();
                txtYas.Clear();
                txtDeriKivrimi.Clear();
                txtVucutYogunlugu.Clear();
                txtUyeNo.Focus();

                KayitEklendi?.Invoke();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnKayitlaraGeriDon_Click(object sender, EventArgs e)
        {
            // Bu formu kapatınca ana form (GymForm) tekrar gösterilir ve yenilenir
            this.Close();
        }

        private void KayitEkle_Load(object sender, EventArgs e)
        {

        }
    }
}