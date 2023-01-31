using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CountingExam.Models;
using CountingExam.Servicies;
using System.Speech.Synthesis;

namespace CountingExam.Controls
{
    public partial class CountingControl : UserControl
    {
        public delegate void Reset();

        public event Reset OnReset;
        private List<CountingAction> _actions;
        private double _result = 0;
        private readonly SpeechSynthesizer _speechSynthesizer;

        public CountingControl()
        {
            InitializeComponent();
            _speechSynthesizer = new SpeechSynthesizer();
            _speechSynthesizer.SetOutputToDefaultAudioDevice();
        }

        private bool _shown;
        private bool _speech;

        public void Start(List<CountingAction> actions, Settings settings)
        {
            _actions = actions;
            _speech = settings.Speech;
            _btnShow.Hide();
            _actionIndex = 0;
            _result = 0;
            _timer.Interval = settings.Interval * 1000;
            _timer.Start();
            _timer_Tick(null, null);
            _btnShow.Text = "Show";
            _shown = false;
            
        }

        private int _actionIndex = 0;

        private void _timer_Tick(object sender, EventArgs e)
        {
            if (_actionIndex + 1 > _actions.Count)
            {
                _timer.Stop();
                _countingLabel.Text = "---";
                _btnShow.Show();
                return;
            }

            _countingLabel.Text = _actions[_actionIndex].ToString();
            if (_speech)
                _speechSynthesizer.SpeakAsync(_actions[_actionIndex].ToSpeech());
            _result = MathService.Operate(_actions[_actionIndex], _result);
            _actionIndex++;
            _lblOrder.Text = _actionIndex + ".";
        }


        private void _btnShow_Click(object sender, EventArgs e)
        {
            if (_shown)
            {
                OnReset?.Invoke();
                return;
            }

            _countingLabel.Text = _result.ToString();
            if (_speech)
                _speechSynthesizer.SpeakAsync("Result is " + _result);
            _btnShow.Text = "Reset";
            _shown = true;
        }
    }
}