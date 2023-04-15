using System.Windows.Forms;

namespace Scheduling
{
    partial class viewAppointmentTypeReportForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.janRadio = new System.Windows.Forms.RadioButton();
            this.julRadio = new System.Windows.Forms.RadioButton();
            this.febRadio = new System.Windows.Forms.RadioButton();
            this.augRadio = new System.Windows.Forms.RadioButton();
            this.marRadio = new System.Windows.Forms.RadioButton();
            this.sepRadio = new System.Windows.Forms.RadioButton();
            this.aprRadio = new System.Windows.Forms.RadioButton();
            this.octRadio = new System.Windows.Forms.RadioButton();
            this.mayRadio = new System.Windows.Forms.RadioButton();
            this.novRadio = new System.Windows.Forms.RadioButton();
            this.junRadio = new System.Windows.Forms.RadioButton();
            this.decRadio = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(243, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(225, 244);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.Location = new System.Drawing.Point(136, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Appointment Type Report";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(387, 347);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(81, 32);
            this.cancelBtn.TabIndex = 18;
            this.cancelBtn.Text = "Close";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // janRadio
            // 
            this.janRadio.AutoSize = true;
            this.janRadio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.janRadio.Location = new System.Drawing.Point(32, 87);
            this.janRadio.Name = "janRadio";
            this.janRadio.Size = new System.Drawing.Size(74, 23);
            this.janRadio.TabIndex = 19;
            this.janRadio.TabStop = true;
            this.janRadio.Text = "January";
            this.janRadio.UseVisualStyleBackColor = true;
            this.janRadio.CheckedChanged += new System.EventHandler(this.janRadio_CheckedChanged);
            // 
            // julRadio
            // 
            this.julRadio.AutoSize = true;
            this.julRadio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.julRadio.Location = new System.Drawing.Point(136, 87);
            this.julRadio.Name = "julRadio";
            this.julRadio.Size = new System.Drawing.Size(50, 23);
            this.julRadio.TabIndex = 20;
            this.julRadio.TabStop = true;
            this.julRadio.Text = "July";
            this.julRadio.UseVisualStyleBackColor = true;
            this.julRadio.CheckedChanged += new System.EventHandler(this.julRadio_CheckedChanged);
            // 
            // febRadio
            // 
            this.febRadio.AutoSize = true;
            this.febRadio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.febRadio.Location = new System.Drawing.Point(32, 121);
            this.febRadio.Name = "febRadio";
            this.febRadio.Size = new System.Drawing.Size(81, 23);
            this.febRadio.TabIndex = 21;
            this.febRadio.TabStop = true;
            this.febRadio.Text = "February";
            this.febRadio.UseVisualStyleBackColor = true;
            this.febRadio.CheckedChanged += new System.EventHandler(this.febRadio_CheckedChanged);
            // 
            // augRadio
            // 
            this.augRadio.AutoSize = true;
            this.augRadio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.augRadio.Location = new System.Drawing.Point(136, 121);
            this.augRadio.Name = "augRadio";
            this.augRadio.Size = new System.Drawing.Size(71, 23);
            this.augRadio.TabIndex = 22;
            this.augRadio.TabStop = true;
            this.augRadio.Text = "August";
            this.augRadio.UseVisualStyleBackColor = true;
            this.augRadio.CheckedChanged += new System.EventHandler(this.augRadio_CheckedChanged);
            // 
            // marRadio
            // 
            this.marRadio.AutoSize = true;
            this.marRadio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.marRadio.Location = new System.Drawing.Point(32, 156);
            this.marRadio.Name = "marRadio";
            this.marRadio.Size = new System.Drawing.Size(66, 23);
            this.marRadio.TabIndex = 23;
            this.marRadio.TabStop = true;
            this.marRadio.Text = "March";
            this.marRadio.UseVisualStyleBackColor = true;
            this.marRadio.CheckedChanged += new System.EventHandler(this.marRadio_CheckedChanged);
            // 
            // sepRadio
            // 
            this.sepRadio.AutoSize = true;
            this.sepRadio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.sepRadio.Location = new System.Drawing.Point(136, 156);
            this.sepRadio.Name = "sepRadio";
            this.sepRadio.Size = new System.Drawing.Size(93, 23);
            this.sepRadio.TabIndex = 24;
            this.sepRadio.TabStop = true;
            this.sepRadio.Text = "September";
            this.sepRadio.UseVisualStyleBackColor = true;
            this.sepRadio.CheckedChanged += new System.EventHandler(this.sepRadio_CheckedChanged);
            // 
            // aprRadio
            // 
            this.aprRadio.AutoSize = true;
            this.aprRadio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.aprRadio.Location = new System.Drawing.Point(32, 191);
            this.aprRadio.Name = "aprRadio";
            this.aprRadio.Size = new System.Drawing.Size(55, 23);
            this.aprRadio.TabIndex = 25;
            this.aprRadio.TabStop = true;
            this.aprRadio.Text = "April";
            this.aprRadio.UseVisualStyleBackColor = true;
            this.aprRadio.CheckedChanged += new System.EventHandler(this.aprRadio_CheckedChanged);
            // 
            // octRadio
            // 
            this.octRadio.AutoSize = true;
            this.octRadio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.octRadio.Location = new System.Drawing.Point(136, 191);
            this.octRadio.Name = "octRadio";
            this.octRadio.Size = new System.Drawing.Size(77, 23);
            this.octRadio.TabIndex = 26;
            this.octRadio.TabStop = true;
            this.octRadio.Text = "October";
            this.octRadio.UseVisualStyleBackColor = true;
            this.octRadio.CheckedChanged += new System.EventHandler(this.octRadio_CheckedChanged);
            // 
            // mayRadio
            // 
            this.mayRadio.AutoSize = true;
            this.mayRadio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.mayRadio.Location = new System.Drawing.Point(32, 225);
            this.mayRadio.Name = "mayRadio";
            this.mayRadio.Size = new System.Drawing.Size(54, 23);
            this.mayRadio.TabIndex = 27;
            this.mayRadio.TabStop = true;
            this.mayRadio.Text = "May";
            this.mayRadio.UseVisualStyleBackColor = true;
            this.mayRadio.CheckedChanged += new System.EventHandler(this.mayRadio_CheckedChanged);
            // 
            // novRadio
            // 
            this.novRadio.AutoSize = true;
            this.novRadio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.novRadio.Location = new System.Drawing.Point(136, 225);
            this.novRadio.Name = "novRadio";
            this.novRadio.Size = new System.Drawing.Size(91, 23);
            this.novRadio.TabIndex = 28;
            this.novRadio.TabStop = true;
            this.novRadio.Text = "November";
            this.novRadio.UseVisualStyleBackColor = true;
            this.novRadio.CheckedChanged += new System.EventHandler(this.novRadio_CheckedChanged);
            // 
            // junRadio
            // 
            this.junRadio.AutoSize = true;
            this.junRadio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.junRadio.Location = new System.Drawing.Point(32, 260);
            this.junRadio.Name = "junRadio";
            this.junRadio.Size = new System.Drawing.Size(55, 23);
            this.junRadio.TabIndex = 29;
            this.junRadio.TabStop = true;
            this.junRadio.Text = "June";
            this.junRadio.UseVisualStyleBackColor = true;
            this.junRadio.CheckedChanged += new System.EventHandler(this.junRadio_CheckedChanged);
            // 
            // decRadio
            // 
            this.decRadio.AutoSize = true;
            this.decRadio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.decRadio.Location = new System.Drawing.Point(136, 260);
            this.decRadio.Name = "decRadio";
            this.decRadio.Size = new System.Drawing.Size(89, 23);
            this.decRadio.TabIndex = 30;
            this.decRadio.TabStop = true;
            this.decRadio.Text = "December";
            this.decRadio.UseVisualStyleBackColor = true;
            this.decRadio.CheckedChanged += new System.EventHandler(this.decRadio_CheckedChanged);
            // 
            // viewAppointmentTypeReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 420);
            this.Controls.Add(this.decRadio);
            this.Controls.Add(this.junRadio);
            this.Controls.Add(this.novRadio);
            this.Controls.Add(this.mayRadio);
            this.Controls.Add(this.octRadio);
            this.Controls.Add(this.aprRadio);
            this.Controls.Add(this.sepRadio);
            this.Controls.Add(this.marRadio);
            this.Controls.Add(this.augRadio);
            this.Controls.Add(this.febRadio);
            this.Controls.Add(this.julRadio);
            this.Controls.Add(this.janRadio);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "viewAppointmentTypeReportForm";
            this.Text = "View Appointment Type Report";
            this.Load += new System.EventHandler(this.viewAppointmentTypeReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.RadioButton janRadio;
        private System.Windows.Forms.RadioButton julRadio;
        private System.Windows.Forms.RadioButton febRadio;
        private System.Windows.Forms.RadioButton augRadio;
        private System.Windows.Forms.RadioButton marRadio;
        private System.Windows.Forms.RadioButton sepRadio;
        private System.Windows.Forms.RadioButton aprRadio;
        private System.Windows.Forms.RadioButton octRadio;
        private System.Windows.Forms.RadioButton mayRadio;
        private System.Windows.Forms.RadioButton novRadio;
        private System.Windows.Forms.RadioButton junRadio;
        private System.Windows.Forms.RadioButton decRadio;
    }
}