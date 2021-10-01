using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winforms_Analog_Clock_9
{
    public partial class Form1 : Form
    {
        
        List<double> list1 = new List<double>();
        double firstNum;
        double secondNum;
        object oper;
        bool lockNums;
        bool lockOpers;
      
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonNumber_Click(object sender, EventArgs e)
        {   // Runs only if numberButtons are unlocked, and display is not full
            if (!lockNums && list1.Count < 11)
            {
                // Changes Sender to a Button, adds button pressed to display, Casts button pressed button value to double, adds double to list.
                Button number = sender as Button;
              
                label1.Text += number.Text;
               
                double btnPress = Convert.ToDouble(number.Text);
                
                list1.Add(btnPress);
                
            }
        }

        private void buttonDecimal_Click(object sender, EventArgs e)
        {

        }

        private void buttonOperator_Click(object sender, EventArgs e)
        {
           // Calls fillnumber to put list into one double, sets oper to button pressed value.
            FillNumbers();
                       
            oper = sender;
          
            // Creates button sets it to sender. if there is a firstnumber, display it, and operator.
            Button operButton = sender as Button;
            if (firstNum != 0)
            {
                label2.Text = firstNum.ToString() + " " + operButton.Text;
            }

            // Converts firstNumber to string cast to firstNumToDouble.
            string firstNumToDoub = firstNum.ToString();

            // If a number has been calculated it clears label1 text and Unlocks numberButtons.
            if (firstNumToDoub == label1.Text)
            {
                lockNums = false;
                label1.Text = "";
            }
       
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            FillNumbers();
            // Runs if both numbers have been filled.
            if (firstNum > 0 && secondNum > 0)
            {
                // Displays firstNumber, oper, and secondNumber on label2.
                label2.Text = label2.Text + " " + secondNum.ToString() + " =";

                if (oper == buttonAdd)
                { // Adds numbers and sets to firstnumber, displays answer.
                    firstNum = firstNum + secondNum;
                    label1.Text = firstNum.ToString();             
                }

                if (oper == buttonSubtract)
                { // Subtracts numbers and sets to firstnumber, displays answer.
                    firstNum = firstNum - secondNum;
                    label1.Text = firstNum.ToString();                 
                }

                if (oper == buttonMultiply)
                { // Multiply numbers and sets to firstnumber, displays answer.
                    firstNum = firstNum * secondNum;
                    label1.Text = firstNum.ToString();                 
                }

                if (oper == buttonDivide)
                { // Divides numbers and sets to firstnumber, displays answer.
                    firstNum = firstNum / secondNum;
                    label1.Text = firstNum.ToString();
                }

                // Adds answer to history, clears second number, clears oper, locks lumber buttons until cleared.
                listView1.Items.Add(label2.Text + " " + label1.Text);
                ScaleLabel(label1);
                secondNum = 0;
                oper = null;
                lockNums = true;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        { // Runs if pressed button was not clearhistory.
            if (sender != buttonClearHistory)
            { // Clears: display1, display 2, first and second number, list. Unlocks number buttons, Unlocks operators.
                label1.Text = "";
                label2.Text = "";
                firstNum = 0;
                secondNum = 0;
                list1.Clear();
                lockNums = false;
                lockOpers = false;
            }
            else // if clearhistory was pressed, clears list view.
                listView1.Clear();
        }

        public void FillNumbers()
        { // Only runs if numbers have been entered.
            if (list1.Count != 0)
            {
                
                if (firstNum == 0)
                { // If no  first number was Taken. new string taken from list1, convert string to doubles, display number, clearlist.  
                    string doubleText = ListToDouble();
                    firstNum = Convert.ToDouble(doubleText);
                    label1.Text = "";
                    list1.Clear();
                }
                else
                { // If first number was Taken. new string taken from list1, convert string to doubles, display number, clearlist.
                    string doubleText = ListToDouble();
                    secondNum = Convert.ToDouble(doubleText);
                    label1.Text = "";
                    list1.Clear();
                }
            }
        }

        public string ListToDouble()
        { // Empty string created
            string doubleText = "";
            // Each item in list1 is converted to string and added to Empty string, string is returned.
            foreach  (double item in list1)
            {
                doubleText += item.ToString();
            }
            return doubleText;
        }

        public static void ScaleLabel(Label label, float stepSize = 0.5f)
        {
            //decrease font size if text is wider or higher than label
            while (lblTextSize() is Size s && s.Width > label.Width || s.Height > label.Height)
            {
                label.Font = new Font(label.Font.FontFamily, label.Font.Size - stepSize, label.Font.Style);
            }

            //increase font size if label width is bigger than text size
            while (label.Width > lblTextSize().Width)
            {
                var font = new Font(label.Font.FontFamily, label.Font.Size + stepSize, label.Font.Style);
                var nextSize = TextRenderer.MeasureText(label.Text, font);

                //dont make text width or hight bigger than label
                if (nextSize.Width > label.Width || nextSize.Height > label.Height)
                    break;

                label.Font = font;
            }

            Size lblTextSize() => TextRenderer.MeasureText(label.Text,
                new Font(label.Font.FontFamily, label.Font.Size, label.Font.Style));
        }
    }
}
