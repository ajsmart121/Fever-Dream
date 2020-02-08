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
    public partial class playMenu : Form
    {
        public playMenu()
        {
            InitializeComponent();

            //change button colour on hover - referenced from stack overflow
            btnSingle.MouseEnter += OnMouseEnterBtnSingle;
            btnSingle.MouseLeave += OnMouseLeaveBtnSingle;

            btnMulti.MouseEnter += OnMouseEnterBtnMulti;
            btnMulti.MouseLeave += OnMouseLeaveBtnMulti;

            btnBack.MouseEnter += OnMouseEnterBtnBack;
            btnBack.MouseLeave += OnMouseLeaveBtnBack;

        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new frmMenu().Show();

          //  GameMenu().Visible = true;
        }

        //handlers for colour change on hover
        private void OnMouseEnterBtnSingle(object sender, EventArgs e)          //single player button
        {
            btnSingle.ForeColor = Color.Green;
        }
        private void OnMouseLeaveBtnSingle(object sender, EventArgs e)
        {
            btnSingle.ForeColor = Color.Purple;
        }

        private void OnMouseEnterBtnMulti(object sender, EventArgs e)           //Multi player button
        {
            btnMulti.ForeColor = Color.Green;
        }
        private void OnMouseLeaveBtnMulti(object sender, EventArgs e)
        {
            btnMulti.ForeColor = Color.Purple;
        }

        private void OnMouseEnterBtnBack(object sender, EventArgs e)            //Back Button
        {
            btnBack.ForeColor = Color.Green;
        }
        private void OnMouseLeaveBtnBack(object sender, EventArgs e)
        {
            btnBack.ForeColor = Color.Purple;
        }

        private void BtnMulti_Click(object sender, EventArgs e)
        {
            this.Visible=false;
            new frmStory().Show();
        }

        private void BtnSingle_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new Inversus.Inversus().Show();
        }

        private void PlayMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
