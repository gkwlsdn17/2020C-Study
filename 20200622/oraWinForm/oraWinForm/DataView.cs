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
    public partial class DataView : Form
    {
        public DataView()
        {
            InitializeComponent();
            
        }
        public void initListView()
        {
            string[] data = { "1", "홍길동", "200", "대구 동구 신천동" };
            listView1.Items.Add(new ListViewItem(data));
            for (int i = 0; i < 100; i++)
            {
                listView1.Items.Add(new ListViewItem(
                    new string[]
                    {
                        (i+2).ToString(),"홍길동",(100+i).ToString(),"대구 동구 신천1동"
                    }
                ));
            }

            //listView의 마지막 행 자동 선택
            int index = listView1.Items.Count - 1;
            listView1.Items[index].Selected = true;
            listView1.Items[index].Focused = true;
            listView1.Focus();
            listView1.EnsureVisible(index);

            //선택된 마지막행 컬럼값 변경
            listView1.Items[listView1.FocusedItem.Index].SubItems[1].Text = "전우치";
            listView1.Items[listView1.FocusedItem.Index].SubItems[2].Text = (200).ToString();
            listView1.Items[listView1.FocusedItem.Index].SubItems[3].Text = "조선 팔도";

           
        }

        private void DataView_Load(object sender, EventArgs e)
        {
            initListView();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            //선택한 행의 값을 가져오기
            MessageBox.Show(listView1.Items[listView1.FocusedItem.Index].SubItems[0].Text+"\r\n"+listView1.Items[listView1.FocusedItem.Index].SubItems[1].Text);
        }
    }
}
