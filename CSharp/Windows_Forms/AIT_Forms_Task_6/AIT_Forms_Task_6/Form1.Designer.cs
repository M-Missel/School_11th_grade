namespace AIT_Forms_Task_6
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
            this.B_HideEdit = new System.Windows.Forms.Button();
            this.B_Blue = new System.Windows.Forms.Button();
            this.B_ShowEdit = new System.Windows.Forms.Button();
            this.B_Green = new System.Windows.Forms.Button();
            this.B_Red = new System.Windows.Forms.Button();
            this.T_EditBlue = new System.Windows.Forms.TextBox();
            this.T_EditGreen = new System.Windows.Forms.TextBox();
            this.T_EditRed = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // B_HideEdit
            // 
            this.B_HideEdit.Location = new System.Drawing.Point(12, 126);
            this.B_HideEdit.Name = "B_HideEdit";
            this.B_HideEdit.Size = new System.Drawing.Size(414, 23);
            this.B_HideEdit.TabIndex = 14;
            this.B_HideEdit.Text = "Hide Editfields";
            this.B_HideEdit.UseVisualStyleBackColor = true;
            this.B_HideEdit.Click += new System.EventHandler(this.HideTbs);
            // 
            // B_Blue
            // 
            this.B_Blue.Location = new System.Drawing.Point(326, 49);
            this.B_Blue.Name = "B_Blue";
            this.B_Blue.Size = new System.Drawing.Size(100, 23);
            this.B_Blue.TabIndex = 12;
            this.B_Blue.Text = "Blue";
            this.B_Blue.UseVisualStyleBackColor = true;
            this.B_Blue.Click += new System.EventHandler(this.ChangeColor);
            // 
            // B_ShowEdit
            // 
            this.B_ShowEdit.Location = new System.Drawing.Point(12, 97);
            this.B_ShowEdit.Name = "B_ShowEdit";
            this.B_ShowEdit.Size = new System.Drawing.Size(414, 23);
            this.B_ShowEdit.TabIndex = 13;
            this.B_ShowEdit.Text = "Show Editfields";
            this.B_ShowEdit.UseVisualStyleBackColor = true;
            this.B_ShowEdit.Click += new System.EventHandler(this.ShowTbs);
            // 
            // B_Green
            // 
            this.B_Green.Location = new System.Drawing.Point(176, 49);
            this.B_Green.Name = "B_Green";
            this.B_Green.Size = new System.Drawing.Size(100, 23);
            this.B_Green.TabIndex = 11;
            this.B_Green.Text = "Green";
            this.B_Green.UseVisualStyleBackColor = true;
            this.B_Green.Click += new System.EventHandler(this.ChangeColor);
            // 
            // B_Red
            // 
            this.B_Red.Location = new System.Drawing.Point(12, 49);
            this.B_Red.Name = "B_Red";
            this.B_Red.Size = new System.Drawing.Size(100, 23);
            this.B_Red.TabIndex = 10;
            this.B_Red.Text = "Red";
            this.B_Red.UseVisualStyleBackColor = true;
            this.B_Red.Click += new System.EventHandler(this.ChangeColor);
            // 
            // T_EditBlue
            // 
            this.T_EditBlue.Location = new System.Drawing.Point(326, 12);
            this.T_EditBlue.Name = "T_EditBlue";
            this.T_EditBlue.Size = new System.Drawing.Size(100, 20);
            this.T_EditBlue.TabIndex = 9;
            // 
            // T_EditGreen
            // 
            this.T_EditGreen.Location = new System.Drawing.Point(176, 12);
            this.T_EditGreen.Name = "T_EditGreen";
            this.T_EditGreen.Size = new System.Drawing.Size(100, 20);
            this.T_EditGreen.TabIndex = 8;
            // 
            // T_EditRed
            // 
            this.T_EditRed.Location = new System.Drawing.Point(12, 12);
            this.T_EditRed.Name = "T_EditRed";
            this.T_EditRed.Size = new System.Drawing.Size(100, 20);
            this.T_EditRed.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 170);
            this.Controls.Add(this.B_HideEdit);
            this.Controls.Add(this.B_Blue);
            this.Controls.Add(this.B_ShowEdit);
            this.Controls.Add(this.B_Green);
            this.Controls.Add(this.B_Red);
            this.Controls.Add(this.T_EditBlue);
            this.Controls.Add(this.T_EditGreen);
            this.Controls.Add(this.T_EditRed);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_HideEdit;
        private System.Windows.Forms.Button B_Blue;
        private System.Windows.Forms.Button B_ShowEdit;
        private System.Windows.Forms.Button B_Green;
        private System.Windows.Forms.Button B_Red;
        private System.Windows.Forms.TextBox T_EditBlue;
        private System.Windows.Forms.TextBox T_EditGreen;
        private System.Windows.Forms.TextBox T_EditRed;
    }
}

