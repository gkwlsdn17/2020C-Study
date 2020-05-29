using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex01
{
    public partial class Form1 : Form
    {
        private int number = 0;
        public Form1()
        {
            InitializeComponent();
            number = new Random().Next(1, 11);
            Console.WriteLine("정답: "+number);
        }

        private void button_input_Click(object sender, EventArgs e)
        {
            //int input = int.Parse(textBox_input.Text);
            int input = 0;
            bool ans = int.TryParse(textBox_input.Text, out input);
            if (ans == false)
            {
                MessageBox.Show("잘못된 값입니다.");
            }
            else
            {
                if (input > number)
                {
                    MessageBox.Show("선택한 숫자가 더 큽니다");
                }
                else if (input < number)
                {
                    MessageBox.Show("선택한 숫자가 더 작습니다");
                }
                else
                {
                    MessageBox.Show("정답");
                    time = 0;
                    number = new Random().Next(1, 11);
                    Console.WriteLine("정답: " + number);
                    label_time.Text = "Finished";

                }
                
            }
        }

        private int time = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            if (time > 5)
            {
                label_time.Text = "Time Over";
                time = 0;
                number = new Random().Next(1, 11);
                Console.WriteLine("정답: " + number);
            }
            else
            {
                label_time.Text = time.ToString();
            }
        }
    }
}
