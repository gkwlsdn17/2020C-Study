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
        public Form1()
        {
            InitializeComponent();
            Calculate cal = new Calculate();

            MessageBox.Show(cal.Power(5).ToString());
            MessageBox.Show(cal.Power(5,3).ToString());
            MessageBox.Show(cal.sumAll(10).ToString());
            MessageBox.Show(cal.sumAll(5,10).ToString());

            MessageBox.Show(ClassMethod.Power(5).ToString());
            MessageBox.Show(ClassMethod.Power(5,3).ToString());
            MessageBox.Show(ClassMethod.sumAll(10).ToString());
            MessageBox.Show(ClassMethod.sumAll(5,10).ToString());
        }
    }
}
