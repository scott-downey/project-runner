
namespace ProjectRunner.Desktop.Forms
{
    partial class ProjectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectForm));
            this.TblProject = new System.Windows.Forms.TableLayoutPanel();
            this.TbExecutableArgs = new System.Windows.Forms.TextBox();
            this.LblExecutableArgs = new System.Windows.Forms.Label();
            this.TbExecutable = new System.Windows.Forms.TextBox();
            this.LblExecutable = new System.Windows.Forms.Label();
            this.TbPath = new System.Windows.Forms.TextBox();
            this.LblPath = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.TbName = new System.Windows.Forms.TextBox();
            this.PnlControls = new System.Windows.Forms.Panel();
            this.BtnSave = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.TblProject.SuspendLayout();
            this.PnlControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // TblProject
            // 
            this.TblProject.ColumnCount = 2;
            this.TblProject.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TblProject.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.TblProject.Controls.Add(this.TbExecutableArgs, 0, 3);
            this.TblProject.Controls.Add(this.LblExecutableArgs, 0, 3);
            this.TblProject.Controls.Add(this.TbExecutable, 1, 2);
            this.TblProject.Controls.Add(this.LblExecutable, 0, 2);
            this.TblProject.Controls.Add(this.TbPath, 1, 1);
            this.TblProject.Controls.Add(this.LblPath, 0, 1);
            this.TblProject.Controls.Add(this.LblName, 0, 0);
            this.TblProject.Controls.Add(this.TbName, 1, 0);
            this.TblProject.Controls.Add(this.PnlControls, 0, 4);
            this.TblProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TblProject.Location = new System.Drawing.Point(0, 0);
            this.TblProject.Margin = new System.Windows.Forms.Padding(0);
            this.TblProject.Name = "TblProject";
            this.TblProject.RowCount = 6;
            this.TblProject.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TblProject.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TblProject.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TblProject.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.TblProject.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TblProject.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TblProject.Size = new System.Drawing.Size(676, 283);
            this.TblProject.TabIndex = 0;
            // 
            // TbExecutableArgs
            // 
            this.TbExecutableArgs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbExecutableArgs.Location = new System.Drawing.Point(135, 156);
            this.TbExecutableArgs.Margin = new System.Windows.Forms.Padding(0, 6, 10, 0);
            this.TbExecutableArgs.Name = "TbExecutableArgs";
            this.TbExecutableArgs.Size = new System.Drawing.Size(531, 35);
            this.TbExecutableArgs.TabIndex = 8;
            // 
            // LblExecutableArgs
            // 
            this.LblExecutableArgs.AutoSize = true;
            this.LblExecutableArgs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblExecutableArgs.Location = new System.Drawing.Point(0, 150);
            this.LblExecutableArgs.Margin = new System.Windows.Forms.Padding(0);
            this.LblExecutableArgs.Name = "LblExecutableArgs";
            this.LblExecutableArgs.Size = new System.Drawing.Size(135, 70);
            this.LblExecutableArgs.TabIndex = 7;
            this.LblExecutableArgs.Text = "Executable Args";
            this.LblExecutableArgs.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TbExecutable
            // 
            this.TbExecutable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbExecutable.Location = new System.Drawing.Point(135, 106);
            this.TbExecutable.Margin = new System.Windows.Forms.Padding(0, 6, 10, 0);
            this.TbExecutable.Name = "TbExecutable";
            this.TbExecutable.Size = new System.Drawing.Size(531, 35);
            this.TbExecutable.TabIndex = 5;
            // 
            // LblExecutable
            // 
            this.LblExecutable.AutoSize = true;
            this.LblExecutable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblExecutable.Location = new System.Drawing.Point(0, 100);
            this.LblExecutable.Margin = new System.Windows.Forms.Padding(0);
            this.LblExecutable.Name = "LblExecutable";
            this.LblExecutable.Size = new System.Drawing.Size(135, 50);
            this.LblExecutable.TabIndex = 4;
            this.LblExecutable.Text = "Executable";
            this.LblExecutable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TbPath
            // 
            this.TbPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbPath.Location = new System.Drawing.Point(135, 56);
            this.TbPath.Margin = new System.Windows.Forms.Padding(0, 6, 10, 0);
            this.TbPath.Name = "TbPath";
            this.TbPath.Size = new System.Drawing.Size(531, 35);
            this.TbPath.TabIndex = 3;
            // 
            // LblPath
            // 
            this.LblPath.AutoSize = true;
            this.LblPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblPath.Location = new System.Drawing.Point(0, 50);
            this.LblPath.Margin = new System.Windows.Forms.Padding(0);
            this.LblPath.Name = "LblPath";
            this.LblPath.Size = new System.Drawing.Size(135, 50);
            this.LblPath.TabIndex = 2;
            this.LblPath.Text = "Path";
            this.LblPath.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblName.Location = new System.Drawing.Point(0, 0);
            this.LblName.Margin = new System.Windows.Forms.Padding(0);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(135, 50);
            this.LblName.TabIndex = 0;
            this.LblName.Text = "Name";
            this.LblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TbName
            // 
            this.TbName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbName.Location = new System.Drawing.Point(135, 6);
            this.TbName.Margin = new System.Windows.Forms.Padding(0, 6, 10, 0);
            this.TbName.Name = "TbName";
            this.TbName.Size = new System.Drawing.Size(531, 35);
            this.TbName.TabIndex = 1;
            // 
            // PnlControls
            // 
            this.PnlControls.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TblProject.SetColumnSpan(this.PnlControls, 2);
            this.PnlControls.Controls.Add(this.BtnSave);
            this.PnlControls.Location = new System.Drawing.Point(1, 220);
            this.PnlControls.Margin = new System.Windows.Forms.Padding(0);
            this.PnlControls.Name = "PnlControls";
            this.PnlControls.Size = new System.Drawing.Size(673, 60);
            this.PnlControls.TabIndex = 6;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(535, 10);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(130, 40);
            this.BtnSave.TabIndex = 0;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 283);
            this.Controls.Add(this.TblProject);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProjectForm";
            this.Text = "Insert Project";
            this.TblProject.ResumeLayout(false);
            this.TblProject.PerformLayout();
            this.PnlControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TblProject;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.TextBox TbName;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label LblPath;
        private System.Windows.Forms.TextBox TbExecutable;
        private System.Windows.Forms.Label LblExecutable;
        private System.Windows.Forms.TextBox TbPath;
        private System.Windows.Forms.Panel PnlControls;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.TextBox TbExecutableArgs;
        private System.Windows.Forms.Label LblExecutableArgs;
    }
}