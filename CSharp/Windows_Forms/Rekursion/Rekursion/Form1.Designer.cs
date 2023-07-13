namespace Rekursion
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
            this.TB_Output = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TB_Input
            // 
            this.TB_Input.Location = new System.Drawing.Point(146, 29);
            this.TB_Input.Name = "TB_Input";
            this.TB_Input.Size = new System.Drawing.Size(122, 20);
            this.TB_Input.TabIndex = 0;
            this.TB_Input.TextChanged += new System.EventHandler(this.TB_Input_TextChanged);
            // 
            // TB_Output
            // 
            this.TB_Output.Location = new System.Drawing.Point(56, 61);
            this.TB_Output.Multiline = true;
            this.TB_Output.Name = "TB_Output";
            this.TB_Output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TB_Output.Size = new System.Drawing.Size(212, 377);
            this.TB_Output.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "upper limit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_Output);
            this.Controls.Add(this.TB_Input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Input;
        private System.Windows.Forms.TextBox TB_Output;
        private System.Windows.Forms.Label label1;
    }
}

