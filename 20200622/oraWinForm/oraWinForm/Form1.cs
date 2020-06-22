using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oraWinForm
{
    public partial class Form1 : Form
    {
        DbManager db = DbManager.getInstance();
        string name; int age; string addr; bool check=false;
        public Form1()
        {
            InitializeComponent();
            DbManager.getInstance().dbConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.createTable();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            db.dropTable();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //db.insertDB();
            onSubCallEvent(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            db.selectDB();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            db.deleteDB();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            db.updateDB();
            

        }
        private void onSubCallEvent(object sender, EventArgs e)
        {
            if((Button)sender == button3)
            {
                DataInsert insert = new DataInsert();
                insert.onSubFormSendEvent += onGetMsgEvent;
                insert.ShowDialog();
                if(check)db.insertDBForm(name, age, addr);
            }
            
        }
        public void onGetMsgEvent(string name,int age, string addr)
        {
            if (name == null && age==0 && addr==null)
            {
                check = false;

            }
            else
            {
                this.name = name;
                this.age = age;
                this.addr = addr;
                check = true;
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("오라클 DB 관리 프로그램 v1.4\n2020.6.22","프로그램정보", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
