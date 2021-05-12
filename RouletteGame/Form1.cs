using RouletteGame.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RouletteGame
{
    public partial class Form1 : Form
    {
        int total, win, lose;
        string caption;
        Logic logic;
        SoundPlayer soundPlayer;
        int position;

        public Form1()
        {
            InitializeComponent();
            caption = "Roussian Roulette Tournament";
            soundPlayer = new SoundPlayer();
            ResetGameControls();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            logic = new Logic();
            position = 1;
            MessageBox.Show("Now, Game Begins!!!", caption);
            buttonLoad.Enabled = true;
            buttonPlay.Enabled = false;
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            logic.Load();
            pictureGame.Image = Resources.Load;
            buttonLoad.Enabled = false;
            buttonSpin.Enabled = true;
            MessageBox.Show("Bullet is Loaded!!!", caption);
        }

        private void buttonSpin_Click(object sender, EventArgs e)
        {
            logic.Spin();
            pictureGame.Image = Resources.Spin1;
            buttonSpin.Enabled = false;
            buttonFire.Enabled = true;
            soundPlayer.Stream = Resources.spin;
            soundPlayer.Play();
            MessageBox.Show("Now, Revolver Chamber is Spinning",caption);
            pictureGame.Image = Resources.Cover;
        }

        private void buttonFire_Click(object sender, EventArgs e)
        {
            if (logic.Fire(position))
            {
                pictureGame.Image = Properties.Resources.HeadShot;
                soundPlayer.Stream = Resources.shot;
                soundPlayer.Play();
                lose++;
                total++;
                MessageBox.Show("You Lost This Game!!!",caption);
                ResetGameControls();
            }
            else
            {
                soundPlayer.Stream = Resources.empty;
                soundPlayer.Play();
                position++;
                MessageBox.Show("Hey, You Near To Win The Game!!!",caption);
            }
            if (position == 4)
            {
                win++;
                total++;
                MessageBox.Show("You Won this Game!!!",caption);
                ResetGameControls();
            }
        }

        private void ResetGameControls()
        {
            buttonPlay.Enabled = true;
            buttonLoad.Enabled = false;
            buttonFire.Enabled = false;
            buttonSpin.Enabled = false;
            labelStat.Text = "TOTAL GAME: " + total + " WIN: " + win + " LOSE: " + lose;
            pictureGame.Image = Resources.Cover;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string message = "";
            if(win > lose)
            {
                message = "You Walk as a Winner!!!";
            }
            else if( win < lose )
            {
                message = "You Walk as a Loser!!!";
            }
            else
            {
                message = "There is Tie!!! No Hard Feelings!!!";
            }
            MessageBox.Show(message, caption);
        }
    }
}
