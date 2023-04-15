using System.Windows.Forms;

namespace Scheduling
{
    partial class mainForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addAptBtn = new System.Windows.Forms.Button();
            this.modifyAptBtn = new System.Windows.Forms.Button();
            this.deleteAptBtn = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.viewAptBtn = new System.Windows.Forms.Button();
            this.reportAptBtn = new System.Windows.Forms.Button();
            this.consultAptBtn = new System.Windows.Forms.Button();
            this.customerAptBtn = new System.Windows.Forms.Button();
            this.LogOutBtn = new System.Windows.Forms.Button();
            this.addCustomerBtn = new System.Windows.Forms.Button();
            this.modifyCustomerBtn = new System.Windows.Forms.Button();
            this.deleteCustomerBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.buttonNotification = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.Location = new System.Drawing.Point(688, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Schedule Software";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(689, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Upcoming Appoitments";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1415, 406);
            this.dataGridView1.TabIndex = 0;
            // 
            // addAptBtn
            // 
            this.addAptBtn.Location = new System.Drawing.Point(598, 505);
            this.addAptBtn.Name = "addAptBtn";
            this.addAptBtn.Size = new System.Drawing.Size(81, 32);
            this.addAptBtn.TabIndex = 3;
            this.addAptBtn.Text = "Add";
            this.addAptBtn.UseVisualStyleBackColor = true;
            this.addAptBtn.Click += new System.EventHandler(this.addAptBtn_Click);
            // 
            // modifyAptBtn
            // 
            this.modifyAptBtn.Location = new System.Drawing.Point(729, 505);
            this.modifyAptBtn.Name = "modifyAptBtn";
            this.modifyAptBtn.Size = new System.Drawing.Size(81, 32);
            this.modifyAptBtn.TabIndex = 4;
            this.modifyAptBtn.Text = "Modify";
            this.modifyAptBtn.UseVisualStyleBackColor = true;
            this.modifyAptBtn.Click += new System.EventHandler(this.modifyAptBtn_Click);
            // 
            // deleteAptBtn
            // 
            this.deleteAptBtn.Location = new System.Drawing.Point(868, 505);
            this.deleteAptBtn.Name = "deleteAptBtn";
            this.deleteAptBtn.Size = new System.Drawing.Size(81, 32);
            this.deleteAptBtn.TabIndex = 5;
            this.deleteAptBtn.Text = "Delete";
            this.deleteAptBtn.UseVisualStyleBackColor = true;
            this.deleteAptBtn.Click += new System.EventHandler(this.deleteAptBtn_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 592);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1208, 234);
            this.dataGridView2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(589, 563);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Customers";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(1297, 563);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Controls";
            // 
            // viewAptBtn
            // 
            this.viewAptBtn.Location = new System.Drawing.Point(1235, 592);
            this.viewAptBtn.Name = "viewAptBtn";
            this.viewAptBtn.Size = new System.Drawing.Size(192, 35);
            this.viewAptBtn.TabIndex = 9;
            this.viewAptBtn.Text = "View All Appointments";
            this.viewAptBtn.UseVisualStyleBackColor = true;
            this.viewAptBtn.Click += new System.EventHandler(this.viewAptBtn_Click);
            // 
            // reportAptBtn
            // 
            this.reportAptBtn.Location = new System.Drawing.Point(1235, 632);
            this.reportAptBtn.Name = "reportAptBtn";
            this.reportAptBtn.Size = new System.Drawing.Size(192, 35);
            this.reportAptBtn.TabIndex = 10;
            this.reportAptBtn.Text = "Montly Appointments Count By Type Report";
            this.reportAptBtn.UseVisualStyleBackColor = true;
            this.reportAptBtn.Click += new System.EventHandler(this.reportAptBtn_Click);
            // 
            // consultAptBtn
            // 
            this.consultAptBtn.Location = new System.Drawing.Point(1235, 672);
            this.consultAptBtn.Name = "consultAptBtn";
            this.consultAptBtn.Size = new System.Drawing.Size(192, 35);
            this.consultAptBtn.TabIndex = 11;
            this.consultAptBtn.Text = "Schedule Appointmnet By Customer Report";
            this.consultAptBtn.UseVisualStyleBackColor = true;
            this.consultAptBtn.Click += new System.EventHandler(this.consultAptBtn_Click);
            // 
            // customerAptBtn
            // 
            this.customerAptBtn.Location = new System.Drawing.Point(1235, 712);
            this.customerAptBtn.Name = "customerAptBtn";
            this.customerAptBtn.Size = new System.Drawing.Size(192, 35);
            this.customerAptBtn.TabIndex = 12;
            this.customerAptBtn.Text = "Montly Appointments Count By Customer Report";
            this.customerAptBtn.UseVisualStyleBackColor = true;
            this.customerAptBtn.Click += new System.EventHandler(this.customerAptBtn_Click);
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.Location = new System.Drawing.Point(1235, 752);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(192, 35);
            this.LogOutBtn.TabIndex = 13;
            this.LogOutBtn.Text = "Log Off";
            this.LogOutBtn.UseVisualStyleBackColor = true;
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // addCustomerBtn
            // 
            this.addCustomerBtn.Location = new System.Drawing.Point(475, 841);
            this.addCustomerBtn.Name = "addCustomerBtn";
            this.addCustomerBtn.Size = new System.Drawing.Size(81, 32);
            this.addCustomerBtn.TabIndex = 14;
            this.addCustomerBtn.Text = "Add";
            this.addCustomerBtn.UseVisualStyleBackColor = true;
            this.addCustomerBtn.Click += new System.EventHandler(this.addCustomerBtn_Click);
            // 
            // modifyCustomerBtn
            // 
            this.modifyCustomerBtn.Location = new System.Drawing.Point(608, 841);
            this.modifyCustomerBtn.Name = "modifyCustomerBtn";
            this.modifyCustomerBtn.Size = new System.Drawing.Size(81, 32);
            this.modifyCustomerBtn.TabIndex = 15;
            this.modifyCustomerBtn.Text = "Modify";
            this.modifyCustomerBtn.UseVisualStyleBackColor = true;
            this.modifyCustomerBtn.Click += new System.EventHandler(this.modifyCustomerBtn_Click);
            // 
            // deleteCustomerBtn
            // 
            this.deleteCustomerBtn.Location = new System.Drawing.Point(741, 841);
            this.deleteCustomerBtn.Name = "deleteCustomerBtn";
            this.deleteCustomerBtn.Size = new System.Drawing.Size(81, 32);
            this.deleteCustomerBtn.TabIndex = 16;
            this.deleteCustomerBtn.Text = "Delete";
            this.deleteCustomerBtn.UseVisualStyleBackColor = true;
            this.deleteCustomerBtn.Click += new System.EventHandler(this.deleteCustomerBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(1235, 791);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(192, 35);
            this.exitBtn.TabIndex = 17;
            this.exitBtn.Text = "Exit Program";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // buttonNotification
            // 
            this.buttonNotification.BackColor = System.Drawing.SystemColors.Control;
            this.buttonNotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNotification.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonNotification.Location = new System.Drawing.Point(12, 25);
            this.buttonNotification.Name = "buttonNotification";
            this.buttonNotification.Size = new System.Drawing.Size(60, 43);
            this.buttonNotification.TabIndex = 19;
            this.buttonNotification.Text = "🔔";
            this.buttonNotification.UseVisualStyleBackColor = false;
            this.buttonNotification.Click += new System.EventHandler(this.buttonNotification_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1439, 885);
            this.Controls.Add(this.buttonNotification);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.deleteCustomerBtn);
            this.Controls.Add(this.modifyCustomerBtn);
            this.Controls.Add(this.addCustomerBtn);
            this.Controls.Add(this.LogOutBtn);
            this.Controls.Add(this.customerAptBtn);
            this.Controls.Add(this.consultAptBtn);
            this.Controls.Add(this.reportAptBtn);
            this.Controls.Add(this.viewAptBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.deleteAptBtn);
            this.Controls.Add(this.modifyAptBtn);
            this.Controls.Add(this.addAptBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "mainForm";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addAptBtn;
        private System.Windows.Forms.Button modifyAptBtn;
        private System.Windows.Forms.Button deleteAptBtn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button viewAptBtn;
        private System.Windows.Forms.Button reportAptBtn;
        private System.Windows.Forms.Button consultAptBtn;
        private System.Windows.Forms.Button customerAptBtn;
        private System.Windows.Forms.Button LogOutBtn;
        private System.Windows.Forms.Button addCustomerBtn;
        private System.Windows.Forms.Button modifyCustomerBtn;
        private System.Windows.Forms.Button deleteCustomerBtn;
        private System.Windows.Forms.Button exitBtn;
        private Button buttonNotification;
    }
}