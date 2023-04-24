using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_form_play
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int min = 100, max = 999, counter = 10, number = 0;
            number = (min + max) / 2;

            Random rd = new Random();
            int rnd = rd.Next(100, 999);


            while (number != rnd)
            {
                if (number > rnd)
                {
                    max = number; number = (number + min) / 2;
                }
                else if (number < rnd)
                {
                    min = number; number = (number + max) / 2;
                }
                listBox1.Items.Add(number);
                counter--;
                label1.Text = "round : " + counter.ToString();
            }
            label2.Text = "random number: " + number;
            button1.Enabled = false;

        }
    }
}
       