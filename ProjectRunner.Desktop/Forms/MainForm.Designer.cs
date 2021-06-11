
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
            this.BtnAddProject = new System.Windows.Forms.Button();
            this.PnlTopControls = new System.Windows.Forms.Panel();
            this.FlPProjects = new System.Windows.Forms.FlowLayoutPanel();
            this.PnlProjects = new System.Windows.Forms.Panel();
            this.PnlTopControls.SuspendLayout();
            this.PnlProjects.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnAddProject
            // 
            this.BtnAddProject.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnAddProject.Location = new System.Drawing.Point(636, 10);
            this.BtnAddProject.Margin = new System.Windows.Forms.Padding(0);
            this.BtnAddProject.Name = "BtnAddProject";
            this.BtnAddProject.Size = new System.Drawing.Size(130, 40);
            this.BtnAddProject.TabIndex = 0;
            this.BtnAddProject.Text = "Add project";
            this.BtnAddProject.UseVisualStyleBackColor = true;
            this.BtnAddProject.Click += new System.EventHandler(this.BtnAddProject_Click);
            // 
            // PnlTopControls
            // 
            this.PnlTopControls.Controls.Add(this.BtnAddProject);
            this.PnlTopControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTopControls.Location = new System.Drawing.Point(0, 0);
            this.PnlTopControls.Margin = new System.Windows.Forms.Padding(0);
            this.PnlTopControls.Name = "PnlTopControls";
            this.PnlTopControls.Padding = new System.Windows.Forms.Padding(10);
            this.PnlTopControls.Size = new System.Drawing.Size(776, 60);
            this.PnlTopControls.TabIndex = 1;
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
            this.PnlProjects.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlProjects.Controls.Add(this.FlPProjects);
            this.PnlProjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlProjects.Location = new System.Drawing.Point(0, 60);
            this.PnlProjects.Margin = new System.Windows.Forms.Padding(0);
            this.PnlProjects.Name = "PnlProjects";
            this.PnlProjects.Size = new System.Drawing.Size(776, 426);
            this.PnlProjects.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 536);
            this.Controls.Add(this.PnlProjects);
            this.Controls.Add(this.PnlTopControls);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 50);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.PnlTopControls.ResumeLayout(false);
            this.PnlProjects.ResumeLayout(false);
            this.PnlProjects.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAddProject;
        private System.Windows.Forms.Panel PnlTopControls;
        private System.Windows.Forms.FlowLayoutPanel FlPProjects;
        private System.Windows.Forms.Panel PnlProjects;
    }
}