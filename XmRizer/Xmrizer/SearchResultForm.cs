using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrKhaled.Xmrizer
{
    public partial class SearchResultForm : MetroFramework.Forms.MetroForm
    {
        public List<TreeNode> Results { get; set; }
        public TreeView TreeView { get; set; }
        public string CurrentSelected { get; set; }

        public SearchResultForm(List<TreeNode> res , TreeView tv)
        {
            InitializeComponent();
            Results = res;
            TreeView = tv;
            CurrentSelected = "";
        }

        private void SearchResult_Load(object sender, EventArgs e)
        {
            foreach (TreeNode node in Results)
                listBox1.Items.Add(node.Text);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CurrentSelected != "")
            {
                TreeView.Nodes[CurrentSelected].BackColor = Color.Green;
                TreeView.Nodes[CurrentSelected].ForeColor = Color.White;
            }
                string selected = (string)listBox1.SelectedItem;
                TreeView.SelectedNode = TreeView.Nodes[selected];
                TreeView.SelectedNode.BackColor = Color.Red;
                CurrentSelected = selected;

        }
    }
}
