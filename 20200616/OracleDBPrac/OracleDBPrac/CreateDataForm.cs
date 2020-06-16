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
    public partial class CreateDataForm : Form
    {
        OracleConnection conn = Form1.getOracleConnection();
        OracleCommand cmd = Form1.getOracleCommand();
        public CreateDataForm()
        {
            InitializeComponent();
        }

        private void btn_createData(object sender, EventArgs e)
        {
            string name = tb_name.Text;
            int age;
            int.TryParse(tb_age.Text,out age);
            string addr = tb_addr.Text;
            try
            {
                cmd.Connection = conn;
                cmd.CommandText = $"insert into student0616 values (seq_student0616_id.nextval, '{name}',{age},'{addr}')";
                cmd.ExecuteNonQuery();

                MessageBox.Show("데이터 삽입에 성공했습니다!");
            }
            catch(OracleException oe)
            {
                MessageBox.Show("데이터 삽입을 실패했습니다.\n" + oe.Message);
            }
            
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            
            this.Close();

        }
    }
}
