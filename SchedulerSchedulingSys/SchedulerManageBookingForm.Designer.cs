namespace SchedulerSchedulingSys
{
    partial class SchedulerManageBookingForm
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
            this.schedulerAvailableSlotsGroupBox = new System.Windows.Forms.GroupBox();
            this.schedulerDataGridView = new System.Windows.Forms.DataGridView();
            this.schedulerBackButton = new System.Windows.Forms.Button();
            this.schedulerBookButton = new System.Windows.Forms.Button();
            this.schedulerBookingProcessGroupBox = new System.Windows.Forms.GroupBox();
            this.schedulerBookingNewTimeComboBox = new System.Windows.Forms.ComboBox();
            this.schedulerBookingNewDateComboBox = new System.Windows.Forms.ComboBox();
            this.schedulerBookingNewTimeLabel = new System.Windows.Forms.Label();
            this.schedulerBookingNewDateLabel = new System.Windows.Forms.Label();
            this.schedulerBookingUsernameTextBox = new System.Windows.Forms.TextBox();
            this.schedulerBookingUsernameLabel = new System.Windows.Forms.Label();
            this.schedulerBookingPreviousDateComboBox = new System.Windows.Forms.ComboBox();
            this.schedulerBookingPreviousDateLabel = new System.Windows.Forms.Label();
            this.schedulerBookingPreviousTimeComboBox = new System.Windows.Forms.ComboBox();
            this.schedulerBookingPreviousTimeLabel = new System.Windows.Forms.Label();
            this.schedulerBookingEventNameTextBox = new System.Windows.Forms.TextBox();
            this.schedulerBookingEventNameLabel = new System.Windows.Forms.Label();
            this.schedulerBookingCancelationProcessGroupBox = new System.Windows.Forms.GroupBox();
            this.schedulerBookingCancelationDateComboBox = new System.Windows.Forms.ComboBox();
            this.schedulerBookingCancelationDateLabel = new System.Windows.Forms.Label();
            this.schedulerBookingCancelationTimeComboBox = new System.Windows.Forms.ComboBox();
            this.schedulerBookingCancelationTimeLabel = new System.Windows.Forms.Label();
            this.schedulerCancelBookingButton = new System.Windows.Forms.Button();
            this.schedulerReleasedStatusDisplayLabel = new System.Windows.Forms.Label();
            this.schedulerReleasedStatusLabel = new System.Windows.Forms.Label();
            this.schedulerBookingCancelationUsernameLabel = new System.Windows.Forms.Label();
            this.schedulerBookingCancelationUsernameTextBox = new System.Windows.Forms.TextBox();
            this.schedulerAvailableSlotsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataGridView)).BeginInit();
            this.schedulerBookingProcessGroupBox.SuspendLayout();
            this.schedulerBookingCancelationProcessGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // schedulerLocationLabel
            // 
            this.schedulerLocationLabel.AutoSize = true;
            this.schedulerLocationLabel.Location = new System.Drawing.Point(41, 29);
            this.schedulerLocationLabel.Name = "schedulerLocationLabel";
            this.schedulerLocationLabel.Size = new System.Drawing.Size(51, 13);
            this.schedulerLocationLabel.TabIndex = 0;
            this.schedulerLocationLabel.Text = "Location:";
            // 
            // schedulerLocationComboBox
            // 
            this.schedulerLocationComboBox.FormattingEnabled = true;
            this.schedulerLocationComboBox.Location = new System.Drawing.Point(120, 26);
            this.schedulerLocationComboBox.Name = "schedulerLocationComboBox";
            this.schedulerLocationComboBox.Size = new System.Drawing.Size(192, 21);
            this.schedulerLocationComboBox.TabIndex = 1;
            this.schedulerLocationComboBox.SelectedIndexChanged += new System.EventHandler(this.schedulerLocationComboBox_SelectedIndexChanged);
            // 
            // schedulerAvailableSlotsGroupBox
            // 
            this.schedulerAvailableSlotsGroupBox.Controls.Add(this.schedulerDataGridView);
            this.schedulerAvailableSlotsGroupBox.Location = new System.Drawing.Point(12, 68);
            this.schedulerAvailableSlotsGroupBox.Name = "schedulerAvailableSlotsGroupBox";
            this.schedulerAvailableSlotsGroupBox.Size = new System.Drawing.Size(868, 274);
            this.schedulerAvailableSlotsGroupBox.TabIndex = 2;
            this.schedulerAvailableSlotsGroupBox.TabStop = false;
            this.schedulerAvailableSlotsGroupBox.Text = "Available slots";
            // 
            // schedulerDataGridView
            // 
            this.schedulerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.schedulerDataGridView.Location = new System.Drawing.Point(7, 20);
            this.schedulerDataGridView.Name = "schedulerDataGridView";
            this.schedulerDataGridView.Size = new System.Drawing.Size(851, 248);
            this.schedulerDataGridView.TabIndex = 0;
            // 
            // schedulerBackButton
            // 
            this.schedulerBackButton.Location = new System.Drawing.Point(12, 433);
            this.schedulerBackButton.Name = "schedulerBackButton";
            this.schedulerBackButton.Size = new System.Drawing.Size(75, 23);
            this.schedulerBackButton.TabIndex = 0;
            this.schedulerBackButton.Text = "<< Back";
            this.schedulerBackButton.UseVisualStyleBackColor = true;
            this.schedulerBackButton.Click += new System.EventHandler(this.schedulerBackButton_Click);
            // 
            // schedulerBookButton
            // 
            this.schedulerBookButton.Location = new System.Drawing.Point(990, 280);
            this.schedulerBookButton.Name = "schedulerBookButton";
            this.schedulerBookButton.Size = new System.Drawing.Size(110, 23);
            this.schedulerBookButton.TabIndex = 3;
            this.schedulerBookButton.Text = "Book";
            this.schedulerBookButton.UseVisualStyleBackColor = true;
            this.schedulerBookButton.Click += new System.EventHandler(this.schedulerBookButton_Click);
            // 
            // schedulerBookingProcessGroupBox
            // 
            this.schedulerBookingProcessGroupBox.Controls.Add(this.schedulerBookingNewTimeComboBox);
            this.schedulerBookingProcessGroupBox.Controls.Add(this.schedulerBookingNewDateComboBox);
            this.schedulerBookingProcessGroupBox.Controls.Add(this.schedulerBookingNewTimeLabel);
            this.schedulerBookingProcessGroupBox.Controls.Add(this.schedulerBookingNewDateLabel);
            this.schedulerBookingProcessGroupBox.Controls.Add(this.schedulerBookingUsernameTextBox);
            this.schedulerBookingProcessGroupBox.Controls.Add(this.schedulerBookingUsernameLabel);
            this.schedulerBookingProcessGroupBox.Controls.Add(this.schedulerBookingPreviousDateComboBox);
            this.schedulerBookingProcessGroupBox.Controls.Add(this.schedulerBookingPreviousDateLabel);
            this.schedulerBookingProcessGroupBox.Controls.Add(this.schedulerBookingPreviousTimeComboBox);
            this.schedulerBookingProcessGroupBox.Controls.Add(this.schedulerBookingPreviousTimeLabel);
            this.schedulerBookingProcessGroupBox.Controls.Add(this.schedulerBookingEventNameTextBox);
            this.schedulerBookingProcessGroupBox.Controls.Add(this.schedulerBookingEventNameLabel);
            this.schedulerBookingProcessGroupBox.Location = new System.Drawing.Point(886, 68);
            this.schedulerBookingProcessGroupBox.Name = "schedulerBookingProcessGroupBox";
            this.schedulerBookingProcessGroupBox.Size = new System.Drawing.Size(214, 206);
            this.schedulerBookingProcessGroupBox.TabIndex = 3;
            this.schedulerBookingProcessGroupBox.TabStop = false;
            this.schedulerBookingProcessGroupBox.Text = "Modify Booking";
            // 
            // schedulerBookingNewTimeComboBox
            // 
            this.schedulerBookingNewTimeComboBox.FormattingEnabled = true;
            this.schedulerBookingNewTimeComboBox.Location = new System.Drawing.Point(79, 179);
            this.schedulerBookingNewTimeComboBox.Name = "schedulerBookingNewTimeComboBox";
            this.schedulerBookingNewTimeComboBox.Size = new System.Drawing.Size(121, 21);
            this.schedulerBookingNewTimeComboBox.TabIndex = 15;
            this.schedulerBookingNewTimeComboBox.SelectedIndexChanged += new System.EventHandler(this.schedulerBookingNewTimeComboBox_SelectedIndexChanged);
            // 
            // schedulerBookingNewDateComboBox
            // 
            this.schedulerBookingNewDateComboBox.FormattingEnabled = true;
            this.schedulerBookingNewDateComboBox.Location = new System.Drawing.Point(79, 150);
            this.schedulerBookingNewDateComboBox.Name = "schedulerBookingNewDateComboBox";
            this.schedulerBookingNewDateComboBox.Size = new System.Drawing.Size(121, 21);
            this.schedulerBookingNewDateComboBox.TabIndex = 14;
            this.schedulerBookingNewDateComboBox.SelectedIndexChanged += new System.EventHandler(this.schedulerBookingNewDateComboBox_SelectedIndexChanged);
            // 
            // schedulerBookingNewTimeLabel
            // 
            this.schedulerBookingNewTimeLabel.AutoSize = true;
            this.schedulerBookingNewTimeLabel.Location = new System.Drawing.Point(6, 182);
            this.schedulerBookingNewTimeLabel.Name = "schedulerBookingNewTimeLabel";
            this.schedulerBookingNewTimeLabel.Size = new System.Drawing.Size(54, 13);
            this.schedulerBookingNewTimeLabel.TabIndex = 13;
            this.schedulerBookingNewTimeLabel.Text = "New time:";
            // 
            // schedulerBookingNewDateLabel
            // 
            this.schedulerBookingNewDateLabel.AutoSize = true;
            this.schedulerBookingNewDateLabel.Location = new System.Drawing.Point(6, 153);
            this.schedulerBookingNewDateLabel.Name = "schedulerBookingNewDateLabel";
            this.schedulerBookingNewDateLabel.Size = new System.Drawing.Size(56, 13);
            this.schedulerBookingNewDateLabel.TabIndex = 12;
            this.schedulerBookingNewDateLabel.Text = "New date:";
            // 
            // schedulerBookingUsernameTextBox
            // 
            this.schedulerBookingUsernameTextBox.Location = new System.Drawing.Point(79, 23);
            this.schedulerBookingUsernameTextBox.Name = "schedulerBookingUsernameTextBox";
            this.schedulerBookingUsernameTextBox.Size = new System.Drawing.Size(121, 20);
            this.schedulerBookingUsernameTextBox.TabIndex = 11;
            this.schedulerBookingUsernameTextBox.TextChanged += new System.EventHandler(this.schedulerBookingUsernameTextBox_TextChanged);
            // 
            // schedulerBookingUsernameLabel
            // 
            this.schedulerBookingUsernameLabel.AutoSize = true;
            this.schedulerBookingUsernameLabel.Location = new System.Drawing.Point(6, 26);
            this.schedulerBookingUsernameLabel.Name = "schedulerBookingUsernameLabel";
            this.schedulerBookingUsernameLabel.Size = new System.Drawing.Size(58, 13);
            this.schedulerBookingUsernameLabel.TabIndex = 10;
            this.schedulerBookingUsernameLabel.Text = "Username:";
            // 
            // schedulerBookingPreviousDateComboBox
            // 
            this.schedulerBookingPreviousDateComboBox.FormattingEnabled = true;
            this.schedulerBookingPreviousDateComboBox.Location = new System.Drawing.Point(79, 83);
            this.schedulerBookingPreviousDateComboBox.Name = "schedulerBookingPreviousDateComboBox";
            this.schedulerBookingPreviousDateComboBox.Size = new System.Drawing.Size(121, 21);
            this.schedulerBookingPreviousDateComboBox.TabIndex = 9;
            this.schedulerBookingPreviousDateComboBox.SelectedIndexChanged += new System.EventHandler(this.schedulerBookingPreviousDateComboBox_SelectedIndexChanged);
            // 
            // schedulerBookingPreviousDateLabel
            // 
            this.schedulerBookingPreviousDateLabel.AutoSize = true;
            this.schedulerBookingPreviousDateLabel.Location = new System.Drawing.Point(6, 86);
            this.schedulerBookingPreviousDateLabel.Name = "schedulerBookingPreviousDateLabel";
            this.schedulerBookingPreviousDateLabel.Size = new System.Drawing.Size(75, 13);
            this.schedulerBookingPreviousDateLabel.TabIndex = 8;
            this.schedulerBookingPreviousDateLabel.Text = "Previous date:";
            // 
            // schedulerBookingPreviousTimeComboBox
            // 
            this.schedulerBookingPreviousTimeComboBox.FormattingEnabled = true;
            this.schedulerBookingPreviousTimeComboBox.Location = new System.Drawing.Point(79, 117);
            this.schedulerBookingPreviousTimeComboBox.Name = "schedulerBookingPreviousTimeComboBox";
            this.schedulerBookingPreviousTimeComboBox.Size = new System.Drawing.Size(121, 21);
            this.schedulerBookingPreviousTimeComboBox.TabIndex = 6;
            this.schedulerBookingPreviousTimeComboBox.SelectedIndexChanged += new System.EventHandler(this.schedulerBookingPreviousTimeComboBox_SelectedIndexChanged);
            // 
            // schedulerBookingPreviousTimeLabel
            // 
            this.schedulerBookingPreviousTimeLabel.AutoSize = true;
            this.schedulerBookingPreviousTimeLabel.Location = new System.Drawing.Point(6, 120);
            this.schedulerBookingPreviousTimeLabel.Name = "schedulerBookingPreviousTimeLabel";
            this.schedulerBookingPreviousTimeLabel.Size = new System.Drawing.Size(73, 13);
            this.schedulerBookingPreviousTimeLabel.TabIndex = 4;
            this.schedulerBookingPreviousTimeLabel.Text = "Previous time:";
            // 
            // schedulerBookingEventNameTextBox
            // 
            this.schedulerBookingEventNameTextBox.Location = new System.Drawing.Point(79, 54);
            this.schedulerBookingEventNameTextBox.Name = "schedulerBookingEventNameTextBox";
            this.schedulerBookingEventNameTextBox.Size = new System.Drawing.Size(121, 20);
            this.schedulerBookingEventNameTextBox.TabIndex = 3;
            this.schedulerBookingEventNameTextBox.TextChanged += new System.EventHandler(this.schedulerBookingEventNameTextBox_TextChanged);
            // 
            // schedulerBookingEventNameLabel
            // 
            this.schedulerBookingEventNameLabel.AutoSize = true;
            this.schedulerBookingEventNameLabel.Location = new System.Drawing.Point(6, 57);
            this.schedulerBookingEventNameLabel.Name = "schedulerBookingEventNameLabel";
            this.schedulerBookingEventNameLabel.Size = new System.Drawing.Size(67, 13);
            this.schedulerBookingEventNameLabel.TabIndex = 0;
            this.schedulerBookingEventNameLabel.Text = "Event name:";
            // 
            // schedulerBookingCancelationProcessGroupBox
            // 
            this.schedulerBookingCancelationProcessGroupBox.Controls.Add(this.schedulerBookingCancelationUsernameTextBox);
            this.schedulerBookingCancelationProcessGroupBox.Controls.Add(this.schedulerBookingCancelationUsernameLabel);
            this.schedulerBookingCancelationProcessGroupBox.Controls.Add(this.schedulerBookingCancelationDateComboBox);
            this.schedulerBookingCancelationProcessGroupBox.Controls.Add(this.schedulerBookingCancelationDateLabel);
            this.schedulerBookingCancelationProcessGroupBox.Controls.Add(this.schedulerBookingCancelationTimeComboBox);
            this.schedulerBookingCancelationProcessGroupBox.Controls.Add(this.schedulerBookingCancelationTimeLabel);
            this.schedulerBookingCancelationProcessGroupBox.Location = new System.Drawing.Point(886, 309);
            this.schedulerBookingCancelationProcessGroupBox.Name = "schedulerBookingCancelationProcessGroupBox";
            this.schedulerBookingCancelationProcessGroupBox.Size = new System.Drawing.Size(214, 118);
            this.schedulerBookingCancelationProcessGroupBox.TabIndex = 12;
            this.schedulerBookingCancelationProcessGroupBox.TabStop = false;
            this.schedulerBookingCancelationProcessGroupBox.Text = "Booking Cancelation";
            // 
            // schedulerBookingCancelationDateComboBox
            // 
            this.schedulerBookingCancelationDateComboBox.FormattingEnabled = true;
            this.schedulerBookingCancelationDateComboBox.Location = new System.Drawing.Point(79, 53);
            this.schedulerBookingCancelationDateComboBox.Name = "schedulerBookingCancelationDateComboBox";
            this.schedulerBookingCancelationDateComboBox.Size = new System.Drawing.Size(121, 21);
            this.schedulerBookingCancelationDateComboBox.TabIndex = 9;
            // 
            // schedulerBookingCancelationDateLabel
            // 
            this.schedulerBookingCancelationDateLabel.AutoSize = true;
            this.schedulerBookingCancelationDateLabel.Location = new System.Drawing.Point(6, 56);
            this.schedulerBookingCancelationDateLabel.Name = "schedulerBookingCancelationDateLabel";
            this.schedulerBookingCancelationDateLabel.Size = new System.Drawing.Size(33, 13);
            this.schedulerBookingCancelationDateLabel.TabIndex = 8;
            this.schedulerBookingCancelationDateLabel.Text = "Date:";
            // 
            // schedulerBookingCancelationTimeComboBox
            // 
            this.schedulerBookingCancelationTimeComboBox.FormattingEnabled = true;
            this.schedulerBookingCancelationTimeComboBox.Location = new System.Drawing.Point(79, 87);
            this.schedulerBookingCancelationTimeComboBox.Name = "schedulerBookingCancelationTimeComboBox";
            this.schedulerBookingCancelationTimeComboBox.Size = new System.Drawing.Size(121, 21);
            this.schedulerBookingCancelationTimeComboBox.TabIndex = 6;
            // 
            // schedulerBookingCancelationTimeLabel
            // 
            this.schedulerBookingCancelationTimeLabel.AutoSize = true;
            this.schedulerBookingCancelationTimeLabel.Location = new System.Drawing.Point(6, 90);
            this.schedulerBookingCancelationTimeLabel.Name = "schedulerBookingCancelationTimeLabel";
            this.schedulerBookingCancelationTimeLabel.Size = new System.Drawing.Size(33, 13);
            this.schedulerBookingCancelationTimeLabel.TabIndex = 4;
            this.schedulerBookingCancelationTimeLabel.Text = "Time:";
            // 
            // schedulerCancelBookingButton
            // 
            this.schedulerCancelBookingButton.Location = new System.Drawing.Point(990, 433);
            this.schedulerCancelBookingButton.Name = "schedulerCancelBookingButton";
            this.schedulerCancelBookingButton.Size = new System.Drawing.Size(110, 23);
            this.schedulerCancelBookingButton.TabIndex = 13;
            this.schedulerCancelBookingButton.Text = "Cancel Booking";
            this.schedulerCancelBookingButton.UseVisualStyleBackColor = true;
            this.schedulerCancelBookingButton.Click += new System.EventHandler(this.schedulerCancelBookingButton_Click);
            // 
            // schedulerReleasedStatusDisplayLabel
            // 
            this.schedulerReleasedStatusDisplayLabel.AutoSize = true;
            this.schedulerReleasedStatusDisplayLabel.Location = new System.Drawing.Point(364, 29);
            this.schedulerReleasedStatusDisplayLabel.Name = "schedulerReleasedStatusDisplayLabel";
            this.schedulerReleasedStatusDisplayLabel.Size = new System.Drawing.Size(10, 13);
            this.schedulerReleasedStatusDisplayLabel.TabIndex = 15;
            this.schedulerReleasedStatusDisplayLabel.Text = "-";
            // 
            // schedulerReleasedStatusLabel
            // 
            this.schedulerReleasedStatusLabel.AutoSize = true;
            this.schedulerReleasedStatusLabel.Location = new System.Drawing.Point(318, 29);
            this.schedulerReleasedStatusLabel.Name = "schedulerReleasedStatusLabel";
            this.schedulerReleasedStatusLabel.Size = new System.Drawing.Size(40, 13);
            this.schedulerReleasedStatusLabel.TabIndex = 14;
            this.schedulerReleasedStatusLabel.Text = "Status:";
            // 
            // schedulerBookingCancelationUsernameLabel
            // 
            this.schedulerBookingCancelationUsernameLabel.AutoSize = true;
            this.schedulerBookingCancelationUsernameLabel.Location = new System.Drawing.Point(6, 26);
            this.schedulerBookingCancelationUsernameLabel.Name = "schedulerBookingCancelationUsernameLabel";
            this.schedulerBookingCancelationUsernameLabel.Size = new System.Drawing.Size(58, 13);
            this.schedulerBookingCancelationUsernameLabel.TabIndex = 10;
            this.schedulerBookingCancelationUsernameLabel.Text = "Username:";
            // 
            // schedulerBookingCancelationUsernameTextBox
            // 
            this.schedulerBookingCancelationUsernameTextBox.Location = new System.Drawing.Point(79, 23);
            this.schedulerBookingCancelationUsernameTextBox.Name = "schedulerBookingCancelationUsernameTextBox";
            this.schedulerBookingCancelationUsernameTextBox.Size = new System.Drawing.Size(121, 20);
            this.schedulerBookingCancelationUsernameTextBox.TabIndex = 11;
            // 
            // SchedulerManageBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 466);
            this.Controls.Add(this.schedulerReleasedStatusDisplayLabel);
            this.Controls.Add(this.schedulerReleasedStatusLabel);
            this.Controls.Add(this.schedulerCancelBookingButton);
            this.Controls.Add(this.schedulerBookingCancelationProcessGroupBox);
            this.Controls.Add(this.schedulerBookingProcessGroupBox);
            this.Controls.Add(this.schedulerBookButton);
            this.Controls.Add(this.schedulerBackButton);
            this.Controls.Add(this.schedulerAvailableSlotsGroupBox);
            this.Controls.Add(this.schedulerLocationComboBox);
            this.Controls.Add(this.schedulerLocationLabel);
            this.Name = "SchedulerManageBookingForm";
            this.Text = "Scheduler - Manage Booking";
            this.Load += new System.EventHandler(this.SchedulerManageBookingForm_Load);
            this.schedulerAvailableSlotsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataGridView)).EndInit();
            this.schedulerBookingProcessGroupBox.ResumeLayout(false);
            this.schedulerBookingProcessGroupBox.PerformLayout();
            this.schedulerBookingCancelationProcessGroupBox.ResumeLayout(false);
            this.schedulerBookingCancelationProcessGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label schedulerLocationLabel;
        private System.Windows.Forms.ComboBox schedulerLocationComboBox;
        private System.Windows.Forms.GroupBox schedulerAvailableSlotsGroupBox;
        private System.Windows.Forms.Button schedulerBackButton;
        private System.Windows.Forms.Button schedulerBookButton;
        private System.Windows.Forms.GroupBox schedulerBookingProcessGroupBox;
        private System.Windows.Forms.TextBox schedulerBookingEventNameTextBox;
        private System.Windows.Forms.Label schedulerBookingEventNameLabel;
        private System.Windows.Forms.ComboBox schedulerBookingPreviousTimeComboBox;
        private System.Windows.Forms.Label schedulerBookingPreviousTimeLabel;
        private System.Windows.Forms.ComboBox schedulerBookingPreviousDateComboBox;
        private System.Windows.Forms.Label schedulerBookingPreviousDateLabel;
        private System.Windows.Forms.TextBox schedulerBookingUsernameTextBox;
        private System.Windows.Forms.Label schedulerBookingUsernameLabel;
        private System.Windows.Forms.DataGridView schedulerDataGridView;
        private System.Windows.Forms.GroupBox schedulerBookingCancelationProcessGroupBox;
        private System.Windows.Forms.ComboBox schedulerBookingCancelationDateComboBox;
        private System.Windows.Forms.Label schedulerBookingCancelationDateLabel;
        private System.Windows.Forms.ComboBox schedulerBookingCancelationTimeComboBox;
        private System.Windows.Forms.Label schedulerBookingCancelationTimeLabel;
        private System.Windows.Forms.Button schedulerCancelBookingButton;
        private System.Windows.Forms.ComboBox schedulerBookingNewTimeComboBox;
        private System.Windows.Forms.ComboBox schedulerBookingNewDateComboBox;
        private System.Windows.Forms.Label schedulerBookingNewTimeLabel;
        private System.Windows.Forms.Label schedulerBookingNewDateLabel;
        private System.Windows.Forms.Label schedulerReleasedStatusDisplayLabel;
        private System.Windows.Forms.Label schedulerReleasedStatusLabel;
        private System.Windows.Forms.TextBox schedulerBookingCancelationUsernameTextBox;
        private System.Windows.Forms.Label schedulerBookingCancelationUsernameLabel;
    }
}