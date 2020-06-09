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
    public partial class BasicCalc : Form
    {
        public BasicCalc()
        {
            InitializeComponent();
        }

        private void onExit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void onHelp(object sender, EventArgs e)
        {
            MessageBox.Show("간단한 계산을 수행하는 앱","간단 계산기",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

       
        private void onAdd(object sender, EventArgs e)
        {
            int num1, num2;
            int.TryParse(input1.Text, out num1);
            int.TryParse(input2.Text, out num2);
            
            result.Text = (num1 + num2).ToString();
            
        }

        private void onSub(object sender, EventArgs e)
        {
            int num1, num2;
            num1 = Convert.ToInt32(input3.Text);
            num2 = Convert.ToInt32(input4.Text);

            result2.Text = (num1 - num2).ToString();
        }

        private void onMul(object sender, EventArgs e)
        {
            int num1, num2;
            num1 = Convert.ToInt32(input5.Text);
            num2 = Convert.ToInt32(input6.Text);

            result3.Text = (num1 * num2).ToString();
        }

        private void onDiv(object sender, EventArgs e)
        {
            int num1, num2;
            num1 = Convert.ToInt32(input7.Text);
            num2 = Convert.ToInt32(input8.Text);

            result4.Text = (num1 / num2).ToString();
        }

        private void onClear(object sender, EventArgs e)
        {
            input1.Clear(); 
            input2.Clear();
            input3.Clear();
            input4.Clear();
            input5.Clear();
            input6.Clear();
            input7.Clear();
            input8.Clear();
            result.Clear();
            result2.Clear();
            result3.Clear();
            result4.Clear();

            
        }
    }
}
