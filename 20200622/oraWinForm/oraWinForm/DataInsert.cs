﻿using System;
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
    public partial class DataInsert : Form
    {
        public delegate void subFormSendEvent(string name, int age, string addr);
        public event subFormSendEvent onSubFormSendEvent;
        public DataInsert()
        {
            InitializeComponent();
        }
        public void onSendData(object sender, EventArgs e)
        {
            string name = tb_name.Text;
            int age;
            int.TryParse(tb_age.Text,out age);
            string addr = tb_addr.Text;
            onSubFormSendEvent(name, age, addr);
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
