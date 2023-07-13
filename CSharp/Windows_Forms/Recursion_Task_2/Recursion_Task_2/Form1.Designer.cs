namespace Recursion_Task_2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RB_Iterative = new System.Windows.Forms.RadioButton();
            this.RB_Recursive = new System.Windows.Forms.RadioButton();
            this.BTN_Fac = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TB_Input
            // 
            this.TB_Input.Location = new System.Drawing.Point(24, 39);
            this.TB_Input.Name = "TB_Input";
            this.TB_Input.Size = new System.Drawing.Size(143, 20);
            this.TB_Input.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RB_Recursive);
            this.groupBox1.Controls.Add(this.RB_Iterative);
            this.groupBox1.Location = new System.Drawing.Point(261, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selection";
            // 
            // RB_Iterative
            // 
            this.RB_Iterative.AutoSize = true;
            this.RB_Iterative.Location = new System.Drawing.Point(22, 19);
            this.RB_Iterative.Name = "RB_Iterative";
            this.RB_Iterative.Size = new System.Drawing.Size(63, 17);
            this.RB_Iterative.TabIndex = 0;
            this.RB_Iterative.TabStop = true;
            this.RB_Iterative.Text = "Iterative";
            this.RB_Iterative.UseVisualStyleBackColor = true;
            // 
            // RB_Recursive
            // 
            this.RB_Recursive.AutoSize = true;
            this.RB_Recursive.Location = new System.Drawing.Point(22, 42);
            this.RB_Recursive.Name = "RB_Recursive";
            this.RB_Recursive.Size = new System.Drawing.Size(73, 17);
            this.RB_Recursive.TabIndex = 1;
            this.RB_Recursive.TabStop = true;
            this.RB_Recursive.Text = "Recursive";
            this.RB_Recursive.UseVisualStyleBackColor = true;
            // 
            // BTN_Fac
            // 
            this.BTN_Fac.Location = new System.Drawing.Point(24, 81);
            this.BTN_Fac.Name = "BTN_Fac";
            this.BTN_Fac.Size = new System.Drawing.Size(143, 58);
            this.BTN_Fac.TabIndex = 2;
            this.BTN_Fac.Text = "Faculty";
            this.BTN_Fac.UseVisualStyleBackColor = true;
            this.BTN_Fac.Click += new System.EventHandler(this.BTN_Fac_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 175);
            this.Controls.Add(this.BTN_Fac);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TB_Input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Input;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RB_Recursive;
        private System.Windows.Forms.RadioButton RB_Iterative;
        private System.Windows.Forms.Button BTN_Fac;
    }
}

