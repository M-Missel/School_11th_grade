namespace AIT_Forms_Task_3
{
    partial class Form1
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
            this.T_Euro = new System.Windows.Forms.TextBox();
            this.T_Dollar = new System.Windows.Forms.TextBox();
            this.T_ExchangeRate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.B_Calc = new System.Windows.Forms.Button();
            this.B_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Euro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dollar";
            // 
            // T_Euro
            // 
            this.T_Euro.Location = new System.Drawing.Point(110, 67);
            this.T_Euro.Name = "T_Euro";
            this.T_Euro.Size = new System.Drawing.Size(100, 20);
            this.T_Euro.TabIndex = 2;
            // 
            // T_Dollar
            // 
            this.T_Dollar.Location = new System.Drawing.Point(297, 67);
            this.T_Dollar.Name = "T_Dollar";
            this.T_Dollar.Size = new System.Drawing.Size(100, 20);
            this.T_Dollar.TabIndex = 3;
            // 
            // T_ExchangeRate
            // 
            this.T_ExchangeRate.Location = new System.Drawing.Point(297, 107);
            this.T_ExchangeRate.Name = "T_ExchangeRate";
            this.T_ExchangeRate.Size = new System.Drawing.Size(100, 20);
            this.T_ExchangeRate.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "1 Euro in Dollar";
            // 
            // B_Calc
            // 
            this.B_Calc.Location = new System.Drawing.Point(116, 163);
            this.B_Calc.Name = "B_Calc";
            this.B_Calc.Size = new System.Drawing.Size(75, 23);
            this.B_Calc.TabIndex = 6;
            this.B_Calc.Text = "Calculate";
            this.B_Calc.UseVisualStyleBackColor = true;
            this.B_Calc.Click += new System.EventHandler(this.Calc_Dollar);
            // 
            // B_Exit
            // 
            this.B_Exit.Location = new System.Drawing.Point(297, 163);
            this.B_Exit.Name = "B_Exit";
            this.B_Exit.Size = new System.Drawing.Size(75, 23);
            this.B_Exit.TabIndex = 7;
            this.B_Exit.Text = "Exit";
            this.B_Exit.UseVisualStyleBackColor = true;
            this.B_Exit.Click += new System.EventHandler(this.Exit_Application);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 216);
            this.Controls.Add(this.B_Exit);
            this.Controls.Add(this.B_Calc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.T_ExchangeRate);
            this.Controls.Add(this.T_Dollar);
            this.Controls.Add(this.T_Euro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox T_Euro;
        private System.Windows.Forms.TextBox T_Dollar;
        private System.Windows.Forms.TextBox T_ExchangeRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button B_Calc;
        private System.Windows.Forms.Button B_Exit;
    }
}

