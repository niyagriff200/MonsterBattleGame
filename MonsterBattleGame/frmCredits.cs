using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MonsterBattleGame
{
    public partial class frmCredits : Form
    {
        private frmMainMenu frmOriginal;

        public frmCredits()
        {
            InitializeComponent();
        }

        public frmCredits(frmMainMenu frmMainMenuObj)
        {
            InitializeComponent();
            frmOriginal = frmMainMenuObj;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmOriginal.Show();
            this.Close();
        }

        private void frmCredits_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmOriginal.Show();
        }
    }
}
