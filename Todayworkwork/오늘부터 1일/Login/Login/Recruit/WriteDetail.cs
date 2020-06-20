using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.Recruit
{
    public partial class WriteDetail : Form
    {
        DataRow dr;
        public WriteDetail(DataSet ds)
        {
            InitializeComponent();
            dr = ds.Tables[0].Rows[0];
            

        }
        

        private void btn_뒤로가기_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void WriteDetail_Load(object sender, EventArgs e)
        {
            lb_subject.Text = (string)dr["subject"];
        }
    }
}
