using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class EndScreen : Form
    {
        public EndScreen()
        {
            InitializeComponent();

        }

        private void TxtGOQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnGOBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new frmMenu().Show();
        }



        private void TxtGameOver_TextChanged(object sender, EventArgs e)
        {
            
    
        }

        private void EndScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
