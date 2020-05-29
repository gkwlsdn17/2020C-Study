using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGame
{
    public partial class Form1 : Form
    {
        
        private int timeLimit = 30;
        private int answer = new Random().Next(10);
        bool check = false;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLimit > 0 && check == false)
            {
                label_time.Text = timeLimit.ToString();
                timeLimit--;
            }
            else if(timeLimit>0 && check == true)
            {
                timer1.Stop();
                label_time.Text = timeLimit.ToString();
            }
            else
            {
                timer1.Stop();
                label_time.Text = "시간초과";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int input = int.Parse(textBox1.Text);
            if(answer == input)
            {
                label_info.Text = "정답입니다!";
                check = true;
                
            }
            else
            {
                label_info.Text = "틀렸습니다. 다시 해보세요";
            }
        }

        private void button_restart_Click(object sender, EventArgs e)
        {
            check = false;
            answer = new Random().Next(10);
            timeLimit = 30;
            timer1.Start();
            label_info.Text = "정답을 맞춰 보세요";
            
        }
    }
}
