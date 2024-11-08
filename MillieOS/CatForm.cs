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
    public partial class CatForm : Form
    {
        public CatForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You pet the cat. It purrs contentedly!", "Millie.exe", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
