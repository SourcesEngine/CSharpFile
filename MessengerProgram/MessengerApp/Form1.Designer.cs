namespace MessengerApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axTV1 = new AxCTVLib.AxTV();
            ((System.ComponentModel.ISupportInitialize)(this.axTV1)).BeginInit();
            this.SuspendLayout();
            // 
            // axTV1
            // 
            this.axTV1.Enabled = true;
            this.axTV1.Location = new System.Drawing.Point(118, 54);
            this.axTV1.Name = "axTV1";
            this.axTV1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axTV1.OcxState")));
            this.axTV1.Size = new System.Drawing.Size(100, 50);
            this.axTV1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 450);
            this.Controls.Add(this.axTV1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axTV1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxCTVLib.AxTV axTV1;
    }
}

