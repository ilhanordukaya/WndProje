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
    public partial class FormSecenek : Form
    {
        public FormSecenek()
        {
            InitializeComponent();
        }

       

        private void ekleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void bulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void listeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ekleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormSube formSube = new FormSube();
            formSube.Show();
        }

        private void bulToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormSube formSube = new FormSube();
            formSube.Show();

        }

        private void güncelleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormSube formSube = new FormSube();
            formSube.Show();
        }

        private void silToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormSube formSube = new FormSube();
            formSube.Show();
        }

        private void listeleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormSube formSube = new FormSube();
            formSube.Show();
        }
    }
}
