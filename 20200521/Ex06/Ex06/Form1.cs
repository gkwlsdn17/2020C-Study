using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //인스턴스 메서드
            //new Test().print();

            //클래스 메서드
            TestClass2.print();
        }

        private void power_button_Click(object sender, EventArgs e)
        {
            int square = int.Parse(textBox1.Text);

            //case 1 인스턴스 메서드
            //Test test = new Test();
            //int result = test.Power(square);

            //case 2 클래스 메서드
            int result = TestClass2.Power(square);

            s_result.Text = result.ToString();
        }

        private void multi_button_Click(object sender, EventArgs e)
        {
            int mul1 = int.Parse(textBox2.Text);
            int mul2 = int.Parse(textBox3.Text);

            //인스턴스 메서드
            //Test test = new Test();
            //int result = test.Multi(mul1, mul2);

            //클래스 메서드
            int result = TestClass2.Multi(mul1, mul2);

            m_result.Text = result.ToString();
        }
    }
}
