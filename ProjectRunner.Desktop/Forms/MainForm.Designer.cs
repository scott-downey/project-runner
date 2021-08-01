
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
            this.FlpProjects = new System.Windows.Forms.FlowLayoutPanel();
            this.PnlProjects = new System.Windows.Forms.Panel();
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.TabControl = new System.Windows.Forms.TabControl();
            this.TpProjects = new System.Windows.Forms.TabPage();
            this.PnlProjectsTop = new System.Windows.Forms.Panel();
            this.BtnAddProject = new System.Windows.Forms.Button();
            this.TpExecutables = new System.Windows.Forms.TabPage();
            this.PnlExecutablesTop = new System.Windows.Forms.Panel();
            this.BtnAddExecutable = new System.Windows.Forms.Button();
            this.PnlExecutables = new System.Windows.Forms.Panel();
            this.FlpExecutables = new System.Windows.Forms.FlowLayoutPanel();
            this.TpSettings = new System.Windows.Forms.TabPage();
            this.TlpSettings = new System.Windows.Forms.TableLayoutPanel();
            this.LblSettingsClose = new System.Windows.Forms.Label();
            this.PnlSettingsCloseOptions = new System.Windows.Forms.Panel();
            this.RbSettingsCloseNo = new System.Windows.Forms.RadioButton();
            this.RbSettingsCloseYes = new System.Windows.Forms.RadioButton();
            this.LblSettingsMinimize = new System.Windows.Forms.Label();
            this.PnlSettingsMinimizeOptions = new System.Windows.Forms.Panel();
            this.RbSettingsMinimizeNo = new System.Windows.Forms.RadioButton();
            this.RbSettingsMinimizeYes = new System.Windows.Forms.RadioButton();
            this.PnlSettingsButtons = new System.Windows.Forms.Panel();
            this.BtnSaveSettings = new System.Windows.Forms.Button();
            this.PnlProjects.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.TpProjects.SuspendLayout();
            this.PnlProjectsTop.SuspendLayout();
            this.TpExecutables.SuspendLayout();
            this.PnlExecutablesTop.SuspendLayout();
            this.PnlExecutables.SuspendLayout();
            this.TpSettings.SuspendLayout();
            this.TlpSettings.SuspendLayout();
            this.PnlSettingsCloseOptions.SuspendLayout();
            this.PnlSettingsMinimizeOptions.SuspendLayout();
            this.PnlSettingsButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // FlpProjects
            // 
            this.FlpProjects.AutoSize = true;
            this.FlpProjects.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FlpProjects.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FlpProjects.Location = new System.Drawing.Point(0, 70);
            this.FlpProjects.Margin = new System.Windows.Forms.Padding(0);
            this.FlpProjects.Name = "FlpProjects";
            this.FlpProjects.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.FlpProjects.Size = new System.Drawing.Size(0, 15);
            this.FlpProjects.TabIndex = 2;
            // 
            // PnlProjects
            // 
            this.PnlProjects.AutoScroll = true;
            this.PnlProjects.BackColor = System.Drawing.SystemColors.Control;
            this.PnlProjects.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlProjects.Controls.Add(this.FlpProjects);
            this.PnlProjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlProjects.Location = new System.Drawing.Point(10, 10);
            this.PnlProjects.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.PnlProjects.Name = "PnlProjects";
            this.PnlProjects.Size = new System.Drawing.Size(747, 468);
            this.PnlProjects.TabIndex = 3;
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon.Icon")));
            this.NotifyIcon.Text = "Project Runner";
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.TpProjects);
            this.TabControl.Controls.Add(this.TpExecutables);
            this.TabControl.Controls.Add(this.TpSettings);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.ItemSize = new System.Drawing.Size(85, 40);
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Margin = new System.Windows.Forms.Padding(0);
            this.TabControl.Name = "TabControl";
            this.TabControl.Padding = new System.Drawing.Point(10, 3);
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(775, 536);
            this.TabControl.TabIndex = 4;
            // 
            // TpProjects
            // 
            this.TpProjects.Controls.Add(this.PnlProjectsTop);
            this.TpProjects.Controls.Add(this.PnlProjects);
            this.TpProjects.Location = new System.Drawing.Point(4, 44);
            this.TpProjects.Name = "TpProjects";
            this.TpProjects.Padding = new System.Windows.Forms.Padding(10);
            this.TpProjects.Size = new System.Drawing.Size(767, 488);
            this.TpProjects.TabIndex = 0;
            this.TpProjects.Text = "Projects";
            this.TpProjects.UseVisualStyleBackColor = true;
            // 
            // PnlProjectsTop
            // 
            this.PnlProjectsTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlProjectsTop.Controls.Add(this.BtnAddProject);
            this.PnlProjectsTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlProjectsTop.Location = new System.Drawing.Point(10, 10);
            this.PnlProjectsTop.Margin = new System.Windows.Forms.Padding(0);
            this.PnlProjectsTop.Name = "PnlProjectsTop";
            this.PnlProjectsTop.Size = new System.Drawing.Size(747, 60);
            this.PnlProjectsTop.TabIndex = 4;
            // 
            // BtnAddProject
            // 
            this.BtnAddProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddProject.Location = new System.Drawing.Point(604, 10);
            this.BtnAddProject.Name = "BtnAddProject";
            this.BtnAddProject.Size = new System.Drawing.Size(131, 40);
            this.BtnAddProject.TabIndex = 0;
            this.BtnAddProject.Text = "Add";
            this.BtnAddProject.UseVisualStyleBackColor = true;
            this.BtnAddProject.Click += new System.EventHandler(this.BtnAddProject_Click);
            // 
            // TpExecutables
            // 
            this.TpExecutables.Controls.Add(this.PnlExecutablesTop);
            this.TpExecutables.Controls.Add(this.PnlExecutables);
            this.TpExecutables.Location = new System.Drawing.Point(4, 44);
            this.TpExecutables.Name = "TpExecutables";
            this.TpExecutables.Padding = new System.Windows.Forms.Padding(10);
            this.TpExecutables.Size = new System.Drawing.Size(767, 488);
            this.TpExecutables.TabIndex = 1;
            this.TpExecutables.Text = "Executables";
            this.TpExecutables.UseVisualStyleBackColor = true;
            // 
            // PnlExecutablesTop
            // 
            this.PnlExecutablesTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlExecutablesTop.Controls.Add(this.BtnAddExecutable);
            this.PnlExecutablesTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlExecutablesTop.Location = new System.Drawing.Point(10, 10);
            this.PnlExecutablesTop.Margin = new System.Windows.Forms.Padding(0);
            this.PnlExecutablesTop.Name = "PnlExecutablesTop";
            this.PnlExecutablesTop.Size = new System.Drawing.Size(747, 60);
            this.PnlExecutablesTop.TabIndex = 5;
            // 
            // BtnAddExecutable
            // 
            this.BtnAddExecutable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddExecutable.Location = new System.Drawing.Point(604, 10);
            this.BtnAddExecutable.Name = "BtnAddExecutable";
            this.BtnAddExecutable.Size = new System.Drawing.Size(131, 40);
            this.BtnAddExecutable.TabIndex = 0;
            this.BtnAddExecutable.Text = "Add";
            this.BtnAddExecutable.UseVisualStyleBackColor = true;
            this.BtnAddExecutable.Click += new System.EventHandler(this.BtnAddExecutable_Click);
            // 
            // PnlExecutables
            // 
            this.PnlExecutables.AutoScroll = true;
            this.PnlExecutables.BackColor = System.Drawing.SystemColors.Control;
            this.PnlExecutables.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlExecutables.Controls.Add(this.FlpExecutables);
            this.PnlExecutables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlExecutables.Location = new System.Drawing.Point(10, 10);
            this.PnlExecutables.Margin = new System.Windows.Forms.Padding(0);
            this.PnlExecutables.Name = "PnlExecutables";
            this.PnlExecutables.Size = new System.Drawing.Size(747, 468);
            this.PnlExecutables.TabIndex = 4;
            // 
            // FlpExecutables
            // 
            this.FlpExecutables.AutoSize = true;
            this.FlpExecutables.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FlpExecutables.BackColor = System.Drawing.Color.Transparent;
            this.FlpExecutables.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FlpExecutables.Location = new System.Drawing.Point(0, 70);
            this.FlpExecutables.Margin = new System.Windows.Forms.Padding(0);
            this.FlpExecutables.Name = "FlpExecutables";
            this.FlpExecutables.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.FlpExecutables.Size = new System.Drawing.Size(0, 15);
            this.FlpExecutables.TabIndex = 2;
            // 
            // TpSettings
            // 
            this.TpSettings.Controls.Add(this.TlpSettings);
            this.TpSettings.Location = new System.Drawing.Point(4, 44);
            this.TpSettings.Name = "TpSettings";
            this.TpSettings.Padding = new System.Windows.Forms.Padding(10);
            this.TpSettings.Size = new System.Drawing.Size(767, 488);
            this.TpSettings.TabIndex = 2;
            this.TpSettings.Text = "Settings";
            this.TpSettings.UseVisualStyleBackColor = true;
            // 
            // TlpSettings
            // 
            this.TlpSettings.BackColor = System.Drawing.Color.Transparent;
            this.TlpSettings.ColumnCount = 2;
            this.TlpSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpSettings.Controls.Add(this.LblSettingsClose, 0, 1);
            this.TlpSettings.Controls.Add(this.PnlSettingsCloseOptions, 1, 1);
            this.TlpSettings.Controls.Add(this.LblSettingsMinimize, 0, 0);
            this.TlpSettings.Controls.Add(this.PnlSettingsMinimizeOptions, 1, 0);
            this.TlpSettings.Controls.Add(this.PnlSettingsButtons, 0, 2);
            this.TlpSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpSettings.Location = new System.Drawing.Point(10, 10);
            this.TlpSettings.Margin = new System.Windows.Forms.Padding(0);
            this.TlpSettings.Name = "TlpSettings";
            this.TlpSettings.RowCount = 4;
            this.TlpSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.TlpSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.TlpSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.TlpSettings.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TlpSettings.Size = new System.Drawing.Size(747, 468);
            this.TlpSettings.TabIndex = 1;
            // 
            // LblSettingsClose
            // 
            this.LblSettingsClose.AutoSize = true;
            this.LblSettingsClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblSettingsClose.Location = new System.Drawing.Point(3, 74);
            this.LblSettingsClose.Name = "LblSettingsClose";
            this.LblSettingsClose.Size = new System.Drawing.Size(367, 74);
            this.LblSettingsClose.TabIndex = 3;
            this.LblSettingsClose.Text = "Close to stray";
            this.LblSettingsClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PnlSettingsCloseOptions
            // 
            this.PnlSettingsCloseOptions.Controls.Add(this.RbSettingsCloseNo);
            this.PnlSettingsCloseOptions.Controls.Add(this.RbSettingsCloseYes);
            this.PnlSettingsCloseOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlSettingsCloseOptions.Location = new System.Drawing.Point(376, 77);
            this.PnlSettingsCloseOptions.Name = "PnlSettingsCloseOptions";
            this.PnlSettingsCloseOptions.Size = new System.Drawing.Size(368, 68);
            this.PnlSettingsCloseOptions.TabIndex = 4;
            // 
            // RbSettingsCloseNo
            // 
            this.RbSettingsCloseNo.AutoSize = true;
            this.RbSettingsCloseNo.Location = new System.Drawing.Point(113, 17);
            this.RbSettingsCloseNo.Margin = new System.Windows.Forms.Padding(0);
            this.RbSettingsCloseNo.Name = "RbSettingsCloseNo";
            this.RbSettingsCloseNo.Size = new System.Drawing.Size(66, 34);
            this.RbSettingsCloseNo.TabIndex = 2;
            this.RbSettingsCloseNo.TabStop = true;
            this.RbSettingsCloseNo.Text = "No";
            this.RbSettingsCloseNo.UseVisualStyleBackColor = true;
            // 
            // RbSettingsCloseYes
            // 
            this.RbSettingsCloseYes.AutoSize = true;
            this.RbSettingsCloseYes.Location = new System.Drawing.Point(12, 17);
            this.RbSettingsCloseYes.Margin = new System.Windows.Forms.Padding(0);
            this.RbSettingsCloseYes.Name = "RbSettingsCloseYes";
            this.RbSettingsCloseYes.Size = new System.Drawing.Size(68, 34);
            this.RbSettingsCloseYes.TabIndex = 1;
            this.RbSettingsCloseYes.TabStop = true;
            this.RbSettingsCloseYes.Text = "Yes";
            this.RbSettingsCloseYes.UseVisualStyleBackColor = true;
            // 
            // LblSettingsMinimize
            // 
            this.LblSettingsMinimize.AutoSize = true;
            this.LblSettingsMinimize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblSettingsMinimize.Location = new System.Drawing.Point(3, 0);
            this.LblSettingsMinimize.Name = "LblSettingsMinimize";
            this.LblSettingsMinimize.Size = new System.Drawing.Size(367, 74);
            this.LblSettingsMinimize.TabIndex = 0;
            this.LblSettingsMinimize.Text = "Minimize to stray";
            this.LblSettingsMinimize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PnlSettingsMinimizeOptions
            // 
            this.PnlSettingsMinimizeOptions.Controls.Add(this.RbSettingsMinimizeNo);
            this.PnlSettingsMinimizeOptions.Controls.Add(this.RbSettingsMinimizeYes);
            this.PnlSettingsMinimizeOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlSettingsMinimizeOptions.Location = new System.Drawing.Point(376, 3);
            this.PnlSettingsMinimizeOptions.Name = "PnlSettingsMinimizeOptions";
            this.PnlSettingsMinimizeOptions.Size = new System.Drawing.Size(368, 68);
            this.PnlSettingsMinimizeOptions.TabIndex = 2;
            // 
            // RbSettingsMinimizeNo
            // 
            this.RbSettingsMinimizeNo.AutoSize = true;
            this.RbSettingsMinimizeNo.Location = new System.Drawing.Point(113, 17);
            this.RbSettingsMinimizeNo.Margin = new System.Windows.Forms.Padding(0);
            this.RbSettingsMinimizeNo.Name = "RbSettingsMinimizeNo";
            this.RbSettingsMinimizeNo.Size = new System.Drawing.Size(66, 34);
            this.RbSettingsMinimizeNo.TabIndex = 2;
            this.RbSettingsMinimizeNo.TabStop = true;
            this.RbSettingsMinimizeNo.Text = "No";
            this.RbSettingsMinimizeNo.UseVisualStyleBackColor = true;
            // 
            // RbSettingsMinimizeYes
            // 
            this.RbSettingsMinimizeYes.AutoSize = true;
            this.RbSettingsMinimizeYes.Location = new System.Drawing.Point(12, 17);
            this.RbSettingsMinimizeYes.Margin = new System.Windows.Forms.Padding(0);
            this.RbSettingsMinimizeYes.Name = "RbSettingsMinimizeYes";
            this.RbSettingsMinimizeYes.Size = new System.Drawing.Size(68, 34);
            this.RbSettingsMinimizeYes.TabIndex = 1;
            this.RbSettingsMinimizeYes.TabStop = true;
            this.RbSettingsMinimizeYes.Text = "Yes";
            this.RbSettingsMinimizeYes.UseVisualStyleBackColor = true;
            // 
            // PnlSettingsButtons
            // 
            this.TlpSettings.SetColumnSpan(this.PnlSettingsButtons, 2);
            this.PnlSettingsButtons.Controls.Add(this.BtnSaveSettings);
            this.PnlSettingsButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlSettingsButtons.Location = new System.Drawing.Point(3, 151);
            this.PnlSettingsButtons.Name = "PnlSettingsButtons";
            this.PnlSettingsButtons.Size = new System.Drawing.Size(741, 68);
            this.PnlSettingsButtons.TabIndex = 5;
            // 
            // BtnSaveSettings
            // 
            this.BtnSaveSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSaveSettings.Location = new System.Drawing.Point(598, 14);
            this.BtnSaveSettings.Name = "BtnSaveSettings";
            this.BtnSaveSettings.Size = new System.Drawing.Size(131, 40);
            this.BtnSaveSettings.TabIndex = 0;
            this.BtnSaveSettings.Text = "Save";
            this.BtnSaveSettings.UseVisualStyleBackColor = true;
            this.BtnSaveSettings.Click += new System.EventHandler(this.BtnSaveSettings_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(775, 536);
            this.Controls.Add(this.TabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(799, 1198);
            this.MinimumSize = new System.Drawing.Size(799, 598);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project Runner";
            this.PnlProjects.ResumeLayout(false);
            this.PnlProjects.PerformLayout();
            this.TabControl.ResumeLayout(false);
            this.TpProjects.ResumeLayout(false);
            this.PnlProjectsTop.ResumeLayout(false);
            this.TpExecutables.ResumeLayout(false);
            this.PnlExecutablesTop.ResumeLayout(false);
            this.PnlExecutables.ResumeLayout(false);
            this.PnlExecutables.PerformLayout();
            this.TpSettings.ResumeLayout(false);
            this.TlpSettings.ResumeLayout(false);
            this.TlpSettings.PerformLayout();
            this.PnlSettingsCloseOptions.ResumeLayout(false);
            this.PnlSettingsCloseOptions.PerformLayout();
            this.PnlSettingsMinimizeOptions.ResumeLayout(false);
            this.PnlSettingsMinimizeOptions.PerformLayout();
            this.PnlSettingsButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel FlpProjects;
        private System.Windows.Forms.Panel PnlProjects;
        private System.Windows.Forms.NotifyIcon NotifyIcon;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage TpProjects;
        private System.Windows.Forms.TabPage TpExecutables;
        private System.Windows.Forms.TabPage TpSettings;
        private System.Windows.Forms.Panel PnlExecutables;
        private System.Windows.Forms.FlowLayoutPanel FlpExecutables;
        private System.Windows.Forms.TableLayoutPanel TlpSettings;
        private System.Windows.Forms.Label LblSettingsClose;
        private System.Windows.Forms.Panel PnlSettingsCloseOptions;
        private System.Windows.Forms.RadioButton RbSettingsCloseNo;
        private System.Windows.Forms.RadioButton RbSettingsCloseYes;
        private System.Windows.Forms.Label LblSettingsMinimize;
        private System.Windows.Forms.Panel PnlSettingsMinimizeOptions;
        private System.Windows.Forms.RadioButton RbSettingsMinimizeNo;
        private System.Windows.Forms.RadioButton RbSettingsMinimizeYes;
        private System.Windows.Forms.Panel PnlSettingsButtons;
        private System.Windows.Forms.Button BtnSaveSettings;
        private System.Windows.Forms.Panel PnlProjectsTop;
        private System.Windows.Forms.Button BtnAddProject;
        private System.Windows.Forms.Panel PnlExecutablesTop;
        private System.Windows.Forms.Button BtnAddExecutable;
    }
}