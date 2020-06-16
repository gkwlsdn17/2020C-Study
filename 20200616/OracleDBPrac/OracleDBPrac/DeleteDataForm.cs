using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OracleDBPrac
{
    public partial class DeleteDataForm : Form
    {
        OracleConnection conn = Form1.getOracleConnection();
        OracleCommand cmd = Form1.getOracleCommand();
        public DeleteDataForm()
        {
            InitializeComponent();
        }

        private void btn_deleteData(object sender, EventArgs e)
        {
            try
            {
                cmd.Connection = conn;
                cmd.CommandText = $"delete from student0616 where name = '{tb_name.Text}'";
                cmd.ExecuteNonQuery();

                MessageBox.Show("데이터를 삭제했습니다!");
            }
            catch(OracleException oe)
            {
                MessageBox.Show("데이터 삭제에 실패했습니다.\n"+oe.Message);
            }
        }

        private void btn_cancel(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_searchName(object sender, EventArgs e)
        {
            try
            {
                cmd.Connection = conn;
                cmd.CommandText = $"select * from student0616 where name = '{tb_searchName.Text}'";
                cmd.CommandType = System.Data.CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        tb_name.Text = dr["name"].ToString();
                        tb_age.Text = dr["age"].ToString();
                        tb_addr.Text = dr["addr"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("데이터가 없습니다");
                }
                dr.Close();
            }
            catch(OracleException oe)
            {
                MessageBox.Show("DB 검색 오류\r\n" + oe.Message);
            }
        }
    }
}
