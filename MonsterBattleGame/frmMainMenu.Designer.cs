namespace MonsterBattleGame
{
    partial class frmMainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnStartGame = new Button();
            btnExit = new Button();
            btnCredits = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 20.1F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.OrangeRed;
            label1.Location = new Point(411, 92);
            label1.Name = "label1";
            label1.Size = new Size(608, 83);
            label1.TabIndex = 0;
            label1.Text = "MONSTER BATTLE";
            // 
            // btnStartGame
            // 
            btnStartGame.BackColor = Color.Transparent;
            btnStartGame.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStartGame.ForeColor = Color.DarkRed;
            btnStartGame.Location = new Point(546, 309);
            btnStartGame.Name = "btnStartGame";
            btnStartGame.Size = new Size(321, 58);
            btnStartGame.TabIndex = 1;
            btnStartGame.Text = "START GAME";
            btnStartGame.UseVisualStyleBackColor = false;
            btnStartGame.Click += btnStartGame_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Transparent;
            btnExit.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.DarkRed;
            btnExit.Location = new Point(546, 497);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(321, 58);
            btnExit.TabIndex = 2;
            btnExit.Text = "EXIT GAME";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnCredits
            // 
            btnCredits.BackColor = Color.Transparent;
            btnCredits.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCredits.ForeColor = Color.DarkRed;
            btnCredits.Location = new Point(546, 402);
            btnCredits.Name = "btnCredits";
            btnCredits.Size = new Size(321, 58);
            btnCredits.TabIndex = 3;
            btnCredits.Text = "Credits";
            btnCredits.UseVisualStyleBackColor = false;
            btnCredits.Click += btnCredits_Click;
            // 
            // frmMainMenu
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.peterpang252_night_3129908_1280;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1404, 899);
            Controls.Add(btnCredits);
            Controls.Add(btnExit);
            Controls.Add(btnStartGame);
            Controls.Add(label1);
            Name = "frmMainMenu";
            Text = "Monster Battle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnStartGame;
        private Button btnExit;
        private Button btnCredits;
    }
}
