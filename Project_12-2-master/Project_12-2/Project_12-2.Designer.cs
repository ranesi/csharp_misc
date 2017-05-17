namespace Project_12_2 {
    partial class frmTicketAssign {
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblGuests = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnChooseTS = new System.Windows.Forms.Button();
            this.lblNextEntry = new System.Windows.Forms.Label();
            this.lblTicketsOutstanding = new System.Windows.Forms.Label();
            this.btnIssueTicket = new System.Windows.Forms.Button();
            this.lblNext = new System.Windows.Forms.Label();
            this.lblOutstanding = new System.Windows.Forms.Label();
            this.lbTickets = new System.Windows.Forms.ListBox();
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblGuests);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Guests with the following tickets may now enter:";
            // 
            // lblGuests
            // 
            this.lblGuests.AutoSize = true;
            this.lblGuests.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGuests.Location = new System.Drawing.Point(7, 33);
            this.lblGuests.Name = "lblGuests";
            this.lblGuests.Size = new System.Drawing.Size(0, 13);
            this.lblGuests.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnChooseTS);
            this.groupBox2.Controls.Add(this.lblNextEntry);
            this.groupBox2.Controls.Add(this.lblTicketsOutstanding);
            this.groupBox2.Controls.Add(this.btnIssueTicket);
            this.groupBox2.Controls.Add(this.lblNext);
            this.groupBox2.Controls.Add(this.lblOutstanding);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Location = new System.Drawing.Point(12, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 129);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ticket Availability";
            // 
            // btnChooseTS
            // 
            this.btnChooseTS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnChooseTS.Location = new System.Drawing.Point(181, 89);
            this.btnChooseTS.Name = "btnChooseTS";
            this.btnChooseTS.Size = new System.Drawing.Size(121, 23);
            this.btnChooseTS.TabIndex = 5;
            this.btnChooseTS.Text = "&Choose Timeslot";
            this.btnChooseTS.UseVisualStyleBackColor = true;
            this.btnChooseTS.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // lblNextEntry
            // 
            this.lblNextEntry.AutoSize = true;
            this.lblNextEntry.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNextEntry.Location = new System.Drawing.Point(166, 56);
            this.lblNextEntry.Name = "lblNextEntry";
            this.lblNextEntry.Size = new System.Drawing.Size(0, 13);
            this.lblNextEntry.TabIndex = 4;
            // 
            // lblTicketsOutstanding
            // 
            this.lblTicketsOutstanding.AutoSize = true;
            this.lblTicketsOutstanding.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTicketsOutstanding.Location = new System.Drawing.Point(166, 30);
            this.lblTicketsOutstanding.Name = "lblTicketsOutstanding";
            this.lblTicketsOutstanding.Size = new System.Drawing.Size(0, 13);
            this.lblTicketsOutstanding.TabIndex = 3;
            // 
            // btnIssueTicket
            // 
            this.btnIssueTicket.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnIssueTicket.Location = new System.Drawing.Point(6, 89);
            this.btnIssueTicket.Name = "btnIssueTicket";
            this.btnIssueTicket.Size = new System.Drawing.Size(121, 23);
            this.btnIssueTicket.TabIndex = 0;
            this.btnIssueTicket.Text = "&Issue Ticket";
            this.btnIssueTicket.UseVisualStyleBackColor = true;
            this.btnIssueTicket.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // lblNext
            // 
            this.lblNext.AutoSize = true;
            this.lblNext.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNext.Location = new System.Drawing.Point(8, 56);
            this.lblNext.Name = "lblNext";
            this.lblNext.Size = new System.Drawing.Size(103, 13);
            this.lblNext.TabIndex = 1;
            this.lblNext.Text = "Next available entry:";
            // 
            // lblOutstanding
            // 
            this.lblOutstanding.AutoSize = true;
            this.lblOutstanding.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblOutstanding.Location = new System.Drawing.Point(8, 30);
            this.lblOutstanding.Name = "lblOutstanding";
            this.lblOutstanding.Size = new System.Drawing.Size(126, 13);
            this.lblOutstanding.TabIndex = 0;
            this.lblOutstanding.Text = "Total tickets outstanding:";
            // 
            // lbTickets
            // 
            this.lbTickets.FormattingEnabled = true;
            this.lbTickets.Location = new System.Drawing.Point(12, 244);
            this.lbTickets.Name = "lbTickets";
            this.lbTickets.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbTickets.Size = new System.Drawing.Size(308, 160);
            this.lbTickets.TabIndex = 2;
            this.lbTickets.TabStop = false;
            // 
            // btnOptions
            // 
            this.btnOptions.Location = new System.Drawing.Point(12, 423);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(75, 23);
            this.btnOptions.TabIndex = 1;
            this.btnOptions.Text = "&Options";
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(245, 423);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.TimerTick);
            // 
            // frmTicketAssign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 458);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.lbTickets);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmTicketAssign";
            this.Load += new System.EventHandler(this.FormLoad);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblGuests;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnIssueTicket;
        private System.Windows.Forms.Label lblNext;
        private System.Windows.Forms.Label lblOutstanding;
        private System.Windows.Forms.ListBox lbTickets;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblNextEntry;
        private System.Windows.Forms.Label lblTicketsOutstanding;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnChooseTS;
    }
}

