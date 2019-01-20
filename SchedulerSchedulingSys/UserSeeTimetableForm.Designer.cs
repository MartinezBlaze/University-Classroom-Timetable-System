namespace UserSchedulingSystem
{
    partial class UserSeeTimetableForm
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
            this.userLocationSeeTimetableLabel = new System.Windows.Forms.Label();
            this.userHomeButton = new System.Windows.Forms.Button();
            this.userLocationSeeTimetableComboBox = new System.Windows.Forms.ComboBox();
            this.userTimetableGroupBox = new System.Windows.Forms.GroupBox();
            this.userTimetableDataGridView = new System.Windows.Forms.DataGridView();
            this.schedulerReleasedStatusDisplayLabel = new System.Windows.Forms.Label();
            this.schedulerReleasedStatusLabel = new System.Windows.Forms.Label();
            this.userTimetableGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userTimetableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // userLocationSeeTimetableLabel
            // 
            this.userLocationSeeTimetableLabel.AutoSize = true;
            this.userLocationSeeTimetableLabel.Location = new System.Drawing.Point(17, 33);
            this.userLocationSeeTimetableLabel.Name = "userLocationSeeTimetableLabel";
            this.userLocationSeeTimetableLabel.Size = new System.Drawing.Size(51, 13);
            this.userLocationSeeTimetableLabel.TabIndex = 0;
            this.userLocationSeeTimetableLabel.Text = "Location:";
            // 
            // userHomeButton
            // 
            this.userHomeButton.Location = new System.Drawing.Point(693, 437);
            this.userHomeButton.Name = "userHomeButton";
            this.userHomeButton.Size = new System.Drawing.Size(75, 23);
            this.userHomeButton.TabIndex = 1;
            this.userHomeButton.Text = "Home";
            this.userHomeButton.UseVisualStyleBackColor = true;
            this.userHomeButton.Click += new System.EventHandler(this.userHomeButton_Click);
            // 
            // userLocationSeeTimetableComboBox
            // 
            this.userLocationSeeTimetableComboBox.FormattingEnabled = true;
            this.userLocationSeeTimetableComboBox.Location = new System.Drawing.Point(84, 29);
            this.userLocationSeeTimetableComboBox.Name = "userLocationSeeTimetableComboBox";
            this.userLocationSeeTimetableComboBox.Size = new System.Drawing.Size(179, 21);
            this.userLocationSeeTimetableComboBox.TabIndex = 2;
            this.userLocationSeeTimetableComboBox.SelectedIndexChanged += new System.EventHandler(this.userLocationSeeTimetableComboBox_SelectedIndexChanged);
            // 
            // userTimetableGroupBox
            // 
            this.userTimetableGroupBox.Controls.Add(this.userTimetableDataGridView);
            this.userTimetableGroupBox.Location = new System.Drawing.Point(20, 72);
            this.userTimetableGroupBox.Name = "userTimetableGroupBox";
            this.userTimetableGroupBox.Size = new System.Drawing.Size(724, 359);
            this.userTimetableGroupBox.TabIndex = 3;
            this.userTimetableGroupBox.TabStop = false;
            this.userTimetableGroupBox.Text = "Timetable";
            // 
            // userTimetableDataGridView
            // 
            this.userTimetableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userTimetableDataGridView.Location = new System.Drawing.Point(6, 19);
            this.userTimetableDataGridView.Name = "userTimetableDataGridView";
            this.userTimetableDataGridView.Size = new System.Drawing.Size(712, 334);
            this.userTimetableDataGridView.TabIndex = 0;
            // 
            // schedulerReleasedStatusDisplayLabel
            // 
            this.schedulerReleasedStatusDisplayLabel.AutoSize = true;
            this.schedulerReleasedStatusDisplayLabel.Location = new System.Drawing.Point(315, 33);
            this.schedulerReleasedStatusDisplayLabel.Name = "schedulerReleasedStatusDisplayLabel";
            this.schedulerReleasedStatusDisplayLabel.Size = new System.Drawing.Size(10, 13);
            this.schedulerReleasedStatusDisplayLabel.TabIndex = 17;
            this.schedulerReleasedStatusDisplayLabel.Text = "-";
            // 
            // schedulerReleasedStatusLabel
            // 
            this.schedulerReleasedStatusLabel.AutoSize = true;
            this.schedulerReleasedStatusLabel.Location = new System.Drawing.Point(269, 33);
            this.schedulerReleasedStatusLabel.Name = "schedulerReleasedStatusLabel";
            this.schedulerReleasedStatusLabel.Size = new System.Drawing.Size(40, 13);
            this.schedulerReleasedStatusLabel.TabIndex = 16;
            this.schedulerReleasedStatusLabel.Text = "Status:";
            // 
            // UserSeeTimetableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 472);
            this.Controls.Add(this.schedulerReleasedStatusDisplayLabel);
            this.Controls.Add(this.schedulerReleasedStatusLabel);
            this.Controls.Add(this.userTimetableGroupBox);
            this.Controls.Add(this.userLocationSeeTimetableComboBox);
            this.Controls.Add(this.userHomeButton);
            this.Controls.Add(this.userLocationSeeTimetableLabel);
            this.Name = "UserSeeTimetableForm";
            this.Text = "User - See Timetable";
            this.Load += new System.EventHandler(this.UserSeeTimetableForm_Load);
            this.userTimetableGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userTimetableDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userLocationSeeTimetableLabel;
        private System.Windows.Forms.Button userHomeButton;
        private System.Windows.Forms.ComboBox userLocationSeeTimetableComboBox;
        private System.Windows.Forms.GroupBox userTimetableGroupBox;
        private System.Windows.Forms.DataGridView userTimetableDataGridView;
        private System.Windows.Forms.Label schedulerReleasedStatusDisplayLabel;
        private System.Windows.Forms.Label schedulerReleasedStatusLabel;
    }
}