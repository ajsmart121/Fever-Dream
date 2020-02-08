using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Threading;

namespace Inversus
{
    public partial class Inversus : Form
    {
        private int tickCounter;
        static int maxX = 40;
        static int maxY = 22;
        static int minSize = 9;
        static int sizeOfSquare = 39;
        public int playerOneX;
        public int playerOneY;
        public int playerTwoX;
        public int playerTwoY;
        public Label[,] visualGrid;
        // 0 = null, 1 = white, 2 = black, 3 = blocks you can shoot throw but can't walk through, 4 = player 1, 5 = player 2, 6 = player 1 laser, 7 = player 2 laser, 8 = tempNull
        int[,] grid = new int[maxX, maxY];
        Random r = new Random();

        // 0 = green, 1 = green yellow, 2 = purple, 3 = magenta
        public void colourSquare(int x, int y, int colour)
        {
            if (colour == 0)
            {
                visualGrid[x, y].BackColor = Color.Green;
            }
            else if (colour == 1)
            {
                visualGrid[x, y].BackColor = Color.GreenYellow;
            }
            else if (colour == 2)
            {
                visualGrid[x, y].BackColor = Color.Purple;
            }
            else if (colour == 3)
            {
                visualGrid[x, y].BackColor = Color.Magenta;
            }
            else if (colour == 4)
            {
                visualGrid[x, y].BackColor = Color.Red;
            }
        }

        //[0] is up, [1] is right, [2] is down, [3] is left
        //[0] holds the x coord, [1] holds the y coord
        public laser[,] lasers = new laser[maxX, maxY];

        public class laser
        {
            //[0] is up, [1] is right, [2] is down, [3] is left
            int direction;
            int player;
            int x;
            int y;
            public void setDirection(int tempInt) { this.direction = tempInt; }
            public void setplayer(int tempInt) { this.player = tempInt; }
            public void setX(int tempInt) { this.x = tempInt; }
            public void setY(int tempInt) { this.y = tempInt; }
            public int getDirection() { return this.direction; }
            public int getPlayer() { return this.player; }
            public int getX() { return this.x; }
            public int getY() { return this.y; }
        };

        //checking around 
        public void lasersaround(int X, int Y, int player)
        {
            laser[] laserArray = new laser[4];
            for (int i = 0; i < 4; i++)
            {
                laserArray[i] = new laser();
                laserArray[i].setplayer(player);
            }
            if (Y > 0)
            {
                laserArray[0].setDirection(0);
                laserArray[0].setX(X);
                laserArray[0].setY(Y - 1);
            }

            if (X < maxX - 1)
            {
                laserArray[1].setDirection(1);
                laserArray[1].setX(X + 1);
                laserArray[1].setY(Y);
            }

            if (Y < maxY - 1)
            {
                laserArray[2].setDirection(2);
                laserArray[2].setX(X);
                laserArray[2].setY(Y + 1);
            }

            if (X > 0)
            {
                laserArray[3].setDirection(3);
                laserArray[3].setX(X - 1);
                laserArray[3].setY(Y);
            }
            for (int i = 0; i < 4; i++)
            {
                lasers[laserArray[i].getX(), laserArray[i].getY()] = laserArray[i];
                checkSquare(laserArray[i]);
            }



        }

        public void checkForLasers()
        {
            laser[,] laserbeam = new laser[maxX, maxY];
            for (int i = 0; i < maxX; i++)
            {
                for (int counter = 0; counter < maxY; counter++)
                {
                    laserbeam[i, counter] = new laser();
                    laserbeam[i, counter] = lasers[i, counter];
                }
            }
            for (int i = 0; i < maxX; i++)
            {
                for (int counter = 0; counter < maxY; counter++)
                {
                    if (laserbeam[i, counter] != null)
                    {
                        extendLaser(laserbeam[i, counter]);
                    }
                }
            }
        }

