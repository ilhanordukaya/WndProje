using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WndProje.Model;
using WndProje.DbManeger;
using WndProje.DataB;
using System.Data.SqlClient;


namespace WndProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        
        private void Form1_Load(object sender, EventArgs e)
        {
            //tc ve musterino nun max kısıtları
            txt_tckmo.MaxLength = 11;
            txt_MusteriNo.MaxLength = 10;
            
            SubeMn mn = new SubeMn();
            var subelerad = mn.SubeListele().ToList();
            cmbx_subeid.DataSource = subelerad;
            cmbx_subeid.DisplayMember = "SubeAdı";
            cmbx_subeid.ValueMember = "SubeID";
            txt_SubeId.Text = "";

        }


        //veritabanına kayıt ekler
        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            Musteri musteriler = new Musteri();
            MusteriDb db = new MusteriDb();

            try
            {
                if (txt_ad.Text.Trim() != "" && txt_Soyad.Text.Trim() != "" )
                {
                    musteriler.MusteriTurID = int.Parse(txt_MusterturuId.Text);
                    musteriler.SubeID = int.Parse(txt_SubeId.Text);
                    musteriler.MusteriNo = txt_MusteriNo.Text;
                    musteriler.Ad = txt_ad.Text;
                    musteriler.SoyAd = txt_Soyad.Text;
                    musteriler.TckNO = txt_tckmo.Text;

                    db.MusteriEkle(musteriler); 
                }
                else
                {
                    MessageBox.Show("Satırlar Boş Geçilemez");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hatalı Bilgi Girişi");
            }
        }

        //veritabanına id yazilan kayıdı bulur
        private void btn_Bul_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txt_MusteriId.Text);
            MusteriDb db = new MusteriDb();
            Musteri musteriler = db.Ara(id);

            //txt_MusteriId = musteriler.MusteriID.ToString();
            txt_MusterturuId.Text = musteriler.MusteriTurID.ToString();
            txt_SubeId.Text = musteriler.SubeID.ToString();
            txt_MusteriNo.Text = musteriler.MusteriNo;
            txt_ad.Text = musteriler.Ad;
            txt_Soyad.Text = musteriler.SoyAd;
            txt_tckmo.Text = musteriler.TckNO;


        }

        //kayıtlı olan ve seçili olan bilgiyi gunceller
        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            //int id = int.Parse(txt_MusteriId.Text);
            MusteriDb db = new MusteriDb();
            Musteri musteriler = new Musteri();


            musteriler.MusteriID = int.Parse(txt_MusteriId.Text);
            musteriler.MusteriTurID = int.Parse(txt_MusterturuId.Text);
            musteriler.SubeID = int.Parse(txt_SubeId.Text);
            musteriler.MusteriNo = txt_MusteriNo.Text;
            musteriler.Ad = txt_ad.Text;
            musteriler.SoyAd = txt_Soyad.Text;
            musteriler.TckNO = txt_tckmo.Text;
            db.Guncelle(musteriler);

        }

        //veritabanından secili olan kayıtı siler
        private void btn_sil_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Emin misiniz?", "UYARI!!!", MessageBoxButtons.YesNo);
           
            int id = int.Parse(txt_MusteriId.Text);
            MusteriDb db = new MusteriDb();
            Musteri musteriler = new Musteri();
            db.Sil(id);


        }

        //veritabanındaki bilgileri listeler
        private void txt_listele_Click(object sender, EventArgs e)
        {
            MusteriDb db = new MusteriDb();
            dataGridView1.DataSource = db.Listele();
        }








        //Sadece sayı girilmesini ve bosluk karakter girilmemesini sağlıyoruz
        private void txt_tckmo_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }
        //Sadece sayı girilmesini ve bosluk karakter girilmemesini sağlıyoruz
        private void txt_MusteriNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            
            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }
        //textboxlardaki bilgi temizleyen mesaj
        public void Temizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox tbox = (TextBox)item;
                    tbox.Clear();
                }
            }

        }

        //textboxlardaki bilgi temizler
        private void txt_temizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

       
        //musteriturundeki kayıtların value değerlerini texboxa atar
        private void cmbx_musteriid_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedcmbox = cmbx_musteriid.SelectedItem.ToString();
            if (selectedcmbox.ToString() == "Gerçek Müşteri")
            {
                txt_MusterturuId.Text = "100";
                

            }
            else if (selectedcmbox.ToString() == "Tüzel Müşteri")
            {
                txt_MusterturuId.Text = "101";
            }
        }

        //subeturlerini  value değerlerini texboxa atar
        private void cmbx_subeid_SelectedIndexChanged(object sender, EventArgs e)
        {
                      
            txt_SubeId.Text = ((Sube)cmbx_subeid.SelectedItem).SubeID.ToString();
        }

        
        


        //tc girilirken 11 az karakter girilmemesini sağlar
        private void txt_tckmo_Leave(object sender, EventArgs e)
        {
            if (txt_tckmo.Text.Length!=11)
            {
                MessageBox.Show("11 Haneden Az Olamaz....");
            }
        }

        //musterino girilirken 11 az karakter girilmemesini sağlar
        private void txt_MusteriNo_Leave(object sender, EventArgs e)
        {
            if (txt_MusteriNo.Text.Length != 10)
            {
                MessageBox.Show("10 Haneden Az Olamaz....");
            }
        }

        
        

        //kayıtları yeniler
        private void btn_yenile_Click_1(object sender, EventArgs e)
        {
            MusteriDb db = new MusteriDb();
            dataGridView1.DataSource = db.Listele();
        }

        //back tusu
        private void btn_form1geri_Click(object sender, EventArgs e)
        {

            
            this.Close();
        }

        private void btn_form1Cık_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
