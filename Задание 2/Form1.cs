using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            long a = Convert.ToInt64(textBox1.Text);
            long b = Convert.ToInt64(textBox2.Text);
            long c = Convert.ToInt64(textBox3.Text);
            long d = Convert.ToInt64(textBox4.Text);
            if ((a > b && a > c && a > d)&&(a % 2 == 0))
                MessageBox.Show("Наибольшее четное число: " + a.ToString());
            else
                if ((b > a && b > c && b > d)&& (b % 2 == 0))
                MessageBox.Show("Наибольшее четное число: " + b.ToString());
            else
                if ((c > a && c > b && c > d)&& (c % 2 == 0))
                MessageBox.Show("Наибольшее четное число: " + c.ToString());
            else
                if ((d > a && d > b && d > c)&& (d % 2 == 0))
                MessageBox.Show("Наибольшее четное число: " + d.ToString());
            else
                MessageBox.Show("not found");
        }    

        private void синийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor =Color.Blue;
            menuStrip1.BackColor = Color.Blue;
        }     

        private void красныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.Red;
            menuStrip1.BackColor = Color.Red;
        }

        private void оранжевыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.Orange;
            menuStrip1.BackColor = Color.Orange;
        }
        
        private void зелёныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.Green;
            menuStrip1.BackColor = Color.Green;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
