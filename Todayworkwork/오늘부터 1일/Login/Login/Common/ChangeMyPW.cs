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
    public partial class ChangeMyPW : Form
    {
        //마우스로 창 이동
        bool On;
        Point Pos;

        string table;
        public ChangeMyPW(string table)
        {
            InitializeComponent();
            this.table = table;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (table == "COM_CUSTOMER")
            {
                if (text_currentPW.Text.Equals(MainForm.getPW()))
                {
                    if (text_changePW.Text.Equals(text_check.Text))
                    {
                        SqlConnection sqlcon = new SqlConnection(MainForm.getSqlSet());
                        sqlcon.Open();
                        SqlCommand cmd = new SqlCommand("update COM_CUSTOMER set PW = @pw where ID = @id", sqlcon);
                        cmd.Parameters.AddWithValue("@pw", text_changePW.Text);
                        cmd.Parameters.AddWithValue("@id", MainForm.getID());
                        cmd.ExecuteNonQuery();
                        sqlcon.Close();
                        MessageBox.Show("변경이 완료되었습니다.\r\n다시 로그인 해 주세요");
                        Application.Exit();
                    }
                    else
                    {
                        MessageBox.Show("바꿀 비밀번호 확인이 맞지 않습니다. 다시 입력 해 주세요");
                    }
                }
                else
                {
                    MessageBox.Show("비밀번호가 틀립니다. 다시 입력 해 주세요");
                }
            }
            else
            {
                if (text_currentPW.Text.Equals(IMemberMainForm.getPW()))
                {
                    if (text_changePW.Text.Equals(text_check.Text))
                    {
                        SqlConnection sqlcon = new SqlConnection(MainForm.getSqlSet());
                        sqlcon.Open();
                        SqlCommand cmd = new SqlCommand("update CUSTOMER set PW = @pw where ID = @id", sqlcon);
                        cmd.Parameters.AddWithValue("@pw", text_changePW.Text);
                        cmd.Parameters.AddWithValue("@id", IMemberMainForm.getID());
                        cmd.ExecuteNonQuery();
                        sqlcon.Close();
                        MessageBox.Show("변경이 완료되었습니다.\r\n다시 로그인 해 주세요");
                        Application.Exit();
                    }
                    else
                    {
                        MessageBox.Show("바꿀 비밀번호 확인이 맞지 않습니다. 다시 입력 해 주세요");
                    }
                }
                else
                {
                    MessageBox.Show("비밀번호가 틀립니다. 다시 입력 해 주세요");
                }
            }
        }

        private void ChangeMyPW_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
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
