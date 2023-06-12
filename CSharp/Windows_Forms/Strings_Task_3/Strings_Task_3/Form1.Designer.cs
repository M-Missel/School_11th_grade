namespace Strings_Task_3
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
            this.BTN_Check = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "E-Mail Check";
            // 
            // TB_Input
            // 
            this.TB_Input.Location = new System.Drawing.Point(107, 27);
            this.TB_Input.Name = "TB_Input";
            this.TB_Input.Size = new System.Drawing.Size(275, 20);
            this.TB_Input.TabIndex = 1;
            // 
            // BTN_Check
            // 
            this.BTN_Check.Location = new System.Drawing.Point(404, 25);
            this.BTN_Check.Name = "BTN_Check";
            this.BTN_Check.Size = new System.Drawing.Size(75, 23);
            this.BTN_Check.TabIndex = 2;
            this.BTN_Check.Text = "Check";
            this.BTN_Check.UseVisualStyleBackColor = true;
            this.BTN_Check.Click += new System.EventHandler(this.BTN_Check_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 69);
            this.Controls.Add(this.BTN_Check);
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
        private System.Windows.Forms.Button BTN_Check;
    }
}

