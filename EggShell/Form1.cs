﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EggShell
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        private static extern int FindWindow(string className, string windowText);
        [DllImport("user32.dll")]
        private static extern int ShowWindow(int hwnd, int command);
        private const int SW_HIDE = 0;
        private const int SW_SHOW = 1;
        public Form1()
        {
            InitializeComponent();
        }
        public void Init(object sender, EventArgs e)
        {
            int hwnd = FindWindow("Shell_TrayWnd", "");
            ShowWindow(hwnd, SW_HIDE);
            panel1.Size = this.Size;
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
            this.Location = new Point(this.Location.X, Screen.PrimaryScreen.Bounds.Height - this.Size.Height);
        }
        public void CloseShell(object sender, EventArgs e)
        {
            int hwnd = FindWindow("Shell_TrayWnd", "");
            ShowWindow(hwnd, SW_SHOW);
            Application.Exit();
        }
    }
}
