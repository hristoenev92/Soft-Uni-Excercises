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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // po uslovie ne e s button pravq go s button za da e po lesno inache trqbva da tyrsq tochniq event i da pravq izlishni proverki
            string tekst = textBox1.Text;//tekst vzima celiq string ot textbox1
            int suma = 0;// tova e za rezultata koito trqbva da izlieze v textbox2
            int br = 0;
            for (int i = 0; i < tekst.Length; i++)//vseki string e masiv ot charove vartim za vseki char ot tekst
            {
                if (tekst[i]=='0')//ako chara(cifrata) e 0 cikula spira
                {
                    break;
                }
                br++;
                suma += int.Parse(tekst[i].ToString());//ako cikula ne spre chara(cifrata) se sumira, .ToString() e zashtoto int.parse promenq stringove samo a tekst[i] e char
            }
            textBox2.Text = (suma/br).ToString();//kogato cikula svurshi textbox2 vzima sumata, .tostring e zashtoto textbox2.text e string a suma e int 
        }
    }
}
