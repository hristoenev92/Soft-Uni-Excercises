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
        
        private void BT1_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            LB1.Items.Clear();
            int[] number = TB1.Text.Split('.').Select(int.Parse).ToArray();
            int position = 0;
            for (int i = 0; i < number.Length; i++)
            {
                position = list.Count;
                for (int j = 0; j < 9; j++)
                {
                    if (number[i] > 0)
                    {
                        list.Insert(position, (number[i] % 2).ToString());
                        number[i] /= 2;
                    }
                    else
                    {
                        list.Insert(position, "0");
                    }
                }
                if (i==3)
                {
                    break;
                }
                list.Add(".");
            }
            LB1.Items.Add(string.Join("",list));
        }

        private void TB1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LB1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
