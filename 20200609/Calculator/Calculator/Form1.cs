using System;
using System.Collections;
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
        string ruleResult = "";
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
                    ruleCalc();
                    input = calc().ToString();
                    
                    textBox_result.Text = "순서대로 계산시 : "+input + "\r\n" + "산술연산 규칙대로 계산시 : "+ruleResult;
                    
                    
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

        //입력 순서대로 계산하는 함수
        private double calc()
        {
            char[] op = { '+', '-', '*', '/' };
            string[] numArr = input.Split(op);


            double sum = Convert.ToDouble(numArr[0]);
            char[] temp = input.ToCharArray();
            int count = 1;
            
            for (int i = 0; i < temp.Length; i++)
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

        //산술연산 우선순위 규칙 따라 계산하는 함수
        private void ruleCalc()
        {

            int opCount = 0; // 연산자의 개수를 구한다
            for (int i = 0; i < input.Length; i++)
            {

                if (input[i].Equals('+') || input[i].Equals('-') || input[i].Equals('*') || input[i].Equals('/'))
                {
                    opCount++;
                }
            }
            string[] opArr = new string[opCount];
            int oplen = 0;
            //연산자만 구하기위해서 split을 했을 때 오류가 있어서 직접 연산자 배열을 구한다
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Equals('+') || input[i].Equals('-') || input[i].Equals('*') || input[i].Equals('/'))
                {
                    opArr[oplen] = input[i].ToString();
                    oplen++;
                }
            }

            char[] op = { '+', '-', '*', '/' }; //구분자
            string[] numArr = input.Split(op); //숫자만 있는 배열

            string[] newInputArr = new string[numArr.Length + opCount]; //여러자리 숫자와 연산자를 다시 배열로 만든다
            int numArrCount=0, opCountNum=0;
            for(int i = 0; i < numArr.Length + opCount; i++)
            {
                if (i % 2 == 0) //숫자를 넣는 조건문
                {
                    newInputArr[i] = numArr[numArrCount];
                    numArrCount++;
                }
                else // 연산자를 넣는 조건문
                {
                    newInputArr[i] = opArr[opCountNum];
                    opCountNum++;
                }
            }
            
            seq_op(opArr); // 연산자만 있는 배열을 우선순위대로 재배열

            List<string> list = newInputArr.ToList();
            opCountNum = 0;
            while (list.Count!=1) //마지막 숫자 한개가 남을 때 까지 연산을 계속 한다
            {
                
                for(int i = 0; i < list.Count; i++)
                {
                    if (list.ElementAt(i).Equals(opArr[opCountNum]))
                    {
                        //연산자가 있는 인덱스 번호에 결과값을 넣고 계산한 숫자들은 삭제한다
                        if (list.ElementAt(i).Equals("+"))
                        {
                            
                            double sum = double.Parse(list.ElementAt(i - 1)) + double.Parse(list.ElementAt(i + 1));
                            
                            list.Insert(i, sum.ToString()); 
                            list.RemoveAt(i + 1);
                            list.RemoveAt(i + 1); list.RemoveAt(i - 1);
                            if (opCount != opArr.Length - 1)
                                opCountNum++;
                            break;


                        }
                        if (list.ElementAt(i).Equals("-"))
                        {
                            double sum = double.Parse(list.ElementAt(i - 1)) - double.Parse(list.ElementAt(i + 1));

                            list.Insert(i, sum.ToString()); 
                            list.RemoveAt(i + 1);
                            list.RemoveAt(i + 1); list.RemoveAt(i - 1);
                            if (opCount != opArr.Length - 1)
                                opCountNum++;
                            break;

                        }
                        if (list.ElementAt(i).Equals("*"))
                        {
                            double sum = double.Parse(list.ElementAt(i - 1)) * double.Parse(list.ElementAt(i + 1));

                            list.Insert(i, sum.ToString());
                            list.RemoveAt(i+1);
                            list.RemoveAt(i + 1);  list.RemoveAt(i - 1);
                            if (opCount != opArr.Length - 1)
                                opCountNum++;
                            break;

                        }
                        if (list.ElementAt(i).Equals("/"))
                        {
                            double sum = double.Parse(list.ElementAt(i - 1)) / double.Parse(list.ElementAt(i + 1));

                            list.Insert(i, sum.ToString()); 
                            list.RemoveAt(i + 1);
                            list.RemoveAt(i + 1); list.RemoveAt(i - 1);
                            if (opCount != opArr.Length - 1)
                                opCountNum++;
                            break;
                        }
                        
                    }
                    
                }
            }
            //마지막 남은 숫자를 결과를 출력하는 문자열에 담는다
            ruleResult = list.ElementAt(0);
            

        }

        //계산기에 한 글자 지우는 함수
        private void back()
        {
            char[] temp = input.ToCharArray();
            input = "";
            for (int i = 0; i < temp.Length - 1; i++)
            {
                input += temp[i];
            }
        }

        //연산자를 우선순위 맞춰서 배열하는 함수
        private void seq_op(string[] op)
        {
            int count = op.Length;
            
            int[] priority = new int[count];

            for (int i = 0; i < count; i++)
            {
                if (op[i].Equals("+")) { priority[i] = 0; }
                else if (op[i].Equals("-")){ priority[i] = 0; }
                else if (op[i].Equals("*")){ priority[i] = 1; }
                else if (op[i].Equals("/")){ priority[i] = 1; }
            }
           
            for (int i = 1; i < op.Length ; i++)
            {
                for (int j = 1; j < op.Length-i+1; j++)
                {
                    if (priority[j-1] < priority[j])
                    {
                        
                        int temp = priority[j-1];
                        priority[j-1] = priority[j];
                        priority[j] = temp;

                        string chtemp = op[j-1];
                        op[j-1] = op[j];
                        op[j] = chtemp;
                    }

                }
                
                
            }
            
        }
    }
}