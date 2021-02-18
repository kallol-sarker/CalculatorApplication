using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApplication
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((txtBoxResult.Text == "0") || (isOperationPerformed))
                txtBoxResult.Clear();
            isOperationPerformed = false;

            Button button1 = (Button)sender;
            if ( button1.Text == ".")
            {
                if (!txtBoxResult.Text.Contains("."))
                    txtBoxResult.Text = txtBoxResult.Text + button1.Text;
            }
            else
            txtBoxResult.Text = txtBoxResult.Text + button1.Text;
        }

        private void operatorClick(object sender, EventArgs e)
        {
            Button button1 = (Button)sender;

            if ( resultValue != 0)
            {
                button19.PerformClick();
                operationPerformed = button1.Text;
                lblOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }

            else
            {
                operationPerformed = button1.Text;
                resultValue = Double.Parse(txtBoxResult.Text);
                lblOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
            


        }

        private void btnClickCE(object sender, EventArgs e)
        {
            txtBoxResult.Text = "0";
            resultValue = 0;
        }

        private void btnClick_C(object sender, EventArgs e)
        {
            txtBoxResult.Text = "0";
            resultValue = 0;
        }

        private void btnEqual(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+": 
                    txtBoxResult.Text = (resultValue + Double.Parse(txtBoxResult.Text)).ToString();
                    break;

                case "-":
                    txtBoxResult.Text = (resultValue - Double.Parse(txtBoxResult.Text)).ToString();
                    break;

                case "*":
                    txtBoxResult.Text = (resultValue * Double.Parse(txtBoxResult.Text)).ToString();
                    break;

                case "/":
                    txtBoxResult.Text = (resultValue / Double.Parse(txtBoxResult.Text)).ToString();
                    break;
                default:
                    break;

            }
            resultValue = Double.Parse(txtBoxResult.Text);
            lblOperation.Text = " ";
        }
    }
}
