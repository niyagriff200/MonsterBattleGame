using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;


namespace MonsterBattleGame
{
    public partial class frmGameplay : Form
    {
        // Reference to the main menu form so we can return to it
        private frmMainMenu frmOriginal;

        // Random number generator used for choosing monster positions
        private Random rand = new Random();

        // List that stores all active monster PictureBoxes currently in the panel
        private List<PictureBox> listMonsters = new List<PictureBox>();

        // Array for monster starting row(s)
        // may expand later
        private int[] rows = {50};

        // Array of possible X positions (columns) where monsters can spawn.
        // Monsters will randomly choose one of these lanes.
        private int[] cols = { 100, 300, 500, 700, 900, 1100};

        // Player's health points. When monsters reach the bottom, this decreases.
        private int playerHP = 50;

        // Default monster health, Stored in the PictureBox.Tag
        private int monsterHP = 100;

        // Tracks whether it is the player's turn (used later for turn-based logic)
        private bool playerTurn = false;

        // Stores which attack mode the player has chosen ("single", "row", "column")
        private string attackMode = "";

        // Stores the monster the player clicked on when selecting a target
        private PictureBox selectedMonster = null;

        public frmGameplay()
        {
            InitializeComponent();
        }

        public frmGameplay(frmMainMenu frmMainMenuObj)
        {
            InitializeComponent();
            frmOriginal = frmMainMenuObj;
            Test();
        }

        private async void Test() //TODO: DON'T FORGET TO DELETE LATER
        {
            SpawnMonsters();
            await Task.Delay(5000); // waits 5 second
            MoveMonsters();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmOriginal.Show();
            this.Close();
        }

        private void frmGameplay_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmOriginal.Show();
        }

        public void SpawnMonsters()
        {
            // Only spawn a monster if fewer than 6 are currently active
            if (listMonsters.Count < 6)
            {
                // Create a new monster as a PictureBox
                PictureBox monster = new PictureBox();

                // Assign the monster image and make sure it scales correctly
                monster.Image = Properties.Resources.pixelcreatures_alien_671296_640;
                monster.SizeMode = PictureBoxSizeMode.StretchImage;

                // Set the monster's size (100x100 pixels)
                monster.Size = new Size(100, 100);

                // Store the monster's HP inside the Tag property
                monster.Tag = monsterHP;

                // Set the monster's starting vertical position (Y)
                // Using rows[0] makes this easy to change later
                monster.Top = rows[0];

                // Choose a random column (X position) from the cols array
                int startCol = cols[rand.Next(cols.Length)];
                monster.Left = startCol;

                // Allow the monster to be clicked for attack selection
                monster.Click += Monster_Click;

                // Add the monster to the gameplay panel and to the list
                pnlGameArea.Controls.Add(monster);
                listMonsters.Add(monster);
            }
        }

        public void MoveMonsters()
        {
            // Loop backwards so we can safely remove monsters during iteration
            for (int i = listMonsters.Count - 1; i >= 0; i--)
            {
                PictureBox m = listMonsters[i];

                // Move the monster downward by 100 pixels
                m.Top += 100;

                // Check if the monster has reached the bottom of the panel
                if (m.Top >= pnlGameArea.Height - m.Height)
                {
                    // Monster reached the player area → player takes damage
                    playerHP -= 50;

                    // TODO: Update player HP label here

                    // Remove the monster from the panel and the list
                    pnlGameArea.Controls.Remove(m);
                    listMonsters.Remove(m);
                }
            }
        }

        private void Monster_Click(object sender, EventArgs e)
        {
            // Only allow selection if an attack mode is active
            if (attackMode != "")
            {
                PictureBox clicked = sender as PictureBox;

                // Reset all monsters to the "can be selected" color
                foreach (PictureBox m in listMonsters)
                {
                    m.BackColor = Color.Red;
                }

                // Highlight the monster the player clicked on
                clicked.BackColor = Color.Green;

                // Store this monster as the selected target
                selectedMonster = clicked;
            }
        }

        public void AttackSingle()
        {
            // Only attack if a monster has been selected
            if (selectedMonster != null)
            {
                // Get the monster's current HP from the Tag
                int hp = (int)selectedMonster.Tag;

                // Apply damage
                hp -= 50;

                // Store updated HP back into the Tag
                selectedMonster.Tag = hp;

                // If HP is zero or below, remove the monster
                if (hp <= 0)
                {
                    pnlGameArea.Controls.Remove(selectedMonster);
                    listMonsters.Remove(selectedMonster);
                }
            }
        }

        public void AttackRow()
        {
            // Only attack if a monster has been selected
            if (selectedMonster != null)
            {
                // Determine the row (Y position) of the selected monster
                int targetRow = selectedMonster.Top;

                // Height of one row. Since monsters are 100px tall,
                // this means "hit everything in the same horizontal band."
                int rowHeight = 100;

                // Loop backwards so we can remove monsters safely
                for (int i = listMonsters.Count - 1; i >= 0; i--)
                {
                    PictureBox m = listMonsters[i];

                    // Check if this monster is in the same row band
                    if (m.Top >= targetRow && m.Top < targetRow + rowHeight)
                    {
                        int hp = (int)m.Tag;
                        hp -= 25; // row attack deals less damage
                        m.Tag = hp;

                        if (hp <= 0)
                        {
                            pnlGameArea.Controls.Remove(m);
                            listMonsters.Remove(m);
                        }
                    }
                }
            }
        }

        public void AttackColumn()
        {
            // Only attack if a monster has been selected
            if (selectedMonster != null)
            {
                // Determine the column (X position) of the selected monster
                int targetCol = selectedMonster.Left;

                // Width of one column. Monsters are 100px wide,
                // so this hits everything in the same vertical lane.
                int colWidth = 100;

                // Loop backwards so we can remove monsters safely
                for (int i = listMonsters.Count - 1; i >= 0; i--)
                {
                    PictureBox m = listMonsters[i];

                    // Check if this monster is in the same column band
                    if (m.Left >= targetCol && m.Left < targetCol + colWidth)
                    {
                        int hp = (int)m.Tag;
                        hp -= 25; // column attack damage
                        m.Tag = hp;

                        if (hp <= 0)
                        {
                            pnlGameArea.Controls.Remove(m);
                            listMonsters.Remove(m);
                        }
                    }
                }
            }
        }


    }
}
