using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvoCity_Radio_Player
{
    public partial class Main : MetroFramework.Forms.MetroForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            metroProgressSpinner1.Visible = false;
        }

        private void metroToggle1_CheckedChanged(object sender, EventArgs e)
        {
            if (metroToggle1.Checked == true)
            {
                axWindowsMediaPlayer1.URL = @"http://51.254.200.243:8000/stream";
            }
            else
            {
                axWindowsMediaPlayer1.Ctlcontrols.stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsBuffering)
            {
                statusLabel.Text = "Status: Buffering";
                metroProgressSpinner1.Visible = true;
            }
            else if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                statusLabel.Text = "Status: Playing";
                metroProgressSpinner1.Visible = false;
            }
            else if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                statusLabel.Text = "Status: Stopped";
                metroProgressSpinner1.Visible = false;
            }
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
    }
}
