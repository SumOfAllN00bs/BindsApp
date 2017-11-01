namespace BindsApp
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
            this.sc_BindsList = new System.Windows.Forms.SplitContainer();
            this.btn_Binds = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sc_BindsList)).BeginInit();
            this.sc_BindsList.Panel1.SuspendLayout();
            this.sc_BindsList.SuspendLayout();
            this.SuspendLayout();
            // 
            // sc_BindsList
            // 
            this.sc_BindsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sc_BindsList.Location = new System.Drawing.Point(0, 0);
            this.sc_BindsList.Name = "sc_BindsList";
            this.sc_BindsList.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sc_BindsList.Panel1
            // 
            this.sc_BindsList.Panel1.Controls.Add(this.btn_Binds);
            this.sc_BindsList.Panel1.Controls.Add(this.btn_Refresh);
            this.sc_BindsList.Size = new System.Drawing.Size(284, 261);
            this.sc_BindsList.SplitterDistance = 28;
            this.sc_BindsList.TabIndex = 0;
            // 
            // btn_Binds
            // 
            this.btn_Binds.Location = new System.Drawing.Point(206, 3);
            this.btn_Binds.Name = "btn_Binds";
            this.btn_Binds.Size = new System.Drawing.Size(75, 23);
            this.btn_Binds.TabIndex = 0;
            this.btn_Binds.Text = "Binds file";
            this.btn_Binds.UseVisualStyleBackColor = true;
            this.btn_Binds.Click += new System.EventHandler(this.btn_Binds_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(3, 3);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_Refresh.TabIndex = 0;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.sc_BindsList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.sc_BindsList.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sc_BindsList)).EndInit();
            this.sc_BindsList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer sc_BindsList;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Binds;
    }
}

