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

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            departmentDropList.Items.Add("Finance");
            departmentDropList.Items.Add("Human Resources");
            departmentDropList.Items.Add("Operations");
            departmentDropList.Items.Add("Sales");
            departmentDropList.Items.Add("Information Technology");
        }

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
