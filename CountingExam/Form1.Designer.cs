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
            this._setupControl = new CountingExam.Controls.SettingControl();
            this._countingControl = new CountingExam.Controls.CountingControl();
            this.SuspendLayout();
            // 
            // _setupControl
            // 
            this._setupControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this._setupControl.Location = new System.Drawing.Point(2, 0);
            this._setupControl.Name = "_setupControl";
            this._setupControl.Size = new System.Drawing.Size(590, 619);
            this._setupControl.TabIndex = 0;
            // 
            // _countingControl
            // 
            this._countingControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this._countingControl.Location = new System.Drawing.Point(2, 0);
            this._countingControl.Name = "_countingControl";
            this._countingControl.Size = new System.Drawing.Size(590, 586);
            this._countingControl.TabIndex = 1;
            this._countingControl.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 733);
            this.Controls.Add(this._countingControl);
            this.Controls.Add(this._setupControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        private CountingExam.Controls.CountingControl _countingControl;

        private CountingExam.Controls.SettingControl _setupControl;

        #endregion
    }
}