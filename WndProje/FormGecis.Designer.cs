﻿namespace WndProje
{
    partial class FormGecis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGecis));
            this.btn_gecis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_gecis
            // 
            this.btn_gecis.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_gecis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gecis.Location = new System.Drawing.Point(741, 418);
            this.btn_gecis.Name = "btn_gecis";
            this.btn_gecis.Size = new System.Drawing.Size(160, 59);
            this.btn_gecis.TabIndex = 0;
            this.btn_gecis.Text = "Tam Üzerindesiniz";
            this.btn_gecis.UseVisualStyleBackColor = false;
            this.btn_gecis.Click += new System.EventHandler(this.btn_gecis_Click);
            // 
            // FormGecis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(985, 601);
            this.Controls.Add(this.btn_gecis);
            this.Name = "FormGecis";
            this.Text = "FormGecis";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_gecis;
    }
}