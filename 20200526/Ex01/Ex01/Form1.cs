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
    class MyClass
    {
        public void test()
        {
            
        }
    }
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            MessageBox.Show(Test(1000).ToString());
        }
        private static void print()
        {

        }
        public int Test(int input)
        {
            return 0;
        }

        public int Test(int input, int input2)
        {
            return 0;
        }

       
        //public double Test(int input)
        //{
        //    //오버로딩 하려면 반환형이 같아야 한다.
        //}
    }
}
