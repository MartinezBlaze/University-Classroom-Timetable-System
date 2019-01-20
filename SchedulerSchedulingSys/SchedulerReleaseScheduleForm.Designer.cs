namespace SchedulerSchedulingSys
{
    partial class SchedulerReleaseScheduleForm
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
            this.schedulerLocationComboBox = new System.Windows.Forms.ComboBox();
            this.schedulerLocationLabel = new System.Windows.Forms.Label();
            this.shedulerTimetableGroupBox = new System.Windows.Forms.GroupBox();
            this.schedulerDataGridView = new System.Windows.Forms.DataGridView();
            this.scheduleReleaseScheduleButton = new System.Windows.Forms.Button();
            this.schedulerBackButton = new System.Windows.Forms.Button();
            this.schedulerReleasedStatusDisplayLabel = new System.Windows.Forms.Label();
            this.schedulerReleasedStatusLabel = new System.Windows.Forms.Label();
            this.shedulerTimetableGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // schedulerLocationComboBox
            // 
            this.schedulerLocationComboBox.FormattingEnabled = true;
            this.schedulerLocationComboBox.Location = new System.Drawing.Point(105, 30);
            this.schedulerLocationComboBox.Name = "schedulerLocationComboBox";
            this.schedulerLocationComboBox.Size = new System.Drawing.Size(168, 21);
            this.schedulerLocationComboBox.TabIndex = 10;
            this.schedulerLocationComboBox.SelectedIndexChanged += new System.EventHandler(this.schedulerLocationComboBox_SelectedIndexChanged);
            // 
            // schedulerLocationLabel
            // 
            this.schedulerLocationLabel.AutoSize = true;
            this.schedulerLocationLabel.Location = new System.Drawing.Point(19, 33);
            this.schedulerLocationLabel.Name = "schedulerLocationLabel";
            this.schedulerLocationLabel.Size = new System.Drawing.Size(51, 13);
            this.schedulerLocationLabel.TabIndex = 9;
            this.schedulerLocationLabel.Text = "Location:";
            // 
            // shedulerTimetableGroupBox
            // 
            this.shedulerTimetableGroupBox.Controls.Add(this.schedulerDataGridView);
            this.shedulerTimetableGroupBox.Location = new System.Drawing.Point(22, 72);
            this.shedulerTimetableGroupBox.Name = "shedulerTimetableGroupBox";
            this.shedulerTimetableGroupBox.Size = new System.Drawing.Size(873, 272);
            this.shedulerTimetableGroupBox.TabIndex = 11;
            this.shedulerTimetableGroupBox.TabStop = false;
            this.shedulerTimetableGroupBox.Text = "Timetable";
            // 
            // schedulerDataGridView
            // 
            this.schedulerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.schedulerDataGridView.Location = new System.Drawing.Point(7, 20);
            this.schedulerDataGridView.Name = "schedulerDataGridView";
            this.schedulerDataGridView.Size = new System.Drawing.Size(860, 246);
            this.schedulerDataGridView.TabIndex = 0;
            // 
            // scheduleReleaseScheduleButton
            // 
            this.scheduleReleaseScheduleButton.Location = new System.Drawing.Point(427, 28);
            this.scheduleReleaseScheduleButton.Name = "scheduleReleaseScheduleButton";
            this.scheduleReleaseScheduleButton.Size = new System.Drawing.Size(105, 23);
            this.scheduleReleaseScheduleButton.TabIndex = 12;
            this.scheduleReleaseScheduleButton.Text = "Release schedule";
            this.scheduleReleaseScheduleButton.UseVisualStyleBackColor = true;
            this.scheduleReleaseScheduleButton.Click += new System.EventHandler(this.scheduleReleaseScheduleButton_Click);
            // 
            // schedulerBackButton
            // 
            this.schedulerBackButton.Location = new System.Drawing.Point(12, 357);
            this.schedulerBackButton.Name = "schedulerBackButton";
            this.schedulerBackButton.Size = new System.Drawing.Size(75, 23);
            this.schedulerBackButton.TabIndex = 13;
            this.schedulerBackButton.Text = "<< Back";
            this.schedulerBackButton.UseVisualStyleBackColor = true;
            this.schedulerBackButton.Click += new System.EventHandler(this.schedulerBackButton_Click);
            // 
            // schedulerReleasedStatusDisplayLabel
            // 
            this.schedulerReleasedStatusDisplayLabel.AutoSize = true;
            this.schedulerReleasedStatusDisplayLabel.Location = new System.Drawing.Point(325, 33);
            this.schedulerReleasedStatusDisplayLabel.Name = "schedulerReleasedStatusDisplayLabel";
            this.schedulerReleasedStatusDisplayLabel.Size = new System.Drawing.Size(10, 13);
            this.schedulerReleasedStatusDisplayLabel.TabIndex = 15;
            this.schedulerReleasedStatusDisplayLabel.Text = "-";
            // 
            // schedulerReleasedStatusLabel
            // 
            this.schedulerReleasedStatusLabel.AutoSize = true;
            this.schedulerReleasedStatusLabel.Location = new System.Drawing.Point(279, 33);
            this.schedulerReleasedStatusLabel.Name = "schedulerReleasedStatusLabel";
            this.schedulerReleasedStatusLabel.Size = new System.Drawing.Size(40, 13);
            this.schedulerReleasedStatusLabel.TabIndex = 14;
            this.schedulerReleasedStatusLabel.Text = "Status:";
            // 
            // SchedulerReleaseScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 392);
            this.Controls.Add(this.schedulerReleasedStatusDisplayLabel);
            this.Controls.Add(this.schedulerReleasedStatusLabel);
            this.Controls.Add(this.schedulerBackButton);
            this.Controls.Add(this.scheduleReleaseScheduleButton);
            this.Controls.Add(this.shedulerTimetableGroupBox);
            this.Controls.Add(this.schedulerLocationComboBox);
            this.Controls.Add(this.schedulerLocationLabel);
            this.Name = "SchedulerReleaseScheduleForm";
            this.Text = "Scheduler - Release Schedule";
            this.Load += new System.EventHandler(this.SchedulerReleaseScheduleForm_Load);
            this.shedulerTimetableGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox schedulerLocationComboBox;
        private System.Windows.Forms.Label schedulerLocationLabel;
        private System.Windows.Forms.GroupBox shedulerTimetableGroupBox;
        private System.Windows.Forms.DataGridView schedulerDataGridView;
        private System.Windows.Forms.Button scheduleReleaseScheduleButton;
        private System.Windows.Forms.Button schedulerBackButton;
        private System.Windows.Forms.Label schedulerReleasedStatusDisplayLabel;
        private System.Windows.Forms.Label schedulerReleasedStatusLabel;
    }
}