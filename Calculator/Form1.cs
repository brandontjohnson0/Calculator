namespace Calculator
{
    public partial class Form1 : Form
    {
        string input = string.Empty; //stores input
        string operand1 = string.Empty; //stores first operand
        string operand2 = string.Empty; //stores second operand
        char operation; //operation
        double result = 0.0; //calculation
        public Form1()
        {
            InitializeComponent();
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            this.TextBox.Text = "";
            input += "7";
            this.TextBox.Text += input;
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            this.TextBox.Text = "";
            input += "8";
            this.TextBox.Text += input;
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            this.TextBox.Text = "";
            input += "9";
            this.TextBox.Text += input;
        }

        private void Four_Click(object sender, EventArgs e)
        {
            this.TextBox.Text = "";
            input += "4";
            this.TextBox.Text += input;
        }

        private void Five_Click(object sender, EventArgs e)
        {
            this.TextBox.Text = "";
            input += "5";
            this.TextBox.Text += input;
        }

        private void Six_Click(object sender, EventArgs e)
        {
            this.TextBox.Text = "";
            input += "6";
            this.TextBox.Text += input;
        }

        private void One_Click(object sender, EventArgs e)
        {
            this.TextBox.Text = "";
            input += "1";
            this.TextBox.Text += input;
        }

        private void Two_Click(object sender, EventArgs e)
        {
            this.TextBox.Text = "";
            input += "2";
            this.TextBox.Text += input;
        }

        private void Three_Click(object sender, EventArgs e)
        {
            this.TextBox.Text = "";
            input += "3";
            this.TextBox.Text += input;
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            this.TextBox.Text = "";
            input += "0";
            this.TextBox.Text += input;
        }

        private void Decimal_Click(object sender, EventArgs e)
        {
            this.TextBox.Text = "";
            input += ".";
            this.TextBox.Text += input;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            this.TextBox.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            input = string.Empty;
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void Subtract_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            this.TextBox.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;

            if (operation == '+')
            {
                result = num1 + num2;
                TextBox.Text = result.ToString();
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                TextBox.Text = result.ToString();
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                TextBox.Text = result.ToString();
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    TextBox.Text = result.ToString();
                }
                else
                {
                    TextBox.Text = "DIV/Zero!";
                }
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
