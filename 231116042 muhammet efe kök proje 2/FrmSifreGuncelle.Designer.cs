namespace _231116042_muhammet_efe_kök_proje_2
{
    partial class FrmSifreGuncelle
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
            this.txtGiris = new System.Windows.Forms.Button();
            this.txtsfire = new System.Windows.Forms.TextBox();
            this.txtKulAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtGiris
            // 
            this.txtGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGiris.Location = new System.Drawing.Point(292, 204);
            this.txtGiris.Name = "txtGiris";
            this.txtGiris.Size = new System.Drawing.Size(100, 29);
            this.txtGiris.TabIndex = 9;
            this.txtGiris.Text = "Giriş Yap";
            this.txtGiris.UseVisualStyleBackColor = true;
            this.txtGiris.Click += new System.EventHandler(this.txtGiris_Click);
            // 
            // txtsfire
            // 
            this.txtsfire.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsfire.Location = new System.Drawing.Point(292, 173);
            this.txtsfire.Name = "txtsfire";
            this.txtsfire.Size = new System.Drawing.Size(100, 24);
            this.txtsfire.TabIndex = 8;
            this.txtsfire.UseSystemPasswordChar = true;
            // 
            // txtKulAd
            // 
            this.txtKulAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKulAd.Location = new System.Drawing.Point(292, 143);
            this.txtKulAd.Name = "txtKulAd";
            this.txtKulAd.Size = new System.Drawing.Size(100, 24);
            this.txtKulAd.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(237, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(163, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // FrmSifreGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(621, 447);
            this.Controls.Add(this.txtGiris);
            this.Controls.Add(this.txtsfire);
            this.Controls.Add(this.txtKulAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmSifreGuncelle";
            this.Text = "FrmSifreGuncelle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button txtGiris;
        private System.Windows.Forms.TextBox txtsfire;
        private System.Windows.Forms.TextBox txtKulAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}