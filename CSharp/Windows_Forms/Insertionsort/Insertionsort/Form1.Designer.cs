namespace Insertionsort
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
            this.LB_output = new System.Windows.Forms.ListBox();
            this.BTN_Init_Array = new System.Windows.Forms.Button();
            this.BTN_Insertionsort = new System.Windows.Forms.Button();
            this.BTN_Print_out = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LB_output
            // 
            this.LB_output.FormattingEnabled = true;
            this.LB_output.Location = new System.Drawing.Point(81, 30);
            this.LB_output.Name = "LB_output";
            this.LB_output.Size = new System.Drawing.Size(274, 238);
            this.LB_output.TabIndex = 0;
            // 
            // BTN_Init_Array
            // 
            this.BTN_Init_Array.Location = new System.Drawing.Point(81, 283);
            this.BTN_Init_Array.Name = "BTN_Init_Array";
            this.BTN_Init_Array.Size = new System.Drawing.Size(274, 23);
            this.BTN_Init_Array.TabIndex = 1;
            this.BTN_Init_Array.Text = "Init Array";
            this.BTN_Init_Array.UseVisualStyleBackColor = true;
            this.BTN_Init_Array.Click += new System.EventHandler(this.BTN_Init_Array_Click);
            // 
            // BTN_Insertionsort
            // 
            this.BTN_Insertionsort.Location = new System.Drawing.Point(81, 312);
            this.BTN_Insertionsort.Name = "BTN_Insertionsort";
            this.BTN_Insertionsort.Size = new System.Drawing.Size(274, 23);
            this.BTN_Insertionsort.TabIndex = 2;
            this.BTN_Insertionsort.Text = "Sort Array";
            this.BTN_Insertionsort.UseVisualStyleBackColor = true;
            this.BTN_Insertionsort.Click += new System.EventHandler(this.BTN_Insertionsort_Click);
            // 
            // BTN_Print_out
            // 
            this.BTN_Print_out.Location = new System.Drawing.Point(81, 341);
            this.BTN_Print_out.Name = "BTN_Print_out";
            this.BTN_Print_out.Size = new System.Drawing.Size(274, 23);
            this.BTN_Print_out.TabIndex = 3;
            this.BTN_Print_out.Text = "Print out";
            this.BTN_Print_out.UseVisualStyleBackColor = true;
            this.BTN_Print_out.Click += new System.EventHandler(this.BTN_PrintOut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 450);
            this.Controls.Add(this.BTN_Print_out);
            this.Controls.Add(this.BTN_Insertionsort);
            this.Controls.Add(this.BTN_Init_Array);
            this.Controls.Add(this.LB_output);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LB_output;
        private System.Windows.Forms.Button BTN_Init_Array;
        private System.Windows.Forms.Button BTN_Insertionsort;
        private System.Windows.Forms.Button BTN_Print_out;
    }
}

