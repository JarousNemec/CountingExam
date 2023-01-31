using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CountingExam.Models;
using CountingExam.Servicies;

namespace CountingExam.Controls
{
    public partial class SettingControl : UserControl
    {
        public delegate void CountingStart(List<CountingAction> actions);

        public event CountingStart OnCountingStart;
        public SettingControl()
        {
            InitializeComponent();
        }

        private void _btnStart_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            List<CountingAction> actions = new List<CountingAction>();
            for (int i = 0; i < _numNumbersCount.Value; i++)
            {
                Operations operation = (Operations)r.Next(1, 5);
                actions.Add(new CountingAction(MathService.GenerateNumberForAction(operation, r, (int)_numTo.Value),operation));
            }

            // if (actions[0].Operation == Operations.Divide)
            // {
            //     Operations operation = (Operations)r.Next(1, 3);
            //     actions[0] = new CountingAction(MathService.GenerateNumberForAction(operation, r, (int)_numTo.Value),operation);
            // }
            OnCountingStart?.Invoke(actions);
        }
    }
}