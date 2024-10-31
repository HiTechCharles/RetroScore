namespace RetroScore
{
    partial class AddScores
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
            this.DoneBTN = new System.Windows.Forms.Button();
            this.AddScoreBTN = new System.Windows.Forms.Button();
            this.NewScoreTB = new System.Windows.Forms.TextBox();
            this.ScoreListLB = new System.Windows.Forms.ListBox();
            this.ScoreListLBL = new System.Windows.Forms.Label();
            this.DeleteBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DoneBTN
            // 
            this.DoneBTN.BackColor = System.Drawing.Color.Yellow;
            this.DoneBTN.ForeColor = System.Drawing.Color.Black;
            this.DoneBTN.Location = new System.Drawing.Point(424, 564);
            this.DoneBTN.Name = "DoneBTN";
            this.DoneBTN.Size = new System.Drawing.Size(129, 46);
            this.DoneBTN.TabIndex = 4;
            this.DoneBTN.Text = "&Done";
            this.DoneBTN.UseVisualStyleBackColor = false;
            this.DoneBTN.Click += new System.EventHandler(this.DoneBTN_Click);
            // 
            // AddScoreBTN
            // 
            this.AddScoreBTN.BackColor = System.Drawing.Color.Yellow;
            this.AddScoreBTN.ForeColor = System.Drawing.Color.Black;
            this.AddScoreBTN.Location = new System.Drawing.Point(16, 564);
            this.AddScoreBTN.Name = "AddScoreBTN";
            this.AddScoreBTN.Size = new System.Drawing.Size(129, 46);
            this.AddScoreBTN.TabIndex = 3;
            this.AddScoreBTN.Text = "&Add";
            this.AddScoreBTN.UseVisualStyleBackColor = false;
            this.AddScoreBTN.Click += new System.EventHandler(this.AddScoreBTN_Click);
            // 
            // NewScoreTB
            // 
            this.NewScoreTB.AccessibleName = "Add New Score: Type new entry, then hit ENTER. ";
            this.NewScoreTB.Location = new System.Drawing.Point(16, 484);
            this.NewScoreTB.Name = "NewScoreTB";
            this.NewScoreTB.Size = new System.Drawing.Size(542, 46);
            this.NewScoreTB.TabIndex = 2;
            // 
            // ScoreListLB
            // 
            this.ScoreListLB.FormattingEnabled = true;
            this.ScoreListLB.ItemHeight = 39;
            this.ScoreListLB.Location = new System.Drawing.Point(16, 67);
            this.ScoreListLB.Name = "ScoreListLB";
            this.ScoreListLB.Size = new System.Drawing.Size(542, 394);
            this.ScoreListLB.TabIndex = 1;
            // 
            // ScoreListLBL
            // 
            this.ScoreListLBL.AutoSize = true;
            this.ScoreListLBL.Location = new System.Drawing.Point(9, 11);
            this.ScoreListLBL.Name = "ScoreListLBL";
            this.ScoreListLBL.Size = new System.Drawing.Size(0, 39);
            this.ScoreListLBL.TabIndex = 0;
            // 
            // DeleteBTN
            // 
            this.DeleteBTN.BackColor = System.Drawing.Color.Yellow;
            this.DeleteBTN.ForeColor = System.Drawing.Color.Black;
            this.DeleteBTN.Location = new System.Drawing.Point(220, 564);
            this.DeleteBTN.Name = "DeleteBTN";
            this.DeleteBTN.Size = new System.Drawing.Size(129, 46);
            this.DeleteBTN.TabIndex = 5;
            this.DeleteBTN.Text = "Dele&te";
            this.DeleteBTN.UseVisualStyleBackColor = false;
            this.DeleteBTN.Click += new System.EventHandler(this.DeleteBTN_Click);
            // 
            // AddScores
            // 
            this.AcceptButton = this.AddScoreBTN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(566, 620);
            this.Controls.Add(this.DeleteBTN);
            this.Controls.Add(this.DoneBTN);
            this.Controls.Add(this.AddScoreBTN);
            this.Controls.Add(this.NewScoreTB);
            this.Controls.Add(this.ScoreListLB);
            this.Controls.Add(this.ScoreListLBL);
            this.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Yellow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "AddScores";
            this.Text = "RetroScores - ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DoneBTN;
        private System.Windows.Forms.Button AddScoreBTN;
        private System.Windows.Forms.TextBox NewScoreTB;
        private System.Windows.Forms.ListBox ScoreListLB;
        private System.Windows.Forms.Label ScoreListLBL;
        private System.Windows.Forms.Button DeleteBTN;
    }
}