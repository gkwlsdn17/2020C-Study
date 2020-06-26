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
    public partial class ComManage : Form
    {
        //DB연결
        string strconn = "Data Source=munggu.iptime.org,11113;Initial Catalog=TodayWorkWork;Persist Security Info=True;User ID=sa;Password=8765432!";
        string current_row_com_name;
        string current_com_num;
        public ComManage()
        {
            InitializeComponent();
        }

        private void ComManage_Load(object sender, EventArgs e)
        {
            select_all();
        }
        private void select_all()
        {
            SqlConnection sqlcon = new SqlConnection(strconn);
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand("Select * from COM_INFO", sqlcon);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adpt.Fill(ds);
            dataGridView1.Rows.Clear();
            initList(ds.Tables[0]);
            sqlcon.Close();
        }
        private void initList(DataTable table)
        {
            int count = 1;
            foreach (DataRow row in table.Rows)
            {
                dataGridView1.Rows.Add(count, row["COM_NUM"], row["COM_NAME"]);
                count++;
            }
        }
        
        private void btn_clear_Click(object sender, EventArgs e)
        {
            text_clean();
        }
        private void text_clean()
        {
            tb_ap_count.Text = "";
            tb_com_addr.Text = "";
            tb_com_name.Text = "";
            tb_com_num.Text = "";
            tb_com_tel.Text = "";
            tb_field.Text = "";
            tb_sales.Text = "";
            tb_search.Text = "";
            tb_star_pt.Text = "";
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            search();
        }
        private void search()
        {
            SqlConnection sqlcon = new SqlConnection(strconn);
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand("Select * from COM_INFO where COM_NAME LIKE '%'+ @com_name +'%'", sqlcon);
            cmd.Parameters.AddWithValue("@com_name", tb_search.Text);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adpt.Fill(ds);
            dataGridView1.Rows.Clear();
            initList(ds.Tables[0]);
            sqlcon.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            current_row_com_name = dataGridView1[2, e.RowIndex].Value.ToString();
            current_com_num = dataGridView1[1, e.RowIndex].Value.ToString();
            SqlConnection sqlcon = new SqlConnection(strconn);
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand("Select * from COM_INFO where COM_NAME = @com_name", sqlcon);
            cmd.Parameters.AddWithValue("@com_name", current_row_com_name);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adpt.Fill(ds);

            DataRow row = ds.Tables[0].Rows[0];
            tb_ap_count.Text = row["AP_COUNT"].ToString();
            tb_com_addr.Text = row["COM_ADDR"].ToString();
            tb_com_name.Text = row["COM_NAME"].ToString();
            tb_com_num.Text = row["COM_NUM"].ToString();
            tb_com_tel.Text = row["COM_TEL"].ToString();
            tb_field.Text = row["FIELD"].ToString();
            tb_sales.Text = row["SALES"].ToString();
            tb_star_pt.Text = row["STAR_PT"].ToString();
            sqlcon.Close();
        }
        
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            current_row_com_name = dataGridView1[2, e.RowIndex].Value.ToString();
            current_com_num = dataGridView1[1, e.RowIndex].Value.ToString();
            SqlConnection sqlcon = new SqlConnection(strconn);
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand("Select * from COM_INFO where COM_NAME = @com_name", sqlcon);
            cmd.Parameters.AddWithValue("@com_name", current_row_com_name);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adpt.Fill(ds);
            
            DataRow row = ds.Tables[0].Rows[0];
            tb_ap_count.Text = row["AP_COUNT"].ToString();
            tb_com_addr.Text = row["COM_ADDR"].ToString();
            tb_com_name.Text = row["COM_NAME"].ToString();
            tb_com_num.Text = row["COM_NUM"].ToString();
            tb_com_tel.Text = row["COM_TEL"].ToString();
            tb_field.Text = row["FIELD"].ToString();
            tb_sales.Text = row["SALES"].ToString();
            tb_star_pt.Text = row["STAR_PT"].ToString();
            sqlcon.Close();
            
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(strconn);
            sqlcon.Open();
            try
            {
                
                SqlCommand cmd = new SqlCommand("insert into COM_INFO values(@com_num,@com_name,@com_addr,@field,@com_tel,@sales,@ap_count,@star_pt)", sqlcon);
                cmd.Parameters.AddWithValue("@com_num", tb_com_num.Text);
                cmd.Parameters.AddWithValue("@com_name", tb_com_name.Text);
                cmd.Parameters.AddWithValue("@com_addr", tb_com_name.Text);
                cmd.Parameters.AddWithValue("@field", tb_com_name.Text);
                cmd.Parameters.AddWithValue("@com_tel", tb_com_name.Text);
                int sales = int.Parse(tb_sales.Text);
                cmd.Parameters.AddWithValue("@sales", sales);
                int ap_count = int.Parse(tb_ap_count.Text);
                cmd.Parameters.AddWithValue("@ap_count", ap_count);
                float star_pt = float.Parse(tb_star_pt.Text);
                cmd.Parameters.AddWithValue("@star_pt", star_pt);
                cmd.ExecuteNonQuery();
                select_all();
            }
            catch(Exception ee)
            {
                if (string.Equals(current_row_com_name,tb_com_name))
                {
                    MessageBox.Show("회사이름이 같아서 등록불가");
                }
                else
                {

                    MessageBox.Show(ee.StackTrace);
                }
            }
            finally
            {
                sqlcon.Close();
            }
            

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            tb_com_num.ReadOnly = true;
            try
            {
                SqlConnection sqlcon = new SqlConnection(strconn);
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand("update COM_INFO set COM_NUM=@com_num, COM_NAME=@com_name, COM_ADDR=@com_addr, FIELD=@field, COM_TEL=@com_tel, SALES = @sales, AP_COUNT = @ap_count, STAR_PT = @star_pt where COM_NUM = @before_com_num", sqlcon);
                cmd.Parameters.AddWithValue("@com_num", tb_com_num.Text);
                cmd.Parameters.AddWithValue("@com_name", tb_com_name.Text);
                cmd.Parameters.AddWithValue("@com_addr", tb_com_addr.Text);
                cmd.Parameters.AddWithValue("@field", tb_field.Text);
                cmd.Parameters.AddWithValue("@com_tel", tb_com_tel.Text);
                int sales = int.Parse(tb_sales.Text);
                cmd.Parameters.AddWithValue("@sales", sales);
                int ap_count = int.Parse(tb_ap_count.Text);
                cmd.Parameters.AddWithValue("@ap_count", ap_count);
                float star_pt = float.Parse(tb_star_pt.Text);
                cmd.Parameters.AddWithValue("@star_pt", star_pt);
                cmd.Parameters.AddWithValue("@before_com_num", current_com_num);
                
                cmd.ExecuteNonQuery();
                sqlcon.Close();
                select_all();
            }
            catch(Exception ee)
            {
               MessageBox.Show("수정할수없음\r\n" + ee.StackTrace);
            }
            
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection(strconn);
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand("delete from COM_INFO where COM_NAME = @com_name", sqlcon);
                cmd.Parameters.AddWithValue("@com_name", current_row_com_name);
                cmd.ExecuteNonQuery();
                select_all();
                text_clean();
                sqlcon.Close();
            }
            catch(Exception ee)
            {
                MessageBox.Show("삭제할수없음\r\n"+ee.StackTrace);
            }
            
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            select_all();
        }
    }
}
