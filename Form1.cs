using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {

        Double resultvalue = 0;
        String operationperformed = "";
        bool isOperationPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((textBoxResult.Text == "0") || (isOperationPerformed))
                textBoxResult.Clear();

            isOperationPerformed = false ;

            //if(textBoxResult.Text == ".")
            //    {
            //    if(textBoxResult.Text.Contains("."))
            //    {
            //        textBoxResult.Text = textBoxResult.Text + button.Text;
            //    }
            //    else
            //    {
            //        textBoxResult.Text = textBoxResult.Text + button.Text;
            //    }
            //}

            Button button = (Button)sender;
            textBoxResult.Text = textBoxResult.Text + button.Text;
            
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operationperformed = button.Text;
            resultvalue = double.Parse(textBoxResult.Text);
            //labelCurrentOperation.Text = resultvalue +  " " + operationperformed  ;
            //labelCurrentOperation2.Text =  resultvalue.ToString();
            isOperationPerformed = true;
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";
            //labelCurrentOperation.Text = "";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";
            resultvalue = 0;
            //labelCurrentOperation.Text = "";
            //labelCurrentOperation2.Text = "";
        }

        private void buttonequalto_Click(object sender, EventArgs e)
        {
            switch(operationperformed)
            {
                case "+":
                    textBoxResult.Text = (resultvalue + double.Parse(textBoxResult.Text)).ToString();
                    break;
                case "-":
                    textBoxResult.Text = (resultvalue - double.Parse(textBoxResult.Text)).ToString();
                    break;
                case "*":
                    textBoxResult.Text = (resultvalue * double.Parse(textBoxResult.Text)).ToString();
                    break;
                case "/":
                    textBoxResult.Text = (resultvalue / double.Parse(textBoxResult.Text)).ToString();
                    break;
                default:
                    break;
            }
        }

        //private void labelCurrentOperation_Click(object sender, EventArgs e)
        //{

        //}
    }
}
