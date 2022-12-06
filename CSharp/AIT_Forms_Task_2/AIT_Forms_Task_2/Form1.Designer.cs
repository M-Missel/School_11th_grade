namespace AIT_Forms_Task_2
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
            this.label3 = new System.Windows.Forms.Label();
            this.T_Length = new System.Windows.Forms.TextBox();
            this.T_Width = new System.Windows.Forms.TextBox();
            this.T_Area = new System.Windows.Forms.TextBox();
            this.B_Calc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lenght";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Area";
            // 
            // T_Length
            // 
            this.T_Length.Location = new System.Drawing.Point(263, 27);
            this.T_Length.Name = "T_Length";
            this.T_Length.Size = new System.Drawing.Size(100, 20);
            this.T_Length.TabIndex = 3;
            // 
            // T_Width
            // 
            this.T_Width.Location = new System.Drawing.Point(263, 62);
            this.T_Width.Name = "T_Width";
            this.T_Width.Size = new System.Drawing.Size(100, 20);
            this.T_Width.TabIndex = 4;
            // 
            // T_Area
            // 
            this.T_Area.Location = new System.Drawing.Point(263, 123);
            this.T_Area.Name = "T_Area";
            this.T_Area.Size = new System.Drawing.Size(100, 20);
            this.T_Area.TabIndex = 5;
            // 
            // B_Calc
            // 
            this.B_Calc.Location = new System.Drawing.Point(275, 94);
            this.B_Calc.Name = "B_Calc";
            this.B_Calc.Size = new System.Drawing.Size(75, 23);
            this.B_Calc.TabIndex = 6;
            this.B_Calc.Text = "Calculate";
            this.B_Calc.UseVisualStyleBackColor = true;
            this.B_Calc.Click += new System.EventHandler(this.Calc_Area);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 204);
            this.Controls.Add(this.B_Calc);
            this.Controls.Add(this.T_Area);
            this.Controls.Add(this.T_Width);
            this.Controls.Add(this.T_Length);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox T_Length;
        private System.Windows.Forms.TextBox T_Width;
        private System.Windows.Forms.TextBox T_Area;
        private System.Windows.Forms.Button B_Calc;
    }
}

