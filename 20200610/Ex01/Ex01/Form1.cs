using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex01
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        private int n = 10;
        public Form1()
        {
            n = 300;
            InitializeComponent();
            lvDummy.Columns.Add("Name");
            lvDummy.Columns.Add("Depth");
        }

        private void cboFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeFont();
        }

        void changeFont()
        {
            if(cboFont.SelectedIndex < 0)
            {
                return;
            }
            FontStyle style = FontStyle.Regular;
            if (chkBold.Checked)
            {
                style |= FontStyle.Bold;
            }
            if (chkItalic.Checked)
            {
                style |= FontStyle.Italic;
            }

            txtSampleText.Font = new Font((string)cboFont.SelectedItem, 10, style);
        }

        private void formLoad(object sender, EventArgs e)
        {
            var Fonts = FontFamily.Families;
            foreach (FontFamily font in Fonts)
            {
                cboFont.Items.Add(font.Name);
            }
        }

        private void changeFont(object sender, EventArgs e)
        {
            FontStyle style = FontStyle.Regular;
            if (chkBold.Checked)
            {
                style |= FontStyle.Bold;
            }
            if (chkItalic.Checked)
            {
                style |= FontStyle.Italic;
            }

            txtSampleText.Font = new Font((string)cboFont.SelectedItem, 10, style);
        }

        private void tbDummy_Scroll(object sender, EventArgs e)
        {
            pgDummy.Value = tbDummy.Value;
        }

        private void btnModal_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            frm.Text = "모달창";
            frm.Width = 300;
            frm.Height = 100;
            frm.BackColor = Color.Red;
            frm.ShowDialog();
        }

        private void btnModaless_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            frm.Text = "모달리스창";
            frm.Width = 300;
            frm.Height = 100;
            frm.BackColor = Color.Blue;
            frm.Show();
        }

        private void btnMessageBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtSampleText.Text, "메시지박스창", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
        }


        private void btnAddRoot_Click(object sender, EventArgs e)
        {
            tvDummy.Nodes.Add(random.Next(30).ToString());
            treeToList();
        }

        private void btnAddChild_Click(object sender, EventArgs e)
        {
            if(tvDummy.SelectedNode == null)
            {
                MessageBox.Show("선행된 노드가 없습니다","트리뷰",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            tvDummy.SelectedNode.Nodes.Add(random.Next(30).ToString());
            tvDummy.SelectedNode.Expand();
            treeToList();

        }
        void treeToList()
        {
            lvDummy.Items.Clear();
            foreach(TreeNode node in tvDummy.Nodes)
            {
                treeToList(node);
            }
        }
        void treeToList(TreeNode node)
        {
            lvDummy.Items.Add(
                new ListViewItem(new string[] {
                    node.Text, node.FullPath.Count(f=> f == '\\').ToString()
                    }
                )
             );
            foreach(TreeNode n in node.Nodes)
            {
                treeToList(n);
            }
        }
    }
}
