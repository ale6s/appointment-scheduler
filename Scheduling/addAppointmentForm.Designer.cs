using System.Windows.Forms;

namespace Scheduling
{
    partial class addAppointmentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAptId = new System.Windows.Forms.TextBox();
            this.textBoxUserId = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.textBoxContact = new System.Windows.Forms.TextBox();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePickerStartTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEndTime = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.comboBoxcustomerId = new System.Windows.Forms.ComboBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.Location = new System.Drawing.Point(170, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Appointment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(30, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Appointment ID";
            // 
            // textBoxAptId
            // 
            this.textBoxAptId.AccessibleDescription = "";
            this.textBoxAptId.AccessibleName = "";
            this.textBoxAptId.Enabled = false;
            this.textBoxAptId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxAptId.Location = new System.Drawing.Point(144, 86);
            this.textBoxAptId.Name = "textBoxAptId";
            this.textBoxAptId.ReadOnly = true;
            this.textBoxAptId.Size = new System.Drawing.Size(265, 25);
            this.textBoxAptId.TabIndex = 2;
            // 
            // textBoxUserId
            // 
            this.textBoxUserId.AccessibleDescription = "";
            this.textBoxUserId.AccessibleName = "";
            this.textBoxUserId.Enabled = false;
            this.textBoxUserId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxUserId.Location = new System.Drawing.Point(144, 120);
            this.textBoxUserId.Name = "textBoxUserId";
            this.textBoxUserId.ReadOnly = true;
            this.textBoxUserId.Size = new System.Drawing.Size(265, 25);
            this.textBoxUserId.TabIndex = 3;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.AccessibleDescription = "";
            this.textBoxTitle.AccessibleName = "";
            this.textBoxTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxTitle.Location = new System.Drawing.Point(143, 223);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(265, 25);
            this.textBoxTitle.TabIndex = 5;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.AccessibleDescription = "";
            this.textBoxDescription.AccessibleName = "";
            this.textBoxDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxDescription.Location = new System.Drawing.Point(143, 257);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(265, 25);
            this.textBoxDescription.TabIndex = 6;
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.AccessibleDescription = "";
            this.textBoxLocation.AccessibleName = "";
            this.textBoxLocation.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxLocation.Location = new System.Drawing.Point(143, 292);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(265, 25);
            this.textBoxLocation.TabIndex = 7;
            // 
            // textBoxContact
            // 
            this.textBoxContact.AccessibleDescription = "";
            this.textBoxContact.AccessibleName = "";
            this.textBoxContact.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxContact.Location = new System.Drawing.Point(143, 327);
            this.textBoxContact.Name = "textBoxContact";
            this.textBoxContact.Size = new System.Drawing.Size(265, 25);
            this.textBoxContact.TabIndex = 8;
            // 
            // textBoxType
            // 
            this.textBoxType.AccessibleDescription = "";
            this.textBoxType.AccessibleName = "";
            this.textBoxType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxType.Location = new System.Drawing.Point(143, 361);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(265, 25);
            this.textBoxType.TabIndex = 9;
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.AccessibleDescription = "";
            this.textBoxUrl.AccessibleName = "";
            this.textBoxUrl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxUrl.Location = new System.Drawing.Point(143, 396);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(265, 25);
            this.textBoxUrl.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(30, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "User ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.Location = new System.Drawing.Point(30, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Customer ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.Location = new System.Drawing.Point(29, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Title";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.Location = new System.Drawing.Point(29, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "Description";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label7.Location = new System.Drawing.Point(29, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "Location";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label8.Location = new System.Drawing.Point(29, 330);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "Contact";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label9.Location = new System.Drawing.Point(29, 365);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 19);
            this.label9.TabIndex = 17;
            this.label9.Text = "Type";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label10.Location = new System.Drawing.Point(29, 400);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 19);
            this.label10.TabIndex = 18;
            this.label10.Text = "URL";
            // 
            // dateTimePickerStartTime
            // 
            this.dateTimePickerStartTime.CustomFormat = "yyyy-mm-dd HH:mm:ss";
            this.dateTimePickerStartTime.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dateTimePickerStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerStartTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePickerStartTime.Location = new System.Drawing.Point(142, 434);
            this.dateTimePickerStartTime.Name = "dateTimePickerStartTime";
            this.dateTimePickerStartTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePickerStartTime.Size = new System.Drawing.Size(265, 25);
            this.dateTimePickerStartTime.TabIndex = 20;
            this.dateTimePickerStartTime.Value = new System.DateTime(2022, 12, 23, 0, 0, 0, 0);
            // 
            // dateTimePickerEndTime
            // 
            this.dateTimePickerEndTime.CustomFormat = "yyyy-mm-dd HH:mm:ss";
            this.dateTimePickerEndTime.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dateTimePickerEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerEndTime.Location = new System.Drawing.Point(142, 469);
            this.dateTimePickerEndTime.Name = "dateTimePickerEndTime";
            this.dateTimePickerEndTime.Size = new System.Drawing.Size(265, 25);
            this.dateTimePickerEndTime.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label12.Location = new System.Drawing.Point(28, 441);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 19);
            this.label12.TabIndex = 23;
            this.label12.Text = "Start Time";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label13.Location = new System.Drawing.Point(28, 475);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 19);
            this.label13.TabIndex = 24;
            this.label13.Text = "End Time";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(143, 513);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(81, 32);
            this.saveBtn.TabIndex = 25;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(326, 513);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(81, 32);
            this.cancelBtn.TabIndex = 26;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // comboBoxcustomerId
            // 
            this.comboBoxcustomerId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxcustomerId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxcustomerId.FormattingEnabled = true;
            this.comboBoxcustomerId.Location = new System.Drawing.Point(143, 155);
            this.comboBoxcustomerId.Name = "comboBoxcustomerId";
            this.comboBoxcustomerId.Size = new System.Drawing.Size(265, 25);
            this.comboBoxcustomerId.TabIndex = 27;
            this.comboBoxcustomerId.SelectedIndexChanged += new System.EventHandler(this.comboBoxName_SelectedIndexChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.AccessibleDescription = "";
            this.textBoxName.AccessibleName = "";
            this.textBoxName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxName.Location = new System.Drawing.Point(142, 192);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(265, 25);
            this.textBoxName.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label14.Location = new System.Drawing.Point(30, 195);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(109, 19);
            this.label14.TabIndex = 29;
            this.label14.Text = "Customer Name";
            // 
            // addAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 564);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.comboBoxcustomerId);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dateTimePickerEndTime);
            this.Controls.Add(this.dateTimePickerStartTime);
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
            this.Controls.Add(this.textBoxAptId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "addAppointmentForm";
            this.Text = "Add New Appointment";
            this.Load += new System.EventHandler(this.addAppointmentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAptId;
        private System.Windows.Forms.TextBox textBoxUserId;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.TextBox textBoxContact;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndTime;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
        private ComboBox comboBoxcustomerId;
        private TextBox textBoxName;
        private Label label14;
        private DateTimePicker dateTimePickerStartTime;
    }
}