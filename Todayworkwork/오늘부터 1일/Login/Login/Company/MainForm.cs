using Login.Company;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class MainForm : Form
    {
        //로그인에서 기업회원을 선택해서 로그인 할 경우 true로 바뀐다.
        private static bool formOpen = false;
        //마우스로 창 이동
        bool On;
        Point Pos;

        //메뉴 버튼을 누를 때 마다 현재 버튼이 어떤 버튼인지 알게 하고 색을 바꿈
        private Button currentButton = null;

        private static string userid;
        static Com_customer user = new Com_customer();

        //DB연결
        static string strconn = "Data Source=munggu.iptime.org,11113;Initial Catalog=TodayWorkWork;Persist Security Info=True;User ID=sa;Password=8765432!";

        public MainForm()
        {
            InitializeComponent();

            //현재 날짜 및 시간
            Timer timer = new Timer();
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();
            
            //메뉴2는 static 변수로 선언, 다른 폼에서 참조 가능
            Menu2.setInstance(menu21);
        }
        public static string getSqlSet()
        {
            return strconn;
        }
        private void readUserInfo(string id) //로그인 된 사용자의 정보를 읽어서 Com_customer클래스에 넣어줌
        {
            SqlConnection sqlcon = new SqlConnection(strconn);
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand("select * from COM_CUSTOMER where id = @id", sqlcon);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader sdr = cmd.ExecuteReader();
            
            while (sdr.Read())
            {
                user.ID = sdr["ID"].ToString();
                user.PW = sdr["PW"].ToString();
                lb_username.Text = sdr["NAME"].ToString();
                user.NAME = lb_username.Text;
                user.ADDR = sdr["ADDR"].ToString();
                user.COM_NAME = sdr["COM_NAME"].ToString();
                user.COM_ADDR = sdr["COM_ADDR"].ToString();
                user.COM_NUM = sdr["COM_NUM"].ToString();
                user.PHONE = sdr["PHONE"].ToString();
                user.COM_TEL = sdr["COM_TEL"].ToString();
                user.EMAIL = sdr["EMAIL"].ToString();
            }
            sqlcon.Close();
        }
        public static void setID(string id)
        {
            userid = id;
        }
        public static string getID()
        {
            return user.ID;
        }
        public static string getPW()
        {
            return user.PW;
        }
        public static string getName()
        {
            return user.NAME;
        }
        public static string getAddr()
        {
            return user.ADDR;
        }
        public static string getCom_name()
        {
            return user.COM_NAME;
        }
        public static string getCom_addr()
        {
            return user.COM_ADDR;
        }
        public static string getCom_num()
        {
            return user.COM_NUM;
        }
        public static string getPhone()
        {
            return user.PHONE;
        }
        public static string getCom_tel()
        {
            return user.COM_TEL;
        }
        public static string getEmail()
        {
            return user.EMAIL;
        }
        private void ActivateButton(object btnSender) //현재 버튼과 직전의 버튼 색을 바꾸는 함수
        {
            if (btnSender != null)
            {
                if (currentButton != null)
                {
                    if(btnSender != currentButton)
                    {
                        currentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(166)))));
                        currentButton.ForeColor = System.Drawing.Color.White;
                    }


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
        
        private void panel1_MouseDown(object sender, MouseEventArgs e) //마우스로 창을 움직일 수 있게 하는 함수
        {
            On = true;
            Pos.X = e.X;
            Pos.Y = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e) //마우스로 창을 움직일 수 있게 하는 함수
        {
            if (On == true)
            {
                this.SetDesktopLocation(MousePosition.X - Pos.X, MousePosition.Y - Pos.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e) //마우스로 창을 움직일 수 있게 하는 함수
        {
            On = false;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e) //현재 시간 보여주는 함수
        {
            DateTime time = DateTime.Now;
            string timeView = time.ToString("yyyy") + "년 " + time.ToString("MM") + "월 " + time.ToString("dd") + "일 " + "(" + time.ToString("ddd") + ") " + time.ToString("hh") + "시" + time.ToString("mm") + "분" + time.ToString("ss") + "초";
            lb_date.Text = timeView;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
            if (formOpen == false)
            {
                this.Close();
            }
            if (userid == "admin")
            {
                btn_admin_menu.Visible = true;
            }
            //유저 데이터 불러옴
            readUserInfo(userid);

        }
        public static void setFormOpen(bool open)
        {
            formOpen = open;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            afterLoginMainPage1.BringToFront();
        }

        private void btn_admin_menu_Click(object sender, EventArgs e)
        {
            ComManage form = new ComManage();
            form.Show();
        }
        
        private void 사용자정보수정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeComMyInfo cmi = new ChangeComMyInfo();
            cmi.sendMsg += new ChangeComMyInfo.sendMsgDelegate(refreshInfo);
            cmi.Show();
        }
        private void refreshInfo(string msg)
        {
            if(msg == "OK")
            {
                readUserInfo(userid);
            }
        }

        private void 비밀번호변경ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeMyPW cmpw = new ChangeMyPW("COM_CUSTOMER");
            cmpw.Show();
        }
    }
}
