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
using Login.PostRecruit;
using System.Collections;

namespace Login
{
    public partial class Menu1 : UserControl
    {

        string check;
        public Menu1()
        {
            InitializeComponent();
        }



        private void applyBtn_Click(object sender, EventArgs e)
        {
            /*
                  checkForm checkform = new checkForm();
                  checkform.StartPosition = FormStartPosition.Manual;
                  
                  checkform.Location = new Point(580,350);
                  checkform.Show();
            */
            onCallcheckForm(sender, e);
            if (check=="yes")
            {
                Menu2.getInstance().BringToFront();
            }
        }

        private void onCallcheckForm(object sender, EventArgs e)
        {
            checkForm sub = new checkForm();
            sub.onCheckFormSendEvent += onGetMsgEvent;
            sub.ShowDialog();
        }
        
        public void onGetMsgEvent(string str)
        {
            check = str;
            
        }

    }
}
