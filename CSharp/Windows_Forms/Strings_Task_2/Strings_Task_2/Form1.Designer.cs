namespace Strings_Task_2
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
            this.TB_Input = new System.Windows.Forms.TextBox();
            this.TB_Output = new System.Windows.Forms.TextBox();
            this.BTN_Click = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input Text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Output Text";
            // 
            // TB_Input
            // 
            this.TB_Input.Location = new System.Drawing.Point(115, 37);
            this.TB_Input.Name = "TB_Input";
            this.TB_Input.Size = new System.Drawing.Size(277, 20);
            this.TB_Input.TabIndex = 2;
            // 
            // TB_Output
            // 
            this.TB_Output.Location = new System.Drawing.Point(115, 75);
            this.TB_Output.Name = "TB_Output";
            this.TB_Output.Size = new System.Drawing.Size(277, 20);
            this.TB_Output.TabIndex = 3;
            // 
            // BTN_Click
            // 
            this.BTN_Click.Location = new System.Drawing.Point(433, 37);
            this.BTN_Click.Name = "BTN_Click";
            this.BTN_Click.Size = new System.Drawing.Size(74, 57);
            this.BTN_Click.TabIndex = 4;
            this.BTN_Click.Text = "Reverse";
            this.BTN_Click.UseVisualStyleBackColor = true;
            this.BTN_Click.Click += new System.EventHandler(this.BTN_Click_reverse);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 134);
            this.Controls.Add(this.BTN_Click);
            this.Controls.Add(this.TB_Output);
            this.Controls.Add(this.TB_Input);
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
        private System.Windows.Forms.TextBox TB_Input;
        private System.Windows.Forms.TextBox TB_Output;
        private System.Windows.Forms.Button BTN_Click;
    }
}

