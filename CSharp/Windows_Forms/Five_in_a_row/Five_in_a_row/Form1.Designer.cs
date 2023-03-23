namespace Five_in_a_row
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
            this.SG_Output = new StringGrid.StringGrid();
            this.BTN_Start = new System.Windows.Forms.Button();
            this.LB_Player = new System.Windows.Forms.Label();
            this.LB_Player_Next = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SG_Output
            // 
            this.SG_Output.ColCount = 10;
            this.SG_Output.DefaultColWidth = 25;
            this.SG_Output.DefaultRowHeight = 25;
            this.SG_Output.FixedCols = 1;
            this.SG_Output.FixedRows = 1;
            this.SG_Output.GridLineWidth = 1;
            this.SG_Output.Location = new System.Drawing.Point(51, 26);
            this.SG_Output.Name = "SG_Output";
            this.SG_Output.RowCount = 8;
            this.SG_Output.Size = new System.Drawing.Size(262, 210);
            this.SG_Output.TabIndex = 0;
            this.SG_Output.SelectCell += new StringGrid.StringGrid.SelectCellEventHandler(this.setStone);
            // 
            // BTN_Start
            // 
            this.BTN_Start.Location = new System.Drawing.Point(51, 251);
            this.BTN_Start.Name = "BTN_Start";
            this.BTN_Start.Size = new System.Drawing.Size(261, 29);
            this.BTN_Start.TabIndex = 1;
            this.BTN_Start.Text = "Start";
            this.BTN_Start.UseVisualStyleBackColor = true;
            this.BTN_Start.Click += new System.EventHandler(this.BTN_Start_Click);
            // 
            // LB_Player
            // 
            this.LB_Player.AutoSize = true;
            this.LB_Player.Location = new System.Drawing.Point(59, 308);
            this.LB_Player.Name = "LB_Player";
            this.LB_Player.Size = new System.Drawing.Size(73, 13);
            this.LB_Player.TabIndex = 2;
            this.LB_Player.Text = "Current Player";
            // 
            // LB_Player_Next
            // 
            this.LB_Player_Next.AutoSize = true;
            this.LB_Player_Next.Location = new System.Drawing.Point(159, 308);
            this.LB_Player_Next.Name = "LB_Player_Next";
            this.LB_Player_Next.Size = new System.Drawing.Size(0, 13);
            this.LB_Player_Next.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 450);
            this.Controls.Add(this.LB_Player_Next);
            this.Controls.Add(this.LB_Player);
            this.Controls.Add(this.BTN_Start);
            this.Controls.Add(this.SG_Output);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StringGrid.StringGrid SG_Output;
        private System.Windows.Forms.Button BTN_Start;
        private System.Windows.Forms.Label LB_Player;
        private System.Windows.Forms.Label LB_Player_Next;
    }
}

