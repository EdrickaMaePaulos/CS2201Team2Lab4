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
    public partial class Form2 : Form
    {
        private bool isDegreeMode = true;
        private bool isFractionMode = false;
        private double firstNumber;
        private string operation = "";
        private bool isOperationPerformed = false;

        public Form2()
        {
            InitializeComponent();
        }

     
        private string ConvertToFraction(double value)
        {
            if (double.IsNaN(value) || double.IsInfinity(value))
                return value.ToString();

            if (Math.Abs(value - Math.Round(value)) < 0.000001)
                return Math.Round(value).ToString();

            bool isNegative = value < 0;
            value = Math.Abs(value);

            int wholePart = (int)Math.Floor(value);
            double fractionalPart = value - wholePart;

            const int maxDenominator = 10000;
            int bestNumerator = 0;
            int bestDenominator = 1;
            double bestError = fractionalPart;

            for (int denominator = 1; denominator <= maxDenominator; denominator++)
            {
                int numerator = (int)Math.Round(fractionalPart * denominator);
                double error = Math.Abs(fractionalPart - (double)numerator / denominator);

                if (error < bestError)
                {
                    bestNumerator = numerator;
                    bestDenominator = denominator;
                    bestError = error;

                    if (bestError < 0.0000001)
                        break;
                }
            }

            if (wholePart > 0)
            {
                if (bestNumerator == 0)
                    return (isNegative ? "-" : "") + wholePart.ToString();
                else
                    return (isNegative ? "-" : "") + $"{wholePart} {bestNumerator}/{bestDenominator}";
            }
            else
            {
                if (bestNumerator == 0)
                    return "0";
                else
                    return (isNegative ? "-" : "") + $"{bestNumerator}/{bestDenominator}";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (double.TryParse(displayTextBox.Text, out double value))
                displayTextBox.Text = Math.Sqrt(value).ToString();

            if (isFractionMode && double.TryParse(displayTextBox.Text, out double result))
                displayTextBox.Text = ConvertToFraction(result);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            displayTextBox.Text = Math.PI.ToString();

            if (isFractionMode)
                displayTextBox.Text = ConvertToFraction(Math.PI);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            frmCalculator basicForm = new frmCalculator();
            basicForm.Show();
            this.Hide(); 
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            TextBox display = (TextBox)this.Controls["displayTextBox"];

            if (button.Text == "." && display.Text.EndsWith("."))
                return;

            if (button.Text == "/" && !display.Text.Contains("/"))
            {
                display.Text += button.Text;
                return;
            }

            if (display.Text == "0" && button.Text != ".")
            {
                display.Text = button.Text;
                return;
            }

            if (isOperationPerformed)
            {
                isOperationPerformed = false;
            }

            display.Text += button.Text;
        }

        private void OperatorButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            TextBox display = (TextBox)this.Controls["displayTextBox"];

            if (isFractionMode && display.Text.Contains("/"))
            {
                string text = display.Text;
                string[] mixedParts = text.Split(' ');
                if (mixedParts.Length > 1)
                {
                    double wholeNumber = double.Parse(mixedParts[0]);
                    string[] fractionParts = mixedParts[1].Split('/');
                    double numerator = double.Parse(fractionParts[0]);
                    double denominator = double.Parse(fractionParts[1]);
                    double value = wholeNumber + (numerator / denominator);
                    display.Text = value.ToString();
                }
                else
                {
                    string[] fractionParts = text.Split('/');
                    if (fractionParts.Length == 2)
                    {
                        double numerator = double.Parse(fractionParts[0]);
                        double denominator = double.Parse(fractionParts[1]);
                        display.Text = (numerator / denominator).ToString();
                    }
                }
            }

            if (!isOperationPerformed)
            {
                firstNumber = double.Parse(display.Text);
                operation = button.Text;
                isOperationPerformed = true;
                display.Text = firstNumber.ToString() + " " + operation + " ";
            }
            else
            {
                operation = button.Text;

                string currentText = display.Text.Trim();
                if (currentText.EndsWith("+") || currentText.EndsWith("-") ||
                    currentText.EndsWith("*") || currentText.EndsWith("/") || currentText.EndsWith("%"))
                {
                    display.Text = currentText.Substring(0, currentText.Length - 1).Trim() + " " + operation + " ";
                }
                else
                {
                    display.Text = currentText + " " + operation + " ";
                }
            }
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            TextBox display = (TextBox)this.Controls["displayTextBox"];

            try
            {
                if (display.Text.Contains("/") && !display.Text.Contains(" ") &&
                   !display.Text.Contains("+") && !display.Text.Contains("-") &&
                   !display.Text.Contains("*") && !display.Text.Contains("%"))
                {
                    string[] fractionParts = display.Text.Split('/');
                    if (fractionParts.Length == 2 &&
                        double.TryParse(fractionParts[0], out double numerator) &&
                        double.TryParse(fractionParts[1], out double denominator) &&
                        denominator != 0)
                    {
                        double answer = numerator / denominator;

                        if (isFractionMode)
                            display.Text = ConvertToFraction(answer);
                        else
                            display.Text = answer.ToString();

                        firstNumber = answer;
                        isOperationPerformed = true;
                        return;
                    }
                }

                if (display.Text.Contains("/"))
                {
                    string text = display.Text;
                    if (text.Contains(" ") && !text.Contains("+") && !text.Contains("-") &&
                        !text.Contains("*") && !text.Contains("/") && !text.Contains("%"))
                    {
                        string[] mixedParts = text.Split(' ');
                        double wholeNumber = double.Parse(mixedParts[0]);
                        string[] fractionParts = mixedParts[1].Split('/');
                        double numerator = double.Parse(fractionParts[0]);
                        double denominator = double.Parse(fractionParts[1]);
                        double value = wholeNumber + (numerator / denominator);
                        display.Text = value.ToString();
                        return;
                    }
                    else if (!text.Contains(" ") && !text.Contains("+") && !text.Contains("-") &&
                             !text.Contains("*") && !text.Contains("/") && !text.Contains("%"))
                    {
                        string[] fractionParts = text.Split('/');
                        if (fractionParts.Length == 2)
                        {
                            double numerator = double.Parse(fractionParts[0]);
                            double denominator = double.Parse(fractionParts[1]);
                            display.Text = (numerator / denominator).ToString();
                            return;
                        }
                    }
                }

                string[] parts = display.Text.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length == 3 && operation == "^")
                {
                    double baseNum = double.Parse(parts[0]);
                    double exponent = double.Parse(parts[2]);
                    double answer = Math.Pow(baseNum, exponent);

                    if (isFractionMode)
                        display.Text = ConvertToFraction(answer);
                    else
                        display.Text = answer.ToString();

                    firstNumber = answer;
                    isOperationPerformed = true;
                    return;
                }

                if (parts.Length < 3)
                {
                    if (parts.Length == 1 && double.TryParse(parts[0], out double singleValue))
                    {
                        firstNumber = singleValue;
                        isOperationPerformed = true;
                        return;
                    }

                    MessageBox.Show("Incomplete expression.");
                    return;
                }

                double secondNumber = double.Parse(parts[2]);
                double result = 0;

                switch (operation)
                {
                    case "+":
                        result = firstNumber + secondNumber;
                        break;
                    case "-":
                        result = firstNumber - secondNumber;
                        break;
                    case "*":
                        result = firstNumber * secondNumber;
                        break;
                    case "/":
                        if (secondNumber != 0)
                            result = firstNumber / secondNumber;
                        else
                        {
                            MessageBox.Show("Cannot divide by zero");
                            return;
                        }
                        break;
                    case "%":
                        result = firstNumber % secondNumber;
                        break;
                    default:
                        MessageBox.Show("Invalid operation.");
                        return;
                }

                display.Text = result.ToString();
                firstNumber = result;
                isOperationPerformed = true;

                if (isFractionMode)
                    display.Text = ConvertToFraction(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void ClearButton_Click(object sender, EventArgs e)
        {
            TextBox display = (TextBox)this.Controls["displayTextBox"];
            display.Text = "0";
            firstNumber = 0;
            operation = "";
            isOperationPerformed = false;
        }

        private double DegreesToRadians(double degrees)
        {
            return degrees * Math.PI / 180;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            TextBox display = (TextBox)this.Controls["displayTextBox"];

            if (display.Text.Length > 0)
            {
                display.Text = display.Text.Remove(display.Text.Length - 1);
            }

            if (display.Text == "")
            {
                display.Text = "0";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            NumberButton_Click(sender, e);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            NumberButton_Click(sender, e);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            NumberButton_Click(sender, e);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            NumberButton_Click(sender, e);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            NumberButton_Click(sender, e);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            NumberButton_Click(sender, e);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            NumberButton_Click(sender, e);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            NumberButton_Click(sender, e);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            NumberButton_Click(sender, e);
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            NumberButton_Click(sender, e);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            NumberButton_Click(sender, e);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearButton_Click(sender, e);
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            DeleteButton_Click(sender, e);
        }

        private void btnModulo_Click(object sender, EventArgs e)
        {
            OperatorButton_Click(sender, e);
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            OperatorButton_Click(sender, e);
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            OperatorButton_Click(sender, e);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            OperatorButton_Click(sender, e);
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            OperatorButton_Click(sender, e);
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            EqualsButton_Click(sender, e);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (double.TryParse(displayTextBox.Text, out double value))
            {
                displayTextBox.Text = (-value).ToString();

                if (isFractionMode)
                    displayTextBox.Text = ConvertToFraction(-value);
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (double.TryParse(displayTextBox.Text, out double value))
            {
                if (isDegreeMode)
                    value = DegreesToRadians(value);

                displayTextBox.Text = Math.Sin(value).ToString();

                if (isFractionMode)
                    displayTextBox.Text = ConvertToFraction(Math.Sin(value));
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (double.TryParse(displayTextBox.Text, out double value))
            {
                if (isDegreeMode)
                    value = DegreesToRadians(value);

                displayTextBox.Text = Math.Cos(value).ToString();

                if (isFractionMode)
                    displayTextBox.Text = ConvertToFraction(Math.Cos(value));
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (double.TryParse(displayTextBox.Text, out double value))
            {
                if (isDegreeMode)
                    value = DegreesToRadians(value);

                displayTextBox.Text = Math.Tan(value).ToString();

                if (isFractionMode)
                    displayTextBox.Text = ConvertToFraction(Math.Tan(value));
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (double.TryParse(displayTextBox.Text, out double value) && value > 0)
            {
                displayTextBox.Text = Math.Log(value).ToString();

                if (isFractionMode)
                    displayTextBox.Text = ConvertToFraction(Math.Log(value));
            }
            else
                MessageBox.Show("Input must be > 0");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (double.TryParse(displayTextBox.Text, out double value) && value > 0)
            {
                displayTextBox.Text = Math.Log10(value).ToString();

                if (isFractionMode)
                    displayTextBox.Text = ConvertToFraction(Math.Log10(value));
            }
            else
                MessageBox.Show("Input must be > 0");
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (double.TryParse(displayTextBox.Text, out double value) && value != 0)
            {
                displayTextBox.Text = (1 / value).ToString();

                if (isFractionMode)
                    displayTextBox.Text = ConvertToFraction(1 / value);
            }
            else
                MessageBox.Show("Cannot divide by zero");
        }

        private void button29_Click(object sender, EventArgs e)
        {
            displayTextBox.Text = Math.E.ToString();

            if (isFractionMode)
                displayTextBox.Text = ConvertToFraction(Math.E);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (double.TryParse(displayTextBox.Text, out double value))
            {
                displayTextBox.Text = Math.Abs(value).ToString();

                if (isFractionMode)
                    displayTextBox.Text = ConvertToFraction(Math.Abs(value));
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            isDegreeMode = !isDegreeMode;
            button31.Text = isDegreeMode ? "Rad" : "Deg";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            try
            {
                isFractionMode = !isFractionMode;
                Button btn = (Button)sender;
                btn.Text = isFractionMode ? "Dec" : "Frac";

                string displayText = displayTextBox.Text;

                if (isFractionMode)
                {
                    if (double.TryParse(displayText, out double value))
                    {
                        displayTextBox.Text = ConvertToFraction(value);
                    }
                }
                else
                {
                    if (displayText.Contains(" ") && displayText.Contains("/"))
                    {
                        string[] mixedParts = displayText.Split(' ');
                        if (mixedParts.Length >= 2 &&
                            int.TryParse(mixedParts[0], out int wholePart))
                        {
                            string[] fractionParts = mixedParts[1].Split('/');
                            if (fractionParts.Length == 2 &&
                                double.TryParse(fractionParts[0], out double numerator) &&
                                double.TryParse(fractionParts[1], out double denominator) &&
                                denominator != 0)
                            {
                                double value = wholePart + (numerator / denominator);
                                displayTextBox.Text = value.ToString();
                            }
                        }
                    }
                    else if (displayText.Contains("/"))
                    {
                        string[] fractionParts = displayText.Split('/');
                        if (fractionParts.Length == 2 &&
                            double.TryParse(fractionParts[0], out double numerator) &&
                            double.TryParse(fractionParts[1], out double denominator) &&
                            denominator != 0)
                        {
                            double value = numerator / denominator;
                            displayTextBox.Text = value.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error toggling fraction mode: " + ex.Message);
            }
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            TextBox display = (TextBox)this.Controls["displayTextBox"];

            if (!isOperationPerformed)
            {
                firstNumber = double.Parse(display.Text);
                operation = "^";
                isOperationPerformed = true;
                display.Text = firstNumber.ToString() + " ^ ";
            }
            else
            {
                operation = "^";

                string currentText = display.Text.Trim();
                display.Text = currentText + " ^ ";
            }
        }
    }
}