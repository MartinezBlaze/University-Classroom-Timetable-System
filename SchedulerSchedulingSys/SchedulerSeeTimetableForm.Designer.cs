namespace SchedulerSchedulingSys
{
    partial class SchedulerSeeTimetableForm
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
            this.schedulerLocationLabel = new System.Windows.Forms.Label();
            this.schedulerLocationComboBox = new System.Windows.Forms.ComboBox();
            this.shedulerTimetableGroupBox = new System.Windows.Forms.GroupBox();
            this.schedulerDataGridView = new System.Windows.Forms.DataGridView();
            this.schedulerMakeScheduleButton = new System.Windows.Forms.Button();
            this.schedulerManageBookingButton = new System.Windows.Forms.Button();
            this.schedulerLogoutButton = new System.Windows.Forms.Button();
            this.schedulerReleaseScheduleButton = new System.Windows.Forms.Button();
            this.schedulerReleasedStatusLabel = new System.Windows.Forms.Label();
            this.schedulerReleasedStatusDisplayLabel = new System.Windows.Forms.Label();
            this.shedulerTimetableGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // schedulerLocationLabel
            // 
            this.schedulerLocationLabel.AutoSize = true;
            this.schedulerLocationLabel.Location = new System.Drawing.Point(46, 42);
            this.schedulerLocationLabel.Name = "schedulerLocationLabel";
            this.schedulerLocationLabel.Size = new System.Drawing.Size(48, 13);
            this.schedulerLocationLabel.TabIndex = 0;
            this.schedulerLocationLabel.Text = "Location";
            // 
            // schedulerLocationComboBox
            // 
            this.schedulerLocationComboBox.FormattingEnabled = true;
            this.schedulerLocationComboBox.Location = new System.Drawing.Point(109, 39);
            this.schedulerLocationComboBox.Name = "schedulerLocationComboBox";
            this.schedulerLocationComboBox.Size = new System.Drawing.Size(190, 21);
            this.schedulerLocationComboBox.TabIndex = 1;
            this.schedulerLocationComboBox.SelectedIndexChanged += new System.EventHandler(this.schedulerLocationComboBox_SelectedIndexChanged);
            // 
            // shedulerTimetableGroupBox
            // 
            this.shedulerTimetableGroupBox.Controls.Add(this.schedulerDataGridView);
            this.shedulerTimetableGroupBox.Location = new System.Drawing.Point(12, 78);
            this.shedulerTimetableGroupBox.Name = "shedulerTimetableGroupBox";
            this.shedulerTimetableGroupBox.Size = new System.Drawing.Size(873, 272);
            this.shedulerTimetableGroupBox.TabIndex = 2;
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
            this.schedulerDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // schedulerMakeScheduleButton
            // 
            this.schedulerMakeScheduleButton.Location = new System.Drawing.Point(891, 98);
            this.schedulerMakeScheduleButton.Name = "schedulerMakeScheduleButton";
            this.schedulerMakeScheduleButton.Size = new System.Drawing.Size(75, 47);
            this.schedulerMakeScheduleButton.TabIndex = 3;
            this.schedulerMakeScheduleButton.Text = "Make Schedule";
            this.schedulerMakeScheduleButton.UseVisualStyleBackColor = true;
            this.schedulerMakeScheduleButton.Click += new System.EventHandler(this.schedulerMakeScheduleButton_Click);
            // 
            // schedulerManageBookingButton
            // 
            this.schedulerManageBookingButton.Location = new System.Drawing.Point(891, 205);
            this.schedulerManageBookingButton.Name = "schedulerManageBookingButton";
            this.schedulerManageBookingButton.Size = new System.Drawing.Size(75, 45);
            this.schedulerManageBookingButton.TabIndex = 4;
            this.schedulerManageBookingButton.Text = "Manage Booking";
            this.schedulerManageBookingButton.UseVisualStyleBackColor = true;
            this.schedulerManageBookingButton.Click += new System.EventHandler(this.schedulerManageBookingButton_Click);
            // 
            // schedulerLogoutButton
            // 
            this.schedulerLogoutButton.Location = new System.Drawing.Point(891, 281);
            this.schedulerLogoutButton.Name = "schedulerLogoutButton";
            this.schedulerLogoutButton.Size = new System.Drawing.Size(75, 23);
            this.schedulerLogoutButton.TabIndex = 5;
            this.schedulerLogoutButton.Text = "Logout";
            this.schedulerLogoutButton.UseVisualStyleBackColor = true;
            this.schedulerLogoutButton.Click += new System.EventHandler(this.schedulerLogoutButton_Click);
            // 
            // schedulerReleaseScheduleButton
            // 
            this.schedulerReleaseScheduleButton.Location = new System.Drawing.Point(891, 151);
            this.schedulerReleaseScheduleButton.Name = "schedulerReleaseScheduleButton";
            this.schedulerReleaseScheduleButton.Size = new System.Drawing.Size(75, 48);
            this.schedulerReleaseScheduleButton.TabIndex = 6;
            this.schedulerReleaseScheduleButton.Text = "Release Schedule";
            this.schedulerReleaseScheduleButton.UseVisualStyleBackColor = true;
            this.schedulerReleaseScheduleButton.Click += new System.EventHandler(this.schedulerReleaseScheduleButton_Click);
            // 
            // schedulerReleasedStatusLabel
            // 
            this.schedulerReleasedStatusLabel.AutoSize = true;
            this.schedulerReleasedStatusLabel.Location = new System.Drawing.Point(305, 42);
            this.schedulerReleasedStatusLabel.Name = "schedulerReleasedStatusLabel";
            this.schedulerReleasedStatusLabel.Size = new System.Drawing.Size(40, 13);
            this.schedulerReleasedStatusLabel.TabIndex = 7;
            this.schedulerReleasedStatusLabel.Text = "Status:";
            // 
            // schedulerReleasedStatusDisplayLabel
            // 
            this.schedulerReleasedStatusDisplayLabel.AutoSize = true;
            this.schedulerReleasedStatusDisplayLabel.Location = new System.Drawing.Point(351, 42);
            this.schedulerReleasedStatusDisplayLabel.Name = "schedulerReleasedStatusDisplayLabel";
            this.schedulerReleasedStatusDisplayLabel.Size = new System.Drawing.Size(10, 13);
            this.schedulerReleasedStatusDisplayLabel.TabIndex = 8;
            this.schedulerReleasedStatusDisplayLabel.Text = "-";
            // 
            // SchedulerSeeTimetableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 362);
            this.Controls.Add(this.schedulerReleasedStatusDisplayLabel);
            this.Controls.Add(this.schedulerReleasedStatusLabel);
            this.Controls.Add(this.schedulerReleaseScheduleButton);
            this.Controls.Add(this.schedulerLogoutButton);
            this.Controls.Add(this.schedulerManageBookingButton);
            this.Controls.Add(this.schedulerMakeScheduleButton);
            this.Controls.Add(this.shedulerTimetableGroupBox);
            this.Controls.Add(this.schedulerLocationComboBox);
            this.Controls.Add(this.schedulerLocationLabel);
            this.Name = "SchedulerSeeTimetableForm";
            this.Text = "Scheduler - See Timetable";
            this.Load += new System.EventHandler(this.SchedulerSeeTimetableForm_Load);
            this.shedulerTimetableGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label schedulerLocationLabel;
        private System.Windows.Forms.ComboBox schedulerLocationComboBox;
        private System.Windows.Forms.GroupBox shedulerTimetableGroupBox;
        private System.Windows.Forms.Button schedulerMakeScheduleButton;
        private System.Windows.Forms.Button schedulerManageBookingButton;
        private System.Windows.Forms.Button schedulerLogoutButton;
        private System.Windows.Forms.DataGridView schedulerDataGridView;
        private System.Windows.Forms.Button schedulerReleaseScheduleButton;
        private System.Windows.Forms.Label schedulerReleasedStatusLabel;
        private System.Windows.Forms.Label schedulerReleasedStatusDisplayLabel;
    }
}