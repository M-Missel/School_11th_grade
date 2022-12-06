namespace AIT_Forms_Task_4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.T_Celcuis = new System.Windows.Forms.TextBox();
            this.T_Fahrenheit = new System.Windows.Forms.TextBox();
            this.T_Calc = new System.Windows.Forms.Button();
            this.B_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Celcius";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fahrenheit";
            // 
            // T_Celcuis
            // 
            this.T_Celcuis.Location = new System.Drawing.Point(227, 25);
            this.T_Celcuis.Name = "T_Celcuis";
            this.T_Celcuis.Size = new System.Drawing.Size(100, 20);
            this.T_Celcuis.TabIndex = 2;
            // 
            // T_Fahrenheit
            // 
            this.T_Fahrenheit.Location = new System.Drawing.Point(227, 118);
            this.T_Fahrenheit.Name = "T_Fahrenheit";
            this.T_Fahrenheit.Size = new System.Drawing.Size(100, 20);
            this.T_Fahrenheit.TabIndex = 3;
            // 
            // T_Calc
            // 
            this.T_Calc.Location = new System.Drawing.Point(239, 73);
            this.T_Calc.Name = "T_Calc";
            this.T_Calc.Size = new System.Drawing.Size(75, 23);
            this.T_Calc.TabIndex = 4;
            this.T_Calc.Text = "Calculate";
            this.T_Calc.UseVisualStyleBackColor = true;
            this.T_Calc.Click += new System.EventHandler(this.Calc_Fahrenheit);
            // 
            // B_Exit
            // 
            this.B_Exit.Location = new System.Drawing.Point(380, 120);
            this.B_Exit.Name = "B_Exit";
            this.B_Exit.Size = new System.Drawing.Size(75, 23);
            this.B_Exit.TabIndex = 5;
            this.B_Exit.Text = "Exit";
            this.B_Exit.UseVisualStyleBackColor = true;
            this.B_Exit.Click += new System.EventHandler(this.Exit_Application);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 179);
            this.Controls.Add(this.B_Exit);
            this.Controls.Add(this.T_Calc);
            this.Controls.Add(this.T_Fahrenheit);
            this.Controls.Add(this.T_Celcuis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox T_Celcuis;
        private System.Windows.Forms.TextBox T_Fahrenheit;
        private System.Windows.Forms.Button T_Calc;
        private System.Windows.Forms.Button B_Exit;
    }
}

