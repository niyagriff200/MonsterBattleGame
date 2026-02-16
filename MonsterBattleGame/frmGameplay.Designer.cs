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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
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
            pnlGameArea.Size = new Size(1139, 634);
            pnlGameArea.TabIndex = 2;
            // 
            // btnAttackSingle
            // 
            btnAttackSingle.Location = new Point(267, 652);
            btnAttackSingle.Name = "btnAttackSingle";
            btnAttackSingle.Size = new Size(200, 58);
            btnAttackSingle.TabIndex = 3;
            btnAttackSingle.Text = "Single Attack";
            btnAttackSingle.UseVisualStyleBackColor = true;
            // 
            // btnAttackRow
            // 
            btnAttackRow.Location = new Point(504, 652);
            btnAttackRow.Name = "btnAttackRow";
            btnAttackRow.Size = new Size(200, 58);
            btnAttackRow.TabIndex = 4;
            btnAttackRow.Text = "Row Attack";
            btnAttackRow.UseVisualStyleBackColor = true;
            // 
            // btnColumnAttack
            // 
            btnColumnAttack.Location = new Point(749, 656);
            btnColumnAttack.Name = "btnColumnAttack";
            btnColumnAttack.Size = new Size(221, 51);
            btnColumnAttack.TabIndex = 5;
            btnColumnAttack.Text = "Column Attack";
            btnColumnAttack.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.openclipart_vectors_hero_152842_640;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(43, 642);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(185, 292);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // frmGameplay
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            BackgroundImage = Properties.Resources.jplenio_forest_7456238_640;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1378, 946);
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
        }

        #endregion

        private Button btnBack;
        private Panel pnlGameArea;
        private Button btnAttackSingle;
        private Button btnAttackRow;
        private Button btnColumnAttack;
        private PictureBox pictureBox1;
    }
}