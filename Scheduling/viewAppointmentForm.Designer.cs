using System.Windows.Forms;

namespace Scheduling
{
    partial class viewAppointmentForm
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
            this.weeklyAptRadio = new System.Windows.Forms.RadioButton();
            this.monthlyAptRadio = new System.Windows.Forms.RadioButton();
            this.allAptRadio = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1079, 263);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.Location = new System.Drawing.Point(492, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Calendar View Panel";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(1008, 348);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(81, 32);
            this.cancelBtn.TabIndex = 17;
            this.cancelBtn.Text = "Close";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // weeklyAptRadio
            // 
            this.weeklyAptRadio.AutoSize = true;
            this.weeklyAptRadio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.weeklyAptRadio.Location = new System.Drawing.Point(177, 353);
            this.weeklyAptRadio.Name = "weeklyAptRadio";
            this.weeklyAptRadio.Size = new System.Drawing.Size(161, 23);
            this.weeklyAptRadio.TabIndex = 18;
            this.weeklyAptRadio.TabStop = true;
            this.weeklyAptRadio.Text = "Weekly Appointments";
            this.weeklyAptRadio.UseVisualStyleBackColor = true;
            this.weeklyAptRadio.CheckedChanged += new System.EventHandler(this.weeklyAptRadio_CheckedChanged);
            // 
            // monthlyAptRadio
            // 
            this.monthlyAptRadio.AutoSize = true;
            this.monthlyAptRadio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.monthlyAptRadio.Location = new System.Drawing.Point(492, 353);
            this.monthlyAptRadio.Name = "monthlyAptRadio";
            this.monthlyAptRadio.Size = new System.Drawing.Size(170, 23);
            this.monthlyAptRadio.TabIndex = 19;
            this.monthlyAptRadio.TabStop = true;
            this.monthlyAptRadio.Text = "Monthly Appointments";
            this.monthlyAptRadio.UseVisualStyleBackColor = true;
            this.monthlyAptRadio.CheckedChanged += new System.EventHandler(this.monthlyAptRadio_CheckedChanged);
            // 
            // allAptRadio
            // 
            this.allAptRadio.AutoSize = true;
            this.allAptRadio.Checked = true;
            this.allAptRadio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.allAptRadio.Location = new System.Drawing.Point(800, 353);
            this.allAptRadio.Name = "allAptRadio";
            this.allAptRadio.Size = new System.Drawing.Size(133, 23);
            this.allAptRadio.TabIndex = 20;
            this.allAptRadio.TabStop = true;
            this.allAptRadio.Text = "All Appointments";
            this.allAptRadio.UseVisualStyleBackColor = true;
            this.allAptRadio.CheckedChanged += new System.EventHandler(this.allAptRadio_CheckedChanged);
            // 
            // viewAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 390);
            this.Controls.Add(this.allAptRadio);
            this.Controls.Add(this.monthlyAptRadio);
            this.Controls.Add(this.weeklyAptRadio);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "viewAppointmentForm";
            this.Text = "View Appotments";
            this.Load += new System.EventHandler(this.viewAppointmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.RadioButton weeklyAptRadio;
        private System.Windows.Forms.RadioButton monthlyAptRadio;
        private System.Windows.Forms.RadioButton allAptRadio;
    }
}