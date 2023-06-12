namespace Projekt10
{
    partial class MainForm
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
            WarRadioBtn = new RadioButton();
            groupBox1 = new GroupBox();
            StartBtn = new Button();
            BlackjackRadioBtn = new RadioButton();
            DrawBtn = new Button();
            StopBtn = new Button();
            StayBtn = new Button();
            ResumeBtn = new Button();
            Opponent_label = new Label();
            Player_label = new Label();
            Verdict = new Label();
            OpponentDeckPictureBox = new PictureBox();
            PlayerDeckPictureBox = new PictureBox();
            ScoreLabel = new Label();
            OpponentCard = new PictureBox();
            PlayerCard = new PictureBox();
            BackgroundpictureBox = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OpponentDeckPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PlayerDeckPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OpponentCard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PlayerCard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BackgroundpictureBox).BeginInit();
            SuspendLayout();
            // 
            // WarRadioBtn
            // 
            WarRadioBtn.AutoSize = true;
            WarRadioBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            WarRadioBtn.Location = new Point(5, 20);
            WarRadioBtn.Margin = new Padding(3, 2, 3, 2);
            WarRadioBtn.Name = "WarRadioBtn";
            WarRadioBtn.Size = new Size(109, 25);
            WarRadioBtn.TabIndex = 0;
            WarRadioBtn.TabStop = true;
            WarRadioBtn.Text = "WAR GAME";
            WarRadioBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(StartBtn);
            groupBox1.Controls.Add(BlackjackRadioBtn);
            groupBox1.Controls.Add(WarRadioBtn);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(529, 9);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(160, 117);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Choose the game";
            // 
            // StartBtn
            // 
            StartBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            StartBtn.Location = new Point(34, 86);
            StartBtn.Margin = new Padding(3, 2, 3, 2);
            StartBtn.Name = "StartBtn";
            StartBtn.Size = new Size(100, 27);
            StartBtn.TabIndex = 2;
            StartBtn.Text = "START";
            StartBtn.UseVisualStyleBackColor = true;
            StartBtn.Click += StartBtn_Click;
            // 
            // BlackjackRadioBtn
            // 
            BlackjackRadioBtn.AutoSize = true;
            BlackjackRadioBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BlackjackRadioBtn.Location = new Point(5, 48);
            BlackjackRadioBtn.Margin = new Padding(3, 2, 3, 2);
            BlackjackRadioBtn.Name = "BlackjackRadioBtn";
            BlackjackRadioBtn.Size = new Size(110, 25);
            BlackjackRadioBtn.TabIndex = 1;
            BlackjackRadioBtn.TabStop = true;
            BlackjackRadioBtn.Text = "BLACKJACK";
            BlackjackRadioBtn.UseVisualStyleBackColor = true;
            // 
            // DrawBtn
            // 
            DrawBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DrawBtn.Location = new Point(549, 182);
            DrawBtn.Margin = new Padding(3, 2, 3, 2);
            DrawBtn.Name = "DrawBtn";
            DrawBtn.Size = new Size(115, 36);
            DrawBtn.TabIndex = 2;
            DrawBtn.Text = "DRAW";
            DrawBtn.UseVisualStyleBackColor = true;
            DrawBtn.Visible = false;
            DrawBtn.Click += DrawBtn_Click;
            // 
            // StopBtn
            // 
            StopBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            StopBtn.Location = new Point(549, 284);
            StopBtn.Margin = new Padding(3, 2, 3, 2);
            StopBtn.Name = "StopBtn";
            StopBtn.Size = new Size(115, 37);
            StopBtn.TabIndex = 3;
            StopBtn.Text = "STOP";
            StopBtn.UseVisualStyleBackColor = true;
            StopBtn.Visible = false;
            StopBtn.Click += StopBtn_Click;
            // 
            // StayBtn
            // 
            StayBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            StayBtn.Location = new Point(549, 234);
            StayBtn.Margin = new Padding(3, 2, 3, 2);
            StayBtn.Name = "StayBtn";
            StayBtn.Size = new Size(115, 36);
            StayBtn.TabIndex = 4;
            StayBtn.Text = "STAY";
            StayBtn.UseVisualStyleBackColor = true;
            StayBtn.Visible = false;
            StayBtn.Click += StayBtn_Click;
            // 
            // ResumeBtn
            // 
            ResumeBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ResumeBtn.Location = new Point(549, 284);
            ResumeBtn.Margin = new Padding(3, 2, 3, 2);
            ResumeBtn.Name = "ResumeBtn";
            ResumeBtn.Size = new Size(115, 37);
            ResumeBtn.TabIndex = 5;
            ResumeBtn.Text = "RESUME";
            ResumeBtn.UseVisualStyleBackColor = true;
            ResumeBtn.Visible = false;
            ResumeBtn.Click += ResumeBtn_Click;
            // 
            // Opponent_label
            // 
            Opponent_label.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Opponent_label.AutoSize = true;
            Opponent_label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Opponent_label.Location = new Point(218, 29);
            Opponent_label.Name = "Opponent_label";
            Opponent_label.Size = new Size(120, 21);
            Opponent_label.TabIndex = 6;
            Opponent_label.Text = "Opponent_label";
            // 
            // Player_label
            // 
            Player_label.AutoSize = true;
            Player_label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Player_label.Location = new Point(218, 197);
            Player_label.Name = "Player_label";
            Player_label.Size = new Size(93, 21);
            Player_label.TabIndex = 7;
            Player_label.Text = "Player_label";
            // 
            // Verdict
            // 
            Verdict.AutoSize = true;
            Verdict.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Verdict.Location = new Point(35, 143);
            Verdict.Name = "Verdict";
            Verdict.Size = new Size(68, 21);
            Verdict.TabIndex = 8;
            Verdict.Text = "Werdykt";
            // 
            // OpponentDeckPictureBox
            // 
            OpponentDeckPictureBox.Image = Properties.Resources.back;
            OpponentDeckPictureBox.Location = new Point(35, 34);
            OpponentDeckPictureBox.Name = "OpponentDeckPictureBox";
            OpponentDeckPictureBox.Size = new Size(60, 92);
            OpponentDeckPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            OpponentDeckPictureBox.TabIndex = 9;
            OpponentDeckPictureBox.TabStop = false;
            // 
            // PlayerDeckPictureBox
            // 
            PlayerDeckPictureBox.Image = Properties.Resources.back;
            PlayerDeckPictureBox.Location = new Point(35, 210);
            PlayerDeckPictureBox.Name = "PlayerDeckPictureBox";
            PlayerDeckPictureBox.Size = new Size(60, 92);
            PlayerDeckPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            PlayerDeckPictureBox.TabIndex = 10;
            PlayerDeckPictureBox.TabStop = false;
            // 
            // ScoreLabel
            // 
            ScoreLabel.AutoSize = true;
            ScoreLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ScoreLabel.Location = new Point(52, 170);
            ScoreLabel.Name = "ScoreLabel";
            ScoreLabel.Size = new Size(31, 21);
            ScoreLabel.TabIndex = 11;
            ScoreLabel.Text = "0:0";
            // 
            // OpponentCard
            // 
            OpponentCard.Image = Properties.Resources.empty;
            OpponentCard.Location = new Point(218, 53);
            OpponentCard.Name = "OpponentCard";
            OpponentCard.Size = new Size(60, 92);
            OpponentCard.SizeMode = PictureBoxSizeMode.AutoSize;
            OpponentCard.TabIndex = 12;
            OpponentCard.TabStop = false;
            // 
            // PlayerCard
            // 
            PlayerCard.Image = Properties.Resources.empty;
            PlayerCard.Location = new Point(218, 221);
            PlayerCard.Name = "PlayerCard";
            PlayerCard.Size = new Size(60, 92);
            PlayerCard.SizeMode = PictureBoxSizeMode.AutoSize;
            PlayerCard.TabIndex = 13;
            PlayerCard.TabStop = false;
            // 
            // BackgroundpictureBox
            // 
            BackgroundpictureBox.Location = new Point(12, 9);
            BackgroundpictureBox.Name = "BackgroundpictureBox";
            BackgroundpictureBox.Size = new Size(511, 317);
            BackgroundpictureBox.TabIndex = 14;
            BackgroundpictureBox.TabStop = false;
            BackgroundpictureBox.Visible = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(PlayerCard);
            Controls.Add(OpponentCard);
            Controls.Add(ScoreLabel);
            Controls.Add(PlayerDeckPictureBox);
            Controls.Add(OpponentDeckPictureBox);
            Controls.Add(Verdict);
            Controls.Add(Player_label);
            Controls.Add(Opponent_label);
            Controls.Add(ResumeBtn);
            Controls.Add(StayBtn);
            Controls.Add(StopBtn);
            Controls.Add(DrawBtn);
            Controls.Add(groupBox1);
            Controls.Add(BackgroundpictureBox);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)OpponentDeckPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)PlayerDeckPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)OpponentCard).EndInit();
            ((System.ComponentModel.ISupportInitialize)PlayerCard).EndInit();
            ((System.ComponentModel.ISupportInitialize)BackgroundpictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton WarRadioBtn;
        private GroupBox groupBox1;
        private RadioButton BlackjackRadioBtn;
        private Button StartBtn;
        private Button DrawBtn;
        private Button StopBtn;
        private Button StayBtn;
        private Button ResumeBtn;
        private Label Opponent_label;
        private Label Player_label;
        private Label Verdict;
        private PictureBox OpponentDeckPictureBox;
        private PictureBox PlayerDeckPictureBox;
        private Label ScoreLabel;
        private PictureBox OpponentCard;
        private PictureBox PlayerCard;
        private PictureBox BackgroundpictureBox;
    }
}