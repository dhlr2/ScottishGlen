using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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


            //Create sample items for prototype demonstration
            ListViewItem item1 = new ListViewItem("A001");

            item1.SubItems.Add("Laptop");                 
            item1.SubItems.Add("2023-05-12");             
            item1.SubItems.Add("E123");                   
            item1.SubItems.Add("Assigned to IT");         

            ListViewItem item2 = new ListViewItem("A002");
            item2.SubItems.Add("Monitor");
            item2.SubItems.Add("2023-06-01");
            item2.SubItems.Add("E124");
            item2.SubItems.Add("Spare unit");

            ListViewItem item3 = new ListViewItem("A003");
            item3.SubItems.Add("Keyboard");
            item3.SubItems.Add("2023-07-15");
            item3.SubItems.Add("E125");
            item3.SubItems.Add("Wireless model");

            // Add items to the ListView
            listViewAssets.Items.AddRange(new[] { item1, item2, item3 });

        }

        /// <summary>
        /// Handles the MouseEnter event for the asset menu button, changing the cursor to a hand pointer.
        /// </summary>
        /// <param name="sender">The source of the event, typically the asset menu button.</param>
        /// <param name="e">An EventArgs object that contains the event data.</param>
        private void assetMenuBtn_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        /// <summary>
        /// Handles the MouseLeave event for the asset menu button.
        /// </summary>
        /// <remarks>Resets the cursor to the default cursor when the mouse pointer leaves the asset menu
        /// button.</remarks>
        /// <param name="sender">The source of the event, typically the asset menu button.</param>
        /// <param name="e">An EventArgs object that contains the event data.</param>
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

        /// <summary>
        /// Handles the Click event of the asset menu button, updating the UI to display asset information.
        /// </summary>
        /// <remarks>This method clears the current items in the asset list view and sets up the columns
        /// to display asset details such as ID, Name, Purchase Date, Employee Id, and Notes. It then populates the list
        /// view with sample asset data for demonstration purposes.</remarks>
        /// <param name="sender">The source of the event, typically the asset menu button.</param>
        /// <param name="e">An EventArgs object that contains the event data.</param>
        private void assetMenuBtn_Click(object sender, EventArgs e)
        {
            headingLbl.Text = "Assets";
            listViewAssets.Items.Clear();
            listViewAssets.View = View.Details;
            listViewAssets.FullRowSelect = true;
            listViewAssets.GridLines = true;
            listViewAssets.Columns.Clear();
            listViewAssets.Columns.Add("ID", 100);
            listViewAssets.Columns.Add("Name", 150);
            listViewAssets.Columns.Add("Purchase Date", 100);
            listViewAssets.Columns.Add("Employee Id", 100);
            listViewAssets.Columns.Add("Notes", 100);

            //Create sample items for prototype demonstration
            ListViewItem item1 = new ListViewItem("A001");
            item1.SubItems.Add("Laptop");                 
            item1.SubItems.Add("2023-05-12");             
            item1.SubItems.Add("E123");                   
            item1.SubItems.Add("Assigned to IT");         

            ListViewItem item2 = new ListViewItem("A002");
            item2.SubItems.Add("Monitor");
            item2.SubItems.Add("2023-06-01");
            item2.SubItems.Add("E124");
            item2.SubItems.Add("Spare unit");

            ListViewItem item3 = new ListViewItem("A003");
            item3.SubItems.Add("Keyboard");
            item3.SubItems.Add("2023-07-15");
            item3.SubItems.Add("E125");
            item3.SubItems.Add("Wireless model");

            // Add items to the ListView
            listViewAssets.Items.AddRange(new[] { item1, item2, item3 });
        }

        /// <summary>
        /// Handles the click event for the employee menu button, updating the ListView to display employee details.
        /// </summary>
        /// <remarks>This method clears the current items in the ListView and sets up columns for
        /// displaying employee information. It then populates the ListView with sample employee data for demonstration
        /// purposes.</remarks>
        /// <param name="sender">The source of the event, typically the employee menu button.</param>
        /// <param name="e">An EventArgs object that contains the event data.</param>
        private void employeeMenuBtn_Click(object sender, EventArgs e)
        {   
            headingLbl.Text = "Employees";
            listViewAssets.Items.Clear();
            listViewAssets.View = View.Details;
            listViewAssets.FullRowSelect = true;
            listViewAssets.GridLines = true;
            listViewAssets.Columns.Clear();
            listViewAssets.Columns.Add("ID", 50);
            listViewAssets.Columns.Add("First Name", 150);
            listViewAssets.Columns.Add("Last Name", 100);
            listViewAssets.Columns.Add("Email Address", 200);
            listViewAssets.Columns.Add("Department Id", 100);

            //Create sample items for prototype demonstration
            ListViewItem item1 = new ListViewItem("1"); 
            item1.SubItems.Add("Darren");             
            item1.SubItems.Add("Hardie");             
            item1.SubItems.Add("darren.hardie123@hotmail.com");
            item1.SubItems.Add("4");

            ListViewItem item2 = new ListViewItem("A002");
            item2.SubItems.Add("nadia");
            item2.SubItems.Add("simpson");
            item2.SubItems.Add("nadia.hardie@hotmail.com");
            item2.SubItems.Add("3");

            ListViewItem item3 = new ListViewItem("A003");
            item3.SubItems.Add("arlene");
            item3.SubItems.Add("hardie");
            item3.SubItems.Add("arlene_hardie@hotmail.com");
            item3.SubItems.Add("5");

            // Add items to the ListView
            listViewAssets.Items.AddRange(new[] { item1, item2, item3 });
        }

        /// <summary>
        /// Handles the click event for the system menu button, updating the ListView to display system information.
        /// </summary>
        /// <remarks>This method clears the current items in the ListView and sets up columns to display
        /// system details such as System ID, System Name, Model, Manufacturer, System Type, IP Address, Date Captured,
        /// and Employee Id. It then populates the ListView with a predefined set of system data.</remarks>
        /// <param name="sender">The source of the event, typically the system menu button.</param>
        /// <param name="e">An EventArgs object that contains the event data.</param>
        private void mySystemMenuBtn_Click(object sender, EventArgs e)
        {   
            listViewAssets.Items.Clear();
            headingLbl.Text = "My System";
            listViewAssets.View = View.Details;
            listViewAssets.FullRowSelect = true;
            listViewAssets.GridLines = true;
            listViewAssets.Columns.Clear();
            listViewAssets.Columns.Add("System ID", 100);
            listViewAssets.Columns.Add("System Name", 150);
            listViewAssets.Columns.Add("Model", 150);
            listViewAssets.Columns.Add("Manufacturer", 100);
            listViewAssets.Columns.Add("System Type", 100);
            listViewAssets.Columns.Add("IP Address", 100);
            listViewAssets.Columns.Add("Date Captured", 100);
            listViewAssets.Columns.Add("Employee Id", 100);

            ListViewItem item1 = new ListViewItem("A001"); 
            item1.SubItems.Add("10");                 
            item1.SubItems.Add("Darrens PC");             
            item1.SubItems.Add("HP");                
            item1.SubItems.Add("harry potter");       
            item1.SubItems.Add("Laptop");        
            item1.SubItems.Add("192.134.12.1");        
            item1.SubItems.Add("04/11/3035");         
            item1.SubItems.Add("10");         

            // Add items to the ListView
            listViewAssets.Items.AddRange(new[] { item1});
        }
    }
}