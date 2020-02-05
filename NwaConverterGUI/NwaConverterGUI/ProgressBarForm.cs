using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NwaConverterGUI
{
    public partial class ProgressBarForm : Form
    {
        int totalProcess;
        int process = 0;

        [DllImport("user32.dll")]//拖动无窗体的控件
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;
        public ProgressBarForm(int totalProcess)
        {
            this.totalProcess = totalProcess;
            InitializeComponent();
        }

        public void addProcess(int number)
        {
            process += number;
            double d = (double)process / (double)totalProcess * 100;
            progressBar_ProgressRate.Value = Convert.ToInt32(Math.Round(d));
            
        }
        public void setStatus(string status)
        {
            label_Status.Text = status;
        }

        private void ProgressBarForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        private void progressBar_ProgressRate_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        private void label_Status_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }
    }
}
