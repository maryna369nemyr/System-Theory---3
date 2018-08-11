namespace Draw
{
    partial class FormOutputMatrixs
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
            this.dataGridViewP = new System.Windows.Forms.DataGridView();
            this.P0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewL = new System.Windows.Forms.DataGridView();
            this.L0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.L1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.L2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewSigma = new System.Windows.Forms.DataGridView();
            this.Sigma0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sigma1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sigma2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewVectorL = new System.Windows.Forms.DataGridView();
            this.vectorL0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSigma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVectorL)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewP
            // 
            this.dataGridViewP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.P0,
            this.P1,
            this.P2});
            this.dataGridViewP.Location = new System.Drawing.Point(40, 36);
            this.dataGridViewP.Name = "dataGridViewP";
            this.dataGridViewP.Size = new System.Drawing.Size(344, 116);
            this.dataGridViewP.TabIndex = 0;
            this.dataGridViewP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewP_CellContentClick);
            // 
            // P0
            // 
            this.P0.HeaderText = "П0";
            this.P0.Name = "P0";
            this.P0.ReadOnly = true;
            // 
            // P1
            // 
            this.P1.HeaderText = "П1";
            this.P1.Name = "P1";
            this.P1.ReadOnly = true;
            // 
            // P2
            // 
            this.P2.HeaderText = "П2";
            this.P2.Name = "P2";
            this.P2.ReadOnly = true;
            // 
            // dataGridViewL
            // 
            this.dataGridViewL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.L0,
            this.L1,
            this.L2});
            this.dataGridViewL.Location = new System.Drawing.Point(40, 208);
            this.dataGridViewL.Name = "dataGridViewL";
            this.dataGridViewL.Size = new System.Drawing.Size(344, 114);
            this.dataGridViewL.TabIndex = 1;
            // 
            // L0
            // 
            this.L0.HeaderText = "L0";
            this.L0.Name = "L0";
            this.L0.ReadOnly = true;
            // 
            // L1
            // 
            this.L1.HeaderText = "L1";
            this.L1.Name = "L1";
            this.L1.ReadOnly = true;
            // 
            // L2
            // 
            this.L2.HeaderText = "L2";
            this.L2.Name = "L2";
            this.L2.ReadOnly = true;
            // 
            // dataGridViewSigma
            // 
            this.dataGridViewSigma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSigma.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sigma0,
            this.Sigma1,
            this.Sigma2});
            this.dataGridViewSigma.Location = new System.Drawing.Point(424, 36);
            this.dataGridViewSigma.Name = "dataGridViewSigma";
            this.dataGridViewSigma.Size = new System.Drawing.Size(344, 116);
            this.dataGridViewSigma.TabIndex = 2;
            // 
            // Sigma0
            // 
            this.Sigma0.HeaderText = "Sigma0";
            this.Sigma0.Name = "Sigma0";
            this.Sigma0.ReadOnly = true;
            // 
            // Sigma1
            // 
            this.Sigma1.HeaderText = "Sigma1";
            this.Sigma1.Name = "Sigma1";
            this.Sigma1.ReadOnly = true;
            // 
            // Sigma2
            // 
            this.Sigma2.HeaderText = "Sigma2";
            this.Sigma2.Name = "Sigma2";
            this.Sigma2.ReadOnly = true;
            // 
            // dataGridViewVectorL
            // 
            this.dataGridViewVectorL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVectorL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vectorL0});
            this.dataGridViewVectorL.Location = new System.Drawing.Point(424, 208);
            this.dataGridViewVectorL.Name = "dataGridViewVectorL";
            this.dataGridViewVectorL.Size = new System.Drawing.Size(143, 114);
            this.dataGridViewVectorL.TabIndex = 3;
            // 
            // vectorL0
            // 
            this.vectorL0.HeaderText = "vectorL0";
            this.vectorL0.Name = "vectorL0";
            this.vectorL0.ReadOnly = true;
            // 
            // FormOutputMatrixs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 381);
            this.Controls.Add(this.dataGridViewVectorL);
            this.Controls.Add(this.dataGridViewSigma);
            this.Controls.Add(this.dataGridViewL);
            this.Controls.Add(this.dataGridViewP);
            this.Name = "FormOutputMatrixs";
            this.Text = "FormOutputMatrixs";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSigma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVectorL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewP;
        private System.Windows.Forms.DataGridView dataGridViewL;
        private System.Windows.Forms.DataGridView dataGridViewSigma;
        private System.Windows.Forms.DataGridView dataGridViewVectorL;
        private System.Windows.Forms.DataGridViewTextBoxColumn P0;
        private System.Windows.Forms.DataGridViewTextBoxColumn P1;
        private System.Windows.Forms.DataGridViewTextBoxColumn P2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sigma0;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sigma1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sigma2;
        private System.Windows.Forms.DataGridViewTextBoxColumn L0;
        private System.Windows.Forms.DataGridViewTextBoxColumn L1;
        private System.Windows.Forms.DataGridViewTextBoxColumn L2;
        private System.Windows.Forms.DataGridViewTextBoxColumn vectorL0;
    }
}