namespace MyJobApplication
{
    partial class DisplayCV
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
            this.officeViewer1 = new Spire.OfficeViewer.Forms.OfficeViewer();
            this.SuspendLayout();
            // 
            // officeViewer1
            // 
            this.officeViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.officeViewer1.IsToolBarVisible = true;
            this.officeViewer1.Location = new System.Drawing.Point(0, 0);
            this.officeViewer1.Name = "officeViewer1";
            this.officeViewer1.Size = new System.Drawing.Size(1057, 749);
            this.officeViewer1.TabIndex = 0;
            this.officeViewer1.Text = "officeViewer1";
            // 
            // DisplayCV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 749);
            this.Controls.Add(this.officeViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "DisplayCV";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Display CV";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DisplayCV_FormClosed);
            this.Load += new System.EventHandler(this.DisplayCV_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Spire.OfficeViewer.Forms.OfficeViewer officeViewer1;
    }
}