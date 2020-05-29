using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex03
{
    public partial class Form1 : Form
    {
        private int win = 0;
        private int lose = 0;
        private int same = 0;
        public Form1()
        {
            InitializeComponent();
        }

        //가위 버튼 클릭
        private void button1_Click(object sender, EventArgs e)
        {
            int mychoice = 0;
            int computerChoice = new Random().Next(0,3);

            my_result.Text = button1.Text;
            switch (computerChoice)
            {
                case 0:
                    com_result.Text = "가위";
                    result.Text = "무승부";
                    same++;
                    break;
                case 1:
                    com_result.Text = "바위";
                    result.Text = "패배";
                    lose++;
                    break;
                case 2:
                    com_result.Text = "보";
                    result.Text = "승리";
                    win++;
                    break;
                default:
                    break;
            }
            count.Text = $"{win}승 {same}무 {lose}패";
        }

        //바위 버튼 클릭
        private void button2_Click(object sender, EventArgs e)
        {
            int mychoice = 1;
            int computerChoice = new Random().Next(0, 3);

            my_result.Text = button2.Text;
            switch (computerChoice)
            {
                case 0:
                    com_result.Text = "가위";
                    result.Text = "승리";
                    win++;
                    break;
                case 1:
                    com_result.Text = "바위";
                    result.Text = "무승부";
                    same++;
                    break;
                case 2:
                    com_result.Text = "보";
                    result.Text = "패배";
                    lose++;
                    break;
                default:
                    break;
            }
            count.Text = $"{win}승 {same}무 {lose}패";
        }

        //보 버튼 클릭
        private void button3_Click(object sender, EventArgs e)
        {
            int mychoice = 2;
            int computerChoice = new Random().Next(0, 3);

            my_result.Text = button3.Text;
            switch (computerChoice)
            {
                case 0:
                    com_result.Text = "가위";
                    result.Text = "패배";
                    lose++;
                    break;
                case 1:
                    com_result.Text = "바위";
                    result.Text = "승리";
                    win++;
                    break;
                case 2:
                    com_result.Text = "보";
                    result.Text = "무승부";
                    same++;
                    break;
                default:
                    break;
            }
            count.Text = $"{win}승 {same}무 {lose}패";
        }
    }
}
