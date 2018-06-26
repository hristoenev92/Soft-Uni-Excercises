using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<int> list = new List<int>();
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int row = 0; row < 4; row++)
            {
                dataGridView1.Rows.Add();
                for (int col = 0; col < 4; col++)
                {
                    if (row==col||row+col==3)
                    {
                        dataGridView1[col, row].Value = 0;
                    }
                    else
                    {
                        dataGridView1[col, row].Value = 1;
                    }
                    list.Add(int.Parse(dataGridView1[col, row].Value.ToString()));
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            for (int i = 0; i < list.Count; i++)
            {
                list[i] += n;
            }
            int br = 0;
            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    dataGridView1[col, row].Value = list[br++];
                }
            }
        }
    }
}
