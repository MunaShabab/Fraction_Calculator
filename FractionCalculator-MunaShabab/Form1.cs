using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FractionCalculator_MunaShabab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            int firstNumerator;
            int firstDenominator;
            int secondNumerator;
            int secondDenominator;
            if((int.TryParse(numerator1TextBox.Text,out firstNumerator))
                &&(int.TryParse(denominator1TextBox.Text,out firstDenominator))
                && (int.TryParse(numerator2TextBox.Text, out secondNumerator))
                && (int.TryParse(denominator2TextBox.Text, out secondDenominator)))
            {
                try
                {
                    Fraction firstFrsction = new Fraction(firstNumerator, firstDenominator);
                    Fraction secondFraction = new Fraction(secondNumerator, secondDenominator);
                    if (functionListBox.SelectedIndex == 0)
                    {
                        Fraction result = firstFrsction.Add(secondFraction);
                        resultNumeratorLable.Text = result.Numerator.ToString();
                        resultDenominatorLabel.Text = result.Denominator.ToString();
                        resultLabel.Text = result.ToDecimalString(3);
                    }
                    else if(functionListBox.SelectedIndex==1)
                    {
                        Fraction result = firstFrsction.Subtract(secondFraction);
                        resultNumeratorLable.Text = result.Numerator.ToString();
                        resultDenominatorLabel.Text = result.Denominator.ToString();
                        resultLabel.Text = result.ToDecimalString(3);
                    }
                    else if(functionListBox.SelectedIndex==2)
                    {
                        Fraction result = firstFrsction.Multiply(secondFraction);
                        resultNumeratorLable.Text = result.Numerator.ToString();
                        resultDenominatorLabel.Text = result.Denominator.ToString();
                        resultLabel.Text = result.ToDecimalString(3);
                        //just to tset the toMixedNumberString method
                        MessageBox.Show(result.ToMixedNumberString());
                    }
                    else if(functionListBox.SelectedIndex==3)
                    {
                        Fraction result = firstFrsction.Divide(secondFraction);
                        resultNumeratorLable.Text = result.Numerator.ToString();
                        resultDenominatorLabel.Text = result.Denominator.ToString();
                        resultLabel.Text = result.ToDecimalString(3);
                    }
                    else
                    {
                        MessageBox.Show("You must select an opertaion");
                    }
                }
                catch
                {
                    MessageBox.Show("Zero Denominator Not Permitted - Program Has Been Terminated");
                    this.Close();
                }
                
                

            }
            else
            {
                MessageBox.Show("One of the values entered is invalid, you must enter numbers only");

            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            numerator1TextBox.Text = "";
            denominator1TextBox.Text = "";
            numerator2TextBox.Text = "";
            denominator2TextBox.Text = "";
            functionListBox.SelectedIndex = -1;
            resultNumeratorLable.Text = "";
            resultDenominatorLabel.Text = "";
            resultLabel.Text = "";
        }
    }
}
