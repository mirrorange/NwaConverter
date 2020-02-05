namespace NwaConverterGUI
{
    partial class MianForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.TaskListBox = new System.Windows.Forms.ListBox();
            this.button_Start = new System.Windows.Forms.Button();
            this.label_OutputPath = new System.Windows.Forms.Label();
            this.button_SelectFolder = new System.Windows.Forms.Button();
            this.textBox_OutputPath = new System.Windows.Forms.TextBox();
            this.comboBox_OutputFormat = new System.Windows.Forms.ComboBox();
            this.label_OutputFormat = new System.Windows.Forms.Label();
            this.label_OutputBitRate = new System.Windows.Forms.Label();
            this.comboBox_OutputBitRate = new System.Windows.Forms.ComboBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // TaskListBox
            // 
            this.TaskListBox.AllowDrop = true;
            this.TaskListBox.FormattingEnabled = true;
            this.TaskListBox.ItemHeight = 17;
            this.TaskListBox.Location = new System.Drawing.Point(13, 13);
            this.TaskListBox.Name = "TaskListBox";
            this.TaskListBox.Size = new System.Drawing.Size(459, 242);
            this.TaskListBox.TabIndex = 0;
            this.TaskListBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.TaskListBox_DragDrop);
            this.TaskListBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.TaskListBox_DragEnter);
            this.TaskListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TaskListBox_KeyDown);
            // 
            // button_Start
            // 
            this.button_Start.Location = new System.Drawing.Point(396, 291);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(75, 23);
            this.button_Start.TabIndex = 1;
            this.button_Start.Text = "开始转换";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // label_OutputPath
            // 
            this.label_OutputPath.AutoSize = true;
            this.label_OutputPath.Location = new System.Drawing.Point(13, 265);
            this.label_OutputPath.Name = "label_OutputPath";
            this.label_OutputPath.Size = new System.Drawing.Size(68, 17);
            this.label_OutputPath.TabIndex = 2;
            this.label_OutputPath.Text = "输出目录：";
            // 
            // button_SelectFolder
            // 
            this.button_SelectFolder.Location = new System.Drawing.Point(396, 262);
            this.button_SelectFolder.Name = "button_SelectFolder";
            this.button_SelectFolder.Size = new System.Drawing.Size(75, 23);
            this.button_SelectFolder.TabIndex = 3;
            this.button_SelectFolder.Text = "浏览";
            this.button_SelectFolder.UseVisualStyleBackColor = true;
            this.button_SelectFolder.Click += new System.EventHandler(this.button_SelectFolder_Click);
            // 
            // textBox_OutputPath
            // 
            this.textBox_OutputPath.Location = new System.Drawing.Point(87, 262);
            this.textBox_OutputPath.Name = "textBox_OutputPath";
            this.textBox_OutputPath.Size = new System.Drawing.Size(303, 23);
            this.textBox_OutputPath.TabIndex = 4;
            // 
            // comboBox_OutputFormat
            // 
            this.comboBox_OutputFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_OutputFormat.FormattingEnabled = true;
            this.comboBox_OutputFormat.Items.AddRange(new object[] {
            "默认",
            ".wav",
            ".flac",
            ".mp3",
            ".ogg",
            ".wma",
            ".m4a"});
            this.comboBox_OutputFormat.Location = new System.Drawing.Point(87, 291);
            this.comboBox_OutputFormat.Name = "comboBox_OutputFormat";
            this.comboBox_OutputFormat.Size = new System.Drawing.Size(110, 25);
            this.comboBox_OutputFormat.TabIndex = 5;
            this.comboBox_OutputFormat.SelectedIndexChanged += new System.EventHandler(this.comboBox_OutputFormat_SelectedIndexChanged);
            // 
            // label_OutputFormat
            // 
            this.label_OutputFormat.AutoSize = true;
            this.label_OutputFormat.Location = new System.Drawing.Point(13, 295);
            this.label_OutputFormat.Name = "label_OutputFormat";
            this.label_OutputFormat.Size = new System.Drawing.Size(68, 17);
            this.label_OutputFormat.TabIndex = 6;
            this.label_OutputFormat.Text = "输出格式：";
            // 
            // label_OutputBitRate
            // 
            this.label_OutputBitRate.AutoSize = true;
            this.label_OutputBitRate.Location = new System.Drawing.Point(203, 295);
            this.label_OutputBitRate.Name = "label_OutputBitRate";
            this.label_OutputBitRate.Size = new System.Drawing.Size(68, 17);
            this.label_OutputBitRate.TabIndex = 8;
            this.label_OutputBitRate.Text = "输出码率：";
            // 
            // comboBox_OutputBitRate
            // 
            this.comboBox_OutputBitRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_OutputBitRate.FormattingEnabled = true;
            this.comboBox_OutputBitRate.Items.AddRange(new object[] {
            "默认",
            "320k",
            "256k",
            "192k",
            "128k"});
            this.comboBox_OutputBitRate.Location = new System.Drawing.Point(277, 291);
            this.comboBox_OutputBitRate.Name = "comboBox_OutputBitRate";
            this.comboBox_OutputBitRate.Size = new System.Drawing.Size(110, 25);
            this.comboBox_OutputBitRate.TabIndex = 7;
            // 
            // MianForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 331);
            this.Controls.Add(this.label_OutputBitRate);
            this.Controls.Add(this.comboBox_OutputBitRate);
            this.Controls.Add(this.label_OutputFormat);
            this.Controls.Add(this.comboBox_OutputFormat);
            this.Controls.Add(this.textBox_OutputPath);
            this.Controls.Add(this.button_SelectFolder);
            this.Controls.Add(this.label_OutputPath);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.TaskListBox);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MianForm";
            this.Text = "NwaConverter";
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox TaskListBox;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Label label_OutputPath;
        private System.Windows.Forms.Button button_SelectFolder;
        private System.Windows.Forms.TextBox textBox_OutputPath;
        private System.Windows.Forms.ComboBox comboBox_OutputFormat;
        private System.Windows.Forms.Label label_OutputFormat;
        private System.Windows.Forms.Label label_OutputBitRate;
        private System.Windows.Forms.ComboBox comboBox_OutputBitRate;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}

