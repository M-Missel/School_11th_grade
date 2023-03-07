namespace Real_partition_sum
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
            this.TB_Number = new System.Windows.Forms.TextBox();
            this.TB_Output = new System.Windows.Forms.TextBox();
            this.BTN_ETS = new System.Windows.Forms.Button();
            this.LB_Output = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TB_Number
            // 
            this.TB_Number.Location = new System.Drawing.Point(310, 68);
            this.TB_Number.Name = "TB_Number";
            this.TB_Number.Size = new System.Drawing.Size(181, 20);
            this.TB_Number.TabIndex = 0;
            // 
            // TB_Output
            // 
            this.TB_Output.Location = new System.Drawing.Point(309, 160);
            this.TB_Output.Name = "TB_Output";
            this.TB_Output.Size = new System.Drawing.Size(181, 20);
            this.TB_Output.TabIndex = 1;
            // 
            // BTN_ETS
            // 
            this.BTN_ETS.Location = new System.Drawing.Point(310, 106);
            this.BTN_ETS.Name = "BTN_ETS";
            this.BTN_ETS.Size = new System.Drawing.Size(180, 32);
            this.BTN_ETS.TabIndex = 2;
            this.BTN_ETS.Text = "Calculation";
            this.BTN_ETS.UseVisualStyleBackColor = true;
            this.BTN_ETS.Click += new System.EventHandler(this.BTN_Calc_Ets);
            // 
            // LB_Output
            // 
            this.LB_Output.FormattingEnabled = true;
            this.LB_Output.Location = new System.Drawing.Point(310, 275);
            this.LB_Output.Name = "LB_Output";
            this.LB_Output.Size = new System.Drawing.Size(179, 147);
            this.LB_Output.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(310, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "Calculation_2";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BTN_Calc_Ets_Numbers);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LB_Output);
            this.Controls.Add(this.BTN_ETS);
            this.Controls.Add(this.TB_Output);
            this.Controls.Add(this.TB_Number);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Number;
        private System.Windows.Forms.TextBox TB_Output;
        private System.Windows.Forms.Button BTN_ETS;
        private System.Windows.Forms.ListBox LB_Output;
        private System.Windows.Forms.Button button1;
    }
}

