using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.Individual.Review
{
    public partial class View_Review : Form
    {
        DataRow dr;
        public View_Review(DataSet ds)
        {
            InitializeComponent();
            dr = ds.Tables[0].Rows[0];
        }
        private void View_Review_Load(object sender, EventArgs e)
        {
            label_rev_subject.Text = dr["r_subject"].ToString();
            label_rev_content.Text = dr["r_content"].ToString();
            label_rev_num.Text = dr["r_num"].ToString();
            label_rev_field.Text = dr["r_field"].ToString();
            label_rev_comName.Text = dr["r_comName"].ToString();
            label_rev_rate.Text = dr["r_rate"].ToString();
            label_rev_place.Text = dr["r_place"].ToString();
            DateTime w_date = (DateTime)dr["W_DATE"];
            label_rev_date.Text = w_date.ToString("yyyy/MM/dd");
        }

        // 뒤로가기 버튼 클릭
        private void btn_back_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
