using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Login
{
    public partial class Menu3 : UserControl
    {
        //DB연결
        string strconn = DBConnection.strconn;
        public Menu3()
        {
            InitializeComponent();
            ShowDB();
        }
        //보여주기(셀렉트쿼리)
        public void ShowDB()
        {
            DataSet ds = new DataSet();

            SqlConnection sqlcon = new SqlConnection(strconn);
            sqlcon.Open();

            SqlDataAdapter adpt = new SqlDataAdapter("select RE_NUM, NAME, RE_SUBJECT, LICENSE, EXP, ADDR from RESUME", sqlcon);
            adpt.Fill(ds);

            RESUMEInfo.DataSource = ds.Tables[0];
            RESUMEInfo.Columns[0].Width = 45;
            RESUMEInfo.Columns[1].Width = 100;
            RESUMEInfo.Columns[2].Width = 450;
            RESUMEInfo.Columns[3].Width = 103;
            RESUMEInfo.Columns[4].Width = 102;
            RESUMEInfo.Columns[5].Width = 100;

            sqlcon.Close();
            RESUMEInfo.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        //전체보기
        private void btn_AllView_Click(object sender, EventArgs e)
        {
            ShowDB();
        }
        //기타버튼
        private void btn_CptView_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            SqlConnection sqlcon = new SqlConnection(strconn);
            sqlcon.Open();

            string C = "select * from RESUME where LICENSE like '%목%' or [EXP] like '%목%'";
            SqlCommand cmd = new SqlCommand(C, sqlcon);

            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = new SqlCommand(C, sqlcon);
            adpt.Fill(ds);

            RESUMEInfo.DataSource = ds.Tables[0];
            sqlcon.Close();
        }

        private void btn_ElecView_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            SqlConnection sqlcon = new SqlConnection(strconn);
            sqlcon.Open();

            string C = "select * from RESUME where LICENSE like '%전%' or [EXP] like '%전%'";
            SqlCommand cmd = new SqlCommand(C, sqlcon);

            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = new SqlCommand(C, sqlcon);
            adpt.Fill(ds);

            RESUMEInfo.DataSource = ds.Tables[0];
            sqlcon.Close();
        }

        private void btn_PipeView_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            SqlConnection sqlcon = new SqlConnection(strconn);
            sqlcon.Open();

            string C = "select * from RESUME where LICENSE like '%배%' or [EXP] like '%배%'";
            SqlCommand cmd = new SqlCommand(C, sqlcon);

            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = new SqlCommand(C, sqlcon);
            adpt.Fill(ds);

            RESUMEInfo.DataSource = ds.Tables[0];
            sqlcon.Close();
        }

        private void btn_MoldView_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            SqlConnection sqlcon = new SqlConnection(strconn);
            sqlcon.Open();

            string C = "select * from RESUME where LICENSE like '%몰%' or [EXP] like '%몰%'";
            SqlCommand cmd = new SqlCommand(C, sqlcon);

            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = new SqlCommand(C, sqlcon);
            adpt.Fill(ds);

            RESUMEInfo.DataSource = ds.Tables[0];
            sqlcon.Close();
        }

        private void btn_GasView_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            SqlConnection sqlcon = new SqlConnection(strconn);
            sqlcon.Open();

            string C = "select * from RESUME where LICENSE like '%가%' or [EXP] like '%가%'";
            SqlCommand cmd = new SqlCommand(C, sqlcon);

            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = new SqlCommand(C, sqlcon);
            adpt.Fill(ds);

            RESUMEInfo.DataSource = ds.Tables[0];
            sqlcon.Close();
        }

        private void btn_TileView_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            SqlConnection sqlcon = new SqlConnection(strconn);
            sqlcon.Open();

            string C = "select * from RESUME where LICENSE like '%타%' or [EXP] like '%타%'";
            SqlCommand cmd = new SqlCommand(C, sqlcon);

            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = new SqlCommand(C, sqlcon);
            adpt.Fill(ds);

            RESUMEInfo.DataSource = ds.Tables[0];
            sqlcon.Close();
        }

        private void btn_SashView_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            SqlConnection sqlcon = new SqlConnection(strconn);
            sqlcon.Open();

            string C = "select * from RESUME where LICENSE like '%새%' or [EXP] like '%새%'";
            SqlCommand cmd = new SqlCommand(C, sqlcon);

            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = new SqlCommand(C, sqlcon);
            adpt.Fill(ds);

            RESUMEInfo.DataSource = ds.Tables[0];
            sqlcon.Close();
        }

        private void btn_TWView_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            SqlConnection sqlcon = new SqlConnection(strconn);
            sqlcon.Open();

            string C = "select * from RESUME where LICENSE like '%일용%' or [EXP] like '%일용%'";
            SqlCommand cmd = new SqlCommand(C, sqlcon);

            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = new SqlCommand(C, sqlcon);
            adpt.Fill(ds);

            RESUMEInfo.DataSource = ds.Tables[0];
            sqlcon.Close();
        }
    }
    //버튼연결
}
