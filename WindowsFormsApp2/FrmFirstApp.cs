using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FrmFirstApp : Form
    {
        public FrmFirstApp()
        {
            InitializeComponent();
        }

        private void BtnWelcome_Click(object sender, EventArgs e)
        {
            MessageBox.Show("welcome");
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void PicTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
