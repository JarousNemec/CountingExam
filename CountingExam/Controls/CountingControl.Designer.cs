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
            this._lblOrder = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _countingLabel
            // 
            this._countingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._countingLabel.Location = new System.Drawing.Point(46, 85);
            this._countingLabel.Name = "_countingLabel";
            this._countingLabel.Size = new System.Drawing.Size(378, 108);
            this._countingLabel.TabIndex = 0;
            this._countingLabel.Text = "---";
            this._countingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _btnShow
            // 
            this._btnShow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnShow.Location = new System.Drawing.Point(46, 301);
            this._btnShow.Name = "_btnShow";
            this._btnShow.Size = new System.Drawing.Size(378, 85);
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
            // _lblOrder
            // 
            this._lblOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblOrder.Location = new System.Drawing.Point(3, 0);
            this._lblOrder.Name = "_lblOrder";
            this._lblOrder.Size = new System.Drawing.Size(100, 33);
            this._lblOrder.TabIndex = 2;
            this._lblOrder.Text = "-";
            // 
            // CountingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._lblOrder);
            this.Controls.Add(this._btnShow);
            this.Controls.Add(this._countingLabel);
            this.Name = "CountingControl";
            this.Size = new System.Drawing.Size(476, 512);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label _lblOrder;

        private System.Windows.Forms.Timer _timer;

        private System.Windows.Forms.Button _btnShow;

        private System.Windows.Forms.Label _countingLabel;

        #endregion
    }
}