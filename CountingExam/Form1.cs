using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CountingExam.Models;

namespace CountingExam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _setupControl.OnCountingStart += SetupControlOnOnCountingStart;
            _countingControl.OnReset += CountingControlOnOnReset;
        }

        private void CountingControlOnOnReset()
        {
            _countingControl.Hide();
            _setupControl.Show();
        }

        private void SetupControlOnOnCountingStart(List<CountingAction> actions)
        {
            _setupControl.Hide();
            _countingControl.Start(actions);
            _countingControl.Show();
        }
    }
}