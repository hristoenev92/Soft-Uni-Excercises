using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellValuePushed(object sender, DataGridViewCellValueEventArgs e)
        {
            
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                if (dataGridView1[1,i].Value!=null)
                dataGridView1[2, i].Value = double.Parse(dataGridView1[1, i].Value.ToString()) * 1.2;
            }
        }

        private void dataGridView1_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal obshto = 0;
            for (int i = 0; i < dataGridView1.RowCount-1; i++)
            {
                obshto += decimal.Parse(dataGridView1[2, i].Value.ToString());
            }
            textBox1.Text = obshto.ToString();
        }
    }
}
