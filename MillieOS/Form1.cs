using System;
using System.Linq;
using System.Windows.Forms;

namespace MillieOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Event handler for shutting down the OS
        private void shutdownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int confirmationCount = 0;  // Start with 0 "very"s

            while (true)
            {
                // If it's the first time (confirmationCount == 0), show the base message without "very"
                string message;
                if (confirmationCount == 0)
                {
                    message = "Are you sure you want to shut down MillieOS?";
                }
                else
                {
                    // For subsequent times, add "very"s
                    message = "Are you " + string.Join(" ", Enumerable.Repeat("very", confirmationCount)) + " sure you want to shut down MillieOS?";
                }

                // Show the message box and ask for confirmation
                var result = MessageBox.Show(message, "Shutdown", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // If the user confirms, increment the confirmation count
                    confirmationCount++;

                    // If the count exceeds a certain number (e.g., 5), shut down MillieOS
                    if (confirmationCount >= 5)
                    {
                        Application.Exit();  // Shut down the app
                        break;  // Exit the loop
                    }
                }
                else
                {
                    // If the user clicks "No", cancel the shutdown and exit the loop
                    break;
                }
            }
        }

        // Event handler to open the Cat App from the menu
        private void mToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenCatForm();
        }

        // Event handler to open the Cat App from button1
        private void button1_Click(object sender, EventArgs e)
        {
            OpenCatForm();
        }

        // Event handler to open the File App from button2
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileForm();
        }

        // Method to open the Cat App (Pet Millie)
        private void OpenCatForm()
        {
            CatForm catForm = new CatForm();
            catForm.Show();  // Show the form non-modally
        }

        // Method to open the File Explorer (still in Beta)
        private void OpenFileForm()
        {
            FileForm fileForm = new FileForm();
            fileForm.Show();  // Show the form non-modally
        }
    }
}