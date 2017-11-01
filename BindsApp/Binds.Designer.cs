namespace BindsApp
{
    partial class Binds
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
            this.txt_BindsDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_BindsDisplay
            // 
            this.txt_BindsDisplay.Location = new System.Drawing.Point(12, 12);
            this.txt_BindsDisplay.Multiline = true;
            this.txt_BindsDisplay.Name = "txt_BindsDisplay";
            this.txt_BindsDisplay.Size = new System.Drawing.Size(634, 509);
            this.txt_BindsDisplay.TabIndex = 0;
            // 
            // Binds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 533);
            this.Controls.Add(this.txt_BindsDisplay);
            this.Name = "Binds";
            this.Text = "Binds";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Binds_FormClosing);
            this.Load += new System.EventHandler(this.Binds_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_BindsDisplay;
    }
}