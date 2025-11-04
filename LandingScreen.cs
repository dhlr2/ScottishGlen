using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScottishGlen
{
    public partial class LandingScreen : Form
    {
        public LandingScreen()
        {
            InitializeComponent();
            listViewAssets.View = View.Details;
            listViewAssets.FullRowSelect = true;
            listViewAssets.GridLines = true;
            listViewAssets.Columns.Clear();
            listViewAssets.Columns.Add("ID", 50);
            listViewAssets.Columns.Add("Name", 150);
            listViewAssets.Columns.Add("Purchase Date", 100);
            listViewAssets.Columns.Add("Employee Id", 100);
            listViewAssets.Columns.Add("Notes", 100);
        }

        private void assetMenuBtn_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void assetMenuBtn_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void employeeMenuBtn_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void employeeMenuBtn_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void mySystemMenuBtn_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void mySystemMenuBtn_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addAssetBtn_Click(object sender, EventArgs e)
        {
            AddAsset addAssetForm = new AddAsset();
            addAssetForm.Show();
        }

        private void assetMenuBtn_Click(object sender, EventArgs e)
        {
            headingLbl.Text = "Assets";
            listViewAssets.View = View.Details;
            listViewAssets.FullRowSelect = true;
            listViewAssets.GridLines = true;
            listViewAssets.Columns.Clear();
            listViewAssets.Columns.Add("ID", 50);
            listViewAssets.Columns.Add("Name", 150);
            listViewAssets.Columns.Add("Purchase Date", 100);
            listViewAssets.Columns.Add("Employee Id", 100);
            listViewAssets.Columns.Add("Notes", 100);
        }

        private void employeeMenuBtn_Click(object sender, EventArgs e)
        {   
            headingLbl.Text = "Employees";
            listViewAssets.View = View.Details;
            listViewAssets.FullRowSelect = true;
            listViewAssets.GridLines = true;
            listViewAssets.Columns.Clear();
            listViewAssets.Columns.Add("ID", 50);
            listViewAssets.Columns.Add("First Name", 150);
            listViewAssets.Columns.Add("Last Name", 100);
            listViewAssets.Columns.Add("Email Address", 100);
            listViewAssets.Columns.Add("Department Id", 100);
        }

        private void mySystemMenuBtn_Click(object sender, EventArgs e)
        {   
            headingLbl.Text = "My System";
            listViewAssets.View = View.Details;
            listViewAssets.FullRowSelect = true;
            listViewAssets.GridLines = true;
            listViewAssets.Columns.Clear();
            listViewAssets.Columns.Add("System ID", 50);
            listViewAssets.Columns.Add("System Name", 50);
            listViewAssets.Columns.Add("Model", 50);
            listViewAssets.Columns.Add("Manufacturer", 50);
            listViewAssets.Columns.Add("System Type", 50);
            listViewAssets.Columns.Add("IP Address", 50);
            listViewAssets.Columns.Add("Date Captured", 50);
            listViewAssets.Columns.Add("Employee Id", 50);
        }
    }
}