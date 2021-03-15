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
        // Crashes randomly after turn 18 and goes infinte after the 5th Protect
        bool deciding = false;
        bool mirage1 = false;
        bool mirage2 = false;
        bool mirage3 = false;
        Random generator = new Random();
        int mirageCD = 1;
        int chargedCD = 3;
        int opponentrealhp = 250;
        int opponentmove; // 1 = Rock, 2 == Paper, 3 = Scissors.
        int opponentmirage; // Determines which opponent is real and which are decoys
        int protectCD = 0;
        int timer = 0;

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void radRock_Checked(object sender, EventArgs e)
        {
            if (radRock.Checked)
            {
                lblPlayer.BackColor = (Color.Blue);
                lblBoss1.BackColor = (Color.DarkGreen);
                lblBoss2.BackColor = (Color.DarkGreen);
                lblBoss3.BackColor = (Color.DarkGreen);
                lblActions.Text = "Choose a target";
                deciding = true;
            }
        }

        private void radPaper_Checked(object sender, EventArgs e)
        {
            if (radPaper.Checked)
            {
                lblPlayer.BackColor = (Color.Blue);
                lblBoss1.BackColor = (Color.DarkGreen);
                lblBoss2.BackColor = (Color.DarkGreen);
                lblBoss3.BackColor = (Color.DarkGreen);
                lblActions.Text = "Choose a target";
                deciding = true;
            }
        }

        private void radScissors_Checked(object sender, EventArgs e)
        {
            if (radScissors.Checked)
            {
                lblPlayer.BackColor = (Color.Blue);
                lblBoss1.BackColor = (Color.DarkGreen);
                lblBoss2.BackColor = (Color.DarkGreen);
                lblBoss3.BackColor = (Color.DarkGreen);
                lblActions.Text = "Choose a target";
                deciding = true;
            }
        }

        private void radProtect_Checked(object sender, EventArgs e)
        {
            if (radProtect.Checked)
            {
                lblPlayer.BackColor = (Color.DarkGreen);
                lblBoss1.BackColor = (Color.Crimson);
                lblBoss2.BackColor = (Color.Crimson);
                lblBoss3.BackColor = (Color.Crimson);
                lblActions.Text = "Choose a target";
                deciding = true;
            }
        }
        public void Upkeep()
        {
            //while (timer != 5)
            //{
            //    timer += 1;
            //}
            //Damage();
            lblActions.Text = chargedCD + "," + mirageCD + "," + protectCD;
            radRock.Checked = false;
            radPaper.Checked = false;
            radScissors.Checked = false;
            radProtect.Checked = false;
            deciding = false;
            lblPlayer.BackColor = (Color.Blue);
            lblBoss1.BackColor = (Color.Crimson);
            lblBoss2.BackColor = (Color.Crimson);
            lblBoss3.BackColor = (Color.Crimson);
            lblPlayerhp.Text = barPlayerhp.Value + "/ 250";
            if (barPlayerhp.Value <= 0)
            {
                lblActions.Text = "You lose!";
                radRock.Enabled = false;
                radPaper.Enabled = false;
                radScissors.Enabled = false;
                radProtect.Enabled = false;
                btnPlay.Visible = true;
            }
                
            else if (opponentrealhp <= 0)
            {
                lblActions.Text = "You win!";
                lblBoss1.Visible = false;
                barBoss1hp.Visible = false;
                imgBoss2.Visible = false;
                lblBoss2.Visible = false;
                barBoss2hp.Visible = false;
                imgBoss1.Visible = false;
                lblBoss3.Visible = false;
                barBoss3hp.Visible = false;
                imgBoss3.Visible = false;
                btnPlay.Visible = true;
            }
            else if (chargedCD == 0)
            {
                lblActions.Text = "The Boss is channeling a powerful attack";
                mirageCD -= 1;
            }
            if (chargedCD < 0)
                chargedCD = 5;
                
        }
        public void Damage()
        {
            for (int i = 0; i <= 1000000; i += 1)
                this.BackColor = Color.Red;
            this.BackColor = Color.White;
        }

                
        private void lblBoss2_Click(object sender, EventArgs e)
        {
            opponentmove = generator.Next(0, 3);
            opponentmirage = generator.Next(1, 4);
            if (((deciding == true) && radRock.Checked == true) && mirage2 == false) //ROCK
            {

                imgPlayer.Image = Properties.Resources.Rock;
                if (chargedCD == 0)
                {
                    imgBoss1.Image = Properties.Resources.Rock;
                    imgBoss2.Image = Properties.Resources.Paper;
                    imgBoss3.Image = Properties.Resources.Scissors;
                    lblActions.Text = "Rock clashes with the Trinity, and both combatants take damage!";
                    if (barPlayerhp.Value < 100)
                        barPlayerhp.Value = 0;
                    else
                        barPlayerhp.Value -= 100;
                    barBoss2hp.Value -= 25;
                    mirageCD -= 1;
                    if (protectCD != 0)
                        protectCD -= 1;
                    chargedCD = 5;
                }
                else if (mirageCD == 0)
                {
                    imgBoss1.Image = Properties.Resources.Rock;
                    imgBoss2.Image = Properties.Resources.Paper;
                    imgBoss3.Image = Properties.Resources.Scissors;
                    lblActions.Text = "Rock connects with the boss, and he takes damage! However, he dissapears among decoys!";
                    barBoss2hp.Value -= 25;
                    opponentrealhp -= 25;
                    if (opponentmirage == 1)
                    {
                        mirage1 = false;
                        mirage2 = true;
                        mirage3 = true;
                    }
                    else if (opponentmirage == 2)
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
                    if (protectCD != 0)
                        protectCD -= 1;
                    chargedCD -= 1;
                }
                else if (opponentmove == 0)
                {
                    imgBoss1.Image = Properties.Resources.Rock;
                    imgBoss2.Image = Properties.Resources.Rock;
                    imgBoss3.Image = Properties.Resources.Rock;
                    lblActions.Text = "Rock clashes with Rock, and nothing happens!";
                    mirageCD -= 1;
                    if (protectCD != 0)
                        protectCD -= 1;
                    chargedCD -= 1;
                }
                else if (opponentmove == 1)
                {
                    imgBoss1.Image = Properties.Resources.Paper;
                    imgBoss2.Image = Properties.Resources.Paper;
                    imgBoss3.Image = Properties.Resources.Paper;
                    lblActions.Text = "Rock clashes with Paper, and you take damage!";
                    barPlayerhp.Value -= 25;
                    mirageCD -= 1;
                    if (protectCD != 0)
                        protectCD -= 1;
                    chargedCD -= 1;
                }
                else
                {
                    imgBoss1.Image = Properties.Resources.Scissors;
                    imgBoss2.Image = Properties.Resources.Scissors;
                    imgBoss3.Image = Properties.Resources.Scissors;
                    lblActions.Text = "Rock clashes with scissors, and he takes damage!";
                    barBoss2hp.Value -= 25;
                    opponentrealhp -= 25;
                    mirageCD -= 1;
                    if (protectCD != 0)
                        protectCD -= 1;
                    chargedCD -= 1;
                }
            }
            else if (((deciding == true) && radPaper.Checked == true) && mirage2 == false) //PAPER
            {
                imgPlayer.Image = Properties.Resources.Paper;
                if (chargedCD == 0)
                {
                    imgBoss1.Image = Properties.Resources.Rock;
                    imgBoss2.Image = Properties.Resources.Paper;
                    imgBoss3.Image = Properties.Resources.Scissors;
                    lblActions.Text = "Paper clashes with the Trinity, and both combatants take damage!";
                    if (barPlayerhp.Value < 100)
                        barPlayerhp.Value = 0;
                    else
                        barPlayerhp.Value -= 100;
                    barBoss2hp.Value -= 25;
                    opponentrealhp -= 25;
                    mirageCD -= 1;
                    if (protectCD != 0)
                        protectCD -= 1;
                    chargedCD = 5;
                }
                else if (mirageCD == 0)
                {
                    imgBoss1.Image = Properties.Resources.Rock;
                    imgBoss2.Image = Properties.Resources.Paper;
                    imgBoss3.Image = Properties.Resources.Scissors;
                    lblActions.Text = "Paper connects with the boss, and he takes damage! However, he dissapears among decoys!";
                    barBoss2hp.Value -= 25;
                    opponentrealhp -= 25;
                    if (opponentmirage == 1)
                    {
                        mirage1 = false;
                        mirage2 = true;
                        mirage3 = true;
                    }
                    else if (opponentmirage == 2)
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
                    imgBoss1.Visible = true;
                    lblBoss3.Visible = true;
                    barBoss3hp.Visible = true;

                    imgBoss3.Visible = true;
                    barBoss1hp.Value = opponentrealhp;
                    barBoss2hp.Value = opponentrealhp;
                    barBoss3hp.Value = opponentrealhp;
                    mirageCD = 5;
                    if (protectCD != 0)
                        protectCD -= 1;
                    chargedCD -= 1;
                }
                else if (opponentmove == 0)
                {
                    imgBoss1.Image = Properties.Resources.Rock;
                    imgBoss2.Image = Properties.Resources.Rock;
                    imgBoss3.Image = Properties.Resources.Rock;
                    lblActions.Text = "Paper clashes with Rock, and he takes damage!";
                    opponentrealhp -= 25;
                    barBoss2hp.Value -= 25;
                    mirageCD -= 1;
                    if (protectCD != 0)
                        protectCD -= 1;
                    chargedCD -= 1;
                }
                else if (opponentmove == 1)
                {
                    imgBoss1.Image = Properties.Resources.Paper;
                    imgBoss2.Image = Properties.Resources.Paper;
                    imgBoss3.Image = Properties.Resources.Paper;
                    lblActions.Text = "Paper clashes with Paper, and nothing happens!";
                    mirageCD -= 1;
                    if (protectCD != 0)
                        protectCD -= 1;
                    chargedCD -= 1;
                }
                else
                {
                    imgBoss1.Image = Properties.Resources.Scissors;
                    imgBoss2.Image = Properties.Resources.Scissors;
                    imgBoss3.Image = Properties.Resources.Scissors;
                    lblActions.Text = "Paper clashes with scissors, and you take damage!";
                    barPlayerhp.Value -= 25;
                    mirageCD -= 1;
                    if (protectCD != 0)
                        protectCD -= 1;
                    chargedCD -= 1;

                }

            }
            else if (((deciding == true) && radScissors.Checked == true) && mirage2 == false) //Scissors
            {
                imgPlayer.Image = Properties.Resources.Scissors;
                if (chargedCD == 0)
                {
                    imgBoss1.Image = Properties.Resources.Rock;
                    imgBoss2.Image = Properties.Resources.Paper;
                    imgBoss3.Image = Properties.Resources.Scissors;
                    lblActions.Text = "Scissors clashes with the Trinity, and both combatants take damage!";
                    if (barPlayerhp.Value < 100)
                        barPlayerhp.Value = 0;
                    else
                        barPlayerhp.Value -= 100;
                    barBoss2hp.Value -= 25;
                    opponentrealhp -= 25;
                    mirageCD -= 1;
                    if (protectCD != 0)
                        protectCD -= 1;
                    chargedCD = 5;
                }
                else if (mirageCD == 0)
                {
                    imgBoss1.Image = Properties.Resources.Rock;
                    imgBoss2.Image = Properties.Resources.Paper;
                    imgBoss3.Image = Properties.Resources.Scissors;
                    lblActions.Text = "Scissors connects with the boss, and he takes 25 damage! However, he dissapears among decoys!";
                    barBoss2hp.Value -= 25;
                    opponentrealhp -= 25;
                    if (opponentmirage == 1)
                    {
                        mirage1 = false;
                        mirage2 = true;
                        mirage3 = true;
                    }
                    else if (opponentmirage == 2)
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
                    if (protectCD != 0)
                        protectCD -= 1;
                    chargedCD -= 1;
                }
                else if (opponentmove == 0)
                {
                    imgBoss1.Image = Properties.Resources.Rock;
                    imgBoss2.Image = Properties.Resources.Rock;
                    imgBoss3.Image = Properties.Resources.Rock;
                    lblActions.Text = "Scissors clashes with Rock, and you take damage!";
                    barPlayerhp.Value -= 25;
                    mirageCD -= 1;
                    if (protectCD != 0)
                        protectCD -= 1;
                    chargedCD -= 1;
                }
                else if (opponentmove == 1)
                {
                    imgBoss1.Image = Properties.Resources.Paper;
                    imgBoss2.Image = Properties.Resources.Paper;
                    imgBoss3.Image = Properties.Resources.Paper;
                    lblActions.Text = "Scissors clashes with Paper, and he takes damage!";
                    barBoss2hp.Value -= 25;
                    opponentrealhp -= 25;
                    mirageCD -= 1;
                    if (protectCD != 0)
                        protectCD -= 1;
                    chargedCD -= 1;
                }
                else
                {
                    imgBoss1.Image = Properties.Resources.Scissors;
                    imgBoss2.Image = Properties.Resources.Scissors;
                    imgBoss3.Image = Properties.Resources.Scissors;
                    lblActions.Text = "Scissors clashes with scissors, and nothing happens!";
                    mirageCD -= 1;
                    if (protectCD != 0)
                        protectCD -= 1;
                    chargedCD -= 1;

                }
            }
            else if (((deciding == true) && mirage2 == true) && chargedCD == 0)
            {
                if (radRock.Checked == true)
                    imgPlayer.Image = Properties.Resources.Rock;
                else if (radPaper.Checked == true)
                    imgPlayer.Image = Properties.Resources.Paper;
                else if (radScissors.Checked == true)
                    imgPlayer.Image = Properties.Resources.Scissors;
                lblActions.Text = "The blow connects, but it struck a decoy! While distracted, the boss hits you with the Trinity!";
                lblBoss2.Visible = false;
                barBoss2hp.Visible = false;
                imgBoss2.Visible = false;
                if (barPlayerhp.Value >= 125)
                    barPlayerhp.Value -= 125;
                else
                    barPlayerhp.Value = 0;
                mirageCD -= 1;
                if (protectCD != 0)
                    protectCD -= 1;
                chargedCD = 5;
            }
            else if ((deciding == true) && mirage2 == true)
            {
                if (radRock.Checked == true)
                    imgPlayer.Image = Properties.Resources.Rock;
                else if (radPaper.Checked == true)
                    imgPlayer.Image = Properties.Resources.Paper;
                else if (radScissors.Checked == true)
                    imgPlayer.Image = Properties.Resources.Scissors;
                lblActions.Text = "The blow connects, but it struck a decoy! While distracted, the boss hits you!";
                lblBoss2.Visible = false;
                barBoss2hp.Visible = false;
                imgBoss2.Visible = false;
                barPlayerhp.Value -= 25;
                mirageCD -= 1;
                if (protectCD != 0)
                    protectCD -= 1;
                chargedCD -= 1;
            }
            else
                lblActions.Text = "How";
            Upkeep();
        }

        private void lblPlayer_Click(object sender, EventArgs e)
        {
            if (((deciding == true) && radProtect.Checked == true) && protectCD > 0)
                lblActions.Text = "The shield is not ready yet!";

            else if (((deciding == true) && radProtect.Checked == true) && protectCD <= 0)
            {
                imgPlayer.Image = Properties.Resources.Shield;
                protectCD = 3;
                if (chargedCD <= 0)
                {
                    imgBoss1.Image = Properties.Resources.Rock;
                    imgBoss2.Image = Properties.Resources.Paper;
                    imgBoss3.Image = Properties.Resources.Scissors;
                    chargedCD = 5;
                }
                else if (opponentmove == 0)
                {
                    imgBoss1.Image = Properties.Resources.Rock;
                    imgBoss2.Image = Properties.Resources.Rock;
                    imgBoss3.Image = Properties.Resources.Rock;
                }
                else if (opponentmove == 1)
                {
                    imgBoss1.Image = Properties.Resources.Paper;
                    imgBoss2.Image = Properties.Resources.Paper;
                    imgBoss3.Image = Properties.Resources.Paper;
                }
                else if (opponentmove == 2)
                {
                    imgBoss1.Image = Properties.Resources.Scissors;
                    imgBoss2.Image = Properties.Resources.Scissors;
                    imgBoss3.Image = Properties.Resources.Scissors;
                }
                lblActions.Text = "The boss's attacks are blocked by the shield!";
            }
            else if (((deciding == true) && radProtect.Checked == true) && mirageCD == 0)
            {
                imgPlayer.Image = Properties.Resources.Shield;
                imgBoss1.Image = Properties.Resources.Rock;
                imgBoss2.Image = Properties.Resources.Paper;
                imgBoss3.Image = Properties.Resources.Scissors;
                lblActions.Text = "While you raise your shield, the boss vanishes among decoys!";
                if (opponentmirage == 1)
                {
                    mirage1 = false;
                    mirage2 = true;
                    mirage3 = true;
                }
                else if (opponentmirage == 2)
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
                if (protectCD != 0)
                    protectCD -= 1;
                chargedCD -= 1;

            }
            Upkeep();


        }

        private void lblBoss1_Click(object sender, EventArgs e)
        {
            opponentmove = generator.Next(0, 3);
            opponentmirage = generator.Next(1, 4);
            if (((deciding == true) && radRock.Checked == true) && mirage1 == false) //ROCK
            {

                imgPlayer.Image = Properties.Resources.Rock;
                if (chargedCD == 0)
                {
                    imgBoss1.Image = Properties.Resources.Rock;
                    imgBoss2.Image = Properties.Resources.Paper;
                    imgBoss3.Image = Properties.Resources.Scissors;
                    lblActions.Text = "Rock clashes with the Trinity, and both combatants take damage!";
                    if (barPlayerhp.Value < 100)
                        barPlayerhp.Value = 0;
                    else
                        barPlayerhp.Value -= 100;
                    barBoss1hp.Value -= 25;
                    mirageCD -= 1;
                    if (protectCD != 0)
                        protectCD -= 1;
                    chargedCD = 5;
                }
                else if (mirageCD == 0)
                {
                    imgBoss1.Image = Properties.Resources.Rock;
                    imgBoss2.Image = Properties.Resources.Paper;
                    imgBoss3.Image = Properties.Resources.Scissors;
                    lblActions.Text = "Rock connects with the boss, and he takes damage! However, he dissapears among decoys!";
                    barBoss1hp.Value -= 25;
                    opponentrealhp -= 25;
                    if (opponentmirage == 1)
                    {
                        mirage1 = false;
                        mirage2 = true;
                        mirage3 = true;
                    }
                    else if (opponentmirage == 2)
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
                    lblBoss2.Visible = true;
                    barBoss2hp.Visible = true;
                    lblBoss3.Visible = true;
                    barBoss3hp.Visible = true;
                    imgBoss2.Visible = true;
                    imgBoss3.Visible = true;
                    barBoss1hp.Value = opponentrealhp;
                    barBoss2hp.Value = opponentrealhp;
                    barBoss3hp.Value = opponentrealhp;
                    mirageCD = 5;
                    if (protectCD != 0)
                        protectCD -= 1;
                    chargedCD -= 1;
                }
                else if (opponentmove == 0)
                {
                    imgBoss1.Image = Properties.Resources.Rock;
                    imgBoss2.Image = Properties.Resources.Rock;
                    imgBoss3.Image = Properties.Resources.Rock;
                    lblActions.Text = "Rock clashes with Rock, and nothing happens!";
                    mirageCD -= 1;
                    protectCD -= 1;
                    chargedCD -= 1;
                }
                else if (opponentmove == 1)
                {
                    imgBoss1.Image = Properties.Resources.Paper;
                    imgBoss2.Image = Properties.Resources.Paper;
                    imgBoss3.Image = Properties.Resources.Paper;
                    lblActions.Text = "Rock clashes with Paper, and you take damage!";
                    barPlayerhp.Value -= 25;
                    mirageCD -= 1;
                    if (protectCD != 0)
                        protectCD -= 1;
                    chargedCD -= 1;
                }
                else
                {
                    imgBoss1.Image = Properties.Resources.Scissors;
                    imgBoss2.Image = Properties.Resources.Scissors;
                    imgBoss3.Image = Properties.Resources.Scissors;
                    lblActions.Text = "Rock clashes with scissors, and he takes damage!";
                    barBoss1hp.Value -= 25;
                    opponentrealhp -= 25;
                    mirageCD -= 1;
                    if (protectCD != 0)
                        protectCD -= 1; ;
                    chargedCD -= 1;
                }
            }
            else if (((deciding == true) && radPaper.Checked == true) && mirage1 == false) //PAPER
            {
                imgPlayer.Image = Properties.Resources.Paper;
                if (chargedCD == 0)
                {
                    imgBoss1.Image = Properties.Resources.Rock;
                    imgBoss2.Image = Properties.Resources.Paper;
                    imgBoss3.Image = Properties.Resources.Scissors;
                    lblActions.Text = "Paper clashes with the Trinity, and both combatants take damage!";
                    if (barPlayerhp.Value < 100)
                        barPlayerhp.Value = 0;
                    else
                        barPlayerhp.Value -= 100;
                    barBoss1hp.Value -= 25;
                    opponentrealhp -= 25;
                    mirageCD -= 1;
                    if (protectCD != 0)
                        protectCD -= 1;
                    chargedCD = 5;
                }
                else if (mirageCD == 0)
                {
                    imgBoss1.Image = Properties.Resources.Rock;
                    imgBoss2.Image = Properties.Resources.Paper;
                    imgBoss3.Image = Properties.Resources.Scissors;
                    lblActions.Text = "Paper connects with the boss, and he takes damage! However, he dissapears among decoys!";
                    barBoss1hp.Value -= 25;
                    opponentrealhp -= 25;
                    if (opponentmirage == 1)
                    {
                        mirage1 = false;
                        mirage2 = true;
                        mirage3 = true;
                    }
                    else if (opponentmirage == 2)
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
                    lblBoss2.Visible = true;
                    barBoss2hp.Visible = true;
                    lblBoss3.Visible = true;
                    barBoss3hp.Visible = true;
                    imgBoss2.Visible = true;
                    imgBoss3.Visible = true;
                    barBoss1hp.Value = opponentrealhp;
                    barBoss2hp.Value = opponentrealhp;
                    barBoss3hp.Value = opponentrealhp;
                    mirageCD = 5;
                    if (protectCD != 0)
                        protectCD -= 1;
                    chargedCD -= 1;
                }
                else if (opponentmove == 0)
                {
                    imgBoss1.Image = Properties.Resources.Rock;
                    imgBoss2.Image = Properties.Resources.Rock;
                    imgBoss3.Image = Properties.Resources.Rock;
                    lblActions.Text = "Paper clashes with Rock, and he takes damage!";
                    opponentrealhp -= 25;
                    barBoss1hp.Value -= 25;
                    mirageCD -= 1;
                    if (protectCD != 0)
                        protectCD -= 1;
                    chargedCD -= 1;
                }
                else if (opponentmove == 1)
                {
                    imgBoss1.Image = Properties.Resources.Paper;
                    imgBoss2.Image = Properties.Resources.Paper;
                    imgBoss3.Image = Properties.Resources.Paper;
                    lblActions.Text = "Paper clashes with Paper, and nothing happens!";
                    mirageCD -= 1;
                    if (protectCD != 0)
                        protectCD -= 1;
                    chargedCD -= 1;
                }
                else
                {
                    imgBoss1.Image = Properties.Resources.Scissors;
                    imgBoss2.Image = Properties.Resources.Scissors;
                    imgBoss3.Image = Properties.Resources.Scissors;
                    lblActions.Text = "Paper clashes with scissors, and you take damage!";
                    barPlayerhp.Value -= 25;
                    mirageCD -= 1;
                    if (protectCD != 0)
                        protectCD -= 1;
                    chargedCD -= 1;

                }

            }
            else if (((deciding == true) && radScissors.Checked == true) && mirage1 == false) //Scissors
            {
                imgPlayer.Image = Properties.Resources.Scissors;
                if (chargedCD == 0)
                {
                    imgBoss1.Image = Properties.Resources.Rock;
                    imgBoss2.Image = Properties.Resources.Paper;
                    imgBoss3.Image = Properties.Resources.Scissors;
                    lblActions.Text = "Scissors clashes with the Trinity, and both combatants take damage!";
                    if (barPlayerhp.Value < 100)
                        barPlayerhp.Value = 0;
                    else
                        barPlayerhp.Value -= 100;
                    barBoss1hp.Value -= 25;
                    opponentrealhp -= 25;
                    mirageCD -= 1;
                    if (protectCD != 0)
                        protectCD -= 1;
                    chargedCD = 5;
                }
                else if (mirageCD == 0)
                {
                    imgBoss1.Image = Properties.Resources.Rock;
                    imgBoss2.Image = Properties.Resources.Paper;
                    imgBoss3.Image = Properties.Resources.Scissors;
                    lblActions.Text = "Scissors connects with the boss, and he takes 25 damage! However, he dissapears among decoys!";
                    barBoss1hp.Value -= 25;
                    opponentrealhp -= 25;
                    if (opponentmirage == 1)
                    {
                        mirage1 = false;
                        mirage2 = true;
                        mirage3 = true;
                    }
                    else if (opponentmirage == 2)
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
                    lblBoss2.Visible = true;
                    barBoss2hp.Visible = true;
                    lblBoss3.Visible = true;
                    barBoss3hp.Visible = true;
                    imgBoss2.Visible = true;
                    imgBoss3.Visible = true;
                    barBoss1hp.Value = opponentrealhp;
                    barBoss2hp.Value = opponentrealhp;
                    barBoss3hp.Value = opponentrealhp;
                    mirageCD = 5;
                    if (protectCD != 0)
                        protectCD -= 1;
                    chargedCD -= 1;
                }
                else if (opponentmove == 0)
                {
                    imgBoss1.Image = Properties.Resources.Rock;
                    imgBoss2.Image = Properties.Resources.Rock;
                    imgBoss3.Image = Properties.Resources.Rock;
                    lblActions.Text = "Scissors clashes with Rock, and you take damage!";
                    barPlayerhp.Value -= 25;
                    mirageCD -= 1;
                    if (protectCD != 0)
                        protectCD -= 1;
                    chargedCD -= 1;
                }
                else if (opponentmove == 1)
                {
                    imgBoss1.Image = Properties.Resources.Paper;
                    imgBoss2.Image = Properties.Resources.Paper;
                    imgBoss3.Image = Properties.Resources.Paper;
                    lblActions.Text = "Scissors clashes with Paper, and he takes damage!";
                    barBoss1hp.Value -= 25;
                    opponentrealhp -= 25;
                    mirageCD -= 1;
                    if (protectCD != 0)
                        protectCD -= 1;
                    chargedCD -= 1;
                }
                else
                {
                    imgBoss1.Image = Properties.Resources.Scissors;
                    imgBoss2.Image = Properties.Resources.Scissors;
                    imgBoss3.Image = Properties.Resources.Scissors;
                    lblActions.Text = "Scissors clashes with scissors, and nothing happens!";
                    mirageCD -= 1;
                    if (protectCD != 0)
                        protectCD -= 1;
                    chargedCD -= 1;

                }
            }
            else if (((deciding == true) && mirage1 == true) && chargedCD == 0)
            {
                if (radRock.Checked == true)
                    imgPlayer.Image = Properties.Resources.Rock;
                else if (radPaper.Checked == true)
                    imgPlayer.Image = Properties.Resources.Paper;
                else if (radScissors.Checked == true)
                    imgPlayer.Image = Properties.Resources.Scissors;
                lblActions.Text = "The blow connects, but it struck a decoy! While distracted, the boss hits you with the Trinity!";
                lblBoss1.Visible = false;
                barBoss1hp.Visible = false;
                imgBoss1.Visible = false;
                if (barPlayerhp.Value >= 125)
                        barPlayerhp.Value -= 125;
                else
                    barPlayerhp.Value = 0;
                mirageCD -= 1;
                if (protectCD != 0)
                    protectCD -= 1;
                chargedCD = 5;
            }
            else if ((deciding == true) && mirage1 == true)
            {
                if (radRock.Checked == true)
                    imgPlayer.Image = Properties.Resources.Rock;
                else if (radPaper.Checked == true)
                    imgPlayer.Image = Properties.Resources.Paper;
                else if (radScissors.Checked == true)
                    imgPlayer.Image = Properties.Resources.Scissors;
                lblActions.Text = "The blow connects, but it struck a decoy! While distracted, the boss hits you!";
                lblBoss1.Visible = false;
                barBoss1hp.Visible = false;
                imgBoss1.Visible = false;
                barPlayerhp.Value -= 25;
                mirageCD -= 1;
                if (protectCD != 0)
                    protectCD -= 1;
                chargedCD -= 1;
            }
            else
                lblActions.Text = "How";
            Upkeep();
        }

        private void lblBoss3_Click(object sender, EventArgs e)
        {
            opponentmove = generator.Next(0, 3);
            opponentmirage = generator.Next(1, 4);
            if (((deciding == true) && radRock.Checked == true) && mirage3 == false) //ROCK
            {

                imgPlayer.Image = Properties.Resources.Rock;
                if (chargedCD == 0)
                {
                    imgBoss1.Image = Properties.Resources.Rock;
                    imgBoss2.Image = Properties.Resources.Paper;
                    imgBoss3.Image = Properties.Resources.Scissors;
                    lblActions.Text = "Rock clashes with the Trinity, and both combatants take damage!";
                    if (barPlayerhp.Value < 100)
                        barPlayerhp.Value = 0;
                    else
                        barPlayerhp.Value -= 100;
                    barBoss3hp.Value -= 25;
                    mirageCD -= 1;
                    if (protectCD != 0)
                        protectCD -= 1;
                    chargedCD = 5;
                }
                else if (mirageCD == 0)
                {
                    imgBoss1.Image = Properties.Resources.Rock;
                    imgBoss2.Image = Properties.Resources.Paper;
                    imgBoss3.Image = Properties.Resources.Scissors;
                    lblActions.Text = "Rock connects with the boss, and he takes damage! However, he dissapears among decoys!";
                    barBoss3hp.Value -= 25;
                    opponentrealhp -= 25;
                    if (opponentmirage == 1)
                    {
                        mirage1 = false;
                        mirage2 = true;
                        mirage3 = true;
                    }
                    else if (opponentmirage == 2)
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
                    lblBoss2.Visible = true;
                    barBoss2hp.Visible = true;
                    imgBoss1.Visible = true;
                    imgBoss2.Visible = true;
                    barBoss1hp.Value = opponentrealhp;
                    barBoss2hp.Value = opponentrealhp;
                    barBoss3hp.Value = opponentrealhp;
                    mirageCD = 5;
                    chargedCD -= 1;
                }
                else if (opponentmove == 0)
                {
                    imgBoss1.Image = Properties.Resources.Rock;
                    imgBoss2.Image = Properties.Resources.Rock;
                    imgBoss3.Image = Properties.Resources.Rock;
                    lblActions.Text = "Rock clashes with Rock, and nothing happens!";
                    mirageCD -= 1;
                    if (protectCD != 0)
                        protectCD -= 1;
                    chargedCD -= 1;
                }
                else if (opponentmove == 1)
                {
                    imgBoss1.Image = Properties.Resources.Paper;
                    imgBoss2.Image = Properties.Resources.Paper;
                    imgBoss3.Image = Properties.Resources.Paper;
                    lblActions.Text = "Rock clashes with Paper, and you take damage!";
                    barPlayerhp.Value -= 25;
                    mirageCD -= 1;
                    if (protectCD != 0)
                        protectCD -= 1;
                    chargedCD -= 1;
                }
                else
                {
                    imgBoss1.Image = Properties.Resources.Scissors;
                    imgBoss2.Image = Properties.Resources.Scissors;
                    imgBoss3.Image = Properties.Resources.Scissors;
                    lblActions.Text = "Rock clashes with scissors, and he takes damage!";
                    barBoss3hp.Value -= 25;
                    opponentrealhp -= 25;
                    mirageCD -= 1;
                    if (protectCD != 0)
                        protectCD -= 1;
                    chargedCD -= 1;
                }
            }
            else if (((deciding == true) && radPaper.Checked == true) && mirage3 == false) //PAPER
            {
                imgPlayer.Image = Properties.Resources.Paper;
                if (chargedCD == 0)
                {
                    imgBoss1.Image = Properties.Resources.Rock;
                    imgBoss2.Image = Properties.Resources.Paper;
                    imgBoss3.Image = Properties.Resources.Scissors;
                    lblActions.Text = "Paper clashes with the Trinity, and both combatants take damage!";
                    if (barPlayerhp.Value < 100)
                        barPlayerhp.Value = 0;
                    else
                        barPlayerhp.Value -= 100;
                    barBoss3hp.Value -= 25;
                    opponentrealhp -= 25;
                    mirageCD -= 1;
                    if (protectCD != 0)
                        protectCD -= 1;
                    chargedCD = 5;
                }
                else if (mirageCD == 0)
                {
                    imgBoss1.Image = Properties.Resources.Rock;
                    imgBoss2.Image = Properties.Resources.Paper;
                    imgBoss3.Image = Properties.Resources.Scissors;
                    lblActions.Text = "Paper connects with the boss, and he takes damage! However, he dissapears among decoys!";
                    barBoss3hp.Value -= 25;
                    opponentrealhp -= 25;
                    if (opponentmirage == 1)
                    {
                        mirage1 = false;
                        mirage2 = true;
                        mirage3 = true;
                    }
                    else if (opponentmirage == 2)
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
                    lblBoss2.Visible = true;
                    barBoss2hp.Visible = true;
                    imgBoss1.Visible = true;
                    imgBoss2.Visible = true;
                    barBoss1hp.Value = opponentrealhp;
                    barBoss2hp.Value = opponentrealhp;
                    barBoss3hp.Value = opponentrealhp;
                    mirageCD = 5;
                    if (protectCD != 0)
                        protectCD -= 1;
                    chargedCD -= 1;
                }
                else if (opponentmove == 0)
                {
                    imgBoss1.Image = Properties.Resources.Rock;
                    imgBoss2.Image = Properties.Resources.Rock;
                    imgBoss3.Image = Properties.Resources.Rock;
                    lblActions.Text = "Paper clashes with Rock, and he takes damage!";
                    opponentrealhp -= 25;
                    barBoss3hp.Value -= 25;
                    mirageCD -= 1;
                    if (protectCD != 0)
                        protectCD -= 1;
                    chargedCD -= 1;
                }
                else if (opponentmove == 1)
                {
                    imgBoss1.Image = Properties.Resources.Paper;
                    imgBoss2.Image = Properties.Resources.Paper;
                    imgBoss3.Image = Properties.Resources.Paper;
                    lblActions.Text = "Paper clashes with Paper, and nothing happens!";
                    mirageCD -= 1;
                    if (protectCD != 0)
                        protectCD -= 1;
                    chargedCD -= 1;
                }
                else
                {
                    imgBoss1.Image = Properties.Resources.Scissors;
                    imgBoss2.Image = Properties.Resources.Scissors;
                    imgBoss3.Image = Properties.Resources.Scissors;
                    lblActions.Text = "Paper clashes with scissors, and you take damage!";
                    barPlayerhp.Value -= 25;
                    mirageCD -= 1;
                    if (protectCD != 0)
                        protectCD -= 1;
                    chargedCD -= 1;

                }

            }
            else if (((deciding == true) && radScissors.Checked == true) && mirage3 == false) //Scissors
            {
                imgPlayer.Image = Properties.Resources.Scissors;
                if (chargedCD == 0)
                {
                    imgBoss1.Image = Properties.Resources.Rock;
                    imgBoss2.Image = Properties.Resources.Paper;
                    imgBoss3.Image = Properties.Resources.Scissors;
                    lblActions.Text = "Scissors clashes with the Trinity, and both combatants take damage!";
                    if (barPlayerhp.Value < 100)
                        barPlayerhp.Value = 0;
                    else
                        barPlayerhp.Value -= 100;
                    barBoss3hp.Value -= 25;
                    opponentrealhp -= 25;
                    mirageCD -= 1;
                    if (protectCD != 0)
                        protectCD -= 1;
                    chargedCD = 5;
                }
                else if (mirageCD == 0)
                {
                    imgBoss1.Image = Properties.Resources.Rock;
                    imgBoss2.Image = Properties.Resources.Paper;
                    imgBoss3.Image = Properties.Resources.Scissors;
                    lblActions.Text = "Scissors connects with the boss, and he takes 25 damage! However, he dissapears among decoys!";
                    barBoss3hp.Value -= 25;
                    opponentrealhp -= 25;
                    if (opponentmirage == 1)
                    {
                        mirage1 = false;
                        mirage2 = true;
                        mirage3 = true;
                    }
                    else if (opponentmirage == 2)
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
                    lblBoss2.Visible = true;
                    barBoss2hp.Visible = true;
                    imgBoss1.Visible = true;
                    imgBoss2.Visible = true;
                    barBoss1hp.Value = opponentrealhp;
                    barBoss2hp.Value = opponentrealhp;
                    barBoss3hp.Value = opponentrealhp;
                    mirageCD = 5;
                    if (protectCD != 0)
                        protectCD -= 1;
                    chargedCD -= 1;
                }
                else if (opponentmove == 0)
                {
                    imgBoss1.Image = Properties.Resources.Rock;
                    imgBoss2.Image = Properties.Resources.Rock;
                    imgBoss3.Image = Properties.Resources.Rock;
                    lblActions.Text = "Scissors clashes with Rock, and you take damage!";
                    barPlayerhp.Value -= 25;
                    mirageCD -= 1;
                    if (protectCD != 0)
                        protectCD -= 1;
                    chargedCD -= 1;
                }
                else if (opponentmove == 1)
                {
                    imgBoss1.Image = Properties.Resources.Paper;
                    imgBoss2.Image = Properties.Resources.Paper;
                    imgBoss3.Image = Properties.Resources.Paper;
                    lblActions.Text = "Scissors clashes with Paper, and he takes damage!";
                    barBoss3hp.Value -= 25;
                    opponentrealhp -= 25;
                    mirageCD -= 1;
                    if (protectCD != 0)
                        protectCD -= 1;
                    chargedCD -= 1;
                }
                else
                {
                    imgBoss1.Image = Properties.Resources.Scissors;
                    imgBoss2.Image = Properties.Resources.Scissors;
                    imgBoss3.Image = Properties.Resources.Scissors;
                    lblActions.Text = "Scissors clashes with scissors, and nothing happens!";
                    mirageCD -= 1;
                    if (protectCD != 0)
                        protectCD -= 1;
                    chargedCD -= 1;

                }
            }
            else if (((deciding == true) && mirage3 == true) && chargedCD == 0)
            {
                if (radRock.Checked == true)
                    imgPlayer.Image = Properties.Resources.Rock;
                else if (radPaper.Checked == true)
                    imgPlayer.Image = Properties.Resources.Paper;
                else if (radScissors.Checked == true)
                    imgPlayer.Image = Properties.Resources.Scissors;
                lblActions.Text = "The blow connects, but it struck a decoy! While distracted, the boss hits you with the Trinity!";
                lblBoss3.Visible = false;
                barBoss3hp.Visible = false;
                imgBoss3.Visible = false;
                if (barPlayerhp.Value >= 125)
                    barPlayerhp.Value -= 125;
                else
                    barPlayerhp.Value = 0;
                mirageCD -= 1;
                if (protectCD != 0)
                    protectCD -= 1;
                chargedCD = 5;
            }

            else if ((deciding == true) && mirage3 == true)
            {
                if (radRock.Checked == true)
                    imgPlayer.Image = Properties.Resources.Rock;
                else if (radPaper.Checked == true)
                    imgPlayer.Image = Properties.Resources.Paper;
                else if (radScissors.Checked == true)
                    imgPlayer.Image = Properties.Resources.Scissors;
                lblActions.Text = "The blow connects, but it struck a decoy! While distracted, the boss hits you!";
                lblBoss3.Visible = false;
                barBoss3hp.Visible = false;
                imgBoss3.Visible = false;
                barPlayerhp.Value -= 25;
                mirageCD -= 1;
                if (protectCD != 0)
                    protectCD -= 1;
                chargedCD -= 1;
            }
            else
                lblActions.Text = "How";
            Upkeep();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            System.IO.Stream str = Properties.Resources.Warrior_Boss_Battle___Copy;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.PlayLooping();
            grpDecision.Visible = true;
            lblPlayer.Visible = true;
            lblPlayerhp.Visible = true;
            lblPlayerhp.Text = "250 / 250";
            barPlayerhp.Visible = true;
            barPlayerhp.Value = 250;
            lblBoss2.Visible = true;
            barBoss2hp.Visible = true;
            imgBoss2.Visible = true;
            barBoss2hp.Value = 250;
            lblActions.Text = "";
            lblActions.Visible = true;
            btnPlay.Visible = false;
            btnPlay.Text = "Play again?";
            radRock.Enabled = true;
            radPaper.Enabled = true;
            radScissors.Enabled = true;
            radProtect.Enabled = true;
            lblBoss1.Visible = false;
            barBoss1hp.Visible = false;
            barBoss3hp.Visible = false;
            lblBoss3.Visible = false;
            imgBoss1.Visible = false;
            imgBoss3.Visible = false;
             deciding = false;
             mirage1 = false;
             mirage2 = false;
             mirage3 = false;
             mirageCD = 1;
             chargedCD = 3;
             protectCD = 0;
             opponentrealhp = 250;
             protectCD = 0;
             timer = 0;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }  
}
