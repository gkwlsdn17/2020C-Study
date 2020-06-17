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

namespace CRUD
{
    public partial class Form1 : Form
    {
        string strconn = "Data Source=192.168.0.200;Initial Catalog=khk_20200611;Persist Security Info=True;User ID=sa;Password=8765432!";
        public Form1()
        {
            InitializeComponent();
        }
        private void writeLog(string contents)
        {
            string logContents = $"[{DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")}] {contents}";
            Logwriter.printLog(logContents);
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                //MessageBox.Show($"선택한 값{dataGridView1[e.ColumnIndex,e.RowIndex].Value}");
                writeLog($"선택한 값{dataGridView1[e.ColumnIndex, e.RowIndex].Value}");

                textBox_id.Text = dataGridView1[0, e.RowIndex].Value.ToString();
                textBox_name.Text = dataGridView1[1, e.RowIndex].Value.ToString();
                textBox_age.Text = dataGridView1[2, e.RowIndex].Value.ToString();
                textBox_etc.Text = dataGridView1[4, e.RowIndex].Value.ToString();


            }
            catch (Exception exce)
            {
                MessageBox.Show(exce.Message);
                MessageBox.Show(exce.StackTrace);
                
            }
        }
        private void button_select_Click(object sender, EventArgs e)
        {
            writeLog("select 버튼 클릭");

            DataSet ds = new DataSet();

            SqlConnection sqlcon = new SqlConnection(strconn);
            sqlcon.Open();

            SqlDataAdapter adpt = new SqlDataAdapter("select * from MemberTable", sqlcon);
            adpt.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
            sqlcon.Close();
        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            writeLog("insert 버튼 클릭");

            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into MemberTable(ID,Name,age,rgdate,remark) values(@ID,@name,@age,getdate(),@bigo)", conn);
            cmd.Parameters.AddWithValue("@ID", textBox_id.Text);
            cmd.Parameters.AddWithValue("@name", textBox_name.Text);
            cmd.Parameters.AddWithValue("@age", textBox_age.Text);
            cmd.Parameters.AddWithValue("@bigo", textBox_etc.Text);
            cmd.ExecuteNonQuery();
            conn.Close();

            button_select.PerformClick();

        }


        private void button_update_Click(object sender, EventArgs e)
        {
            writeLog("update 버튼 클릭");

            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();
            SqlCommand cmd = new SqlCommand("update MemberTable set Name = @name,age=@age,remark=@bigo where ID=@id",conn);
            cmd.Parameters.AddWithValue("@id", textBox_id.Text);
            cmd.Parameters.AddWithValue("@name", textBox_name.Text);
            cmd.Parameters.AddWithValue("@age", textBox_age.Text);
            cmd.Parameters.AddWithValue("@bigo", textBox_etc.Text);
            cmd.ExecuteNonQuery();
            conn.Close();

            button_select.PerformClick();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            writeLog("delete 버튼 클릭");

            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from MemberTable where ID=@id", conn);
            cmd.Parameters.AddWithValue("@id", textBox_id.Text);
            cmd.ExecuteNonQuery();
            conn.Close();

            button_select.PerformClick();
        }
    }
}
