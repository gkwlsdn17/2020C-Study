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

namespace Login
{
    public partial class SignUp : Form
    {
        //마우스로 창 이동
        bool On;
        Point Pos;

        string strconn = "Data Source=munggu.iptime.org,11113;Initial Catalog=TodayWorkWork;Persist Security Info=True;User ID=sa;Password=8765432!";
        string table_name = "CUSTOMER";

        public SignUp()
        {
            InitializeComponent();
            rbtn_customer.Checked = true;
        }
        // 고객 회원 라디오 버튼 클릭 - textbox 비활성화
        private void rbtn_customer_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_customer.Checked == true)
            {
                text_comAddr.Enabled = false;
                text_comNum.Enabled = false;
                text_comName.Enabled = false;
                text_comTel.Enabled = false;
            }
            else
            {
                text_comAddr.Enabled = true;
                text_comNum.Enabled = true;
                text_comName.Enabled = true;
                text_comTel.Enabled = true;
            }
        }
        // id 중복확인 버튼
        private void btn_idCheck_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strconn);
            SqlCommand cmd;
            SqlDataAdapter sda;
            DataSet ds = new DataSet();
            conn.Open();
            // 개인 회원 테이블 확인
            if (rbtn_customer.Checked == true)
            {
                table_name = "CUSTOMER";
                cmd = new SqlCommand($"select ID from {table_name} where ID = @ID", conn);
                cmd.Parameters.AddWithValue("@ID", text_id.Text);
                sda = new SqlDataAdapter(cmd);
                sda.Fill(ds);
                // 중복된 id가 있을 경우
                if( ds.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("아이디가 중복됩니다.\n다른 아이디를 입력하세요.");
                    ds.Reset();
                }
                // 중복된 id가 없을 경우
                else
                {
                    MessageBox.Show("아이디 사용 가능");
                }
            }
            // 기업 회원 테이블 확인
            else
            {
                table_name = "COM_CUSTOMER";
                cmd = new SqlCommand($"select ID from {table_name} where ID = @ID", conn);
                cmd.Parameters.AddWithValue("@ID", text_id.Text);
                sda = new SqlDataAdapter(cmd);
                sda.Fill(ds);
                // 중복된 id가 있을 경우
                if (ds.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("아이디가 중복됩니다.\n다른 아이디를 입력하세요.");
                    ds.Reset();
                }
                // 중복된 id가 없을 경우
                else
                {
                    MessageBox.Show("아이디 사용 가능");
                }
            }
            conn.Close();
        }
        // 회원가입 버튼 클릭
        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strconn);
            SqlCommand cmd;
            conn.Open();
            // 고객 회원 라디오 버튼 클릭
            if (rbtn_customer.Checked == true)
            {
                table_name = "CUSTOMER";
                cmd = new SqlCommand($"insert into {table_name} (ID, PW, NAME, ADDR, EMAIL, PHONE) values (@ID, @PW, @NAME, @ADDR, @EMAIL, @PHONE)", conn);
                cmd.Parameters.AddWithValue("@ID", text_id.Text);
                cmd.Parameters.AddWithValue("@PW", text_pw.Text);
                cmd.Parameters.AddWithValue("@NAME", text_name.Text);
                cmd.Parameters.AddWithValue("@ADDR", text_addr.Text);
                cmd.Parameters.AddWithValue("@EMAIL", text_email.Text);
                cmd.Parameters.AddWithValue("@PHONE", text_phone.Text);
                MessageBox.Show("개인 회원가입 되었습니다.");
            }
            // 기업 회원 라디오 버튼 클릭
            else
            {
                table_name = "COM_CUSTOMER";
                cmd = new SqlCommand($"insert into {table_name} (ID, PW, NAME, ADDR, COM_NAME, COM_ADDR, COM_NUM, PHONE, COM_TEL, EMAIL) values (@ID, @PW, @NAME, @ADDR, @COM_NAME, @COM_ADDR, @COM_NUM, @PHONE, @COM_TEL, @EMAIL)", conn);
                cmd.Parameters.AddWithValue("@ID", text_id.Text);
                cmd.Parameters.AddWithValue("@PW", text_pw.Text);
                cmd.Parameters.AddWithValue("@NAME", text_name.Text);
                cmd.Parameters.AddWithValue("@ADDR", text_addr.Text);
                cmd.Parameters.AddWithValue("@COM_NAME", text_comName.Text);
                cmd.Parameters.AddWithValue("@COM_ADDR", text_addr.Text);
                cmd.Parameters.AddWithValue("@COM_NUM", Convert.ToInt32(text_comNum.Text));
                cmd.Parameters.AddWithValue("@PHONE", text_phone.Text);
                cmd.Parameters.AddWithValue("@COM_TEL", text_comTel.Text);
                cmd.Parameters.AddWithValue("@EMAIL", text_email.Text);
                MessageBox.Show("기업 회원가입 되었습니다.");
            }
            cmd.ExecuteNonQuery();
            conn.Close();
            Close();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
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
