using MySql.Data.MySqlClient;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Test code to add an employee to the database for debugging purposes
            /*try
            {
                DatabaseManager dbManager = new DatabaseManager();
                dbManager.AddEmployee("John", "Hardie", "darren.hardie123@hotmail.com", "password", 1);
                MessageBox.Show("Employee added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding the employee to the database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
            DatabaseManager dbManager = new DatabaseManager();
            if (dbManager.AuthenticateEmployee(emailTxtBox.Text, passwordTxtBox.Text))
            {
                MessageBox.Show("Login successful!");
                LandingScreen landingScreen = new LandingScreen();
                landingScreen.Show();
            }
            else
            {
                MessageBox.Show("Invalid email or password.");
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        //Show password when mouse is down on password picture box
        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            passwordTxtBox.UseSystemPasswordChar = false;
        }

        //Hide password when mouse is up on password picture box
        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            passwordTxtBox.UseSystemPasswordChar = true;
        }
    }
}
