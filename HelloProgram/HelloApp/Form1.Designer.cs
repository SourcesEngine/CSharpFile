namespace HelloApp
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
            this.adodc1 = new Microsoft.VisualBasic.Compatibility.VB6.ADODC();
            this.SuspendLayout();
            // 
            // adodc1
            // 
            this.adodc1.BackColor = System.Drawing.SystemColors.Control;
            this.adodc1.CommandTimeout = 0;
            this.adodc1.CommandType = ADODB.CommandTypeEnum.adCmdUnknown;
            this.adodc1.ConnectionString = null;
            this.adodc1.CursorType = ADODB.CursorTypeEnum.adOpenStatic;
            this.adodc1.Location = new System.Drawing.Point(278, 27);
            this.adodc1.LockType = ADODB.LockTypeEnum.adLockOptimistic;
            this.adodc1.Name = "adodc1";
            this.adodc1.Size = new System.Drawing.Size(130, 26);
            this.adodc1.TabIndex = 0;
            this.adodc1.Text = "adodc1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.adodc1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.VisualBasic.Compatibility.VB6.ADODC adodc1;
    }
}

