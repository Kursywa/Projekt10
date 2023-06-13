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
            PassBtn = new Button();
            Opponent_label = new Label();
            Player_label = new Label();
            OpponentDeckPictureBox = new PictureBox();
            PlayerDeckPictureBox = new PictureBox();
            OpponentCard = new PictureBox();
            PlayerCard = new PictureBox();
            textBox1 = new TextBox();
            OpponentNumberOfCards = new Label();
            PlayerNumberOfCards = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OpponentDeckPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PlayerDeckPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OpponentCard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PlayerCard).BeginInit();
            SuspendLayout();
            // 
            // WarRadioBtn
            // 
            WarRadioBtn.AutoSize = true;
            WarRadioBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            WarRadioBtn.Location = new Point(6, 27);
            WarRadioBtn.Name = "WarRadioBtn";
            WarRadioBtn.Size = new Size(136, 32);
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
            groupBox1.Location = new Point(605, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(183, 156);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Choose the game";
            // 
            // StartBtn
            // 
            StartBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            StartBtn.Location = new Point(39, 115);
            StartBtn.Name = "StartBtn";
            StartBtn.Size = new Size(114, 36);
            StartBtn.TabIndex = 2;
            StartBtn.Text = "START";
            StartBtn.UseVisualStyleBackColor = true;
            StartBtn.Click += StartBtn_Click;
            // 
            // BlackjackRadioBtn
            // 
            BlackjackRadioBtn.AutoSize = true;
            BlackjackRadioBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BlackjackRadioBtn.Location = new Point(6, 64);
            BlackjackRadioBtn.Name = "BlackjackRadioBtn";
            BlackjackRadioBtn.Size = new Size(136, 32);
            BlackjackRadioBtn.TabIndex = 1;
            BlackjackRadioBtn.TabStop = true;
            BlackjackRadioBtn.Text = "BLACKJACK";
            BlackjackRadioBtn.UseVisualStyleBackColor = true;
            // 
            // DrawBtn
            // 
            DrawBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DrawBtn.Location = new Point(627, 243);
            DrawBtn.Name = "DrawBtn";
            DrawBtn.Size = new Size(131, 48);
            DrawBtn.TabIndex = 2;
            DrawBtn.Text = "DRAW";
            DrawBtn.UseVisualStyleBackColor = true;
            DrawBtn.Visible = false;
            DrawBtn.Click += DrawBtn_Click;
            // 
            // StopBtn
            // 
            StopBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            StopBtn.Location = new Point(627, 379);
            StopBtn.Name = "StopBtn";
            StopBtn.Size = new Size(131, 49);
            StopBtn.TabIndex = 3;
            StopBtn.Text = "STOP";
            StopBtn.UseVisualStyleBackColor = true;
            StopBtn.Visible = false;
            StopBtn.Click += StopBtn_Click;
            // 
            // PassBtn
            // 
            PassBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PassBtn.Location = new Point(627, 312);
            PassBtn.Name = "PassBtn";
            PassBtn.Size = new Size(131, 48);
            PassBtn.TabIndex = 4;
            PassBtn.Text = "PASS";
            PassBtn.UseVisualStyleBackColor = true;
            PassBtn.Visible = false;
            PassBtn.Click += StayBtn_Click;
            // 
            // Opponent_label
            // 
            Opponent_label.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Opponent_label.AutoSize = true;
            Opponent_label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Opponent_label.Location = new Point(249, 39);
            Opponent_label.Name = "Opponent_label";
            Opponent_label.Size = new Size(152, 28);
            Opponent_label.TabIndex = 6;
            Opponent_label.Text = "Opponent_label";
            // 
            // Player_label
            // 
            Player_label.AutoSize = true;
            Player_label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Player_label.Location = new Point(249, 280);
            Player_label.Name = "Player_label";
            Player_label.Size = new Size(115, 28);
            Player_label.TabIndex = 7;
            Player_label.Text = "Player_label";
            // 
            // OpponentDeckPictureBox
            // 
            OpponentDeckPictureBox.Image = Properties.Resources.back;
            OpponentDeckPictureBox.Location = new Point(522, 26);
            OpponentDeckPictureBox.Margin = new Padding(3, 4, 3, 4);
            OpponentDeckPictureBox.Name = "OpponentDeckPictureBox";
            OpponentDeckPictureBox.Size = new Size(60, 92);
            OpponentDeckPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            OpponentDeckPictureBox.TabIndex = 9;
            OpponentDeckPictureBox.TabStop = false;
            // 
            // PlayerDeckPictureBox
            // 
            PlayerDeckPictureBox.Image = Properties.Resources.back;
            PlayerDeckPictureBox.Location = new Point(522, 268);
            PlayerDeckPictureBox.Margin = new Padding(3, 4, 3, 4);
            PlayerDeckPictureBox.Name = "PlayerDeckPictureBox";
            PlayerDeckPictureBox.Size = new Size(60, 92);
            PlayerDeckPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            PlayerDeckPictureBox.TabIndex = 10;
            PlayerDeckPictureBox.TabStop = false;
            // 
            // OpponentCard
            // 
            OpponentCard.Image = Properties.Resources.empty;
            OpponentCard.Location = new Point(249, 71);
            OpponentCard.Margin = new Padding(3, 4, 3, 4);
            OpponentCard.Name = "OpponentCard";
            OpponentCard.Size = new Size(60, 92);
            OpponentCard.SizeMode = PictureBoxSizeMode.AutoSize;
            OpponentCard.TabIndex = 12;
            OpponentCard.TabStop = false;
            // 
            // PlayerCard
            // 
            PlayerCard.Image = Properties.Resources.empty;
            PlayerCard.Location = new Point(249, 312);
            PlayerCard.Margin = new Padding(3, 4, 3, 4);
            PlayerCard.Name = "PlayerCard";
            PlayerCard.Size = new Size(60, 92);
            PlayerCard.SizeMode = PictureBoxSizeMode.AutoSize;
            PlayerCard.TabIndex = 13;
            PlayerCard.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(12, 206);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(90, 60);
            textBox1.TabIndex = 15;
            textBox1.Text = "Number of cards";
            // 
            // OpponentNumberOfCards
            // 
            OpponentNumberOfCards.AutoSize = true;
            OpponentNumberOfCards.Location = new Point(142, 169);
            OpponentNumberOfCards.Name = "OpponentNumberOfCards";
            OpponentNumberOfCards.Size = new Size(0, 20);
            OpponentNumberOfCards.TabIndex = 16;
            // 
            // PlayerNumberOfCards
            // 
            PlayerNumberOfCards.AutoSize = true;
            PlayerNumberOfCards.Location = new Point(140, 282);
            PlayerNumberOfCards.Name = "PlayerNumberOfCards";
            PlayerNumberOfCards.Size = new Size(0, 20);
            PlayerNumberOfCards.TabIndex = 17;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(PlayerNumberOfCards);
            Controls.Add(OpponentNumberOfCards);
            Controls.Add(textBox1);
            Controls.Add(PlayerCard);
            Controls.Add(OpponentCard);
            Controls.Add(PlayerDeckPictureBox);
            Controls.Add(OpponentDeckPictureBox);
            Controls.Add(Player_label);
            Controls.Add(Opponent_label);
            Controls.Add(PassBtn);
            Controls.Add(StopBtn);
            Controls.Add(DrawBtn);
            Controls.Add(groupBox1);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)OpponentDeckPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)PlayerDeckPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)OpponentCard).EndInit();
            ((System.ComponentModel.ISupportInitialize)PlayerCard).EndInit();
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
        private Button PassBtn;
        private Label Opponent_label;
        private Label Player_label;
        private PictureBox OpponentDeckPictureBox;
        private PictureBox PlayerDeckPictureBox;
        private PictureBox OpponentCard;
        private PictureBox PlayerCard;
        private TextBox textBox1;
        private Label OpponentNumberOfCards;
        private Label PlayerNumberOfCards;
    }
}