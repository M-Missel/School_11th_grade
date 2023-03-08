namespace AIT_Amicable_numbers
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
            this.TB_Input = new System.Windows.Forms.TextBox();
            this.BTN_Calc_AN = new System.Windows.Forms.Button();
            this.LB_Output = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // TB_Input
            // 
            this.TB_Input.Location = new System.Drawing.Point(267, 47);
            this.TB_Input.Name = "TB_Input";
            this.TB_Input.Size = new System.Drawing.Size(226, 20);
            this.TB_Input.TabIndex = 0;
            // 
            // BTN_Calc_AN
            // 
            this.BTN_Calc_AN.Location = new System.Drawing.Point(267, 82);
            this.BTN_Calc_AN.Name = "BTN_Calc_AN";
            this.BTN_Calc_AN.Size = new System.Drawing.Size(225, 31);
            this.BTN_Calc_AN.TabIndex = 1;
            this.BTN_Calc_AN.Text = "Calculate";
            this.BTN_Calc_AN.UseVisualStyleBackColor = true;
            this.BTN_Calc_AN.Click += new System.EventHandler(this.BTN_Calc);
            // 
            // LB_Output
            // 
            this.LB_Output.FormattingEnabled = true;
            this.LB_Output.Location = new System.Drawing.Point(267, 133);
            this.LB_Output.Name = "LB_Output";
            this.LB_Output.Size = new System.Drawing.Size(225, 186);
            this.LB_Output.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LB_Output);
            this.Controls.Add(this.BTN_Calc_AN);
            this.Controls.Add(this.TB_Input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Input;
        private System.Windows.Forms.Button BTN_Calc_AN;
        private System.Windows.Forms.ListBox LB_Output;
    }
}

