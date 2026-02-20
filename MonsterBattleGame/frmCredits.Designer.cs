namespace MonsterBattleGame
{
    partial class frmCredits
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
            pnlCredits = new Panel();
            lblShaniyaGriffin = new Label();
            lblJoe = new Label();
            lblOpenClipArt = new Label();
            lblWernerMoser = new Label();
            lblPeterPang = new Label();
            lblCreditsTitle = new Label();
            pnlCredits.SuspendLayout();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(33, 28);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(308, 58);
            btnBack.TabIndex = 0;
            btnBack.Text = "RETURN TO MENU";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // pnlCredits
            // 
            pnlCredits.BackColor = Color.Gray;
            pnlCredits.Controls.Add(lblShaniyaGriffin);
            pnlCredits.Controls.Add(lblJoe);
            pnlCredits.Controls.Add(lblOpenClipArt);
            pnlCredits.Controls.Add(lblWernerMoser);
            pnlCredits.Controls.Add(lblPeterPang);
            pnlCredits.Controls.Add(lblCreditsTitle);
            pnlCredits.Location = new Point(234, 92);
            pnlCredits.Name = "pnlCredits";
            pnlCredits.Size = new Size(805, 788);
            pnlCredits.TabIndex = 1;
            // 
            // lblShaniyaGriffin
            // 
            lblShaniyaGriffin.AutoSize = true;
            lblShaniyaGriffin.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblShaniyaGriffin.ForeColor = Color.White;
            lblShaniyaGriffin.Location = new Point(232, 141);
            lblShaniyaGriffin.Name = "lblShaniyaGriffin";
            lblShaniyaGriffin.Size = new Size(350, 50);
            lblShaniyaGriffin.TabIndex = 5;
            lblShaniyaGriffin.Text = "Shaniya Griffin";
            // 
            // lblJoe
            // 
            lblJoe.AutoSize = true;
            lblJoe.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblJoe.ForeColor = Color.White;
            lblJoe.Location = new Point(303, 425);
            lblJoe.Name = "lblJoe";
            lblJoe.Size = new Size(235, 50);
            lblJoe.TabIndex = 4;
            lblJoe.Text = "Joe Plenio";
            // 
            // lblOpenClipArt
            // 
            lblOpenClipArt.AutoSize = true;
            lblOpenClipArt.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOpenClipArt.ForeColor = Color.White;
            lblOpenClipArt.Location = new Point(265, 352);
            lblOpenClipArt.Name = "lblOpenClipArt";
            lblOpenClipArt.Size = new Size(304, 50);
            lblOpenClipArt.TabIndex = 3;
            lblOpenClipArt.Text = "Open Clip Art";
            // 
            // lblWernerMoser
            // 
            lblWernerMoser.AutoSize = true;
            lblWernerMoser.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWernerMoser.ForeColor = Color.White;
            lblWernerMoser.Location = new Point(256, 283);
            lblWernerMoser.Name = "lblWernerMoser";
            lblWernerMoser.Size = new Size(326, 50);
            lblWernerMoser.TabIndex = 2;
            lblWernerMoser.Text = "Werner Moser";
            // 
            // lblPeterPang
            // 
            lblPeterPang.AutoSize = true;
            lblPeterPang.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPeterPang.ForeColor = Color.White;
            lblPeterPang.Location = new Point(280, 206);
            lblPeterPang.Name = "lblPeterPang";
            lblPeterPang.Size = new Size(258, 50);
            lblPeterPang.TabIndex = 1;
            lblPeterPang.Text = "Peter Pang";
            // 
            // lblCreditsTitle
            // 
            lblCreditsTitle.AutoSize = true;
            lblCreditsTitle.Font = new Font("Showcard Gothic", 20.1F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblCreditsTitle.ForeColor = Color.White;
            lblCreditsTitle.Location = new Point(256, 32);
            lblCreditsTitle.Name = "lblCreditsTitle";
            lblCreditsTitle.Size = new Size(313, 83);
            lblCreditsTitle.TabIndex = 0;
            lblCreditsTitle.Text = "CREDITS";
            // 
            // frmCredits
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.peterpang252_night_3129908_1280;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1303, 906);
            Controls.Add(pnlCredits);
            Controls.Add(btnBack);
            Name = "frmCredits";
            Text = "frmCredits";
            FormClosing += frmCredits_FormClosing;
            pnlCredits.ResumeLayout(false);
            pnlCredits.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnBack;
        private Panel pnlCredits;
        private Label lblCreditsTitle;
        private Label lblOpenClipArt;
        private Label lblWernerMoser;
        private Label lblPeterPang;
        private Label lblShaniyaGriffin;
        private Label lblJoe;
    }
}