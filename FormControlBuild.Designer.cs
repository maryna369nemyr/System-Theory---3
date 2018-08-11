namespace Draw
{
    partial class FormControlBuild
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
            this.zedGraphControlNewForm = new ZedGraph.ZedGraphControl();
            this.SuspendLayout();
            // 
            // zedGraphControlNewForm
            // 
            this.zedGraphControlNewForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphControlNewForm.IsShowPointValues = false;
            this.zedGraphControlNewForm.Location = new System.Drawing.Point(0, 0);
            this.zedGraphControlNewForm.Name = "zedGraphControlNewForm";
            this.zedGraphControlNewForm.PointValueFormat = "G";
            this.zedGraphControlNewForm.Size = new System.Drawing.Size(695, 352);
            this.zedGraphControlNewForm.TabIndex = 1;
            // 
            // FormControlBuild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 352);
            this.Controls.Add(this.zedGraphControlNewForm);
            this.Name = "FormControlBuild";
            this.Text = "FormControlBuild";
            this.ResumeLayout(false);

        }

        #endregion

        private ZedGraph.ZedGraphControl zedGraphControlNewForm;
    }
}