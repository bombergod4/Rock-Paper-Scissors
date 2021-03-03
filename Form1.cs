using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Paper_Scissors
{
    public partial class Form1 : Form
    {
        bool deciding = false;
        bool mirage1 = false;
        bool mirage2 = false;
        bool mirage3 = false;
        Random generator = new Random();
        int mirageCD = 1;
        int chargedCD = 3;
        int opponentrealhp = 250;
        

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            System.IO.Stream str = Properties.Resources.Warrior_Boss_Battle___Copy;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.PlayLooping();
        }

        private void radRock_Checked(object sender, EventArgs e)
        {
            lblBoss1.BackColor = (Color.DarkGreen);
            lblBoss2.BackColor = (Color.DarkGreen);
            lblBoss3.BackColor = (Color.DarkGreen);
            deciding = true;
        }

        private void lblBoss2_Click(object sender, EventArgs e)
        {
            if (((deciding == true) && radRock.Checked == true) && mirage2 == false) //ROCK
            {
                imgPlayer.Image = Properties.Resources.Rock;
                if (chargedCD == 0)
                {
                    imgBoss1.Image = Properties.Resources.Rock;
                    imgBoss2.Image = Properties.Resources.Paper;
                    imgBoss3.Image = Properties.Resources.Scissors;
                    lblActions.Text = "Rock clashes with the Trinity, and both combatants take damage!";
                    barPlayerhp.Value -= 100;
                    barBoss2hp.Value -= 25;
                    mirageCD -= 1;
                    chargedCD = 5;
                }
                else if (mirageCD == 0)
                {
                    imgBoss1.Image = Properties.Resources.Rock;
                    imgBoss2.Image = Properties.Resources.Paper;
                    imgBoss3.Image = Properties.Resources.Scissors;
                    lblActions.Text = "Rock connects with the boss, and he takes damage!";
                    barBoss2hp.Value -= 25;
                    opponentrealhp -= 25;
                    if (generator.Next(1, 3) == 1)
                    {
                        mirage1 = false;
                        mirage2 = true;
                        mirage3 = true;
                    }
                    else if (generator.Next(1, 3) == 2)
                    {
                        mirage1 = true;
                        mirage2 = false;
                        mirage3 = true;
                    }
                    else
                    {
                        mirage1 = true;
                        mirage2 = true;
                        mirage3 = false;
                    }
                    lblBoss1.Visible = true;
                    barBoss1hp.Visible = true;
                    lblBoss3.Visible = true;
                    barBoss3hp.Visible = true;
                    imgBoss1.Visible = true;
                    imgBoss3.Visible = true;
                    barBoss1hp.Value = opponentrealhp;
                    barBoss2hp.Value = opponentrealhp;
                    barBoss3hp.Value = opponentrealhp;
                    mirageCD = 5;
                    chargedCD -= 1;
                }
                else if (generator.Next(0, 2) == 0)
                {
                    imgBoss1.Image = Properties.Resources.Rock;
                    imgBoss2.Image = Properties.Resources.Rock;
                    imgBoss3.Image = Properties.Resources.Rock;
                    lblActions.Text = "Rock clashes with Rock, and nothing happens!";
                    mirageCD -= 1;
                    chargedCD -= 1;
                }
                else if (generator.Next(0, 2) == 1)
                {
                    imgBoss1.Image = Properties.Resources.Paper;
                    imgBoss2.Image = Properties.Resources.Paper;
                    imgBoss3.Image = Properties.Resources.Paper;
                    lblActions.Text = "Rock clashes with Paper, and you take 30 damage!";
                    barPlayerhp.Value -= 30;
                    mirageCD -= 1;
                    chargedCD -= 1;
                }
                else
                {
                    imgBoss1.Image = Properties.Resources.Scissors;
                    imgBoss2.Image = Properties.Resources.Scissors;
                    imgBoss3.Image = Properties.Resources.Scissors;
                    lblActions.Text = "Rock clashes with scissors, and he takes 30 damage!";
                    barBoss2hp.Value -= 30;
                    opponentrealhp -= 30;
                    mirageCD -= 1;
                    chargedCD -= 1;
                }
            }
            else if (((deciding == true) && radPaper.Checked == true) && mirage2 == false) //PAPER
            {
                imgPlayer.Image = Properties.Resources.Rock;
                if (chargedCD == 0)
                {
                    imgBoss1.Image = Properties.Resources.Rock;
                    imgBoss2.Image = Properties.Resources.Paper;
                    imgBoss3.Image = Properties.Resources.Scissors;
                    lblActions.Text = "Paper clashes with the Trinity, and both combatants take damage!";
                    barPlayerhp.Value -= 100;
                    barBoss2hp.Value -= 25;
                    opponentrealhp -= 25;
                    mirageCD -= 1;
                    chargedCD = 5;
                }
                else if (mirageCD == 0)
                {
                    imgBoss1.Image = Properties.Resources.Rock;
                    imgBoss2.Image = Properties.Resources.Paper;
                    imgBoss3.Image = Properties.Resources.Scissors;
                    lblActions.Text = "Paper connects with the boss, and he takes damage!";
                    barBoss2hp.Value -= 25;
                    opponentrealhp -= 25;
                    if (generator.Next(1, 3) == 1)
                    {
                        mirage1 = false;
                        mirage2 = true;
                        mirage3 = true;
                    }
                    else if (generator.Next(1, 3) == 2)
                    {
                        mirage1 = true;
                        mirage2 = false;
                        mirage3 = true;
                    }
                    else
                    {
                        mirage1 = true;
                        mirage2 = true;
                        mirage3 = false;
                    }
                    lblBoss1.Visible = true;
                    barBoss1hp.Visible = true;
                    lblBoss3.Visible = true;
                    barBoss3hp.Visible = true;
                    imgBoss1.Visible = true;
                    imgBoss3.Visible = true;
                    barBoss1hp.Value = opponentrealhp;
                    barBoss2hp.Value = opponentrealhp;
                    barBoss3hp.Value = opponentrealhp;
                    mirageCD = 5;
                    chargedCD -= 1;
                }
                else if (generator.Next(0, 2) == 0)
                {
                    imgBoss1.Image = Properties.Resources.Rock;
                    imgBoss2.Image = Properties.Resources.Rock;
                    imgBoss3.Image = Properties.Resources.Rock;
                    lblActions.Text = "Paper clashes with Rock, and he takes 30 damage!";
                    opponentrealhp -= 30;
                    barBoss2hp.Value -= 30;
                    mirageCD -= 1;
                    chargedCD -= 1;
                }
                else if (generator.Next(0, 2) == 1)
                {
                    imgBoss1.Image = Properties.Resources.Paper;
                    imgBoss2.Image = Properties.Resources.Paper;
                    imgBoss3.Image = Properties.Resources.Paper;
                    lblActions.Text = "Paper clashes with Paper, and nothing happens!";
                    mirageCD -= 1;
                    chargedCD -= 1;
                }
                else
                {
                    imgBoss1.Image = Properties.Resources.Scissors;
                    imgBoss2.Image = Properties.Resources.Scissors;
                    imgBoss3.Image = Properties.Resources.Scissors;
                    lblActions.Text = "Paper clashes with scissors, and you take 30 damage!";
                    barPlayerhp.Value -= 30;
                    mirageCD -= 1;
                    chargedCD -= 1;

                }

            }
            else if (((deciding == true) && radScissors.Checked == true) && mirage2 == false) //Scissors
            {
                imgPlayer.Image = Properties.Resources.Rock;
                if (chargedCD == 0)
                {
                    imgBoss1.Image = Properties.Resources.Rock;
                    imgBoss2.Image = Properties.Resources.Paper;
                    imgBoss3.Image = Properties.Resources.Scissors;
                    lblActions.Text = "Scissors clashes with the Trinity, and both combatants take damage!";
                    barPlayerhp.Value -= 100;
                    barBoss2hp.Value -= 25;
                    opponentrealhp -= 25;
                    mirageCD -= 1;
                    chargedCD = 5;
                }
                else if (mirageCD == 0)
                {
                    imgBoss1.Image = Properties.Resources.Rock;
                    imgBoss2.Image = Properties.Resources.Paper;
                    imgBoss3.Image = Properties.Resources.Scissors;
                    lblActions.Text = "Scissors connects with the boss, and he takes 25 damage!";
                    barBoss2hp.Value -= 25;
                    opponentrealhp -= 25;
                    if (generator.Next(1, 3) == 1)
                    {
                        mirage1 = false;
                        mirage2 = true;
                        mirage3 = true;
                    }
                    else if (generator.Next(1, 3) == 2)
                    {
                        mirage1 = true;
                        mirage2 = false;
                        mirage3 = true;
                    }
                    else
                    {
                        mirage1 = true;
                        mirage2 = true;
                        mirage3 = false;
                    }
                    lblBoss1.Visible = true;
                    barBoss1hp.Visible = true;
                    lblBoss3.Visible = true;
                    barBoss3hp.Visible = true;
                    imgBoss1.Visible = true;
                    imgBoss3.Visible = true;
                    barBoss1hp.Value = opponentrealhp;
                    barBoss2hp.Value = opponentrealhp;
                    barBoss3hp.Value = opponentrealhp;
                    mirageCD = 5;
                    chargedCD -= 1;
                }
                else if (generator.Next(0, 2) == 0)
                {
                    imgBoss1.Image = Properties.Resources.Rock;
                    imgBoss2.Image = Properties.Resources.Rock;
                    imgBoss3.Image = Properties.Resources.Rock;
                    lblActions.Text = "Scissors clashes with Rock, and you take 30 damage!";
                    barPlayerhp.Value -= 30;
                    mirageCD -= 1;
                    chargedCD -= 1;
                }
                else if (generator.Next(0, 2) == 1)
                {
                    imgBoss1.Image = Properties.Resources.Paper;
                    imgBoss2.Image = Properties.Resources.Paper;
                    imgBoss3.Image = Properties.Resources.Paper;
                    lblActions.Text = "Scissors clashes with Paper, and he takes 30 damage!";
                    barBoss2hp.Value -= 30;
                    opponentrealhp -= 30;
                    mirageCD -= 1;
                    chargedCD -= 1;
                }
                else
                {
                    imgBoss1.Image = Properties.Resources.Scissors;
                    imgBoss2.Image = Properties.Resources.Scissors;
                    imgBoss3.Image = Properties.Resources.Scissors;
                    lblActions.Text = "Scissors clashes with scissors, and nothing happens!";
                    mirageCD -= 1;
                    chargedCD -= 1;

                }
            }
        }
    }
}
