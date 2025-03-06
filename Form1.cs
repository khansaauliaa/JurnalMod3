using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JurnalMod3
{
    public partial class Form1 : Form
    {
        int a;
        int b;

        public Form1()
        {
            InitializeComponent();
        }
                                                                                                                                                                
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            output.Text = output.Text + "3";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            output.Text = output.Text + "9";

        }

        private void button11_Click(object sender, EventArgs e)
        {
            output.Text = output.Text + "6";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            output.Text = output.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            output.Text = output.Text + "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            output.Text = output.Text + "5";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            output.Text = output.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            output.Text = output.Text + "8";
        }

        private void output_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            output.Text = output.Text + "1";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = int.Parse(output.Text);
            output.Text = "+";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            b = int.Parse(output.Text);
            output.Text = (a + b).ToString();
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            output.Text = output.Text + "0";
        }
    }
}
