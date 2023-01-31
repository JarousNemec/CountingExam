using System.ComponentModel;

namespace CountingExam.Controls
{
    partial class CountingControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this._countingLabel = new System.Windows.Forms.Label();
            this._btnShow = new System.Windows.Forms.Button();
            this._timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // _countingLabel
            // 
            this._countingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._countingLabel.Location = new System.Drawing.Point(24, 10);
            this._countingLabel.Name = "_countingLabel";
            this._countingLabel.Size = new System.Drawing.Size(534, 273);
            this._countingLabel.TabIndex = 0;
            this._countingLabel.Text = "---";
            this._countingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _btnShow
            // 
            this._btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnShow.Location = new System.Drawing.Point(48, 297);
            this._btnShow.Name = "_btnShow";
            this._btnShow.Size = new System.Drawing.Size(486, 113);
            this._btnShow.TabIndex = 1;
            this._btnShow.Text = "Show";
            this._btnShow.UseVisualStyleBackColor = true;
            this._btnShow.Click += new System.EventHandler(this._btnShow_Click);
            // 
            // _timer
            // 
            this._timer.Interval = 3000;
            this._timer.Tick += new System.EventHandler(this._timer_Tick);
            // 
            // CountingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._btnShow);
            this.Controls.Add(this._countingLabel);
            this.Name = "CountingControl";
            this.Size = new System.Drawing.Size(574, 586);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Timer _timer;

        private System.Windows.Forms.Button _btnShow;

        private System.Windows.Forms.Label _countingLabel;

        #endregion
    }
}