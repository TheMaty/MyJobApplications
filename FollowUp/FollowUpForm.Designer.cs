namespace FollowUp
{
    partial class FollowUpForm
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
            this.txtItems = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtItems
            // 
            this.txtItems.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtItems.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItems.ForeColor = System.Drawing.Color.Orange;
            this.txtItems.Location = new System.Drawing.Point(0, 0);
            this.txtItems.Multiline = true;
            this.txtItems.Name = "txtItems";
            this.txtItems.ReadOnly = true;
            this.txtItems.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtItems.Size = new System.Drawing.Size(511, 869);
            this.txtItems.TabIndex = 0;
            // 
            // FollowUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 869);
            this.ControlBox = true;
            this.Controls.Add(this.txtItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.Name = "FollowUpForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Follow Up ";
            this.Load += new System.EventHandler(this.FollowUpForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FollowUpForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtItems;
    }
}

