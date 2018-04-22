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
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        public TreeConstructor Tree { get; set; }
        public List<TreeNode> SearchResults { get; set; }
        public MainForm()
        {
            InitializeComponent();
            this.ActiveControl = lblRules;
            lblStatus.Text = "No file loaded.";
            SearchResults = new List<TreeNode>();
        }

        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "XML Files | *.xml";
            if(of.ShowDialog()==DialogResult.OK)
            {
                txtFilePath.Text = of.FileName;
                lblStatus.Text = "File loaded successfully.";
            }
            this.ActiveControl = lblRules;
        }

        private async void btnLoadTree_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            Tree = new TreeConstructor(txtFilePath.Text, treeView1,lblStatus);
            lblStatus.Text = "Constructing tree from file...";
            Tree.Start(checkBoxFC.Checked);
            

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(e.Node.Tag == "R")
            {
                lblRuleName.Text = e.Node.Text;
                lblRuleCategory.Text = "Category : "+e.Node.Nodes["Category"].Nodes[0].Text;
                lblRuleFC.Text = "FC : "+e.Node.Nodes["FC"].Nodes[0].Text;
                lblRuleOC.Text = "OC : "+e.Node.Nodes["OC"].Nodes[0].Text;
                lblRuleConditions.Text = "";
                foreach(TreeNode condition in e.Node.Nodes[e.Node.Text + "Tuples"].Nodes)
                {
                    foreach(TreeNode child in condition.Nodes)
                        lblRuleConditions.Text += condition.Text + " : "+ child.Text + "\n";
                }
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if(Tree==null)
            {
                MessageBox.Show("There is no tree constructed yet to search.\nPlease load a tree first.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            foreach(TreeNode node in SearchResults)
            {
                node.BackColor = Color.White;
                node.ForeColor = Color.Black;
            }

            SearchForm form = new SearchForm(Tree);
            form.ShowDialog();
            if(form.DialogResult==DialogResult.OK)
            {
                SearchFor(form.SearchConditions);
            }
        }

        private TreeNode GetParentOf(TreeNode child)
        {
            TreeNode tmp = child;
            while (tmp.Tag != "R")
                tmp = tmp.Parent;
            return tmp;
        }

        private void SearchFor(List<Condition> conditions)
        {
            List<List<TreeNode>> satisifedNodes = new List<List<TreeNode>>();
            foreach (var condition in conditions)
            {
                //Get all nodes with the specific property in the condition
                var treeNodes = treeView1.FlattenTree()
                         .Where(n => n.Text == condition.Property)
                         .ToList();

                //List of rule nodes that has the properties
                var ruleNodes = new List<TreeNode>();
                foreach (var node in treeNodes)
                    ruleNodes.Add(GetParentOf(node));

                /*DEBUG : Verifies all the suspected nodes
                foreach (var node in ruleNodes)
                    node.BackColor = Color.Aqua;
                */

                satisifedNodes.Add(ruleNodes);
            }
            // Gets the intersection of all the nodes found with the specific properties
            // ie: gets all the rules that have these properties in the first place
            var intersection = satisifedNodes
                                .Skip(1)
                                .Aggregate(
                                 new HashSet<TreeNode>(satisifedNodes.First()),
                                 (h, e) => { h.IntersectWith(e); return h; });

            List<TreeNode> nodesThatSatisfy = new List<TreeNode>();
            foreach (var node in intersection)
            {
                bool satisfy = true;
                foreach (var condition in conditions)
                {
                    if (condition.Property == "FC")
                    {
                        if(node.Nodes["FC"].Nodes[0].Text != condition.Value) { satisfy = false;  break; }
                    }
                    else if (condition.Property == "OC")
                    {
                        if (node.Nodes["OC"].Nodes[0].Text != condition.Value) { satisfy = false; break; }
                    }
                    else if (condition.Property == "Category")
                    {
                        if (node.Nodes["Category"].Nodes[0].Text != condition.Value) { satisfy = false; break; }
                    }
                    else
                    {
                        foreach(TreeNode childCondition in node.Nodes[node.Name+"Tuples"].Nodes[condition.Property].Nodes)
                        {
                            if (childCondition.Text.Trim(' ') == (condition.Comparator + condition.Value).ToString().Trim(' '))
                            {
                                satisfy = true;
                                break;
                            }
                            else
                                satisfy = false;
                        }
                    }
                }
                if (satisfy)
                {
                    nodesThatSatisfy.Add(node);
                    node.BackColor = Color.Green;
                    node.ForeColor = Color.White;
                }
            }
            SearchResults = nodesThatSatisfy;
            SearchResultForm resultForm = new SearchResultForm(SearchResults, treeView1);
            resultForm.Show();
            resultForm.Location = new Point(this.Width , this.Location.Y);
                //foreach (var node in intersection)
                 //   node.BackColor = Color.Aqua;
        }
    }

}
