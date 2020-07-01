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

namespace Login.Company.ManagePost
{
    public partial class ApplicantList : Form
    {
        //DB연결
        string strconn = DBConnection.strconn;
        int w_num;
        public ApplicantList(int w_num)
        {
            InitializeComponent();
            this.w_num = w_num;
            lb_w_num.Text = "No. " + w_num.ToString();
        }

        private void ApplicantList_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection(strconn);
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand("select * from A_LIST where W_NUM = @w_num",sqlcon);
                cmd.Parameters.AddWithValue("@w_num", w_num);
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adpt.Fill(ds);
                init_list_setting(ds.Tables[0]);
                sqlcon.Close();
            }
            catch(Exception ee)
            {
                Console.WriteLine(ee.StackTrace);
            }
        }

        private void init_list_setting(DataTable table)
        {
            foreach (DataRow row in table.Rows)
            {
                string[] addr = row["A_ADDR"].ToString().Split(' ');
                string addr_convert;
                if (addr.Length < 2)
                {
                    addr_convert = addr[0];
                }
                else
                {
                    addr_convert = addr[0] + " " + addr[1];
                }
                dataGridView1.Rows.Add(row["A_ID"], row["A_NAME"], row["A_PHONE"], addr_convert);
            }
        }
    }


}
