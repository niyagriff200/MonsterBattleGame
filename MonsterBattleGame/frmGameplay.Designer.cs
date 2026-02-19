namespace MonsterBattleGame
{
    partial class frmGameplay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnBack = new Button();
            pnlGameArea = new Panel();
            btnAttackSingle = new Button();
            btnAttackRow = new Button();
            btnColumnAttack = new Button();
            pictureBox1 = new PictureBox();
            btnStartGame = new Button();
            lblPlayerHP = new Label();
            lblAttackDamageS = new Label();
            lblAttackDamageR = new Label();
            lblAttackDamageC = new Label();
            btnConfirm = new Button();
            lblPlayerPoints = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(1028, 876);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(338, 58);
            btnBack.TabIndex = 0;
            btnBack.Text = "RETURN TO MENU";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // pnlGameArea
            // 
            pnlGameArea.BackColor = Color.LightGray;
            pnlGameArea.BackgroundImageLayout = ImageLayout.Stretch;
            pnlGameArea.Location = new Point(117, 2);
            pnlGameArea.Name = "pnlGameArea";
            pnlGameArea.Size = new Size(1140, 640);
            pnlGameArea.TabIndex = 2;
            // 
            // btnAttackSingle
            // 
            btnAttackSingle.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAttackSingle.Location = new Point(267, 652);
            btnAttackSingle.Name = "btnAttackSingle";
            btnAttackSingle.Size = new Size(200, 55);
            btnAttackSingle.TabIndex = 3;
            btnAttackSingle.Text = "Single Attack";
            btnAttackSingle.UseVisualStyleBackColor = true;
            btnAttackSingle.Click += btnAttackSingle_Click;
            // 
            // btnAttackRow
            // 
            btnAttackRow.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAttackRow.Location = new Point(519, 655);
            btnAttackRow.Name = "btnAttackRow";
            btnAttackRow.Size = new Size(200, 52);
            btnAttackRow.TabIndex = 4;
            btnAttackRow.Text = "Row Attack";
            btnAttackRow.UseVisualStyleBackColor = true;
            btnAttackRow.Click += btnAttackRow_Click;
            // 
            // btnColumnAttack
            // 
            btnColumnAttack.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnColumnAttack.Location = new Point(774, 656);
            btnColumnAttack.Name = "btnColumnAttack";
            btnColumnAttack.Size = new Size(221, 51);
            btnColumnAttack.TabIndex = 5;
            btnColumnAttack.Text = "Column Attack";
            btnColumnAttack.UseVisualStyleBackColor = true;
            btnColumnAttack.Click += btnColumnAttack_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.openclipart_vectors_hero_152842_640;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(12, 642);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(185, 292);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // btnStartGame
            // 
            btnStartGame.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStartGame.Location = new Point(734, 876);
            btnStartGame.Name = "btnStartGame";
            btnStartGame.Size = new Size(288, 58);
            btnStartGame.TabIndex = 7;
            btnStartGame.Text = "START GAME";
            btnStartGame.UseVisualStyleBackColor = true;
            btnStartGame.Click += btnStartGame_Click;
            // 
            // lblPlayerHP
            // 
            lblPlayerHP.AutoSize = true;
            lblPlayerHP.BackColor = Color.Transparent;
            lblPlayerHP.Font = new Font("Showcard Gothic", 14.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlayerHP.ForeColor = Color.Crimson;
            lblPlayerHP.Location = new Point(203, 777);
            lblPlayerHP.Name = "lblPlayerHP";
            lblPlayerHP.Size = new Size(176, 59);
            lblPlayerHP.TabIndex = 8;
            lblPlayerHP.Text = "HP: 50";
            // 
            // lblAttackDamageS
            // 
            lblAttackDamageS.AutoSize = true;
            lblAttackDamageS.BackColor = Color.Transparent;
            lblAttackDamageS.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAttackDamageS.ForeColor = Color.FromArgb(255, 128, 128);
            lblAttackDamageS.Location = new Point(321, 713);
            lblAttackDamageS.Name = "lblAttackDamageS";
            lblAttackDamageS.Size = new Size(68, 50);
            lblAttackDamageS.TabIndex = 9;
            lblAttackDamageS.Text = "50";
            // 
            // lblAttackDamageR
            // 
            lblAttackDamageR.AutoSize = true;
            lblAttackDamageR.BackColor = Color.Transparent;
            lblAttackDamageR.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAttackDamageR.ForeColor = Color.FromArgb(255, 128, 128);
            lblAttackDamageR.Location = new Point(582, 716);
            lblAttackDamageR.Name = "lblAttackDamageR";
            lblAttackDamageR.Size = new Size(62, 50);
            lblAttackDamageR.TabIndex = 10;
            lblAttackDamageR.Text = "25";
            // 
            // lblAttackDamageC
            // 
            lblAttackDamageC.AutoSize = true;
            lblAttackDamageC.BackColor = Color.Transparent;
            lblAttackDamageC.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAttackDamageC.ForeColor = Color.FromArgb(255, 128, 128);
            lblAttackDamageC.Location = new Point(853, 710);
            lblAttackDamageC.Name = "lblAttackDamageC";
            lblAttackDamageC.Size = new Size(62, 50);
            lblAttackDamageC.TabIndex = 11;
            lblAttackDamageC.Text = "25";
            // 
            // btnConfirm
            // 
            btnConfirm.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfirm.Location = new Point(1044, 652);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(188, 114);
            btnConfirm.TabIndex = 12;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // lblPlayerPoints
            // 
            lblPlayerPoints.AutoSize = true;
            lblPlayerPoints.BackColor = Color.Transparent;
            lblPlayerPoints.Font = new Font("Showcard Gothic", 14.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlayerPoints.ForeColor = Color.Crimson;
            lblPlayerPoints.Location = new Point(203, 856);
            lblPlayerPoints.Name = "lblPlayerPoints";
            lblPlayerPoints.Size = new Size(253, 59);
            lblPlayerPoints.TabIndex = 13;
            lblPlayerPoints.Text = "POINTS: 0";
            // 
            // frmGameplay
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            BackgroundImage = Properties.Resources.jplenio_forest_7456238_640;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1378, 946);
            Controls.Add(lblPlayerPoints);
            Controls.Add(btnConfirm);
            Controls.Add(lblAttackDamageC);
            Controls.Add(lblAttackDamageR);
            Controls.Add(lblAttackDamageS);
            Controls.Add(lblPlayerHP);
            Controls.Add(btnStartGame);
            Controls.Add(pictureBox1);
            Controls.Add(btnColumnAttack);
            Controls.Add(btnAttackRow);
            Controls.Add(btnAttackSingle);
            Controls.Add(pnlGameArea);
            Controls.Add(btnBack);
            Name = "frmGameplay";
            Text = "frmGameplay";
            FormClosing += frmGameplay_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Panel pnlGameArea;
        private Button btnAttackSingle;
        private Button btnAttackRow;
        private Button btnColumnAttack;
        private PictureBox pictureBox1;
        private Button btnStartGame;
        private Label lblPlayerHP;
        private Label lblAttackDamageS;
        private Label lblAttackDamageR;
        private Label lblAttackDamageC;
        private Button btnConfirm;
        private Label lblPlayerPoints;
    }
}