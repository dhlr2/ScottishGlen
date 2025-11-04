using Google.Protobuf.WellKnownTypes;
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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the RegisterForm.
        /// </summary>
        /// <remarks>Populates the department dropdown list with predefined department names when the form
        /// is loaded.</remarks>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void RegisterForm_Load(object sender, EventArgs e)
        {
            departmentDropList.Items.Add("Finance");
            departmentDropList.Items.Add("Human Resources");
            departmentDropList.Items.Add("Operations");
            departmentDropList.Items.Add("Sales");
            departmentDropList.Items.Add("Information Technology");
        }

        /// <summary>
        /// Handles the click event of the register button, validating password input and registering a new employee.
        /// </summary>
        /// <remarks>This method checks if the passwords entered in the password and confirm password text
        /// boxes match and meet the minimum length requirement. If validation passes, it creates a new <see
        /// cref="Employee"/> object and adds it to the database. Displays a message box if the passwords do not match
        /// or are too short.</remarks>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void registerBtn_Click(object sender, EventArgs e)
        {
            if (passwordTxtBox.Text != confirmPasswordTxtBox.Text || passwordTxtBox.Text.Length < 6)
            {
                MessageBox.Show("Passwords do not match. Please re-enter.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Employee newEmployee = new Employee
                {
                    firstName = firstNameTxtBox.Text,
                    lastName = lastNameTxtBox.Text,
                    email = emailTxtBox.Text,
                    password = passwordTxtBox.Text,
                    departmentId = departmentDropList.SelectedIndex + 1
                };
                newEmployee.addEmployeeToDatabase(newEmployee);
            }
        }
    }
}
