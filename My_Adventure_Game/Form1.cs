using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Media;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace My_Adventure_Game
{
    public partial class Form1 : Form
    {
        int page;
        int cape = 1, ninjastar = 1, bamboo = 0;
        int ranNum;
        Random ranGen = new Random();
        string answer;

        private void bamboo_Button_Click(object sender, EventArgs e)
        {
            itemLabel.Text = "【BAMBOO】";
            itemLabel.Text += "\nYou can use this to breath \nhidding in the water.";
            itemLabel.Text += "\nThis is the Ninja skill called WATER-ESCAPE.";
            item_picBox.BackgroundImage = Properties.Resources.water_hide_pic;
        }

        private void cape_Button_Click(object sender, EventArgs e)
        {
            itemLabel.Text = "【CAPE】";
            itemLabel.Text += "\nYou can use this to blend into the wall.";
            itemLabel.Text += "\nNinja use this to camouflage.";
            item_picBox.BackgroundImage = Properties.Resources.cape_pic;
        }

        private void ninja_star_Button_Click_1(object sender, EventArgs e)
        {
            itemLabel.Text = "【NINJA STAR】";
            itemLabel.Text += "\nYou can throw this to kill someone.";
            itemLabel.Text += "\nThis is the most famous Ninja weapon.";
            item_picBox.BackgroundImage = Properties.Resources.ninja_star_pic;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ///
            if (page == 1)
            {
                page = 3;
            }

            else if (page == 4)
            {
                page = 6;
            }

            else if (page == 7)
            {
                page = 8;
            }

            else if (page == 8 || page == 9)
            {
                page = 11;
            }

            else if (page == 11)
            {
                page = 13;
            }

            else if (page == 12 || page == 13)
            {
                page = 14;
            }

            else if (page == 15)
            {
                if (cape == 1)
                {
                    page = 20;
                }

                else if (cape == 0)
                {
                    page = 22;
                }
            }

            else if (page == 16)
            {
                ranNum = ranGen.Next(1,101);
                if (ranNum >= 50)
                {
                    page = 18;
                }

                else if (ranNum >= 100)
                {
                    page = 19;
                }
            }

            else if (page == 17 || page == 19 || page == 23)
            {
                page = 24;
            }

            else if (page == 20)
            {
                page = 22;
            }

            else if (page == 27)
            {
                page = 31;
            }

            else if (page == 28)
            {
                page = 30;
            }
            
            else if (page == 31)
            {
                page = 32;
            }

            else if (page == 33)
            {
                page = 34;
            }

            else if (page == 99)
            {
                this.Close();
            }
            ///
            switch (page)
            {
                case 1:
                    {
                        topLabel.Text = "You are the NINJA\n\n【MISSION】   Assasinate the enemy's boss!";
                        askLabel.Text = "Select the way you want to go.";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Go to main gate";
                        button2.Show();
                        button1.Enabled = true;
                        button2.Text = "Look around";
                        button3.Show();
                        button3.Enabled = true;
                        button3.Text = "Dive to the\nwater moats";
                        imagebox.BackgroundImage = Properties.Resources.page_1;
                    }
                    break;

                case 2:
                    {
                        topLabel.Text = "【MISSON FAILED】   The gate keeper found you.";
                        askLabel.Text = "Play again?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        button3.Hide();
                        button3.Enabled = false;
                        page = 99;
                        imagebox.BackgroundImage = Properties.Resources.page_2;
                        SoundPlayer gameoversound = new SoundPlayer(Properties.Resources.game_over);
                        gameoversound.Play();
                    }
                    break;

                case 3:
                    {
                        if (bamboo == 0)
                        {
                            topLabel.Text = "You get the BAMBOO";
                            askLabel.Text = "";
                            bamboo = 1;
                            bamboo_Button.Visible = true;
                            bamboo_Button.Enabled = true;
                            button1.Hide();
                            button1.Enabled = false;
                            button2.Hide();
                            button2.Enabled = false;
                            button3.Hide();
                            button3.Enabled = false;
                            imagebox.BackgroundImage = Properties.Resources.page_3;
                        }

                        else if (bamboo == 1)
                        {
                            topLabel.Text = "You already got the item.";
                            askLabel.Text = "";
                            button1.Hide();
                            button1.Enabled = false;
                            button2.Hide();
                            button2.Enabled = false;
                            button3.Hide();
                            button3.Enabled = false;
                            imagebox.BackgroundImage = Properties.Resources.page_3;
                        }
                        Refresh();
                        Thread.Sleep(2000);
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Go to main gate";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "Look around";
                        button3.Show();
                        button3.Enabled = true;
                        button3.Text = "Dive to the\nwater moats";
                        askLabel.Text = "Select the way you want to go.";
                        topLabel.Text = "You are the NINJA\n\n【MISSION】   Assasinate the enemy's boss!";
                        imagebox.BackgroundImage= Properties.Resources.page_1;
                        page = 1;
                    }
                    break;

                case 4:
                    {
                        topLabel.Text = "No one noticed";
                        askLabel.Text = "How to across the moats?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Swim";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "Run on the water";
                        button3.Hide();
                        button3.Enabled = false;

                        if (bamboo == 1)
                        {
                            button3.Show();
                            button3.Enabled = true;
                            button3.Text = "Use the bamboo";
                        }
                        imagebox.BackgroundImage = Properties.Resources.page_4;
                    }
                    break;

                case 5:
                    {
                        topLabel.Text = "【MISSON FAILED】   A watchman realized your bubbling. ";
                        if (bamboo == 0)
                        {
                            topLabel.Text += "\n\nHint: Try to search the item";
                        }
                        askLabel.Text = "Play again?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        button3.Hide();
                        button3.Enabled = false;
                        imagebox.BackgroundImage = Properties.Resources.page_2;
                        SoundPlayer gameoversound = new SoundPlayer(Properties.Resources.game_over);
                        gameoversound.Play();
                        page = 99;
                    }
                    break;

                case 6:
                    {
                        topLabel.Text = "【MISSON FAILED】   People can't run on the water lol.";
                        topLabel.Text += "\n\nHint: Try to search the item";
                        askLabel.Text = "Play again?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        button3.Hide();
                        button3.Enabled = false;
                        imagebox.BackgroundImage = Properties.Resources.page_6;
                        SoundPlayer gameoversound = new SoundPlayer(Properties.Resources.game_over);
                        gameoversound.Play();
                        page = 99;
                    }
                    break;

                case 7:
                    {
                        bamboo = 0;
                        bamboo_Button.Visible = false;
                        bamboo_Button.Enabled= false;
                        itemLabel.Text = "";
                        item_picBox.BackgroundImage = null;
                        topLabel.Text = "No one noticed.";
                        topLabel.Text += "\nYou used the bamboo and acrossed the moats";
                        askLabel.Text = "";
                        button1.Hide();
                        button1.Enabled = false;
                        button2.Hide();
                        button2.Enabled = false;
                        button3.Hide();
                        button3.Enabled = false;
                        imagebox.BackgroundImage = Properties.Resources.page_7_1_;
                        Refresh();
                        Thread.Sleep(6000);
                        topLabel.Text = "You are climbing the castle wall.\nYou feel someone watching you";
                        askLabel.Text = "Use the CAPE to hide?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        imagebox.BackgroundImage = Properties.Resources.page_7_2_;
                    }
                    break;

                case 8:
                    {
                        topLabel.Text = "Just the frog watching you.";
                        askLabel.Text = "";
                        button1.Hide();
                        button1.Enabled = false;
                        button2.Hide();
                        button2.Enabled = false;
                        imagebox.BackgroundImage = Properties.Resources.page_8_1_;
                        Refresh();
                        Thread.Sleep(3000);
                        topLabel.Text = "You found the window";
                        askLabel.Text = "Go in to the castle from the window?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        imagebox.BackgroundImage = Properties.Resources.page_8_2_;
                    }
                    break;

                case 9:
                    {
                        cape = 0;
                        cape_Button.Visible = false;
                        cape_Button.Enabled = false;
                        itemLabel.Text = "";
                        item_picBox.BackgroundImage = null;
                        topLabel.Text = "You used the cape and make it through.";
                        askLabel.Text = "";
                        button1.Hide();
                        button1.Enabled = false;
                        button2.Hide();
                        button2.Enabled = false;
                        imagebox.BackgroundImage = Properties.Resources.page_9;
                        Refresh();
                        Thread.Sleep(5000);
                        topLabel.Text = "You found the window";
                        askLabel.Text = "Go in to the castle from the window?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        imagebox.BackgroundImage = Properties.Resources.page_8_2_;
                    }
                    break;

                case 10:
                    {
                        topLabel.Text = "【MISSION FAILED】The room you go in to is the meeting room.";
                        topLabel.Text += "\nEvery soldier realized you and you were killed";
                        askLabel.Text = "Play again?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        button3.Hide();
                        button3.Enabled = false;
                        imagebox.BackgroundImage = Properties.Resources.page_10;
                        SoundPlayer gameoversound = new SoundPlayer(Properties.Resources.game_over);
                        gameoversound.Play();
                        page = 99;
                    }
                    break;

                case 11:
                    {
                        topLabel.Text = "Actually, the room you wanted to go in to is the meeting room.";
                        button1.Hide();
                        button1.Enabled = false;
                        button2.Hide();
                        button2.Enabled = false;
                        askLabel.Text = "Eavsdrop their conversation?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        imagebox.BackgroundImage = Properties.Resources.page_11;
                    }
                    break;

                case 12:
                    {
                        topLabel.Text = "You heard they said SUSHI is the secret word.";
                        secretLabel.Text = "Secret word: SUSHI";
                        askLabel.Text = "";
                        button1.Hide();
                        button1.Enabled = false;
                        button2.Hide();
                        button2.Enabled = false;
                        secretwordLabel.Visible = true;
                        secret_word_pic.Visible = true;
                        Refresh();
                        Thread.Sleep(6000);
                        topLabel.Text = "You found the new window";
                        askLabel.Text = "Go in to the castle from the window?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        imagebox.BackgroundImage = Properties.Resources.page_8_2_;
                    }
                    break;

                case 13:
                    {
                        topLabel.Text = "You found the new window";
                        askLabel.Text = "Go in to the castle from the window?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        imagebox.BackgroundImage = Properties.Resources.page_8_2_;
                    }
                    break;

                case 14:
                    {
                        topLabel.Text = "【MISSION FAILED】   You are realized by the watchman in outside";
                        askLabel.Text = "Play again?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        button3.Hide();
                        button3.Enabled = false;
                        page = 99;
                        imagebox.BackgroundImage = Properties.Resources.page_2;
                        SoundPlayer gameoversound = new SoundPlayer(Properties.Resources.game_over);
                        gameoversound.Play();
                    }
                    break;

                case 15:
                    {
                        topLabel.Text = "You succeeded to intrusion, but you see the soldier coming";
                        askLabel.Text = "What do you do?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Kill the soldier";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "Hide";
                        imagebox.BackgroundImage = Properties.Resources.page_15;
                    }
                    break;

                case 16:
                    {
                        topLabel.Text = "";
                        askLabel.Text = "Use the NINJA STAR ?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        imagebox.BackgroundImage = Properties.Resources.page_16;
                    }
                    break;

                case 17:
                    {
                        ninjastar = 0;
                        ninja_star_Button.Visible = false;
                        ninja_star_Button.Enabled = false;
                        itemLabel.Text = "";
                        item_picBox.BackgroundImage = null;
                        topLabel.Text = "You killed the soldier.";
                        topLabel.Text += "\nYou hide the cadaver";
                        askLabel.Text = "Change to the soldier clothes?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        button3.Hide();
                        button3.Enabled = false;
                        imagebox.BackgroundImage = Properties.Resources.page_17;
                    }
                    break;

                case 18:
                    {
                        topLabel.Text = "【MISSION FAILED】   You are killed by the soldier.";
                        askLabel.Text = "Play again?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        button3.Hide();
                        button3.Enabled = false;
                        imagebox.BackgroundImage = Properties.Resources.page_2;
                        SoundPlayer gameoversound = new SoundPlayer(Properties.Resources.game_over);
                        gameoversound.Play();
                        page = 99;
                    }
                    break;

                case 19:
                    {
                        topLabel.Text = "You panched and succeeded to kill the soldier";
                        topLabel.Text += "\nYou hide the cadaver";
                        askLabel.Text = "";
                        button1.Hide();
                        button1.Enabled = false;
                        button2.Hide();
                        button2.Enabled = false;
                        askLabel.Text = "Change to the soldier clothes?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        button3.Hide();
                        button3.Enabled = false;
                        imagebox.BackgroundImage = Properties.Resources.page_17;
                    }
                    break;

                case 20:
                    {
                        askLabel.Text = "Use the cape?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        imagebox.BackgroundImage = Properties.Resources.page_9;
                    }
                    break;

                case 21:
                    {
                        cape = 0;
                        cape_Button.Visible = false;
                        cape_Button.Enabled = false;
                        topLabel.Text = "The soldier came up to you unnoticed.";
                        askLabel.Text = "Kill him?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        imagebox.BackgroundImage = Properties.Resources.page_20;
                    }
                    break;

                case 22:
                    {
                        topLabel.Text = "【MISSION FAILED】   A soldier realized you.";
                        topLabel.Text += "\n\nHint: When you use the CAPE?";
                        askLabel.Text = "Play again?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        button3.Hide();
                        button3.Enabled = false;
                        page = 99;
                        imagebox.BackgroundImage = Properties.Resources.page_10;
                        SoundPlayer gameoversound = new SoundPlayer(Properties.Resources.game_over);
                        gameoversound.Play();
                    }
                    break;

                case 23:
                    {
                        topLabel.Text = "You took the soldier by surprise.";
                        topLabel.Text += "You succeeded to kill him.";
                        topLabel.Text += "You hide the cadaver";
                        askLabel.Text = "Change to the soldier clothes?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        button3.Hide();
                        button3.Enabled = false;
                        imagebox.BackgroundImage = Properties.Resources.page_17;
                    }
                    break;

                case 24:
                    {
                        topLabel.Text = "【MISSION FAILED】   The new soldier came and realized you";
                        askLabel.Text = "Play again?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        button3.Hide();
                        button3.Enabled = false;
                        page = 99;
                        imagebox.BackgroundImage = Properties.Resources.page_10;
                        SoundPlayer gameoversound = new SoundPlayer(Properties.Resources.game_over);
                        gameoversound.Play();
                    }
                    break;

                case 25:
                    {
                        topLabel.Text = "The new soldier passed you,\nbut he didn't realized you are disguising.";
                        topLabel.Text += "\nYou walk in to the main castle.";
                        askLabel.Text = "";
                        button1.Hide();
                        button1.Enabled = false;
                        button2.Hide();
                        button2.Enabled = false;
                        imagebox.BackgroundImage = Properties.Resources.page_25_1_;
                        Refresh();
                        Thread.Sleep(7000);
                        topLabel.Text = "When you arrived the main castle, the gate keeper said ";
                        topLabel.Text += "You have to say the SECRED WORD when you go in to the main castle.";
                        askLabel.Text = "Answer the SECRET WORD";
                        answertext.Visible = true;
                        enterButton.Visible = true;
                        enterButton.Enabled = true;
                        imagebox.BackgroundImage = Properties.Resources.page_25_2_;
                    }
                    break;

                case 26:
                    {
                        topLabel.Text = "【MISSION FAILED】You missed the SECRET WORD.";
                        topLabel.Text += "\nThe gate keeper realized you are a ninja";
                        askLabel.Text = "Play again?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        button3.Hide();
                        button3.Enabled = false;
                        page = 99;
                        imagebox.BackgroundImage = Properties.Resources.page_2;
                        SoundPlayer gameoversound = new SoundPlayer(Properties.Resources.game_over);
                        gameoversound.Play();
                    }
                    break;

                case 27:
                    {
                        topLabel.Text = "The gate keeper allow you to enter.";
                        topLabel.Text += "You enter to the main castle";
                        askLabel.Text = "What do you do?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Go to the\nBoss Room";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "Walk around";
                        imagebox.BackgroundImage = Properties.Resources.page_27;
                    }
                    break;

                case 28:
                    {
                        topLabel.Text = "You enter to the boss room.";
                        topLabel.Text += "\nThere are few body guards around the enemy's boss.";
                        askLabel.Text = "Kill the boss?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        imagebox.BackgroundImage = Properties.Resources.page_28;
                    }
                    break;

                case 29:
                    {
                        topLabel.Text = "【MISSION FAILED】   You killed a body guard,but the other realized and killed you";
                        askLabel.Text = "Play again?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        button3.Hide();
                        button3.Enabled = false;
                        page = 99;
                        imagebox.BackgroundImage = Properties.Resources.page_10;
                        SoundPlayer gameoversound = new SoundPlayer(Properties.Resources.game_over);
                        gameoversound.Play();
                    }
                    break;

                case 30:
                    {
                        topLabel.Text = "You get out from the boss room";
                        askLabel.Text = "";
                        imagebox.BackgroundImage = Properties.Resources.page_27;
                        button1.Hide();
                        button1.Enabled = false;
                        button2.Hide();
                        button2.Enabled = false;
                        Refresh();
                        Thread.Sleep(2000);
                        askLabel.Text = "What do you do?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Go to the\nBoss room";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "Walk around";
                        page = 27;
                    }
                    break;

                case 31:
                    {
                        topLabel.Text = "You see the doctor going to the boss room.";
                        askLabel.Text = "Kill the doctor?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        imagebox.BackgroundImage = Properties.Resources.page_31;
                    }
                    break;

                case 32:
                    {
                        topLabel.Text = "【MISSION FAILED】   You missd the chance";
                        askLabel.Text = "Play again?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        button3.Hide();
                        button3.Enabled = false;
                        imagebox.BackgroundImage = Properties.Resources.page_10;
                        SoundPlayer gameoversound = new SoundPlayer(Properties.Resources.game_over);
                        gameoversound.Play();
                        page = 99;
                    }
                    break;

                case 33:
                    {
                        askLabel.Text = "Use the NINJA STAR?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        imagebox.BackgroundImage = Properties.Resources.page_16;
                    }
                    break;

                case 34:
                    {
                        topLabel.Text = "【MISSION FAILED】You punched the doctor and killed him,";
                        topLabel.Text += "\nbut you made a big sound.";
                        topLabel.Text += "\nThe gurads heard the sound and killed you";
                        if (ninjastar == 0)
                        {
                            topLabel.Text += "\n\nHint: Where do you use the NINJA STAR?";
                        }
                        askLabel.Text = "Play again?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        button3.Hide();
                        button3.Enabled = false;
                        page = 99;
                        imagebox.BackgroundImage = Properties.Resources.page_10;
                        SoundPlayer gameoversound = new SoundPlayer(Properties.Resources.game_over);
                        gameoversound.Play();
                    }
                    break;

                case 35:
                    {
                        ninjastar = 0;
                        ninja_star_Button.Visible = false;
                        ninja_star_Button.Enabled = false;
                        topLabel.Text = "You succeeded to kill the doctor.";
                        topLabel.Text += "\nYou change to the doctor clothes and enter to the boss room.";
                        topLabel.Text += "\nYou injected the boss with a poison that didn't cause immediate symptoms.";
                        topLabel.Text += "\nThen, you escaped from the castle.";
                        imagebox.BackgroundImage = Properties.Resources.page_35;
                        askLabel.Text = "";
                        button1.Hide();
                        button1.Enabled = false;
                        button2.Hide();
                        button2.Enabled = false;
                        Refresh();
                        Thread.Sleep(12000);
                        topLabel.Text = "【MISSION COMPLETE】   Thank you for playing!!";
                        askLabel.Text = "Play again?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                    }
                    break;
            }
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            answer = answertext.Text;

            if (answer == "SUSHI")
            {
                enterButton.Visible = false;
                enterButton.Enabled = false;
                answertext.Visible = false;
                topLabel.Text = "The gate keeper allow you to enter.";
                topLabel.Text += "You enter to the main castle";
                askLabel.Text = "What do you do?";
                button1.Show();
                button1.Enabled = true;
                button1.Text = "Go to the\nBoss Room";
                button2.Show();
                button2.Enabled = true;
                button2.Text = "Walk around";
                imagebox.BackgroundImage = Properties.Resources.page_27;
                page = 27;
            }

            else
            {
                enterButton.Visible = false;
                enterButton.Enabled = false;
                answertext.Visible = false;
                topLabel.Text = "【MISSION FAILED】\nYou missed the SECRET WORD.";
                topLabel.Text += "\nThe gate keeper realized you are a ninja";
                askLabel.Text = "Play again?";
                button1.Show();
                button1.Enabled = true;
                button1.Text = "Yes";
                button2.Show();
                button2.Enabled = true;
                button2.Text = "No";
                button3.Hide();
                button3.Enabled = false;
                page = 99;
                imagebox.BackgroundImage = Properties.Resources.page_2;
                page = 26;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ///
            if (page == 1)
            {
                page = 4;
            }

            else if (page == 4)
            {
                if (bamboo == 1)
                {
                    page = 7;
                }

                else
                {
                    button3.Visible= false;
                    button3.Enabled= false;
                }
            }

            ///
            switch (page)
            {
                case 1:
                    {
                        topLabel.Text = "You are the NINJA\n\n【MISSION】   Assasinate the enemy's boss!";
                        askLabel.Text = "Select the way you want to go.";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Go to main gate";
                        button2.Show();
                        button1.Enabled = true;
                        button2.Text = "Look around";
                        button3.Show();
                        button3.Enabled = true;
                        button3.Text = "Dive to the\nwater moats";
                        imagebox.BackgroundImage = Properties.Resources.page_1;
                    }
                    break;

                case 2:
                    {
                        topLabel.Text = "【MISSON FAILED】   The gate keeper found you.";
                        askLabel.Text = "Play again?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        button3.Hide();
                        button3.Enabled = false;
                        page = 99;
                        imagebox.BackgroundImage = Properties.Resources.page_2;
                        SoundPlayer gameoversound = new SoundPlayer(Properties.Resources.game_over);
                        gameoversound.Play();
                    }
                    break;

                case 3:
                    {
                        if (bamboo == 0)
                        {
                            topLabel.Text = "You get the BAMBOO";
                            askLabel.Text = "";
                            bamboo = 1;
                            bamboo_Button.Visible = true;
                            bamboo_Button.Enabled = true;
                            button1.Hide();
                            button1.Enabled = false;
                            button2.Hide();
                            button2.Enabled = false;
                            button3.Hide();
                            button3.Enabled = false;
                            imagebox.BackgroundImage = Properties.Resources.page_3;
                        }

                        else if (bamboo == 1)
                        {
                            topLabel.Text = "You already got the item.";
                            askLabel.Text = "";
                            button1.Hide();
                            button1.Enabled = false;
                            button2.Hide();
                            button2.Enabled = false;
                            button3.Hide();
                            button3.Enabled = false;
                            imagebox.BackgroundImage = Properties.Resources.page_3;
                        }
                        Refresh();
                        Thread.Sleep(2000);
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Go to main gate";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "Look around";
                        button3.Show();
                        button3.Enabled = true;
                        button3.Text = "Dive to the\nwater moats";
                        askLabel.Text = "Select the way you want to go.";
                        topLabel.Text = "You are the NINJA\n\n【MISSION】   Assasinate the enemy's boss!";
                        imagebox.BackgroundImage = Properties.Resources.page_1;
                        page = 1;
                    }
                    break;

                case 4:
                    {
                        topLabel.Text = "No one noticed";
                        askLabel.Text = "How to across the moats?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Swim";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "Run on the water";
                        button3.Hide();
                        button3.Enabled = false;

                        if (bamboo == 1)
                        {
                            button3.Show();
                            button3.Enabled = true;
                            button3.Text = "Use the bamboo";
                        }
                        imagebox.BackgroundImage = Properties.Resources.page_4;
                    }
                    break;

                case 5:
                    {
                        topLabel.Text = "【MISSON FAILED】   A watchman realized your bubbling. ";
                        if (bamboo == 0)
                        {
                            topLabel.Text += "\n\nHint: Try to search the item";
                        }
                        askLabel.Text = "Play again?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        button3.Hide();
                        button3.Enabled = false;
                        imagebox.BackgroundImage = Properties.Resources.page_2;
                        SoundPlayer gameoversound = new SoundPlayer(Properties.Resources.game_over);
                        gameoversound.Play();
                        page = 99;
                    }
                    break;

                case 6:
                    {
                        topLabel.Text = "【MISSON FAILED】   People can't run on the water lol.";
                        topLabel.Text += "\n\nHint: Try to search the item";
                        askLabel.Text = "Play again?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        button3.Hide();
                        button3.Enabled = false;
                        imagebox.BackgroundImage = Properties.Resources.page_6;
                        SoundPlayer gameoversound = new SoundPlayer(Properties.Resources.game_over);
                        gameoversound.Play();
                        page = 99;
                    }
                    break;

                case 7:
                    {
                        bamboo = 0;
                        bamboo_Button.Visible = false;
                        bamboo_Button.Enabled = false;
                        itemLabel.Text = "";
                        item_picBox.BackgroundImage = null;
                        topLabel.Text = "No one noticed.";
                        topLabel.Text += "\nYou used the bamboo and acrossed the moats";
                        askLabel.Text = "";
                        button1.Hide();
                        button1.Enabled = false;
                        button2.Hide();
                        button2.Enabled = false;
                        button3.Hide();
                        button3.Enabled = false;
                        imagebox.BackgroundImage = Properties.Resources.page_7_1_;
                        Refresh();
                        Thread.Sleep(6000);
                        topLabel.Text = "You are climbing the castle wall.\nYou feel someone watching you";
                        askLabel.Text = "Use the CAPE to hide?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        imagebox.BackgroundImage = Properties.Resources.page_7_2_;
                    }
                    break;

                case 8:
                    {
                        topLabel.Text = "Just the frog watching you.";
                        askLabel.Text = "";
                        button1.Hide();
                        button1.Enabled = false;
                        button2.Hide();
                        button2.Enabled = false;
                        imagebox.BackgroundImage = Properties.Resources.page_8_1_;
                        Refresh();
                        Thread.Sleep(3000);
                        topLabel.Text = "You found the window";
                        askLabel.Text = "Go in to the castle from the window?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        imagebox.BackgroundImage = Properties.Resources.page_8_2_;
                    }
                    break;

                case 9:
                    {
                        cape = 0;
                        cape_Button.Visible = false;
                        cape_Button.Enabled = false;
                        itemLabel.Text = "";
                        item_picBox.BackgroundImage = null;
                        topLabel.Text = "You used the cape and make it through.";
                        askLabel.Text = "";
                        button1.Hide();
                        button1.Enabled = false;
                        button2.Hide();
                        button2.Enabled = false;
                        imagebox.BackgroundImage = Properties.Resources.page_9;
                        Refresh();
                        Thread.Sleep(5000);
                        topLabel.Text = "You found the window";
                        askLabel.Text = "Go in to the castle from the window?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        imagebox.BackgroundImage = Properties.Resources.page_8_2_;
                    }
                    break;

                case 10:
                    {
                        topLabel.Text = "【MISSION FAILED】The room you go in to is the meeting room.";
                        topLabel.Text += "\nEvery soldier realized you and you were killed";
                        askLabel.Text = "Play again?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        button3.Hide();
                        button3.Enabled = false;
                        imagebox.BackgroundImage = Properties.Resources.page_10;
                        SoundPlayer gameoversound = new SoundPlayer(Properties.Resources.game_over);
                        gameoversound.Play();
                        page = 99;
                    }
                    break;

                case 11:
                    {
                        topLabel.Text = "Actually, the room you wanted to go in to is the meeting room.";
                        button1.Hide();
                        button1.Enabled = false;
                        button2.Hide();
                        button2.Enabled = false;
                        askLabel.Text = "Eavsdrop their conversation?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        imagebox.BackgroundImage = Properties.Resources.page_11;
                    }
                    break;

                case 12:
                    {
                        topLabel.Text = "You heard they said SUSHI is the secret word.";
                        secretLabel.Text = "Secret word: SUSHI";
                        askLabel.Text = "";
                        button1.Hide();
                        button1.Enabled = false;
                        button2.Hide();
                        button2.Enabled = false;
                        secretwordLabel.Visible = true;
                        secret_word_pic.Visible = true;
                        Refresh();
                        Thread.Sleep(6000);
                        topLabel.Text = "You found the new window";
                        askLabel.Text = "Go in to the castle from the window?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        imagebox.BackgroundImage = Properties.Resources.page_8_2_;
                    }
                    break;

                case 13:
                    {
                        topLabel.Text = "You found the new window";
                        askLabel.Text = "Go in to the castle from the window?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        imagebox.BackgroundImage = Properties.Resources.page_8_2_;
                    }
                    break;

                case 14:
                    {
                        topLabel.Text = "【MISSION FAILED】   You are realized by the watchman in outside";
                        askLabel.Text = "Play again?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        button3.Hide();
                        button3.Enabled = false;
                        page = 99;
                        imagebox.BackgroundImage = Properties.Resources.page_2;
                        SoundPlayer gameoversound = new SoundPlayer(Properties.Resources.game_over);
                        gameoversound.Play();
                    }
                    break;

                case 15:
                    {
                        topLabel.Text = "You succeeded to intrusion, but you see the soldier coming";
                        askLabel.Text = "What do you do?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Kill the soldier";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "Hide";
                        imagebox.BackgroundImage = Properties.Resources.page_15;
                    }
                    break;

                case 16:
                    {
                        topLabel.Text = "";
                        askLabel.Text = "Use the NINJA STAR ?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        imagebox.BackgroundImage = Properties.Resources.page_16;
                    }
                    break;

                case 17:
                    {
                        ninjastar = 0;
                        ninja_star_Button.Visible = false;
                        ninja_star_Button.Enabled = false;
                        itemLabel.Text = "";
                        item_picBox.BackgroundImage = null;
                        topLabel.Text = "You killed the soldier.";
                        topLabel.Text += "\nYou hide the cadaver";
                        askLabel.Text = "Change to the soldier clothes?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        button3.Hide();
                        button3.Enabled = false;
                        imagebox.BackgroundImage = Properties.Resources.page_17;
                    }
                    break;

                case 18:
                    {
                        topLabel.Text = "【MISSION FAILED】   You are killed by the soldier.";
                        askLabel.Text = "Play again?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        button3.Hide();
                        button3.Enabled = false;
                        imagebox.BackgroundImage = Properties.Resources.page_2;
                        SoundPlayer gameoversound = new SoundPlayer(Properties.Resources.game_over);
                        gameoversound.Play();
                        page = 99;
                    }
                    break;

                case 19:
                    {
                        topLabel.Text = "You panched and succeeded to kill the soldier";
                        topLabel.Text += "\nYou hide the cadaver";
                        askLabel.Text = "";
                        button1.Hide();
                        button1.Enabled = false;
                        button2.Hide();
                        button2.Enabled = false;
                        askLabel.Text = "Change to the soldier clothes?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        button3.Hide();
                        button3.Enabled = false;
                        imagebox.BackgroundImage = Properties.Resources.page_17;
                    }
                    break;

                case 20:
                    {
                        askLabel.Text = "Use the cape?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        imagebox.BackgroundImage = Properties.Resources.page_9;
                    }
                    break;

                case 21:
                    {
                        cape = 0;
                        cape_Button.Visible = false;
                        cape_Button.Enabled = false;
                        topLabel.Text = "The soldier came up to you unnoticed.";
                        askLabel.Text = "Kill him?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        imagebox.BackgroundImage = Properties.Resources.page_20;
                    }
                    break;

                case 22:
                    {
                        topLabel.Text = "【MISSION FAILED】   A soldier realized you.";
                        topLabel.Text += "\n\nHint: When you use the CAPE?";
                        askLabel.Text = "Play again?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        button3.Hide();
                        button3.Enabled = false;
                        page = 99;
                        imagebox.BackgroundImage = Properties.Resources.page_10;
                        SoundPlayer gameoversound = new SoundPlayer(Properties.Resources.game_over);
                        gameoversound.Play();
                    }
                    break;

                case 23:
                    {
                        topLabel.Text = "You took the soldier by surprise.";
                        topLabel.Text += "You succeeded to kill him.";
                        topLabel.Text += "You hide the cadaver";
                        askLabel.Text = "Change to the soldier clothes?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        button3.Hide();
                        button3.Enabled = false;
                        imagebox.BackgroundImage = Properties.Resources.page_17;
                    }
                    break;

                case 24:
                    {
                        topLabel.Text = "【MISSION FAILED】   The new soldier came and realized you";
                        askLabel.Text = "Play again?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        button3.Hide();
                        button3.Enabled = false;
                        page = 99;
                        imagebox.BackgroundImage = Properties.Resources.page_10;
                        SoundPlayer gameoversound = new SoundPlayer(Properties.Resources.game_over);
                        gameoversound.Play();
                    }
                    break;

                case 25:
                    {
                        topLabel.Text = "The new soldier passed you,\nbut he didn't realized you are disguising.";
                        topLabel.Text += "\nYou walk in to the main castle.";
                        askLabel.Text = "";
                        button1.Hide();
                        button1.Enabled = false;
                        button2.Hide();
                        button2.Enabled = false;
                        imagebox.BackgroundImage = Properties.Resources.page_25_1_;
                        Refresh();
                        Thread.Sleep(7000);
                        topLabel.Text = "When you arrived the main castle, the gate keeper said ";
                        topLabel.Text += "You have to say the SECRED WORD when you go in to the main castle.";
                        askLabel.Text = "Answer the SECRET WORD";
                        answertext.Visible = true;
                        enterButton.Visible = true;
                        enterButton.Enabled = true;
                        imagebox.BackgroundImage = Properties.Resources.page_25_2_;
                    }
                    break;

                case 26:
                    {
                        topLabel.Text = "【MISSION FAILED】You missed the SECRET WORD.";
                        topLabel.Text += "\nThe gate keeper realized you are a ninja";
                        askLabel.Text = "Play again?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        button3.Hide();
                        button3.Enabled = false;
                        page = 99;
                        imagebox.BackgroundImage = Properties.Resources.page_2;
                        SoundPlayer gameoversound = new SoundPlayer(Properties.Resources.game_over);
                        gameoversound.Play();
                    }
                    break;

                case 27:
                    {
                        topLabel.Text = "The gate keeper allow you to enter.";
                        topLabel.Text += "You enter to the main castle";
                        askLabel.Text = "What do you do?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Go to the\nBoss Room";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "Walk around";
                        imagebox.BackgroundImage = Properties.Resources.page_27;
                    }
                    break;

                case 28:
                    {
                        topLabel.Text = "You enter to the boss room.";
                        topLabel.Text += "\nThere are few body guards around the enemy's boss.";
                        askLabel.Text = "Kill the boss?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        imagebox.BackgroundImage = Properties.Resources.page_28;
                    }
                    break;

                case 29:
                    {
                        topLabel.Text = "【MISSION FAILED】   You killed a body guard,but the other realized and killed you";
                        askLabel.Text = "Play again?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        button3.Hide();
                        button3.Enabled = false;
                        page = 99;
                        imagebox.BackgroundImage = Properties.Resources.page_10;
                        SoundPlayer gameoversound = new SoundPlayer(Properties.Resources.game_over);
                        gameoversound.Play();
                    }
                    break;

                case 30:
                    {
                        topLabel.Text = "You get out from the boss room";
                        askLabel.Text = "";
                        imagebox.BackgroundImage = Properties.Resources.page_27;
                        button1.Hide();
                        button1.Enabled = false;
                        button2.Hide();
                        button2.Enabled = false;
                        Refresh();
                        Thread.Sleep(2000);
                        askLabel.Text = "What do you do?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Go to the\nBoss room";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "Walk around";
                        page = 27;
                    }
                    break;

                case 31:
                    {
                        topLabel.Text = "You see the doctor going to the boss room.";
                        askLabel.Text = "Kill the doctor?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        imagebox.BackgroundImage = Properties.Resources.page_31;
                    }
                    break;

                case 32:
                    {
                        topLabel.Text = "【MISSION FAILED】   You missd the chance";
                        askLabel.Text = "Play again?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        button3.Hide();
                        button3.Enabled = false;
                        imagebox.BackgroundImage = Properties.Resources.page_10;
                        SoundPlayer gameoversound = new SoundPlayer(Properties.Resources.game_over);
                        gameoversound.Play();
                        page = 99;
                    }
                    break;

                case 33:
                    {
                        askLabel.Text = "Use the NINJA STAR?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        imagebox.BackgroundImage = Properties.Resources.page_16;
                    }
                    break;

                case 34:
                    {
                        topLabel.Text = "【MISSION FAILED】You punched the doctor and killed him,";
                        topLabel.Text += "\nbut you made a big sound.";
                        topLabel.Text += "\nThe gurads heard the sound and killed you";
                        if (ninjastar == 0)
                        {
                            topLabel.Text += "\n\nHint: Where do you use the NINJA STAR?";
                        }
                        askLabel.Text = "Play again?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        button3.Hide();
                        button3.Enabled = false;
                        page = 99;
                        imagebox.BackgroundImage = Properties.Resources.page_10;
                        SoundPlayer gameoversound = new SoundPlayer(Properties.Resources.game_over);
                        gameoversound.Play();
                    }
                    break;

                case 35:
                    {
                        ninjastar = 0;
                        ninja_star_Button.Visible = false;
                        ninja_star_Button.Enabled = false;
                        topLabel.Text = "You succeeded to kill the doctor.";
                        topLabel.Text += "\nYou change to the doctor clothes and enter to the boss room.";
                        topLabel.Text += "\nYou injected the boss with a poison that didn't cause immediate symptoms.";
                        topLabel.Text += "\nThen, you escaped from the castle.";
                        imagebox.BackgroundImage = Properties.Resources.page_35;
                        askLabel.Text = "";
                        button1.Hide();
                        button1.Enabled = false;
                        button2.Hide();
                        button2.Enabled = false;
                        Refresh();
                        Thread.Sleep(12000);
                        topLabel.Text = "【MISSION COMPLETE】   Thank you for playing!!";
                        askLabel.Text = "Play again?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                    }
                    break;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            menupic.Visible = false;
            startButton.Visible = false;
            startButton.Enabled = false;
        }

        public Form1()
        {
            page = 1;
            InitializeComponent();
            topLabel.Text = "You are the NINJA\n\n【MISSION】   Assasinate the enemy's boss!";
            askLabel.Text = "Select the way you want to go.";
            button1.Show();
            button1.Text = "Go to main gate";
            button2.Show();
            button2.Text = "Look around";
            button3.Show();
            button3.Text = "Dive to the\nwater moats";
            imagebox.BackgroundImage = Properties.Resources.page_1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ///
            if (page == 1)
            {
                page = 2;
            }

            else if (page == 4)
            {
                page = 5;
            }

            else if (page == 7)
            {
                page = 9;
            }

            else if (page == 8 || page == 9) 
            {
                page = 10;
            }

            else if (page == 11)
            {
                page = 12;
            }

            else if (page == 12 || page == 13)
            {
                page = 15;
            }

            else if (page == 15)
            {
                page = 16;
            }

            else if (page == 16)
            {
                page = 17;
            }

            else if (page == 20)
            {
                page = 21;
            }

            else if (page == 21)
            {
                page = 23;
            }

            else if (page == 17 || page == 19 || page == 23)
            {
                page = 25;
            }

            else if (page == 27)
            {
                page = 28;
            }

            else if (page == 28)
            {
                page = 29;
            }

            else if (page == 31)
            {
                if (ninjastar == 1)
                {
                    page = 33;
                }

                else if (ninjastar == 0)
                {
                    page = 34;
                }
            }

            else if (page == 33)
            {
                page = 35;
            }

            else if (page == 98)
            {
                page = 28;
            }

            else if (page == 99)
            {
                cape = 1;
                cape_Button.Visible = true;
                cape_Button.Enabled = true;
                ninjastar = 1;
                ninja_star_Button.Visible = true;
                ninja_star_Button.Enabled = true;
                bamboo = 0;
                bamboo_Button.Hide();
                bamboo_Button.Enabled = false;
                itemLabel.Text = "";
                item_picBox.BackgroundImage = null;
                secretwordLabel.Hide();
                secret_word_pic.Hide();
                page = 1;
            }


            ///
            switch (page)
            {
                case 1:
                    {
                        topLabel.Text = "You are the NINJA\n\n【MISSION】   Assasinate the enemy's boss!";
                        askLabel.Text = "Select the way you want to go.";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Go to main gate";
                        button2.Show();
                        button1.Enabled = true;
                        button2.Text = "Look around";
                        button3.Show();
                        button3.Enabled = true;
                        button3.Text = "Dive to the\nwater moats";
                        imagebox.BackgroundImage = Properties.Resources.page_1;
                    }
                    break;

                case 2:
                    {
                        topLabel.Text = "【MISSON FAILED】   The gate keeper found you.";
                        askLabel.Text = "Play again?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        button3.Hide();
                        button3.Enabled = false;
                        page = 99;
                        imagebox.BackgroundImage = Properties.Resources.page_2;
                        SoundPlayer gameoversound = new SoundPlayer(Properties.Resources.game_over);
                        gameoversound.Play();
                    }
                    break;

                case 3:
                    {
                        if (bamboo == 0)
                        {
                            topLabel.Text = "You get the BAMBOO";
                            askLabel.Text = "";
                            bamboo = 1;
                            bamboo_Button.Visible = true;
                            bamboo_Button.Enabled = true;
                            button1.Hide();
                            button1.Enabled = false;
                            button2.Hide();
                            button2.Enabled = false;
                            button3.Hide();
                            button3.Enabled = false;
                            imagebox.BackgroundImage = Properties.Resources.page_3;
                        }

                        else if (bamboo == 1)
                        {
                            topLabel.Text = "You already got the item.";
                            askLabel.Text = "";
                            button1.Hide();
                            button1.Enabled = false;
                            button2.Hide();
                            button2.Enabled = false;
                            button3.Hide();
                            button3.Enabled = false;
                            imagebox.BackgroundImage = Properties.Resources.page_3;
                        }
                        Refresh();
                        Thread.Sleep(2000);
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Go to main gate";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "Look around";
                        button3.Show();
                        button3.Enabled = true;
                        button3.Text = "Dive to the\nwater moats";
                        askLabel.Text = "Select the way you want to go.";
                        topLabel.Text = "You are the NINJA\n\n【MISSION】   Assasinate the enemy's boss!";
                        imagebox.BackgroundImage = Properties.Resources.page_1;
                        page = 1;
                    }
                    break;

                case 4:
                    {
                        topLabel.Text = "No one noticed";
                        askLabel.Text = "How to across the moats?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Swim";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "Run on the water";
                        button3.Hide();
                        button3.Enabled = false;

                        if (bamboo == 1)
                        {
                            button3.Show();
                            button3.Enabled = true;
                            button3.Text = "Use the bamboo";
                        }
                        imagebox.BackgroundImage = Properties.Resources.page_4;
                    }
                    break;

                case 5:
                    {
                        topLabel.Text = "【MISSON FAILED】   A watchman realized your bubbling. ";
                        if (bamboo == 0)
                        {
                            topLabel.Text += "\n\nHint: Try to search the item";
                        }
                        askLabel.Text = "Play again?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        button3.Hide();
                        button3.Enabled = false;
                        imagebox.BackgroundImage = Properties.Resources.page_2;
                        SoundPlayer gameoversound = new SoundPlayer(Properties.Resources.game_over);
                        gameoversound.Play();
                        page = 99;
                    }
                    break;

                case 6:
                    {
                        topLabel.Text = "【MISSON FAILED】   People can't run on the water lol.";
                        topLabel.Text += "\n\nHint: Try to search the item";
                        askLabel.Text = "Play again?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        button3.Hide();
                        button3.Enabled = false;
                        imagebox.BackgroundImage = Properties.Resources.page_6;
                        SoundPlayer gameoversound = new SoundPlayer(Properties.Resources.game_over);
                        gameoversound.Play();
                        page = 99;
                    }
                    break;

                case 7:
                    {
                        bamboo = 0;
                        bamboo_Button.Visible = false;
                        bamboo_Button.Enabled = false;
                        itemLabel.Text = "";
                        item_picBox.BackgroundImage = null;
                        topLabel.Text = "No one noticed.";
                        topLabel.Text += "\nYou used the bamboo and acrossed the moats";
                        askLabel.Text = "";
                        button1.Hide();
                        button1.Enabled = false;
                        button2.Hide();
                        button2.Enabled = false;
                        button3.Hide();
                        button3.Enabled = false;
                        imagebox.BackgroundImage = Properties.Resources.page_7_1_;
                        Refresh();
                        Thread.Sleep(6000);
                        topLabel.Text = "You are climbing the castle wall.\nYou feel someone watching you";
                        askLabel.Text = "Use the CAPE to hide?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        imagebox.BackgroundImage = Properties.Resources.page_7_2_;
                    }
                    break;

                case 8:
                    {
                        topLabel.Text = "Just the frog watching you.";
                        askLabel.Text = "";
                        button1.Hide();
                        button1.Enabled = false;
                        button2.Hide();
                        button2.Enabled = false;
                        imagebox.BackgroundImage = Properties.Resources.page_8_1_;
                        Refresh();
                        Thread.Sleep(3000);
                        topLabel.Text = "You found the window";
                        askLabel.Text = "Go in to the castle from the window?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        imagebox.BackgroundImage = Properties.Resources.page_8_2_;
                    }
                    break;

                case 9:
                    {
                        cape = 0;
                        cape_Button.Visible = false;
                        cape_Button.Enabled = false;
                        itemLabel.Text = "";
                        item_picBox.BackgroundImage = null;
                        topLabel.Text = "You used the cape and make it through.";
                        askLabel.Text = "";
                        button1.Hide();
                        button1.Enabled = false;
                        button2.Hide();
                        button2.Enabled = false;
                        imagebox.BackgroundImage = Properties.Resources.page_9;
                        Refresh();
                        Thread.Sleep(5000);
                        topLabel.Text = "You found the window";
                        askLabel.Text = "Go in to the castle from the window?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        imagebox.BackgroundImage = Properties.Resources.page_8_2_;
                    }
                    break;

                case 10:
                    {
                        topLabel.Text = "【MISSION FAILED】The room you go in to is the meeting room.";
                        topLabel.Text += "\nEvery soldier realized you and you were killed";
                        askLabel.Text = "Play again?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        button3.Hide();
                        button3.Enabled = false;
                        imagebox.BackgroundImage = Properties.Resources.page_10;
                        SoundPlayer gameoversound = new SoundPlayer(Properties.Resources.game_over);
                        gameoversound.Play();
                        page = 99;
                    }
                    break;

                case 11:
                    {
                        topLabel.Text = "Actually, the room you wanted to go in to is the meeting room.";
                        button1.Hide();
                        button1.Enabled = false;
                        button2.Hide();
                        button2.Enabled = false;
                        askLabel.Text = "Eavsdrop their conversation?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        imagebox.BackgroundImage = Properties.Resources.page_11;
                    }
                    break;

                case 12:
                    {
                        topLabel.Text = "You heard they said SUSHI is the secret word.";
                        secretLabel.Text = "Secret word: SUSHI";
                        askLabel.Text = "";
                        button1.Hide();
                        button1.Enabled = false;
                        button2.Hide();
                        button2.Enabled = false;
                        secretwordLabel.Visible = true;
                        secret_word_pic.Visible = true;
                        Refresh();
                        Thread.Sleep(6000);
                        topLabel.Text = "You found the new window";
                        askLabel.Text = "Go in to the castle from the window?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        imagebox.BackgroundImage = Properties.Resources.page_8_2_;
                    }
                    break;

                case 13:
                    {
                        topLabel.Text = "You found the new window";
                        askLabel.Text = "Go in to the castle from the window?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        imagebox.BackgroundImage = Properties.Resources.page_8_2_;
                    }
                    break;

                case 14:
                    {
                        topLabel.Text = "【MISSION FAILED】   You are realized by the watchman in outside";
                        askLabel.Text = "Play again?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        button3.Hide();
                        button3.Enabled = false;
                        page = 99;
                        imagebox.BackgroundImage = Properties.Resources.page_2;
                        SoundPlayer gameoversound = new SoundPlayer(Properties.Resources.game_over);
                        gameoversound.Play();
                    }
                    break;

                case 15:
                    {
                        topLabel.Text = "You succeeded to intrusion, but you see the soldier coming";
                        askLabel.Text = "What do you do?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Kill the soldier";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "Hide";
                        imagebox.BackgroundImage = Properties.Resources.page_15;
                    }
                    break;

                case 16:
                    {
                        topLabel.Text = "";
                        askLabel.Text = "Use the NINJA STAR ?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        imagebox.BackgroundImage = Properties.Resources.page_16;
                    }
                    break;

                case 17:
                    {
                        ninjastar = 0;
                        ninja_star_Button.Visible = false;
                        ninja_star_Button.Enabled = false;
                        itemLabel.Text = "";
                        item_picBox.BackgroundImage = null;
                        topLabel.Text = "You killed the soldier.";
                        topLabel.Text += "\nYou hide the cadaver";
                        askLabel.Text = "Change to the soldier clothes?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        button3.Hide();
                        button3.Enabled = false;
                        imagebox.BackgroundImage = Properties.Resources.page_17;
                    }
                    break;

                case 18:
                    {
                        topLabel.Text = "【MISSION FAILED】   You are killed by the soldier.";
                        askLabel.Text = "Play again?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        button3.Hide();
                        button3.Enabled = false;
                        imagebox.BackgroundImage = Properties.Resources.page_2;
                        SoundPlayer gameoversound = new SoundPlayer(Properties.Resources.game_over);
                        gameoversound.Play();
                        page = 99;
                    }
                    break;

                case 19:
                    {
                        topLabel.Text = "You panched and succeeded to kill the soldier";
                        topLabel.Text += "\nYou hide the cadaver";
                        askLabel.Text = "";
                        button1.Hide();
                        button1.Enabled = false;
                        button2.Hide();
                        button2.Enabled = false;
                        askLabel.Text = "Change to the soldier clothes?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        button3.Hide();
                        button3.Enabled = false;
                        imagebox.BackgroundImage = Properties.Resources.page_17;
                    }
                    break;

                case 20:
                    {
                        askLabel.Text = "Use the cape?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        imagebox.BackgroundImage = Properties.Resources.page_9;
                    }
                    break;

                case 21:
                    {
                        cape = 0;
                        cape_Button.Visible = false;
                        cape_Button.Enabled = false;
                        topLabel.Text = "The soldier came up to you unnoticed.";
                        askLabel.Text = "Kill him?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        imagebox.BackgroundImage = Properties.Resources.page_20;
                    }
                    break;

                case 22:
                    {
                        topLabel.Text = "【MISSION FAILED】   A soldier realized you.";
                        topLabel.Text += "\n\nHint: When you use the CAPE?";
                        askLabel.Text = "Play again?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        button3.Hide();
                        button3.Enabled = false;
                        page = 99;
                        imagebox.BackgroundImage = Properties.Resources.page_10;
                        SoundPlayer gameoversound = new SoundPlayer(Properties.Resources.game_over);
                        gameoversound.Play();
                    }
                    break;

                case 23:
                    {
                        topLabel.Text = "You took the soldier by surprise.";
                        topLabel.Text += "You succeeded to kill him.";
                        topLabel.Text += "You hide the cadaver";
                        askLabel.Text = "Change to the soldier clothes?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        button3.Hide();
                        button3.Enabled = false;
                        imagebox.BackgroundImage = Properties.Resources.page_17;
                    }
                    break;

                case 24:
                    {
                        topLabel.Text = "【MISSION FAILED】   The new soldier came and realized you";
                        askLabel.Text = "Play again?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        button3.Hide();
                        button3.Enabled = false;
                        page = 99;
                        imagebox.BackgroundImage = Properties.Resources.page_10;
                        SoundPlayer gameoversound = new SoundPlayer(Properties.Resources.game_over);
                        gameoversound.Play();
                    }
                    break;

                case 25:
                    {
                        topLabel.Text = "The new soldier passed you,\nbut he didn't realized you are disguising.";
                        topLabel.Text += "\nYou walk in to the main castle.";
                        askLabel.Text = "";
                        button1.Hide();
                        button1.Enabled = false;
                        button2.Hide();
                        button2.Enabled = false;
                        imagebox.BackgroundImage = Properties.Resources.page_25_1_;
                        Refresh();
                        Thread.Sleep(7000);
                        topLabel.Text = "When you arrived the main castle, the gate keeper said ";
                        topLabel.Text += "You have to say the SECRED WORD when you go in to the main castle.";
                        askLabel.Text = "Answer the SECRET WORD";
                        answertext.Visible = true;
                        enterButton.Visible = true;
                        enterButton.Enabled = true;
                        imagebox.BackgroundImage = Properties.Resources.page_25_2_;
                    }
                    break;

                case 26:
                    {
                        topLabel.Text = "【MISSION FAILED】You missed the SECRET WORD.";
                        topLabel.Text += "\nThe gate keeper realized you are a ninja";
                        askLabel.Text = "Play again?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        button3.Hide();
                        button3.Enabled = false;
                        page = 99;
                        imagebox.BackgroundImage = Properties.Resources.page_2;
                        SoundPlayer gameoversound = new SoundPlayer(Properties.Resources.game_over);
                        gameoversound.Play();
                    }
                    break;

                case 27:
                    {
                        topLabel.Text = "The gate keeper allow you to enter.";
                        topLabel.Text += "You enter to the main castle";
                        askLabel.Text = "What do you do?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Go to the\nBoss Room";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "Walk around";
                        imagebox.BackgroundImage = Properties.Resources.page_27;
                    }
                    break;

                case 28:
                    {
                        topLabel.Text = "You enter to the boss room.";
                        topLabel.Text += "\nThere are few body guards around the enemy's boss.";
                        askLabel.Text = "Kill the boss?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        imagebox.BackgroundImage = Properties.Resources.page_28;
                    }
                    break;

                case 29:
                    {
                        topLabel.Text = "【MISSION FAILED】   You killed a body guard,but the other realized and killed you";
                        askLabel.Text = "Play again?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        button3.Hide();
                        button3.Enabled = false;
                        page = 99;
                        imagebox.BackgroundImage = Properties.Resources.page_10;
                        SoundPlayer gameoversound = new SoundPlayer(Properties.Resources.game_over);
                        gameoversound.Play();
                    }
                    break;

                case 30:
                    {
                        topLabel.Text = "You get out from the boss room";
                        askLabel.Text = "";
                        imagebox.BackgroundImage = Properties.Resources.page_27;
                        button1.Hide();
                        button1.Enabled = false;
                        button2.Hide();
                        button2.Enabled = false;
                        Refresh();
                        Thread.Sleep(2000);
                        askLabel.Text = "What do you do?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Go to the\nBoss room";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "Walk around";
                        page = 27;
                    }
                    break;

                case 31:
                    {
                        topLabel.Text = "You see the doctor going to the boss room.";
                        askLabel.Text = "Kill the doctor?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        imagebox.BackgroundImage = Properties.Resources.page_31;
                    }
                    break;

                case 32:
                    {
                        topLabel.Text = "【MISSION FAILED】   You missd the chance";
                        askLabel.Text = "Play again?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        button3.Hide();
                        button3.Enabled = false;
                        imagebox.BackgroundImage = Properties.Resources.page_10;
                        SoundPlayer gameoversound = new SoundPlayer(Properties.Resources.game_over);
                        gameoversound.Play();
                        page = 99;
                    }
                    break;

                case 33:
                    {
                        askLabel.Text = "Use the NINJA STAR?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        imagebox.BackgroundImage = Properties.Resources.page_16;
                    }
                    break;

                case 34:
                    {
                        topLabel.Text = "【MISSION FAILED】You punched the doctor and killed him,";
                        topLabel.Text += "\nbut you made a big sound.";
                        topLabel.Text += "\nThe gurads heard the sound and killed you";
                        if (ninjastar == 0)
                        {
                            topLabel.Text += "\n\nHint: Where do you use the NINJA STAR?";
                        }
                        askLabel.Text = "Play again?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                        button3.Hide();
                        button3.Enabled = false;
                        page = 99;
                        imagebox.BackgroundImage = Properties.Resources.page_10;
                        SoundPlayer gameoversound = new SoundPlayer(Properties.Resources.game_over);
                        gameoversound.Play();
                    }
                    break;

                case 35:
                    {
                        ninjastar = 0;
                        ninja_star_Button.Visible = false;
                        ninja_star_Button.Enabled = false;
                        topLabel.Text = "You succeeded to kill the doctor.";
                        topLabel.Text += "\nYou change to the doctor clothes and enter to the boss room.";
                        topLabel.Text += "\nYou injected the boss with a poison that didn't cause immediate symptoms.";
                        topLabel.Text += "\nThen, you escaped from the castle.";
                        imagebox.BackgroundImage = Properties.Resources.page_35;
                        askLabel.Text = "";
                        button1.Hide();
                        button1.Enabled = false;
                        button2.Hide();
                        button2.Enabled = false;
                        Refresh();
                        Thread.Sleep(12000);
                        topLabel.Text = "【MISSION COMPLETE】   Thank you for playing!!";
                        askLabel.Text = "Play again?";
                        button1.Show();
                        button1.Enabled = true;
                        button1.Text = "Yes";
                        button2.Show();
                        button2.Enabled = true;
                        button2.Text = "No";
                    }
                    break;
            }
        }
    }
}