        public void extendLaser(laser laserpewpew)
        {
            if (laserpewpew.getDirection() == 0)
            {
                if (laserpewpew.getY() > 0)
                {
                    lasers[laserpewpew.getX(), laserpewpew.getY()] = null;
                    laserpewpew.setY(laserpewpew.getY() - 1);
                    lasers[laserpewpew.getX(), laserpewpew.getY()] = laserpewpew;
                }
                else
                {
                    lasers[laserpewpew.getX(), laserpewpew.getY()] = null;
                }
            }

            if (laserpewpew.getDirection() == 1)
            {
                if (laserpewpew.getX() < maxX-1)
                {
                    lasers[laserpewpew.getX(), laserpewpew.getY()] = null;
                    laserpewpew.setX(laserpewpew.getX() + 1);
                    lasers[laserpewpew.getX(), laserpewpew.getY()] = laserpewpew;
                }
                else
                {
                    lasers[laserpewpew.getX(), laserpewpew.getY()] = null;
                }
            }

            if (laserpewpew.getDirection() == 2)
            {
                if (laserpewpew.getY() < maxY - 1)
                {
                    lasers[laserpewpew.getX(), laserpewpew.getY()] = null;
                    laserpewpew.setY(laserpewpew.getY() + 1);
                    lasers[laserpewpew.getX(), laserpewpew.getY()] = laserpewpew;
                }
                else
                {
                    lasers[laserpewpew.getX(), laserpewpew.getY()] = null;
                }
            }

            if (laserpewpew.getDirection() == 3)
            {
                if (laserpewpew.getX() > 0)
                {
                    lasers[laserpewpew.getX(), laserpewpew.getY()] = null;
                    laserpewpew.setX(laserpewpew.getX() - 1);
                    lasers[laserpewpew.getX(), laserpewpew.getY()] = laserpewpew;
                }
                else
                {
                    lasers[laserpewpew.getX(), laserpewpew.getY()] = null;
                }
            }

            checkSquare(laserpewpew);

        }

        //change state or stop ?
        //checkcheckcheckcheckcheckcheck
        public void checkSquare(laser laserpewpew)
        {

            
            
            //if the square is a wall then stop shooting that direction (make the value -1 or somehting)
            if (grid[laserpewpew.getX(), laserpewpew.getY()] == 0)
            {
                lasers[laserpewpew.getX(), laserpewpew.getY()] = null;
            }

            //if the square is moveable for current player then keep current state
            if (laserpewpew.getX() == playerOneX && laserpewpew.getY() == playerOneY)
            {
                winner = "hahaha you lose";
                end = true;
                this.Visible = false;                                                                        //!!!!
            }
            if (laserpewpew.getX() == playerTwoX && laserpewpew.getY() == playerTwoY)
            {
                winner = "You win :tada:";
                end = true;
                this.Visible = false;                                                                        //!!!!
            }

            //if the square isnt moveable for the current player then change to moveable stateS
            if (laserpewpew.getPlayer() == 1)
            {

                if (grid[laserpewpew.getX(), laserpewpew.getY()] == 1 || grid[laserpewpew.getX(), laserpewpew.getY()] == 2)
                {
                    grid[laserpewpew.getX(), laserpewpew.getY()] = 1;
                    colourSquare(laserpewpew.getX(), laserpewpew.getY(), 2);
                }
            }
            else
            {
                if (grid[laserpewpew.getX(), laserpewpew.getY()] == 1 || grid[laserpewpew.getX(), laserpewpew.getY()] == 2)
                {
                    grid[laserpewpew.getX(), laserpewpew.getY()] = 2;
                    colourSquare(laserpewpew.getX(), laserpewpew.getY(), 0);
                }
            }

        }

