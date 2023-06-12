namespace Strings_Task_4
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
            this.TB_Input = new System.Windows.Forms.TextBox();
            this.BTN_Count_Vowels = new System.Windows.Forms.Button();
            this.L_Output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input Text";
            // 
            // TB_Input
            // 
            this.TB_Input.Location = new System.Drawing.Point(113, 24);
            this.TB_Input.Name = "TB_Input";
            this.TB_Input.Size = new System.Drawing.Size(330, 20);
            this.TB_Input.TabIndex = 1;
            // 
            // BTN_Count_Vowels
            // 
            this.BTN_Count_Vowels.Location = new System.Drawing.Point(488, 21);
            this.BTN_Count_Vowels.Name = "BTN_Count_Vowels";
            this.BTN_Count_Vowels.Size = new System.Drawing.Size(103, 23);
            this.BTN_Count_Vowels.TabIndex = 2;
            this.BTN_Count_Vowels.Text = "Count Vowels";
            this.BTN_Count_Vowels.UseVisualStyleBackColor = true;
            this.BTN_Count_Vowels.Click += new System.EventHandler(this.BTN_Count_Vowels_Click);
            // 
            // L_Output
            // 
            this.L_Output.AutoSize = true;
            this.L_Output.Location = new System.Drawing.Point(118, 60);
            this.L_Output.Name = "L_Output";
            this.L_Output.Size = new System.Drawing.Size(0, 13);
            this.L_Output.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 97);
            this.Controls.Add(this.L_Output);
            this.Controls.Add(this.BTN_Count_Vowels);
            this.Controls.Add(this.TB_Input);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_Input;
        private System.Windows.Forms.Button BTN_Count_Vowels;
        private System.Windows.Forms.Label L_Output;
    }
}

