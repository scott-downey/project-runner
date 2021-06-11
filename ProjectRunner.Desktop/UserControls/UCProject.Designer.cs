
namespace ProjectRunner.Desktop.UserControls
{
    partial class UCProject
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PnlButtons = new System.Windows.Forms.Panel();
            this.BtnManage = new System.Windows.Forms.Button();
            this.BtnAction = new System.Windows.Forms.Button();
            this.PnlDescription = new System.Windows.Forms.Panel();
            this.LblProject = new System.Windows.Forms.Label();
            this.PnlButtons.SuspendLayout();
            this.PnlDescription.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlButtons
            // 
            this.PnlButtons.Controls.Add(this.BtnManage);
            this.PnlButtons.Controls.Add(this.BtnAction);
            this.PnlButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.PnlButtons.Location = new System.Drawing.Point(390, 0);
            this.PnlButtons.Margin = new System.Windows.Forms.Padding(0);
            this.PnlButtons.Name = "PnlButtons";
            this.PnlButtons.Padding = new System.Windows.Forms.Padding(15);
            this.PnlButtons.Size = new System.Drawing.Size(260, 80);
            this.PnlButtons.TabIndex = 1;
            // 
            // BtnManage
            // 
            this.BtnManage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnManage.Location = new System.Drawing.Point(142, 22);
            this.BtnManage.Name = "BtnManage";
            this.BtnManage.Size = new System.Drawing.Size(100, 40);
            this.BtnManage.TabIndex = 1;
            this.BtnManage.Text = "Manage";
            this.BtnManage.UseVisualStyleBackColor = true;
            // 
            // BtnAction
            // 
            this.BtnAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAction.Location = new System.Drawing.Point(24, 22);
            this.BtnAction.Name = "BtnAction";
            this.BtnAction.Size = new System.Drawing.Size(100, 40);
            this.BtnAction.TabIndex = 0;
            this.BtnAction.Text = "Run";
            this.BtnAction.UseVisualStyleBackColor = true;
            // 
            // PnlDescription
            // 
            this.PnlDescription.Controls.Add(this.LblProject);
            this.PnlDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlDescription.Location = new System.Drawing.Point(0, 0);
            this.PnlDescription.Margin = new System.Windows.Forms.Padding(0);
            this.PnlDescription.Name = "PnlDescription";
            this.PnlDescription.Padding = new System.Windows.Forms.Padding(15);
            this.PnlDescription.Size = new System.Drawing.Size(390, 80);
            this.PnlDescription.TabIndex = 2;
            // 
            // LblProject
            // 
            this.LblProject.AutoSize = true;
            this.LblProject.Font = new System.Drawing.Font("Segoe UI", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblProject.Location = new System.Drawing.Point(15, 15);
            this.LblProject.Margin = new System.Windows.Forms.Padding(0);
            this.LblProject.Name = "LblProject";
            this.LblProject.Size = new System.Drawing.Size(0, 50);
            this.LblProject.TabIndex = 0;
            // 
            // UCProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.Controls.Add(this.PnlDescription);
            this.Controls.Add(this.PnlButtons);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UCProject";
            this.Size = new System.Drawing.Size(650, 80);
            this.PnlButtons.ResumeLayout(false);
            this.PnlDescription.ResumeLayout(false);
            this.PnlDescription.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlButtons;
        private System.Windows.Forms.Button BtnManage;
        private System.Windows.Forms.Button BtnAction;
        private System.Windows.Forms.Panel PnlDescription;
        private System.Windows.Forms.Label LblProject;
    }
}
