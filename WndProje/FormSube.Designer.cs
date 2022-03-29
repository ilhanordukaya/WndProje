namespace WndProje
{
    partial class FormSube
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
            this.lblsubeID = new System.Windows.Forms.Label();
            this.lblsubeAd = new System.Windows.Forms.Label();
            this.txt_ssubeid = new System.Windows.Forms.TextBox();
            this.txt_ssubeAd = new System.Windows.Forms.TextBox();
            this.btn_ssubeEkle = new System.Windows.Forms.Button();
            this.btn_subeBul = new System.Windows.Forms.Button();
            this.btn_subeGuncelle = new System.Windows.Forms.Button();
            this.btn_subeSil = new System.Windows.Forms.Button();
            this.btn_subeListele = new System.Windows.Forms.Button();
            this.dataGridSubeler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSubeler)).BeginInit();
            this.SuspendLayout();
            // 
            // lblsubeID
            // 
            this.lblsubeID.AutoSize = true;
            this.lblsubeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsubeID.Location = new System.Drawing.Point(34, 42);
            this.lblsubeID.Name = "lblsubeID";
            this.lblsubeID.Size = new System.Drawing.Size(60, 17);
            this.lblsubeID.TabIndex = 0;
            this.lblsubeID.Text = "ŞubeID";
            // 
            // lblsubeAd
            // 
            this.lblsubeAd.AutoSize = true;
            this.lblsubeAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsubeAd.Location = new System.Drawing.Point(34, 76);
            this.lblsubeAd.Name = "lblsubeAd";
            this.lblsubeAd.Size = new System.Drawing.Size(64, 17);
            this.lblsubeAd.TabIndex = 1;
            this.lblsubeAd.Text = "ŞubeAd";
            // 
            // txt_ssubeid
            // 
            this.txt_ssubeid.Location = new System.Drawing.Point(138, 42);
            this.txt_ssubeid.Name = "txt_ssubeid";
            this.txt_ssubeid.Size = new System.Drawing.Size(110, 22);
            this.txt_ssubeid.TabIndex = 2;
            // 
            // txt_ssubeAd
            // 
            this.txt_ssubeAd.Location = new System.Drawing.Point(138, 76);
            this.txt_ssubeAd.Name = "txt_ssubeAd";
            this.txt_ssubeAd.Size = new System.Drawing.Size(110, 22);
            this.txt_ssubeAd.TabIndex = 3;
            // 
            // btn_ssubeEkle
            // 
            this.btn_ssubeEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ssubeEkle.Location = new System.Drawing.Point(315, 36);
            this.btn_ssubeEkle.Name = "btn_ssubeEkle";
            this.btn_ssubeEkle.Size = new System.Drawing.Size(112, 28);
            this.btn_ssubeEkle.TabIndex = 4;
            this.btn_ssubeEkle.Text = "Ekle";
            this.btn_ssubeEkle.UseVisualStyleBackColor = true;
            this.btn_ssubeEkle.Click += new System.EventHandler(this.btn_ssubeEkle_Click);
            // 
            // btn_subeBul
            // 
            this.btn_subeBul.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_subeBul.Location = new System.Drawing.Point(315, 70);
            this.btn_subeBul.Name = "btn_subeBul";
            this.btn_subeBul.Size = new System.Drawing.Size(112, 28);
            this.btn_subeBul.TabIndex = 5;
            this.btn_subeBul.Text = "Bul";
            this.btn_subeBul.UseVisualStyleBackColor = true;
            this.btn_subeBul.Click += new System.EventHandler(this.btn_subeBul_Click);
            // 
            // btn_subeGuncelle
            // 
            this.btn_subeGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_subeGuncelle.Location = new System.Drawing.Point(315, 99);
            this.btn_subeGuncelle.Name = "btn_subeGuncelle";
            this.btn_subeGuncelle.Size = new System.Drawing.Size(112, 34);
            this.btn_subeGuncelle.TabIndex = 6;
            this.btn_subeGuncelle.Text = "Güncelle";
            this.btn_subeGuncelle.UseVisualStyleBackColor = true;
            this.btn_subeGuncelle.Click += new System.EventHandler(this.btn_subeGuncelle_Click);
            // 
            // btn_subeSil
            // 
            this.btn_subeSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_subeSil.Location = new System.Drawing.Point(315, 139);
            this.btn_subeSil.Name = "btn_subeSil";
            this.btn_subeSil.Size = new System.Drawing.Size(112, 36);
            this.btn_subeSil.TabIndex = 7;
            this.btn_subeSil.Text = "Sil";
            this.btn_subeSil.UseVisualStyleBackColor = true;
            this.btn_subeSil.Click += new System.EventHandler(this.btn_subeSil_Click);
            // 
            // btn_subeListele
            // 
            this.btn_subeListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_subeListele.Location = new System.Drawing.Point(315, 181);
            this.btn_subeListele.Name = "btn_subeListele";
            this.btn_subeListele.Size = new System.Drawing.Size(112, 34);
            this.btn_subeListele.TabIndex = 8;
            this.btn_subeListele.Text = "Listele";
            this.btn_subeListele.UseVisualStyleBackColor = true;
            this.btn_subeListele.Click += new System.EventHandler(this.btn_subeListele_Click);
            // 
            // dataGridSubeler
            // 
            this.dataGridSubeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSubeler.Location = new System.Drawing.Point(37, 266);
            this.dataGridSubeler.Name = "dataGridSubeler";
            this.dataGridSubeler.RowHeadersWidth = 51;
            this.dataGridSubeler.RowTemplate.Height = 24;
            this.dataGridSubeler.Size = new System.Drawing.Size(348, 150);
            this.dataGridSubeler.TabIndex = 9;
            // 
            // FormSube
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridSubeler);
            this.Controls.Add(this.btn_subeListele);
            this.Controls.Add(this.btn_subeSil);
            this.Controls.Add(this.btn_subeGuncelle);
            this.Controls.Add(this.btn_subeBul);
            this.Controls.Add(this.btn_ssubeEkle);
            this.Controls.Add(this.txt_ssubeAd);
            this.Controls.Add(this.txt_ssubeid);
            this.Controls.Add(this.lblsubeAd);
            this.Controls.Add(this.lblsubeID);
            this.Name = "FormSube";
            this.Text = "FormSube";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSubeler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblsubeID;
        private System.Windows.Forms.Label lblsubeAd;
        private System.Windows.Forms.TextBox txt_ssubeid;
        private System.Windows.Forms.TextBox txt_ssubeAd;
        private System.Windows.Forms.Button btn_ssubeEkle;
        private System.Windows.Forms.Button btn_subeBul;
        private System.Windows.Forms.Button btn_subeGuncelle;
        private System.Windows.Forms.Button btn_subeSil;
        private System.Windows.Forms.Button btn_subeListele;
        private System.Windows.Forms.DataGridView dataGridSubeler;
    }
}