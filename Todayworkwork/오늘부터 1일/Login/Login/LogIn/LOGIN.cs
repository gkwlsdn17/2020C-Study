using Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogIn
{
	public partial class Form1 : Form
	{
        //마우스로 창 이동
        bool On;
        Point Pos;

        public Form1()
		{
			InitializeComponent();
            rbtn_customer.Checked = true;
		}
        private string strconn = "Data Source=munggu.iptime.org,11113;Initial Catalog=TodayWorkWork;Persist Security Info=True;User ID=sa;Password=8765432!";
        private string table_name = "";
		private void btn_exit_Click(object sender, EventArgs e)
		{
            Application.Exit();
		}
        // 로그인 버튼 클릭
        private void btn_login_Click(object sender, EventArgs e)
        {
            login();
        }
        private void login()
        {
            SqlConnection conn = new SqlConnection(strconn);
            SqlCommand cmd;
            SqlDataAdapter sda;
            DataSet ds = new DataSet();
            conn.Open();
            // 고객 회원으로 로그인
            if (rbtn_customer.Checked == true)
            {
                table_name = "CUSTOMER";
                cmd = new SqlCommand($"select ID from {table_name} where ID = @ID and PW = @PW", conn);
                cmd.Parameters.AddWithValue("@ID", text_id.Text);
                cmd.Parameters.AddWithValue("@PW", text_pw.Text);
                sda = new SqlDataAdapter(cmd);
                sda.Fill(ds);
                // db에 정보가 있을 경우
                if (ds.Tables[0].Rows.Count == 1)
                {
                    //MessageBox.Show("개인 회원으로 로그인 되었습니다.");
                    IMemberMainForm imain = new IMemberMainForm();
                    IMemberMainForm.setID(text_id.Text);
                    IMemberMainForm.setFormOpen(true);
                    conn.Close();
                    imain.Show();
                    this.Close();

                }
                // db에 정보가 없을 경우
                else
                {
                    MessageBox.Show("등록된 회원 정보가 없습니다.");
                    conn.Close();
                }
            }
            // 기업 회원으로 로그인
            else
            {
                table_name = "COM_CUSTOMER";
                cmd = new SqlCommand($"select ID from {table_name} where ID = @ID and PW = @PW", conn);
                cmd.Parameters.AddWithValue("@ID", text_id.Text);
                cmd.Parameters.AddWithValue("@PW", text_pw.Text);
                sda = new SqlDataAdapter(cmd);
                sda.Fill(ds);
                // db에 정보가 있을 경우
                if (ds.Tables[0].Rows.Count == 1)
                {
                    //MessageBox.Show("기업 회원으로 로그인 되었습니다.");
                    ds.Reset();
                    MainForm main = new MainForm();
                    MainForm.setID(text_id.Text);
                    MainForm.setFormOpen(true);
                    conn.Close();
                    main.Show();
                    this.Close();
                }
                // db에 정보가 없을 경우
                else
                {
                    MessageBox.Show("등록된 회원 정보가 없습니다.");
                    conn.Close();
                }
            }
        }
        // 회원가입 버튼 클릭
        private void btn_signUp_Click(object sender, EventArgs e)
        {
            SignUp signupForm = new SignUp();
            signupForm.Show();
        }

        private void btn_idFind_Click(object sender, EventArgs e)
        {
            IDFind IDFindForm = new IDFind();
            IDFindForm.Show();
        }

        private void btn_pwFind_Click(object sender, EventArgs e)
        {
            PWFind PWFindForm = new PWFind();
            PWFindForm.Show();
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

    }
}
