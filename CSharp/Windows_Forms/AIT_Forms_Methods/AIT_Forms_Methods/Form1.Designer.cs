namespace AIT_Forms_Methods
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
            this.B_Straftarbeit = new System.Windows.Forms.Button();
            this.LB_Output = new System.Windows.Forms.ListBox();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.TB_Straftext = new System.Windows.Forms.TextBox();
            this.TB_Anzahl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // B_Straftarbeit
            // 
            this.B_Straftarbeit.Location = new System.Drawing.Point(48, 35);
            this.B_Straftarbeit.Name = "B_Straftarbeit";
            this.B_Straftarbeit.Size = new System.Drawing.Size(367, 42);
            this.B_Straftarbeit.TabIndex = 0;
            this.B_Straftarbeit.Text = "Strafarbeit";
            this.B_Straftarbeit.UseVisualStyleBackColor = true;
            this.B_Straftarbeit.Click += new System.EventHandler(this.straftarbeit);
            // 
            // LB_Output
            // 
            this.LB_Output.FormattingEnabled = true;
            this.LB_Output.Location = new System.Drawing.Point(22, 120);
            this.LB_Output.Name = "LB_Output";
            this.LB_Output.Size = new System.Drawing.Size(405, 303);
            this.LB_Output.TabIndex = 3;
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(184, 465);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(100, 20);
            this.TB_Name.TabIndex = 4;
            // 
            // TB_Straftext
            // 
            this.TB_Straftext.Location = new System.Drawing.Point(184, 491);
            this.TB_Straftext.Name = "TB_Straftext";
            this.TB_Straftext.Size = new System.Drawing.Size(100, 20);
            this.TB_Straftext.TabIndex = 5;
            // 
            // TB_Anzahl
            // 
            this.TB_Anzahl.Location = new System.Drawing.Point(184, 517);
            this.TB_Anzahl.Name = "TB_Anzahl";
            this.TB_Anzahl.Size = new System.Drawing.Size(100, 20);
            this.TB_Anzahl.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 468);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 491);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Straftext";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 520);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Anzahl";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 624);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_Anzahl);
            this.Controls.Add(this.TB_Straftext);
            this.Controls.Add(this.TB_Name);
            this.Controls.Add(this.LB_Output);
            this.Controls.Add(this.B_Straftarbeit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_Straftarbeit;
        private System.Windows.Forms.ListBox LB_Output;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.TextBox TB_Straftext;
        private System.Windows.Forms.TextBox TB_Anzahl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

