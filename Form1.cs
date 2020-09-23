using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SincronoAssincrono
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {}

        public void label1_Click(object sender, EventArgs e)
        {}

        public void textBox1_TextChanged(object sender, EventArgs e)
        {}

        public void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Increment(100);            

            Task.Delay(50000);

            if (progressBar1.Value == 100)
            {
                Task.Delay(999999999);
                Console.Beep();
                ((Button)sender).IsAccessible = true;
            }

        }

        public void label1_Click_1(object sender, EventArgs e)
        {}

        public void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {}

        public void progressBar1_Click(object sender, EventArgs e)
        {}

        public void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            Console.Beep(5000, 1000);
            progressBar1.Increment(100);

        }

        public void timer1_Tick(object sender, EventArgs e)
        {}
        private void bindingSource1_CurrentChanged_1(object sender, EventArgs e)
        {}       
    }
}