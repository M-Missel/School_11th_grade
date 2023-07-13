namespace Recursion_Task_3
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
            this.L_Upper_Limit = new System.Windows.Forms.Label();
            this.L_Count_Fibo = new System.Windows.Forms.Label();
            this.TB_Upper_Limit = new System.Windows.Forms.TextBox();
            this.LB_Output = new System.Windows.Forms.ListBox();
            this.BTN_Calc_Fibo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // L_Upper_Limit
            // 
            this.L_Upper_Limit.AutoSize = true;
            this.L_Upper_Limit.Location = new System.Drawing.Point(26, 26);
            this.L_Upper_Limit.Name = "L_Upper_Limit";
            this.L_Upper_Limit.Size = new System.Drawing.Size(56, 13);
            this.L_Upper_Limit.TabIndex = 0;
            this.L_Upper_Limit.Text = "Upper limit";
            // 
            // L_Count_Fibo
            // 
            this.L_Count_Fibo.AutoSize = true;
            this.L_Count_Fibo.Location = new System.Drawing.Point(286, 73);
            this.L_Count_Fibo.Name = "L_Count_Fibo";
            this.L_Count_Fibo.Size = new System.Drawing.Size(41, 13);
            this.L_Count_Fibo.TabIndex = 1;
            this.L_Count_Fibo.Text = "fib(x) = ";
            // 
            // TB_Upper_Limit
            // 
            this.TB_Upper_Limit.Location = new System.Drawing.Point(88, 23);
            this.TB_Upper_Limit.Name = "TB_Upper_Limit";
            this.TB_Upper_Limit.Size = new System.Drawing.Size(54, 20);
            this.TB_Upper_Limit.TabIndex = 2;
            // 
            // LB_Output
            // 
            this.LB_Output.FormattingEnabled = true;
            this.LB_Output.Location = new System.Drawing.Point(29, 103);
            this.LB_Output.Name = "LB_Output";
            this.LB_Output.Size = new System.Drawing.Size(243, 303);
            this.LB_Output.TabIndex = 3;
            // 
            // BTN_Calc_Fibo
            // 
            this.BTN_Calc_Fibo.Location = new System.Drawing.Point(31, 58);
            this.BTN_Calc_Fibo.Name = "BTN_Calc_Fibo";
            this.BTN_Calc_Fibo.Size = new System.Drawing.Size(241, 39);
            this.BTN_Calc_Fibo.TabIndex = 4;
            this.BTN_Calc_Fibo.Text = "Calculate fib(month)";
            this.BTN_Calc_Fibo.UseVisualStyleBackColor = true;
            this.BTN_Calc_Fibo.Click += new System.EventHandler(this.BTN_Fibo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 450);
            this.Controls.Add(this.BTN_Calc_Fibo);
            this.Controls.Add(this.LB_Output);
            this.Controls.Add(this.TB_Upper_Limit);
            this.Controls.Add(this.L_Count_Fibo);
            this.Controls.Add(this.L_Upper_Limit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_Upper_Limit;
        private System.Windows.Forms.Label L_Count_Fibo;
        private System.Windows.Forms.TextBox TB_Upper_Limit;
        private System.Windows.Forms.ListBox LB_Output;
        private System.Windows.Forms.Button BTN_Calc_Fibo;
    }
}

