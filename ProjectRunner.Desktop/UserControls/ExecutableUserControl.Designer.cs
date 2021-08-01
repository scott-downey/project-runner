
namespace ProjectRunner.Desktop.UserControls
{
    partial class ExecutableUserControl
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
            this.PnlName = new System.Windows.Forms.Panel();
            this.LblName = new System.Windows.Forms.Label();
            this.PnlActions = new System.Windows.Forms.Panel();
            this.MSMainMenu = new System.Windows.Forms.MenuStrip();
            this.MSIManage = new System.Windows.Forms.ToolStripMenuItem();
            this.MSIEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.MSIRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.PnlName.SuspendLayout();
            this.PnlActions.SuspendLayout();
            this.MSMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlName
            // 
            this.PnlName.Controls.Add(this.LblName);
            this.PnlName.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlName.Location = new System.Drawing.Point(0, 0);
            this.PnlName.Margin = new System.Windows.Forms.Padding(2);
            this.PnlName.Name = "PnlName";
            this.PnlName.Size = new System.Drawing.Size(298, 70);
            this.PnlName.TabIndex = 0;
            // 
            // LblName
            // 
            this.LblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblName.Font = new System.Drawing.Font("Segoe UI", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblName.Location = new System.Drawing.Point(0, 0);
            this.LblName.Margin = new System.Windows.Forms.Padding(0);
            this.LblName.Name = "LblName";
            this.LblName.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.LblName.Size = new System.Drawing.Size(298, 70);
            this.LblName.TabIndex = 0;
            this.LblName.Text = "Name";
            this.LblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PnlActions
            // 
            this.PnlActions.Controls.Add(this.MSMainMenu);
            this.PnlActions.Dock = System.Windows.Forms.DockStyle.Right;
            this.PnlActions.Location = new System.Drawing.Point(300, 0);
            this.PnlActions.Margin = new System.Windows.Forms.Padding(2);
            this.PnlActions.Name = "PnlActions";
            this.PnlActions.Size = new System.Drawing.Size(180, 70);
            this.PnlActions.TabIndex = 1;
            // 
            // MSMainMenu
            // 
            this.MSMainMenu.BackColor = System.Drawing.SystemColors.Control;
            this.MSMainMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.MSMainMenu.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.MSMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MSIManage});
            this.MSMainMenu.Location = new System.Drawing.Point(19, 14);
            this.MSMainMenu.Name = "MSMainMenu";
            this.MSMainMenu.Padding = new System.Windows.Forms.Padding(0);
            this.MSMainMenu.Size = new System.Drawing.Size(115, 44);
            this.MSMainMenu.TabIndex = 0;
            this.MSMainMenu.Text = "Manage";
            // 
            // MSIManage
            // 
            this.MSIManage.BackColor = System.Drawing.SystemColors.Window;
            this.MSIManage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.MSIManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MSIEdit,
            this.MSIRemove});
            this.MSIManage.Name = "MSIManage";
            this.MSIManage.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.MSIManage.Size = new System.Drawing.Size(113, 44);
            this.MSIManage.Text = "Manage";
            // 
            // MSIEdit
            // 
            this.MSIEdit.Name = "MSIEdit";
            this.MSIEdit.Size = new System.Drawing.Size(205, 40);
            this.MSIEdit.Text = "Edit";
            this.MSIEdit.Click += new System.EventHandler(this.MSIEdit_Click);
            // 
            // MSIRemove
            // 
            this.MSIRemove.Name = "MSIRemove";
            this.MSIRemove.Size = new System.Drawing.Size(205, 40);
            this.MSIRemove.Text = "Remove";
            this.MSIRemove.Click += new System.EventHandler(this.MSIRemove_Click);
            // 
            // ExecutableUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.PnlActions);
            this.Controls.Add(this.PnlName);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(480, 70);
            this.MinimumSize = new System.Drawing.Size(480, 70);
            this.Name = "ExecutableUserControl";
            this.Size = new System.Drawing.Size(480, 70);
            this.PnlName.ResumeLayout(false);
            this.PnlActions.ResumeLayout(false);
            this.PnlActions.PerformLayout();
            this.MSMainMenu.ResumeLayout(false);
            this.MSMainMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlName;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Panel PnlActions;
        private System.Windows.Forms.MenuStrip MSMainMenu;
        private System.Windows.Forms.ToolStripMenuItem MSIManage;
        private System.Windows.Forms.ToolStripMenuItem MSIEdit;
        private System.Windows.Forms.ToolStripMenuItem MSIRemove;
    }
}
