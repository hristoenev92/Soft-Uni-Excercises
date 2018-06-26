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

namespace zad_1_upr_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FileStream fs;
            if (!File.Exists(@"D:\mebeli.dat")) 
            {
                fs = new FileStream(@"D:\mebeli.dat", FileMode.Open);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write("Mechta");
                bw.Write("Spalnq");
                bw.Write("qvor");
                bw.Write(365.25);
                bw.Write(10);
                fs.Close();
            }
            fs = new FileStream(@"D:\mebeli.dat", FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            while (fs.Position < fs.Length)
            {
                string name = br.ReadString();
                string gr = br.ReadString();
                string pn = br.ReadString();
                double pr = br.ReadDouble();
                int st = br.ReadInt32();

                dataGridView1.Rows.Add(name, gr, pn, pr, st);
            }
            fs.Close();

        }

        private void dobavqneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddItems add = new AddItems();
            add.Show();
            Visible = false;

        }
    }
}
