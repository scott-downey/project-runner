
namespace ProjectRunner.Desktop.Forms
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.PnlTopControls = new System.Windows.Forms.Panel();
            this.MainManuStrip = new System.Windows.Forms.MenuStrip();
            this.MMSProject = new System.Windows.Forms.ToolStripMenuItem();
            this.MMSProjectAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.MMSSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.FlPProjects = new System.Windows.Forms.FlowLayoutPanel();
            this.PnlProjects = new System.Windows.Forms.Panel();
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.PnlBody = new System.Windows.Forms.Panel();
            this.PnlTopControls.SuspendLayout();
            this.MainManuStrip.SuspendLayout();
            this.PnlProjects.SuspendLayout();
            this.PnlBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlTopControls
            // 
            this.PnlTopControls.Controls.Add(this.MainManuStrip);
            this.PnlTopControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTopControls.Location = new System.Drawing.Point(0, 0);
            this.PnlTopControls.Margin = new System.Windows.Forms.Padding(0);
            this.PnlTopControls.Name = "PnlTopControls";
            this.PnlTopControls.Padding = new System.Windows.Forms.Padding(10);
            this.PnlTopControls.Size = new System.Drawing.Size(776, 60);
            this.PnlTopControls.TabIndex = 1;
            // 
            // MainManuStrip
            // 
            this.MainManuStrip.BackColor = System.Drawing.SystemColors.Window;
            this.MainManuStrip.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.MainManuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MMSProject,
            this.MMSSettings});
            this.MainManuStrip.Location = new System.Drawing.Point(10, 10);
            this.MainManuStrip.Name = "MainManuStrip";
            this.MainManuStrip.Padding = new System.Windows.Forms.Padding(0);
            this.MainManuStrip.Size = new System.Drawing.Size(756, 34);
            this.MainManuStrip.TabIndex = 1;
            // 
            // MMSProject
            // 
            this.MMSProject.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MMSProjectAdd});
            this.MMSProject.Name = "MMSProject";
            this.MMSProject.Size = new System.Drawing.Size(95, 34);
            this.MMSProject.Text = "Project";
            // 
            // MMSProjectAdd
            // 
            this.MMSProjectAdd.Name = "MMSProjectAdd";
            this.MMSProjectAdd.Size = new System.Drawing.Size(169, 40);
            this.MMSProjectAdd.Text = "Add";
            this.MMSProjectAdd.Click += new System.EventHandler(this.MMSProjectAdd_Click);
            // 
            // MMSSettings
            // 
            this.MMSSettings.Name = "MMSSettings";
            this.MMSSettings.Size = new System.Drawing.Size(105, 34);
            this.MMSSettings.Text = "Settings";
            this.MMSSettings.Click += new System.EventHandler(this.MMSSettings_Click);
            // 
            // FlPProjects
            // 
            this.FlPProjects.AutoSize = true;
            this.FlPProjects.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FlPProjects.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FlPProjects.Location = new System.Drawing.Point(0, 0);
            this.FlPProjects.Margin = new System.Windows.Forms.Padding(0);
            this.FlPProjects.Name = "FlPProjects";
            this.FlPProjects.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.FlPProjects.Size = new System.Drawing.Size(0, 15);
            this.FlPProjects.TabIndex = 2;
            // 
            // PnlProjects
            // 
            this.PnlProjects.AutoScroll = true;
            this.PnlProjects.BackColor = System.Drawing.SystemColors.Control;
            this.PnlProjects.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlProjects.Controls.Add(this.FlPProjects);
            this.PnlProjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlProjects.Location = new System.Drawing.Point(10, 0);
            this.PnlProjects.Margin = new System.Windows.Forms.Padding(0);
            this.PnlProjects.Name = "PnlProjects";
            this.PnlProjects.Size = new System.Drawing.Size(756, 456);
            this.PnlProjects.TabIndex = 3;
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon.Icon")));
            this.NotifyIcon.Text = "Project Runner";
            // 
            // PnlBody
            // 
            this.PnlBody.Controls.Add(this.PnlProjects);
            this.PnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlBody.Location = new System.Drawing.Point(0, 60);
            this.PnlBody.Margin = new System.Windows.Forms.Padding(0);
            this.PnlBody.Name = "PnlBody";
            this.PnlBody.Padding = new System.Windows.Forms.Padding(10, 0, 10, 20);
            this.PnlBody.Size = new System.Drawing.Size(776, 476);
            this.PnlBody.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(776, 536);
            this.Controls.Add(this.PnlBody);
            this.Controls.Add(this.PnlTopControls);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainManuStrip;
            this.MaximumSize = new System.Drawing.Size(800, 1200);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project Runner";
            this.PnlTopControls.ResumeLayout(false);
            this.PnlTopControls.PerformLayout();
            this.MainManuStrip.ResumeLayout(false);
            this.MainManuStrip.PerformLayout();
            this.PnlProjects.ResumeLayout(false);
            this.PnlProjects.PerformLayout();
            this.PnlBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PnlTopControls;
        private System.Windows.Forms.FlowLayoutPanel FlPProjects;
        private System.Windows.Forms.Panel PnlProjects;
        private System.Windows.Forms.NotifyIcon NotifyIcon;
        private System.Windows.Forms.MenuStrip MainManuStrip;
        private System.Windows.Forms.ToolStripMenuItem MMSProject;
        private System.Windows.Forms.ToolStripMenuItem MMSProjectAdd;
        private System.Windows.Forms.ToolStripMenuItem MMSSettings;
        private System.Windows.Forms.Panel PnlBody;
    }
}