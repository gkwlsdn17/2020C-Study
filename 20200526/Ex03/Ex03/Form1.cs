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

            MessageBox.Show(Math.PI.ToString());

            Product p1 = new Product("감자", 1000);
            Product p2 = new Product("무우", 100);
            int j = 1 + Product.test;

            string showText = $"{p1.mId} : {p1.mName}" + Environment.NewLine + $"{p2.mId} : {p2.mName}" + Environment.NewLine + $"{Product.mCounter}개 생성되었습니다.";

            Label label = new Label();
            label.AutoSize = true;
            label.Text = showText;
            label.SetBounds(10, 10,20,20);
            Controls.Add(label);
        }
    }
}
