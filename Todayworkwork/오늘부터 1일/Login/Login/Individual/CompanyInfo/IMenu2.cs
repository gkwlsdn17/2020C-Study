using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login.Individual.CompanyInfo;
using System.Data.SqlClient;

namespace Login
{
    public partial class IMenu2 : UserControl
    {
        string strconn = "Data Source=munggu.iptime.org,11113;Initial Catalog=TodayWorkWork;Persist Security Info=True;User ID=sa;Password=8765432!";
        int count;
        
        public IMenu2()
        {
            InitializeComponent();
        }
        private void infoItemView(DataSet ds)
        {
            InfoItem[] infolist = new InfoItem[count];
            int i = 0;
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                infolist[i] = new InfoItem();
                infolist[i].lb_COM_NAME = item["COM_NAME"].ToString();
                infolist[i].lb_FIELD = item["FIELD"].ToString();
                double point;
                double.TryParse(item["STAR_PT"].ToString(), out point);
                infolist[i].lb_POINT = point;
                int sales;
                int.TryParse(item["SALES"].ToString(), out sales);
                infolist[i].lb_SALES = sales;
                infolist[i].lb_COM_TEL = item["COM_TEL"].ToString();
                int ap_count;
                int.TryParse(item["AP_COUNT"].ToString(), out ap_count);
                infolist[i].lb_AP_COUNT = ap_count;
                infolist[i].lb_COM_ADDR = item["COM_ADDR"].ToString();
                if (flowLayoutPanel1.Controls.Count < 0)
                {
                    flowLayoutPanel1.Controls.Clear();
                }
                flowLayoutPanel1.Controls.Add(infolist[i]);
                i++;
            }
        }

        private void IMenu2_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlConnection sqlcon = new SqlConnection(strconn);
            sqlcon.Open();

            SqlDataAdapter adpt = new SqlDataAdapter("select * from COM_INFO", sqlcon);
            adpt.Fill(ds);
            count = ds.Tables[0].Rows.Count;
            infoItemView(ds);
            sqlcon.Close();
        }
    }
}
