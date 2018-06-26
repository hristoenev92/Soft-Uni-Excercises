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

        private void button1_Click(object sender, EventArgs e)
        {
            //ne slagam vsichki koloni v tablicata zashtoto nqma smislyl naimenovanie i tip sa si na mestata koito sa po uslnvie i samo te trqbvat realno
            listBox1.Items.Clear();//izchistva sudurjanieto na listbox
            string tip = textBox1.Text;//tip promelnivata za ravnenie
            for (int i = 0; i < dataGridView1.RowCount-1; i++)//i e rolqta na red ot tablicata zavyrtame cikula rowcount -1 zashtoto vinagi ima edin prazen red nakraq sled vyvejdane
            {
                string a = dataGridView1[1, i].Value.ToString();
                if (a==tip)//sravnqvame sydyrjanieto na kolontata tip s sydyrjanieto na texbox1 dataGridView1[kolona,red], broeneto zapochva ot 0 
                {
                    listBox1.Items.Add(dataGridView1[0, i].Value.ToString());//dobavq naimenovanieto v listboxa
                }
            }
        }
    }
}
