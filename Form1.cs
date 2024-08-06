// LOG IN GUI Source Code 
// Reth Sengvisoth 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Khmer_Morse_Code_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // Log in 
        {
            string correctUsername = "admin";
            string correctPassword = "1234";

            // Check if the entered username and password match the correct ones
            if (username.Text == correctUsername && password.Text == correctPassword)
            {
                // If they match, open Form2 and hide the current form
                new Form2().Show();
                this.Hide();
            }
            else
            {
                // If they don't match, show an error message and clear the input fields
                MessageBox.Show("The Username and Password you entered is incorrect, try again");
                username.Clear();
                password.Clear();
            }
        }

        private void label4_Click(object sender, EventArgs e) // Exit 
        {
            Application.Exit();

        }

        private void label3_Click(object sender, EventArgs e) // Clear 
        {
            username.Clear();
            password.Clear();
            username.Focus();
        }
    }
}
    

