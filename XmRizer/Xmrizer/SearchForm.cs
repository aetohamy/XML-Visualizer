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
    public partial class SearchForm : MetroFramework.Forms.MetroForm
    {
        public TreeConstructor Tree { get; set; }
        public List<Condition> SearchConditions { get; set; }
        public SearchForm(TreeConstructor tree)
        {
            InitializeComponent();
            Tree = tree;
            SearchConditions = new List<Condition>();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            foreach (var item in Tree.UniqueProperties)
                comboBoxProperties.Items.Add(item);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Condition newCondition = new Condition(comboBoxProperties.SelectedItem.ToString(), comboBoxSymbol.SelectedItem.ToString(), txtValue.Text);
            listConditions.Items.Add((comboBoxProperties.SelectedItem.ToString() + " " + comboBoxSymbol.SelectedItem.ToString() + " " + txtValue.Text).ToString());
            SearchConditions.Add(newCondition);
            comboBoxProperties.SelectedIndex = 0;
            comboBoxSymbol.SelectedIndex = 0;
            txtValue.Text = "";
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void btnAddFC_Click(object sender, EventArgs e)
        {
            Condition newCondition = new Condition("FC","=",txtFC.Text);
            listConditions.Items.Add(("FC"+" "+"="+" "+txtFC.Text));
            SearchConditions.Add(newCondition);
        }

        private void btnAddOC_Click(object sender, EventArgs e)
        {
            Condition newCondition = new Condition("OC", "=", txtOC.Text);
            listConditions.Items.Add(("OC" + " " + "=" + " " + txtOC.Text));
            SearchConditions.Add(newCondition);
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            Condition newCondition = new Condition("Category", "=", txtCategory.Text);
            listConditions.Items.Add(("Category" + " " + "=" + " " + txtCategory.Text));
            SearchConditions.Add(newCondition);
        }
    }
}
