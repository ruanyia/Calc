using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int flag;
        int num1;
        double results;
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(textBox1.Text);
            textBox1.Text = "";
            flag = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button btnOperator = (Button)sender;
            if (btnOperator.Text == "+")
            {
                num1 = int.Parse(textBox1.Text);
                textBox1.Text = "";
                flag = 0;
            }
            if (btnOperator.Text == "=") 
            {
                
                switch (flag) 
                {
                    case 0:
                        results = num1 / float.Parse(textBox1.Text);
                        break;
                    case 1:
                        results = num1 * float.Parse(textBox1.Text);
                        break;
                    case 2:
                        results = num1 + float.Parse(textBox1.Text);
                        break;
                    case 3:
                        results = num1 - float.Parse(textBox1.Text);
                        break;
                }
                textBox1.Text = Convert.ToString(results);
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btnOperator = (Button)sender;
            textBox1.Text = textBox1.Text + button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button btnOperator = (Button)sender;
            textBox1.Text = textBox1.Text + button2.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(textBox1.Text);
            textBox1.Text = "";
            flag = 1;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(textBox1.Text);
            textBox1.Text = "";
            flag = 2;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(textBox1.Text);
            textBox1.Text = "";
            flag = 3;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            flag = 100;
            num1 = 0;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button btnOperator = (Button)sender;
            textBox1.Text = textBox1.Text + button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button btnOperator = (Button)sender;
            textBox1.Text = textBox1.Text + button10.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button btnOperator = (Button)sender;
            textBox1.Text = textBox1.Text + button11.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button btnOperator = (Button)sender;
            textBox1.Text = textBox1.Text + button12.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Button btnOperator = (Button)sender;
            textBox1.Text = textBox1.Text + button13.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Button btnOperator = (Button)sender;
            textBox1.Text = textBox1.Text + button14.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Button btnOperator = (Button)sender;
            textBox1.Text = textBox1.Text + button15.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Button btnOperator = (Button)sender;
            textBox1.Text = textBox1.Text + button16.Text;
        }
   }
}
