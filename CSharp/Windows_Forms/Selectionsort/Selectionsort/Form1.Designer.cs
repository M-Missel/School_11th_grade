namespace Selectionsort
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
            this.LB_Output = new System.Windows.Forms.ListBox();
            this.BTN_Init_Array = new System.Windows.Forms.Button();
            this.BTN_Output_Array = new System.Windows.Forms.Button();
            this.BTN_Selection_Sort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LB_Output
            // 
            this.LB_Output.FormattingEnabled = true;
            this.LB_Output.Location = new System.Drawing.Point(52, 12);
            this.LB_Output.Name = "LB_Output";
            this.LB_Output.Size = new System.Drawing.Size(164, 264);
            this.LB_Output.TabIndex = 0;
            // 
            // BTN_Init_Array
            // 
            this.BTN_Init_Array.Location = new System.Drawing.Point(52, 282);
            this.BTN_Init_Array.Name = "BTN_Init_Array";
            this.BTN_Init_Array.Size = new System.Drawing.Size(164, 38);
            this.BTN_Init_Array.TabIndex = 1;
            this.BTN_Init_Array.Text = "Initialize Array";
            this.BTN_Init_Array.UseVisualStyleBackColor = true;
            this.BTN_Init_Array.Click += new System.EventHandler(this.BTN_Init_Array_Click);
            // 
            // BTN_Output_Array
            // 
            this.BTN_Output_Array.Location = new System.Drawing.Point(52, 326);
            this.BTN_Output_Array.Name = "BTN_Output_Array";
            this.BTN_Output_Array.Size = new System.Drawing.Size(164, 38);
            this.BTN_Output_Array.TabIndex = 2;
            this.BTN_Output_Array.Text = "Output Array";
            this.BTN_Output_Array.UseVisualStyleBackColor = true;
            this.BTN_Output_Array.Click += new System.EventHandler(this.BTN_Output_Array_Click);
            // 
            // BTN_Selection_Sort
            // 
            this.BTN_Selection_Sort.Location = new System.Drawing.Point(52, 370);
            this.BTN_Selection_Sort.Name = "BTN_Selection_Sort";
            this.BTN_Selection_Sort.Size = new System.Drawing.Size(164, 38);
            this.BTN_Selection_Sort.TabIndex = 3;
            this.BTN_Selection_Sort.Text = "Selection Sort";
            this.BTN_Selection_Sort.UseVisualStyleBackColor = true;
            this.BTN_Selection_Sort.Click += new System.EventHandler(this.BTN_Selection_Sort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 422);
            this.Controls.Add(this.BTN_Selection_Sort);
            this.Controls.Add(this.BTN_Output_Array);
            this.Controls.Add(this.BTN_Init_Array);
            this.Controls.Add(this.LB_Output);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LB_Output;
        private System.Windows.Forms.Button BTN_Init_Array;
        private System.Windows.Forms.Button BTN_Output_Array;
        private System.Windows.Forms.Button BTN_Selection_Sort;
    }
}

