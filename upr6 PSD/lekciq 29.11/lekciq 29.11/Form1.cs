using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lekciq_29._11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void справкиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void въвежданеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Сигурни ли сте?","Излизане",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Close();
            }
        }

        private void списъкНаДаннитеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form3().Show();
        }

        private void поВидМПСToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form4().Show();
        }

        private void данниToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void търсенеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form5().Show();
        }
    }
}
