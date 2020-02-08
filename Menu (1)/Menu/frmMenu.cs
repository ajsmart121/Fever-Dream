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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            //change button colour on hover - referenced from stack overflow
            btnPlay.MouseEnter += OnMouseEnterBtnPlay;
            btnPlay.MouseLeave += OnMouseLeaveBtnPlay;

            btnInstructions.MouseEnter += OnMouseEnterBtnInstructions;
            btnInstructions.MouseLeave += OnMouseLeaveBtnInstructions;

            btnQuit.MouseEnter += OnMouseEnterBtnQuit;
            btnQuit.MouseLeave += OnMouseLeaveBtnQuit;

            //btnTest.KeyDown += btnTest_KeyDown(System.KeyEventHandler);
            //this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameMenu_KeyDown);
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnInstructions_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new Instructions().Show();
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            new playMenu().Show();
          
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    //handlers for colour change on hover
      private void OnMouseEnterBtnPlay(object sender, EventArgs e)              //play button
        {
            btnPlay.ForeColor = Color.Green;
        }
        private void OnMouseLeaveBtnPlay(object sender, EventArgs e)            
        {
            btnPlay.ForeColor = Color.Purple;
        }


        private void OnMouseEnterBtnInstructions(object sender, EventArgs e)      //Instructions button
        {
            btnInstructions.ForeColor = Color.Green;
        }
        private void OnMouseLeaveBtnInstructions(object sender, EventArgs e)
        {
            btnInstructions.ForeColor = Color.Purple;
        }


        private void OnMouseEnterBtnQuit(object sender, EventArgs e)                //Quit
        {
            btnQuit.ForeColor = Color.Green;
        }
        private void OnMouseLeaveBtnQuit(object sender, EventArgs e)
        {
            btnQuit.ForeColor = Color.Purple;
        }

    

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

    }
}
