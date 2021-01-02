namespace TrackerUI
{
    partial class TournamentViewerForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.HeaderLable = new System.Windows.Forms.Label();
            this.TournamentName = new System.Windows.Forms.Label();
            this.RoundLable = new System.Windows.Forms.Label();
            this.RoundDropdown = new System.Windows.Forms.ComboBox();
            this.UnplayedOnlyCheckbox = new System.Windows.Forms.CheckBox();
            this.matchupListBox = new System.Windows.Forms.ListBox();
            this.teamOneNameLable = new System.Windows.Forms.Label();
            this.teamOneScoreLabel = new System.Windows.Forms.Label();
            this.teamOneScoreValue = new System.Windows.Forms.TextBox();
            this.teamTwoScoreValue = new System.Windows.Forms.TextBox();
            this.teamTwoScoreLabel = new System.Windows.Forms.Label();
            this.teamTwoNameLable = new System.Windows.Forms.Label();
            this.vsLable = new System.Windows.Forms.Label();
            this.scoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HeaderLable
            // 
            this.HeaderLable.AutoSize = true;
            this.HeaderLable.BackColor = System.Drawing.Color.White;
            this.HeaderLable.ForeColor = System.Drawing.Color.DarkCyan;
            this.HeaderLable.Location = new System.Drawing.Point(20, 36);
            this.HeaderLable.Name = "HeaderLable";
            this.HeaderLable.Size = new System.Drawing.Size(176, 32);
            this.HeaderLable.TabIndex = 0;
            this.HeaderLable.Text = "Tournament:";
            // 
            // TournamentName
            // 
            this.TournamentName.AutoSize = true;
            this.TournamentName.BackColor = System.Drawing.Color.White;
            this.TournamentName.ForeColor = System.Drawing.Color.DarkCyan;
            this.TournamentName.Location = new System.Drawing.Point(202, 36);
            this.TournamentName.Name = "TournamentName";
            this.TournamentName.Size = new System.Drawing.Size(111, 32);
            this.TournamentName.TabIndex = 1;
            this.TournamentName.Text = "<none>";
            // 
            // RoundLable
            // 
            this.RoundLable.AutoSize = true;
            this.RoundLable.BackColor = System.Drawing.Color.White;
            this.RoundLable.ForeColor = System.Drawing.Color.DarkCyan;
            this.RoundLable.Location = new System.Drawing.Point(20, 118);
            this.RoundLable.Name = "RoundLable";
            this.RoundLable.Size = new System.Drawing.Size(99, 32);
            this.RoundLable.TabIndex = 2;
            this.RoundLable.Text = "Round";
            // 
            // RoundDropdown
            // 
            this.RoundDropdown.FormattingEnabled = true;
            this.RoundDropdown.Location = new System.Drawing.Point(160, 111);
            this.RoundDropdown.Name = "RoundDropdown";
            this.RoundDropdown.Size = new System.Drawing.Size(178, 39);
            this.RoundDropdown.TabIndex = 3;
            // 
            // UnplayedOnlyCheckbox
            // 
            this.UnplayedOnlyCheckbox.AutoSize = true;
            this.UnplayedOnlyCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnplayedOnlyCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnplayedOnlyCheckbox.Location = new System.Drawing.Point(160, 195);
            this.UnplayedOnlyCheckbox.Name = "UnplayedOnlyCheckbox";
            this.UnplayedOnlyCheckbox.Size = new System.Drawing.Size(190, 33);
            this.UnplayedOnlyCheckbox.TabIndex = 4;
            this.UnplayedOnlyCheckbox.Text = "UnPlayed Only";
            this.UnplayedOnlyCheckbox.UseVisualStyleBackColor = true;
            // 
            // matchupListBox
            // 
            this.matchupListBox.FormattingEnabled = true;
            this.matchupListBox.ItemHeight = 31;
            this.matchupListBox.Location = new System.Drawing.Point(26, 245);
            this.matchupListBox.Name = "matchupListBox";
            this.matchupListBox.Size = new System.Drawing.Size(312, 283);
            this.matchupListBox.TabIndex = 5;
            // 
            // teamOneNameLable
            // 
            this.teamOneNameLable.AutoSize = true;
            this.teamOneNameLable.BackColor = System.Drawing.Color.White;
            this.teamOneNameLable.ForeColor = System.Drawing.Color.DarkCyan;
            this.teamOneNameLable.Location = new System.Drawing.Point(423, 245);
            this.teamOneNameLable.Name = "teamOneNameLable";
            this.teamOneNameLable.Size = new System.Drawing.Size(165, 32);
            this.teamOneNameLable.TabIndex = 6;
            this.teamOneNameLable.Text = "<team one>";
            // 
            // teamOneScoreLabel
            // 
            this.teamOneScoreLabel.AutoSize = true;
            this.teamOneScoreLabel.BackColor = System.Drawing.Color.White;
            this.teamOneScoreLabel.ForeColor = System.Drawing.Color.DarkCyan;
            this.teamOneScoreLabel.Location = new System.Drawing.Point(423, 315);
            this.teamOneScoreLabel.Name = "teamOneScoreLabel";
            this.teamOneScoreLabel.Size = new System.Drawing.Size(89, 32);
            this.teamOneScoreLabel.TabIndex = 7;
            this.teamOneScoreLabel.Text = "Score";
            // 
            // teamOneScoreValue
            // 
            this.teamOneScoreValue.Location = new System.Drawing.Point(518, 309);
            this.teamOneScoreValue.Name = "teamOneScoreValue";
            this.teamOneScoreValue.Size = new System.Drawing.Size(136, 38);
            this.teamOneScoreValue.TabIndex = 8;
            // 
            // teamTwoScoreValue
            // 
            this.teamTwoScoreValue.Location = new System.Drawing.Point(518, 476);
            this.teamTwoScoreValue.Name = "teamTwoScoreValue";
            this.teamTwoScoreValue.Size = new System.Drawing.Size(136, 38);
            this.teamTwoScoreValue.TabIndex = 11;
            //this.teamTwoScoreValue.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // teamTwoScoreLabel
            // 
            this.teamTwoScoreLabel.AutoSize = true;
            this.teamTwoScoreLabel.BackColor = System.Drawing.Color.White;
            this.teamTwoScoreLabel.ForeColor = System.Drawing.Color.DarkCyan;
            this.teamTwoScoreLabel.Location = new System.Drawing.Point(423, 482);
            this.teamTwoScoreLabel.Name = "teamTwoScoreLabel";
            this.teamTwoScoreLabel.Size = new System.Drawing.Size(89, 32);
            this.teamTwoScoreLabel.TabIndex = 10;
            this.teamTwoScoreLabel.Text = "Score";
            // 
            // teamTwoNameLable
            // 
            this.teamTwoNameLable.AutoSize = true;
            this.teamTwoNameLable.BackColor = System.Drawing.Color.White;
            this.teamTwoNameLable.ForeColor = System.Drawing.Color.DarkCyan;
            this.teamTwoNameLable.Location = new System.Drawing.Point(423, 412);
            this.teamTwoNameLable.Name = "teamTwoNameLable";
            this.teamTwoNameLable.Size = new System.Drawing.Size(161, 32);
            this.teamTwoNameLable.TabIndex = 9;
            this.teamTwoNameLable.Text = "<team two>";
            //this.teamTwoNameLable.Click += new System.EventHandler(this.teamTwoName_Click);
            // 
            // vsLable
            // 
            this.vsLable.AutoSize = true;
            this.vsLable.ForeColor = System.Drawing.Color.DarkCyan;
            this.vsLable.Location = new System.Drawing.Point(480, 369);
            this.vsLable.Name = "vsLable";
            this.vsLable.Size = new System.Drawing.Size(85, 32);
            this.vsLable.TabIndex = 12;
            this.vsLable.Text = "- VS -";
            //this.vsLable.Click += new System.EventHandler(this.label1_Click);
            // 
            // scoreButton
            // 
            this.scoreButton.BackColor = System.Drawing.Color.White;
            this.scoreButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.scoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.scoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.scoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scoreButton.ForeColor = System.Drawing.Color.DarkCyan;
            this.scoreButton.Location = new System.Drawing.Point(663, 373);
            this.scoreButton.Name = "scoreButton";
            this.scoreButton.Size = new System.Drawing.Size(132, 71);
            this.scoreButton.TabIndex = 13;
            this.scoreButton.Text = "Score";
            this.scoreButton.UseVisualStyleBackColor = false;
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(816, 572);
            this.Controls.Add(this.scoreButton);
            this.Controls.Add(this.vsLable);
            this.Controls.Add(this.teamTwoScoreValue);
            this.Controls.Add(this.teamTwoScoreLabel);
            this.Controls.Add(this.teamTwoNameLable);
            this.Controls.Add(this.teamOneScoreValue);
            this.Controls.Add(this.teamOneScoreLabel);
            this.Controls.Add(this.teamOneNameLable);
            this.Controls.Add(this.matchupListBox);
            this.Controls.Add(this.UnplayedOnlyCheckbox);
            this.Controls.Add(this.RoundDropdown);
            this.Controls.Add(this.RoundLable);
            this.Controls.Add(this.TournamentName);
            this.Controls.Add(this.HeaderLable);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "TournamentViewerForm";
            this.Text = "Tournament Viewer";
            //this.Load += new System.EventHandler(this.TournamentViewerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderLable;
        private System.Windows.Forms.Label TournamentName;
        private System.Windows.Forms.Label RoundLable;
        private System.Windows.Forms.ComboBox RoundDropdown;
        private System.Windows.Forms.CheckBox UnplayedOnlyCheckbox;
        private System.Windows.Forms.ListBox matchupListBox;
        private System.Windows.Forms.Label teamOneNameLable;
        private System.Windows.Forms.Label teamOneScoreLabel;
        private System.Windows.Forms.TextBox teamOneScoreValue;
        private System.Windows.Forms.TextBox teamTwoScoreValue;
        private System.Windows.Forms.Label teamTwoScoreLabel;
        private System.Windows.Forms.Label teamTwoNameLable;
        private System.Windows.Forms.Label vsLable;
        private System.Windows.Forms.Button scoreButton;
    }
}

