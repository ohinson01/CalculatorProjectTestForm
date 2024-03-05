/* Date: 5/13/2020
 * 
 * Maintenance History:
 *  5/13/2020 - Draw Form, set properties 
 *  5/20/2020 - Modified code to include event handlers for calculations
 *  5/23/2020 - Modified code to reset my variables and event handlers for calculations 
 *  6/3/2020 - Modified code to set key input and added conditions for pressing Subtract, Multiplicaiton and Division
 */
using System;
using System.Windows.Forms;

namespace CalculatorProjectTestForm
{
    public partial class CalculatorProjectTestForm : Form
    {
        string input = string.Empty; 
        string value1 = string.Empty; 
        string value2 = string.Empty; 
        char operation;              
        double result = 0.0;        

        public CalculatorProjectTestForm()
        {
            InitializeComponent();
        } 
       
        private void clearButton_Click(object sender, EventArgs e)
        {
            calcTextBox.Clear(); 
        } 

        private void allClearButton_Click(object sender, EventArgs e)
        {
            input = string.Empty;
            calcTextBox.Text = input; 
        } 

        private void CalculatorProjectTestForm_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D0:
                    zeroButton.PerformClick();
                    break;
                case Keys.D1:
                    oneButton.PerformClick();
                    break;
                case Keys.D2:
                    twoButton.PerformClick();
                    break;
                case Keys.D3:
                    threeButton.PerformClick();
                    break;
                case Keys.D4:
                    fourButton.PerformClick();
                    break;
                case Keys.D5:
                    fiveButton.PerformClick();
                    break;
                case Keys.D6:
                    sixButton.PerformClick();
                    break;
                case Keys.D7:
                    sevenButton.PerformClick();
                    break;
                case Keys.D8:
                    eightButton.PerformClick();
                    break;
                case Keys.D9:
                    nineButton.PerformClick();
                    break;
                case Keys.NumPad0:
                    zeroButton.PerformClick();
                    break;
                case Keys.NumPad1:
                    oneButton.PerformClick();
                    break;
                case Keys.NumPad2:
                    twoButton.PerformClick();
                    break;
                case Keys.NumPad3:
                    threeButton.PerformClick();
                    break;
                case Keys.NumPad4:
                    fourButton.PerformClick();
                    break;
                case Keys.NumPad5:
                    fiveButton.PerformClick();
                    break;
                case Keys.NumPad6:
                    sixButton.PerformClick();
                    break;
                case Keys.NumPad7:
                    sevenButton.PerformClick();
                    break;
                case Keys.NumPad8:
                    eightButton.PerformClick();
                    break;
                case Keys.NumPad9:
                    nineButton.PerformClick();
                    break;
                case Keys.Decimal:
                    dotButton.PerformClick();
                    break;
                case Keys.Add:
                    addButton.PerformClick();
                    break;
                case Keys.Multiply:
                    multiplyButton.PerformClick();
                    break;
                case Keys.Divide:
                    divideButton.PerformClick();
                    break;
                case Keys.Subtract:
                    subtractButton.PerformClick();
                    break;
                case Keys.Enter:
                    equalsButton.PerformClick();
                    break;
                case Keys.Delete:
                    allClearButton.PerformClick();
                    break;
                default:
                    break;
            }
        } 

        private void zeroButton_Click(object sender, EventArgs e)
        {
            calcTextBox.Text = ""; 
            input = input + "0";
            calcTextBox.Text = input;
        } 

        private void oneButton_Click(object sender, EventArgs e)
        {
            calcTextBox.Text = "";
            input = input + "1";
            calcTextBox.Text = input; 
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            calcTextBox.Text = "";
            input = input + "2";
            calcTextBox.Text = input;
        } 

        private void threeButton_Click(object sender, EventArgs e)
        {
            calcTextBox.Text = "";
            input = input + "3";
            calcTextBox.Text = input;
        } 

        private void fourButton_Click(object sender, EventArgs e)
        {
            calcTextBox.Text = "";
            input = input + "4";
            calcTextBox.Text = input; 
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            calcTextBox.Text = "";
            input = input + "5";
            calcTextBox.Text = input; 
        } 

        private void sixButton_Click(object sender, EventArgs e)
        {
            calcTextBox.Text = "";
            input = input + "6";
            calcTextBox.Text = input; 
        } 
        
        private void sevenButton_Click(object sender, EventArgs e)
        {
            calcTextBox.Text = "";
            input = input + "7";
            calcTextBox.Text = input; 
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            calcTextBox.Text = "";
            input = input + "8";
            calcTextBox.Text = input; 
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            calcTextBox.Text = "";
            input = input + "9";
            calcTextBox.Text = input; 
        }

        private void signChangeButton_Click(object sender, EventArgs e)
        {
            input = input + '-';
            calcTextBox.Text = input; 
        } 

        private void dotButton_Click(object sender, EventArgs e)
        {
            input = input + '.';
            calcTextBox.Text = input; 
        } 

        private void divideButton_Click(object sender, EventArgs e)
        {
            value1 = input;
            operation = '/';
            input = string.Empty; 
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            value1 = input;
            operation = '*';
            input = string.Empty;
        } 

        private void subtractButton_Click(object sender, EventArgs e)
        {
            value1 = input;
            operation = '-';
            input = string.Empty; 
        } 

        private void addButton_Click(object sender, EventArgs e)
        {
            value1 = input;
            operation = '+';
            input = string.Empty; 
        } 

        private void equalsButton_Click(object sender, EventArgs e)
        {
            value2 = input;   
            double num1, num2; 
            double roundResult;

            double.TryParse(value1, out num1); 
            double.TryParse(value2, out num2);     

            if (operation == '+')
            {
                result = num1 + num2;
                roundResult = Math.Round((double)result, 2); 
                calcTextBox.Text = roundResult.ToString(); 
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                roundResult = Math.Round((double)result, 2); 
                calcTextBox.Text = roundResult.ToString();
            } 
            else if (operation == '*')
            {
                result = num1 * num2;
                roundResult = Math.Round((double)result, 2); 
                calcTextBox.Text = roundResult.ToString();
            } 
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    roundResult = Math.Round((double)result, 2);
                    calcTextBox.Text = roundResult.ToString();
                }
                else
                {
                    calcTextBox.Text = "DIV/Zero!";
                } 
            }
        } 

        private void offButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    } 
} 

/*********************************************************
 * References:
 *  cdog204. (2020). Creating a Calculator Visual Studio C#. Retrieved from
 *  https://www.instructables.com/id/Creating-a-Calculator-Visual-Studio-C/
 *********************************************************/
