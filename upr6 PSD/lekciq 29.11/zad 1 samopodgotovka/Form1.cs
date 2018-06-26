using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad_1_samopodgotovka
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
            int n = int.Parse(textBox1.Text);
            if (n<1||n>100)
            {
                textBox1.Clear();
            }
            else
            for (int i = 1; i <= n; i++)
            {
                if (i%2==0)
                {
                    listBox1.Items.Add(i);
                }
            }
        }
    }
}
