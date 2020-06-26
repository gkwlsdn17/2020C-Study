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
    public partial class PWFind : Form
    {
        private string strconn = "Data Source=munggu.iptime.org,11113;Initial Catalog=TodayWorkWork;Persist Security Info=True;User ID=sa;Password=8765432!";
        private string table_name = "";

        public PWFind()
        {
            InitializeComponent();
            rbtn_customer.Checked = true;
        }
        // 찾기 버튼 클릭
        private void btn_pwFind_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strconn);
            SqlCommand cmd;
            SqlDataAdapter sda;
            DataSet ds = new DataSet();
            conn.Open();
            if (rbtn_customer.Checked == true)
            {
                table_name = "CUSTOMER";
                cmd = new SqlCommand($"select PW from {table_name} where NAME = @NAME and ID = @ID and PHONE = @PHONE and EMAIL = @EMAIL", conn);
                cmd.Parameters.AddWithValue("@NAME", text_name.Text);
                cmd.Parameters.AddWithValue("@ID", text_id.Text);
                cmd.Parameters.AddWithValue("@PHONE", text_tel.Text);
                cmd.Parameters.AddWithValue("@EMAIL", text_email.Text);
                sda = new SqlDataAdapter(cmd);
                sda.Fill(ds);
                // db 정보 있을 경우
                if (ds.Tables[0].Rows.Count == 1)
                {
                    DataRow dr;
                    dr = ds.Tables[0].Rows[0];
                    string temp = (string)dr[0];
                    MessageBox.Show("비밀번호 : " + temp);
                }
                // db에 정보가 없을 경우
                else
                {
                    MessageBox.Show("등록된 회원 정보가 없습니다.");
                }
                conn.Close();
            }
            else
            {
                table_name = "COM_CUSTOMER";
                cmd = new SqlCommand($"select PW from {table_name} where NAME = @NAME and ID = @ID and PHONE = @PHONE and EMAIL = @EMAIL", conn);
                cmd.Parameters.AddWithValue("@NAME", text_name.Text);
                cmd.Parameters.AddWithValue("@ID", text_id.Text);
                cmd.Parameters.AddWithValue("@PHONE", text_tel.Text);
                cmd.Parameters.AddWithValue("@EMAIL", text_email.Text);
                sda = new SqlDataAdapter(cmd);
                sda.Fill(ds);
                // db 정보 있을 경우
                if (ds.Tables[0].Rows.Count == 1)
                {
                    DataRow dr;
                    dr = ds.Tables[0].Rows[0];
                    string temp = (string)dr[0];
                    MessageBox.Show("비밀번호 : " + temp);
                }
                // db에 정보가 없을 경우
                else
                {
                    MessageBox.Show("등록된 회원 정보가 없습니다.");
                }
                conn.Close();
            }
        }
    }
}
