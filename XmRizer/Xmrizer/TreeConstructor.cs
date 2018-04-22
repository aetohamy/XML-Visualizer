using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Collections.Generic;
using System.Collections;

namespace DrKhaled.Xmrizer
{
    public class TreeConstructor
    {
        public string FilePath { get; set; }
        public TreeView TreeView { get; set; }
        public MetroFramework.Controls.MetroLabel Status { get; set; }
        public HashSet<string> UniqueProperties { get; set; }

        public TreeConstructor(string file , TreeView tv , MetroFramework.Controls.MetroLabel stat)
        {
            FilePath = file;
            TreeView = tv;
            TreeView.Sorted = true;
            TreeView.TreeViewNodeSorter = new NodeSorter();
            Status = stat;
            UniqueProperties = new HashSet<string>();
        }

        private TreeNode CreateRuleNode(XmlReader cReader)
        {
            TreeNode ruleNode = new TreeNode();
            ruleNode.Tag = "R";
            string ruleName = cReader.GetAttribute("Name");
            string ruleFC = cReader.GetAttribute("Fc");
            string ruleOC = cReader.GetAttribute("Oc");
            string ruleCategory = cReader.GetAttribute("category");
            ruleNode.Name = ruleName;
            ruleNode.Text = ruleName;
            ruleNode.Nodes.Add("FC", "FC").Nodes.Add(ruleName + "FC" + "_Value", ruleFC);
            ruleNode.Nodes.Add("OC", "OC").Nodes.Add(ruleName + "OC" + "_Value", ruleOC);
            ruleNode.Nodes.Add("Category","Category").Nodes.Add(ruleName + "Category" + "_Value", ruleCategory);
            TreeNode tuplesNode = new TreeNode();
            tuplesNode.Name = ruleName + "Tuples";
            tuplesNode.Text = "Conditions";
            if (cReader.ReadToDescendant("Tuple"))
            {
                do
                {
                    string tupleProp = cReader.GetAttribute("Prop");
                    string tupleVal = cReader.GetAttribute("Val");
                    if(!tupleVal.Contains(">") && !tupleVal.Contains("<"))
                    {
                        tupleVal = "=" + tupleVal;
                    }
                    UniqueProperties.Add(tupleProp);
                    if (tuplesNode.Nodes.ContainsKey(tupleProp))
                        tuplesNode.Nodes[tupleProp].Nodes.Add(tupleProp + "_Value", tupleVal);
                    else
                    {
                        tuplesNode.Nodes.Add(tupleProp, tupleProp).Nodes.Add(tupleProp + "_Value", tupleVal);
                    }
                } while (cReader.ReadToNextSibling("Tuple"));
            }
            ruleNode.Nodes.Add(tuplesNode);
            return ruleNode;
        }

        public async void Start(bool fcCluster=false , bool ocCluster=false)
        {
            using (XmlReader r = XmlReader.Create(FilePath))
            {
                r.ReadToFollowing("Cluster");
                if (r.ReadToDescendant("Rule"))
                {
                    TreeNode node = new TreeNode();
                    do
                    {
                        await Task.Run(() =>
                        {
                            node = CreateRuleNode(r);
                            
                            
                        }).
                        ContinueWith((ant) =>
                        {
                            if(!fcCluster)
                                TreeView.Nodes.Add(node);
                            else
                            {
                                string fcName = "FCVALUE" + node.Nodes["FC"].Nodes[0].Text.ToString();
                                string nodeFC = node.Nodes["FC"].Nodes[0].Text.ToString(); 
                                if(!TreeView.Nodes.ContainsKey(fcName))
                                { TreeView.Nodes.Add(fcName, nodeFC).Nodes.Add(node); }
                                else
                                {
                                    TreeView.Nodes[fcName].Nodes.Add(node);
                                }

                            }
                        }, TaskScheduler.FromCurrentSynchronizationContext());

                    } while(r.ReadToNextSibling("Rule"));
                }
            }
            Status.Text = "Tree construction completed.";
        }
    }

    /// <summary>
    /// Class that acts as a comparer for TreeNodes
    /// </summary>
    public class NodeSorter : IComparer
    {
        public int Compare(object x, object y)
        {
            TreeNode tx = x as TreeNode;
            TreeNode ty = y as TreeNode;
            if (tx.Text.Length == ty.Text.Length) { return string.Compare(tx.Text, ty.Text); }
            else if (tx.Text.Length > ty.Text.Length) { return 1; }
            else { return -1; }
        }
    }
}
