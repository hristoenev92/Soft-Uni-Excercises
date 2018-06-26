using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad_2_samopodgotovka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (textBox1.Text==null)
            {
                for (int i = 0; i < dataGridView1.RowCount-1; i++)
                {
                    listBox1.Items.Add(dataGridView1[0, i].Value.ToString());
                }
            }
            int nomer = int.Parse(textBox1.Text);
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                int grupa = int.Parse(dataGridView1[2, i].Value.ToString());
                if (grupa==nomer)
                {
                    listBox1.Items.Add(dataGridView1[0, i].Value.ToString());
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