        //Draws Grid
        public void drawSquare(int x, int y, int previous)
        {
            //Do nothing if square has previously been editted
            if (grid[x, y] != 0)
            {
                return;
            }
            //See what colour to make current square
            int randomColour = 0;
            //If Starting 50,50 flip it
            if (previous == 3)
            {
                randomColour = r.Next(2) + 1;
            }
            else
            {
                randomColour = r.Next(11);
                if (randomColour < 6)
                {
                    randomColour = 1;
                }
                else
                {
                    randomColour = 2;
                }
            }
            //Set the square to this colour on background grid
            grid[x, y] = randomColour;

            //Display square on visual grid
            //Set labels colour
            if (randomColour == 1)
            {
                colourSquare(x, y, 2);
            }
            else
            {
                colourSquare(x, y, 0);
            }

            //Calculating probabilities used for if a new square is created
            int probabiltyDecreaseX = 100 / (maxX / 2);
            int probabiltyDecreaseY = 100 / (maxY / 2);
            int xAwayFromCenter = (maxX / 2) - x;
            if (xAwayFromCenter < 0)
            {
                xAwayFromCenter *= -1;
            }
            int yAwayFromCenter = (maxY / 2) - y;
            if (yAwayFromCenter < 0)
            {
                yAwayFromCenter *= -1;
            }
            int tempInt = r.Next(100);

            //Going left
            if (x != 0)
            {
                if (tempInt > xAwayFromCenter * probabiltyDecreaseX)
                {
                    drawSquare(x - 1, y, randomColour);
                }
                else
                {
                    if (grid[x - 1, y] == 0)
                    {
                        grid[x - 1, y] = 8;
                    }

                }
            }
            //Going Right
            if (x < maxX - 1)
            {
                tempInt = r.Next(100);
                if (tempInt > xAwayFromCenter * probabiltyDecreaseX)
                {
                    drawSquare(x + 1, y, randomColour);
                }
                else
                {
                    if (grid[x + 1, y] == 0)
                    {
                        grid[x + 1, y] = 8;
                    }
                }
            }
            //Going up
            if (y != 0)
            {
                tempInt = r.Next(100);
                if (tempInt > yAwayFromCenter * probabiltyDecreaseY)
                {
                    drawSquare(x, y - 1, randomColour);
                }
                else
                {
                    if (grid[x, y - 1] == 0)
                    {
                        grid[x, y - 1] = 8;
                    }
                }
            }
            //Going down
            if (y < maxY - 1)
            {
                tempInt = r.Next(100);
                if (tempInt > yAwayFromCenter * probabiltyDecreaseY)
                {
                    drawSquare(x, y + 1, randomColour);
                }
                else
                {
                    if (grid[x, y + 1] == 0)
                    {
                        grid[x, y + 1] = 8;
                    }
                }
            }
        }

        public void cleanGrid()
        {
            for (int i = 0; i < maxX; i++)
            {
                for (int counter = 0; counter < maxY; counter++)
                {
                    if (grid[i, counter] == 8)
                    {
                        grid[i, counter] = 0;
                    }
                }
            }
        }

        public int countPlayerSpaces(int player)
        {

            int total = 0;
            for (int i = 0; i < maxX; i++)
            {
                for (int counter = 0; counter < maxY; counter++)
                {
                    if (grid[i, counter] == player)
                    {
                        total++;
                    }
                }
            }
            return (total);
        }

        public void RandomStartingLocations(int player)
        {
            int countingSpaces = 0;
            //Pick a random square from the players selection
            int tempInt = r.Next(countPlayerSpaces(player));

            //Go through every square
            for (int i = 0; i < maxX; i++)
            {
                for (int counter = 0; counter < maxY; counter++)
                {
                    if (grid[i, counter] == player)
                    {
                        if (countingSpaces == tempInt)
                        {
                            grid[i, counter] = player + 3;
                            if (player == 1)
                            {
                                colourSquare(i, counter, 1);
                                playerOneX = i;
                                playerOneY = counter;
                            }
                            else
                            {
                                colourSquare(i, counter, 3);
                                playerTwoX = i;
                                playerTwoY = counter;
                            }
                            return;
                        }
                        else
                        {
                            countingSpaces++;
                        }
                    }
                }
            }
        }

