namespace UserSchedulingSystem
{
    partial class UserBookingProcessForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserBookingProcessForm));
            this.userLocationBookingProcessLabel = new System.Windows.Forms.Label();
            this.userLocationBookingProcessComboBox = new System.Windows.Forms.ComboBox();
            this.userHomeButton = new System.Windows.Forms.Button();
            this.userNextButton = new System.Windows.Forms.Button();
            this.userAvailableSlotsGroupBox = new System.Windows.Forms.GroupBox();
            this.userAvailableSlotsDataGridView = new System.Windows.Forms.DataGridView();
            this.userNoticeLabel = new System.Windows.Forms.Label();
            this.userNoticeExplanationLabel = new System.Windows.Forms.Label();
            this.userBookingProcessGroupBox = new System.Windows.Forms.GroupBox();
            this.userDateBookingProcessComboBox = new System.Windows.Forms.ComboBox();
            this.userDateBookingProcessLabel = new System.Windows.Forms.Label();
            this.userTimeBookingProcessComboBox = new System.Windows.Forms.ComboBox();
            this.userStartTimeLabel = new System.Windows.Forms.Label();
            this.userEventNameTextBox = new System.Windows.Forms.TextBox();
            this.userEventNameLabel = new System.Windows.Forms.Label();
            this.userBookingProcessWarningLabel = new System.Windows.Forms.Label();
            this.schedulerReleasedStatusDisplayLabel = new System.Windows.Forms.Label();
            this.schedulerReleasedStatusLabel = new System.Windows.Forms.Label();
            this.userAvailableSlotsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userAvailableSlotsDataGridView)).BeginInit();
            this.userBookingProcessGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // userLocationBookingProcessLabel
            // 
            this.userLocationBookingProcessLabel.AutoSize = true;
            this.userLocationBookingProcessLabel.Location = new System.Drawing.Point(20, 36);
            this.userLocationBookingProcessLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userLocationBookingProcessLabel.Name = "userLocationBookingProcessLabel";
            this.userLocationBookingProcessLabel.Size = new System.Drawing.Size(66, 17);
            this.userLocationBookingProcessLabel.TabIndex = 0;
            this.userLocationBookingProcessLabel.Text = "Location:";
            // 
            // userLocationBookingProcessComboBox
            // 
            this.userLocationBookingProcessComboBox.FormattingEnabled = true;
            this.userLocationBookingProcessComboBox.Location = new System.Drawing.Point(91, 31);
            this.userLocationBookingProcessComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userLocationBookingProcessComboBox.Name = "userLocationBookingProcessComboBox";
            this.userLocationBookingProcessComboBox.Size = new System.Drawing.Size(439, 24);
            this.userLocationBookingProcessComboBox.TabIndex = 1;
            this.userLocationBookingProcessComboBox.SelectedIndexChanged += new System.EventHandler(this.userLocationBookingProcessComboBox_SelectedIndexChanged);
            // 
            // userHomeButton
            // 
            this.userHomeButton.Location = new System.Drawing.Point(16, 625);
            this.userHomeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userHomeButton.Name = "userHomeButton";
            this.userHomeButton.Size = new System.Drawing.Size(100, 28);
            this.userHomeButton.TabIndex = 2;
            this.userHomeButton.Text = "Home";
            this.userHomeButton.UseVisualStyleBackColor = true;
            this.userHomeButton.Click += new System.EventHandler(this.userHomeButton_Click);
            // 
            // userNextButton
            // 
            this.userNextButton.Location = new System.Drawing.Point(1057, 625);
            this.userNextButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userNextButton.Name = "userNextButton";
            this.userNextButton.Size = new System.Drawing.Size(100, 28);
            this.userNextButton.TabIndex = 3;
            this.userNextButton.Text = "Next >>";
            this.userNextButton.UseVisualStyleBackColor = true;
            this.userNextButton.Click += new System.EventHandler(this.userNextButton_Click);
            // 
            // userAvailableSlotsGroupBox
            // 
            this.userAvailableSlotsGroupBox.Controls.Add(this.userAvailableSlotsDataGridView);
            this.userAvailableSlotsGroupBox.Location = new System.Drawing.Point(24, 76);
            this.userAvailableSlotsGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userAvailableSlotsGroupBox.Name = "userAvailableSlotsGroupBox";
            this.userAvailableSlotsGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userAvailableSlotsGroupBox.Size = new System.Drawing.Size(1083, 379);
            this.userAvailableSlotsGroupBox.TabIndex = 4;
            this.userAvailableSlotsGroupBox.TabStop = false;
            this.userAvailableSlotsGroupBox.Text = "Available Slots";
            // 
            // userAvailableSlotsDataGridView
            // 
            this.userAvailableSlotsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userAvailableSlotsDataGridView.Location = new System.Drawing.Point(8, 23);
            this.userAvailableSlotsDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userAvailableSlotsDataGridView.Name = "userAvailableSlotsDataGridView";
            this.userAvailableSlotsDataGridView.Size = new System.Drawing.Size(1064, 348);
            this.userAvailableSlotsDataGridView.TabIndex = 8;
            // 
            // userNoticeLabel
            // 
            this.userNoticeLabel.AutoSize = true;
            this.userNoticeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNoticeLabel.Location = new System.Drawing.Point(33, 466);
            this.userNoticeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userNoticeLabel.Name = "userNoticeLabel";
            this.userNoticeLabel.Size = new System.Drawing.Size(59, 13);
            this.userNoticeLabel.TabIndex = 5;
            this.userNoticeLabel.Text = "*NOTICE:";
            // 
            // userNoticeExplanationLabel
            // 
            this.userNoticeExplanationLabel.AutoSize = true;
            this.userNoticeExplanationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNoticeExplanationLabel.Location = new System.Drawing.Point(33, 485);
            this.userNoticeExplanationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userNoticeExplanationLabel.Name = "userNoticeExplanationLabel";
            this.userNoticeExplanationLabel.Size = new System.Drawing.Size(303, 90);
            this.userNoticeExplanationLabel.TabIndex = 6;
            this.userNoticeExplanationLabel.Text = resources.GetString("userNoticeExplanationLabel.Text");
            // 
            // userBookingProcessGroupBox
            // 
            this.userBookingProcessGroupBox.Controls.Add(this.userDateBookingProcessComboBox);
            this.userBookingProcessGroupBox.Controls.Add(this.userDateBookingProcessLabel);
            this.userBookingProcessGroupBox.Controls.Add(this.userTimeBookingProcessComboBox);
            this.userBookingProcessGroupBox.Controls.Add(this.userStartTimeLabel);
            this.userBookingProcessGroupBox.Controls.Add(this.userEventNameTextBox);
            this.userBookingProcessGroupBox.Controls.Add(this.userEventNameLabel);
            this.userBookingProcessGroupBox.Location = new System.Drawing.Point(1137, 142);
            this.userBookingProcessGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userBookingProcessGroupBox.Name = "userBookingProcessGroupBox";
            this.userBookingProcessGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userBookingProcessGroupBox.Size = new System.Drawing.Size(384, 222);
            this.userBookingProcessGroupBox.TabIndex = 7;
            this.userBookingProcessGroupBox.TabStop = false;
            this.userBookingProcessGroupBox.Text = "Booking Process";
            // 
            // userDateBookingProcessComboBox
            // 
            this.userDateBookingProcessComboBox.FormattingEnabled = true;
            this.userDateBookingProcessComboBox.Location = new System.Drawing.Point(113, 108);
            this.userDateBookingProcessComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userDateBookingProcessComboBox.Name = "userDateBookingProcessComboBox";
            this.userDateBookingProcessComboBox.Size = new System.Drawing.Size(232, 24);
            this.userDateBookingProcessComboBox.TabIndex = 15;
            this.userDateBookingProcessComboBox.SelectedIndexChanged += new System.EventHandler(this.userDateBookingProcessComboBox_SelectedIndexChanged);
            // 
            // userDateBookingProcessLabel
            // 
            this.userDateBookingProcessLabel.AutoSize = true;
            this.userDateBookingProcessLabel.Location = new System.Drawing.Point(15, 114);
            this.userDateBookingProcessLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userDateBookingProcessLabel.Name = "userDateBookingProcessLabel";
            this.userDateBookingProcessLabel.Size = new System.Drawing.Size(42, 17);
            this.userDateBookingProcessLabel.TabIndex = 8;
            this.userDateBookingProcessLabel.Text = "Date:";
            // 
            // userTimeBookingProcessComboBox
            // 
            this.userTimeBookingProcessComboBox.FormattingEnabled = true;
            this.userTimeBookingProcessComboBox.Location = new System.Drawing.Point(113, 167);
            this.userTimeBookingProcessComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userTimeBookingProcessComboBox.Name = "userTimeBookingProcessComboBox";
            this.userTimeBookingProcessComboBox.Size = new System.Drawing.Size(232, 24);
            this.userTimeBookingProcessComboBox.TabIndex = 13;
            this.userTimeBookingProcessComboBox.SelectedIndexChanged += new System.EventHandler(this.userTimeComboBox_SelectedIndexChanged);
            // 
            // userStartTimeLabel
            // 
            this.userStartTimeLabel.AutoSize = true;
            this.userStartTimeLabel.Location = new System.Drawing.Point(12, 174);
            this.userStartTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userStartTimeLabel.Name = "userStartTimeLabel";
            this.userStartTimeLabel.Size = new System.Drawing.Size(43, 17);
            this.userStartTimeLabel.TabIndex = 8;
            this.userStartTimeLabel.Text = "Time:";
            // 
            // userEventNameTextBox
            // 
            this.userEventNameTextBox.Location = new System.Drawing.Point(113, 58);
            this.userEventNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userEventNameTextBox.Name = "userEventNameTextBox";
            this.userEventNameTextBox.Size = new System.Drawing.Size(232, 22);
            this.userEventNameTextBox.TabIndex = 11;
            this.userEventNameTextBox.TextChanged += new System.EventHandler(this.userEventNameTextBox_TextChanged);
            // 
            // userEventNameLabel
            // 
            this.userEventNameLabel.AutoSize = true;
            this.userEventNameLabel.Location = new System.Drawing.Point(15, 58);
            this.userEventNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userEventNameLabel.Name = "userEventNameLabel";
            this.userEventNameLabel.Size = new System.Drawing.Size(89, 17);
            this.userEventNameLabel.TabIndex = 8;
            this.userEventNameLabel.Text = "Event Name:";
            // 
            // userBookingProcessWarningLabel
            // 
            this.userBookingProcessWarningLabel.AutoSize = true;
            this.userBookingProcessWarningLabel.Location = new System.Drawing.Point(1133, 412);
            this.userBookingProcessWarningLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userBookingProcessWarningLabel.Name = "userBookingProcessWarningLabel";
            this.userBookingProcessWarningLabel.Size = new System.Drawing.Size(100, 17);
            this.userBookingProcessWarningLabel.TabIndex = 8;
            this.userBookingProcessWarningLabel.Text = "Warning Label";
            // 
            // schedulerReleasedStatusDisplayLabel
            // 
            this.schedulerReleasedStatusDisplayLabel.AutoSize = true;
            this.schedulerReleasedStatusDisplayLabel.Location = new System.Drawing.Point(600, 36);
            this.schedulerReleasedStatusDisplayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.schedulerReleasedStatusDisplayLabel.Name = "schedulerReleasedStatusDisplayLabel";
            this.schedulerReleasedStatusDisplayLabel.Size = new System.Drawing.Size(13, 17);
            this.schedulerReleasedStatusDisplayLabel.TabIndex = 17;
            this.schedulerReleasedStatusDisplayLabel.Text = "-";
            // 
            // schedulerReleasedStatusLabel
            // 
            this.schedulerReleasedStatusLabel.AutoSize = true;
            this.schedulerReleasedStatusLabel.Location = new System.Drawing.Point(539, 36);
            this.schedulerReleasedStatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.schedulerReleasedStatusLabel.Name = "schedulerReleasedStatusLabel";
            this.schedulerReleasedStatusLabel.Size = new System.Drawing.Size(52, 17);
            this.schedulerReleasedStatusLabel.TabIndex = 16;
            this.schedulerReleasedStatusLabel.Text = "Status:";
            // 
            // UserBookingProcessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1544, 666);
            this.Controls.Add(this.schedulerReleasedStatusDisplayLabel);
            this.Controls.Add(this.schedulerReleasedStatusLabel);
            this.Controls.Add(this.userBookingProcessWarningLabel);
            this.Controls.Add(this.userBookingProcessGroupBox);
            this.Controls.Add(this.userNoticeExplanationLabel);
            this.Controls.Add(this.userNoticeLabel);
            this.Controls.Add(this.userAvailableSlotsGroupBox);
            this.Controls.Add(this.userNextButton);
            this.Controls.Add(this.userHomeButton);
            this.Controls.Add(this.userLocationBookingProcessComboBox);
            this.Controls.Add(this.userLocationBookingProcessLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserBookingProcessForm";
            this.Text = "User - Booking Process";
            this.Load += new System.EventHandler(this.UserBookingProcessForm_Load);
            this.userAvailableSlotsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userAvailableSlotsDataGridView)).EndInit();
            this.userBookingProcessGroupBox.ResumeLayout(false);
            this.userBookingProcessGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userLocationBookingProcessLabel;
        private System.Windows.Forms.ComboBox userLocationBookingProcessComboBox;
        private System.Windows.Forms.Button userHomeButton;
        private System.Windows.Forms.Button userNextButton;
        private System.Windows.Forms.GroupBox userAvailableSlotsGroupBox;
        private System.Windows.Forms.Label userNoticeLabel;
        private System.Windows.Forms.Label userNoticeExplanationLabel;
        private System.Windows.Forms.GroupBox userBookingProcessGroupBox;
        private System.Windows.Forms.TextBox userEventNameTextBox;
        private System.Windows.Forms.Label userEventNameLabel;
        private System.Windows.Forms.Label userStartTimeLabel;
        private System.Windows.Forms.ComboBox userTimeBookingProcessComboBox;
        private System.Windows.Forms.DataGridView userAvailableSlotsDataGridView;
        private System.Windows.Forms.ComboBox userDateBookingProcessComboBox;
        private System.Windows.Forms.Label userDateBookingProcessLabel;
        private System.Windows.Forms.Label userBookingProcessWarningLabel;
        private System.Windows.Forms.Label schedulerReleasedStatusDisplayLabel;
        private System.Windows.Forms.Label schedulerReleasedStatusLabel;
    }
}