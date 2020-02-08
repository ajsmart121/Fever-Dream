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
    public partial class winscreen : Form
    {
        public winscreen()
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

        private void Winscreen_Load(object sender, EventArgs e)
        {

        }
    }
}
