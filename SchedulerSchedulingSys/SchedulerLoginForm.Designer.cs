namespace SchedulerSchedulingSys
{
    partial class SchedulerLoginForm
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
            this.schedulerLoginLabel = new System.Windows.Forms.Label();
            this.shedulerUsernameLabel = new System.Windows.Forms.Label();
            this.schedulerPasswordLabel = new System.Windows.Forms.Label();
            this.schedulerUsernameTextBox = new System.Windows.Forms.TextBox();
            this.schedulerPasswordTextBox = new System.Windows.Forms.TextBox();
            this.SchedulerLoginButton = new System.Windows.Forms.Button();
            this.schedulerBackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // schedulerLoginLabel
            // 
            this.schedulerLoginLabel.AutoSize = true;
            this.schedulerLoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schedulerLoginLabel.Location = new System.Drawing.Point(35, 31);
            this.schedulerLoginLabel.Name = "schedulerLoginLabel";
            this.schedulerLoginLabel.Size = new System.Drawing.Size(224, 31);
            this.schedulerLoginLabel.TabIndex = 0;
            this.schedulerLoginLabel.Text = "Scheduler Login";
            // 
            // shedulerUsernameLabel
            // 
            this.shedulerUsernameLabel.AutoSize = true;
            this.shedulerUsernameLabel.Location = new System.Drawing.Point(52, 87);
            this.shedulerUsernameLabel.Name = "shedulerUsernameLabel";
            this.shedulerUsernameLabel.Size = new System.Drawing.Size(58, 13);
            this.shedulerUsernameLabel.TabIndex = 1;
            this.shedulerUsernameLabel.Text = "Username:";
            // 
            // schedulerPasswordLabel
            // 
            this.schedulerPasswordLabel.AutoSize = true;
            this.schedulerPasswordLabel.Location = new System.Drawing.Point(52, 125);
            this.schedulerPasswordLabel.Name = "schedulerPasswordLabel";
            this.schedulerPasswordLabel.Size = new System.Drawing.Size(56, 13);
            this.schedulerPasswordLabel.TabIndex = 2;
            this.schedulerPasswordLabel.Text = "Password:";
            // 
            // schedulerUsernameTextBox
            // 
            this.schedulerUsernameTextBox.Location = new System.Drawing.Point(121, 84);
            this.schedulerUsernameTextBox.Name = "schedulerUsernameTextBox";
            this.schedulerUsernameTextBox.Size = new System.Drawing.Size(100, 20);
            this.schedulerUsernameTextBox.TabIndex = 3;
            this.schedulerUsernameTextBox.TextChanged += new System.EventHandler(this.schedulerUsernameTextBox_TextChanged);
            // 
            // schedulerPasswordTextBox
            // 
            this.schedulerPasswordTextBox.Location = new System.Drawing.Point(121, 122);
            this.schedulerPasswordTextBox.Name = "schedulerPasswordTextBox";
            this.schedulerPasswordTextBox.PasswordChar = '*';
            this.schedulerPasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.schedulerPasswordTextBox.TabIndex = 4;
            // 
            // SchedulerLoginButton
            // 
            this.SchedulerLoginButton.Location = new System.Drawing.Point(105, 164);
            this.SchedulerLoginButton.Name = "SchedulerLoginButton";
            this.SchedulerLoginButton.Size = new System.Drawing.Size(75, 23);
            this.SchedulerLoginButton.TabIndex = 5;
            this.SchedulerLoginButton.Text = "Login";
            this.SchedulerLoginButton.UseVisualStyleBackColor = true;
            this.SchedulerLoginButton.Click += new System.EventHandler(this.schedulerLoginButton_Click);
            // 
            // schedulerBackButton
            // 
            this.schedulerBackButton.Location = new System.Drawing.Point(12, 226);
            this.schedulerBackButton.Name = "schedulerBackButton";
            this.schedulerBackButton.Size = new System.Drawing.Size(75, 23);
            this.schedulerBackButton.TabIndex = 6;
            this.schedulerBackButton.Text = "<< Back";
            this.schedulerBackButton.UseVisualStyleBackColor = true;
            this.schedulerBackButton.Click += new System.EventHandler(this.schedulerBackButton_Click);
            // 
            // SchedulerLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.schedulerBackButton);
            this.Controls.Add(this.SchedulerLoginButton);
            this.Controls.Add(this.schedulerPasswordTextBox);
            this.Controls.Add(this.schedulerUsernameTextBox);
            this.Controls.Add(this.schedulerPasswordLabel);
            this.Controls.Add(this.shedulerUsernameLabel);
            this.Controls.Add(this.schedulerLoginLabel);
            this.Name = "SchedulerLoginForm";
            this.Text = "Scheduler - Login Form";
            this.Load += new System.EventHandler(this.SchedulerLoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label schedulerLoginLabel;
        private System.Windows.Forms.Label shedulerUsernameLabel;
        private System.Windows.Forms.Label schedulerPasswordLabel;
        private System.Windows.Forms.TextBox schedulerUsernameTextBox;
        private System.Windows.Forms.TextBox schedulerPasswordTextBox;
        private System.Windows.Forms.Button SchedulerLoginButton;
        private System.Windows.Forms.Button schedulerBackButton;
    }
}

