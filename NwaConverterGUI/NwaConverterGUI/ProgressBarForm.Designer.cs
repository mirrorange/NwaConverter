namespace NwaConverterGUI
{
    partial class ProgressBarForm
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
            this.progressBar_ProgressRate = new System.Windows.Forms.ProgressBar();
            this.label_Status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar_ProgressRate
            // 
            this.progressBar_ProgressRate.Location = new System.Drawing.Point(12, 13);
            this.progressBar_ProgressRate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressBar_ProgressRate.Name = "progressBar_ProgressRate";
            this.progressBar_ProgressRate.Size = new System.Drawing.Size(476, 33);
            this.progressBar_ProgressRate.TabIndex = 0;
            this.progressBar_ProgressRate.MouseDown += new System.Windows.Forms.MouseEventHandler(this.progressBar_ProgressRate_MouseDown);
            // 
            // label_Status
            // 
            this.label_Status.Location = new System.Drawing.Point(12, 50);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(476, 21);
            this.label_Status.TabIndex = 1;
            this.label_Status.Text = "QWQ";
            this.label_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Status.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_Status_MouseDown);
            // 
            // ProgressBarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 80);
            this.Controls.Add(this.label_Status);
            this.Controls.Add(this.progressBar_ProgressRate);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ProgressBarForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProgressBarForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProgressBarForm_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar_ProgressRate;
        private System.Windows.Forms.Label label_Status;
    }
}