namespace First_Forms_App
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
            this.B_SetAusgabe = new System.Windows.Forms.Button();
            this.CB_ActivateAusgabe = new System.Windows.Forms.CheckBox();
            this.T_TestAusgabe = new System.Windows.Forms.TextBox();
            this.B_SetAusgabe_2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // B_SetAusgabe
            // 
            this.B_SetAusgabe.Location = new System.Drawing.Point(621, 97);
            this.B_SetAusgabe.Name = "B_SetAusgabe";
            this.B_SetAusgabe.Size = new System.Drawing.Size(75, 23);
            this.B_SetAusgabe.TabIndex = 0;
            this.B_SetAusgabe.Text = "button1";
            this.B_SetAusgabe.UseVisualStyleBackColor = true;
            this.B_SetAusgabe.Click += new System.EventHandler(this.T_Ausgabe_Click);
            // 
            // CB_ActivateAusgabe
            // 
            this.CB_ActivateAusgabe.AutoSize = true;
            this.CB_ActivateAusgabe.Location = new System.Drawing.Point(621, 148);
            this.CB_ActivateAusgabe.Name = "CB_ActivateAusgabe";
            this.CB_ActivateAusgabe.Size = new System.Drawing.Size(80, 17);
            this.CB_ActivateAusgabe.TabIndex = 1;
            this.CB_ActivateAusgabe.Text = "checkBox1";
            this.CB_ActivateAusgabe.UseVisualStyleBackColor = true;
            this.CB_ActivateAusgabe.CheckedChanged += new System.EventHandler(this.CB_ActivateAusgabe_CheckedChanged);
            // 
            // T_TestAusgabe
            // 
            this.T_TestAusgabe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.T_TestAusgabe.Enabled = false;
            this.T_TestAusgabe.Location = new System.Drawing.Point(162, 100);
            this.T_TestAusgabe.Name = "T_TestAusgabe";
            this.T_TestAusgabe.ShortcutsEnabled = false;
            this.T_TestAusgabe.Size = new System.Drawing.Size(100, 13);
            this.T_TestAusgabe.TabIndex = 2;
            // 
            // B_SetAusgabe_2
            // 
            this.B_SetAusgabe_2.Location = new System.Drawing.Point(621, 187);
            this.B_SetAusgabe_2.Name = "B_SetAusgabe_2";
            this.B_SetAusgabe_2.Size = new System.Drawing.Size(75, 23);
            this.B_SetAusgabe_2.TabIndex = 3;
            this.B_SetAusgabe_2.Text = "button1";
            this.B_SetAusgabe_2.UseVisualStyleBackColor = true;
            this.B_SetAusgabe_2.Click += new System.EventHandler(this.B_SetAusgabe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.B_SetAusgabe_2);
            this.Controls.Add(this.T_TestAusgabe);
            this.Controls.Add(this.CB_ActivateAusgabe);
            this.Controls.Add(this.B_SetAusgabe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_SetAusgabe;
        private System.Windows.Forms.CheckBox CB_ActivateAusgabe;
        private System.Windows.Forms.TextBox T_TestAusgabe;
        private System.Windows.Forms.Button B_SetAusgabe_2;
    }
}

