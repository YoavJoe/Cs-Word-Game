namespace WordGame_YoavShalev
{
    partial class WordGame
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lstWords = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtNewWord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLetters = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnCheckWin = new System.Windows.Forms.Button();
            this.btnp2Delete = new System.Windows.Forms.Button();
            this.btnP1Delete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstp2 = new System.Windows.Forms.ListBox();
            this.lstP1 = new System.Windows.Forms.ListBox();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lstWords
            // 
            this.lstWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lstWords.FormattingEnabled = true;
            this.lstWords.ItemHeight = 24;
            this.lstWords.Location = new System.Drawing.Point(12, 211);
            this.lstWords.Name = "lstWords";
            this.lstWords.Size = new System.Drawing.Size(301, 196);
            this.lstWords.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 174);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(63, 31);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtNewWord
            // 
            this.txtNewWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtNewWord.Location = new System.Drawing.Point(83, 176);
            this.txtNewWord.Multiline = true;
            this.txtNewWord.Name = "txtNewWord";
            this.txtNewWord.Size = new System.Drawing.Size(229, 28);
            this.txtNewWord.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(9, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Given Letters";
            // 
            // lblLetters
            // 
            this.lblLetters.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblLetters.Location = new System.Drawing.Point(102, 132);
            this.lblLetters.Name = "lblLetters";
            this.lblLetters.Size = new System.Drawing.Size(211, 30);
            this.lblLetters.TabIndex = 4;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(112, 62);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(130, 12);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(112, 62);
            this.btnRestart.TabIndex = 6;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.Restartbt_Click);
            // 
            // btnCheckWin
            // 
            this.btnCheckWin.Location = new System.Drawing.Point(401, 369);
            this.btnCheckWin.Name = "btnCheckWin";
            this.btnCheckWin.Size = new System.Drawing.Size(329, 38);
            this.btnCheckWin.TabIndex = 22;
            this.btnCheckWin.Text = "Check winner";
            this.btnCheckWin.UseVisualStyleBackColor = true;
            this.btnCheckWin.Click += new System.EventHandler(this.btnCheckWin_Click);
            // 
            // btnp2Delete
            // 
            this.btnp2Delete.Location = new System.Drawing.Point(701, 143);
            this.btnp2Delete.Name = "btnp2Delete";
            this.btnp2Delete.Size = new System.Drawing.Size(29, 23);
            this.btnp2Delete.TabIndex = 21;
            this.btnp2Delete.Text = "X";
            this.btnp2Delete.UseVisualStyleBackColor = true;
            this.btnp2Delete.Click += new System.EventHandler(this.btnp2Delete_Click);
            // 
            // btnP1Delete
            // 
            this.btnP1Delete.Location = new System.Drawing.Point(508, 147);
            this.btnP1Delete.Name = "btnP1Delete";
            this.btnP1Delete.Size = new System.Drawing.Size(29, 23);
            this.btnP1Delete.TabIndex = 20;
            this.btnP1Delete.Text = "X";
            this.btnP1Delete.UseVisualStyleBackColor = true;
            this.btnP1Delete.Click += new System.EventHandler(this.btnP1Delete_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(594, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "player2 words";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(398, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "player1 words";
            // 
            // lstp2
            // 
            this.lstp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lstp2.FormattingEnabled = true;
            this.lstp2.ItemHeight = 20;
            this.lstp2.Location = new System.Drawing.Point(597, 176);
            this.lstp2.Name = "lstp2";
            this.lstp2.Size = new System.Drawing.Size(133, 184);
            this.lstp2.TabIndex = 17;
            // 
            // lstP1
            // 
            this.lstP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lstP1.FormattingEnabled = true;
            this.lstP1.ItemHeight = 20;
            this.lstP1.Location = new System.Drawing.Point(401, 176);
            this.lstP1.Name = "lstP1";
            this.lstP1.Size = new System.Drawing.Size(137, 184);
            this.lstP1.TabIndex = 16;
            // 
            // lblPlayer
            // 
            this.lblPlayer.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblPlayer.Location = new System.Drawing.Point(9, 92);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(150, 24);
            this.lblPlayer.TabIndex = 23;
            this.lblPlayer.Text = "Current Player";
            this.lblPlayer.Click += new System.EventHandler(this.lblPlayer_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblTimer.Location = new System.Drawing.Point(460, 61);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(77, 25);
            this.lblTimer.TabIndex = 25;
            this.lblTimer.Text = "00:00";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(398, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "Timer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 431);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.btnCheckWin);
            this.Controls.Add(this.btnp2Delete);
            this.Controls.Add(this.btnP1Delete);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstp2);
            this.Controls.Add(this.lstP1);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblLetters);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNewWord);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstWords);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox lstWords;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtNewWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLetters;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnCheckWin;
        private System.Windows.Forms.Button btnp2Delete;
        private System.Windows.Forms.Button btnP1Delete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstp2;
        private System.Windows.Forms.ListBox lstP1;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label label3;
    }
}

