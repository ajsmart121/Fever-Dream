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
    public partial class frmStory : Form
    {
        public int happySentence = 0;
        public frmStory() {
            InitializeComponent();
            
        }
        private void BigBtn_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Thistle;
            happySentence++;
            if (happySentence == 6)
            {
                this.Visible = false;
                Menu.frmMenu potato = new Menu.frmMenu();
                potato.Show();
            }
            Inversus.Inversus frm = new Inversus.Inversus();
            frm.Show();
            if (happySentence == 1)
            {
                BiggerTxtBx.Text = "NNNNNNNNNOOOOOOOOOOOOOOOOOOOOOOOOOOOOO!!!!!!!!!!!!, screached the alexa voice having a small dent in its door. While the car was doing it's particularly... 'manly' squeal the rat hid in the bushes till it was able to get back to its family.\nSuddenly a giant spaceship that looked oddly like it was shaped like it spelt AMAZON dropped from the sky between you and the pesky rodent.\nJeff Bezos evaporated from the ship and glared the truck straight in the head lights. Zeus, hold my cybernautically enhanced wrist... oh right, the whole not having hand things is an issue.\nBezos teleported the two of them into the Amazon logo where they were assulted by a single ninja turtle.";
                BigBtn.Text = "<fight the turtle>";
            }
            else if (happySentence == 2)
            {
                BiggerTxtBx.Text = "In his excitement from the heat of battle Zeus ran over Bezos accidentally dragging him to the command deck. Zeus backed up letting the leader of the milky way stand up. Bezos tries to brush off the skid marks to no avail.\nThe universe has been at war for 10 minutes, Bezos started his boring monologue. I have seen every future through the new amazon smart glasses( #NotAnAdvertButPleaseSponserMeAmazon<3 ) and discovered the only hope for it is you... Now go and kill these evil spaceships that look like tea pots he manages to get out before Zeus is ejected from the space ship through the truck shaped hole in the ceiling.";
                BigBtn.Text = "<start battle against tea pot ships>";
            }
            else if (happySentence == 3)
            {
                BiggerTxtBx.Text = "Our car like companion didn't know what to do with himself. Stuck in space with only his alexa brain to keep him company. He slowly climbed towards madness slowly dying from his brain imploding.\nSomewhere else in the universe! A unicorn magestically galloped across a field of daisies and rainbows. The peace was short lived though as soon lightning struck the unicorn. The unicorn, known as Galious, looked around and discovered this attack was no mear coincidence but caused by a wild karter now weilding what looked like a banana peel. Galious leeps after the kart.";
                BigBtn.Text = "<commense fight against kart>";
            }
            else if (happySentence == 4)
            {
                BiggerTxtBx.Text = "You managed to pierce the driver with your horn, watching the guts slowly drop infront of your eyes. You feel pleasure with your revenge.\nAliens then proceed to abduct Galious, brain washing them to lead the fight against Bezos in the great Universal War of Death and NO COOKIES! Bwuh bwuh bwuhhhhhhh!";
                BigBtn.Text = "<commence battle to end the ferosous war>";
            }
            else if (happySentence == 5)
            {
                BiggerTxtBx.Text = "With Bezos saved, the universe goes back to living in peace. Civilians continue to be ruled by their corperate overlords. Corperate overlords continue to roll in the dosh and Galious continues to cry over their lost friend.\nBecause War... War never changes";
                BigBtn.Text = "<Press to go back to menu>";
            }
        }

        private void FrmStory_Load(object sender, EventArgs e)
        {

        }
    } 
}
