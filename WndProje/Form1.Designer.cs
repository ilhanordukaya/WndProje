namespace WndProje
{
    partial class Form1
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
            this.lbl_MusteriId = new System.Windows.Forms.Label();
            this.lbl_müsteritürüid = new System.Windows.Forms.Label();
            this.lbl_Subeid = new System.Windows.Forms.Label();
            this.lbl_MusteriNo = new System.Windows.Forms.Label();
            this.lbl_ad = new System.Windows.Forms.Label();
            this.lbl_soyad = new System.Windows.Forms.Label();
            this.lbl_tc = new System.Windows.Forms.Label();
            this.txt_MusteriId = new System.Windows.Forms.TextBox();
            this.txt_MusterturuId = new System.Windows.Forms.TextBox();
            this.txt_SubeId = new System.Windows.Forms.TextBox();
            this.txt_MusteriNo = new System.Windows.Forms.TextBox();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.txt_Soyad = new System.Windows.Forms.TextBox();
            this.txt_tckmo = new System.Windows.Forms.TextBox();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.btn_Bul = new System.Windows.Forms.Button();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.txt_listele = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_temizle = new System.Windows.Forms.Button();
            this.cmbx_musteriid = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.cmbx_subeid = new System.Windows.Forms.ComboBox();
            this.btn_yenile = new System.Windows.Forms.Button();
            this.btn_form1geri = new System.Windows.Forms.Button();
            this.btn_form1Cık = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_MusteriId
            // 
            this.lbl_MusteriId.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lbl_MusteriId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MusteriId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_MusteriId.Location = new System.Drawing.Point(12, 27);
            this.lbl_MusteriId.Name = "lbl_MusteriId";
            this.lbl_MusteriId.Size = new System.Drawing.Size(113, 28);
            this.lbl_MusteriId.TabIndex = 0;
            this.lbl_MusteriId.Text = "MüşteriId";
            // 
            // lbl_müsteritürüid
            // 
            this.lbl_müsteritürüid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_müsteritürüid.Location = new System.Drawing.Point(12, 55);
            this.lbl_müsteritürüid.Name = "lbl_müsteritürüid";
            this.lbl_müsteritürüid.Size = new System.Drawing.Size(137, 28);
            this.lbl_müsteritürüid.TabIndex = 1;
            this.lbl_müsteritürüid.Text = "MüşteriTürüId";
            // 
            // lbl_Subeid
            // 
            this.lbl_Subeid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Subeid.Location = new System.Drawing.Point(12, 83);
            this.lbl_Subeid.Name = "lbl_Subeid";
            this.lbl_Subeid.Size = new System.Drawing.Size(113, 28);
            this.lbl_Subeid.TabIndex = 2;
            this.lbl_Subeid.Text = "ŞubeId";
            // 
            // lbl_MusteriNo
            // 
            this.lbl_MusteriNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MusteriNo.Location = new System.Drawing.Point(12, 111);
            this.lbl_MusteriNo.Name = "lbl_MusteriNo";
            this.lbl_MusteriNo.Size = new System.Drawing.Size(113, 28);
            this.lbl_MusteriNo.TabIndex = 3;
            this.lbl_MusteriNo.Text = "MüşteriNo";
            // 
            // lbl_ad
            // 
            this.lbl_ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ad.Location = new System.Drawing.Point(12, 139);
            this.lbl_ad.Name = "lbl_ad";
            this.lbl_ad.Size = new System.Drawing.Size(113, 28);
            this.lbl_ad.TabIndex = 4;
            this.lbl_ad.Text = "Ad";
            // 
            // lbl_soyad
            // 
            this.lbl_soyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_soyad.Location = new System.Drawing.Point(12, 167);
            this.lbl_soyad.Name = "lbl_soyad";
            this.lbl_soyad.Size = new System.Drawing.Size(113, 28);
            this.lbl_soyad.TabIndex = 5;
            this.lbl_soyad.Text = "Soyad";
            // 
            // lbl_tc
            // 
            this.lbl_tc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tc.Location = new System.Drawing.Point(12, 195);
            this.lbl_tc.Name = "lbl_tc";
            this.lbl_tc.Size = new System.Drawing.Size(113, 28);
            this.lbl_tc.TabIndex = 6;
            this.lbl_tc.Text = "TCKno";
            // 
            // txt_MusteriId
            // 
            this.txt_MusteriId.Location = new System.Drawing.Point(155, 27);
            this.txt_MusteriId.Name = "txt_MusteriId";
            this.txt_MusteriId.Size = new System.Drawing.Size(100, 22);
            this.txt_MusteriId.TabIndex = 7;
            // 
            // txt_MusterturuId
            // 
            this.txt_MusterturuId.Enabled = false;
            this.txt_MusterturuId.Location = new System.Drawing.Point(155, 55);
            this.txt_MusterturuId.Name = "txt_MusterturuId";
            this.txt_MusterturuId.Size = new System.Drawing.Size(100, 22);
            this.txt_MusterturuId.TabIndex = 8;
            // 
            // txt_SubeId
            // 
            this.txt_SubeId.Enabled = false;
            this.txt_SubeId.Location = new System.Drawing.Point(155, 83);
            this.txt_SubeId.Name = "txt_SubeId";
            this.txt_SubeId.Size = new System.Drawing.Size(100, 22);
            this.txt_SubeId.TabIndex = 9;
            // 
            // txt_MusteriNo
            // 
            this.txt_MusteriNo.Location = new System.Drawing.Point(155, 111);
            this.txt_MusteriNo.Name = "txt_MusteriNo";
            this.txt_MusteriNo.Size = new System.Drawing.Size(100, 22);
            this.txt_MusteriNo.TabIndex = 10;
            this.txt_MusteriNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_MusteriNo_KeyPress);
            this.txt_MusteriNo.Leave += new System.EventHandler(this.txt_MusteriNo_Leave);
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(155, 136);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(100, 22);
            this.txt_ad.TabIndex = 11;
            // 
            // txt_Soyad
            // 
            this.txt_Soyad.Location = new System.Drawing.Point(155, 164);
            this.txt_Soyad.Name = "txt_Soyad";
            this.txt_Soyad.Size = new System.Drawing.Size(100, 22);
            this.txt_Soyad.TabIndex = 12;
            // 
            // txt_tckmo
            // 
            this.txt_tckmo.Location = new System.Drawing.Point(155, 192);
            this.txt_tckmo.Name = "txt_tckmo";
            this.txt_tckmo.Size = new System.Drawing.Size(100, 22);
            this.txt_tckmo.TabIndex = 13;
            this.txt_tckmo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tckmo_KeyPress);
            this.txt_tckmo.Leave += new System.EventHandler(this.txt_tckmo_Leave);
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.AutoSize = true;
            this.btn_Ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ekle.Location = new System.Drawing.Point(509, 27);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(93, 33);
            this.btn_Ekle.TabIndex = 14;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // btn_Bul
            // 
            this.btn_Bul.AutoSize = true;
            this.btn_Bul.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Bul.Location = new System.Drawing.Point(509, 66);
            this.btn_Bul.Name = "btn_Bul";
            this.btn_Bul.Size = new System.Drawing.Size(93, 30);
            this.btn_Bul.TabIndex = 15;
            this.btn_Bul.Text = "Bul";
            this.btn_Bul.UseVisualStyleBackColor = true;
            this.btn_Bul.Click += new System.EventHandler(this.btn_Bul_Click);
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.AutoSize = true;
            this.btn_Guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guncelle.Location = new System.Drawing.Point(509, 102);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(93, 35);
            this.btn_Guncelle.TabIndex = 16;
            this.btn_Guncelle.Text = "Güncelle";
            this.btn_Guncelle.UseVisualStyleBackColor = true;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.AutoSize = true;
            this.btn_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sil.Location = new System.Drawing.Point(509, 143);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(93, 30);
            this.btn_sil.TabIndex = 17;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // txt_listele
            // 
            this.txt_listele.AutoSize = true;
            this.txt_listele.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_listele.Location = new System.Drawing.Point(509, 179);
            this.txt_listele.Name = "txt_listele";
            this.txt_listele.Size = new System.Drawing.Size(93, 30);
            this.txt_listele.TabIndex = 18;
            this.txt_listele.Text = "Listele";
            this.txt_listele.UseVisualStyleBackColor = true;
            this.txt_listele.Click += new System.EventHandler(this.txt_listele_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 308);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(709, 233);
            this.dataGridView1.TabIndex = 19;
            // 
            // txt_temizle
            // 
            this.txt_temizle.AutoSize = true;
            this.txt_temizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_temizle.Location = new System.Drawing.Point(509, 215);
            this.txt_temizle.Name = "txt_temizle";
            this.txt_temizle.Size = new System.Drawing.Size(93, 30);
            this.txt_temizle.TabIndex = 20;
            this.txt_temizle.Text = "Temizle";
            this.txt_temizle.UseVisualStyleBackColor = true;
            this.txt_temizle.Click += new System.EventHandler(this.txt_temizle_Click);
            // 
            // cmbx_musteriid
            // 
            this.cmbx_musteriid.FormattingEnabled = true;
            this.cmbx_musteriid.Items.AddRange(new object[] {
            "Gerçek Müşteri",
            "Tüzel Müşteri"});
            this.cmbx_musteriid.Location = new System.Drawing.Point(271, 57);
            this.cmbx_musteriid.Name = "cmbx_musteriid";
            this.cmbx_musteriid.Size = new System.Drawing.Size(121, 24);
            this.cmbx_musteriid.TabIndex = 21;
            this.cmbx_musteriid.SelectedIndexChanged += new System.EventHandler(this.cmbx_musteriid_SelectedIndexChanged);
            // 
            // cmbx_subeid
            // 
            this.cmbx_subeid.FormattingEnabled = true;
            this.cmbx_subeid.Location = new System.Drawing.Point(271, 87);
            this.cmbx_subeid.Name = "cmbx_subeid";
            this.cmbx_subeid.Size = new System.Drawing.Size(121, 24);
            this.cmbx_subeid.TabIndex = 22;
            this.cmbx_subeid.SelectedIndexChanged += new System.EventHandler(this.cmbx_subeid_SelectedIndexChanged);
            // 
            // btn_yenile
            // 
            this.btn_yenile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_yenile.Location = new System.Drawing.Point(631, 265);
            this.btn_yenile.Name = "btn_yenile";
            this.btn_yenile.Size = new System.Drawing.Size(93, 37);
            this.btn_yenile.TabIndex = 23;
            this.btn_yenile.Text = "Yenile";
            this.btn_yenile.UseVisualStyleBackColor = true;
            this.btn_yenile.Click += new System.EventHandler(this.btn_yenile_Click_1);
            // 
            // btn_form1geri
            // 
            this.btn_form1geri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_form1geri.Location = new System.Drawing.Point(866, 23);
            this.btn_form1geri.Name = "btn_form1geri";
            this.btn_form1geri.Size = new System.Drawing.Size(119, 41);
            this.btn_form1geri.TabIndex = 24;
            this.btn_form1geri.Text = "Geri";
            this.btn_form1geri.UseVisualStyleBackColor = true;
            this.btn_form1geri.Click += new System.EventHandler(this.btn_form1geri_Click);
            // 
            // btn_form1Cık
            // 
            this.btn_form1Cık.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_form1Cık.Location = new System.Drawing.Point(887, 485);
            this.btn_form1Cık.Name = "btn_form1Cık";
            this.btn_form1Cık.Size = new System.Drawing.Size(98, 52);
            this.btn_form1Cık.TabIndex = 25;
            this.btn_form1Cık.Text = "ÇIK";
            this.btn_form1Cık.UseVisualStyleBackColor = true;
            this.btn_form1Cık.Click += new System.EventHandler(this.btn_form1Cık_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(997, 549);
            this.Controls.Add(this.btn_form1Cık);
            this.Controls.Add(this.btn_form1geri);
            this.Controls.Add(this.btn_yenile);
            this.Controls.Add(this.cmbx_subeid);
            this.Controls.Add(this.cmbx_musteriid);
            this.Controls.Add(this.txt_temizle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_listele);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.btn_Bul);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.txt_tckmo);
            this.Controls.Add(this.txt_Soyad);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.txt_MusteriNo);
            this.Controls.Add(this.txt_SubeId);
            this.Controls.Add(this.txt_MusterturuId);
            this.Controls.Add(this.txt_MusteriId);
            this.Controls.Add(this.lbl_tc);
            this.Controls.Add(this.lbl_soyad);
            this.Controls.Add(this.lbl_ad);
            this.Controls.Add(this.lbl_MusteriNo);
            this.Controls.Add(this.lbl_Subeid);
            this.Controls.Add(this.lbl_müsteritürüid);
            this.Controls.Add(this.lbl_MusteriId);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_MusteriId;
        private System.Windows.Forms.Label lbl_müsteritürüid;
        private System.Windows.Forms.Label lbl_Subeid;
        private System.Windows.Forms.Label lbl_MusteriNo;
        private System.Windows.Forms.Label lbl_ad;
        private System.Windows.Forms.Label lbl_soyad;
        private System.Windows.Forms.Label lbl_tc;
        private System.Windows.Forms.TextBox txt_MusteriId;
        private System.Windows.Forms.TextBox txt_MusterturuId;
        private System.Windows.Forms.TextBox txt_SubeId;
        private System.Windows.Forms.TextBox txt_MusteriNo;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.TextBox txt_Soyad;
        private System.Windows.Forms.TextBox txt_tckmo;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.Button btn_Bul;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button txt_listele;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button txt_temizle;
        private System.Windows.Forms.ComboBox cmbx_musteriid;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ComboBox cmbx_subeid;
        private System.Windows.Forms.Button btn_yenile;
        private System.Windows.Forms.Button btn_form1geri;
        private System.Windows.Forms.Button btn_form1Cık;
    }
}

