namespace Examen_2
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
            this.L_k = new System.Windows.Forms.Label();
            this.L_Exponent = new System.Windows.Forms.Label();
            this.L_X_Value = new System.Windows.Forms.Label();
            this.L_x = new System.Windows.Forms.Label();
            this.L_X_Times_Expo = new System.Windows.Forms.Label();
            this.L_QM_String = new System.Windows.Forms.Label();
            this.TB_Exponent = new System.Windows.Forms.TextBox();
            this.TB_X_Value = new System.Windows.Forms.TextBox();
            this.TB_X_Times_Expo = new System.Windows.Forms.TextBox();
            this.TB_QM_String = new System.Windows.Forms.TextBox();
            this.L_Arrow = new System.Windows.Forms.Label();
            this.BTN_Create_QM = new System.Windows.Forms.Button();
            this.BTN_X_Times_K = new System.Windows.Forms.Button();
            this.BTN_Decimal = new System.Windows.Forms.Button();
            this.TB_Output_X_K = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // L_k
            // 
            this.L_k.AutoSize = true;
            this.L_k.Location = new System.Drawing.Point(27, 41);
            this.L_k.Name = "L_k";
            this.L_k.Size = new System.Drawing.Size(19, 13);
            this.L_k.TabIndex = 0;
            this.L_k.Text = "k=";
            // 
            // L_Exponent
            // 
            this.L_Exponent.AutoSize = true;
            this.L_Exponent.Location = new System.Drawing.Point(61, 22);
            this.L_Exponent.Name = "L_Exponent";
            this.L_Exponent.Size = new System.Drawing.Size(84, 13);
            this.L_Exponent.TabIndex = 1;
            this.L_Exponent.Text = "Exponent (binär)";
            // 
            // L_X_Value
            // 
            this.L_X_Value.AutoSize = true;
            this.L_X_Value.Location = new System.Drawing.Point(61, 85);
            this.L_X_Value.Name = "L_X_Value";
            this.L_X_Value.Size = new System.Drawing.Size(82, 13);
            this.L_X_Value.TabIndex = 3;
            this.L_X_Value.Text = "x-Wert (dezimal)";
            // 
            // L_x
            // 
            this.L_x.AutoSize = true;
            this.L_x.Location = new System.Drawing.Point(27, 104);
            this.L_x.Name = "L_x";
            this.L_x.Size = new System.Drawing.Size(18, 13);
            this.L_x.TabIndex = 2;
            this.L_x.Text = "x=";
            // 
            // L_X_Times_Expo
            // 
            this.L_X_Times_Expo.AutoSize = true;
            this.L_X_Times_Expo.Location = new System.Drawing.Point(313, 85);
            this.L_X_Times_Expo.Name = "L_X_Times_Expo";
            this.L_X_Times_Expo.Size = new System.Drawing.Size(131, 13);
            this.L_X_Times_Expo.TabIndex = 5;
            this.L_X_Times_Expo.Text = "Ergebnis x hoch Exponent";
            // 
            // L_QM_String
            // 
            this.L_QM_String.AutoSize = true;
            this.L_QM_String.Location = new System.Drawing.Point(313, 22);
            this.L_QM_String.Name = "L_QM_String";
            this.L_QM_String.Size = new System.Drawing.Size(54, 13);
            this.L_QM_String.TabIndex = 4;
            this.L_QM_String.Text = "QM-String";
            // 
            // TB_Exponent
            // 
            this.TB_Exponent.Location = new System.Drawing.Point(64, 41);
            this.TB_Exponent.Name = "TB_Exponent";
            this.TB_Exponent.Size = new System.Drawing.Size(145, 20);
            this.TB_Exponent.TabIndex = 6;
            // 
            // TB_X_Value
            // 
            this.TB_X_Value.Location = new System.Drawing.Point(64, 104);
            this.TB_X_Value.Name = "TB_X_Value";
            this.TB_X_Value.Size = new System.Drawing.Size(145, 20);
            this.TB_X_Value.TabIndex = 7;
            // 
            // TB_X_Times_Expo
            // 
            this.TB_X_Times_Expo.Location = new System.Drawing.Point(316, 104);
            this.TB_X_Times_Expo.Name = "TB_X_Times_Expo";
            this.TB_X_Times_Expo.Size = new System.Drawing.Size(145, 20);
            this.TB_X_Times_Expo.TabIndex = 8;
            // 
            // TB_QM_String
            // 
            this.TB_QM_String.Location = new System.Drawing.Point(316, 41);
            this.TB_QM_String.Name = "TB_QM_String";
            this.TB_QM_String.Size = new System.Drawing.Size(145, 20);
            this.TB_QM_String.TabIndex = 9;
            // 
            // L_Arrow
            // 
            this.L_Arrow.AutoSize = true;
            this.L_Arrow.Location = new System.Drawing.Point(259, 44);
            this.L_Arrow.Name = "L_Arrow";
            this.L_Arrow.Size = new System.Drawing.Size(19, 13);
            this.L_Arrow.TabIndex = 10;
            this.L_Arrow.Text = "-->";
            // 
            // BTN_Create_QM
            // 
            this.BTN_Create_QM.Location = new System.Drawing.Point(536, 32);
            this.BTN_Create_QM.Name = "BTN_Create_QM";
            this.BTN_Create_QM.Size = new System.Drawing.Size(75, 37);
            this.BTN_Create_QM.TabIndex = 11;
            this.BTN_Create_QM.Text = "Erzeuge QM-String";
            this.BTN_Create_QM.UseVisualStyleBackColor = true;
            this.BTN_Create_QM.Click += new System.EventHandler(this.BTN_Create_QM_String_Click);
            // 
            // BTN_X_Times_K
            // 
            this.BTN_X_Times_K.Location = new System.Drawing.Point(536, 95);
            this.BTN_X_Times_K.Name = "BTN_X_Times_K";
            this.BTN_X_Times_K.Size = new System.Drawing.Size(75, 37);
            this.BTN_X_Times_K.TabIndex = 12;
            this.BTN_X_Times_K.Text = "Berechne x hoch k";
            this.BTN_X_Times_K.UseVisualStyleBackColor = true;
            this.BTN_X_Times_K.Click += new System.EventHandler(this.BTN_x_pow_k_Click);
            // 
            // BTN_Decimal
            // 
            this.BTN_Decimal.Location = new System.Drawing.Point(64, 165);
            this.BTN_Decimal.Name = "BTN_Decimal";
            this.BTN_Decimal.Size = new System.Drawing.Size(75, 37);
            this.BTN_Decimal.TabIndex = 13;
            this.BTN_Decimal.Text = "Dezimal";
            this.BTN_Decimal.UseVisualStyleBackColor = true;
            this.BTN_Decimal.Click += new System.EventHandler(this.BTN_Calc_Decimal_Click);
            // 
            // TB_Output_X_K
            // 
            this.TB_Output_X_K.Location = new System.Drawing.Point(160, 174);
            this.TB_Output_X_K.Name = "TB_Output_X_K";
            this.TB_Output_X_K.Size = new System.Drawing.Size(301, 20);
            this.TB_Output_X_K.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 228);
            this.Controls.Add(this.TB_Output_X_K);
            this.Controls.Add(this.BTN_Decimal);
            this.Controls.Add(this.BTN_X_Times_K);
            this.Controls.Add(this.BTN_Create_QM);
            this.Controls.Add(this.L_Arrow);
            this.Controls.Add(this.TB_QM_String);
            this.Controls.Add(this.TB_X_Times_Expo);
            this.Controls.Add(this.TB_X_Value);
            this.Controls.Add(this.TB_Exponent);
            this.Controls.Add(this.L_X_Times_Expo);
            this.Controls.Add(this.L_QM_String);
            this.Controls.Add(this.L_X_Value);
            this.Controls.Add(this.L_x);
            this.Controls.Add(this.L_Exponent);
            this.Controls.Add(this.L_k);
            this.Name = "Form1";
            this.Text = "Binäre Exponentation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_k;
        private System.Windows.Forms.Label L_Exponent;
        private System.Windows.Forms.Label L_X_Value;
        private System.Windows.Forms.Label L_x;
        private System.Windows.Forms.Label L_X_Times_Expo;
        private System.Windows.Forms.Label L_QM_String;
        private System.Windows.Forms.TextBox TB_Exponent;
        private System.Windows.Forms.TextBox TB_X_Value;
        private System.Windows.Forms.TextBox TB_X_Times_Expo;
        private System.Windows.Forms.TextBox TB_QM_String;
        private System.Windows.Forms.Label L_Arrow;
        private System.Windows.Forms.Button BTN_Create_QM;
        private System.Windows.Forms.Button BTN_X_Times_K;
        private System.Windows.Forms.Button BTN_Decimal;
        private System.Windows.Forms.TextBox TB_Output_X_K;
    }
}