        //0 = up, 1 = right, 2 = down, 3 = left
        public int[,] laser1 = new int[4, 2];

        //Checks if square is movable
        public bool moveableSquare(int player, int squareX, int squareY)
        {
            //Checks to see if player number is the same as the colour of the square
            if (player == grid[squareX, squareY])
            {
                return (true);
            }
            return false;
        }


        // directions: 0 = up, 1 = right, 2 = down, 3 = left
        public bool movements(int player, int direction)
        {
            int x = 0;
            int y = 0;
            int done = 0;

            if (player == 1)
            {
                x = playerOneX;
                y = playerOneY;
            }
            else
            {
                x = playerTwoX;
                y = playerTwoY;
            }

            if (y != 0)
            {
                if (moveableSquare(player, x, y - 1) && direction == 0)
                {
                    //y--;
                    done = 1;
                }
            }
            if (y != maxY-1)
            {
                if (moveableSquare(player, x, y + 1) && direction == 2)
                {
                    //y++;
                    done = 2;
                }
            }
            if (x != maxX-1d )
            {
                if (moveableSquare(player, x + 1, y) && direction == 1)
                {
                    //x++;
                    done = 3;
                }
            }
            if (x != 0)
            {
                if (moveableSquare(player, x - 1, y) && direction == 3)
                {
                    //x--;
                    done = 4;
                }
            }

            if (done != 0)
            {

                if (player == 1)
                {
                    colourSquare(x, y, 2);
                    grid[x, y] = 1;
                }
                else
                {
                    colourSquare(x, y, 0);
                    grid[x, y] = 2;
                }


                if (done == 1)
                {
                    y--;
                }
                else if (done == 2)
                {
                    y++;
                }
                else if (done == 3)
                {
                    x++;
                }
                else
                {
                    x--;
                }

                if (player == 1)
                {
                    playerOneX = x;
                    playerOneY = y;
                    colourSquare(x, y, 1);
                }
                else
                {
                    playerTwoX = x;
                    playerTwoY = y;
                    colourSquare(x, y, 3);
                }
                return true;
            }
            return false;
        }

        public char keyPress;
        public bool spacePress = false;
        public bool end = false;
        public string winner;

        public async void gameLoop()
        {
            visualGrid[0, 0].Font = new Font("Arial", sizeOfSquare-15, FontStyle.Bold);
            visualGrid[0,0].ForeColor = Color.Green;
            visualGrid[1, 0].Font = new Font("Arial", sizeOfSquare-15, FontStyle.Bold);
            visualGrid[1, 0].ForeColor = Color.Green;
            visualGrid[0, 0].Text = "3";
            await Task.Delay(800);
            visualGrid[0, 0].Text = "2";
            await Task.Delay(800);
            visualGrid[0, 0].Text = "1";
            await Task.Delay(800);
            visualGrid[0, 0].Text = "G";
            visualGrid[1, 0].Text = "O!";
            await Task.Delay(50);
            while (end == false)
            {
                await Task.Delay(50);
                oneTick();
                visualGrid[0, 0].Text = "";
                visualGrid[1, 0].Text = "";
            }
            Console.WriteLine(winner);
            if (winner.Equals("You win :tada:"))
            {
                Menu.winscreen frm = new Menu.winscreen();
                frm.Show();
                frm.Visible = true;
            }
            else
            {
                Menu.EndScreen frm = new Menu.EndScreen();
                frm.Show();
                frm.Visible = true;
            }
        }

