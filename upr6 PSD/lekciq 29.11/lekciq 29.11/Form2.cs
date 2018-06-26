using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace lekciq_29._11
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length>0 && textBox2.Text!="" && textBox3.Text!="")
            {
                FileStream fs = new FileStream("PETROL.DAT", FileMode.Append);
                BinaryWriter bw = new BinaryWriter(fs);

                string rn = textBox1.Text.ToUpper();
                int mps = comboBox1.SelectedIndex;
                int oil = comboBox2.SelectedIndex;
                double cena = double.Parse(textBox2.Text);
                double litri = double.Parse(textBox3.Text);

                bw.Write(rn);
                bw.Write(mps);
                bw.Write(oil);
                bw.Write(cena);
                bw.Write(litri);
                fs.Close();
                bw.Close();
                MessageBox.Show("Данните са записани успешно !");

            }
            else
            {
                MessageBox.Show("Липсват попълнени данни!");
                textBox1.Focus();
            }
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            textBox1.Text = "Въведете рег.№";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Length>0)
            {
                double cena = double.Parse(textBox2.Text);
                double kol = double.Parse(textBox3.Text);
                double suma = kol*cena;
                label6.Text = "СУМА :" + suma + " лв.";
            }
            else
            {
                MessageBox.Show("Въведете количество");
                textBox3.Focus();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    textBox2.Text = "1,83";
                    break;
                case 1:
                    textBox2.Text = "2,05";
                    break;
                case 2:
                    textBox2.Text = "0,90";
                    break;
                case 3:
                    textBox2.Text = "1,70";
                    break;
            }
        }
    }
}
