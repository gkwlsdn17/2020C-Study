using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class MainForm : Form
    {
        //마우스로 창 이동
        bool On;
        Point Pos;

        private Button currentButton = null;
        
        public MainForm(string id)
        {
            InitializeComponent();
            Timer timer = new Timer();
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();
        }
        
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != null)
                {
                    currentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
                    currentButton.ForeColor = System.Drawing.Color.White;


                }
                if (currentButton != (Button)btnSender)
                {
                    currentButton = (Button)btnSender;

                    currentButton.BackColor = System.Drawing.Color.White;
                    currentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));

                }
            }
        }
        private void btn_menu1_Click(object sender, EventArgs e)
        {
            menu11.BringToFront();
            ActivateButton(btn_menu1);
        }

        private void btn_menu2_Click(object sender, EventArgs e)
        {
            menu21.BringToFront();
            ActivateButton(btn_menu2);
        }

        private void btn_menu3_Click(object sender, EventArgs e)
        {
            menu31.BringToFront();
            ActivateButton(btn_menu3);
        }

        private void btn_menu4_Click(object sender, EventArgs e)
        {
            menu41.BringToFront();
            ActivateButton(btn_menu4);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            On = true;
            Pos.X = e.X;
            Pos.Y = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (On == true)
            {
                this.SetDesktopLocation(MousePosition.X - Pos.X, MousePosition.Y - Pos.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            On = false;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            string timeView = time.ToString("yyyy") + "년 " + time.ToString("MM") + "월 " + time.ToString("dd") + "일 " + "(" + time.ToString("ddd") + ") " + time.ToString("hh") + "시" + time.ToString("mm") + "분" + time.ToString("ss") + "초";
            lb_date.Text = timeView;
        }
    }
}
