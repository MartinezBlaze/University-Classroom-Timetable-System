namespace SchedulerSchedulingSys
{
    partial class MainLoginForm
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
            this.mainLoginWelcomeLabel = new System.Windows.Forms.Label();
            this.mainLoginLoginAsGroupBox = new System.Windows.Forms.GroupBox();
            this.mainLoginSchedulerButton = new System.Windows.Forms.Button();
            this.mainLoginUserButton = new System.Windows.Forms.Button();
            this.mainLoginCloseButton = new System.Windows.Forms.Button();
            this.mainLoginLoginAsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLoginWelcomeLabel
            // 
            this.mainLoginWelcomeLabel.AutoSize = true;
            this.mainLoginWelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLoginWelcomeLabel.Location = new System.Drawing.Point(51, 34);
            this.mainLoginWelcomeLabel.Name = "mainLoginWelcomeLabel";
            this.mainLoginWelcomeLabel.Size = new System.Drawing.Size(198, 32);
            this.mainLoginWelcomeLabel.TabIndex = 0;
            this.mainLoginWelcomeLabel.Text = "Welcome to\r\nClassroom Booking System";
            this.mainLoginWelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainLoginLoginAsGroupBox
            // 
            this.mainLoginLoginAsGroupBox.Controls.Add(this.mainLoginSchedulerButton);
            this.mainLoginLoginAsGroupBox.Controls.Add(this.mainLoginUserButton);
            this.mainLoginLoginAsGroupBox.Location = new System.Drawing.Point(71, 94);
            this.mainLoginLoginAsGroupBox.Name = "mainLoginLoginAsGroupBox";
            this.mainLoginLoginAsGroupBox.Size = new System.Drawing.Size(140, 80);
            this.mainLoginLoginAsGroupBox.TabIndex = 1;
            this.mainLoginLoginAsGroupBox.TabStop = false;
            this.mainLoginLoginAsGroupBox.Text = "Login as:";
            // 
            // mainLoginSchedulerButton
            // 
            this.mainLoginSchedulerButton.Location = new System.Drawing.Point(34, 19);
            this.mainLoginSchedulerButton.Name = "mainLoginSchedulerButton";
            this.mainLoginSchedulerButton.Size = new System.Drawing.Size(75, 23);
            this.mainLoginSchedulerButton.TabIndex = 2;
            this.mainLoginSchedulerButton.Text = "Scheduler";
            this.mainLoginSchedulerButton.UseVisualStyleBackColor = true;
            this.mainLoginSchedulerButton.Click += new System.EventHandler(this.mainLoginSchedulerButton_Click);
            // 
            // mainLoginUserButton
            // 
            this.mainLoginUserButton.Location = new System.Drawing.Point(34, 48);
            this.mainLoginUserButton.Name = "mainLoginUserButton";
            this.mainLoginUserButton.Size = new System.Drawing.Size(75, 23);
            this.mainLoginUserButton.TabIndex = 4;
            this.mainLoginUserButton.Text = "User";
            this.mainLoginUserButton.UseVisualStyleBackColor = true;
            this.mainLoginUserButton.Click += new System.EventHandler(this.mainLoginUserButton_Click);
            // 
            // mainLoginCloseButton
            // 
            this.mainLoginCloseButton.Location = new System.Drawing.Point(197, 198);
            this.mainLoginCloseButton.Name = "mainLoginCloseButton";
            this.mainLoginCloseButton.Size = new System.Drawing.Size(75, 23);
            this.mainLoginCloseButton.TabIndex = 5;
            this.mainLoginCloseButton.Text = "Close";
            this.mainLoginCloseButton.UseVisualStyleBackColor = true;
            this.mainLoginCloseButton.Click += new System.EventHandler(this.mainLoginCloseButton_Click);
            // 
            // MainLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 233);
            this.Controls.Add(this.mainLoginCloseButton);
            this.Controls.Add(this.mainLoginLoginAsGroupBox);
            this.Controls.Add(this.mainLoginWelcomeLabel);
            this.Name = "MainLoginForm";
            this.Text = "Main Login Form";
            this.Load += new System.EventHandler(this.MainLoginForm_Load);
            this.mainLoginLoginAsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainLoginWelcomeLabel;
        private System.Windows.Forms.GroupBox mainLoginLoginAsGroupBox;
        private System.Windows.Forms.Button mainLoginSchedulerButton;
        private System.Windows.Forms.Button mainLoginCloseButton;
        private System.Windows.Forms.Button mainLoginUserButton;
    }
}