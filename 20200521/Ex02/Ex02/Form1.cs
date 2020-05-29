using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex02
{
    public partial class Form1 : Form
    {
        private int answer_number;
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Hello world");
            //Random random = new Random();
            //answer_number = random.Next(1,11);
            answer_number = new Random().Next(1, 11);
            label1.Text = answer_number.ToString();
        }

        

        private void input_Click_1(object sender, EventArgs e)
        {
            //Parse
            //잘못된 string을 받으면 프로그램이 종료됨
            //TryParse
            //잘못된 string 받으면 값을 0으로 바꿔주고, 그 함수 자체는 false를 리턴함.

            int input_number = int.Parse(textbox_input.Text);
            if (input_number > answer_number)
            {
                MessageBox.Show("입력하신 숫자가 더 큽니다");
            }
            else if (input_number < answer_number)
            {
                MessageBox.Show("입력하신 숫자가 더 작습니다");
            }
            else
            {
                MessageBox.Show("정답!");
                answer_number = new Random().Next(1, 11);
                label1.Text = answer_number.ToString();
            }
        }
    }
}
