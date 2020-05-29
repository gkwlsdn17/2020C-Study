using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //button_test.Text = "프로그램 시작 후 변경됨";
            //button_test.AutoSize = true;
            Random random = new Random();
            //button_test.Text = random.Next(1,10).ToString();
            button_test.Text = random.NextDouble().ToString();

            for(int i = 0; i < 5; i++)
            {
                Button button = new Button();
                Controls.Add(button);
                Point point = new Point();
                point.X = 13;
                point.Y = 100 + 13 + (23 + 3) * i;
                //button.Location = new Point(13, 13);
                button.Location = point;
                button.Text = "코드상 버튼" + (i+1);
                button.AutoSize = true;

                Random rand = new Random();
                bool visible = rand.Next(2) == 0 ? false:true;
                Thread.Sleep(10);
                button.Visible = visible;
            }

            
        }
    }
}
