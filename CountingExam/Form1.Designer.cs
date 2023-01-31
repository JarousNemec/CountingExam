namespace CountingExam
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._countingControl = new CountingExam.Controls.CountingControl();
            this._setupControl = new CountingExam.Controls.SettingControl();
            this.SuspendLayout();
            // 
            // _countingControl
            // 
            this._countingControl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._countingControl.Location = new System.Drawing.Point(12, 12);
            this._countingControl.Name = "_countingControl";
            this._countingControl.Size = new System.Drawing.Size(472, 512);
            this._countingControl.TabIndex = 0;
            this._countingControl.Visible = false;
            // 
            // _setupControl
            // 
            this._setupControl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._setupControl.Location = new System.Drawing.Point(110, 12);
            this._setupControl.Name = "_setupControl";
            this._setupControl.Size = new System.Drawing.Size(266, 425);
            this._setupControl.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 613);
            this.Controls.Add(this._setupControl);
            this.Controls.Add(this._countingControl);
            this.Name = "Form1";
            this.Text = "Let\'s count";
            this.ResumeLayout(false);
        }

        private CountingExam.Controls.CountingControl _countingControl;
        private CountingExam.Controls.SettingControl _setupControl;

        #endregion
    }
}