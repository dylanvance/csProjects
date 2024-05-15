using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Calculator
{
    public partial class Calculator : Form
    {
        private float value1;
        private float value2;
        private float result;
        private string operation;

        public Calculator()
        {
            InitializeComponent();
        }

        private void ClearButton_Click(object sender, EventArgs e) => OutputLabel.Text = "";

        private void SignButton_Click(object sender, EventArgs e)
        {
            int tempInt;
            float tempFloat;
            if (Int32.TryParse(OutputLabel.Text, out tempInt))
            {
                    tempInt *= -1;
                    OutputLabel.Text = tempInt.ToString();
            }
            else if (float.TryParse(OutputLabel.Text, out tempFloat))
            {
                    tempFloat *= -1.0f;
                    OutputLabel.Text = tempFloat.ToString();
            }
        }

        private void PercentButton_Click(object sender, EventArgs e)
        {
            try
            {
                result = float.Parse(OutputLabel.Text) / 100;
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            try
            {
                result = (float)Int32.Parse(OutputLabel.Text) / 100;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            OutputLabel.Text = result.ToString();
        }

        private void DivisionButton_Click(object sender, EventArgs e)
        {
            int tempInt;
            float tempFloat;
            if (Int32.TryParse(OutputLabel.Text, out tempInt))
            {
                value1 = Int32.Parse(OutputLabel.Text);
            }
            else if (float.TryParse(OutputLabel.Text, out tempFloat))
            {
                value1 = float.Parse(OutputLabel.Text);
            }
            else
            {
                return; // Something went wrong -> prevent the operation
            }
            operation = "DIVISION";
            OutputLabel.Text = "";
        }

        private void SevenButton_Click(object sender, EventArgs e) => OutputLabel.Text += "7";

        private void EightButton_Click(object sender, EventArgs e) => OutputLabel.Text += "8";

        private void NineButton_Click(object sender, EventArgs e) => OutputLabel.Text += "9";

        private void MultiplicationButton_Click(object sender, EventArgs e)
        {
            int tempInt;
            float tempFloat;
            if (Int32.TryParse(OutputLabel.Text, out tempInt))
            {
                value1 = Int32.Parse(OutputLabel.Text);
            }
            else if (float.TryParse(OutputLabel.Text, out tempFloat))
            {
                value1 = float.Parse(OutputLabel.Text);
            }
            else
            {
                return; // Something went wrong -> prevent the operation
            }
            operation = "MULTIPLICATION";
            OutputLabel.Text = "";
        }

        private void FourButton_Click(object sender, EventArgs e) => OutputLabel.Text += "4";

        private void FiveButton_Click(object sender, EventArgs e) => OutputLabel.Text += "5";

        private void SixButton_Click(object sender, EventArgs e) => OutputLabel.Text += "6";

        private void SubtractionButton_Click(object sender, EventArgs e)
        {
            int tempInt;
            float tempFloat;
            if (Int32.TryParse(OutputLabel.Text, out tempInt))
            {
                value1 = Int32.Parse(OutputLabel.Text);
            }
            else if (float.TryParse(OutputLabel.Text, out tempFloat))
            {
                value1 = float.Parse(OutputLabel.Text);
            }
            else
            {
                return; // Something went wrong -> prevent the operation
            }
            operation = "SUBTRACTION";
            OutputLabel.Text = "";
        }

        private void OneButton_Click(object sender, EventArgs e) => OutputLabel.Text += "1";

        private void TwoButton_Click(object sender, EventArgs e) => OutputLabel.Text += "2";

        private void ThreeButton_Click(object sender, EventArgs e) => OutputLabel.Text += "3";

        private void AdditionButton_Click(object sender, EventArgs e)
        {
            int tempInt;
            float tempFloat;
            if (Int32.TryParse(OutputLabel.Text, out tempInt))
            {
                value1 = Int32.Parse(OutputLabel.Text);
            }
            else if (float.TryParse(OutputLabel.Text, out tempFloat))
            {
                value1 = float.Parse(OutputLabel.Text);
            }
            else
            {
                return; // Something went wrong -> prevent the operation
            }
            operation = "ADDITION";
            OutputLabel.Text = "";
        }

        private void ZeroButton_Click(object sender, EventArgs e) => OutputLabel.Text += "0";

        private void DecimalButton_Click(object sender, EventArgs e)
        {
            OutputLabel.Text += ".";
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            int tempInt;
            float tempFloat;
            if (Int32.TryParse(OutputLabel.Text, out tempInt))
            {
                value2 = Int32.Parse(OutputLabel.Text);
            }
            else if (float.TryParse(OutputLabel.Text, out tempFloat))
            {
                value2 = float.Parse(OutputLabel.Text);
            }
            else
            {
                return; // Something went wrong -> prevent the operation
            }

            switch(operation)
            {
                case "ADDITION":
                    result = value1 + value2;
                    OutputLabel.Text = result.ToString();
                    break;
                case "SUBTRACTION":
                    result = value1 - value2;
                    OutputLabel.Text = result.ToString();
                    break;
                case "MULTIPLICATION":
                    result = value1 * value2;
                    OutputLabel.Text = result.ToString();
                    break;
                case "DIVISION":
                    result = value1 / value2;
                    OutputLabel.Text = result.ToString();
                    break;
                default:
                    OutputLabel.Text = "Err";
                    break;
            }
        }

        private void OutputLabel_Click(object sender, EventArgs e) {/*Do Nothing On Click*/}

    }
}
