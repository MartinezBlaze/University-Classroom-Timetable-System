namespace SchedulerSchedulingSys
{
    partial class SchedulerCompletedForm
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
            this.schedulerSuccessfulNoticeLabel = new System.Windows.Forms.Label();
            this.schedulerBackToHomeButton = new System.Windows.Forms.Button();
            this.schedulerLogoutButton = new System.Windows.Forms.Button();
            this.schedulerExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // schedulerSuccessfulNoticeLabel
            // 
            this.schedulerSuccessfulNoticeLabel.AutoSize = true;
            this.schedulerSuccessfulNoticeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schedulerSuccessfulNoticeLabel.Location = new System.Drawing.Point(43, 31);
            this.schedulerSuccessfulNoticeLabel.Name = "schedulerSuccessfulNoticeLabel";
            this.schedulerSuccessfulNoticeLabel.Size = new System.Drawing.Size(209, 50);
            this.schedulerSuccessfulNoticeLabel.TabIndex = 0;
            this.schedulerSuccessfulNoticeLabel.Text = "Your booking details\r\nhave been stored!";
            // 
            // schedulerBackToHomeButton
            // 
            this.schedulerBackToHomeButton.Location = new System.Drawing.Point(93, 95);
            this.schedulerBackToHomeButton.Name = "schedulerBackToHomeButton";
            this.schedulerBackToHomeButton.Size = new System.Drawing.Size(95, 23);
            this.schedulerBackToHomeButton.TabIndex = 1;
            this.schedulerBackToHomeButton.Text = "Back to Home";
            this.schedulerBackToHomeButton.UseVisualStyleBackColor = true;
            this.schedulerBackToHomeButton.Click += new System.EventHandler(this.schedulerBackToHomeButton_Click);
            // 
            // schedulerLogoutButton
            // 
            this.schedulerLogoutButton.Location = new System.Drawing.Point(98, 134);
            this.schedulerLogoutButton.Name = "schedulerLogoutButton";
            this.schedulerLogoutButton.Size = new System.Drawing.Size(90, 23);
            this.schedulerLogoutButton.TabIndex = 2;
            this.schedulerLogoutButton.Text = "Logout";
            this.schedulerLogoutButton.UseVisualStyleBackColor = true;
            this.schedulerLogoutButton.Click += new System.EventHandler(this.schedulerLogoutButton_Click);
            // 
            // schedulerExitButton
            // 
            this.schedulerExitButton.Location = new System.Drawing.Point(98, 175);
            this.schedulerExitButton.Name = "schedulerExitButton";
            this.schedulerExitButton.Size = new System.Drawing.Size(90, 23);
            this.schedulerExitButton.TabIndex = 3;
            this.schedulerExitButton.Text = "Exit";
            this.schedulerExitButton.UseVisualStyleBackColor = true;
            this.schedulerExitButton.Click += new System.EventHandler(this.schedulerExitButton_Click);
            // 
            // SchedulerCompletedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.schedulerExitButton);
            this.Controls.Add(this.schedulerLogoutButton);
            this.Controls.Add(this.schedulerBackToHomeButton);
            this.Controls.Add(this.schedulerSuccessfulNoticeLabel);
            this.Name = "SchedulerCompletedForm";
            this.Text = "Scheduler - Completed Form";
            this.Load += new System.EventHandler(this.SchedulerCompletedForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label schedulerSuccessfulNoticeLabel;
        private System.Windows.Forms.Button schedulerBackToHomeButton;
        private System.Windows.Forms.Button schedulerLogoutButton;
        private System.Windows.Forms.Button schedulerExitButton;
    }
}