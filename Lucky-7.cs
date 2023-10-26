using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lucky7
{
    public partial class Form1 : Form
    {
        // Set attributes
        int Money = 100;
        int Choice = 1;
        int Round = 1;
        int Rand1;
        int Rand2;
        int Rand3;

        // Store images
        Image Fruit1 = Properties.Resources.Fruit_11;
        Image Fruit2 = Properties.Resources.Fruit_2;
        Image Fruit3 = Properties.Resources.Fruit_3;
        Image Fruit4 = Properties.Resources.Fruit_4;
        Image Fruit5 = Properties.Resources.Fruit_5;
        Image Fruit6 = Properties.Resources.Fruit_6;
        Image Fruit7 = Properties.Resources.Fruit_7;
        Image Fruit8 = Properties.Resources.Fruit_8;
        Random Random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        // Display the 'spin' animation for the fruits, looping through 8 preset options each time
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(Choice == 1 && Round != 3)
            {
                lbl1.Image = Fruit1;
                lbl2.Image = Fruit5;
                lbl3.Image = Fruit4;
            }
            else if (Choice == 2 && Round != 3)
            {
                lbl1.Image = Fruit2;
                lbl2.Image = Fruit6;
                lbl3.Image = Fruit5;
            }
            else if (Choice == 3 && Round != 3)
            {
                lbl1.Image = Fruit3;
                lbl2.Image = Fruit1;
                lbl3.Image = Fruit7;
            }
            else if (Choice == 4 && Round != 3)
            {
                lbl1.Image = Fruit4;
                lbl2.Image = Fruit2;
                lbl3.Image = Fruit3;
            }
            else if (Choice == 5 && Round != 3)
            {
                lbl1.Image = Fruit5;
                lbl2.Image = Fruit6;
                lbl3.Image = Fruit8;
            }
            else if (Choice == 6 && Round != 3)
            {
                lbl1.Image = Fruit6;
                lbl2.Image = Fruit8;
                lbl3.Image = Fruit3;
            }
            else if (Choice == 7 && Round != 3)
            {
                lbl1.Image = Fruit7;
                lbl2.Image = Fruit2;
                lbl3.Image = Fruit1;
            }
            else if (Choice == 8 && Round != 3)
            {
                lbl1.Image = Fruit8;
                lbl2.Image = Fruit7;
                lbl3.Image = Fruit2;
                Choice = 0;
                Round += 1;
            }
            
            Choice += 1;

            if (Round == 3)
            {
                timer1.Enabled = false;

                // Dislplay final roll once finished spinning
                DisplayFruit();
            }
        }

        void DisplayFruit()
        {
            // Loop through each of the three fruit and display outcome
            // Due to the nture of visual studio this must be hard coded unfortunately
            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine(i);
                int Rand = Random.Next(1, 9);
                Console.WriteLine(Rand.ToString());
               

                if (i == 1)
                {
                    Rand1 = Rand;
                    if (Rand == 1)
                    {
                        lbl1.Image = Fruit1;
                    }
                    else if (Rand == 2)
                    {
                        lbl1.Image = Fruit2;
                    }
                    else if (Rand == 3)
                    {
                        lbl1.Image = Fruit3;
                    }
                    else if (Rand == 4)
                    {
                        lbl1.Image = Fruit4;
                    }
                    else if (Rand == 5)
                    {
                        lbl1.Image = Fruit5;
                    }
                    else if (Rand == 6)
                    {
                        lbl1.Image = Fruit6;
                    }
                    else if (Rand == 7)
                    {
                        lbl1.Image = Fruit7;
                    }
                    else if (Rand == 8)
                    {
                        lbl1.Image = Fruit8;
                    }
                }

                else if (i == 2)
                {
                    Rand2 = Rand;
                    if (Rand == 1)
                    {
                        lbl2.Image = Fruit1;
                    }
                    else if (Rand == 2)
                    {
                        lbl2.Image = Fruit2;
                    }
                    else if (Rand == 3)
                    {
                        lbl2.Image = Fruit3;
                    }
                    else if (Rand == 4)
                    {
                        lbl2.Image = Fruit4;
                    }
                    else if (Rand == 5)
                    {
                        lbl2.Image = Fruit5;
                    }
                    else if (Rand == 6)
                    {
                        lbl2.Image = Fruit6;
                    }
                    else if (Rand == 7)
                    {
                        lbl2.Image = Fruit7;
                    }
                    else if (Rand == 8)
                    {
                        lbl2.Image = Fruit8;
                    }
                }

                else if (i == 3)
                {
                    Rand3 = Rand;
                    if (Rand == 1)
                    {
                        lbl3.Image = Fruit1;
                    }
                    else if (Rand == 2)
                    {
                        lbl3.Image = Fruit2;
                    }
                    else if (Rand == 3)
                    {
                        lbl3.Image = Fruit3;
                    }
                    else if (Rand == 4)
                    {
                        lbl3.Image = Fruit4;
                    }
                    else if (Rand == 5)
                    {
                        lbl3.Image = Fruit5;
                    }
                    else if (Rand == 6)
                    {
                        lbl3.Image = Fruit6;
                    }
                    else if (Rand == 7)
                    {
                        lbl3.Image = Fruit7;
                    }
                    else if (Rand == 8)
                    {
                        lbl3.Image = Fruit8;
                    }
                }
            }

            // Display prizes won by user
            if (Rand1 == Rand2 && Rand2 == Rand3)
            {
                if (Rand1 == 8)
                {
                    MessageBox.Show("Jackpot!! You won £100000!!!");
                    Money += 100000;
                }
                else
                {
                    MessageBox.Show("You won £200!!!");
                    Money += 200;
                }

            }
            else if (Rand1 == Rand2 || Rand1 == Rand3 || Rand2 == Rand3)
            {
                if (Rand1 == 8 || Rand2 == 8 || Rand3 == 8)
                {
                    MessageBox.Show("You won £30!!!");
                    Money += 30;
                }
                else
                {
                    MessageBox.Show("You won £20!!!");
                    Money += 20;
                }
            }
            else if (Rand1 == 8 || Rand2 == 8 || Rand3 == 8)
            {
                MessageBox.Show("You won £5!!!");
                Money += 5;
            }
            lblMoney.Text = "£" + Money.ToString();
        }

        // The spin button will set off the timer, and subtract £10 from the user's money
        private void btnSpin_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            Round = 0;
            Money -= 10;
            lblMoney.Text = "£" + Money.ToString();
        }

        // Close application if user presses cross button
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
