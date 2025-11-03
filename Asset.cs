using Mysqlx.Expr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScottishGlen
{
    internal class Asset
    {
        public string name { get; set; }
        public DateTime purchaseDate { get; set; }
        public string notes { get; set; }
        public int employeeId { get; set; }

        public bool ValidateAsset(Asset asset)
        {
            if (string.IsNullOrWhiteSpace(asset.name) ||
               asset.purchaseDate == null ||
               string.IsNullOrWhiteSpace(asset.notes) ||
               asset.employeeId <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public void addAssetToDatabase(Asset asset)
        {
            try
            {
                if (ValidateAsset(asset) == true)
                {
                    DatabaseManager dbManager = new DatabaseManager();
                    dbManager.AddAsset(asset.name, asset.purchaseDate, asset.notes, asset.employeeId);
                    MessageBox.Show("Asset added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please ensure all fields are filled out correctly.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding the asset to the database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
