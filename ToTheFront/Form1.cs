using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace ToTheFront {
    public partial class Form1 : Form {

        private const int HWND_TOPMOST = -1;
        private const int HWND_NOTOPMOST = -2;

        public struct POINTAPI {
            public int x;
            public int y;
        }

        [DllImport("user32.dll")]
        private static extern bool SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int X, int Y, int cx, int cy, int uFlags);
        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(Keys vKey);
        [DllImport("user32.dll")]
        private static extern IntPtr WindowFromPoint(POINTAPI p);
        [DllImport("user32.dll")]
        private static extern bool GetCursorPos(out POINTAPI lpPoint);

        public Form1() {
            InitializeComponent();
        }

        private void chkOnTop_CheckedChanged(object sender, EventArgs e) {
            if (chkOnTop.Checked) {
                SetWindowPos(this.Handle, HWND_TOPMOST, 0, 0, 0, 0, 3);
            } else {
                SetWindowPos(this.Handle, HWND_NOTOPMOST, 0, 0, 0, 0, 3);
            }
        }

        private void btnToFront_Click(object sender, EventArgs e) {
            IntPtr handle = (IntPtr)Int32.Parse(txtHandle.Text);
            SetWindowPos(handle, HWND_TOPMOST, 0, 0, 0, 0, 3);
        }

        private void btnToNormal_Click(object sender, EventArgs e) {
            IntPtr handle = (IntPtr) Int32.Parse(txtHandle.Text);
            SetWindowPos(handle, HWND_NOTOPMOST, 0, 0, 0, 0, 3);
        }

        private void tmrGetHandle_Tick(object sender, EventArgs e) {
            POINTAPI maus = new POINTAPI();
            if ((GetAsyncKeyState(Keys.ControlKey) & 0x8000) == 0x8000) {
                GetCursorPos(out maus);
                txtHandle.Text = WindowFromPoint(maus).ToString();
            }
        }
    }
}
