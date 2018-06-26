using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lekciq_29._11
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (textBox1.Text != "")
            {
                string[] imena = { "benzin", "dizel", "gaz" };
                FileStream f = new FileStream("Petrol.Dat", FileMode.OpenOrCreate);
                BinaryReader br = new BinaryReader(f);
                int count = 0;
                listBox1.Items.Add("reg. nom    vid MPS     Gorivo  Litri");
                listBox1.Items.Add("-----------------------------------------------");
                while (f.Position < f.Length)
                {
                    string rn = br.ReadString();
                    int vid = br.ReadInt32();
                    int gor = br.ReadInt32();
                    double cena = br.ReadDouble();
                    double litri = br.ReadDouble();
                    if (rn.Contains(textBox1.Text))
                    {
                        listBox1.Items.Add(rn+" "+vid+" "+imena[gor]+" ");
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
