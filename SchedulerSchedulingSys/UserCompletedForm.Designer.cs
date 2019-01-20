namespace UserSchedulingSystem
{
    partial class UserCompletedForm
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
            this.userSuccessfulNoticeLabel = new System.Windows.Forms.Label();
            this.userBackToHomeButton = new System.Windows.Forms.Button();
            this.userLogoutButton = new System.Windows.Forms.Button();
            this.userExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userSuccessfulNoticeLabel
            // 
            this.userSuccessfulNoticeLabel.AutoSize = true;
            this.userSuccessfulNoticeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userSuccessfulNoticeLabel.Location = new System.Drawing.Point(40, 66);
            this.userSuccessfulNoticeLabel.Name = "userSuccessfulNoticeLabel";
            this.userSuccessfulNoticeLabel.Size = new System.Drawing.Size(280, 66);
            this.userSuccessfulNoticeLabel.TabIndex = 0;
            this.userSuccessfulNoticeLabel.Text = "Your booking details\r\n have been stored!";
            // 
            // userBackToHomeButton
            // 
            this.userBackToHomeButton.Location = new System.Drawing.Point(123, 158);
            this.userBackToHomeButton.Name = "userBackToHomeButton";
            this.userBackToHomeButton.Size = new System.Drawing.Size(94, 31);
            this.userBackToHomeButton.TabIndex = 1;
            this.userBackToHomeButton.Text = "Back to Home";
            this.userBackToHomeButton.UseVisualStyleBackColor = true;
            this.userBackToHomeButton.Click += new System.EventHandler(this.userBackToHomeButton_Click);
            // 
            // userLogoutButton
            // 
            this.userLogoutButton.Location = new System.Drawing.Point(122, 206);
            this.userLogoutButton.Name = "userLogoutButton";
            this.userLogoutButton.Size = new System.Drawing.Size(93, 31);
            this.userLogoutButton.TabIndex = 2;
            this.userLogoutButton.Text = "Logout";
            this.userLogoutButton.UseVisualStyleBackColor = true;
            this.userLogoutButton.Click += new System.EventHandler(this.userLogoutButton_Click);
            // 
            // userExitButton
            // 
            this.userExitButton.Location = new System.Drawing.Point(123, 258);
            this.userExitButton.Name = "userExitButton";
            this.userExitButton.Size = new System.Drawing.Size(93, 31);
            this.userExitButton.TabIndex = 3;
            this.userExitButton.Text = "Exit";
            this.userExitButton.UseVisualStyleBackColor = true;
            this.userExitButton.Click += new System.EventHandler(this.userExitButton_Click);
            // 
            // UserCompletedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 312);
            this.Controls.Add(this.userExitButton);
            this.Controls.Add(this.userLogoutButton);
            this.Controls.Add(this.userBackToHomeButton);
            this.Controls.Add(this.userSuccessfulNoticeLabel);
            this.Name = "UserCompletedForm";
            this.Text = "User - Completed Form";
            this.Load += new System.EventHandler(this.UserCompletedForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userSuccessfulNoticeLabel;
        private System.Windows.Forms.Button userBackToHomeButton;
        private System.Windows.Forms.Button userLogoutButton;
        private System.Windows.Forms.Button userExitButton;
    }
}