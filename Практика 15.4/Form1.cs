using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практика_15._4
{
    public partial class Form1 : Form
    {
        private int popytki;
        private  Point v;
        private static Random r;

        public Form1()
        {
            InitializeComponent();
            popytki = 0;
            r = new Random();
            v = label2.Location;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            popytki++;
            if (r.Next(10) == int.Parse(textBox1.Text))
            {
                label2.Text = "Угадал. Коэффициент невезучести равен " + popytki / 10.0;
                popytki = 0;
                label2.Location = v;
            }
            else
            {
                label2.Text = "Не угадал";
                Point a = label2.Location;
                a.X += 5;
                label2.Location = a;
            }
        }
    }
}
