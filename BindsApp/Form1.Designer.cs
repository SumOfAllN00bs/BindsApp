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
            this.btn_Binds = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.tlp_BindsList = new System.Windows.Forms.TableLayoutPanel();
            this.p_Controls = new System.Windows.Forms.Panel();
            this.flp_Buttons = new System.Windows.Forms.FlowLayoutPanel();
            this.tlp_BindsList.SuspendLayout();
            this.p_Controls.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Binds
            // 
            this.btn_Binds.Location = new System.Drawing.Point(194, 9);
            this.btn_Binds.Name = "btn_Binds";
            this.btn_Binds.Size = new System.Drawing.Size(75, 23);
            this.btn_Binds.TabIndex = 0;
            this.btn_Binds.Text = "Binds file";
            this.btn_Binds.UseVisualStyleBackColor = true;
            this.btn_Binds.Click += new System.EventHandler(this.btn_Binds_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(9, 9);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_Refresh.TabIndex = 0;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // tlp_BindsList
            // 
            this.tlp_BindsList.ColumnCount = 1;
            this.tlp_BindsList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_BindsList.Controls.Add(this.p_Controls, 0, 0);
            this.tlp_BindsList.Controls.Add(this.flp_Buttons, 0, 1);
            this.tlp_BindsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_BindsList.Location = new System.Drawing.Point(0, 0);
            this.tlp_BindsList.Name = "tlp_BindsList";
            this.tlp_BindsList.RowCount = 2;
            this.tlp_BindsList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlp_BindsList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_BindsList.Size = new System.Drawing.Size(284, 261);
            this.tlp_BindsList.TabIndex = 1;
            // 
            // p_Controls
            // 
            this.p_Controls.Controls.Add(this.btn_Refresh);
            this.p_Controls.Controls.Add(this.btn_Binds);
            this.p_Controls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_Controls.Location = new System.Drawing.Point(3, 3);
            this.p_Controls.Name = "p_Controls";
            this.p_Controls.Size = new System.Drawing.Size(278, 44);
            this.p_Controls.TabIndex = 0;
            // 
            // flp_Buttons
            // 
            this.flp_Buttons.AutoScroll = true;
            this.flp_Buttons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_Buttons.Location = new System.Drawing.Point(3, 53);
            this.flp_Buttons.Name = "flp_Buttons";
            this.flp_Buttons.Size = new System.Drawing.Size(278, 205);
            this.flp_Buttons.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tlp_BindsList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tlp_BindsList.ResumeLayout(false);
            this.p_Controls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Binds;
        private System.Windows.Forms.TableLayoutPanel tlp_BindsList;
        private System.Windows.Forms.Panel p_Controls;
        private System.Windows.Forms.FlowLayoutPanel flp_Buttons;
    }
}

