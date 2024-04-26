﻿using System;
using System.Diagnostics;
using TXBeditor.Properties;

namespace TXBeditor
{
    public partial class ImglibAbout : Form
    {
        public ImglibAbout()
        {
            InitializeComponent();
            this.license.Lines = System.Text.RegularExpressions.Regex.Split(Properties.Resources.GPL2, "\r\n|\r|\n");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo {
                FileName = rainbowlink.Text,
                UseShellExecute = true
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
