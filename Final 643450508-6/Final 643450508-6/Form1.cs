using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_643450508_6
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
            int total = 0;
            if (foodbox1.Text!= "")
        
               total +=Convert.ToInt32(foodbox1.Text) * 35;

            if (foodbox2.Text != "")

                total += Convert.ToInt32(foodbox2.Text) * 40;

            if (foodbox3.Text != "")

                total += Convert.ToInt32(foodbox3.Text) * 50;

            if (foodbox4.Text != "")

                total += Convert.ToInt32(foodbox4.Text) * 40;

            if (foodbox5.Text != "")

                total += Convert.ToInt32(foodbox5.Text) * 5;

            if (foodbox6.Text != "")

                total += Convert.ToInt32(foodbox6.Text) * 10;

            pricebox1.Text = total.ToString();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
