using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RussianRouletteGun
{
    public partial class Form1 : Form
    {
        public System.Media.SoundPlayer player;
        public Form1()
        {
            InitializeComponent();
            ArrayList chamber = new ArrayList();
            player = new System.Media.SoundPlayer();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void loadGun(ArrayList chamber)
        {
            chamber.Add(0);
            chamber.Add(0);
            chamber.Add(0);
            chamber.Add(0);
            chamber.Add(0);
            chamber.Add(1);

        }

        private void spinRevolver(ArrayList chamber)
        {
            Random random = new Random();

            for (int i = 0;i< chamber.Count;i++)
            {
                object temp = chamber[i];
                int r = random.Next(chamber.Count - i)+i;
                chamber[i] = chamber[r];
                chamber[r] = temp;
            }
        }

        private void loadSound(String sound)
        {
            switch (sound)
            {
                case "fire":
                    player.SoundLocation = "src\fire.wav";
                    player.Play();
                    break;

                case "shuffle":
                    player.SoundLocation = "src\shuffle.wav";
                    player.Play();
                    break;
                case "miss":
                    //player.Play();
                    break;
                default:
                    break;
            }
        }
    }
}
