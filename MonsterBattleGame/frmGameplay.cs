using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Media;



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
        private int[] rows = { 50 };

        // Array of possible X positions (columns) where monsters can spawn.
        // Monsters will randomly choose one of these lanes.
        private int[] cols = { 100, 300, 500, 700, 900};

        // Player's health points. When monsters reach the bottom, this decreases.
        private int playerHP = 100;

        //Player's starting points
        private int playerPoints = 0;

        // Default monster health, Stored in the PictureBox.Tag
        private int monsterHP = 100;

        // Stores which attack mode the player has chosen ("single", "row", "column")
        private string attackMode = "";

        // Stores the monster the player clicked on when selecting a target
        private PictureBox selectedMonster = null;

        //Contains player score
        private string scoreFile = "score.json";



        public frmGameplay()
        {
            InitializeComponent();
        }

        public frmGameplay(frmMainMenu frmMainMenuObj)
        {
            InitializeComponent();
            frmOriginal = frmMainMenuObj;
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

        // Stores the monster's current HP value and its HP label
        public class MonsterData
        {
            // Holds the monster's HP value
            public int HP;

            // Holds the label that displays the monster's HP
            public Label HPLabel;

            // Assigns the HP value and label reference when the monster is created
            public MonsterData(int hp, Label label)
            {
                HP = hp;
                HPLabel = label;
            }
        }



        public void SpawnMonsters()
        {
            try
            {
                //max number of monsters
                int maxMonsters = 4;

                //subtract 1 from max monsters, because list starts at 0, (0, 1, 2, 3)
                int availableSlots = maxMonsters - listMonsters.Count;

                if (availableSlots <= 0) //if there are no available slots return...
                {
                    return;
                }

                // Randomly spawn 1 or 2 monsters
                int monstersToSpawn = rand.Next(1, 3);
                monstersToSpawn = Math.Min(monstersToSpawn, availableSlots);


                // Only spawn a monster if fewer than the max number are active
                for (int i = 0; i < monstersToSpawn; i++)
                { 
                    // Create a new monster as a PictureBox
                    PictureBox monster = new PictureBox();

                    // Assign the monster image and make sure it scales correctly
                    monster.Image = Properties.Resources.pixelcreatures_alien_671296_640;
                    monster.SizeMode = PictureBoxSizeMode.StretchImage;

                    // Set the monster's size (75x75 pixels)
                    monster.Size = new Size(75, 75);

                    // Store the monster's HP inside the Tag property
                    monster.Tag = monsterHP;

                    // Set the monster's starting vertical position (Y)
                    // Using rows[0] makes this easy to change later
                    monster.Top = rows[0];

                    // Choose a random column (X position) from the cols array
                    int startCol = cols[rand.Next(cols.Length)];
                    monster.Left = startCol;

                    // Creates a label to display the monster's HP
                    Label hpLabel = new Label();

                    // Sets the label text to the monster's HP
                    hpLabel.Text = monsterHP.ToString();

                    // Sets the label font and color
                    hpLabel.Font = new Font("Arial", 10, FontStyle.Bold);
                    hpLabel.ForeColor = Color.White;

                    // Enables automatic sizing
                    hpLabel.AutoSize = true;

                    // Positions the label above the monster
                    hpLabel.Left = monster.Left + (monster.Width - hpLabel.Width) / 2;
                    hpLabel.Top = monster.Top - 40;

                    // Stores the label inside the monster's Tag along with HP
                    monster.Tag = new MonsterData(monsterHP, hpLabel);

                    // Adds the label to the game area
                    pnlGameArea.Controls.Add(hpLabel);

                    // Allow the monster to be clicked for attack selection
                    monster.Click += Monster_Click;

                    // Add the monster to the gameplay panel and to the list
                    pnlGameArea.Controls.Add(monster);
                    listMonsters.Add(monster);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error spawning monster: " + ex.Message);
            }
        }

        public void MoveMonsters()
        {
            try
            {
                // Loop backwards so we can safely remove monsters during iteration
                for (int i = listMonsters.Count - 1; i >= 0; i--)
                {
                    PictureBox m = listMonsters[i];

                    // Move the monster downward by 100 pixels
                    m.Top += 100;

                    //Move the label downward with the monster
                    MonsterData data = (MonsterData)m.Tag;
                    data.HPLabel.Top = m.Top - 40;
                    data.HPLabel.Left = m.Left + (m.Width - data.HPLabel.Width) / 2;


                    // Check if the monster has reached the bottom of the panel
                    if (m.Top >= pnlGameArea.Height - m.Height)
                    {
                        // Monster reached the player area (player takes damage)
                        playerHP -= 10;

                        //play monster attack sound
                        PlayMonsterAttackSound();

                        lblPlayerHP.Text = "HP: " + playerHP;

                        // Remove the monster from the panel and the list
                        pnlGameArea.Controls.Remove(data.HPLabel);
                        pnlGameArea.Controls.Remove(m);
                        listMonsters.Remove(m);
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Error moving monster: " + ex.Message);
            }
        }

        private void Monster_Click(object sender, EventArgs e)
        {
            // Allows selection only when an attack mode is active
            if (attackMode != "")
            {
                PictureBox clicked = sender as PictureBox;

                // Resets all monsters to the selectable color
                foreach (PictureBox m in listMonsters)
                {
                    m.BackColor = Color.Red;
                }

                // Stores the clicked monster as the selected target
                selectedMonster = clicked;

                // Highlights based on the selected attack mode
                if (attackMode == "single")
                {
                    // Highlights only the clicked monster
                    clicked.BackColor = Color.Green;
                }
                else if (attackMode == "row")
                {
                    // Gets the Y position of the selected monster
                    int targetRow = clicked.Top;

                    // Defines the height range for the row
                    int rowHeight = 100;

                    // Highlights all monsters in the same row band
                    foreach (PictureBox m in listMonsters)
                    {
                        if (m.Top >= targetRow && m.Top < targetRow + rowHeight)
                        {
                            m.BackColor = Color.Green;
                        }
                    }
                }
                else if (attackMode == "column")
                {
                    // Gets the X position of the selected monster
                    int targetCol = clicked.Left;

                    // Defines the width range for the column
                    int colWidth = 100;

                    // Highlights all monsters in the same column band
                    foreach (PictureBox m in listMonsters)
                    {
                        if (m.Left >= targetCol && m.Left < targetCol + colWidth)
                        {
                            m.BackColor = Color.Green;
                        }
                    }
                }
            }
        }


        public void AttackSingle()
        {
            // Only attack if a monster has been selected
            if (selectedMonster != null)
            {
                // Get the monster's current HP from the Tag
                MonsterData data = (MonsterData)selectedMonster.Tag;
                data.HP -= 50;
                data.HPLabel.Text = data.HP.ToString();

                //plays Player attack sound
                PlayPlayerAttackSound();

                // If HP is zero or below, remove the monster
                if (data.HP <= 0)
                {
                    PlayDeathSound();

                    playerPoints += 25;
                    lblPlayerPoints.Text = "Points: " + playerPoints;

                    pnlGameArea.Controls.Remove(data.HPLabel);
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

                // Height of one row
                int rowHeight = 100;

                // Loop backwards so we can remove monsters safely
                for (int i = listMonsters.Count - 1; i >= 0; i--)
                {
                    PictureBox m = listMonsters[i];

                    // Check if this monster is in the same row band
                    if (m.Top >= targetRow && m.Top < targetRow + rowHeight)
                    {
                        // Get the monster's current HP from the Tag
                        MonsterData data = (MonsterData)m.Tag;

                        // Reduce HP
                        data.HP -= 25;

                        //Plays player attack sound
                        PlayPlayerAttackSound();

                        // Update label
                        data.HPLabel.Text = data.HP.ToString();

                        // Remove if dead
                        if (data.HP <= 0)
                        {
                            PlayDeathSound();

                            playerPoints += 25;
                            lblPlayerPoints.Text = "Points: " + playerPoints;

                            pnlGameArea.Controls.Remove(data.HPLabel);
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

                // Width of one column
                int colWidth = 100;

                // Loop backwards so we can remove monsters safely
                for (int i = listMonsters.Count - 1; i >= 0; i--)
                {
                    PictureBox m = listMonsters[i];

                    // Check if this monster is in the same column band
                    if (m.Left >= targetCol && m.Left < targetCol + colWidth)
                    {
                        // Get the monster's current HP from the Tag
                        MonsterData data = (MonsterData)m.Tag;

                        // Reduce HP
                        data.HP -= 25;

                        //Plays Player attack sound
                        PlayPlayerAttackSound();


                        // Update label
                        data.HPLabel.Text = data.HP.ToString();

                        // Remove if dead
                        if (data.HP <= 0)
                        {
                            PlayDeathSound();

                            playerPoints += 25;
                            lblPlayerPoints.Text = "Points: " + playerPoints;

                            pnlGameArea.Controls.Remove(data.HPLabel);
                            pnlGameArea.Controls.Remove(m);
                            listMonsters.Remove(m);
                        }
                    }
                }
            }
        }


        private void HighlightSelectableMonsters()
        {
            foreach (PictureBox m in listMonsters)
            {
                m.BorderStyle = BorderStyle.FixedSingle; // outline
                m.BackColor = Color.Red; // means "clickable"
            }
        }

        private void ResetSelection() 
        {
            attackMode = "";
            selectedMonster = null;

            foreach (PictureBox m in listMonsters)
            {
                m.BackColor = Color.Transparent;
                m.BorderStyle = BorderStyle.None;
            }
        }
        private void ShowGameOverLabel()
        {
            // Creates a new label for the Game Over message
            Label lblGameOver = new Label();

            // Sets the text displayed on the label
            lblGameOver.Text = "GAME OVER";

            // Sets the font style and size for the label
            lblGameOver.Font = new Font("Showcard Gothic", 24, FontStyle.Bold);

            // Sets the text color to red
            lblGameOver.ForeColor = Color.Red;

            // Enables automatic sizing based on the text
            lblGameOver.AutoSize = true;

            // Centers the label horizontally inside the game area panel
            lblGameOver.Left = (pnlGameArea.Width - lblGameOver.Width) / 2;

            // Centers the label vertically inside the game area panel
            lblGameOver.Top = (pnlGameArea.Height - lblGameOver.Height) / 2;

            // Adds the label to the game area panel
            pnlGameArea.Controls.Add(lblGameOver);
        }


        private void CheckGameOver()
        {
            // Checks if the player's HP is zero or below
            if (playerHP <= 0)
            {
                int savedHighScore = 0;

                try
                {
                    // Checks if the score file exists
                    if (File.Exists(scoreFile))
                    {
                        // Reads the saved score from the file
                        string savedScoreText = File.ReadAllText(scoreFile);

                        // Converts the saved score text from JSON into a dictionary
                        Dictionary<string, int> scoreData = JsonSerializer.Deserialize<Dictionary<string, int>>(savedScoreText);

                        // Gets the saved high score from the dictionary
                        if (scoreData != null && scoreData.ContainsKey("HighScore"))
                        {
                            savedHighScore = scoreData["HighScore"];
                        }
                    }

                    // Saves the new score only if it is higher than the saved score
                    if (playerPoints > savedHighScore)
                    {
                        // Creates a dictionary to store the high score
                        Dictionary<string, int> newScoreData = new Dictionary<string, int>();
                        newScoreData["HighScore"] = playerPoints;

                        // Writes the new high score to the file in JSON format
                        string json = JsonSerializer.Serialize(newScoreData);
                        File.WriteAllText(scoreFile, json);
                    }
                }
                catch (Exception ex)
                {
                    // Displays an error message if saving fails
                    MessageBox.Show("Error saving score: " + ex.Message);
                }

                // Removes all controls from the game area panel
                pnlGameArea.Controls.Clear();

                // Clears the list of active monsters
                listMonsters.Clear();

                // Clears the current attack mode
                attackMode = "";

                // Clears the selected monster reference
                selectedMonster = null;

                // Displays the Game Over label inside the game area
                ShowGameOverLabel();

                //Play Game Over Sound
                PlayGameOverSound();

                btnStartGame.Enabled = true;
                btnStartGame.Text = "Play Again?";
            }
        }


        private void btnStartGame_Click(object sender, EventArgs e)
        {
            try //check if the file exists
            {
                if (File.Exists(scoreFile))
                {
                    // Reads the saved score from the file
                    string savedScoreText = File.ReadAllText(scoreFile);

                    // Converts the saved score text from JSON into a dictionary
                    Dictionary<string, int> scoreData = JsonSerializer.Deserialize<Dictionary<string, int>>(savedScoreText);

                    // Displays the saved high score
                    if (scoreData != null && scoreData.ContainsKey("HighScore"))
                    {
                        lblHighScore.Text = "High Score: " + scoreData["HighScore"];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading score: " + ex.Message);
            }


            //Clear all monsters from the game area
            pnlGameArea.Controls.Clear();

            //Clear list of monsters
            listMonsters.Clear();

            //Reset player hp
            playerHP = 100;
            lblPlayerHP.Text = "HP: " + playerHP;

            //Reset player points
            playerPoints = 0;
            lblPlayerPoints.Text = "Points: " + playerPoints;

            //Reset attack mode
            attackMode = "";
            selectedMonster = null;

            //Spawn first monster
            SpawnMonsters();

            btnStartGame.Enabled = false;
        }

        private void btnAttackSingle_Click(object sender, EventArgs e)
        {
            attackMode = "single";
            HighlightSelectableMonsters();
        }

        private void btnAttackRow_Click(object sender, EventArgs e)
        {
            attackMode = "row";
            HighlightSelectableMonsters();
        }

        private void btnColumnAttack_Click(object sender, EventArgs e)
        {
            attackMode = "column";
            HighlightSelectableMonsters();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // Make sure an attack mode is selected
            if (attackMode == "")
            {
                return;
            }
            // Apply the correct attack
            if (attackMode == "single")
            {
                AttackSingle();
            }
            else if (attackMode == "row")
            {
                AttackRow();
            }
            else if (attackMode == "column")
            {
                AttackColumn();
            }

            // Reset selection visuals
            ResetSelection();

            // Move monsters after the player's attack
            MoveMonsters();

            // Spawn new monsters if fewer than 4 exist
            SpawnMonsters();

            // Check if the player died
            CheckGameOver();
        }

        private void PlayDeathSound()
        {
            try
            {
                SoundPlayer sound = new SoundPlayer(Properties.Resources.deathSound); //create new soundplayer, called sound
                sound.Play(); //play sound
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error playing sound: " + ex.Message); //catch any exception
            }
        }

        private void PlayMonsterAttackSound()
        {

            try
            {
                SoundPlayer sound = new SoundPlayer(Properties.Resources.monsterAttackSound); //create new soundplayer, called sound
                sound.Play(); //play sound
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error playing sound: " + ex.Message);  //catch any exception
            }
        }

        private void PlayPlayerAttackSound()
        {

            try
            {
                SoundPlayer sound = new SoundPlayer(Properties.Resources.playerAttackSound); //create new soundplayer, called sound
                sound.Play(); //play sound
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error playing sound: " + ex.Message);  //catch any exception
            }
        }

        private void PlayGameOverSound()
        {

            try
            {
                SoundPlayer sound = new SoundPlayer(Properties.Resources.gameOverSound); //create new soundplayer, called sound
                sound.Play(); //play sound
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error playing sound: " + ex.Message);  //catch any exception
            }
        }
    }
}
