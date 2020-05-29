using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex05
{
    public partial class Form1 : Form
    {
        class GameCharacter
        {
            public static int mCountOfMember = 0;
            public string mId;

            public GameCharacter()
            {
                mCountOfMember++;
            }
        }
        public Form1()
        {
            InitializeComponent();
            TestClass t = new TestClass();
            t.test = 1;
            TestClass.tt = 5;
            Product pt = new Product();
            
            GameCharacter chulsoo = new GameCharacter() { mId = "chul" };
            GameCharacter yuri = new GameCharacter() { mId = "yuri000" };

            List<string> idList = new List<string>();
            idList.Add(chulsoo.mId);
            idList.Add(yuri.mId);

            for(int i = 0; i < idList.Count; i++)
            {
                Label lbl = new Label();
                lbl.Text = idList[i];
                Controls.Add(lbl);
                lbl.Location = new Point(13, 13 + 23 * i);
            }
            MessageBox.Show($"이 게임의 회원 수는 {idList.Count} 명 입니다");
        }
    }

    internal class Product
    {
        public Product()
        {
        }
    }
}
