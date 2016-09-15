using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using org.mariuszgromada.math.mxparser;

namespace calculate001
{
    public partial class Calculate : Form
    {
        public Calculate()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Clears the text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtBoxMathEquation.Clear();
            this.lblResult.Text = "";
        }

        /// <summary>
        /// Calculate the math equation in the textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string input = "";
            if (this.txtBoxMathEquation.Text.ToString().Trim().Equals(""))
            {
                MessageBox.Show("Empty input");
                this.txtBoxMathEquation.Focus();
            }
            else
            {
                input = this.txtBoxMathEquation.Text.ToString().Trim();

                Expression mX = new Expression(input);
                String result = mX.calculate().ToString();

                if (result.ToString().Trim().ToLower().Equals("nan"))
                {
                    MessageBox.Show("Invalid Input");
                    this.txtBoxMathEquation.Text = "";
                    this.txtBoxMathEquation.Focus();
                }
                else
                {
                    //this.txtBoxMathEquation.Text = result;
                    this.lblResult.Text = "Equals: " + result;
                }
            }           
        }
    }
}
