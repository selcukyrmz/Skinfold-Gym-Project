namespace SkinFold_Gym_Project
{
    partial class Login
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
            this.pictBackgorund = new System.Windows.Forms.PictureBox();
            this.btnGiris = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictBackgorund)).BeginInit();
            this.SuspendLayout();
            // 
            // pictBackgorund
            // 
            this.pictBackgorund.BackColor = System.Drawing.Color.Transparent;
            this.pictBackgorund.Image = global::kurtarma.Properties.Resources.skinfold_logo;
            this.pictBackgorund.Location = new System.Drawing.Point(-47, -51);
            this.pictBackgorund.Name = "pictBackgorund";
            this.pictBackgorund.Size = new System.Drawing.Size(410, 397);
            this.pictBackgorund.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictBackgorund.TabIndex = 0;
            this.pictBackgorund.TabStop = false;
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.Transparent;
            this.btnGiris.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.ForeColor = System.Drawing.Color.Black;
            this.btnGiris.Location = new System.Drawing.Point(127, 258);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(62, 50);
            this.btnGiris.TabIndex = 1;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kurtarma.Properties.Resources.login_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1457, 716);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.pictBackgorund);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictBackgorund)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictBackgorund;
        private System.Windows.Forms.Button btnGiris;
    }
}