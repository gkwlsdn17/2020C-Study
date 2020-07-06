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

namespace Login.Company
{
    public partial class ChangeComMyInfo : Form
    {
        //마우스로 창 이동
        bool On;
        Point Pos;

        //메인폼에 메시지 전달
        public delegate void sendMsgDelegate(string msg);
        public event sendMsgDelegate sendMsg;

        public ChangeComMyInfo()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChangeMyInfo_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            text_phone.Text = MainForm.getPhone();
            text_name.Text = MainForm.getName();
            text_addr.Text = MainForm.getAddr();
            text_email.Text = MainForm.getEmail();
            text_comName.Text = MainForm.getCom_name();
            text_comTel.Text = MainForm.getCom_tel();
            text_comAddr.Text = MainForm.getCom_addr();
            text_comNum.Text = MainForm.getCom_num();
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

        // 이름, 주소, 회사이름, 회사주소, 사업자번호, 회원 핸드폰번호, 회사 전화번호, 회원 이메일 정보를 업데이트 한다.
        private void btn_update_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(DBConnection.strconn);
            try
            {
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand("update COM_CUSTOMER set NAME=@name, ADDR=@addr, COM_NAME=@com_name"+
                    ", COM_ADDR=@com_addr, COM_NUM=@com_num, PHONE = @phone"+
                    ", COM_TEL=@com_tel, EMAIL=@email where ID = @id",sqlcon);
                cmd.Parameters.AddWithValue("@name", text_name.Text);
                cmd.Parameters.AddWithValue("@addr", text_addr.Text);
                cmd.Parameters.AddWithValue("@com_name", text_comName.Text);
                cmd.Parameters.AddWithValue("@com_addr", text_comAddr.Text);
                cmd.Parameters.AddWithValue("@com_num", text_comNum.Text);
                cmd.Parameters.AddWithValue("@phone", text_phone.Text);
                cmd.Parameters.AddWithValue("@com_tel", text_comTel.Text);
                cmd.Parameters.AddWithValue("@email", text_email.Text);
                cmd.Parameters.AddWithValue("@id", MainForm.getID());
                cmd.ExecuteNonQuery();
                MessageBox.Show("수정이 완료되었습니다!");
                sendMsg("OK");
            }
            catch(Exception ee)
            {
                Console.WriteLine(ee.StackTrace);
            }
            finally
            {
                if(sqlcon!=null)
                    sqlcon.Close();
                this.Close();
            }
            
                      
        }
    }
}
