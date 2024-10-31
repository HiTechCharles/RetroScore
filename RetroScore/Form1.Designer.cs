namespace RetroScore
{
    partial class PickGame
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
            this.GameListLBL = new System.Windows.Forms.Label();
            this.GameListLB = new System.Windows.Forms.ListBox();
            this.NewGameTB = new System.Windows.Forms.TextBox();
            this.AddGameBTN = new System.Windows.Forms.Button();
            this.PlayBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GameListLBL
            // 
            this.GameListLBL.AutoSize = true;
            this.GameListLBL.Location = new System.Drawing.Point(5, 9);
            this.GameListLBL.Name = "GameListLBL";
            this.GameListLBL.Size = new System.Drawing.Size(371, 39);
            this.GameListLBL.TabIndex = 0;
            this.GameListLBL.Text = "Select a game to play:";
            // 
            // GameListLB
            // 
            this.GameListLB.FormattingEnabled = true;
            this.GameListLB.ItemHeight = 39;
            this.GameListLB.Location = new System.Drawing.Point(12, 65);
            this.GameListLB.Name = "GameListLB";
            this.GameListLB.Size = new System.Drawing.Size(542, 394);
            this.GameListLB.Sorted = true;
            this.GameListLB.TabIndex = 1;
            // 
            // NewGameTB
            // 
            this.NewGameTB.AccessibleName = "Add New Game: Type new entry, then hit ENTER. ";
            this.NewGameTB.Location = new System.Drawing.Point(12, 481);
            this.NewGameTB.Name = "NewGameTB";
            this.NewGameTB.Size = new System.Drawing.Size(542, 46);
            this.NewGameTB.TabIndex = 2;
            // 
            // AddGameBTN
            // 
            this.AddGameBTN.ForeColor = System.Drawing.Color.Black;
            this.AddGameBTN.Location = new System.Drawing.Point(12, 562);
            this.AddGameBTN.Name = "AddGameBTN";
            this.AddGameBTN.Size = new System.Drawing.Size(105, 46);
            this.AddGameBTN.TabIndex = 3;
            this.AddGameBTN.Text = "&Add";
            this.AddGameBTN.UseVisualStyleBackColor = true;
            this.AddGameBTN.Click += new System.EventHandler(this.AddGameBTN_Click);
            // 
            // PlayBTN
            // 
            this.PlayBTN.ForeColor = System.Drawing.Color.Black;
            this.PlayBTN.Location = new System.Drawing.Point(449, 562);
            this.PlayBTN.Name = "PlayBTN";
            this.PlayBTN.Size = new System.Drawing.Size(105, 46);
            this.PlayBTN.TabIndex = 4;
            this.PlayBTN.Text = "&Play";
            this.PlayBTN.UseVisualStyleBackColor = true;
            this.PlayBTN.Click += new System.EventHandler(this.PlayBTN_Click);
            // 
            // PickGame
            // 
            this.AcceptButton = this.AddGameBTN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(566, 620);
            this.Controls.Add(this.PlayBTN);
            this.Controls.Add(this.AddGameBTN);
            this.Controls.Add(this.NewGameTB);
            this.Controls.Add(this.GameListLB);
            this.Controls.Add(this.GameListLBL);
            this.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.Name = "PickGame";
            this.Text = "RetroScore by HiTechCharles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GameListLBL;
        private System.Windows.Forms.ListBox GameListLB;
        private System.Windows.Forms.TextBox NewGameTB;
        private System.Windows.Forms.Button AddGameBTN;
        private System.Windows.Forms.Button PlayBTN;
    }
}

