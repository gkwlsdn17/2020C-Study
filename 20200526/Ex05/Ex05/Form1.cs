using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_swap_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox_beforeNum1.Text);
            int b = int.Parse(textBox_beforeNum2.Text);
            swap(ref a, ref b);
            textBox_afterNum1.Text = a.ToString();
            textBox_afterNum2.Text = b.ToString();
        }
        
        private void swap(ref int a,ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