        public void oneTick()
        {
            tickCounter++;
            checkForLasers();
            if (tickCounter == 3)
            {
                tickCounter = 0;
                if (spacePress == true)
                {
                    lasersaround(playerOneX, playerOneY, 1);
                }
                if (keyPress == 'W')
                {
                    movements(1, 0);
                }
                else if (keyPress == 'D')
                {
                    movements(1, 1);
                }
                else if (keyPress == 'S')
                {
                    movements(1, 2);
                }
                else if (keyPress == 'A')
                {
                    movements(1, 3);
                }

                botStuff();
            }
        }
        //Bot Stuff
        public int botCoolDown = 8;
        public void botStuff()
        {
            bool lasered = false;
            bool moved = false;
            int differenceX = playerOneX - playerTwoX;
            int differenceY = playerOneY - playerTwoY;
            if (differenceX == 0 || differenceY == 0)
            {
                if (r.Next(botCoolDown / 2) == 1)
                {
                    lasersaround(playerTwoX, playerTwoY, 2);
                    lasered = true;
                }
            }
            if (r.Next(botCoolDown) == 1 && lasered == false)
            {
                lasersaround(playerTwoX, playerTwoY, 2);
            }   
            if (differenceX < 0)
            {
                if (r.Next(botCoolDown / 2) == 1)
                {
                    if (movements(2, 3))
                    {
                        moved = true;
                    }
                }

            }
            else if (differenceX > 0)
            {
                if (r.Next(botCoolDown / 2) == 1)
                {
                    if (movements(2, 1))
                    {
                        moved = true;
                    }
                }
            }
            if (differenceY < 0 && moved == false)
            {
                if (r.Next(botCoolDown / 2) == 1)
                {
                    if (movements(2, 0))
                    {
                        moved = true;
                    }
                }
            }

            else if (differenceY > 0 && moved == false)
            {
                if (r.Next(botCoolDown / 2) == 1)
                {
                    if (movements(2, 2))
                    {
                        moved = true;
                    }
                }
            }
            if (r.Next(botCoolDown) == 1 && moved == false)
            {
                if (!movements(2, r.Next(4)))
                {
                    movements(2, r.Next(4));
                }
            }
        }

        public void Form1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Space)
            {
                spacePress = true;
            }
            else if (e.KeyValue == (char)Keys.A)
            {
                keyPress = 'A';
            }
            else if (e.KeyValue == (char)Keys.S)
            {
                keyPress = 'S';
            }
            else if (e.KeyValue == (char)Keys.W)
            {
                keyPress = 'W';
            }
            else if (e.KeyValue == (char)Keys.D)
            {
                keyPress = 'D';
            }
        }
        public void Form1_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Space)
            {
                spacePress = false;
            }
            else
            {
                keyPress = ' ';
            }
        }

        public Inversus()
        {
            InitializeComponent();
            int maxXSize;
            int maxYSize;
            this.WindowState = FormWindowState.Maximized;
            maxX = r.Next(1 + maxX - minSize);
            maxY = r.Next(1 + maxY - minSize);
            maxX += minSize;
            maxY += minSize;
            maxXSize = this.Size.Width / maxX;
            maxYSize = this.Size.Height / maxY;
            if(maxXSize > maxYSize)
            {
                sizeOfSquare = maxYSize * 9 / 10;
            }
            else
            {
                sizeOfSquare = maxXSize * 9 / 10;
            }
            visualGrid = new Label[maxX, maxY];
            for (int i = 0; i < maxX; i++)
            {
                for (int counter = 0; counter < maxY; counter++)
                {
                    visualGrid[i, counter] = new Label();
                    visualGrid[i, counter].SetBounds( (this.Size.Width / 2 -(sizeOfSquare * maxX / 2))+ (i) * (sizeOfSquare + 1), (this.Size.Height / 2 - (sizeOfSquare * maxY / 2)) + (counter) * (sizeOfSquare + 1), sizeOfSquare, sizeOfSquare);
                    Controls.Add(visualGrid[i, counter]);
                }
            }
            this.BackColor = Color.Black;
            drawSquare(maxX / 2, maxY / 2, 3);
            cleanGrid();
            RandomStartingLocations(1);
            RandomStartingLocations(2);
            gameLoop();
            this.Hide();
            this.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}