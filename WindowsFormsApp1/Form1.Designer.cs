namespace RockPaperScissors
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnRock = new System.Windows.Forms.Button();
            this.btnScissors = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblRound = new System.Windows.Forms.Label();
            this.lblComputerChoice = new System.Windows.Forms.Label();
            this.lblRoundResult = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // btnRock
            this.btnRock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnRock.Location = new System.Drawing.Point(30, 30);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(120, 50);
            this.btnRock.TabIndex = 0;
            this.btnRock.Text = "Камень";
            this.btnRock.UseVisualStyleBackColor = true;
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);

            // btnScissors
            this.btnScissors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnScissors.Location = new System.Drawing.Point(160, 30);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(120, 50);
            this.btnScissors.TabIndex = 1;
            this.btnScissors.Text = "Ножницы";
            this.btnScissors.UseVisualStyleBackColor = true;
            this.btnScissors.Click += new System.EventHandler(this.btnScissors_Click);

            // btnPaper
            this.btnPaper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPaper.Location = new System.Drawing.Point(290, 30);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(120, 50);
            this.btnPaper.TabIndex = 2;
            this.btnPaper.Text = "Бумага";
            this.btnPaper.UseVisualStyleBackColor = true;
            this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);

            // lblScore
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblScore.Location = new System.Drawing.Point(30, 100);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(108, 20);
            this.lblScore.TabIndex = 3;
            this.lblScore.Text = "Вы: 0 - Компьютер: 0";

            // lblRound
            this.lblRound.AutoSize = true;
            this.lblRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRound.Location = new System.Drawing.Point(30, 130);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(72, 20);
            this.lblRound.TabIndex = 4;
            this.lblRound.Text = "Раунд: 0";

            // lblComputerChoice
            this.lblComputerChoice.AutoSize = true;
            this.lblComputerChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblComputerChoice.Location = new System.Drawing.Point(30, 160);
            this.lblComputerChoice.Name = "lblComputerChoice";
            this.lblComputerChoice.Size = new System.Drawing.Size(151, 20);
            this.lblComputerChoice.TabIndex = 5;
            this.lblComputerChoice.Text = "Компьютер выбрал:";

            // lblRoundResult
            this.lblRoundResult.AutoSize = true;
            this.lblRoundResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblRoundResult.ForeColor = System.Drawing.Color.Blue;
            this.lblRoundResult.Location = new System.Drawing.Point(30, 190);
            this.lblRoundResult.Name = "lblRoundResult";
            this.lblRoundResult.Size = new System.Drawing.Size(0, 20);
            this.lblRoundResult.TabIndex = 6;

            // lblResult
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblResult.ForeColor = System.Drawing.Color.Green;
            this.lblResult.Location = new System.Drawing.Point(30, 220);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 20);
            this.lblResult.TabIndex = 7;

            // btnNewGame
            this.btnNewGame.Enabled = false;
            this.btnNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnNewGame.Location = new System.Drawing.Point(160, 260);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(120, 40);
            this.btnNewGame.TabIndex = 8;
            this.btnNewGame.Text = "Новая игра";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);

            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 320);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblRoundResult);
            this.Controls.Add(this.lblComputerChoice);
            this.Controls.Add(this.lblRound);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnScissors);
            this.Controls.Add(this.btnRock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Камень, Ножницы, Бумага";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnScissors;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.Label lblComputerChoice;
        private System.Windows.Forms.Label lblRoundResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnNewGame;
    }
}