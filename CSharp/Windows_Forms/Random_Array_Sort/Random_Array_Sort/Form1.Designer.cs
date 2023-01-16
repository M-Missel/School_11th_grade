namespace Random_Array_Sort
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
            this.B_Init = new System.Windows.Forms.Button();
            this.B_Search = new System.Windows.Forms.Button();
            this.RTB_Ausgabe = new System.Windows.Forms.RichTextBox();
            this.L_Array = new System.Windows.Forms.ListBox();
            this.T_Suchwert = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // B_Init
            // 
            this.B_Init.Location = new System.Drawing.Point(132, 12);
            this.B_Init.Name = "B_Init";
            this.B_Init.Size = new System.Drawing.Size(161, 56);
            this.B_Init.TabIndex = 0;
            this.B_Init.Text = "Initialisieren";
            this.B_Init.UseVisualStyleBackColor = true;
            this.B_Init.Click += new System.EventHandler(this.Init);
            // 
            // B_Search
            // 
            this.B_Search.Location = new System.Drawing.Point(132, 348);
            this.B_Search.Name = "B_Search";
            this.B_Search.Size = new System.Drawing.Size(161, 56);
            this.B_Search.TabIndex = 1;
            this.B_Search.Text = "Wert suchen";
            this.B_Search.UseVisualStyleBackColor = true;
            this.B_Search.Click += new System.EventHandler(this.Output);
            // 
            // RTB_Ausgabe
            // 
            this.RTB_Ausgabe.Enabled = false;
            this.RTB_Ausgabe.Location = new System.Drawing.Point(132, 425);
            this.RTB_Ausgabe.Name = "RTB_Ausgabe";
            this.RTB_Ausgabe.Size = new System.Drawing.Size(160, 43);
            this.RTB_Ausgabe.TabIndex = 2;
            this.RTB_Ausgabe.Text = "";
            // 
            // L_Array
            // 
            this.L_Array.FormattingEnabled = true;
            this.L_Array.Location = new System.Drawing.Point(132, 86);
            this.L_Array.Name = "L_Array";
            this.L_Array.Size = new System.Drawing.Size(160, 199);
            this.L_Array.TabIndex = 3;
            // 
            // T_Suchwert
            // 
            this.T_Suchwert.Location = new System.Drawing.Point(220, 308);
            this.T_Suchwert.Name = "T_Suchwert";
            this.T_Suchwert.Size = new System.Drawing.Size(73, 20);
            this.T_Suchwert.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Suchwert";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 484);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.T_Suchwert);
            this.Controls.Add(this.L_Array);
            this.Controls.Add(this.RTB_Ausgabe);
            this.Controls.Add(this.B_Search);
            this.Controls.Add(this.B_Init);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_Init;
        private System.Windows.Forms.Button B_Search;
        private System.Windows.Forms.RichTextBox RTB_Ausgabe;
        private System.Windows.Forms.ListBox L_Array;
        private System.Windows.Forms.TextBox T_Suchwert;
        private System.Windows.Forms.Label label1;
    }
}

