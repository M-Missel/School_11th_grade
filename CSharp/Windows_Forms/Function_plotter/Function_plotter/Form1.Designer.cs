namespace Function_plotter
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
            this.P_FunctionPlotter = new System.Windows.Forms.Panel();
            this.L_Point = new System.Windows.Forms.Label();
            this.L_XPoint = new System.Windows.Forms.Label();
            this.L_YPoint = new System.Windows.Forms.Label();
            this.TB_XPoint = new System.Windows.Forms.TextBox();
            this.TB_YPoint = new System.Windows.Forms.TextBox();
            this.BTN_DrawPoint = new System.Windows.Forms.Button();
            this.L_X_Axis = new System.Windows.Forms.Label();
            this.L_X_Begin = new System.Windows.Forms.Label();
            this.L_X_End = new System.Windows.Forms.Label();
            this.L_Y_End = new System.Windows.Forms.Label();
            this.L_Y_Begin = new System.Windows.Forms.Label();
            this.L_Y_Axis = new System.Windows.Forms.Label();
            this.TB_X_Begin = new System.Windows.Forms.TextBox();
            this.TB_X_End = new System.Windows.Forms.TextBox();
            this.TB_Y_End = new System.Windows.Forms.TextBox();
            this.TB_Y_Begin = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.L_Function = new System.Windows.Forms.Label();
            this.L_Function_A = new System.Windows.Forms.Label();
            this.L_Function_B = new System.Windows.Forms.Label();
            this.L_Function_C = new System.Windows.Forms.Label();
            this.TB_A_Value = new System.Windows.Forms.TextBox();
            this.TB_B_Value = new System.Windows.Forms.TextBox();
            this.TB_C_Value = new System.Windows.Forms.TextBox();
            this.BTN_Draw_Function = new System.Windows.Forms.Button();
            this.L_Grid = new System.Windows.Forms.Label();
            this.TB_X_Grid = new System.Windows.Forms.TextBox();
            this.L_X_Grid = new System.Windows.Forms.Label();
            this.TB_Y_Grid = new System.Windows.Forms.TextBox();
            this.L_Y_Grid = new System.Windows.Forms.Label();
            this.BTN_Draw_Grid = new System.Windows.Forms.Button();
            this.BTN_Clear_Grid = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // P_FunctionPlotter
            // 
            this.P_FunctionPlotter.BackColor = System.Drawing.Color.White;
            this.P_FunctionPlotter.Location = new System.Drawing.Point(246, 12);
            this.P_FunctionPlotter.Name = "P_FunctionPlotter";
            this.P_FunctionPlotter.Size = new System.Drawing.Size(601, 401);
            this.P_FunctionPlotter.TabIndex = 0;
            // 
            // L_Point
            // 
            this.L_Point.AutoSize = true;
            this.L_Point.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Point.Location = new System.Drawing.Point(246, 426);
            this.L_Point.Name = "L_Point";
            this.L_Point.Size = new System.Drawing.Size(50, 17);
            this.L_Point.TabIndex = 1;
            this.L_Point.Text = "Point:";
            // 
            // L_XPoint
            // 
            this.L_XPoint.AutoSize = true;
            this.L_XPoint.Location = new System.Drawing.Point(246, 455);
            this.L_XPoint.Name = "L_XPoint";
            this.L_XPoint.Size = new System.Drawing.Size(15, 13);
            this.L_XPoint.TabIndex = 2;
            this.L_XPoint.Text = "x:";
            // 
            // L_YPoint
            // 
            this.L_YPoint.AutoSize = true;
            this.L_YPoint.Location = new System.Drawing.Point(246, 482);
            this.L_YPoint.Name = "L_YPoint";
            this.L_YPoint.Size = new System.Drawing.Size(15, 13);
            this.L_YPoint.TabIndex = 3;
            this.L_YPoint.Text = "y:";
            // 
            // TB_XPoint
            // 
            this.TB_XPoint.Location = new System.Drawing.Point(267, 455);
            this.TB_XPoint.Name = "TB_XPoint";
            this.TB_XPoint.Size = new System.Drawing.Size(160, 20);
            this.TB_XPoint.TabIndex = 4;
            // 
            // TB_YPoint
            // 
            this.TB_YPoint.Location = new System.Drawing.Point(267, 482);
            this.TB_YPoint.Name = "TB_YPoint";
            this.TB_YPoint.Size = new System.Drawing.Size(160, 20);
            this.TB_YPoint.TabIndex = 5;
            // 
            // BTN_DrawPoint
            // 
            this.BTN_DrawPoint.Location = new System.Drawing.Point(454, 455);
            this.BTN_DrawPoint.Name = "BTN_DrawPoint";
            this.BTN_DrawPoint.Size = new System.Drawing.Size(89, 46);
            this.BTN_DrawPoint.TabIndex = 6;
            this.BTN_DrawPoint.Text = "Draw";
            this.BTN_DrawPoint.UseVisualStyleBackColor = true;
            this.BTN_DrawPoint.Click += new System.EventHandler(this.BTN_DrawPoint_Click);
            // 
            // L_X_Axis
            // 
            this.L_X_Axis.AutoSize = true;
            this.L_X_Axis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_X_Axis.Location = new System.Drawing.Point(12, 175);
            this.L_X_Axis.Name = "L_X_Axis";
            this.L_X_Axis.Size = new System.Drawing.Size(47, 15);
            this.L_X_Axis.TabIndex = 7;
            this.L_X_Axis.Text = "X-Axis";
            // 
            // L_X_Begin
            // 
            this.L_X_Begin.AutoSize = true;
            this.L_X_Begin.Location = new System.Drawing.Point(12, 198);
            this.L_X_Begin.Name = "L_X_Begin";
            this.L_X_Begin.Size = new System.Drawing.Size(54, 13);
            this.L_X_Begin.TabIndex = 8;
            this.L_X_Begin.Text = "Beginning";
            // 
            // L_X_End
            // 
            this.L_X_End.AutoSize = true;
            this.L_X_End.Location = new System.Drawing.Point(12, 222);
            this.L_X_End.Name = "L_X_End";
            this.L_X_End.Size = new System.Drawing.Size(40, 13);
            this.L_X_End.TabIndex = 9;
            this.L_X_End.Text = "Ending";
            // 
            // L_Y_End
            // 
            this.L_Y_End.AutoSize = true;
            this.L_Y_End.Location = new System.Drawing.Point(12, 297);
            this.L_Y_End.Name = "L_Y_End";
            this.L_Y_End.Size = new System.Drawing.Size(40, 13);
            this.L_Y_End.TabIndex = 12;
            this.L_Y_End.Text = "Ending";
            // 
            // L_Y_Begin
            // 
            this.L_Y_Begin.AutoSize = true;
            this.L_Y_Begin.Location = new System.Drawing.Point(12, 273);
            this.L_Y_Begin.Name = "L_Y_Begin";
            this.L_Y_Begin.Size = new System.Drawing.Size(54, 13);
            this.L_Y_Begin.TabIndex = 11;
            this.L_Y_Begin.Text = "Beginning";
            // 
            // L_Y_Axis
            // 
            this.L_Y_Axis.AutoSize = true;
            this.L_Y_Axis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Y_Axis.Location = new System.Drawing.Point(12, 250);
            this.L_Y_Axis.Name = "L_Y_Axis";
            this.L_Y_Axis.Size = new System.Drawing.Size(46, 15);
            this.L_Y_Axis.TabIndex = 10;
            this.L_Y_Axis.Text = "Y-Axis";
            // 
            // TB_X_Begin
            // 
            this.TB_X_Begin.Location = new System.Drawing.Point(72, 195);
            this.TB_X_Begin.Name = "TB_X_Begin";
            this.TB_X_Begin.Size = new System.Drawing.Size(100, 20);
            this.TB_X_Begin.TabIndex = 13;
            // 
            // TB_X_End
            // 
            this.TB_X_End.Location = new System.Drawing.Point(72, 219);
            this.TB_X_End.Name = "TB_X_End";
            this.TB_X_End.Size = new System.Drawing.Size(100, 20);
            this.TB_X_End.TabIndex = 14;
            // 
            // TB_Y_End
            // 
            this.TB_Y_End.Location = new System.Drawing.Point(72, 294);
            this.TB_Y_End.Name = "TB_Y_End";
            this.TB_Y_End.Size = new System.Drawing.Size(100, 20);
            this.TB_Y_End.TabIndex = 16;
            // 
            // TB_Y_Begin
            // 
            this.TB_Y_Begin.Location = new System.Drawing.Point(72, 270);
            this.TB_Y_Begin.Name = "TB_Y_Begin";
            this.TB_Y_Begin.Size = new System.Drawing.Size(100, 20);
            this.TB_Y_Begin.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 46);
            this.button1.TabIndex = 17;
            this.button1.Text = "Draw Coordsystem";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BTN_Coord_System);
            // 
            // L_Function
            // 
            this.L_Function.AutoSize = true;
            this.L_Function.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Function.Location = new System.Drawing.Point(12, 12);
            this.L_Function.Name = "L_Function";
            this.L_Function.Size = new System.Drawing.Size(109, 15);
            this.L_Function.TabIndex = 18;
            this.L_Function.Text = "y = ax^2 + bx +c";
            // 
            // L_Function_A
            // 
            this.L_Function_A.AutoSize = true;
            this.L_Function_A.Location = new System.Drawing.Point(12, 38);
            this.L_Function_A.Name = "L_Function_A";
            this.L_Function_A.Size = new System.Drawing.Size(16, 13);
            this.L_Function_A.TabIndex = 19;
            this.L_Function_A.Text = "a:";
            // 
            // L_Function_B
            // 
            this.L_Function_B.AutoSize = true;
            this.L_Function_B.Location = new System.Drawing.Point(12, 64);
            this.L_Function_B.Name = "L_Function_B";
            this.L_Function_B.Size = new System.Drawing.Size(16, 13);
            this.L_Function_B.TabIndex = 20;
            this.L_Function_B.Text = "b:";
            // 
            // L_Function_C
            // 
            this.L_Function_C.AutoSize = true;
            this.L_Function_C.Location = new System.Drawing.Point(12, 90);
            this.L_Function_C.Name = "L_Function_C";
            this.L_Function_C.Size = new System.Drawing.Size(16, 13);
            this.L_Function_C.TabIndex = 21;
            this.L_Function_C.Text = "c:";
            // 
            // TB_A_Value
            // 
            this.TB_A_Value.Location = new System.Drawing.Point(72, 38);
            this.TB_A_Value.Name = "TB_A_Value";
            this.TB_A_Value.Size = new System.Drawing.Size(100, 20);
            this.TB_A_Value.TabIndex = 22;
            // 
            // TB_B_Value
            // 
            this.TB_B_Value.Location = new System.Drawing.Point(72, 64);
            this.TB_B_Value.Name = "TB_B_Value";
            this.TB_B_Value.Size = new System.Drawing.Size(100, 20);
            this.TB_B_Value.TabIndex = 23;
            // 
            // TB_C_Value
            // 
            this.TB_C_Value.Location = new System.Drawing.Point(72, 90);
            this.TB_C_Value.Name = "TB_C_Value";
            this.TB_C_Value.Size = new System.Drawing.Size(100, 20);
            this.TB_C_Value.TabIndex = 24;
            // 
            // BTN_Draw_Function
            // 
            this.BTN_Draw_Function.Location = new System.Drawing.Point(72, 116);
            this.BTN_Draw_Function.Name = "BTN_Draw_Function";
            this.BTN_Draw_Function.Size = new System.Drawing.Size(100, 46);
            this.BTN_Draw_Function.TabIndex = 25;
            this.BTN_Draw_Function.Text = "Draw Function";
            this.BTN_Draw_Function.UseVisualStyleBackColor = true;
            this.BTN_Draw_Function.Click += new System.EventHandler(this.BTN_Draw_Graph);
            // 
            // L_Grid
            // 
            this.L_Grid.AutoSize = true;
            this.L_Grid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Grid.Location = new System.Drawing.Point(12, 369);
            this.L_Grid.Name = "L_Grid";
            this.L_Grid.Size = new System.Drawing.Size(71, 15);
            this.L_Grid.TabIndex = 26;
            this.L_Grid.Text = "Draw Grid";
            // 
            // TB_X_Grid
            // 
            this.TB_X_Grid.Location = new System.Drawing.Point(72, 400);
            this.TB_X_Grid.Name = "TB_X_Grid";
            this.TB_X_Grid.Size = new System.Drawing.Size(100, 20);
            this.TB_X_Grid.TabIndex = 28;
            // 
            // L_X_Grid
            // 
            this.L_X_Grid.AutoSize = true;
            this.L_X_Grid.Location = new System.Drawing.Point(12, 400);
            this.L_X_Grid.Name = "L_X_Grid";
            this.L_X_Grid.Size = new System.Drawing.Size(15, 13);
            this.L_X_Grid.TabIndex = 27;
            this.L_X_Grid.Text = "x:";
            // 
            // TB_Y_Grid
            // 
            this.TB_Y_Grid.Location = new System.Drawing.Point(72, 429);
            this.TB_Y_Grid.Name = "TB_Y_Grid";
            this.TB_Y_Grid.Size = new System.Drawing.Size(100, 20);
            this.TB_Y_Grid.TabIndex = 30;
            // 
            // L_Y_Grid
            // 
            this.L_Y_Grid.AutoSize = true;
            this.L_Y_Grid.Location = new System.Drawing.Point(12, 429);
            this.L_Y_Grid.Name = "L_Y_Grid";
            this.L_Y_Grid.Size = new System.Drawing.Size(15, 13);
            this.L_Y_Grid.TabIndex = 29;
            this.L_Y_Grid.Text = "y:";
            // 
            // BTN_Draw_Grid
            // 
            this.BTN_Draw_Grid.Location = new System.Drawing.Point(72, 455);
            this.BTN_Draw_Grid.Name = "BTN_Draw_Grid";
            this.BTN_Draw_Grid.Size = new System.Drawing.Size(100, 46);
            this.BTN_Draw_Grid.TabIndex = 31;
            this.BTN_Draw_Grid.Text = "Draw Coordsystem";
            this.BTN_Draw_Grid.UseVisualStyleBackColor = true;
            this.BTN_Draw_Grid.Click += new System.EventHandler(this.BTN_Draw_Grid_Extened);
            // 
            // BTN_Clear_Grid
            // 
            this.BTN_Clear_Grid.Location = new System.Drawing.Point(549, 455);
            this.BTN_Clear_Grid.Name = "BTN_Clear_Grid";
            this.BTN_Clear_Grid.Size = new System.Drawing.Size(89, 46);
            this.BTN_Clear_Grid.TabIndex = 32;
            this.BTN_Clear_Grid.Text = "Clear";
            this.BTN_Clear_Grid.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 510);
            this.Controls.Add(this.BTN_Clear_Grid);
            this.Controls.Add(this.BTN_Draw_Grid);
            this.Controls.Add(this.TB_Y_Grid);
            this.Controls.Add(this.L_Y_Grid);
            this.Controls.Add(this.TB_X_Grid);
            this.Controls.Add(this.L_X_Grid);
            this.Controls.Add(this.L_Grid);
            this.Controls.Add(this.BTN_Draw_Function);
            this.Controls.Add(this.TB_C_Value);
            this.Controls.Add(this.TB_B_Value);
            this.Controls.Add(this.TB_A_Value);
            this.Controls.Add(this.L_Function_C);
            this.Controls.Add(this.L_Function_B);
            this.Controls.Add(this.L_Function_A);
            this.Controls.Add(this.L_Function);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TB_Y_End);
            this.Controls.Add(this.TB_Y_Begin);
            this.Controls.Add(this.TB_X_End);
            this.Controls.Add(this.TB_X_Begin);
            this.Controls.Add(this.L_Y_End);
            this.Controls.Add(this.L_Y_Begin);
            this.Controls.Add(this.L_Y_Axis);
            this.Controls.Add(this.L_X_End);
            this.Controls.Add(this.L_X_Begin);
            this.Controls.Add(this.L_X_Axis);
            this.Controls.Add(this.BTN_DrawPoint);
            this.Controls.Add(this.TB_YPoint);
            this.Controls.Add(this.TB_XPoint);
            this.Controls.Add(this.L_YPoint);
            this.Controls.Add(this.L_XPoint);
            this.Controls.Add(this.L_Point);
            this.Controls.Add(this.P_FunctionPlotter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel P_FunctionPlotter;
        private System.Windows.Forms.Label L_Point;
        private System.Windows.Forms.Label L_XPoint;
        private System.Windows.Forms.Label L_YPoint;
        private System.Windows.Forms.TextBox TB_XPoint;
        private System.Windows.Forms.TextBox TB_YPoint;
        private System.Windows.Forms.Button BTN_DrawPoint;
        private System.Windows.Forms.Label L_X_Axis;
        private System.Windows.Forms.Label L_X_Begin;
        private System.Windows.Forms.Label L_X_End;
        private System.Windows.Forms.Label L_Y_End;
        private System.Windows.Forms.Label L_Y_Begin;
        private System.Windows.Forms.Label L_Y_Axis;
        private System.Windows.Forms.TextBox TB_X_Begin;
        private System.Windows.Forms.TextBox TB_X_End;
        private System.Windows.Forms.TextBox TB_Y_End;
        private System.Windows.Forms.TextBox TB_Y_Begin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label L_Function;
        private System.Windows.Forms.Label L_Function_A;
        private System.Windows.Forms.Label L_Function_B;
        private System.Windows.Forms.Label L_Function_C;
        private System.Windows.Forms.TextBox TB_A_Value;
        private System.Windows.Forms.TextBox TB_B_Value;
        private System.Windows.Forms.TextBox TB_C_Value;
        private System.Windows.Forms.Button BTN_Draw_Function;
        private System.Windows.Forms.Label L_Grid;
        private System.Windows.Forms.TextBox TB_X_Grid;
        private System.Windows.Forms.Label L_X_Grid;
        private System.Windows.Forms.TextBox TB_Y_Grid;
        private System.Windows.Forms.Label L_Y_Grid;
        private System.Windows.Forms.Button BTN_Draw_Grid;
        private System.Windows.Forms.Button BTN_Clear_Grid;
    }
}

