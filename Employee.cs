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
