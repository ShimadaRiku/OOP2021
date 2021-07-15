using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopWatch {
    public partial class Form1 : Form {

        Stopwatch sw = new System.Diagnostics.Stopwatch();
        
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            lbTimerDisp.Text = sw.Elapsed.ToString(@"hh\:mm\:ss\.ff");
            
        }

        private void Start_Click(object sender, EventArgs e) {
            
            sw.Start();
            tmDisp.Interval = 1;
            tmDisp.Tick += TmDisp_Tick;
            tmDisp.Start();
        }

        private void TmDisp_Tick(object sender, EventArgs e) {
            lbTimerDisp.Text = sw.Elapsed.ToString(@"hh\:mm\:ss\.ff");
        }

        private void Stop_Click(object sender, EventArgs e) {

            sw.Stop();
            tmDisp.Stop();
        }

        private void Reset_Click(object sender, EventArgs e) {
            sw.Reset();
            lbLapDisp.Items.Clear();

        }

        private void Rap_Click(object sender, EventArgs e) {
            lbLapDisp.Items.Add(sw.Elapsed.ToString(@"hh\:mm\:ss\.ff"));
        }
    }
}
