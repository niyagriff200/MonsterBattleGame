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
            // frmCredits
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1303, 906);
            Controls.Add(btnBack);
            Name = "frmCredits";
            Text = "frmCredits";
            FormClosing += frmCredits_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button btnBack;
    }
}