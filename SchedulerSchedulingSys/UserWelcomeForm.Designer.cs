namespace UserSchedulingSystem
{
    partial class UserClassroomBookingSystemForm
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
            this.userSeeTimetableButton = new System.Windows.Forms.Button();
            this.userSeeAvailableSlotsButton = new System.Windows.Forms.Button();
            this.userLogoutButton = new System.Windows.Forms.Button();
            this.userWelcomeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userSeeTimetableButton
            // 
            this.userSeeTimetableButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userSeeTimetableButton.Location = new System.Drawing.Point(167, 93);
            this.userSeeTimetableButton.Name = "userSeeTimetableButton";
            this.userSeeTimetableButton.Size = new System.Drawing.Size(154, 63);
            this.userSeeTimetableButton.TabIndex = 0;
            this.userSeeTimetableButton.Text = "See Timetable";
            this.userSeeTimetableButton.UseVisualStyleBackColor = true;
            this.userSeeTimetableButton.Click += new System.EventHandler(this.userSeeTimetableButton_Click);
            // 
            // userSeeAvailableSlotsButton
            // 
            this.userSeeAvailableSlotsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userSeeAvailableSlotsButton.Location = new System.Drawing.Point(167, 184);
            this.userSeeAvailableSlotsButton.Name = "userSeeAvailableSlotsButton";
            this.userSeeAvailableSlotsButton.Size = new System.Drawing.Size(154, 63);
            this.userSeeAvailableSlotsButton.TabIndex = 1;
            this.userSeeAvailableSlotsButton.Text = "See Available Slots";
            this.userSeeAvailableSlotsButton.UseVisualStyleBackColor = true;
            this.userSeeAvailableSlotsButton.Click += new System.EventHandler(this.userSeeAvailableSlotsButton_Click);
            // 
            // userLogoutButton
            // 
            this.userLogoutButton.Location = new System.Drawing.Point(431, 304);
            this.userLogoutButton.Name = "userLogoutButton";
            this.userLogoutButton.Size = new System.Drawing.Size(75, 23);
            this.userLogoutButton.TabIndex = 2;
            this.userLogoutButton.Text = "Logout";
            this.userLogoutButton.UseVisualStyleBackColor = true;
            this.userLogoutButton.Click += new System.EventHandler(this.userLogoutButton_Click);
            // 
            // userWelcomeLabel
            // 
            this.userWelcomeLabel.AutoSize = true;
            this.userWelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userWelcomeLabel.Location = new System.Drawing.Point(12, 31);
            this.userWelcomeLabel.Name = "userWelcomeLabel";
            this.userWelcomeLabel.Size = new System.Drawing.Size(478, 24);
            this.userWelcomeLabel.TabIndex = 3;
            this.userWelcomeLabel.Text = "WELCOME TO CLASSROOM BOOKING SYSTEM!";
            // 
            // UserClassroomBookingSystemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 339);
            this.Controls.Add(this.userWelcomeLabel);
            this.Controls.Add(this.userLogoutButton);
            this.Controls.Add(this.userSeeAvailableSlotsButton);
            this.Controls.Add(this.userSeeTimetableButton);
            this.Name = "UserClassroomBookingSystemForm";
            this.Text = "User - CLASSROOM BOOKING SYSTEM";
            this.Load += new System.EventHandler(this.UserClassroomBookingSystemForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button userSeeTimetableButton;
        private System.Windows.Forms.Button userSeeAvailableSlotsButton;
        private System.Windows.Forms.Button userLogoutButton;
        private System.Windows.Forms.Label userWelcomeLabel;
    }
}