using Mysqlx.Expr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScottishGlen
{
    internal class Employee
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public int departmentId { get; set; }

        /// <summary>
        /// validates the specified employee details to ensure it meets the required criteria.
        /// </summary>
        /// <param name="employee"></param>
        /// <returns>valid employee</returns>
        private bool ValidateEmployee(Employee employee)
        {
            if (string.IsNullOrWhiteSpace(employee.firstName) ||
               string.IsNullOrWhiteSpace(employee.lastName) ||
               string.IsNullOrWhiteSpace(employee.email) ||
               !employee.email.Contains("@") ||
               string.IsNullOrWhiteSpace(employee.password) ||
               departmentId <= 0)
            {
                return false;
            }
           
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Adds a new employee to the database after validating the provided employee details.
        /// </summary>
        /// <remarks>Displays a success message if the employee is registered successfully. If validation
        /// fails, a warning message is shown. In case of an error during the database operation, an error message is
        /// displayed.</remarks>
        /// <param name="employee">The employee object containing details such as first name, last name, email, password, and department ID.
        /// Cannot be null.</param>
        public void addEmployeeToDatabase(Employee employee)
        {
            try
            {
                if (ValidateEmployee(employee) == true)
                {
                    DatabaseManager dbManager = new DatabaseManager();
                    dbManager.AddEmployee(employee.firstName, employee.lastName,employee.email, employee.password, employee.departmentId);
                    MessageBox.Show("Employee registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please ensure all fields are filled out correctly.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding the employee to the database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
