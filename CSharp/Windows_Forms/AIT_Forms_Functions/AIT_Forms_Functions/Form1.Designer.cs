namespace AIT_Forms_Functions
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
            this.TB_Obgr = new System.Windows.Forms.TextBox();
            this.TB_Erge = new System.Windows.Forms.TextBox();
            this.BTN_Add = new System.Windows.Forms.Button();
            this.BTN_RandNumb = new System.Windows.Forms.Button();
            this.LB_Output = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TB_Obgr
            // 
            this.TB_Obgr.Location = new System.Drawing.Point(172, 26);
            this.TB_Obgr.Name = "TB_Obgr";
            this.TB_Obgr.Size = new System.Drawing.Size(100, 20);
            this.TB_Obgr.TabIndex = 0;
            // 
            // TB_Erge
            // 
            this.TB_Erge.Location = new System.Drawing.Point(172, 95);
            this.TB_Erge.Name = "TB_Erge";
            this.TB_Erge.Size = new System.Drawing.Size(100, 20);
            this.TB_Erge.TabIndex = 1;
            // 
            // BTN_Add
            // 
            this.BTN_Add.Location = new System.Drawing.Point(135, 52);
            this.BTN_Add.Name = "BTN_Add";
            this.BTN_Add.Size = new System.Drawing.Size(184, 37);
            this.BTN_Add.TabIndex = 2;
            this.BTN_Add.Text = "Addiere";
            this.BTN_Add.UseVisualStyleBackColor = true;
            this.BTN_Add.Click += new System.EventHandler(this.Add);
            // 
            // BTN_RandNumb
            // 
            this.BTN_RandNumb.Location = new System.Drawing.Point(135, 145);
            this.BTN_RandNumb.Name = "BTN_RandNumb";
            this.BTN_RandNumb.Size = new System.Drawing.Size(184, 37);
            this.BTN_RandNumb.TabIndex = 3;
            this.BTN_RandNumb.Text = "3 Random Numbers";
            this.BTN_RandNumb.UseVisualStyleBackColor = true;
            this.BTN_RandNumb.Click += new System.EventHandler(this.Add_Random);
            // 
            // LB_Output
            // 
            this.LB_Output.FormattingEnabled = true;
            this.LB_Output.Location = new System.Drawing.Point(39, 197);
            this.LB_Output.Name = "LB_Output";
            this.LB_Output.Size = new System.Drawing.Size(404, 160);
            this.LB_Output.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Obergrenze";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ergenbis";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 394);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LB_Output);
            this.Controls.Add(this.BTN_RandNumb);
            this.Controls.Add(this.BTN_Add);
            this.Controls.Add(this.TB_Erge);
            this.Controls.Add(this.TB_Obgr);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Obgr;
        private System.Windows.Forms.TextBox TB_Erge;
        private System.Windows.Forms.Button BTN_Add;
        private System.Windows.Forms.Button BTN_RandNumb;
        private System.Windows.Forms.ListBox LB_Output;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

