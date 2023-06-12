namespace Strings_Task_5
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
            this.TB_Input = new System.Windows.Forms.TextBox();
            this.BTN_Execute = new System.Windows.Forms.Button();
            this.L_Output = new System.Windows.Forms.Label();
            this.CB_Count_Vowels = new System.Windows.Forms.CheckBox();
            this.CB_Character_Frequency = new System.Windows.Forms.CheckBox();
            this.TB_Input_Character = new System.Windows.Forms.TextBox();
            this.P_ShowPercent = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.L_Number_Vowels = new System.Windows.Forms.Label();
            this.L_Output_Vowel_Status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input Text";
            // 
            // TB_Input
            // 
            this.TB_Input.Location = new System.Drawing.Point(113, 24);
            this.TB_Input.Name = "TB_Input";
            this.TB_Input.Size = new System.Drawing.Size(330, 20);
            this.TB_Input.TabIndex = 1;
            // 
            // BTN_Execute
            // 
            this.BTN_Execute.Location = new System.Drawing.Point(32, 131);
            this.BTN_Execute.Name = "BTN_Execute";
            this.BTN_Execute.Size = new System.Drawing.Size(103, 23);
            this.BTN_Execute.TabIndex = 2;
            this.BTN_Execute.Text = "Execute";
            this.BTN_Execute.UseVisualStyleBackColor = true;
            this.BTN_Execute.Click += new System.EventHandler(this.BTN_Execute_Click);
            // 
            // L_Output
            // 
            this.L_Output.AutoSize = true;
            this.L_Output.Location = new System.Drawing.Point(159, 77);
            this.L_Output.Name = "L_Output";
            this.L_Output.Size = new System.Drawing.Size(0, 13);
            this.L_Output.TabIndex = 3;
            // 
            // CB_Count_Vowels
            // 
            this.CB_Count_Vowels.AutoSize = true;
            this.CB_Count_Vowels.Location = new System.Drawing.Point(32, 73);
            this.CB_Count_Vowels.Name = "CB_Count_Vowels";
            this.CB_Count_Vowels.Size = new System.Drawing.Size(91, 17);
            this.CB_Count_Vowels.TabIndex = 4;
            this.CB_Count_Vowels.Text = "Count Vowels";
            this.CB_Count_Vowels.UseVisualStyleBackColor = true;
            // 
            // CB_Character_Frequency
            // 
            this.CB_Character_Frequency.AutoSize = true;
            this.CB_Character_Frequency.Location = new System.Drawing.Point(32, 96);
            this.CB_Character_Frequency.Name = "CB_Character_Frequency";
            this.CB_Character_Frequency.Size = new System.Drawing.Size(122, 17);
            this.CB_Character_Frequency.TabIndex = 5;
            this.CB_Character_Frequency.Text = "Character frequency";
            this.CB_Character_Frequency.UseVisualStyleBackColor = true;
            // 
            // TB_Input_Character
            // 
            this.TB_Input_Character.Location = new System.Drawing.Point(173, 96);
            this.TB_Input_Character.Name = "TB_Input_Character";
            this.TB_Input_Character.Size = new System.Drawing.Size(23, 20);
            this.TB_Input_Character.TabIndex = 6;
            // 
            // P_ShowPercent
            // 
            this.P_ShowPercent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.P_ShowPercent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.P_ShowPercent.Location = new System.Drawing.Point(413, 54);
            this.P_ShowPercent.Name = "P_ShowPercent";
            this.P_ShowPercent.Size = new System.Drawing.Size(30, 100);
            this.P_ShowPercent.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(461, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "100%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(461, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "0%";
            // 
            // L_Number_Vowels
            // 
            this.L_Number_Vowels.AutoSize = true;
            this.L_Number_Vowels.Location = new System.Drawing.Point(523, 57);
            this.L_Number_Vowels.Name = "L_Number_Vowels";
            this.L_Number_Vowels.Size = new System.Drawing.Size(0, 13);
            this.L_Number_Vowels.TabIndex = 10;
            // 
            // L_Output_Vowel_Status
            // 
            this.L_Output_Vowel_Status.AutoSize = true;
            this.L_Output_Vowel_Status.Location = new System.Drawing.Point(461, 96);
            this.L_Output_Vowel_Status.Name = "L_Output_Vowel_Status";
            this.L_Output_Vowel_Status.Size = new System.Drawing.Size(0, 13);
            this.L_Output_Vowel_Status.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 166);
            this.Controls.Add(this.L_Output_Vowel_Status);
            this.Controls.Add(this.L_Number_Vowels);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.P_ShowPercent);
            this.Controls.Add(this.TB_Input_Character);
            this.Controls.Add(this.CB_Character_Frequency);
            this.Controls.Add(this.CB_Count_Vowels);
            this.Controls.Add(this.L_Output);
            this.Controls.Add(this.BTN_Execute);
            this.Controls.Add(this.TB_Input);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_Input;
        private System.Windows.Forms.Button BTN_Execute;
        private System.Windows.Forms.Label L_Output;
        private System.Windows.Forms.CheckBox CB_Count_Vowels;
        private System.Windows.Forms.CheckBox CB_Character_Frequency;
        private System.Windows.Forms.TextBox TB_Input_Character;
        private System.Windows.Forms.Panel P_ShowPercent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label L_Number_Vowels;
        private System.Windows.Forms.Label L_Output_Vowel_Status;
    }
}

