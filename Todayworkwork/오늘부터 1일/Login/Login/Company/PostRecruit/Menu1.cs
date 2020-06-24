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

namespace Login
{
    public partial class Menu1 : UserControl
    {
        
        
        public Menu1()
        {
            InitializeComponent();
        }
           
          
            
            private void applyBtn_Click(object sender, EventArgs e)
            {
                  checkForm checkform = new checkForm();
                  checkform.StartPosition = FormStartPosition.Manual;
                  
                  checkform.Location = new Point(580,350);
                  checkform.Show();
            
            }

        
      }
}
