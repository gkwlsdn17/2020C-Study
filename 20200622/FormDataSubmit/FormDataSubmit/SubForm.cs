using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormDataSubmit
{
    public partial class SubForm : Form
    {
        public delegate void subFormSendEvent(string msg);
        public event subFormSendEvent onSubFormSendEvent;
        public SubForm()
        {
            InitializeComponent();
        }
        public SubForm(string data)
        {
            InitializeComponent();
            textBox1.Text = data;
        }
        private void onExit(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            onSubFormSendEvent(str);
            Close();
        }
    }
}
