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
        string input = "";
        
        public Form1()
        {
            InitializeComponent();
        }
        private void onBtnClick(object sender, EventArgs e)
        {
            switch (((Button)sender).Text)
            {
                case "0":
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "+":
                case "-":
                case "/":
                case "*":
                case ".":
                    input += ((Button)sender).Text;
                    textBox_result.Text = input;
                    break;
                case "=":
                    input = calc().ToString();
                    textBox_result.Text = input;
                    break;
                case "AC":
                    input = "";
                    textBox_result.Clear();
                    break;
                case "←":
                    back();
                    textBox_result.Text = input;
                    break;
                
            }
        }
        private double calc()
        {
            char[] s = { '+', '-', '*', '/' };
            string[] numArr = input.Split(s);
            
            double sum = Convert.ToDouble(numArr[0]);
            char[] temp = input.ToCharArray();
            int count = 1;
            for(int i = 0; i < temp.Length; i++)
            {
                
                if (temp[i].Equals('+') == true)
                {
                    sum += double.Parse(numArr[count]);
                    count++;
                }
                else if (temp[i].Equals('-') == true)
                {
                    sum -= double.Parse(numArr[count]);
                    count++;
                }
                else if (temp[i].Equals('*') == true)
                {
                    sum *= double.Parse(numArr[count]);
                    count++;
                }
                else if (temp[i].Equals('/') == true)
                {
                    sum /= double.Parse(numArr[count]);
                    count++;
                }
            }
            
            return sum;
        }
        private void back()
        {
            char[] temp = input.ToCharArray();
            input = "";
            for(int i = 0; i < temp.Length-1; i++)
            {
                input += temp[i];
            }
        }
        
        
    }
}
