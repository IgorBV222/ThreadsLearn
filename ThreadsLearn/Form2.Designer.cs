namespace ThreadsLearn
{
    partial class Form2
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
            this.pgb = new System.Windows.Forms.ProgressBar();
            this.lblPrc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pgb
            // 
            this.pgb.Location = new System.Drawing.Point(3, 38);
            this.pgb.Name = "pgb";
            this.pgb.Size = new System.Drawing.Size(347, 23);
            this.pgb.Step = 1;
            this.pgb.TabIndex = 0;
            // 
            // lblPrc
            // 
            this.lblPrc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)), true);
            this.lblPrc.Location = new System.Drawing.Point(135, 9);
            this.lblPrc.Name = "lblPrc";
            this.lblPrc.Size = new System.Drawing.Size(80, 18);
            this.lblPrc.TabIndex = 1;
            this.lblPrc.Text = "0";
            this.lblPrc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 83);
            this.Controls.Add(this.lblPrc);
            this.Controls.Add(this.pgb);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar pgb;
        private System.Windows.Forms.Label lblPrc;
    }
}