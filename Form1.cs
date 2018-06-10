using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Regex;


namespace Calculator
{
    public partial class CalculatorForm : Form
    {
        double FirstNumber;
        double SecondNumber;
        double Result = 0;
        string Operation;
       

        public CalculatorForm()
        {
            InitializeComponent();

        }

        //button 1
        private void btn1_Click(object sender, EventArgs e)
        {

            // If value is 0, or empty, make it 1, otherwise add 1.

            if (txtValue.Text == "0" && txtValue.Text != null)
            {
                txtValue.Text = "1";
            }
            else
            {
                txtValue.Text = txtValue.Text + "1";
            }
        }

        // button 2
        private void btnN2_Click(object sender, EventArgs e)
        {
            if (txtValue.Text == "0" && txtValue.Text != null)
            {
                txtValue.Text = "2";
            }
            else
            {
                txtValue.Text = txtValue.Text + "2";
            }
        }

        // button 3
        private void btnN3_Click(object sender, EventArgs e)
        {
            if (txtValue.Text == "0" && txtValue.Text != null)
            {
                txtValue.Text = "3";
            }
            else
            {
                txtValue.Text = txtValue.Text + "3";
            }
        }

        // button 4
        private void btnN4_Click(object sender, EventArgs e)
        {
            if (txtValue.Text == "0" && txtValue.Text != null)
            {
                txtValue.Text = "4";
            }
            else
            {
                txtValue.Text = txtValue.Text + "4";
            }
        }

        // button 5
        private void btnN5_Click(object sender, EventArgs e)
        {
            if (txtValue.Text == "0" && txtValue.Text != null)
            {
                txtValue.Text = "5";
            }
            else
            {
                txtValue.Text = txtValue.Text + "5";
            }
        }

        // button 6
        private void btnN6_Click(object sender, EventArgs e)
        {
            if (txtValue.Text == "0" && txtValue.Text != null)
            {
                txtValue.Text = "6";
            }
            else
            {
                txtValue.Text = txtValue.Text + "6";
            }
        }

        // button 7
        private void btnN7_Click(object sender, EventArgs e)
        {
            if (txtValue.Text == "0" && txtValue.Text != null)
            {
                txtValue.Text = "7";
            }
            else
            {
                txtValue.Text = txtValue.Text + "7";
            }
        }

        // button 8
        private void btnN8_Click(object sender, EventArgs e)
        {
            if (txtValue.Text == "0" && txtValue.Text != null)
            {
                txtValue.Text = "8";
            }
            else
            {
                txtValue.Text = txtValue.Text + "8";
            }
        }

        // button 9
        private void btnN9_Click(object sender, EventArgs e)
        {
            if (txtValue.Text == "0" && txtValue.Text != null)
            {
                txtValue.Text = "9";
            }
            else
            {
                txtValue.Text = txtValue.Text + "9";
            }
        }

        // button 0
        private void btnN0_Click(object sender, EventArgs e)
        {
            txtValue.Text = txtValue.Text + "0";
        }


        // Add button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtValue.Text);
            txtValue.Text = "0";
            Operation = "+";
        }

        // Subtract button
        private void btnSub_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtValue.Text);
            txtValue.Text = "0";
            Operation = "-";
        }

        // Multiply button
        private void btnMul_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtValue.Text);
            txtValue.Text = "0";
            Operation = "*";
        }

        // Divide button
        private void btnDiv_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtValue.Text);
            txtValue.Text = "0";
            Operation = "/";
        }

        // Decimal button
        private void btnDecimal_Click(object sender, EventArgs e)
        {
         
            // Prevents more than one decimal being inserted
            if(txtValue.Text.Contains("."))
            {
                return;
            }
            else
            {
                // Add a decimal (if no decimal exists yet)

                txtValue.AppendText(".");

            }


        }

        // Equals button
        private void btnEqual_Click(object sender, EventArgs e)
        {
          

            SecondNumber = Convert.ToDouble(txtValue.Text);

            // add
            if (Operation=="+")
            {
                Result = (FirstNumber + SecondNumber);
                txtValue.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }

            // sub
            if (Operation == "-")
            {
                Result = (FirstNumber - SecondNumber);
                txtValue.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }

            // multiply
            if (Operation == "*")
            {
                Result = (FirstNumber * SecondNumber);
                txtValue.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }

            // divide
            if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    txtValue.Text = "Cannot divide by zero";
                }
                else
                {
                    Result = (FirstNumber / SecondNumber);
                    txtValue.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
            }

            /* For some reason, selecting the first value and pressing Equals will double the value.
            * So this stops that from happening.
            */
            
            if(SecondNumber == 0)
            {
                
                Result = FirstNumber;
                
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtValue.Text = "0";
            FirstNumber = 0;
            SecondNumber = 0;
            Result = 0;
        }

        private void txtValue_TextChanged(object sender, EventArgs e)
        {
            /* Try to prevent non-numerical characters, besides decimals.
             * Or just disable the textbox because Regex is giving problems.
            */

            //string previousInput = "";

            //Regex r = new Regex("^-{0,1}\d+\.{0,1}\d*$"); // This is the main part, can be altered to match any desired form or limitations
            //Match m = r.Match(txtValue.Text);
            //if (m.Success)
            //{
            //    previousInput = txtValue.Text;
            //}
            //else
            //{
            //    txtValue.Text = previousInput;
            //}


        }
    }
}

