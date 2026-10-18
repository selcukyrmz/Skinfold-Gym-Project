namespace Skinfold_Gym_Project
{
    partial class GymForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgwKayitlar = new System.Windows.Forms.DataGridView();
            this.btnKayitEkle = new System.Windows.Forms.Button();
            this.btnKayitSil = new System.Windows.Forms.Button();
            this.btnKayitDuzenle = new System.Windows.Forms.Button();
            this.txtKisiAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbErkekUyeler = new System.Windows.Forms.RadioButton();
            this.lblKadinUyeler = new System.Windows.Forms.Label();
            this.rdbKadinUyeler = new System.Windows.Forms.RadioButton();
            this.lblErkekUyeler = new System.Windows.Forms.Label();
            this.rdbSifirla = new System.Windows.Forms.RadioButton();
            this.lblToplamUyeler = new System.Windows.Forms.Label();
            this.grpFiltre = new System.Windows.Forms.GroupBox();
            this.pictLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKayitlar)).BeginInit();
            this.grpFiltre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwKayitlar
            // 
            this.dgwKayitlar.BackgroundColor = System.Drawing.Color.White;
            this.dgwKayitlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwKayitlar.Location = new System.Drawing.Point(12, 68);
            this.dgwKayitlar.Name = "dgwKayitlar";
            this.dgwKayitlar.Size = new System.Drawing.Size(899, 553);
            this.dgwKayitlar.TabIndex = 0;
            // 
            // btnKayitEkle
            // 
            this.btnKayitEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayitEkle.Location = new System.Drawing.Point(917, 68);
            this.btnKayitEkle.Name = "btnKayitEkle";
            this.btnKayitEkle.Size = new System.Drawing.Size(133, 38);
            this.btnKayitEkle.TabIndex = 3;
            this.btnKayitEkle.Text = "Yeni Kayıt";
            this.btnKayitEkle.UseVisualStyleBackColor = true;
            this.btnKayitEkle.Click += new System.EventHandler(this.btnKayitEkle_Click);
            // 
            // btnKayitSil
            // 
            this.btnKayitSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayitSil.Location = new System.Drawing.Point(917, 156);
            this.btnKayitSil.Name = "btnKayitSil";
            this.btnKayitSil.Size = new System.Drawing.Size(133, 38);
            this.btnKayitSil.TabIndex = 6;
            this.btnKayitSil.Text = "Kayıt Sil";
            this.btnKayitSil.UseVisualStyleBackColor = true;
            this.btnKayitSil.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnKayitDuzenle
            // 
            this.btnKayitDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayitDuzenle.Location = new System.Drawing.Point(917, 112);
            this.btnKayitDuzenle.Name = "btnKayitDuzenle";
            this.btnKayitDuzenle.Size = new System.Drawing.Size(133, 38);
            this.btnKayitDuzenle.TabIndex = 7;
            this.btnKayitDuzenle.Text = "Kayıt Düzenle";
            this.btnKayitDuzenle.UseVisualStyleBackColor = true;
            this.btnKayitDuzenle.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtKisiAra
            // 
            this.txtKisiAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKisiAra.Location = new System.Drawing.Point(758, 34);
            this.txtKisiAra.Multiline = true;
            this.txtKisiAra.Name = "txtKisiAra";
            this.txtKisiAra.Size = new System.Drawing.Size(153, 28);
            this.txtKisiAra.TabIndex = 13;
            this.txtKisiAra.TextChanged += new System.EventHandler(this.txtKisiAra_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(755, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Kişi Ara:";
            // 
            // rdbErkekUyeler
            // 
            this.rdbErkekUyeler.AutoSize = true;
            this.rdbErkekUyeler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbErkekUyeler.Location = new System.Drawing.Point(10, 118);
            this.rdbErkekUyeler.Name = "rdbErkekUyeler";
            this.rdbErkekUyeler.Size = new System.Drawing.Size(156, 19);
            this.rdbErkekUyeler.TabIndex = 18;
            this.rdbErkekUyeler.TabStop = true;
            this.rdbErkekUyeler.Text = "Erkek Üyeleri Göster";
            this.rdbErkekUyeler.UseVisualStyleBackColor = true;
            this.rdbErkekUyeler.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // lblKadinUyeler
            // 
            this.lblKadinUyeler.AutoSize = true;
            this.lblKadinUyeler.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKadinUyeler.Location = new System.Drawing.Point(6, 78);
            this.lblKadinUyeler.Name = "lblKadinUyeler";
            this.lblKadinUyeler.Size = new System.Drawing.Size(131, 19);
            this.lblKadinUyeler.TabIndex = 17;
            this.lblKadinUyeler.Text = "Kadın Üye Sayısı:";
            // 
            // rdbKadinUyeler
            // 
            this.rdbKadinUyeler.AutoSize = true;
            this.rdbKadinUyeler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbKadinUyeler.Location = new System.Drawing.Point(9, 141);
            this.rdbKadinUyeler.Name = "rdbKadinUyeler";
            this.rdbKadinUyeler.Size = new System.Drawing.Size(157, 19);
            this.rdbKadinUyeler.TabIndex = 19;
            this.rdbKadinUyeler.TabStop = true;
            this.rdbKadinUyeler.Text = "Kadın Üyeleri Göster";
            this.rdbKadinUyeler.UseVisualStyleBackColor = true;
            this.rdbKadinUyeler.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // lblErkekUyeler
            // 
            this.lblErkekUyeler.AutoSize = true;
            this.lblErkekUyeler.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblErkekUyeler.Location = new System.Drawing.Point(6, 59);
            this.lblErkekUyeler.Name = "lblErkekUyeler";
            this.lblErkekUyeler.Size = new System.Drawing.Size(130, 19);
            this.lblErkekUyeler.TabIndex = 16;
            this.lblErkekUyeler.Text = "Erkek Üye Sayısı:";
            // 
            // rdbSifirla
            // 
            this.rdbSifirla.AutoSize = true;
            this.rdbSifirla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbSifirla.Location = new System.Drawing.Point(9, 164);
            this.rdbSifirla.Name = "rdbSifirla";
            this.rdbSifirla.Size = new System.Drawing.Size(63, 19);
            this.rdbSifirla.TabIndex = 20;
            this.rdbSifirla.TabStop = true;
            this.rdbSifirla.Text = "Sıfırla";
            this.rdbSifirla.UseVisualStyleBackColor = true;
            this.rdbSifirla.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // lblToplamUyeler
            // 
            this.lblToplamUyeler.AutoSize = true;
            this.lblToplamUyeler.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamUyeler.Location = new System.Drawing.Point(6, 40);
            this.lblToplamUyeler.Name = "lblToplamUyeler";
            this.lblToplamUyeler.Size = new System.Drawing.Size(141, 19);
            this.lblToplamUyeler.TabIndex = 15;
            this.lblToplamUyeler.Text = "Toplam Üye Sayısı:";
            // 
            // grpFiltre
            // 
            this.grpFiltre.Controls.Add(this.lblToplamUyeler);
            this.grpFiltre.Controls.Add(this.rdbSifirla);
            this.grpFiltre.Controls.Add(this.lblErkekUyeler);
            this.grpFiltre.Controls.Add(this.rdbKadinUyeler);
            this.grpFiltre.Controls.Add(this.lblKadinUyeler);
            this.grpFiltre.Controls.Add(this.rdbErkekUyeler);
            this.grpFiltre.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFiltre.Location = new System.Drawing.Point(917, 200);
            this.grpFiltre.Name = "grpFiltre";
            this.grpFiltre.Size = new System.Drawing.Size(218, 213);
            this.grpFiltre.TabIndex = 21;
            this.grpFiltre.TabStop = false;
            this.grpFiltre.Text = "Bilgiler ve Filtreler";
            // 
            // pictLogo
            // 
            this.pictLogo.Image = global::kurtarma.Properties.Resources.skinfold_logo;
            this.pictLogo.Location = new System.Drawing.Point(12, 12);
            this.pictLogo.Name = "pictLogo";
            this.pictLogo.Size = new System.Drawing.Size(73, 50);
            this.pictLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictLogo.TabIndex = 5;
            this.pictLogo.TabStop = false;
            // 
            // GymForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 781);
            this.Controls.Add(this.grpFiltre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKisiAra);
            this.Controls.Add(this.btnKayitDuzenle);
            this.Controls.Add(this.btnKayitSil);
            this.Controls.Add(this.pictLogo);
            this.Controls.Add(this.btnKayitEkle);
            this.Controls.Add(this.dgwKayitlar);
            this.Name = "GymForm";
            this.Text = "GymForm";
            this.Load += new System.EventHandler(this.GymForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwKayitlar)).EndInit();
            this.grpFiltre.ResumeLayout(false);
            this.grpFiltre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwKayitlar;
        private System.Windows.Forms.Button btnKayitEkle;
        private System.Windows.Forms.PictureBox pictLogo;
        private System.Windows.Forms.Button btnKayitSil;
        private System.Windows.Forms.Button btnKayitDuzenle;
        private System.Windows.Forms.TextBox txtKisiAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbErkekUyeler;
        private System.Windows.Forms.Label lblKadinUyeler;
        private System.Windows.Forms.RadioButton rdbKadinUyeler;
        private System.Windows.Forms.Label lblErkekUyeler;
        private System.Windows.Forms.RadioButton rdbSifirla;
        private System.Windows.Forms.Label lblToplamUyeler;
        private System.Windows.Forms.GroupBox grpFiltre;
    }
}

