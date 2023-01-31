using System.ComponentModel;

namespace CountingExam.Controls
{
    partial class SettingControl
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
            this._btnStart = new System.Windows.Forms.Button();
            this._numNumbersCount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this._numFrom = new System.Windows.Forms.NumericUpDown();
            this._numTo = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._numNumbersCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numTo)).BeginInit();
            this.SuspendLayout();
            // 
            // _btnStart
            // 
            this._btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnStart.Location = new System.Drawing.Point(207, 85);
            this._btnStart.Name = "_btnStart";
            this._btnStart.Size = new System.Drawing.Size(176, 87);
            this._btnStart.TabIndex = 0;
            this._btnStart.Text = "Start";
            this._btnStart.UseVisualStyleBackColor = true;
            this._btnStart.Click += new System.EventHandler(this._btnStart_Click);
            // 
            // _numNumbersCount
            // 
            this._numNumbersCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._numNumbersCount.Location = new System.Drawing.Point(163, 234);
            this._numNumbersCount.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            this._numNumbersCount.Name = "_numNumbersCount";
            this._numNumbersCount.Size = new System.Drawing.Size(260, 34);
            this._numNumbersCount.TabIndex = 1;
            this._numNumbersCount.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 43);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numbers count:";
            // 
            // _numFrom
            // 
            this._numFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._numFrom.Location = new System.Drawing.Point(163, 327);
            this._numFrom.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            this._numFrom.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this._numFrom.Name = "_numFrom";
            this._numFrom.Size = new System.Drawing.Size(120, 34);
            this._numFrom.TabIndex = 3;
            this._numFrom.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // _numTo
            // 
            this._numTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._numTo.Location = new System.Drawing.Point(303, 327);
            this._numTo.Minimum = new decimal(new int[] { 20, 0, 0, 0 });
            this._numTo.Name = "_numTo";
            this._numTo.Size = new System.Drawing.Size(120, 34);
            this._numTo.TabIndex = 4;
            this._numTo.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(163, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 43);
            this.label2.TabIndex = 5;
            this.label2.Text = "Range:";
            // 
            // SettingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this._numTo);
            this.Controls.Add(this._numFrom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._numNumbersCount);
            this.Controls.Add(this._btnStart);
            this.Name = "SettingControl";
            this.Size = new System.Drawing.Size(575, 557);
            ((System.ComponentModel.ISupportInitialize)(this._numNumbersCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numTo)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.NumericUpDown _numFrom;
        private System.Windows.Forms.NumericUpDown _numTo;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.NumericUpDown _numNumbersCount;

        private System.Windows.Forms.Button _btnStart;

        #endregion
    }
}