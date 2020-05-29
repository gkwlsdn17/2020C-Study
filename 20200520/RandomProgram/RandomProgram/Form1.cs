using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomProgram
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        int result;
        public Form1()
        {
            InitializeComponent();
            result = random.Next(15);
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = result.ToString();
            if (textBox1.Text == result.ToString())
            {
                label4.Text = "정답입니다";
            }
            else
            {
                label4.Text = "틀렸습니다";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            result = random.Next(15);
        }
    }
}
