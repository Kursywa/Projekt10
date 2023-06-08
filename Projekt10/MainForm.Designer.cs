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
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // WarRadioBtn
            // 
            WarRadioBtn.AutoSize = true;
            WarRadioBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            WarRadioBtn.Location = new Point(6, 26);
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
            StartBtn.Location = new Point(39, 114);
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
            // StayBtn
            // 
            StayBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            StayBtn.Location = new Point(627, 312);
            StayBtn.Name = "StayBtn";
            StayBtn.Size = new Size(131, 48);
            StayBtn.TabIndex = 4;
            StayBtn.Text = "STAY";
            StayBtn.UseVisualStyleBackColor = true;
            StayBtn.Visible = false;
            StayBtn.Click += StayBtn_Click;
            // 
            // ResumeBtn
            // 
            ResumeBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ResumeBtn.Location = new Point(627, 379);
            ResumeBtn.Name = "ResumeBtn";
            ResumeBtn.Size = new Size(131, 49);
            ResumeBtn.TabIndex = 5;
            ResumeBtn.Text = "RESUME";
            ResumeBtn.UseVisualStyleBackColor = true;
            ResumeBtn.Visible = false;
            ResumeBtn.Click += ResumeBtn_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ResumeBtn);
            Controls.Add(StayBtn);
            Controls.Add(StopBtn);
            Controls.Add(DrawBtn);
            Controls.Add(groupBox1);
            Name = "MainForm";
            Text = "MainForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
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
    }
}