using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisMat_GUI
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          /* SI TODO OK IR A MainInterface */
            MainInterface mainView = new MainInterface();
            mainView.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
