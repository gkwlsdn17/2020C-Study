using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class Form1 : Form
    {
        int row = 10;
        int col = 10;
        Button[] btn = new Button[100];
        int btnWidth = 20;
        int btnHeight = 20;
        int startPointX = 30;
        int startPointY = 60;
        int[] mine = new int[100];

        public Form1()
        {
            InitializeComponent();
            
            for(int i = 0; i < row; i++)
            {
                for(int j = 0; j < col; j++)
                {
                    btn[i] = new Button();
                    btn[i].Size = new Size(btnWidth, btnHeight);
                    btn[i].Location = new Point(startPointX+btnWidth * i, startPointY+btnHeight * j);
                    btn[i].Click += Form1_Click;
                    Controls.Add(btn[i]);
                }
               
            }
            mineSet();

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            bt.Text = "1";
        }

        private void mineSet()
        {
            
            int mine_count = 10;
            int[] index = new int[mine_count];
            int i = 0;
            while(i<mine_count)
            {
                int num = new Random().Next(100);
                if (index.Contains(num))
                {
                    continue;
                }
                else
                {
                    index[i] = num;
                    i++;
                }
            }
            for(int j = 0; j < btn.Length; j++)
            {
                if(index.Contains(j)){
                    mine[j] = 1;
                }
            }

            
        }
    }
}
