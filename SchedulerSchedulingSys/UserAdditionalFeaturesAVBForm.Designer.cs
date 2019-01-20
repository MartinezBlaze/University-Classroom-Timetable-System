namespace UserSchedulingSystem
{
    partial class userAudioVisualBookingForm
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
            this.userSubmitButton = new System.Windows.Forms.Button();
            this.userBackButton = new System.Windows.Forms.Button();
            this.userAudioVisualBookingLabel = new System.Windows.Forms.Label();
            this.userNoneRadioButton = new System.Windows.Forms.RadioButton();
            this.userYesRadioButton = new System.Windows.Forms.RadioButton();
            this.userAudioVisualGroupBox = new System.Windows.Forms.GroupBox();
            this.userMicrophoneCheckBox = new System.Windows.Forms.CheckBox();
            this.userProjectorScreenCheckBox = new System.Windows.Forms.CheckBox();
            this.userSoundSystemCheckBox = new System.Windows.Forms.CheckBox();
            this.userProjectorCheckBox = new System.Windows.Forms.CheckBox();
            this.userNoticeLabel = new System.Windows.Forms.Label();
            this.userNoticeExplanationlabel = new System.Windows.Forms.Label();
            this.userWarningLabel = new System.Windows.Forms.Label();
            this.userPlaceYourBookingGroupBox = new System.Windows.Forms.GroupBox();
            this.userAudioVisualGroupBox.SuspendLayout();
            this.userPlaceYourBookingGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // userSubmitButton
            // 
            this.userSubmitButton.Location = new System.Drawing.Point(302, 312);
            this.userSubmitButton.Name = "userSubmitButton";
            this.userSubmitButton.Size = new System.Drawing.Size(75, 23);
            this.userSubmitButton.TabIndex = 1;
            this.userSubmitButton.Text = "Submit";
            this.userSubmitButton.UseVisualStyleBackColor = true;
            this.userSubmitButton.Click += new System.EventHandler(this.userSubmitButton_Click);
            // 
            // userBackButton
            // 
            this.userBackButton.Location = new System.Drawing.Point(12, 312);
            this.userBackButton.Name = "userBackButton";
            this.userBackButton.Size = new System.Drawing.Size(75, 23);
            this.userBackButton.TabIndex = 2;
            this.userBackButton.Text = "<< Back";
            this.userBackButton.UseVisualStyleBackColor = true;
            this.userBackButton.Click += new System.EventHandler(this.userBackButton_Click);
            // 
            // userAudioVisualBookingLabel
            // 
            this.userAudioVisualBookingLabel.AutoSize = true;
            this.userAudioVisualBookingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userAudioVisualBookingLabel.Location = new System.Drawing.Point(92, 25);
            this.userAudioVisualBookingLabel.Name = "userAudioVisualBookingLabel";
            this.userAudioVisualBookingLabel.Size = new System.Drawing.Size(279, 25);
            this.userAudioVisualBookingLabel.TabIndex = 3;
            this.userAudioVisualBookingLabel.Text = "AUDIO VISUAL BOOKING";
            // 
            // userNoneRadioButton
            // 
            this.userNoneRadioButton.AutoSize = true;
            this.userNoneRadioButton.Location = new System.Drawing.Point(27, 18);
            this.userNoneRadioButton.Name = "userNoneRadioButton";
            this.userNoneRadioButton.Size = new System.Drawing.Size(51, 17);
            this.userNoneRadioButton.TabIndex = 4;
            this.userNoneRadioButton.TabStop = true;
            this.userNoneRadioButton.Text = "None";
            this.userNoneRadioButton.UseVisualStyleBackColor = true;
            this.userNoneRadioButton.CheckedChanged += new System.EventHandler(this.userNoneRadioButton_CheckedChanged);
            // 
            // userYesRadioButton
            // 
            this.userYesRadioButton.AutoSize = true;
            this.userYesRadioButton.Location = new System.Drawing.Point(27, 41);
            this.userYesRadioButton.Name = "userYesRadioButton";
            this.userYesRadioButton.Size = new System.Drawing.Size(43, 17);
            this.userYesRadioButton.TabIndex = 5;
            this.userYesRadioButton.TabStop = true;
            this.userYesRadioButton.Text = "Yes";
            this.userYesRadioButton.UseVisualStyleBackColor = true;
            this.userYesRadioButton.CheckedChanged += new System.EventHandler(this.userYesRadioButton_CheckedChanged);
            // 
            // userAudioVisualGroupBox
            // 
            this.userAudioVisualGroupBox.Controls.Add(this.userMicrophoneCheckBox);
            this.userAudioVisualGroupBox.Controls.Add(this.userProjectorScreenCheckBox);
            this.userAudioVisualGroupBox.Controls.Add(this.userSoundSystemCheckBox);
            this.userAudioVisualGroupBox.Controls.Add(this.userProjectorCheckBox);
            this.userAudioVisualGroupBox.Location = new System.Drawing.Point(17, 171);
            this.userAudioVisualGroupBox.Name = "userAudioVisualGroupBox";
            this.userAudioVisualGroupBox.Size = new System.Drawing.Size(150, 107);
            this.userAudioVisualGroupBox.TabIndex = 6;
            this.userAudioVisualGroupBox.TabStop = false;
            this.userAudioVisualGroupBox.Text = "Audio Visual";
            // 
            // userMicrophoneCheckBox
            // 
            this.userMicrophoneCheckBox.AutoSize = true;
            this.userMicrophoneCheckBox.Location = new System.Drawing.Point(6, 79);
            this.userMicrophoneCheckBox.Name = "userMicrophoneCheckBox";
            this.userMicrophoneCheckBox.Size = new System.Drawing.Size(82, 17);
            this.userMicrophoneCheckBox.TabIndex = 9;
            this.userMicrophoneCheckBox.Text = "Microphone";
            this.userMicrophoneCheckBox.UseVisualStyleBackColor = true;
            // 
            // userProjectorScreenCheckBox
            // 
            this.userProjectorScreenCheckBox.AutoSize = true;
            this.userProjectorScreenCheckBox.Location = new System.Drawing.Point(6, 39);
            this.userProjectorScreenCheckBox.Name = "userProjectorScreenCheckBox";
            this.userProjectorScreenCheckBox.Size = new System.Drawing.Size(105, 17);
            this.userProjectorScreenCheckBox.TabIndex = 10;
            this.userProjectorScreenCheckBox.Text = "Projector Screen";
            this.userProjectorScreenCheckBox.UseVisualStyleBackColor = true;
            // 
            // userSoundSystemCheckBox
            // 
            this.userSoundSystemCheckBox.AutoSize = true;
            this.userSoundSystemCheckBox.Location = new System.Drawing.Point(6, 59);
            this.userSoundSystemCheckBox.Name = "userSoundSystemCheckBox";
            this.userSoundSystemCheckBox.Size = new System.Drawing.Size(94, 17);
            this.userSoundSystemCheckBox.TabIndex = 8;
            this.userSoundSystemCheckBox.Text = "Sound System";
            this.userSoundSystemCheckBox.UseVisualStyleBackColor = true;
            // 
            // userProjectorCheckBox
            // 
            this.userProjectorCheckBox.AutoSize = true;
            this.userProjectorCheckBox.Location = new System.Drawing.Point(6, 19);
            this.userProjectorCheckBox.Name = "userProjectorCheckBox";
            this.userProjectorCheckBox.Size = new System.Drawing.Size(68, 17);
            this.userProjectorCheckBox.TabIndex = 7;
            this.userProjectorCheckBox.Text = "Projector";
            this.userProjectorCheckBox.UseVisualStyleBackColor = true;
            // 
            // userNoticeLabel
            // 
            this.userNoticeLabel.AutoSize = true;
            this.userNoticeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNoticeLabel.Location = new System.Drawing.Point(201, 90);
            this.userNoticeLabel.Name = "userNoticeLabel";
            this.userNoticeLabel.Size = new System.Drawing.Size(48, 9);
            this.userNoticeLabel.TabIndex = 7;
            this.userNoticeLabel.Text = "*NOTICE:";
            // 
            // userNoticeExplanationlabel
            // 
            this.userNoticeExplanationlabel.AutoSize = true;
            this.userNoticeExplanationlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNoticeExplanationlabel.Location = new System.Drawing.Point(201, 101);
            this.userNoticeExplanationlabel.Name = "userNoticeExplanationlabel";
            this.userNoticeExplanationlabel.Size = new System.Drawing.Size(220, 36);
            this.userNoticeExplanationlabel.TabIndex = 8;
            this.userNoticeExplanationlabel.Text = "* The Audio Visual Booking must be done at least \r\n5 days in advance before the e" +
    "vent commencement.\r\n* The scheduler has the right to cancel the booking.";
            // 
            // userWarningLabel
            // 
            this.userWarningLabel.AutoSize = true;
            this.userWarningLabel.Location = new System.Drawing.Point(200, 159);
            this.userWarningLabel.Name = "userWarningLabel";
            this.userWarningLabel.Size = new System.Drawing.Size(76, 13);
            this.userWarningLabel.TabIndex = 9;
            this.userWarningLabel.Text = "Warning Label";
            this.userWarningLabel.Click += new System.EventHandler(this.userWarningLabel_Click);
            // 
            // userPlaceYourBookingGroupBox
            // 
            this.userPlaceYourBookingGroupBox.Controls.Add(this.userNoneRadioButton);
            this.userPlaceYourBookingGroupBox.Controls.Add(this.userYesRadioButton);
            this.userPlaceYourBookingGroupBox.Location = new System.Drawing.Point(17, 85);
            this.userPlaceYourBookingGroupBox.Name = "userPlaceYourBookingGroupBox";
            this.userPlaceYourBookingGroupBox.Size = new System.Drawing.Size(144, 70);
            this.userPlaceYourBookingGroupBox.TabIndex = 10;
            this.userPlaceYourBookingGroupBox.TabStop = false;
            this.userPlaceYourBookingGroupBox.Text = "Place your booking";
            // 
            // userAudioVisualBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 347);
            this.Controls.Add(this.userPlaceYourBookingGroupBox);
            this.Controls.Add(this.userWarningLabel);
            this.Controls.Add(this.userNoticeExplanationlabel);
            this.Controls.Add(this.userNoticeLabel);
            this.Controls.Add(this.userAudioVisualGroupBox);
            this.Controls.Add(this.userAudioVisualBookingLabel);
            this.Controls.Add(this.userBackButton);
            this.Controls.Add(this.userSubmitButton);
            this.Name = "userAudioVisualBookingForm";
            this.Text = "User  - AUDIO VISUAL BOOKING (Additional Features)";
            this.Load += new System.EventHandler(this.UserAudioVisualBookingForm_Load);
            this.userAudioVisualGroupBox.ResumeLayout(false);
            this.userAudioVisualGroupBox.PerformLayout();
            this.userPlaceYourBookingGroupBox.ResumeLayout(false);
            this.userPlaceYourBookingGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button userSubmitButton;
        private System.Windows.Forms.Button userBackButton;
        private System.Windows.Forms.Label userAudioVisualBookingLabel;
        private System.Windows.Forms.RadioButton userNoneRadioButton;
        private System.Windows.Forms.RadioButton userYesRadioButton;
        private System.Windows.Forms.GroupBox userAudioVisualGroupBox;
        private System.Windows.Forms.CheckBox userProjectorCheckBox;
        private System.Windows.Forms.CheckBox userSoundSystemCheckBox;
        private System.Windows.Forms.CheckBox userMicrophoneCheckBox;
        private System.Windows.Forms.CheckBox userProjectorScreenCheckBox;
        private System.Windows.Forms.Label userNoticeLabel;
        private System.Windows.Forms.Label userNoticeExplanationlabel;
        private System.Windows.Forms.Label userWarningLabel;
        private System.Windows.Forms.GroupBox userPlaceYourBookingGroupBox;
    }
}