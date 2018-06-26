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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] goriva = { "Бензин", "Дизел", "Газ", "Метан" };
            string[] tip = { "Лек", "Товарен", "Автобус", "Мотоциклет", "Друг" };
            FileStream f = new FileStream("PETROL.DAT", FileMode.OpenOrCreate);
            BinaryReader br = new BinaryReader(f);
            int count = 0;
            while (f.Position < f.Length)
            {
                string rn = br.ReadString();
                int vid = br.ReadInt32();
                int gor = br.ReadInt32();
                double cena = br.ReadDouble();
                double litri = br.ReadDouble();
                if (comboBox1.SelectedIndex==vid)
                {
                    dataGridView1.Rows.Add(++count, rn, goriva[gor], cena * litri);
                }
            }
            f.Close();
            br.Close();
        }

        private void comboBox1_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }
    }
}
