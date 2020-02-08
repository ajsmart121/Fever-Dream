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
    public partial class Instructions : Form
    {
        public Instructions()
        {
            InitializeComponent();

            //change button colour on hover - referenced from stack overflow
            btnInsBack.MouseEnter += OnMouseEnterBtnInsBack;
            btnInsBack.MouseLeave += OnMouseLeaveBtnInsBack;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtIns2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtIns1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnInsBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new frmMenu().Show();
        }


        //handlers for colour change on hover
        private void OnMouseEnterBtnInsBack(object sender, EventArgs e)          //back button
        {
            btnInsBack.ForeColor = Color.Green;
        }
        private void OnMouseLeaveBtnInsBack(object sender, EventArgs e)
        {
            btnInsBack.ForeColor = Color.Purple;
        }

        private void TxtInsA_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
