using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button_calc_Click(object sender, EventArgs e)
        {
            label_area.Text = "";
            double w = double.Parse(textBox_w.Text);
            double h = double.Parse(textBox_h.Text);

            //Box box = new Box(w,h);
            //box.width = w;
            //box.height = h;
            Box box = new Box();
            //box.setWidth(w);
            //box.setHeight(h);

            box.mWidth = w;
            box.mHeight = h;

            label_area.Text = box.Area().ToString();
        }
    }
}
