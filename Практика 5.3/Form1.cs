using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практика_5._3
{
    public partial class Form1 : Form
    {
        private bool f;
        public Form1()
        {
            InitializeComponent();
            f = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (f)
            {
                button1.Text = "Вы нажааааааааааааааааааааааааааааааааааааааааааааааааали меня";
                f = false;
            }
            else
                Close();
        }
    }
}
