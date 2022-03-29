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

namespace WndProje
{
    public partial class FormSube : Form
    {
        public FormSube()
        {
            InitializeComponent();
        }

        private void btn_ssubeEkle_Click(object sender, EventArgs e)
        {
             Sube subeler = new Sube();
            SubeMn mn = new SubeMn();

           
            subeler.SubeAdı = txt_ssubeAd.Text;
            

            mn.SubeEkle(subeler);
        }

        private void btn_subeListele_Click(object sender, EventArgs e)
        {
            SubeMn mn = new SubeMn();
            dataGridSubeler.DataSource = mn.SubeListele();
        }

        private void btn_subeBul_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txt_ssubeid.Text);
            SubeMn mn = new SubeMn();
            Sube subeler = mn.SubeAra(id);

            
            txt_ssubeAd.Text = subeler.SubeAdı;
            
        }

        private void btn_subeSil_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Emin misiniz?", "UYARI!!!", MessageBoxButtons.YesNo);

            int id = int.Parse(txt_ssubeid.Text);
            SubeMn mn = new SubeMn();
            Sube subeler = new Sube();
            mn.subeSil(id);
        }

        private void btn_subeGuncelle_Click(object sender, EventArgs e)
        {
            SubeMn mn = new SubeMn();
            Sube subeler = new Sube();


            subeler.SubeID = int.Parse(txt_ssubeid.Text);
            subeler.SubeAdı = txt_ssubeAd.Text;
            
            mn.subeGuncelle(subeler);
        }
    }
}
