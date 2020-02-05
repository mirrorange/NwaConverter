using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Threading;

namespace NwaConverterGUI
{
    public partial class MianForm : System.Windows.Forms.Form
    {
        Thread thread;
        public MianForm()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private void button_SelectFolder_Click(object sender, System.EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBox_OutputPath.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void Form_Load(object sender, System.EventArgs e)
        {
            comboBox_OutputFormat.SelectedIndex = 0;
            comboBox_OutputBitRate.SelectedIndex = 0;
            comboBox_OutputBitRate.Enabled = false;
            if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory + "ffmpeg.exe"))
            {
                comboBox_OutputFormat.Enabled = false;
            }

        }
        private void comboBox_OutputFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_OutputFormat.SelectedIndex > 2)
            {
                comboBox_OutputBitRate.Enabled = true;
            }
            else
            {
                comboBox_OutputBitRate.Enabled = false;
                comboBox_OutputBitRate.SelectedIndex = 0;
            }
        }
        private void button_Start_Click(object sender, EventArgs e)
        {
            if(TaskListBox.Items.Count != 0)
            {
                thread = new Thread(start);
                thread.Start();
            }
        }

        private void start()
        {
            this.Visible = false;
            ProgressBarForm progressBar = new ProgressBarForm(3 * TaskListBox.Items.Count);
            new Thread((ThreadStart)delegate
            {
                Application.Run(progressBar);
            }).Start();
            foreach (string file in TaskListBox.Items)
            {
                progressBar.setStatus("正在拼命解码文件...");
                nwaToWav(file, textBox_OutputPath.Text);
                progressBar.addProcess(1);
                string ext = "";
                switch (Path.GetExtension(file))
                {
                    case ".nwa":
                        ext = ".wav";
                        break;
                    case ".nwk":
                        ext = ".wav";
                        break;
                    case ".ovk":
                        ext = ".ogg";
                        break;
                }
                if(comboBox_OutputFormat.SelectedItem.ToString() != ext && comboBox_OutputFormat.SelectedIndex != 0)
                {
                    progressBar.setStatus("正在使用FFmpeg转换格式...");
                    string fileName = textBox_OutputPath.Text + @"\" + Path.GetFileNameWithoutExtension(file) + ext;
                    bool ignoreBitRate = false;
                    string bitRate = comboBox_OutputBitRate.SelectedItem.ToString();
                    if (comboBox_OutputFormat.SelectedIndex <= 2)
                    {
                        ignoreBitRate = true;
                    }
                    else if(comboBox_OutputBitRate.SelectedIndex == 0)
                    {
                        bitRate = "320k";
                    }
                    ffmpeg(fileName, textBox_OutputPath.Text, comboBox_OutputFormat.SelectedItem.ToString(),bitRate , ignoreBitRate);
                    File.Delete(fileName);
                }
                progressBar.addProcess(2);
            }
            this.Visible = true;
            TaskListBox.Items.Clear();
            progressBar.Close();
        }
        private void nwaToWav(string inputfile,string outputpath)
        {
            Process process = new Process();
            process.StartInfo.FileName = AppDomain.CurrentDomain.BaseDirectory + "nwatowav.exe";
            process.StartInfo.Arguments = "-inputfile=\"" + inputfile + "\" -outputpath=\"" + outputpath + "\\\\\"";
            process.Start();
            process.WaitForExit();
        }

        private void ffmpeg(string inputfile,string outputpath,string format,string bitRate,bool ignoreBitRate)
        {
            string outputfile = outputpath + @"\" + Path.GetFileNameWithoutExtension(inputfile) + format;
            Process process = new Process();
            process.StartInfo.FileName = AppDomain.CurrentDomain.BaseDirectory + "ffmpeg.exe";
            if(ignoreBitRate)
            {
                process.StartInfo.Arguments = "-i " + inputfile + " " + outputfile;
            }
            else
            {
                process.StartInfo.Arguments = "-i " + inputfile + " -b:a " + bitRate + " " + outputfile;
            }
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            process.WaitForExit();
        }

        private void TaskListBox_DragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void TaskListBox_DragDrop(object sender, DragEventArgs e)
        {
            String[] files = e.Data.GetData(DataFormats.FileDrop, false) as String[];
            foreach (string file in files)
            {
                string ext = Path.GetExtension(file);
                if (ext == ".nwa" || ext == ".nwk" || ext == ".ovk")
                {
                    TaskListBox.Items.Add(file);
                }
            }
        }

        private void TaskListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                
                if (TaskListBox.Items.Count > 0)
                {
                    TaskListBox.Items.RemoveAt(TaskListBox.SelectedIndex);
                    if(TaskListBox.Items.Count > 0)
                    {
                        TaskListBox.SelectedIndex = 0;
                    }
                }
            }
        }
    }
}