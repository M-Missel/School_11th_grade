namespace AIT_Forms_Arrays_LBs
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
            this.BTN_RAD_NUM = new System.Windows.Forms.Button();
            this.BTN_SHOWLB = new System.Windows.Forms.Button();
            this.LB_OUTPUT = new System.Windows.Forms.ListBox();
            this.BTN_SHOW_GREAT_VALUE = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_RAD_NUM
            // 
            this.BTN_RAD_NUM.Location = new System.Drawing.Point(30, 24);
            this.BTN_RAD_NUM.Name = "BTN_RAD_NUM";
            this.BTN_RAD_NUM.Size = new System.Drawing.Size(123, 72);
            this.BTN_RAD_NUM.TabIndex = 1;
            this.BTN_RAD_NUM.Text = "Fill Array";
            this.BTN_RAD_NUM.UseVisualStyleBackColor = true;
            this.BTN_RAD_NUM.Click += new System.EventHandler(this.BTN_FILL_ARRAY);
            // 
            // BTN_SHOWLB
            // 
            this.BTN_SHOWLB.Location = new System.Drawing.Point(30, 102);
            this.BTN_SHOWLB.Name = "BTN_SHOWLB";
            this.BTN_SHOWLB.Size = new System.Drawing.Size(123, 72);
            this.BTN_SHOWLB.TabIndex = 2;
            this.BTN_SHOWLB.Text = "Show Array";
            this.BTN_SHOWLB.UseVisualStyleBackColor = true;
            this.BTN_SHOWLB.Click += new System.EventHandler(this.BTN_SHOW_LB);
            // 
            // LB_OUTPUT
            // 
            this.LB_OUTPUT.FormattingEnabled = true;
            this.LB_OUTPUT.Location = new System.Drawing.Point(200, 24);
            this.LB_OUTPUT.Name = "LB_OUTPUT";
            this.LB_OUTPUT.Size = new System.Drawing.Size(269, 381);
            this.LB_OUTPUT.TabIndex = 3;
            // 
            // BTN_SHOW_GREAT_VALUE
            // 
            this.BTN_SHOW_GREAT_VALUE.Location = new System.Drawing.Point(30, 180);
            this.BTN_SHOW_GREAT_VALUE.Name = "BTN_SHOW_GREAT_VALUE";
            this.BTN_SHOW_GREAT_VALUE.Size = new System.Drawing.Size(123, 72);
            this.BTN_SHOW_GREAT_VALUE.TabIndex = 4;
            this.BTN_SHOW_GREAT_VALUE.Text = "Show greatest Value";
            this.BTN_SHOW_GREAT_VALUE.UseVisualStyleBackColor = true;
            this.BTN_SHOW_GREAT_VALUE.Click += new System.EventHandler(this.BTN_SHOW_GREATEST_VALUE);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 72);
            this.button1.TabIndex = 5;
            this.button1.Text = "Show least Value";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BTN_SHOW_LEAST_VALUE);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 513);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTN_SHOW_GREAT_VALUE);
            this.Controls.Add(this.LB_OUTPUT);
            this.Controls.Add(this.BTN_SHOWLB);
            this.Controls.Add(this.BTN_RAD_NUM);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_RAD_NUM;
        private System.Windows.Forms.Button BTN_SHOWLB;
        private System.Windows.Forms.ListBox LB_OUTPUT;
        private System.Windows.Forms.Button BTN_SHOW_GREAT_VALUE;
        private System.Windows.Forms.Button button1;
    }
}

