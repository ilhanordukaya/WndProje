using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WndProje
{
    public partial class FormGecis : Form
    {
        public FormGecis()
        {
            InitializeComponent();
        }

        private void btn_gecis_Click(object sender, EventArgs e)
        {
            FormSecenek formSecenek = new FormSecenek();
            formSecenek.Show();
                      
        }
    }
}
