using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad_3_samopodgotovka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //условието е: при старане на формата в таблицата се попълва квадратна матрица 3х3 с произволни числа от 1 до 9, в текстбокса се пише число n от 1
            //     до 9, при натискане на бутона, числата от матрицата се умножават по n и матрицата се транспонира
            //       не трябва да се правят допълнителни проверки за празни или невярно въведени данни
            // 1,1 | 1,2 | 1,3
            //-----------------
            // 2,1 | 2,2 | 2,3
            //-----------------
            // 3,1 | 3,2 | 3,3

            int n = int.Parse(textBox1.Text);//числото n в променлива
            List<int> list = new List<int>();//списък за запазване на елементите може и с масив но е малко по различно
            for (int row = 0; row < 3; row++)//3 е броя на редовете става и с dataGridView1.RowCount-1
            {
                for (int col = 0; col < 3; col++)
                {
                    list.Add(int.Parse(dataGridView1[col, row].Value.ToString()));//запазваме в списъка всички елементи от матрицата 
                    // 1,1 ; 1,2 ; 1,3 ; 2,1 ; 2,2 ; 2,3 ; 3,1 ; 3,2 ; 3,3
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                list[i] = list[i] * n;
                //умножаваме всяко число по n
            }
            int br = 0;//брояч за достъп до елементите на списъка
            for (int col = 0; col < 3; col++)// започваме от колоната защото трябва да се транспонира матрицата
            {
                for (int row = 0; row < 3; row++)
                {
                    dataGridView1[col, row].Value = list[br++];//елементите от списъка се запазват в таблицата
                    //1,1 ; 2,1 ; 3,1 ; 1,2 ; 2,2 ; 3,2 ; 1,3 ; 2,3 ; 3,3
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rand = new Random();//променлива за произволно число
            for (int row = 0; row <3; row++)//брой редове=3  
            {
                dataGridView1.Rows.Add();//добавя нов ред в таблицата за да го запълни
                for (int col = 0; col < 3; col++)//брой колони=3
                {
                    dataGridView1[col, row].Value = rand.Next(1, 10);// произволно число от 1 до 9 матрицата се запълва по редове 
                }
            }
        }
    }
}
