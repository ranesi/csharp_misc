namespace Project_12_2 {
    partial class frmOptions {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstTicketNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.nudMinutesPerWindow = new System.Windows.Forms.NumericUpDown();
            this.nudGuestsPerWindow = new System.Windows.Forms.NumericUpDown();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutesPerWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGuestsPerWindow)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Minutes per window:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Guests  per window:";
            // 
            // txtFirstTicketNumber
            // 
            this.txtFirstTicketNumber.Location = new System.Drawing.Point(123, 120);
            this.txtFirstTicketNumber.Name = "txtFirstTicketNumber";
            this.txtFirstTicketNumber.Size = new System.Drawing.Size(200, 20);
            this.txtFirstTicketNumber.TabIndex = 4;
            this.txtFirstTicketNumber.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Start time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "End time:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "First ticket number:";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(200, 161);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(123, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.ButtonClick);
            // 
            // nudMinutesPerWindow
            // 
            this.nudMinutesPerWindow.Location = new System.Drawing.Point(123, 16);
            this.nudMinutesPerWindow.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudMinutesPerWindow.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMinutesPerWindow.Name = "nudMinutesPerWindow";
            this.nudMinutesPerWindow.Size = new System.Drawing.Size(200, 20);
            this.nudMinutesPerWindow.TabIndex = 0;
            this.nudMinutesPerWindow.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // nudGuestsPerWindow
            // 
            this.nudGuestsPerWindow.Location = new System.Drawing.Point(123, 42);
            this.nudGuestsPerWindow.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudGuestsPerWindow.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudGuestsPerWindow.Name = "nudGuestsPerWindow";
            this.nudGuestsPerWindow.Size = new System.Drawing.Size(200, 20);
            this.nudGuestsPerWindow.TabIndex = 1;
            this.nudGuestsPerWindow.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.CustomFormat = "H:mm MM/dd/yy";
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartTime.Location = new System.Drawing.Point(123, 68);
            this.dtpStartTime.MaxDate = new System.DateTime(2525, 12, 31, 0, 0, 0, 0);
            this.dtpStartTime.MinDate = new System.DateTime(2016, 11, 25, 0, 0, 0, 0);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.ShowUpDown = true;
            this.dtpStartTime.Size = new System.Drawing.Size(200, 20);
            this.dtpStartTime.TabIndex = 2;
            this.dtpStartTime.Value = new System.DateTime(2016, 11, 26, 10, 0, 0, 0);
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.CustomFormat = "H:mm MM/dd/yy";
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndTime.Location = new System.Drawing.Point(123, 94);
            this.dtpEndTime.MaxDate = new System.DateTime(2525, 12, 31, 0, 0, 0, 0);
            this.dtpEndTime.MinDate = new System.DateTime(2016, 11, 25, 0, 0, 0, 0);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.ShowUpDown = true;
            this.dtpEndTime.Size = new System.Drawing.Size(200, 20);
            this.dtpEndTime.TabIndex = 3;
            this.dtpEndTime.Value = new System.DateTime(2016, 11, 26, 0, 0, 0, 0);
            // 
            // frmOptions
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 196);
            this.ControlBox = false;
            this.Controls.Add(this.dtpEndTime);
            this.Controls.Add(this.dtpStartTime);
            this.Controls.Add(this.nudGuestsPerWindow);
            this.Controls.Add(this.nudMinutesPerWindow);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFirstTicketNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOptions";
            this.Text = "Options";
            this.Load += new System.EventHandler(this.frmOptions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutesPerWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGuestsPerWindow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirstTicketNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.NumericUpDown nudMinutesPerWindow;
        private System.Windows.Forms.NumericUpDown nudGuestsPerWindow;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
    }
}