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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] goriva = { "Бензин", "Дизел", "Газ", "Метан" };
            string[] tip = { "Лек", "Товарен", "Автобус", "Мотоциклет", "Друг" };
            FileStream f = new FileStream("PETROL.DAT", FileMode.OpenOrCreate);
            BinaryReader br = new BinaryReader(f);
            int count = 0;
            while (f.Position<f.Length)
            {
                string rn = br.ReadString();
                int vid = br.ReadInt32();
                int gor = br.ReadInt32();
                double cena = br.ReadDouble();
                double litri = br.ReadDouble();
                dataGridView1.Rows.Add(++count, rn, tip[vid], goriva[gor], litri, cena, cena * litri);
            }
            f.Close();
            br.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
