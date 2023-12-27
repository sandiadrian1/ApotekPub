namespace ApotekPub.View
{
    partial class Report
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
            this.panelTitleReportAdm = new System.Windows.Forms.Panel();
            this.labelTitleReportAdm = new System.Windows.Forms.Label();
            this.customGradientPanelFillReport = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnReportMedicine = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.panelTitleReportAdm.SuspendLayout();
            this.customGradientPanelFillReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitleReportAdm
            // 
            this.panelTitleReportAdm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelTitleReportAdm.Controls.Add(this.labelTitleReportAdm);
            this.panelTitleReportAdm.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleReportAdm.Location = new System.Drawing.Point(0, 0);
            this.panelTitleReportAdm.Name = "panelTitleReportAdm";
            this.panelTitleReportAdm.Size = new System.Drawing.Size(737, 52);
            this.panelTitleReportAdm.TabIndex = 16;
            // 
            // labelTitleReportAdm
            // 
            this.labelTitleReportAdm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitleReportAdm.AutoSize = true;
            this.labelTitleReportAdm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTitleReportAdm.Font = new System.Drawing.Font("MingLiU-ExtB", 15.25F);
            this.labelTitleReportAdm.ForeColor = System.Drawing.Color.White;
            this.labelTitleReportAdm.Location = new System.Drawing.Point(201, 15);
            this.labelTitleReportAdm.Name = "labelTitleReportAdm";
            this.labelTitleReportAdm.Size = new System.Drawing.Size(296, 21);
            this.labelTitleReportAdm.TabIndex = 0;
            this.labelTitleReportAdm.Text = "See the latest report here";
            // 
            // customGradientPanelFillReport
            // 
            this.customGradientPanelFillReport.Controls.Add(this.btnReportMedicine);
            this.customGradientPanelFillReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customGradientPanelFillReport.FillColor = System.Drawing.Color.IndianRed;
            this.customGradientPanelFillReport.FillColor2 = System.Drawing.Color.Green;
            this.customGradientPanelFillReport.FillColor3 = System.Drawing.Color.Gray;
            this.customGradientPanelFillReport.FillColor4 = System.Drawing.Color.Teal;
            this.customGradientPanelFillReport.Location = new System.Drawing.Point(0, 52);
            this.customGradientPanelFillReport.Name = "customGradientPanelFillReport";
            this.customGradientPanelFillReport.Size = new System.Drawing.Size(737, 372);
            this.customGradientPanelFillReport.TabIndex = 17;
            // 
            // btnReportMedicine
            // 
            this.btnReportMedicine.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReportMedicine.BackColor = System.Drawing.Color.Transparent;
            this.btnReportMedicine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnReportMedicine.BorderRadius = 10;
            this.btnReportMedicine.BorderThickness = 1;
            this.btnReportMedicine.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReportMedicine.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReportMedicine.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReportMedicine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReportMedicine.FillColor = System.Drawing.Color.Gray;
            this.btnReportMedicine.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnReportMedicine.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnReportMedicine.HoverState.BorderColor = System.Drawing.Color.Fuchsia;
            this.btnReportMedicine.HoverState.FillColor = System.Drawing.Color.DarkGray;
            this.btnReportMedicine.Location = new System.Drawing.Point(205, 140);
            this.btnReportMedicine.Name = "btnReportMedicine";
            this.btnReportMedicine.Size = new System.Drawing.Size(332, 45);
            this.btnReportMedicine.TabIndex = 0;
            this.btnReportMedicine.Text = "New Report Manufaktur";
            this.btnReportMedicine.Click += new System.EventHandler(this.btnReportMedicine_Click);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 424);
            this.Controls.Add(this.customGradientPanelFillReport);
            this.Controls.Add(this.panelTitleReportAdm);
            this.Name = "Report";
            this.Text = "Report";
            this.panelTitleReportAdm.ResumeLayout(false);
            this.panelTitleReportAdm.PerformLayout();
            this.customGradientPanelFillReport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleReportAdm;
        private System.Windows.Forms.Label labelTitleReportAdm;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel customGradientPanelFillReport;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnReportMedicine;
    }
}