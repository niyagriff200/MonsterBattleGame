namespace MonsterBattleGame
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            frmGameplay frmgameplay = new frmGameplay(this);

            frmgameplay.Show();

            this.Hide();
        }

        private void btnCredits_Click(object sender, EventArgs e)
        {
            frmCredits frmcredits = new frmCredits(this);

            frmcredits.Show();

            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}
