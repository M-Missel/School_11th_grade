namespace AIT_Forms_Arrays_Min_Max
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
            this.BTN_MAX = new System.Windows.Forms.Button();
            this.BTN_MIN = new System.Windows.Forms.Button();
            this.LB_OUTPUT = new System.Windows.Forms.ListBox();
            this.BTN_MAX_2D = new System.Windows.Forms.Button();
            this.BTN_MIN_2D = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_MAX
            // 
            this.BTN_MAX.Location = new System.Drawing.Point(141, 62);
            this.BTN_MAX.Name = "BTN_MAX";
            this.BTN_MAX.Size = new System.Drawing.Size(93, 46);
            this.BTN_MAX.TabIndex = 0;
            this.BTN_MAX.Text = "Max";
            this.BTN_MAX.UseVisualStyleBackColor = true;
            this.BTN_MAX.Click += new System.EventHandler(this.Max_Search);
            // 
            // BTN_MIN
            // 
            this.BTN_MIN.Location = new System.Drawing.Point(141, 114);
            this.BTN_MIN.Name = "BTN_MIN";
            this.BTN_MIN.Size = new System.Drawing.Size(93, 46);
            this.BTN_MIN.TabIndex = 1;
            this.BTN_MIN.Text = "Min";
            this.BTN_MIN.UseVisualStyleBackColor = true;
            this.BTN_MIN.Click += new System.EventHandler(this.Min_Search);
            // 
            // LB_OUTPUT
            // 
            this.LB_OUTPUT.FormattingEnabled = true;
            this.LB_OUTPUT.Location = new System.Drawing.Point(376, 62);
            this.LB_OUTPUT.Name = "LB_OUTPUT";
            this.LB_OUTPUT.Size = new System.Drawing.Size(293, 264);
            this.LB_OUTPUT.TabIndex = 2;
            // 
            // BTN_MAX_2D
            // 
            this.BTN_MAX_2D.Location = new System.Drawing.Point(141, 189);
            this.BTN_MAX_2D.Name = "BTN_MAX_2D";
            this.BTN_MAX_2D.Size = new System.Drawing.Size(93, 46);
            this.BTN_MAX_2D.TabIndex = 3;
            this.BTN_MAX_2D.Text = "Max2D";
            this.BTN_MAX_2D.UseVisualStyleBackColor = true;
            this.BTN_MAX_2D.Click += new System.EventHandler(this.Max_Search2D);
            // 
            // BTN_MIN_2D
            // 
            this.BTN_MIN_2D.Location = new System.Drawing.Point(141, 241);
            this.BTN_MIN_2D.Name = "BTN_MIN_2D";
            this.BTN_MIN_2D.Size = new System.Drawing.Size(93, 46);
            this.BTN_MIN_2D.TabIndex = 4;
            this.BTN_MIN_2D.Text = "Min2D";
            this.BTN_MIN_2D.UseVisualStyleBackColor = true;
            this.BTN_MIN_2D.Click += new System.EventHandler(this.Min_Search2D);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTN_MIN_2D);
            this.Controls.Add(this.BTN_MAX_2D);
            this.Controls.Add(this.LB_OUTPUT);
            this.Controls.Add(this.BTN_MIN);
            this.Controls.Add(this.BTN_MAX);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_MAX;
        private System.Windows.Forms.Button BTN_MIN;
        private System.Windows.Forms.ListBox LB_OUTPUT;
        private System.Windows.Forms.Button BTN_MAX_2D;
        private System.Windows.Forms.Button BTN_MIN_2D;
    }
}

