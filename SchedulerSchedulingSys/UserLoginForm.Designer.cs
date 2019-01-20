using System;

namespace UserSchedulingSystem
{
    partial class UserLoginForm
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
            this.userUsernameTextBox = new System.Windows.Forms.TextBox();
            this.userPasswordTextBox = new System.Windows.Forms.TextBox();
            this.userLoginLabel = new System.Windows.Forms.Label();
            this.userUsernameLabel = new System.Windows.Forms.Label();
            this.userPasswordLabel = new System.Windows.Forms.Label();
            this.userLoginButton = new System.Windows.Forms.Button();
            this.userBackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userUsernameTextBox
            // 
            this.userUsernameTextBox.Location = new System.Drawing.Point(117, 107);
            this.userUsernameTextBox.Name = "userUsernameTextBox";
            this.userUsernameTextBox.Size = new System.Drawing.Size(145, 20);
            this.userUsernameTextBox.TabIndex = 0;
            // 
            // userPasswordTextBox
            // 
            this.userPasswordTextBox.Location = new System.Drawing.Point(117, 133);
            this.userPasswordTextBox.Name = "userPasswordTextBox";
            this.userPasswordTextBox.PasswordChar = '*';
            this.userPasswordTextBox.Size = new System.Drawing.Size(145, 20);
            this.userPasswordTextBox.TabIndex = 1;
            // 
            // userLoginLabel
            // 
            this.userLoginLabel.AutoSize = true;
            this.userLoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLoginLabel.Location = new System.Drawing.Point(83, 39);
            this.userLoginLabel.Name = "userLoginLabel";
            this.userLoginLabel.Size = new System.Drawing.Size(155, 31);
            this.userLoginLabel.TabIndex = 2;
            this.userLoginLabel.Text = "User Login";
            // 
            // userUsernameLabel
            // 
            this.userUsernameLabel.AutoSize = true;
            this.userUsernameLabel.Location = new System.Drawing.Point(41, 107);
            this.userUsernameLabel.Name = "userUsernameLabel";
            this.userUsernameLabel.Size = new System.Drawing.Size(58, 13);
            this.userUsernameLabel.TabIndex = 3;
            this.userUsernameLabel.Text = "Username:";
            // 
            // userPasswordLabel
            // 
            this.userPasswordLabel.AutoSize = true;
            this.userPasswordLabel.Location = new System.Drawing.Point(41, 133);
            this.userPasswordLabel.Name = "userPasswordLabel";
            this.userPasswordLabel.Size = new System.Drawing.Size(56, 13);
            this.userPasswordLabel.TabIndex = 4;
            this.userPasswordLabel.Text = "Password:";
            // 
            // userLoginButton
            // 
            this.userLoginButton.Location = new System.Drawing.Point(117, 169);
            this.userLoginButton.Name = "userLoginButton";
            this.userLoginButton.Size = new System.Drawing.Size(75, 23);
            this.userLoginButton.TabIndex = 5;
            this.userLoginButton.Text = "Login";
            this.userLoginButton.UseVisualStyleBackColor = true;
            this.userLoginButton.Click += new System.EventHandler(this.UserLoginButton_Click_1);
            // 
            // userBackButton
            // 
            this.userBackButton.Location = new System.Drawing.Point(12, 216);
            this.userBackButton.Name = "userBackButton";
            this.userBackButton.Size = new System.Drawing.Size(75, 23);
            this.userBackButton.TabIndex = 6;
            this.userBackButton.Text = "<< Back";
            this.userBackButton.UseVisualStyleBackColor = true;
            this.userBackButton.Click += new System.EventHandler(this.userBackButton_Click_1);
            // 
            // UserLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 250);
            this.Controls.Add(this.userBackButton);
            this.Controls.Add(this.userLoginButton);
            this.Controls.Add(this.userPasswordLabel);
            this.Controls.Add(this.userUsernameLabel);
            this.Controls.Add(this.userLoginLabel);
            this.Controls.Add(this.userPasswordTextBox);
            this.Controls.Add(this.userUsernameTextBox);
            this.Name = "UserLoginForm";
            this.Text = "User - Login Form";
            this.Load += new System.EventHandler(this.UserLoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void userBackButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TextBox userUsernameTextBox;
        private System.Windows.Forms.TextBox userPasswordTextBox;
        private System.Windows.Forms.Label userLoginLabel;
        private System.Windows.Forms.Label userUsernameLabel;
        private System.Windows.Forms.Label userPasswordLabel;
        private System.Windows.Forms.Button userLoginButton;
        private System.Windows.Forms.Button userBackButton;
    }
}

