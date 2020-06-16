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
    public partial class UpdateDataForm : Form
    {
        OracleConnection conn = Form1.getOracleConnection();
        OracleCommand cmd = Form1.getOracleCommand();
        public UpdateDataForm()
        {
            InitializeComponent();
        }

        private void btn_updateData(object sender, EventArgs e)
        {
            try
            {
                cmd.Connection = conn;
                cmd.CommandText = $"update student0616 set name='{tb_afterName.Text}',age={int.Parse(tb_afterAge.Text)},addr='{tb_afterAddr.Text}' where name='{tb_beforeName.Text}' and age={int.Parse(tb_beforeAge.Text)} and addr='{tb_beforeAddr.Text}'";
                cmd.ExecuteNonQuery();

                MessageBox.Show("데이터 수정에 성공했습니다!");
                this.Close();
            }
            catch(OracleException oe)
            {
                MessageBox.Show("데이터 수정에 실패했습니다.\r\n" + oe.Message);
            }

        }

        private void btn_cancel(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_searchData(object sender, EventArgs e)
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
                        tb_beforeName.Text = dr["name"].ToString();
                        tb_beforeAge.Text = dr["age"].ToString();
                        tb_beforeAddr.Text = dr["addr"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("데이터가 없습니다");
                }
                dr.Close();
            }
            catch (OracleException oe)
            {
                MessageBox.Show("DB 검색 오류\r\n" + oe.Message);
            }
        }
    }
}
