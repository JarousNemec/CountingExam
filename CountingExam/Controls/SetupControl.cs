using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CountingExam.Models;
using CountingExam.Servicies;

namespace CountingExam.Controls
{
    public partial class SettingControl : UserControl
    {
        public delegate void CountingStart(List<CountingAction> actions, Settings settings);

        private MathService _service;
        public event CountingStart OnCountingStart;
        public SettingControl()
        {
            InitializeComponent();
            _service = new MathService();
            _comboDifficulties.SelectedIndex = 3;
        }

        private void _btnStart_Click(object sender, EventArgs e)
        {
            _ = Enum.TryParse(_comboDifficulties.Items[_comboDifficulties.SelectedIndex].ToString(),
                out Difficulties diff);
            var actions = _service.GenerateActions(diff, (int)_numTo.Value, (int)_numNumbersCount.Value);

            OnCountingStart?.Invoke(actions, new Settings(diff, (int)_numInterval.Value, _chckSpeech.Checked));
        }
    }
}