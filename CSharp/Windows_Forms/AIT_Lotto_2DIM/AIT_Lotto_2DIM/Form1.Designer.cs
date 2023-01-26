namespace AIT_Lotto_2DIM
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
            this.BTN_INPUT_NUMBERS = new System.Windows.Forms.Button();
            this.ST_OUTPUT = new StringGrid.StringGrid();
            this.BTN_OUTPUT_NUMBERS = new System.Windows.Forms.Button();
            this.BTN_OUTPUT_LOTTO = new System.Windows.Forms.Button();
            this.LB_LOTTO_NUMMERN = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BTN_INIT_GAMEFIELD
            // 
            this.BTN_INIT_GAMEFIELD.Location = new System.Drawing.Point(35, 37);
            this.BTN_INIT_GAMEFIELD.Name = "BTN_INIT_GAMEFIELD";
            this.BTN_INIT_GAMEFIELD.Size = new System.Drawing.Size(147, 46);
            this.BTN_INIT_GAMEFIELD.TabIndex = 0;
            this.BTN_INIT_GAMEFIELD.Text = "Spielfeld Init";
            this.BTN_INIT_GAMEFIELD.UseVisualStyleBackColor = true;
            this.BTN_INIT_GAMEFIELD.Click += new System.EventHandler(this.btn_init_array);
            // 
            // BTN_PLAY_LOTTO
            // 
            this.BTN_PLAY_LOTTO.AllowDrop = true;
            this.BTN_PLAY_LOTTO.Location = new System.Drawing.Point(35, 89);
            this.BTN_PLAY_LOTTO.Name = "BTN_PLAY_LOTTO";
            this.BTN_PLAY_LOTTO.Size = new System.Drawing.Size(147, 46);
            this.BTN_PLAY_LOTTO.TabIndex = 1;
            this.BTN_PLAY_LOTTO.Text = "Lotto spielen";
            this.BTN_PLAY_LOTTO.UseVisualStyleBackColor = true;
            this.BTN_PLAY_LOTTO.Click += new System.EventHandler(this.btn_play_lotto);
            // 
            // BTN_INPUT_NUMBERS
            // 
            this.BTN_INPUT_NUMBERS.AllowDrop = true;
            this.BTN_INPUT_NUMBERS.Location = new System.Drawing.Point(35, 293);
            this.BTN_INPUT_NUMBERS.Name = "BTN_INPUT_NUMBERS";
            this.BTN_INPUT_NUMBERS.Size = new System.Drawing.Size(147, 46);
            this.BTN_INPUT_NUMBERS.TabIndex = 2;
            this.BTN_INPUT_NUMBERS.Text = "Setzten der 6 Zahlen";
            this.BTN_INPUT_NUMBERS.UseVisualStyleBackColor = true;
            this.BTN_INPUT_NUMBERS.Click += new System.EventHandler(this.btn_input_numbers);
            // 
            // ST_OUTPUT
            // 
            this.ST_OUTPUT.ColCount = 7;
            this.ST_OUTPUT.DefaultColWidth = 35;
            this.ST_OUTPUT.DefaultRowHeight = 35;
            this.ST_OUTPUT.FixedCols = 0;
            this.ST_OUTPUT.FixedRows = 0;
            this.ST_OUTPUT.GridLineWidth = 1;
            this.ST_OUTPUT.Location = new System.Drawing.Point(254, 37);
            this.ST_OUTPUT.Name = "ST_OUTPUT";
            this.ST_OUTPUT.RowCount = 7;
            this.ST_OUTPUT.Size = new System.Drawing.Size(254, 254);
            this.ST_OUTPUT.TabIndex = 3;
            // 
            // BTN_OUTPUT_NUMBERS
            // 
            this.BTN_OUTPUT_NUMBERS.AllowDrop = true;
            this.BTN_OUTPUT_NUMBERS.Location = new System.Drawing.Point(35, 161);
            this.BTN_OUTPUT_NUMBERS.Name = "BTN_OUTPUT_NUMBERS";
            this.BTN_OUTPUT_NUMBERS.Size = new System.Drawing.Size(147, 46);
            this.BTN_OUTPUT_NUMBERS.TabIndex = 4;
            this.BTN_OUTPUT_NUMBERS.Text = "Ausgabe Spielfeld";
            this.BTN_OUTPUT_NUMBERS.UseVisualStyleBackColor = true;
            this.BTN_OUTPUT_NUMBERS.Click += new System.EventHandler(this.btn_output_number);
            // 
            // BTN_OUTPUT_LOTTO
            // 
            this.BTN_OUTPUT_LOTTO.AllowDrop = true;
            this.BTN_OUTPUT_LOTTO.Location = new System.Drawing.Point(35, 213);
            this.BTN_OUTPUT_LOTTO.Name = "BTN_OUTPUT_LOTTO";
            this.BTN_OUTPUT_LOTTO.Size = new System.Drawing.Size(147, 46);
            this.BTN_OUTPUT_LOTTO.TabIndex = 5;
            this.BTN_OUTPUT_LOTTO.Text = "Ausgabe Lottonummern";
            this.BTN_OUTPUT_LOTTO.UseVisualStyleBackColor = true;
            this.BTN_OUTPUT_LOTTO.Click += new System.EventHandler(this.btn_lotto_number);
            // 
            // LB_LOTTO_NUMMERN
            // 
            this.LB_LOTTO_NUMMERN.FormattingEnabled = true;
            this.LB_LOTTO_NUMMERN.Location = new System.Drawing.Point(582, 37);
            this.LB_LOTTO_NUMMERN.Name = "LB_LOTTO_NUMMERN";
            this.LB_LOTTO_NUMMERN.Size = new System.Drawing.Size(115, 212);
            this.LB_LOTTO_NUMMERN.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LB_LOTTO_NUMMERN);
            this.Controls.Add(this.BTN_OUTPUT_LOTTO);
            this.Controls.Add(this.BTN_OUTPUT_NUMBERS);
            this.Controls.Add(this.ST_OUTPUT);
            this.Controls.Add(this.BTN_INPUT_NUMBERS);
            this.Controls.Add(this.BTN_PLAY_LOTTO);
            this.Controls.Add(this.BTN_INIT_GAMEFIELD);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_INIT_GAMEFIELD;
        private System.Windows.Forms.Button BTN_PLAY_LOTTO;
        private System.Windows.Forms.Button BTN_INPUT_NUMBERS;
        private StringGrid.StringGrid ST_OUTPUT;
        private System.Windows.Forms.Button BTN_OUTPUT_NUMBERS;
        private System.Windows.Forms.Button BTN_OUTPUT_LOTTO;
        private System.Windows.Forms.ListBox LB_LOTTO_NUMMERN;
    }
}

