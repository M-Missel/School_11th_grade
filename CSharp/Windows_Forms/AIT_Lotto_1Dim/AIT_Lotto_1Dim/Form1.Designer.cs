namespace AIT_Lotto_1Dim
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
            this.BTN_INIT_GAMEFIELD = new System.Windows.Forms.Button();
            this.BTN_PLAY_LOTTO = new System.Windows.Forms.Button();
            this.BTN_OUTPUT_GAMEFIELD = new System.Windows.Forms.Button();
            this.BTN_OUT_LOTTO_NUMBERS = new System.Windows.Forms.Button();
            this.BTN_INPUT_LOTTO_NB = new System.Windows.Forms.Button();
            this.LB_GAMEFIELD_OUTPUT = new System.Windows.Forms.ListBox();
            this.LB_LOTTO_NUMBERS = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BTN_INIT_GAMEFIELD
            // 
            this.BTN_INIT_GAMEFIELD.Location = new System.Drawing.Point(89, 55);
            this.BTN_INIT_GAMEFIELD.Name = "BTN_INIT_GAMEFIELD";
            this.BTN_INIT_GAMEFIELD.Size = new System.Drawing.Size(109, 48);
            this.BTN_INIT_GAMEFIELD.TabIndex = 0;
            this.BTN_INIT_GAMEFIELD.Text = "Init Gamefield";
            this.BTN_INIT_GAMEFIELD.UseVisualStyleBackColor = true;
            this.BTN_INIT_GAMEFIELD.Click += new System.EventHandler(this.BTN_INIT_Array);
            // 
            // BTN_PLAY_LOTTO
            // 
            this.BTN_PLAY_LOTTO.Location = new System.Drawing.Point(89, 109);
            this.BTN_PLAY_LOTTO.Name = "BTN_PLAY_LOTTO";
            this.BTN_PLAY_LOTTO.Size = new System.Drawing.Size(109, 48);
            this.BTN_PLAY_LOTTO.TabIndex = 1;
            this.BTN_PLAY_LOTTO.Text = "Play Lotto";
            this.BTN_PLAY_LOTTO.UseVisualStyleBackColor = true;
            this.BTN_PLAY_LOTTO.Click += new System.EventHandler(this.BTN_LOTTO_PLAY);
            // 
            // BTN_OUTPUT_GAMEFIELD
            // 
            this.BTN_OUTPUT_GAMEFIELD.Location = new System.Drawing.Point(89, 185);
            this.BTN_OUTPUT_GAMEFIELD.Name = "BTN_OUTPUT_GAMEFIELD";
            this.BTN_OUTPUT_GAMEFIELD.Size = new System.Drawing.Size(109, 48);
            this.BTN_OUTPUT_GAMEFIELD.TabIndex = 2;
            this.BTN_OUTPUT_GAMEFIELD.Text = "Output Gamefield";
            this.BTN_OUTPUT_GAMEFIELD.UseVisualStyleBackColor = true;
            this.BTN_OUTPUT_GAMEFIELD.Click += new System.EventHandler(this.BTN_OUTPUT_Gamefield);
            // 
            // BTN_OUT_LOTTO_NUMBERS
            // 
            this.BTN_OUT_LOTTO_NUMBERS.Location = new System.Drawing.Point(89, 239);
            this.BTN_OUT_LOTTO_NUMBERS.Name = "BTN_OUT_LOTTO_NUMBERS";
            this.BTN_OUT_LOTTO_NUMBERS.Size = new System.Drawing.Size(109, 48);
            this.BTN_OUT_LOTTO_NUMBERS.TabIndex = 3;
            this.BTN_OUT_LOTTO_NUMBERS.Text = "Output 6 Numbers";
            this.BTN_OUT_LOTTO_NUMBERS.UseVisualStyleBackColor = true;
            this.BTN_OUT_LOTTO_NUMBERS.Click += new System.EventHandler(this.BTN_ADD_Numbers);
            // 
            // BTN_INPUT_LOTTO_NB
            // 
            this.BTN_INPUT_LOTTO_NB.Location = new System.Drawing.Point(89, 325);
            this.BTN_INPUT_LOTTO_NB.Name = "BTN_INPUT_LOTTO_NB";
            this.BTN_INPUT_LOTTO_NB.Size = new System.Drawing.Size(109, 48);
            this.BTN_INPUT_LOTTO_NB.TabIndex = 4;
            this.BTN_INPUT_LOTTO_NB.Text = "Input 6 Numbers";
            this.BTN_INPUT_LOTTO_NB.UseVisualStyleBackColor = true;
            this.BTN_INPUT_LOTTO_NB.Click += new System.EventHandler(this.BTN_OUTPUT_LN);
            // 
            // LB_GAMEFIELD_OUTPUT
            // 
            this.LB_GAMEFIELD_OUTPUT.FormattingEnabled = true;
            this.LB_GAMEFIELD_OUTPUT.Location = new System.Drawing.Point(318, 55);
            this.LB_GAMEFIELD_OUTPUT.Name = "LB_GAMEFIELD_OUTPUT";
            this.LB_GAMEFIELD_OUTPUT.Size = new System.Drawing.Size(253, 368);
            this.LB_GAMEFIELD_OUTPUT.TabIndex = 5;
            // 
            // LB_LOTTO_NUMBERS
            // 
            this.LB_LOTTO_NUMBERS.FormattingEnabled = true;
            this.LB_LOTTO_NUMBERS.Location = new System.Drawing.Point(655, 55);
            this.LB_LOTTO_NUMBERS.Name = "LB_LOTTO_NUMBERS";
            this.LB_LOTTO_NUMBERS.Size = new System.Drawing.Size(253, 186);
            this.LB_LOTTO_NUMBERS.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 536);
            this.Controls.Add(this.LB_LOTTO_NUMBERS);
            this.Controls.Add(this.LB_GAMEFIELD_OUTPUT);
            this.Controls.Add(this.BTN_INPUT_LOTTO_NB);
            this.Controls.Add(this.BTN_OUT_LOTTO_NUMBERS);
            this.Controls.Add(this.BTN_OUTPUT_GAMEFIELD);
            this.Controls.Add(this.BTN_PLAY_LOTTO);
            this.Controls.Add(this.BTN_INIT_GAMEFIELD);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_INIT_GAMEFIELD;
        private System.Windows.Forms.Button BTN_PLAY_LOTTO;
        private System.Windows.Forms.Button BTN_OUTPUT_GAMEFIELD;
        private System.Windows.Forms.Button BTN_OUT_LOTTO_NUMBERS;
        private System.Windows.Forms.Button BTN_INPUT_LOTTO_NB;
        private System.Windows.Forms.ListBox LB_GAMEFIELD_OUTPUT;
        private System.Windows.Forms.ListBox LB_LOTTO_NUMBERS;
    }
}

