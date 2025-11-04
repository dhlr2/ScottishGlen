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

        /// <summary>
        /// Validates the specified asset to ensure it meets the required criteria.
        /// </summary>
        /// <param name="asset">The asset to validate. Must not have a null or whitespace name, a null purchase date, null or whitespace
        /// notes, and must have a positive employee ID.</param>
        /// <returns><see langword="true"/> if the asset is valid; otherwise, <see langword="false"/>.</returns>
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

        /// <summary>
        /// Adds a new asset to the database if it passes validation.
        /// </summary>
        /// <remarks>Displays a message box indicating the success or failure of the operation.  If the
        /// asset is invalid, a validation error message is shown.  If an exception occurs during the database
        /// operation, an error message is displayed.</remarks>
        /// <param name="asset">The asset to be added. Must not be null and should have all required fields correctly filled.</param>
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
