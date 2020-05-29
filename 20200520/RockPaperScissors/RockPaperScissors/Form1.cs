using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        string result;
        public Form1()
        {
            InitializeComponent();
            switch (random.Next(3))
            {
                case 0:
                    result = "가위";
                    break;
                case 1:
                    result = "바위";
                    break;
                case 2:
                    result = "보";
                    break;
                default:
                    break;
            }
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = result.ToString();
            if(result.Contains("가위"))
            {
                label4.Text="무승부입니다";
            }
            else if(result.Contains("바위"))
            {
                label4.Text = "졌습니다 분발하세여";
            }
            else
            {
                label4.Text = "이겼습니다! 당신의 승리!";
            }
            switch (random.Next(3))
            {
                case 0:
                    result = "가위";
                    break;
                case 1:
                    result = "바위";
                    break;
                case 2:
                    result = "보";
                    break;
                default:
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = result.ToString();
            if (result.Contains("바위"))
            {
                label4.Text = "무승부입니다";
            }
            else if (result.Contains("보"))
            {
                label4.Text = "졌습니다 분발하세여";
            }
            else
            {
                label4.Text = "이겼습니다! 당신의 승리!";
            }
            switch (random.Next(3))
            {
                case 0:
                    result = "가위";
                    break;
                case 1:
                    result = "바위";
                    break;
                case 2:
                    result = "보";
                    break;
                default:
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = result.ToString();
            if (result.Contains("보"))
            {
                label4.Text = "무승부입니다";
            }
            else if (result.Contains("가위"))
            {
                label4.Text = "졌습니다 분발하세여";
            }
            else
            {
                label4.Text = "이겼습니다! 당신의 승리!";
            }
            switch (random.Next(3))
            {
                case 0:
                    result = "가위";
                    break;
                case 1:
                    result = "바위";
                    break;
                case 2:
                    result = "보";
                    break;
                default:
                    break;
            }
        }
    }
}
