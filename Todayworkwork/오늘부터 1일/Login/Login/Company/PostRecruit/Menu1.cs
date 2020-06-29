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
using Login.Company.PostRecruit;

namespace Login
{
    public partial class Menu1 : UserControl
    {
        string check;
        static PostInsert pi = new PostInsert();
        public Menu1()
        {
            InitializeComponent();
        }

        public static string getSbj()
        {
            return pi.text_Subject;
        }
        public static string getField()
        {
            return pi.text_Field;
        }
        public static string getPlace()
        {
            return pi.text_Place;
        }
        public static string getPay()
        {
            return pi.text_Pay;
        }
        public static string getContent()
        {
            return pi.text_Content;
        }
        public static DateTime getStart()
        {
            return pi.date_TimeStart;
        }
        public static DateTime getFinish()
        {
            return pi.date_TimeFinish;
        }
        public static DateTime getDead()
        {
            return pi.dead_LineTime;
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {
            pi.text_Subject = textSubject.Text;
            pi.text_Field = textField.Text;
            pi.text_Place = textPlace.Text;
            pi.text_Pay = textPay.Text;
            pi.text_Content = textContent.Text;
            pi.date_TimeStart = dateTimeStart.Value;
            pi.date_TimeFinish = dateTimeFinish.Value;
            pi.dead_LineTime = deadLineTime.Value;
            
            onCallcheckForm(sender, e);
            if (check == "yes")
            {
                Menu2.getInstance().BringToFront();
            }
        }
        
        private void textContent_Click(object sender, EventArgs e)
        {
            textContent.Text = "";
            textContent.ForeColor = System.Drawing.Color.Black;
        }
        private void onCallcheckForm(object sender, EventArgs e)
        {
            checkForm checkform = new checkForm();
            checkform.StartPosition = FormStartPosition.Manual;
            checkform.Location = new Point(580, 350);
            checkform.onCheckFormSendEvent += onGetMsgEvent;
            checkform.Show();
        }

        public void onGetMsgEvent(string str)
        {
            check = str;

        }
    }
}
