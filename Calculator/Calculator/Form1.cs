using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class frmCalculator : Form
    {
        private double firstNumber = 0;
        private string operation = "";
        private bool isOperationPerformed = false;

        public frmCalculator()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void frmCalculator_Load(object sender, EventArgs e)
        {

        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            TextBox display = (TextBox)this.Controls["txtInput"];

            if (button.Text == "." && display.Text.EndsWith("."))
                return;

            if (display.Text == "0")
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
            TextBox display = (TextBox)this.Controls["txtInput"];

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
            TextBox display = (TextBox)this.Controls["txtInput"];

            try
            {
                string[] parts = display.Text.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                if (parts.Length < 3)
                {
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void ClearButton_Click(object sender, EventArgs e)
        {
            TextBox display = (TextBox)this.Controls["txtInput"];
            display.Text = "0";
            firstNumber = 0;
            operation = "";
            isOperationPerformed = false;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            TextBox display = (TextBox)this.Controls["txtInput"];

            if (display.Text.Length > 0)
            {
                display.Text = display.Text.Remove(display.Text.Length - 1);
            }

            if (display.Text == "")
            {
                display.Text = "0";
            }
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OperatorButton_Click(sender, e);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearButton_Click(sender, e);
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            DeleteButton_Click(sender, e);
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            EqualsButton_Click(sender, e);
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            Form2 sciForm = new Form2();
            sciForm.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
