namespace OOPKutuphane
{
    partial class KitapEkle
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
            this.lblKitapTur = new System.Windows.Forms.Label();
            this.lblKitapAdi = new System.Windows.Forms.Label();
            this.lblYazar = new System.Windows.Forms.Label();
            this.lblKitapKodu = new System.Windows.Forms.Label();
            this.cmbxKitapTur = new System.Windows.Forms.ComboBox();
            this.txtbxKitapAdi = new System.Windows.Forms.TextBox();
            this.txtbxKitapKodu = new System.Windows.Forms.TextBox();
            this.cmbxYazar = new System.Windows.Forms.ComboBox();
            this.btnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKitapTur
            // 
            this.lblKitapTur.AutoSize = true;
            this.lblKitapTur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKitapTur.Location = new System.Drawing.Point(33, 36);
            this.lblKitapTur.Name = "lblKitapTur";
            this.lblKitapTur.Size = new System.Drawing.Size(78, 16);
            this.lblKitapTur.TabIndex = 0;
            this.lblKitapTur.Text = "Kitap Türü";
            // 
            // lblKitapAdi
            // 
            this.lblKitapAdi.AutoSize = true;
            this.lblKitapAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKitapAdi.Location = new System.Drawing.Point(33, 84);
            this.lblKitapAdi.Name = "lblKitapAdi";
            this.lblKitapAdi.Size = new System.Drawing.Size(70, 16);
            this.lblKitapAdi.TabIndex = 1;
            this.lblKitapAdi.Text = "Kitap Adı";
            // 
            // lblYazar
            // 
            this.lblYazar.AutoSize = true;
            this.lblYazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYazar.Location = new System.Drawing.Point(33, 132);
            this.lblYazar.Name = "lblYazar";
            this.lblYazar.Size = new System.Drawing.Size(48, 16);
            this.lblYazar.TabIndex = 2;
            this.lblYazar.Text = "Yazar";
            // 
            // lblKitapKodu
            // 
            this.lblKitapKodu.AutoSize = true;
            this.lblKitapKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKitapKodu.Location = new System.Drawing.Point(33, 180);
            this.lblKitapKodu.Name = "lblKitapKodu";
            this.lblKitapKodu.Size = new System.Drawing.Size(82, 16);
            this.lblKitapKodu.TabIndex = 3;
            this.lblKitapKodu.Text = "Kitap Kodu";
            // 
            // cmbxKitapTur
            // 
            this.cmbxKitapTur.FormattingEnabled = true;
            this.cmbxKitapTur.Location = new System.Drawing.Point(164, 35);
            this.cmbxKitapTur.Name = "cmbxKitapTur";
            this.cmbxKitapTur.Size = new System.Drawing.Size(121, 21);
            this.cmbxKitapTur.TabIndex = 4;
            this.cmbxKitapTur.SelectedIndexChanged += new System.EventHandler(this.cmbxKitapTur_SelectedIndexChanged);
            // 
            // txtbxKitapAdi
            // 
            this.txtbxKitapAdi.Location = new System.Drawing.Point(164, 83);
            this.txtbxKitapAdi.Name = "txtbxKitapAdi";
            this.txtbxKitapAdi.Size = new System.Drawing.Size(121, 20);
            this.txtbxKitapAdi.TabIndex = 5;
            this.txtbxKitapAdi.TextChanged += new System.EventHandler(this.txtbxKitapAdi_TextChanged);
            // 
            // txtbxKitapKodu
            // 
            this.txtbxKitapKodu.Location = new System.Drawing.Point(164, 179);
            this.txtbxKitapKodu.Name = "txtbxKitapKodu";
            this.txtbxKitapKodu.Size = new System.Drawing.Size(121, 20);
            this.txtbxKitapKodu.TabIndex = 6;
            // 
            // cmbxYazar
            // 
            this.cmbxYazar.FormattingEnabled = true;
            this.cmbxYazar.Location = new System.Drawing.Point(164, 131);
            this.cmbxYazar.Name = "cmbxYazar";
            this.cmbxYazar.Size = new System.Drawing.Size(121, 21);
            this.cmbxYazar.TabIndex = 7;
            this.cmbxYazar.SelectedIndexChanged += new System.EventHandler(this.cmbxYazar_SelectedIndexChanged);
            // 
            // btnButton
            // 
            this.btnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnButton.Location = new System.Drawing.Point(164, 219);
            this.btnButton.Name = "btnButton";
            this.btnButton.Size = new System.Drawing.Size(121, 26);
            this.btnButton.TabIndex = 8;
            this.btnButton.Text = "Ekle";
            this.btnButton.UseVisualStyleBackColor = true;
            this.btnButton.Click += new System.EventHandler(this.btnButton_Click);
            // 
            // KitapEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 334);
            this.Controls.Add(this.btnButton);
            this.Controls.Add(this.cmbxYazar);
            this.Controls.Add(this.txtbxKitapKodu);
            this.Controls.Add(this.txtbxKitapAdi);
            this.Controls.Add(this.cmbxKitapTur);
            this.Controls.Add(this.lblKitapKodu);
            this.Controls.Add(this.lblYazar);
            this.Controls.Add(this.lblKitapAdi);
            this.Controls.Add(this.lblKitapTur);
            this.Name = "KitapEkle";
            this.Text = "Kitap Ekle";
            this.Load += new System.EventHandler(this.KitapEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKitapTur;
        private System.Windows.Forms.Label lblKitapAdi;
        private System.Windows.Forms.Label lblYazar;
        private System.Windows.Forms.Label lblKitapKodu;
        private System.Windows.Forms.ComboBox cmbxKitapTur;
        private System.Windows.Forms.TextBox txtbxKitapAdi;
        private System.Windows.Forms.TextBox txtbxKitapKodu;
        private System.Windows.Forms.ComboBox cmbxYazar;
        private System.Windows.Forms.Button btnButton;
    }
}

