namespace SkinFold_Gym_Project
{
    partial class KayitDuzenle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnKayitlaraGeriDon = new System.Windows.Forms.Button();
            this.btnKayitDuzenle = new System.Windows.Forms.Button();
            this.dgwKayitlar = new System.Windows.Forms.DataGridView();
            this.grpKayitDuzen = new System.Windows.Forms.GroupBox();
            this.tableKayitDuzen = new System.Windows.Forms.TableLayoutPanel();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtUyeNo = new System.Windows.Forms.TextBox();
            this.lblUyeNo = new System.Windows.Forms.Label();
            this.cmbProtokol = new System.Windows.Forms.ComboBox();
            this.txtYas = new System.Windows.Forms.TextBox();
            this.lblDeriKivrimi = new System.Windows.Forms.Label();
            this.lblProtokol = new System.Windows.Forms.Label();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.lblYas = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.txtDeriKivrimi = new System.Windows.Forms.TextBox();
            this.txtVucutYogunlugu = new System.Windows.Forms.TextBox();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.lblVucutYogunlugu = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblKisiAra = new System.Windows.Forms.Label();
            this.txtKisiAra = new System.Windows.Forms.TextBox();
            this.grpFiltre = new System.Windows.Forms.GroupBox();
            this.lblToplam = new System.Windows.Forms.Label();
            this.rdbSifirla = new System.Windows.Forms.RadioButton();
            this.lblErkek = new System.Windows.Forms.Label();
            this.rdbKadinUyeler = new System.Windows.Forms.RadioButton();
            this.lblKadin = new System.Windows.Forms.Label();
            this.rdbErkekUyeler = new System.Windows.Forms.RadioButton();
            this.pictLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKayitlar)).BeginInit();
            this.grpKayitDuzen.SuspendLayout();
            this.tableKayitDuzen.SuspendLayout();
            this.grpFiltre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKayitlaraGeriDon
            // 
            this.btnKayitlaraGeriDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayitlaraGeriDon.Location = new System.Drawing.Point(171, 585);
            this.btnKayitlaraGeriDon.Name = "btnKayitlaraGeriDon";
            this.btnKayitlaraGeriDon.Size = new System.Drawing.Size(199, 48);
            this.btnKayitlaraGeriDon.TabIndex = 8;
            this.btnKayitlaraGeriDon.Text = "Kayıtlara Geri Dön";
            this.btnKayitlaraGeriDon.UseVisualStyleBackColor = true;
            this.btnKayitlaraGeriDon.Click += new System.EventHandler(this.btnKayitlaraGeriDon_Click);
            // 
            // btnKayitDuzenle
            // 
            this.btnKayitDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayitDuzenle.Location = new System.Drawing.Point(12, 585);
            this.btnKayitDuzenle.Name = "btnKayitDuzenle";
            this.btnKayitDuzenle.Size = new System.Drawing.Size(153, 48);
            this.btnKayitDuzenle.TabIndex = 7;
            this.btnKayitDuzenle.Text = "Kaydı Düzenle";
            this.btnKayitDuzenle.UseVisualStyleBackColor = true;
            this.btnKayitDuzenle.Click += new System.EventHandler(this.btnKayitDuzenle_Click);
            // 
            // dgwKayitlar
            // 
            this.dgwKayitlar.BackgroundColor = System.Drawing.Color.White;
            this.dgwKayitlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwKayitlar.Location = new System.Drawing.Point(376, 148);
            this.dgwKayitlar.Name = "dgwKayitlar";
            this.dgwKayitlar.Size = new System.Drawing.Size(853, 485);
            this.dgwKayitlar.TabIndex = 9;
            // 
            // grpKayitDuzen
            // 
            this.grpKayitDuzen.Controls.Add(this.tableKayitDuzen);
            this.grpKayitDuzen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpKayitDuzen.Location = new System.Drawing.Point(12, 77);
            this.grpKayitDuzen.Name = "grpKayitDuzen";
            this.grpKayitDuzen.Size = new System.Drawing.Size(358, 499);
            this.grpKayitDuzen.TabIndex = 10;
            this.grpKayitDuzen.TabStop = false;
            this.grpKayitDuzen.Text = "Kayıt Düzenle";
            // 
            // tableKayitDuzen
            // 
            this.tableKayitDuzen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableKayitDuzen.ColumnCount = 2;
            this.tableKayitDuzen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableKayitDuzen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableKayitDuzen.Controls.Add(this.txtAd, 1, 0);
            this.tableKayitDuzen.Controls.Add(this.txtSoyad, 1, 1);
            this.tableKayitDuzen.Controls.Add(this.txtUyeNo, 1, 7);
            this.tableKayitDuzen.Controls.Add(this.lblUyeNo, 0, 7);
            this.tableKayitDuzen.Controls.Add(this.cmbProtokol, 1, 4);
            this.tableKayitDuzen.Controls.Add(this.txtYas, 1, 2);
            this.tableKayitDuzen.Controls.Add(this.lblDeriKivrimi, 0, 5);
            this.tableKayitDuzen.Controls.Add(this.lblProtokol, 0, 4);
            this.tableKayitDuzen.Controls.Add(this.lblCinsiyet, 0, 3);
            this.tableKayitDuzen.Controls.Add(this.lblYas, 0, 2);
            this.tableKayitDuzen.Controls.Add(this.lblSoyad, 0, 1);
            this.tableKayitDuzen.Controls.Add(this.txtDeriKivrimi, 1, 5);
            this.tableKayitDuzen.Controls.Add(this.txtVucutYogunlugu, 1, 6);
            this.tableKayitDuzen.Controls.Add(this.cmbCinsiyet, 1, 3);
            this.tableKayitDuzen.Controls.Add(this.lblVucutYogunlugu, 0, 6);
            this.tableKayitDuzen.Controls.Add(this.lblAd, 0, 0);
            this.tableKayitDuzen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tableKayitDuzen.Location = new System.Drawing.Point(8, 23);
            this.tableKayitDuzen.Name = "tableKayitDuzen";
            this.tableKayitDuzen.RowCount = 8;
            this.tableKayitDuzen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.tableKayitDuzen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.tableKayitDuzen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.tableKayitDuzen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.tableKayitDuzen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.tableKayitDuzen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.tableKayitDuzen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.099391F));
            this.tableKayitDuzen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableKayitDuzen.Size = new System.Drawing.Size(350, 470);
            this.tableKayitDuzen.TabIndex = 1;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(178, 3);
            this.txtAd.Multiline = true;
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(169, 32);
            this.txtAd.TabIndex = 29;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(178, 65);
            this.txtSoyad.Multiline = true;
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(169, 29);
            this.txtSoyad.TabIndex = 28;
            // 
            // txtUyeNo
            // 
            this.txtUyeNo.Location = new System.Drawing.Point(178, 428);
            this.txtUyeNo.Multiline = true;
            this.txtUyeNo.Name = "txtUyeNo";
            this.txtUyeNo.Size = new System.Drawing.Size(169, 29);
            this.txtUyeNo.TabIndex = 27;
            // 
            // lblUyeNo
            // 
            this.lblUyeNo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUyeNo.AutoSize = true;
            this.lblUyeNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUyeNo.Location = new System.Drawing.Point(3, 425);
            this.lblUyeNo.Name = "lblUyeNo";
            this.lblUyeNo.Size = new System.Drawing.Size(169, 45);
            this.lblUyeNo.TabIndex = 26;
            this.lblUyeNo.Text = "     Üye Numarası:";
            // 
            // cmbProtokol
            // 
            this.cmbProtokol.FormattingEnabled = true;
            this.cmbProtokol.Location = new System.Drawing.Point(178, 251);
            this.cmbProtokol.Name = "cmbProtokol";
            this.cmbProtokol.Size = new System.Drawing.Size(169, 28);
            this.cmbProtokol.TabIndex = 25;
            // 
            // txtYas
            // 
            this.txtYas.Location = new System.Drawing.Point(178, 127);
            this.txtYas.Multiline = true;
            this.txtYas.Name = "txtYas";
            this.txtYas.Size = new System.Drawing.Size(169, 29);
            this.txtYas.TabIndex = 3;
            // 
            // lblDeriKivrimi
            // 
            this.lblDeriKivrimi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDeriKivrimi.AutoSize = true;
            this.lblDeriKivrimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDeriKivrimi.Location = new System.Drawing.Point(3, 310);
            this.lblDeriKivrimi.Name = "lblDeriKivrimi";
            this.lblDeriKivrimi.Size = new System.Drawing.Size(169, 62);
            this.lblDeriKivrimi.TabIndex = 17;
            this.lblDeriKivrimi.Text = "       Deri Kıvrımı:";
            // 
            // lblProtokol
            // 
            this.lblProtokol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProtokol.AutoSize = true;
            this.lblProtokol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProtokol.Location = new System.Drawing.Point(3, 248);
            this.lblProtokol.Name = "lblProtokol";
            this.lblProtokol.Size = new System.Drawing.Size(169, 62);
            this.lblProtokol.TabIndex = 16;
            this.lblProtokol.Text = "         Protokol:";
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCinsiyet.Location = new System.Drawing.Point(3, 186);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(169, 62);
            this.lblCinsiyet.TabIndex = 15;
            this.lblCinsiyet.Text = "     Cinsiyet (E / K):";
            // 
            // lblYas
            // 
            this.lblYas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblYas.AutoSize = true;
            this.lblYas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYas.Location = new System.Drawing.Point(3, 124);
            this.lblYas.Name = "lblYas";
            this.lblYas.Size = new System.Drawing.Size(169, 62);
            this.lblYas.TabIndex = 14;
            this.lblYas.Text = "            Yaş:";
            // 
            // lblSoyad
            // 
            this.lblSoyad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.Location = new System.Drawing.Point(3, 62);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(169, 62);
            this.lblSoyad.TabIndex = 13;
            this.lblSoyad.Text = "          Soyad:";
            // 
            // txtDeriKivrimi
            // 
            this.txtDeriKivrimi.Location = new System.Drawing.Point(178, 313);
            this.txtDeriKivrimi.Multiline = true;
            this.txtDeriKivrimi.Name = "txtDeriKivrimi";
            this.txtDeriKivrimi.Size = new System.Drawing.Size(169, 29);
            this.txtDeriKivrimi.TabIndex = 6;
            // 
            // txtVucutYogunlugu
            // 
            this.txtVucutYogunlugu.Location = new System.Drawing.Point(178, 375);
            this.txtVucutYogunlugu.Multiline = true;
            this.txtVucutYogunlugu.Name = "txtVucutYogunlugu";
            this.txtVucutYogunlugu.Size = new System.Drawing.Size(169, 29);
            this.txtVucutYogunlugu.TabIndex = 8;
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Location = new System.Drawing.Point(178, 189);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(169, 28);
            this.cmbCinsiyet.TabIndex = 24;
            // 
            // lblVucutYogunlugu
            // 
            this.lblVucutYogunlugu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVucutYogunlugu.AutoSize = true;
            this.lblVucutYogunlugu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVucutYogunlugu.Location = new System.Drawing.Point(3, 372);
            this.lblVucutYogunlugu.Name = "lblVucutYogunlugu";
            this.lblVucutYogunlugu.Size = new System.Drawing.Size(169, 53);
            this.lblVucutYogunlugu.TabIndex = 18;
            this.lblVucutYogunlugu.Text = "   Vücut Yoğunluğu:";
            // 
            // lblAd
            // 
            this.lblAd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.Location = new System.Drawing.Point(3, 0);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(169, 62);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "            Ad:";
            // 
            // lblKisiAra
            // 
            this.lblKisiAra.AutoSize = true;
            this.lblKisiAra.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKisiAra.Location = new System.Drawing.Point(376, 86);
            this.lblKisiAra.Name = "lblKisiAra";
            this.lblKisiAra.Size = new System.Drawing.Size(60, 18);
            this.lblKisiAra.TabIndex = 12;
            this.lblKisiAra.Text = "Kişi Ara:";
            // 
            // txtKisiAra
            // 
            this.txtKisiAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKisiAra.Location = new System.Drawing.Point(376, 114);
            this.txtKisiAra.Multiline = true;
            this.txtKisiAra.Name = "txtKisiAra";
            this.txtKisiAra.Size = new System.Drawing.Size(153, 28);
            this.txtKisiAra.TabIndex = 11;
            this.txtKisiAra.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // grpFiltre
            // 
            this.grpFiltre.Controls.Add(this.lblToplam);
            this.grpFiltre.Controls.Add(this.rdbSifirla);
            this.grpFiltre.Controls.Add(this.lblErkek);
            this.grpFiltre.Controls.Add(this.rdbKadinUyeler);
            this.grpFiltre.Controls.Add(this.lblKadin);
            this.grpFiltre.Controls.Add(this.rdbErkekUyeler);
            this.grpFiltre.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFiltre.Location = new System.Drawing.Point(1235, 148);
            this.grpFiltre.Name = "grpFiltre";
            this.grpFiltre.Size = new System.Drawing.Size(218, 213);
            this.grpFiltre.TabIndex = 22;
            this.grpFiltre.TabStop = false;
            this.grpFiltre.Text = "Bilgiler ve Filtreler";
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplam.Location = new System.Drawing.Point(6, 40);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(141, 19);
            this.lblToplam.TabIndex = 15;
            this.lblToplam.Text = "Toplam Üye Sayısı:";
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
            this.rdbSifirla.CheckedChanged += new System.EventHandler(this.rdbSifirla_CheckedChanged);
            // 
            // lblErkek
            // 
            this.lblErkek.AutoSize = true;
            this.lblErkek.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblErkek.Location = new System.Drawing.Point(6, 59);
            this.lblErkek.Name = "lblErkek";
            this.lblErkek.Size = new System.Drawing.Size(130, 19);
            this.lblErkek.TabIndex = 16;
            this.lblErkek.Text = "Erkek Üye Sayısı:";
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
            this.rdbKadinUyeler.CheckedChanged += new System.EventHandler(this.rdbKadinlar_CheckedChanged);
            // 
            // lblKadin
            // 
            this.lblKadin.AutoSize = true;
            this.lblKadin.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKadin.Location = new System.Drawing.Point(6, 78);
            this.lblKadin.Name = "lblKadin";
            this.lblKadin.Size = new System.Drawing.Size(131, 19);
            this.lblKadin.TabIndex = 17;
            this.lblKadin.Text = "Kadın Üye Sayısı:";
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
            this.rdbErkekUyeler.CheckedChanged += new System.EventHandler(this.rdbErkekler_CheckedChanged_1);
            // 
            // pictLogo
            // 
            this.pictLogo.Image = global::kurtarma.Properties.Resources.skinfold_logo;
            this.pictLogo.Location = new System.Drawing.Point(12, 12);
            this.pictLogo.Name = "pictLogo";
            this.pictLogo.Size = new System.Drawing.Size(73, 50);
            this.pictLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictLogo.TabIndex = 6;
            this.pictLogo.TabStop = false;
            // 
            // KayitDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 638);
            this.Controls.Add(this.grpFiltre);
            this.Controls.Add(this.lblKisiAra);
            this.Controls.Add(this.txtKisiAra);
            this.Controls.Add(this.grpKayitDuzen);
            this.Controls.Add(this.dgwKayitlar);
            this.Controls.Add(this.btnKayitlaraGeriDon);
            this.Controls.Add(this.btnKayitDuzenle);
            this.Controls.Add(this.pictLogo);
            this.Name = "KayitDuzenle";
            this.Text = "KayitDuzenle";
            this.Load += new System.EventHandler(this.KayitDuzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwKayitlar)).EndInit();
            this.grpKayitDuzen.ResumeLayout(false);
            this.tableKayitDuzen.ResumeLayout(false);
            this.tableKayitDuzen.PerformLayout();
            this.grpFiltre.ResumeLayout(false);
            this.grpFiltre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictLogo;
        private System.Windows.Forms.Button btnKayitlaraGeriDon;
        private System.Windows.Forms.Button btnKayitDuzenle;
        private System.Windows.Forms.DataGridView dgwKayitlar;
        private System.Windows.Forms.GroupBox grpKayitDuzen;
        private System.Windows.Forms.TableLayoutPanel tableKayitDuzen;
        private System.Windows.Forms.TextBox txtUyeNo;
        private System.Windows.Forms.Label lblUyeNo;
        private System.Windows.Forms.ComboBox cmbProtokol;
        private System.Windows.Forms.TextBox txtYas;
        private System.Windows.Forms.Label lblDeriKivrimi;
        private System.Windows.Forms.Label lblProtokol;
        private System.Windows.Forms.Label lblCinsiyet;
        private System.Windows.Forms.Label lblYas;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.TextBox txtDeriKivrimi;
        private System.Windows.Forms.TextBox txtVucutYogunlugu;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.Label lblVucutYogunlugu;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label lblKisiAra;
        private System.Windows.Forms.TextBox txtKisiAra;
        private System.Windows.Forms.GroupBox grpFiltre;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.RadioButton rdbSifirla;
        private System.Windows.Forms.Label lblErkek;
        private System.Windows.Forms.RadioButton rdbKadinUyeler;
        private System.Windows.Forms.Label lblKadin;
        private System.Windows.Forms.RadioButton rdbErkekUyeler;
    }
}