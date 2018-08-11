namespace Draw
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.button_init = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.label_a1 = new System.Windows.Forms.Label();
            this.label_a2 = new System.Windows.Forms.Label();
            this.label_b = new System.Windows.Forms.Label();
            this.label_q = new System.Windows.Forms.Label();
            this.textBox_q = new System.Windows.Forms.TextBox();
            this.textBox_b = new System.Windows.Forms.TextBox();
            this.textBox_a1 = new System.Windows.Forms.TextBox();
            this.textBox_a2 = new System.Windows.Forms.TextBox();
            this.label_T = new System.Windows.Forms.Label();
            this.textBox_T = new System.Windows.Forms.TextBox();
            this.button_output = new System.Windows.Forms.Button();
            this.label_x0 = new System.Windows.Forms.Label();
            this.textBox_x0 = new System.Windows.Forms.TextBox();
            this.textBox_x1 = new System.Windows.Forms.TextBox();
            this.textBox_x2 = new System.Windows.Forms.TextBox();
            this.label_k0 = new System.Windows.Forms.Label();
            this.textBox_k0 = new System.Windows.Forms.TextBox();
            this.textBox_xx2 = new System.Windows.Forms.TextBox();
            this.textBox_xx1 = new System.Windows.Forms.TextBox();
            this.textBox_xx0 = new System.Windows.Forms.TextBox();
            this.label_xx = new System.Windows.Forms.Label();
            this.button_control = new System.Windows.Forms.Button();
            this.button_outMatrix = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(647, 394);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.MaximumSize = new System.Drawing.Size(200, 200);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(75, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "Build";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.zedGraphControl1.IsShowPointValues = false;
            this.zedGraphControl1.Location = new System.Drawing.Point(0, 0);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.PointValueFormat = "G";
            this.zedGraphControl1.Size = new System.Drawing.Size(880, 383);
            this.zedGraphControl1.TabIndex = 0;
            // 
            // button_init
            // 
            this.button_init.AutoSize = true;
            this.button_init.Location = new System.Drawing.Point(573, 394);
            this.button_init.Margin = new System.Windows.Forms.Padding(2);
            this.button_init.MaximumSize = new System.Drawing.Size(200, 200);
            this.button_init.Name = "button_init";
            this.button_init.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button_init.Size = new System.Drawing.Size(70, 43);
            this.button_init.TabIndex = 4;
            this.button_init.Text = "Initialize";
            this.button_init.UseVisualStyleBackColor = true;
            this.button_init.Click += new System.EventHandler(this.button_init_Click);
            // 
            // button_exit
            // 
            this.button_exit.AutoSize = true;
            this.button_exit.Location = new System.Drawing.Point(814, 394);
            this.button_exit.Margin = new System.Windows.Forms.Padding(2);
            this.button_exit.MaximumSize = new System.Drawing.Size(200, 200);
            this.button_exit.Name = "button_exit";
            this.button_exit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button_exit.Size = new System.Drawing.Size(59, 43);
            this.button_exit.TabIndex = 5;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // label_a1
            // 
            this.label_a1.AutoSize = true;
            this.label_a1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label_a1.Location = new System.Drawing.Point(204, 397);
            this.label_a1.Name = "label_a1";
            this.label_a1.Size = new System.Drawing.Size(47, 13);
            this.label_a1.TabIndex = 6;
            this.label_a1.Text = "Enter a1";
            // 
            // label_a2
            // 
            this.label_a2.AutoSize = true;
            this.label_a2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label_a2.Location = new System.Drawing.Point(204, 430);
            this.label_a2.Name = "label_a2";
            this.label_a2.Size = new System.Drawing.Size(47, 13);
            this.label_a2.TabIndex = 7;
            this.label_a2.Text = "Enter a2";
            // 
            // label_b
            // 
            this.label_b.AutoSize = true;
            this.label_b.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label_b.Location = new System.Drawing.Point(12, 459);
            this.label_b.Name = "label_b";
            this.label_b.Size = new System.Drawing.Size(41, 13);
            this.label_b.TabIndex = 8;
            this.label_b.Text = "Enter b";
            // 
            // label_q
            // 
            this.label_q.AutoSize = true;
            this.label_q.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label_q.Location = new System.Drawing.Point(12, 429);
            this.label_q.Name = "label_q";
            this.label_q.Size = new System.Drawing.Size(41, 13);
            this.label_q.TabIndex = 9;
            this.label_q.Text = "Enter q";
            this.label_q.Click += new System.EventHandler(this.label_q_Click);
            // 
            // textBox_q
            // 
            this.textBox_q.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox_q.Location = new System.Drawing.Point(69, 426);
            this.textBox_q.Name = "textBox_q";
            this.textBox_q.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox_q.Size = new System.Drawing.Size(100, 20);
            this.textBox_q.TabIndex = 10;
            this.textBox_q.Text = "3";
            this.textBox_q.TextChanged += new System.EventHandler(this.textBox_q_TextChanged);
            // 
            // textBox_b
            // 
            this.textBox_b.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox_b.Location = new System.Drawing.Point(70, 452);
            this.textBox_b.Name = "textBox_b";
            this.textBox_b.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox_b.Size = new System.Drawing.Size(100, 20);
            this.textBox_b.TabIndex = 11;
            this.textBox_b.Text = "1";
            // 
            // textBox_a1
            // 
            this.textBox_a1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox_a1.Location = new System.Drawing.Point(257, 397);
            this.textBox_a1.Name = "textBox_a1";
            this.textBox_a1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox_a1.Size = new System.Drawing.Size(100, 20);
            this.textBox_a1.TabIndex = 12;
            this.textBox_a1.Text = "1";
            // 
            // textBox_a2
            // 
            this.textBox_a2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox_a2.Location = new System.Drawing.Point(257, 426);
            this.textBox_a2.Name = "textBox_a2";
            this.textBox_a2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox_a2.Size = new System.Drawing.Size(100, 20);
            this.textBox_a2.TabIndex = 13;
            this.textBox_a2.Text = "3";
            // 
            // label_T
            // 
            this.label_T.AutoSize = true;
            this.label_T.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label_T.Location = new System.Drawing.Point(204, 459);
            this.label_T.Name = "label_T";
            this.label_T.Size = new System.Drawing.Size(42, 13);
            this.label_T.TabIndex = 14;
            this.label_T.Text = "Enter T";
            // 
            // textBox_T
            // 
            this.textBox_T.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox_T.Location = new System.Drawing.Point(257, 452);
            this.textBox_T.Name = "textBox_T";
            this.textBox_T.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox_T.Size = new System.Drawing.Size(100, 20);
            this.textBox_T.TabIndex = 15;
            this.textBox_T.Text = "0,02";
            this.textBox_T.TextChanged += new System.EventHandler(this.textBox_T_TextChanged);
            // 
            // button_output
            // 
            this.button_output.AutoSize = true;
            this.button_output.Location = new System.Drawing.Point(726, 394);
            this.button_output.Margin = new System.Windows.Forms.Padding(2);
            this.button_output.MaximumSize = new System.Drawing.Size(200, 200);
            this.button_output.Name = "button_output";
            this.button_output.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button_output.Size = new System.Drawing.Size(84, 43);
            this.button_output.TabIndex = 16;
            this.button_output.Text = "Output X";
            this.button_output.UseVisualStyleBackColor = true;
            this.button_output.Click += new System.EventHandler(this.button_output_Click);
            // 
            // label_x0
            // 
            this.label_x0.AutoSize = true;
            this.label_x0.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label_x0.Location = new System.Drawing.Point(12, 400);
            this.label_x0.Name = "label_x0";
            this.label_x0.Size = new System.Drawing.Size(52, 13);
            this.label_x0.TabIndex = 17;
            this.label_x0.Text = "Enter x_0";
            // 
            // textBox_x0
            // 
            this.textBox_x0.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox_x0.Location = new System.Drawing.Point(70, 397);
            this.textBox_x0.Name = "textBox_x0";
            this.textBox_x0.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox_x0.Size = new System.Drawing.Size(26, 20);
            this.textBox_x0.TabIndex = 18;
            this.textBox_x0.Text = "0";
            // 
            // textBox_x1
            // 
            this.textBox_x1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox_x1.Location = new System.Drawing.Point(102, 397);
            this.textBox_x1.Name = "textBox_x1";
            this.textBox_x1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox_x1.Size = new System.Drawing.Size(28, 20);
            this.textBox_x1.TabIndex = 19;
            this.textBox_x1.Text = "0";
            // 
            // textBox_x2
            // 
            this.textBox_x2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox_x2.Location = new System.Drawing.Point(136, 397);
            this.textBox_x2.Name = "textBox_x2";
            this.textBox_x2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox_x2.Size = new System.Drawing.Size(28, 20);
            this.textBox_x2.TabIndex = 20;
            this.textBox_x2.Text = "0";
            // 
            // label_k0
            // 
            this.label_k0.AutoSize = true;
            this.label_k0.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label_k0.Location = new System.Drawing.Point(391, 400);
            this.label_k0.Name = "label_k0";
            this.label_k0.Size = new System.Drawing.Size(47, 13);
            this.label_k0.TabIndex = 21;
            this.label_k0.Text = "Enter k0";
            // 
            // textBox_k0
            // 
            this.textBox_k0.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox_k0.Location = new System.Drawing.Point(444, 394);
            this.textBox_k0.Name = "textBox_k0";
            this.textBox_k0.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox_k0.Size = new System.Drawing.Size(100, 20);
            this.textBox_k0.TabIndex = 22;
            this.textBox_k0.Text = "20";
            // 
            // textBox_xx2
            // 
            this.textBox_xx2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox_xx2.Location = new System.Drawing.Point(515, 423);
            this.textBox_xx2.Name = "textBox_xx2";
            this.textBox_xx2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox_xx2.Size = new System.Drawing.Size(28, 20);
            this.textBox_xx2.TabIndex = 26;
            this.textBox_xx2.Text = "0";
            // 
            // textBox_xx1
            // 
            this.textBox_xx1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox_xx1.Location = new System.Drawing.Point(481, 423);
            this.textBox_xx1.Name = "textBox_xx1";
            this.textBox_xx1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox_xx1.Size = new System.Drawing.Size(28, 20);
            this.textBox_xx1.TabIndex = 25;
            this.textBox_xx1.Text = "0";
            // 
            // textBox_xx0
            // 
            this.textBox_xx0.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox_xx0.Location = new System.Drawing.Point(449, 423);
            this.textBox_xx0.Name = "textBox_xx0";
            this.textBox_xx0.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox_xx0.Size = new System.Drawing.Size(26, 20);
            this.textBox_xx0.TabIndex = 24;
            this.textBox_xx0.Text = "2";
            // 
            // label_xx
            // 
            this.label_xx.AutoSize = true;
            this.label_xx.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label_xx.Location = new System.Drawing.Point(391, 426);
            this.label_xx.Name = "label_xx";
            this.label_xx.Size = new System.Drawing.Size(44, 13);
            this.label_xx.TabIndex = 23;
            this.label_xx.Text = "Enter x*";
            // 
            // button_control
            // 
            this.button_control.AutoSize = true;
            this.button_control.Location = new System.Drawing.Point(647, 445);
            this.button_control.Margin = new System.Windows.Forms.Padding(2);
            this.button_control.MaximumSize = new System.Drawing.Size(200, 200);
            this.button_control.Name = "button_control";
            this.button_control.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button_control.Size = new System.Drawing.Size(75, 41);
            this.button_control.TabIndex = 27;
            this.button_control.Text = "Build control";
            this.button_control.UseVisualStyleBackColor = true;
            this.button_control.Click += new System.EventHandler(this.button_control_Click);
            // 
            // button_outMatrix
            // 
            this.button_outMatrix.AutoSize = true;
            this.button_outMatrix.Location = new System.Drawing.Point(726, 446);
            this.button_outMatrix.Margin = new System.Windows.Forms.Padding(2);
            this.button_outMatrix.MaximumSize = new System.Drawing.Size(200, 200);
            this.button_outMatrix.Name = "button_outMatrix";
            this.button_outMatrix.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button_outMatrix.Size = new System.Drawing.Size(84, 41);
            this.button_outMatrix.TabIndex = 28;
            this.button_outMatrix.Text = "Output matrixs";
            this.button_outMatrix.UseVisualStyleBackColor = true;
            this.button_outMatrix.Click += new System.EventHandler(this.button_outMatrix_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 499);
            this.Controls.Add(this.button_outMatrix);
            this.Controls.Add(this.button_control);
            this.Controls.Add(this.textBox_xx2);
            this.Controls.Add(this.textBox_xx1);
            this.Controls.Add(this.textBox_xx0);
            this.Controls.Add(this.label_xx);
            this.Controls.Add(this.textBox_k0);
            this.Controls.Add(this.label_k0);
            this.Controls.Add(this.textBox_x2);
            this.Controls.Add(this.textBox_x1);
            this.Controls.Add(this.textBox_x0);
            this.Controls.Add(this.label_x0);
            this.Controls.Add(this.button_output);
            this.Controls.Add(this.textBox_T);
            this.Controls.Add(this.label_T);
            this.Controls.Add(this.textBox_a2);
            this.Controls.Add(this.textBox_a1);
            this.Controls.Add(this.textBox_b);
            this.Controls.Add(this.textBox_q);
            this.Controls.Add(this.label_q);
            this.Controls.Add(this.label_b);
            this.Controls.Add(this.label_a2);
            this.Controls.Add(this.label_a1);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_init);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.zedGraphControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Button button_init;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Label label_a1;
        private System.Windows.Forms.Label label_a2;
        private System.Windows.Forms.Label label_b;
        private System.Windows.Forms.Label label_q;
        private System.Windows.Forms.TextBox textBox_q;
        private System.Windows.Forms.TextBox textBox_b;
        private System.Windows.Forms.TextBox textBox_a1;
        private System.Windows.Forms.TextBox textBox_a2;
        private System.Windows.Forms.Label label_T;
        private System.Windows.Forms.TextBox textBox_T;
        private System.Windows.Forms.Button button_output;
        private System.Windows.Forms.Label label_x0;
        private System.Windows.Forms.TextBox textBox_x0;
        private System.Windows.Forms.TextBox textBox_x1;
        private System.Windows.Forms.TextBox textBox_x2;
        private System.Windows.Forms.Label label_k0;
        private System.Windows.Forms.TextBox textBox_k0;
        private System.Windows.Forms.TextBox textBox_xx2;
        private System.Windows.Forms.TextBox textBox_xx1;
        private System.Windows.Forms.TextBox textBox_xx0;
        private System.Windows.Forms.Label label_xx;
        private System.Windows.Forms.Button button_control;
        private System.Windows.Forms.Button button_outMatrix;


    }
}

