namespace Project_12_1 {
    partial class frmCalculator {
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
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnSquareRoot = new System.Windows.Forms.Button();
            this.btnReciprocal = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnAddition = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnPositiveNegative = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(13, 13);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(188, 20);
            this.txtOutput.TabIndex = 0;
            this.txtOutput.TabStop = false;
            this.txtOutput.Text = " ";
            this.txtOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtOutput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_Down);
            // 
            // btnBack
            // 
            this.btnBack.ForeColor = System.Drawing.Color.Red;
            this.btnBack.Location = new System.Drawing.Point(13, 40);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(71, 32);
            this.btnBack.TabIndex = 1;
            this.btnBack.TabStop = false;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.Button_Click);
            this.btnBack.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_Down);
            // 
            // btnClear
            // 
            this.btnClear.ForeColor = System.Drawing.Color.Red;
            this.btnClear.Location = new System.Drawing.Point(90, 40);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(111, 32);
            this.btnClear.TabIndex = 2;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.Button_Click);
            this.btnClear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_Down);
            // 
            // btn7
            // 
            this.btn7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn7.Location = new System.Drawing.Point(12, 78);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(33, 33);
            this.btn7.TabIndex = 3;
            this.btn7.TabStop = false;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.Button_Click);
            this.btn7.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_Down);
            // 
            // btn8
            // 
            this.btn8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn8.Location = new System.Drawing.Point(51, 78);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(33, 33);
            this.btn8.TabIndex = 4;
            this.btn8.TabStop = false;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.Button_Click);
            this.btn8.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_Down);
            // 
            // btn9
            // 
            this.btn9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn9.Location = new System.Drawing.Point(90, 78);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(33, 33);
            this.btn9.TabIndex = 5;
            this.btn9.TabStop = false;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.Button_Click);
            this.btn9.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_Down);
            // 
            // btnDivide
            // 
            this.btnDivide.ForeColor = System.Drawing.Color.Red;
            this.btnDivide.Location = new System.Drawing.Point(129, 78);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(33, 33);
            this.btnDivide.TabIndex = 6;
            this.btnDivide.TabStop = false;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.Button_Click);
            this.btnDivide.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_Down);
            // 
            // btnSquareRoot
            // 
            this.btnSquareRoot.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSquareRoot.Location = new System.Drawing.Point(168, 78);
            this.btnSquareRoot.Name = "btnSquareRoot";
            this.btnSquareRoot.Size = new System.Drawing.Size(33, 33);
            this.btnSquareRoot.TabIndex = 7;
            this.btnSquareRoot.TabStop = false;
            this.btnSquareRoot.Text = "sqrt";
            this.btnSquareRoot.UseVisualStyleBackColor = true;
            this.btnSquareRoot.Click += new System.EventHandler(this.Button_Click);
            this.btnSquareRoot.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_Down);
            // 
            // btnReciprocal
            // 
            this.btnReciprocal.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnReciprocal.Location = new System.Drawing.Point(168, 117);
            this.btnReciprocal.Name = "btnReciprocal";
            this.btnReciprocal.Size = new System.Drawing.Size(33, 33);
            this.btnReciprocal.TabIndex = 12;
            this.btnReciprocal.TabStop = false;
            this.btnReciprocal.Text = "1/X";
            this.btnReciprocal.UseVisualStyleBackColor = true;
            this.btnReciprocal.Click += new System.EventHandler(this.Button_Click);
            this.btnReciprocal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_Down);
            // 
            // btnMultiply
            // 
            this.btnMultiply.ForeColor = System.Drawing.Color.Red;
            this.btnMultiply.Location = new System.Drawing.Point(129, 117);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(33, 33);
            this.btnMultiply.TabIndex = 11;
            this.btnMultiply.TabStop = false;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.Button_Click);
            this.btnMultiply.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_Down);
            // 
            // btn6
            // 
            this.btn6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn6.Location = new System.Drawing.Point(90, 117);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(33, 33);
            this.btn6.TabIndex = 10;
            this.btn6.TabStop = false;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.Button_Click);
            this.btn6.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_Down);
            // 
            // btn5
            // 
            this.btn5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn5.Location = new System.Drawing.Point(51, 117);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(33, 33);
            this.btn5.TabIndex = 9;
            this.btn5.TabStop = false;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.Button_Click);
            this.btn5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_Down);
            // 
            // btn4
            // 
            this.btn4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn4.Location = new System.Drawing.Point(12, 117);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(33, 33);
            this.btn4.TabIndex = 8;
            this.btn4.TabStop = false;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.Button_Click);
            this.btn4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_Down);
            // 
            // btnEquals
            // 
            this.btnEquals.ForeColor = System.Drawing.Color.Red;
            this.btnEquals.Location = new System.Drawing.Point(168, 156);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(33, 72);
            this.btnEquals.TabIndex = 17;
            this.btnEquals.TabStop = false;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.Button_Click);
            this.btnEquals.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_Down);
            // 
            // btnSubtract
            // 
            this.btnSubtract.ForeColor = System.Drawing.Color.Red;
            this.btnSubtract.Location = new System.Drawing.Point(129, 156);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(33, 33);
            this.btnSubtract.TabIndex = 16;
            this.btnSubtract.TabStop = false;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.Button_Click);
            this.btnSubtract.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_Down);
            // 
            // btn3
            // 
            this.btn3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn3.Location = new System.Drawing.Point(90, 156);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(33, 33);
            this.btn3.TabIndex = 15;
            this.btn3.TabStop = false;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.Button_Click);
            this.btn3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_Down);
            // 
            // btn2
            // 
            this.btn2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn2.Location = new System.Drawing.Point(51, 156);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(33, 33);
            this.btn2.TabIndex = 14;
            this.btn2.TabStop = false;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.Button_Click);
            this.btn2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_Down);
            // 
            // btn1
            // 
            this.btn1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn1.Location = new System.Drawing.Point(12, 156);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(33, 33);
            this.btn1.TabIndex = 13;
            this.btn1.TabStop = false;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.Button_Click);
            this.btn1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_Down);
            // 
            // btnAddition
            // 
            this.btnAddition.ForeColor = System.Drawing.Color.Red;
            this.btnAddition.Location = new System.Drawing.Point(129, 195);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(33, 33);
            this.btnAddition.TabIndex = 21;
            this.btnAddition.TabStop = false;
            this.btnAddition.Text = "+";
            this.btnAddition.UseVisualStyleBackColor = true;
            this.btnAddition.Click += new System.EventHandler(this.Button_Click);
            this.btnAddition.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_Down);
            // 
            // btnDecimal
            // 
            this.btnDecimal.Location = new System.Drawing.Point(90, 195);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(33, 33);
            this.btnDecimal.TabIndex = 20;
            this.btnDecimal.TabStop = false;
            this.btnDecimal.Text = ".";
            this.btnDecimal.UseVisualStyleBackColor = true;
            this.btnDecimal.Click += new System.EventHandler(this.Button_Click);
            this.btnDecimal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_Down);
            // 
            // btnPositiveNegative
            // 
            this.btnPositiveNegative.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnPositiveNegative.Location = new System.Drawing.Point(51, 195);
            this.btnPositiveNegative.Name = "btnPositiveNegative";
            this.btnPositiveNegative.Size = new System.Drawing.Size(33, 33);
            this.btnPositiveNegative.TabIndex = 19;
            this.btnPositiveNegative.TabStop = false;
            this.btnPositiveNegative.Text = "+/-";
            this.btnPositiveNegative.UseVisualStyleBackColor = true;
            this.btnPositiveNegative.Click += new System.EventHandler(this.Button_Click);
            this.btnPositiveNegative.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_Down);
            // 
            // btn0
            // 
            this.btn0.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn0.Location = new System.Drawing.Point(12, 195);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(33, 33);
            this.btn0.TabIndex = 18;
            this.btn0.TabStop = false;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.Button_Click);
            this.btn0.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_Down);
            // 
            // frmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 241);
            this.Controls.Add(this.btnAddition);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btnPositiveNegative);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnReciprocal);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnSquareRoot);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtOutput);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCalculator";
            this.Text = "Calculator";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_Down);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnSquareRoot;
        private System.Windows.Forms.Button btnReciprocal;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnAddition;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btnPositiveNegative;
        private System.Windows.Forms.Button btn0;
    }
}

