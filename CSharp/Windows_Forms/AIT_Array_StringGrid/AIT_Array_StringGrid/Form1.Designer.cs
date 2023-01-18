namespace AIT_Array_StringGrid
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
            this.SG_OUTPUT = new StringGrid.StringGrid();
            this.BTN_INIT = new System.Windows.Forms.Button();
            this.BTN_MAX_VALUE = new System.Windows.Forms.Button();
            this.BTN_MIN_VALUE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SG_OUTPUT
            // 
            this.SG_OUTPUT.ColCount = 10;
            this.SG_OUTPUT.DefaultColWidth = 25;
            this.SG_OUTPUT.DefaultRowHeight = 25;
            this.SG_OUTPUT.FixedCols = 0;
            this.SG_OUTPUT.FixedRows = 0;
            this.SG_OUTPUT.GridLineWidth = 1;
            this.SG_OUTPUT.Location = new System.Drawing.Point(266, 132);
            this.SG_OUTPUT.Name = "SG_OUTPUT";
            this.SG_OUTPUT.RowCount = 10;
            this.SG_OUTPUT.Size = new System.Drawing.Size(262, 262);
            this.SG_OUTPUT.TabIndex = 0;
            // 
            // BTN_INIT
            // 
            this.BTN_INIT.Location = new System.Drawing.Point(354, 25);
            this.BTN_INIT.Name = "BTN_INIT";
            this.BTN_INIT.Size = new System.Drawing.Size(75, 23);
            this.BTN_INIT.TabIndex = 1;
            this.BTN_INIT.Text = "Init";
            this.BTN_INIT.UseVisualStyleBackColor = true;
            this.BTN_INIT.Click += new System.EventHandler(this.BTN_INIT_ARRAY);
            // 
            // BTN_MAX_VALUE
            // 
            this.BTN_MAX_VALUE.Location = new System.Drawing.Point(354, 54);
            this.BTN_MAX_VALUE.Name = "BTN_MAX_VALUE";
            this.BTN_MAX_VALUE.Size = new System.Drawing.Size(75, 23);
            this.BTN_MAX_VALUE.TabIndex = 2;
            this.BTN_MAX_VALUE.Text = "Max Value";
            this.BTN_MAX_VALUE.UseVisualStyleBackColor = true;
            this.BTN_MAX_VALUE.Click += new System.EventHandler(this.BTN_SEARCH_MAX);
            // 
            // BTN_MIN_VALUE
            // 
            this.BTN_MIN_VALUE.Location = new System.Drawing.Point(354, 83);
            this.BTN_MIN_VALUE.Name = "BTN_MIN_VALUE";
            this.BTN_MIN_VALUE.Size = new System.Drawing.Size(75, 23);
            this.BTN_MIN_VALUE.TabIndex = 3;
            this.BTN_MIN_VALUE.Text = "Min Value";
            this.BTN_MIN_VALUE.UseVisualStyleBackColor = true;
            this.BTN_MIN_VALUE.Click += new System.EventHandler(this.BTN_SEARCH_MIN);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTN_MIN_VALUE);
            this.Controls.Add(this.BTN_MAX_VALUE);
            this.Controls.Add(this.BTN_INIT);
            this.Controls.Add(this.SG_OUTPUT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private StringGrid.StringGrid SG_OUTPUT;
        private System.Windows.Forms.Button BTN_INIT;
        private System.Windows.Forms.Button BTN_MAX_VALUE;
        private System.Windows.Forms.Button BTN_MIN_VALUE;
    }
}

