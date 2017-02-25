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
    public partial class Pradzia : Form
    {
        double value = 0;
        string oper = "";
        bool oper_pressed = false;

        public Pradzia()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0") || (oper_pressed))
                result.Clear();
            oper_pressed = false;
            Button b = (Button)sender;
            result.Text = result.Text + b.Text;
        }

        private void CE_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            value = Double.Parse(result.Text);
            oper = b.Text;
            oper_pressed = true;
            lygyba.Text = value + " " + oper;
        }

        private void Lygu_Click(object sender, EventArgs e)
        {
            lygyba.Text = "=";
            switch (oper)
            {
                case "+":
                    result.Text = (value + Double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value - Double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (value * Double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (value / Double.Parse(result.Text)).ToString();
                    break;
                default:
                    break;
            }
            oper_pressed = true;
      }

        private void C_Click(object sender, EventArgs e)
        {
            result.Clear();
            value = 0;
            result.Text = "0";
        }
    }
}
