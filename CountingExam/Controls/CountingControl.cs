using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CountingExam.Models;
using CountingExam.Servicies;

namespace CountingExam.Controls
{
    public partial class CountingControl : UserControl
    {
        public delegate void Reset();

        public event Reset OnReset;
        private List<CountingAction> _actions;
        private double _result = 0;
        public CountingControl()
        {
            InitializeComponent();
            
        }
        private bool _shown = false;
        public void Start(List<CountingAction> actions)
        {
            _actions = actions;
            _btnShow.Hide();
            _actionIndex = 0;
            _result = 0;
            _timer.Start();
            _timer_Tick(null, null);
            _shown = false;
        }
        private int _actionIndex = 0;
        private void _timer_Tick(object sender, EventArgs e)
        {
            if (_actionIndex+1 > _actions.Count)
            {
                _timer.Stop();
                _countingLabel.Text = "---";
                _btnShow.Show();
                return;
            }
            _countingLabel.Text = _actions[_actionIndex].ToString();
            _result = MathService.Operate(_actions[_actionIndex], _result);
            _actionIndex++;
        }

        
        private void _btnShow_Click(object sender, EventArgs e)
        {
            if (_shown)
            {
                OnReset?.Invoke();
            }
            _countingLabel.Text = _result.ToString();
            _btnShow.Text = "Reset";
            _shown = true;
        }
    }
}