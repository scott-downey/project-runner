
namespace ProjectRunner.Desktop.Forms
{
    partial class ExecutableForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExecutableForm));
            this.TlpExecutable = new System.Windows.Forms.TableLayoutPanel();
            this.LblFileName = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.TbName = new System.Windows.Forms.TextBox();
            this.PnlBtn = new System.Windows.Forms.Panel();
            this.BtnSave = new System.Windows.Forms.Button();
            this.PnlFileName = new System.Windows.Forms.Panel();
            this.BtnOpenFileDialog = new System.Windows.Forms.Button();
            this.TbFileName = new System.Windows.Forms.TextBox();
            this.OFDExecutable = new System.Windows.Forms.OpenFileDialog();
            this.TlpExecutable.SuspendLayout();
            this.PnlBtn.SuspendLayout();
            this.PnlFileName.SuspendLayout();
            this.SuspendLayout();
            // 
            // TlpExecutable
            // 
            this.TlpExecutable.ColumnCount = 2;
            this.TlpExecutable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TlpExecutable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.TlpExecutable.Controls.Add(this.LblFileName, 0, 1);
            this.TlpExecutable.Controls.Add(this.LblName, 0, 0);
            this.TlpExecutable.Controls.Add(this.TbName, 1, 0);
            this.TlpExecutable.Controls.Add(this.PnlBtn, 0, 2);
            this.TlpExecutable.Controls.Add(this.PnlFileName, 1, 1);
            this.TlpExecutable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpExecutable.Location = new System.Drawing.Point(0, 0);
            this.TlpExecutable.Margin = new System.Windows.Forms.Padding(0);
            this.TlpExecutable.Name = "TlpExecutable";
            this.TlpExecutable.RowCount = 4;
            this.TlpExecutable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.TlpExecutable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.TlpExecutable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.TlpExecutable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpExecutable.Size = new System.Drawing.Size(771, 184);
            this.TlpExecutable.TabIndex = 0;
            // 
            // LblFileName
            // 
            this.LblFileName.AutoSize = true;
            this.LblFileName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblFileName.Location = new System.Drawing.Point(0, 62);
            this.LblFileName.Margin = new System.Windows.Forms.Padding(0);
            this.LblFileName.Name = "LblFileName";
            this.LblFileName.Size = new System.Drawing.Size(154, 62);
            this.LblFileName.TabIndex = 4;
            this.LblFileName.Text = "Filename";
            this.LblFileName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblName.Location = new System.Drawing.Point(0, 0);
            this.LblName.Margin = new System.Windows.Forms.Padding(0);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(154, 62);
            this.LblName.TabIndex = 0;
            this.LblName.Text = "Name";
            this.LblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TbName
            // 
            this.TbName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbName.Location = new System.Drawing.Point(154, 9);
            this.TbName.Margin = new System.Windows.Forms.Padding(0, 9, 12, 0);
            this.TbName.Name = "TbName";
            this.TbName.Size = new System.Drawing.Size(605, 43);
            this.TbName.TabIndex = 1;
            // 
            // PnlBtn
            // 
            this.TlpExecutable.SetColumnSpan(this.PnlBtn, 2);
            this.PnlBtn.Controls.Add(this.BtnSave);
            this.PnlBtn.Location = new System.Drawing.Point(0, 124);
            this.PnlBtn.Margin = new System.Windows.Forms.Padding(0);
            this.PnlBtn.Name = "PnlBtn";
            this.PnlBtn.Size = new System.Drawing.Size(771, 62);
            this.PnlBtn.TabIndex = 6;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(595, 7);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(164, 49);
            this.BtnSave.TabIndex = 0;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // PnlFileName
            // 
            this.PnlFileName.Controls.Add(this.BtnOpenFileDialog);
            this.PnlFileName.Controls.Add(this.TbFileName);
            this.PnlFileName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlFileName.Location = new System.Drawing.Point(156, 64);
            this.PnlFileName.Margin = new System.Windows.Forms.Padding(2);
            this.PnlFileName.Name = "PnlFileName";
            this.PnlFileName.Size = new System.Drawing.Size(613, 58);
            this.PnlFileName.TabIndex = 7;
            // 
            // BtnOpenFileDialog
            // 
            this.BtnOpenFileDialog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnOpenFileDialog.BackColor = System.Drawing.SystemColors.Control;
            this.BtnOpenFileDialog.Location = new System.Drawing.Point(562, 6);
            this.BtnOpenFileDialog.Margin = new System.Windows.Forms.Padding(0);
            this.BtnOpenFileDialog.Name = "BtnOpenFileDialog";
            this.BtnOpenFileDialog.Size = new System.Drawing.Size(40, 43);
            this.BtnOpenFileDialog.TabIndex = 1;
            this.BtnOpenFileDialog.Text = "...";
            this.BtnOpenFileDialog.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnOpenFileDialog.UseVisualStyleBackColor = false;
            this.BtnOpenFileDialog.Click += new System.EventHandler(this.BtnOpenFileDialog_Click);
            // 
            // TbFileName
            // 
            this.TbFileName.Location = new System.Drawing.Point(4, 6);
            this.TbFileName.Margin = new System.Windows.Forms.Padding(2);
            this.TbFileName.Name = "TbFileName";
            this.TbFileName.Size = new System.Drawing.Size(546, 43);
            this.TbFileName.TabIndex = 0;
            // 
            // OFDExecutable
            // 
            this.OFDExecutable.FileName = "OFDExecutable";
            // 
            // ExecutableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 184);
            this.Controls.Add(this.TlpExecutable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(799, 263);
            this.MinimumSize = new System.Drawing.Size(799, 263);
            this.Name = "ExecutableForm";
            this.Text = "Insert Executable";
            this.TlpExecutable.ResumeLayout(false);
            this.TlpExecutable.PerformLayout();
            this.PnlBtn.ResumeLayout(false);
            this.PnlFileName.ResumeLayout(false);
            this.PnlFileName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpExecutable;
        private System.Windows.Forms.Label LblFileName;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.TextBox TbName;
        private System.Windows.Forms.Panel PnlBtn;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Panel PnlFileName;
        private System.Windows.Forms.Button BtnOpenFileDialog;
        private System.Windows.Forms.TextBox TbFileName;
        private System.Windows.Forms.OpenFileDialog OFDExecutable;
    }
}