namespace SchedulerSchedulingSys
{
    partial class SchedulerMakeScheduleForm
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
            this.schedulerMakeScheduleLabel = new System.Windows.Forms.Label();
            this.schedulerLecturerLabel = new System.Windows.Forms.Label();
            this.schedulerLocationLabel = new System.Windows.Forms.Label();
            this.schedulerCourseLabel = new System.Windows.Forms.Label();
            this.schedulerDateLabel = new System.Windows.Forms.Label();
            this.schedulerSubmitButton = new System.Windows.Forms.Button();
            this.schedulerBackButton = new System.Windows.Forms.Button();
            this.schedulerLecturerComboBox = new System.Windows.Forms.ComboBox();
            this.schedulerLocationComboBox = new System.Windows.Forms.ComboBox();
            this.schedulerCourseComboBox = new System.Windows.Forms.ComboBox();
            this.schedulerDateComboBox = new System.Windows.Forms.ComboBox();
            this.schedulerTimeLabel = new System.Windows.Forms.Label();
            this.schedulerTimeComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // schedulerMakeScheduleLabel
            // 
            this.schedulerMakeScheduleLabel.AutoSize = true;
            this.schedulerMakeScheduleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schedulerMakeScheduleLabel.Location = new System.Drawing.Point(120, 20);
            this.schedulerMakeScheduleLabel.Name = "schedulerMakeScheduleLabel";
            this.schedulerMakeScheduleLabel.Size = new System.Drawing.Size(95, 13);
            this.schedulerMakeScheduleLabel.TabIndex = 0;
            this.schedulerMakeScheduleLabel.Text = "Make Schedule";
            // 
            // schedulerLecturerLabel
            // 
            this.schedulerLecturerLabel.AutoSize = true;
            this.schedulerLecturerLabel.Location = new System.Drawing.Point(37, 52);
            this.schedulerLecturerLabel.Name = "schedulerLecturerLabel";
            this.schedulerLecturerLabel.Size = new System.Drawing.Size(49, 13);
            this.schedulerLecturerLabel.TabIndex = 1;
            this.schedulerLecturerLabel.Text = "Lecturer:";
            // 
            // schedulerLocationLabel
            // 
            this.schedulerLocationLabel.AutoSize = true;
            this.schedulerLocationLabel.Location = new System.Drawing.Point(37, 88);
            this.schedulerLocationLabel.Name = "schedulerLocationLabel";
            this.schedulerLocationLabel.Size = new System.Drawing.Size(51, 13);
            this.schedulerLocationLabel.TabIndex = 2;
            this.schedulerLocationLabel.Text = "Location:";
            // 
            // schedulerCourseLabel
            // 
            this.schedulerCourseLabel.AutoSize = true;
            this.schedulerCourseLabel.Location = new System.Drawing.Point(37, 123);
            this.schedulerCourseLabel.Name = "schedulerCourseLabel";
            this.schedulerCourseLabel.Size = new System.Drawing.Size(43, 13);
            this.schedulerCourseLabel.TabIndex = 3;
            this.schedulerCourseLabel.Text = "Course:";
            // 
            // schedulerDateLabel
            // 
            this.schedulerDateLabel.AutoSize = true;
            this.schedulerDateLabel.Location = new System.Drawing.Point(37, 155);
            this.schedulerDateLabel.Name = "schedulerDateLabel";
            this.schedulerDateLabel.Size = new System.Drawing.Size(33, 13);
            this.schedulerDateLabel.TabIndex = 4;
            this.schedulerDateLabel.Text = "Date:";
            // 
            // schedulerSubmitButton
            // 
            this.schedulerSubmitButton.Location = new System.Drawing.Point(241, 227);
            this.schedulerSubmitButton.Name = "schedulerSubmitButton";
            this.schedulerSubmitButton.Size = new System.Drawing.Size(75, 23);
            this.schedulerSubmitButton.TabIndex = 5;
            this.schedulerSubmitButton.Text = "Submit";
            this.schedulerSubmitButton.UseVisualStyleBackColor = true;
            this.schedulerSubmitButton.Click += new System.EventHandler(this.schedulerSubmitButton_Click);
            // 
            // schedulerBackButton
            // 
            this.schedulerBackButton.Location = new System.Drawing.Point(12, 253);
            this.schedulerBackButton.Name = "schedulerBackButton";
            this.schedulerBackButton.Size = new System.Drawing.Size(75, 23);
            this.schedulerBackButton.TabIndex = 6;
            this.schedulerBackButton.Text = "<< Back";
            this.schedulerBackButton.UseVisualStyleBackColor = true;
            this.schedulerBackButton.Click += new System.EventHandler(this.schedulerBackButton_Click);
            // 
            // schedulerLecturerComboBox
            // 
            this.schedulerLecturerComboBox.FormattingEnabled = true;
            this.schedulerLecturerComboBox.Location = new System.Drawing.Point(123, 49);
            this.schedulerLecturerComboBox.Name = "schedulerLecturerComboBox";
            this.schedulerLecturerComboBox.Size = new System.Drawing.Size(168, 21);
            this.schedulerLecturerComboBox.TabIndex = 7;
            this.schedulerLecturerComboBox.SelectedIndexChanged += new System.EventHandler(this.schedulerLecturerComboBox_SelectedIndexChanged);
            // 
            // schedulerLocationComboBox
            // 
            this.schedulerLocationComboBox.FormattingEnabled = true;
            this.schedulerLocationComboBox.Location = new System.Drawing.Point(123, 85);
            this.schedulerLocationComboBox.Name = "schedulerLocationComboBox";
            this.schedulerLocationComboBox.Size = new System.Drawing.Size(168, 21);
            this.schedulerLocationComboBox.TabIndex = 8;
            this.schedulerLocationComboBox.SelectedIndexChanged += new System.EventHandler(this.schedulerLocationComboBox_SelectedIndexChanged);
            // 
            // schedulerCourseComboBox
            // 
            this.schedulerCourseComboBox.FormattingEnabled = true;
            this.schedulerCourseComboBox.Location = new System.Drawing.Point(123, 120);
            this.schedulerCourseComboBox.Name = "schedulerCourseComboBox";
            this.schedulerCourseComboBox.Size = new System.Drawing.Size(168, 21);
            this.schedulerCourseComboBox.TabIndex = 9;
            this.schedulerCourseComboBox.SelectedIndexChanged += new System.EventHandler(this.schedulerCourseComboBox_SelectedIndexChanged);
            // 
            // schedulerDateComboBox
            // 
            this.schedulerDateComboBox.FormattingEnabled = true;
            this.schedulerDateComboBox.Location = new System.Drawing.Point(123, 152);
            this.schedulerDateComboBox.Name = "schedulerDateComboBox";
            this.schedulerDateComboBox.Size = new System.Drawing.Size(168, 21);
            this.schedulerDateComboBox.TabIndex = 10;
            this.schedulerDateComboBox.SelectedIndexChanged += new System.EventHandler(this.SchedulerDayComboBox_SelectedIndexChanged);
            // 
            // schedulerTimeLabel
            // 
            this.schedulerTimeLabel.AutoSize = true;
            this.schedulerTimeLabel.Location = new System.Drawing.Point(37, 187);
            this.schedulerTimeLabel.Name = "schedulerTimeLabel";
            this.schedulerTimeLabel.Size = new System.Drawing.Size(33, 13);
            this.schedulerTimeLabel.TabIndex = 11;
            this.schedulerTimeLabel.Text = "Time:";
            // 
            // schedulerTimeComboBox
            // 
            this.schedulerTimeComboBox.FormattingEnabled = true;
            this.schedulerTimeComboBox.Location = new System.Drawing.Point(123, 184);
            this.schedulerTimeComboBox.Name = "schedulerTimeComboBox";
            this.schedulerTimeComboBox.Size = new System.Drawing.Size(168, 21);
            this.schedulerTimeComboBox.TabIndex = 12;
            this.schedulerTimeComboBox.SelectedIndexChanged += new System.EventHandler(this.schedulerStartTimeComboBox_SelectedIndexChanged);
            // 
            // SchedulerMakeScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 286);
            this.Controls.Add(this.schedulerTimeComboBox);
            this.Controls.Add(this.schedulerTimeLabel);
            this.Controls.Add(this.schedulerDateComboBox);
            this.Controls.Add(this.schedulerCourseComboBox);
            this.Controls.Add(this.schedulerLocationComboBox);
            this.Controls.Add(this.schedulerLecturerComboBox);
            this.Controls.Add(this.schedulerBackButton);
            this.Controls.Add(this.schedulerSubmitButton);
            this.Controls.Add(this.schedulerDateLabel);
            this.Controls.Add(this.schedulerCourseLabel);
            this.Controls.Add(this.schedulerLocationLabel);
            this.Controls.Add(this.schedulerLecturerLabel);
            this.Controls.Add(this.schedulerMakeScheduleLabel);
            this.Name = "SchedulerMakeScheduleForm";
            this.Text = "Scheduler - Make Schedule Form";
            this.Load += new System.EventHandler(this.SchedulerMakeScheduleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label schedulerMakeScheduleLabel;
        private System.Windows.Forms.Label schedulerLecturerLabel;
        private System.Windows.Forms.Label schedulerLocationLabel;
        private System.Windows.Forms.Label schedulerCourseLabel;
        private System.Windows.Forms.Label schedulerDateLabel;
        private System.Windows.Forms.Button schedulerSubmitButton;
        private System.Windows.Forms.Button schedulerBackButton;
        private System.Windows.Forms.ComboBox schedulerLecturerComboBox;
        private System.Windows.Forms.ComboBox schedulerLocationComboBox;
        private System.Windows.Forms.ComboBox schedulerCourseComboBox;
        private System.Windows.Forms.ComboBox schedulerDateComboBox;
        private System.Windows.Forms.Label schedulerTimeLabel;
        private System.Windows.Forms.ComboBox schedulerTimeComboBox;
    }
}