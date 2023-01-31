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
            this._numTo = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._numInterval = new System.Windows.Forms.NumericUpDown();
            this._comboDifficulties = new System.Windows.Forms.ComboBox();
            this._chckSpeech = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this._numNumbersCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // _btnStart
            // 
            this._btnStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnStart.Location = new System.Drawing.Point(3, 0);
            this._btnStart.Name = "_btnStart";
            this._btnStart.Size = new System.Drawing.Size(260, 87);
            this._btnStart.TabIndex = 0;
            this._btnStart.Text = "Start";
            this._btnStart.UseVisualStyleBackColor = true;
            this._btnStart.Click += new System.EventHandler(this._btnStart_Click);
            // 
            // _numNumbersCount
            // 
            this._numNumbersCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._numNumbersCount.Location = new System.Drawing.Point(3, 134);
            this._numNumbersCount.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            this._numNumbersCount.Name = "_numNumbersCount";
            this._numNumbersCount.Size = new System.Drawing.Size(260, 28);
            this._numNumbersCount.TabIndex = 1;
            this._numNumbersCount.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numbers count:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _numTo
            // 
            this._numTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._numTo.Location = new System.Drawing.Point(3, 199);
            this._numTo.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            this._numTo.Minimum = new decimal(new int[] { 20, 0, 0, 0 });
            this._numTo.Name = "_numTo";
            this._numTo.Size = new System.Drawing.Size(260, 28);
            this._numTo.TabIndex = 4;
            this._numTo.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Max Range:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Time to next number (sec.):";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(260, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "Difficulty:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _numInterval
            // 
            this._numInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._numInterval.Location = new System.Drawing.Point(0, 264);
            this._numInterval.Maximum = new decimal(new int[] { 150, 0, 0, 0 });
            this._numInterval.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this._numInterval.Name = "_numInterval";
            this._numInterval.Size = new System.Drawing.Size(263, 28);
            this._numInterval.TabIndex = 8;
            this._numInterval.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // _comboDifficulties
            // 
            this._comboDifficulties.AutoCompleteCustomSource.AddRange(new string[] { "Kindergarten", "PrimarySchool", "HighSchool", "University" });
            this._comboDifficulties.DisplayMember = "Primary_school";
            this._comboDifficulties.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboDifficulties.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._comboDifficulties.FormattingEnabled = true;
            this._comboDifficulties.Items.AddRange(new object[] { "Kindergarten", "PrimarySchool", "HighSchool", "University" });
            this._comboDifficulties.Location = new System.Drawing.Point(0, 329);
            this._comboDifficulties.Name = "_comboDifficulties";
            this._comboDifficulties.Size = new System.Drawing.Size(263, 30);
            this._comboDifficulties.TabIndex = 9;
            // 
            // _chckSpeech
            // 
            this._chckSpeech.Checked = true;
            this._chckSpeech.CheckState = System.Windows.Forms.CheckState.Checked;
            this._chckSpeech.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._chckSpeech.Location = new System.Drawing.Point(58, 365);
            this._chckSpeech.Name = "_chckSpeech";
            this._chckSpeech.Size = new System.Drawing.Size(140, 45);
            this._chckSpeech.TabIndex = 10;
            this._chckSpeech.Text = "Speech";
            this._chckSpeech.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._chckSpeech.UseVisualStyleBackColor = true;
            // 
            // SettingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._chckSpeech);
            this.Controls.Add(this._comboDifficulties);
            this.Controls.Add(this._numInterval);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._numTo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._numNumbersCount);
            this.Controls.Add(this._btnStart);
            this.Name = "SettingControl";
            this.Size = new System.Drawing.Size(266, 425);
            ((System.ComponentModel.ISupportInitialize)(this._numNumbersCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numInterval)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.CheckBox _chckSpeech;

        private System.Windows.Forms.ComboBox _comboDifficulties;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown _numInterval;

        private System.Windows.Forms.NumericUpDown _numTo;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.NumericUpDown _numNumbersCount;

        private System.Windows.Forms.Button _btnStart;

        #endregion
    }
}