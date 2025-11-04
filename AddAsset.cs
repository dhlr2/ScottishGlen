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
    public partial class AddAsset : Form
    {
        public AddAsset()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the click event for the confirm asset button, creating a new asset and adding it to the database.
        /// </summary>
        /// <remarks>This method retrieves asset details from the user interface, constructs an <see
        /// cref="Asset"/> object, and invokes the method to add the asset to the database. Ensure that the employee ID
        /// is a valid integer.</remarks>
        /// <param name="sender">The source of the event, typically the confirm asset button.</param>
        /// <param name="e">The event data associated with the click event.</param>
        private void confirmAssetBtn_Click(object sender, EventArgs e)
        {
            Asset asset = new Asset
            {
                name = assetNameTxtBox.Text,
                purchaseDate = purchaseDatePicker.Value,
                notes = notesTxtBox.Text,
                employeeId = Convert.ToInt32(employeeIdTxtBox.Text)
            };
            asset.addAssetToDatabase(asset);
        }
    }
}
