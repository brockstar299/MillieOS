using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MillieOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void shutdownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create an instance of CatForm
            CatForm catForm = new CatForm();

            // Show the CatForm
            catForm.Show();  // Show the form non-modally
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create an instance of CatForm
            CatForm catForm = new CatForm();

            // Show the CatForm
            catForm.Show();  // Show the form non-modally
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Create an instance of CatForm
            FileForm fileForm = new FileForm();

            // Show the CatForm
            fileForm.Show();  // Show the form non-modally
        }
    }
}
