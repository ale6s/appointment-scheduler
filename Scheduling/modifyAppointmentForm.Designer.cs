using System.Windows.Forms;

namespace Scheduling
{
    partial class modifyAppointmentForm
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
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.textBoxContact = new System.Windows.Forms.TextBox();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxUserId = new System.Windows.Forms.TextBox();
            this.textBoxAppointmentId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.dateTimePickerEndTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStartTime = new System.Windows.Forms.DateTimePicker();
            this.comboBoxcustomerId = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(318, 499);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(81, 32);
            this.cancelBtn.TabIndex = 53;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(135, 499);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(81, 32);
            this.saveBtn.TabIndex = 52;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label13.Location = new System.Drawing.Point(27, 462);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 19);
            this.label13.TabIndex = 51;
            this.label13.Text = "End Time";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label12.Location = new System.Drawing.Point(27, 427);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 19);
            this.label12.TabIndex = 50;
            this.label12.Text = "Start Time";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label10.Location = new System.Drawing.Point(27, 389);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 19);
            this.label10.TabIndex = 45;
            this.label10.Text = "URL";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label9.Location = new System.Drawing.Point(27, 355);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 19);
            this.label9.TabIndex = 44;
            this.label9.Text = "Type";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label8.Location = new System.Drawing.Point(27, 320);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 19);
            this.label8.TabIndex = 43;
            this.label8.Text = "Contact";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label7.Location = new System.Drawing.Point(27, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 19);
            this.label7.TabIndex = 42;
            this.label7.Text = "Location";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.Location = new System.Drawing.Point(27, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 19);
            this.label6.TabIndex = 41;
            this.label6.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.Location = new System.Drawing.Point(27, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 19);
            this.label5.TabIndex = 40;
            this.label5.Text = "Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.Location = new System.Drawing.Point(26, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 19);
            this.label4.TabIndex = 39;
            this.label4.Text = "Customer ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(27, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 38;
            this.label3.Text = "User ID";
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.AccessibleDescription = "";
            this.textBoxUrl.AccessibleName = "";
            this.textBoxUrl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxUrl.Location = new System.Drawing.Point(135, 387);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(265, 25);
            this.textBoxUrl.TabIndex = 37;
            // 
            // textBoxType
            // 
            this.textBoxType.AccessibleDescription = "";
            this.textBoxType.AccessibleName = "";
            this.textBoxType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxType.Location = new System.Drawing.Point(135, 352);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(265, 25);
            this.textBoxType.TabIndex = 36;
            // 
            // textBoxContact
            // 
            this.textBoxContact.AccessibleDescription = "";
            this.textBoxContact.AccessibleName = "";
            this.textBoxContact.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxContact.Location = new System.Drawing.Point(135, 317);
            this.textBoxContact.Name = "textBoxContact";
            this.textBoxContact.Size = new System.Drawing.Size(265, 25);
            this.textBoxContact.TabIndex = 35;
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.AccessibleDescription = "";
            this.textBoxLocation.AccessibleName = "";
            this.textBoxLocation.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxLocation.Location = new System.Drawing.Point(135, 283);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(265, 25);
            this.textBoxLocation.TabIndex = 34;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.AccessibleDescription = "";
            this.textBoxDescription.AccessibleName = "";
            this.textBoxDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxDescription.Location = new System.Drawing.Point(135, 248);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(265, 25);
            this.textBoxDescription.TabIndex = 33;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.AccessibleDescription = "";
            this.textBoxTitle.AccessibleName = "";
            this.textBoxTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxTitle.Location = new System.Drawing.Point(135, 213);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(265, 25);
            this.textBoxTitle.TabIndex = 32;
            // 
            // textBoxUserId
            // 
            this.textBoxUserId.AccessibleDescription = "";
            this.textBoxUserId.AccessibleName = "";
            this.textBoxUserId.Enabled = false;
            this.textBoxUserId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxUserId.Location = new System.Drawing.Point(135, 113);
            this.textBoxUserId.Name = "textBoxUserId";
            this.textBoxUserId.ReadOnly = true;
            this.textBoxUserId.Size = new System.Drawing.Size(265, 25);
            this.textBoxUserId.TabIndex = 30;
            // 
            // textBoxAppointmentId
            // 
            this.textBoxAppointmentId.AccessibleDescription = "";
            this.textBoxAppointmentId.AccessibleName = "";
            this.textBoxAppointmentId.Enabled = false;
            this.textBoxAppointmentId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxAppointmentId.Location = new System.Drawing.Point(135, 82);
            this.textBoxAppointmentId.Name = "textBoxAppointmentId";
            this.textBoxAppointmentId.ReadOnly = true;
            this.textBoxAppointmentId.Size = new System.Drawing.Size(265, 25);
            this.textBoxAppointmentId.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(27, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 28;
            this.label2.Text = "Appointment ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.Location = new System.Drawing.Point(166, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Modify Appointment";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label14.Location = new System.Drawing.Point(22, 185);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(109, 19);
            this.label14.TabIndex = 55;
            this.label14.Text = "Customer Name";
            // 
            // textBoxName
            // 
            this.textBoxName.AccessibleDescription = "";
            this.textBoxName.AccessibleName = "";
            this.textBoxName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxName.Location = new System.Drawing.Point(134, 182);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(265, 25);
            this.textBoxName.TabIndex = 54;
            // 
            // dateTimePickerEndTime
            // 
            this.dateTimePickerEndTime.CustomFormat = "yyyy-mm-dd HH:mm:ss";
            this.dateTimePickerEndTime.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dateTimePickerEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerEndTime.Location = new System.Drawing.Point(134, 456);
            this.dateTimePickerEndTime.Name = "dateTimePickerEndTime";
            this.dateTimePickerEndTime.Size = new System.Drawing.Size(265, 25);
            this.dateTimePickerEndTime.TabIndex = 57;
            // 
            // dateTimePickerStartTime
            // 
            this.dateTimePickerStartTime.CustomFormat = "yyyy-mm-dd HH:mm:ss";
            this.dateTimePickerStartTime.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dateTimePickerStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerStartTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePickerStartTime.Location = new System.Drawing.Point(134, 421);
            this.dateTimePickerStartTime.Name = "dateTimePickerStartTime";
            this.dateTimePickerStartTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePickerStartTime.Size = new System.Drawing.Size(265, 25);
            this.dateTimePickerStartTime.TabIndex = 56;
            this.dateTimePickerStartTime.Value = new System.DateTime(2022, 12, 23, 0, 0, 0, 0);
            // 
            // comboBoxcustomerId
            // 
            this.comboBoxcustomerId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxcustomerId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxcustomerId.FormattingEnabled = true;
            this.comboBoxcustomerId.Location = new System.Drawing.Point(134, 146);
            this.comboBoxcustomerId.Name = "comboBoxcustomerId";
            this.comboBoxcustomerId.Size = new System.Drawing.Size(265, 25);
            this.comboBoxcustomerId.TabIndex = 58;
            this.comboBoxcustomerId.SelectedIndexChanged += new System.EventHandler(this.comboBoxcustomerId_SelectedIndexChanged);
            // 
            // modifyAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 562);
            this.Controls.Add(this.comboBoxcustomerId);
            this.Controls.Add(this.dateTimePickerEndTime);
            this.Controls.Add(this.dateTimePickerStartTime);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxUrl);
            this.Controls.Add(this.textBoxType);
            this.Controls.Add(this.textBoxContact);
            this.Controls.Add(this.textBoxLocation);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.textBoxUserId);
            this.Controls.Add(this.textBoxAppointmentId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "modifyAppointmentForm";
            this.Text = "modifyAppointment1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.TextBox textBoxContact;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxUserId;
        private System.Windows.Forms.TextBox textBoxAppointmentId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Label label14;
        private TextBox textBoxName;
        private DateTimePicker dateTimePickerEndTime;
        private DateTimePicker dateTimePickerStartTime;
        private ComboBox comboBoxcustomerId;
    }
}