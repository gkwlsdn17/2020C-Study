using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam
{
    class OSClass
    {
        string name = "";
        public OSClass()
        {
           
        }
        
        public virtual void setLable()
        {
            Label lb = new Label();
            lb.Text = "Label 입니다";
        }

    }
    class WindowClass : OSClass
    {
        public WindowClass()
        {

        }
        public override void setLable()
        {
            Label lb = new Label();
            lb.Text = "Windows 입니다";
        }
    }
    class Form2 : Form
    {
        public Form2()
        {

            Text = "Windows";
            Label lb1 = new Label();
            Point lbp = new Point();
            lbp.X = 50;
            lbp.Y = 100;
            lb1.Location = lbp;
            lb1.Text="Windows Display";
            Controls.Add(lb1);
        }
        
        
    }
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DialogResult result;
            result = MessageBox.Show("당신은 윈도우 사용자입니까?", "제목", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                Form2 windows = new Form2();
                windows.Show();
            }
        }
    }
}
