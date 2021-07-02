
namespace ProjectRunner.Desktop.Forms
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.TlpConfig = new System.Windows.Forms.TableLayoutPanel();
            this.LblClose = new System.Windows.Forms.Label();
            this.PnlCloseOptions = new System.Windows.Forms.Panel();
            this.RbCloseNo = new System.Windows.Forms.RadioButton();
            this.RbCloseYes = new System.Windows.Forms.RadioButton();
            this.LblMinimize = new System.Windows.Forms.Label();
            this.PnlMinimizeOptions = new System.Windows.Forms.Panel();
            this.RbMinimizeNo = new System.Windows.Forms.RadioButton();
            this.RbMinimizeYes = new System.Windows.Forms.RadioButton();
            this.PnlBottom = new System.Windows.Forms.Panel();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TlpConfig.SuspendLayout();
            this.PnlCloseOptions.SuspendLayout();
            this.PnlMinimizeOptions.SuspendLayout();
            this.PnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // TlpConfig
            // 
            this.TlpConfig.ColumnCount = 2;
            this.TlpConfig.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpConfig.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpConfig.Controls.Add(this.LblClose, 0, 1);
            this.TlpConfig.Controls.Add(this.PnlCloseOptions, 1, 1);
            this.TlpConfig.Controls.Add(this.LblMinimize, 0, 0);
            this.TlpConfig.Controls.Add(this.PnlMinimizeOptions, 1, 0);
            this.TlpConfig.Controls.Add(this.PnlBottom, 0, 2);
            this.TlpConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpConfig.Location = new System.Drawing.Point(0, 0);
            this.TlpConfig.Margin = new System.Windows.Forms.Padding(0);
            this.TlpConfig.Name = "TlpConfig";
            this.TlpConfig.RowCount = 3;
            this.TlpConfig.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.TlpConfig.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.TlpConfig.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TlpConfig.Size = new System.Drawing.Size(576, 236);
            this.TlpConfig.TabIndex = 0;
            // 
            // LblClose
            // 
            this.LblClose.AutoSize = true;
            this.LblClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblClose.Location = new System.Drawing.Point(3, 74);
            this.LblClose.Name = "LblClose";
            this.LblClose.Size = new System.Drawing.Size(282, 74);
            this.LblClose.TabIndex = 3;
            this.LblClose.Text = "Close to stray";
            this.LblClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PnlCloseOptions
            // 
            this.PnlCloseOptions.Controls.Add(this.RbCloseNo);
            this.PnlCloseOptions.Controls.Add(this.RbCloseYes);
            this.PnlCloseOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlCloseOptions.Location = new System.Drawing.Point(291, 77);
            this.PnlCloseOptions.Name = "PnlCloseOptions";
            this.PnlCloseOptions.Size = new System.Drawing.Size(282, 68);
            this.PnlCloseOptions.TabIndex = 4;
            // 
            // RbCloseNo
            // 
            this.RbCloseNo.AutoSize = true;
            this.RbCloseNo.Location = new System.Drawing.Point(113, 17);
            this.RbCloseNo.Margin = new System.Windows.Forms.Padding(0);
            this.RbCloseNo.Name = "RbCloseNo";
            this.RbCloseNo.Size = new System.Drawing.Size(66, 34);
            this.RbCloseNo.TabIndex = 2;
            this.RbCloseNo.TabStop = true;
            this.RbCloseNo.Text = "No";
            this.RbCloseNo.UseVisualStyleBackColor = true;
            // 
            // RbCloseYes
            // 
            this.RbCloseYes.AutoSize = true;
            this.RbCloseYes.Location = new System.Drawing.Point(12, 17);
            this.RbCloseYes.Margin = new System.Windows.Forms.Padding(0);
            this.RbCloseYes.Name = "RbCloseYes";
            this.RbCloseYes.Size = new System.Drawing.Size(68, 34);
            this.RbCloseYes.TabIndex = 1;
            this.RbCloseYes.TabStop = true;
            this.RbCloseYes.Text = "Yes";
            this.RbCloseYes.UseVisualStyleBackColor = true;
            // 
            // LblMinimize
            // 
            this.LblMinimize.AutoSize = true;
            this.LblMinimize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblMinimize.Location = new System.Drawing.Point(3, 0);
            this.LblMinimize.Name = "LblMinimize";
            this.LblMinimize.Size = new System.Drawing.Size(282, 74);
            this.LblMinimize.TabIndex = 0;
            this.LblMinimize.Text = "Minimize to stray";
            this.LblMinimize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PnlMinimizeOptions
            // 
            this.PnlMinimizeOptions.Controls.Add(this.RbMinimizeNo);
            this.PnlMinimizeOptions.Controls.Add(this.RbMinimizeYes);
            this.PnlMinimizeOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMinimizeOptions.Location = new System.Drawing.Point(291, 3);
            this.PnlMinimizeOptions.Name = "PnlMinimizeOptions";
            this.PnlMinimizeOptions.Size = new System.Drawing.Size(282, 68);
            this.PnlMinimizeOptions.TabIndex = 2;
            // 
            // RbMinimizeNo
            // 
            this.RbMinimizeNo.AutoSize = true;
            this.RbMinimizeNo.Location = new System.Drawing.Point(113, 17);
            this.RbMinimizeNo.Margin = new System.Windows.Forms.Padding(0);
            this.RbMinimizeNo.Name = "RbMinimizeNo";
            this.RbMinimizeNo.Size = new System.Drawing.Size(66, 34);
            this.RbMinimizeNo.TabIndex = 2;
            this.RbMinimizeNo.TabStop = true;
            this.RbMinimizeNo.Text = "No";
            this.RbMinimizeNo.UseVisualStyleBackColor = true;
            // 
            // RbMinimizeYes
            // 
            this.RbMinimizeYes.AutoSize = true;
            this.RbMinimizeYes.Location = new System.Drawing.Point(12, 17);
            this.RbMinimizeYes.Margin = new System.Windows.Forms.Padding(0);
            this.RbMinimizeYes.Name = "RbMinimizeYes";
            this.RbMinimizeYes.Size = new System.Drawing.Size(68, 34);
            this.RbMinimizeYes.TabIndex = 1;
            this.RbMinimizeYes.TabStop = true;
            this.RbMinimizeYes.Text = "Yes";
            this.RbMinimizeYes.UseVisualStyleBackColor = true;
            // 
            // PnlBottom
            // 
            this.TlpConfig.SetColumnSpan(this.PnlBottom, 2);
            this.PnlBottom.Controls.Add(this.BtnSave);
            this.PnlBottom.Location = new System.Drawing.Point(3, 151);
            this.PnlBottom.Name = "PnlBottom";
            this.PnlBottom.Size = new System.Drawing.Size(570, 85);
            this.PnlBottom.TabIndex = 5;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(430, 33);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(131, 40);
            this.BtnSave.TabIndex = 0;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 236);
            this.Controls.Add(this.TlpConfig);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.TlpConfig.ResumeLayout(false);
            this.TlpConfig.PerformLayout();
            this.PnlCloseOptions.ResumeLayout(false);
            this.PnlCloseOptions.PerformLayout();
            this.PnlMinimizeOptions.ResumeLayout(false);
            this.PnlMinimizeOptions.PerformLayout();
            this.PnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpConfig;
        private System.Windows.Forms.Label LblClose;
        private System.Windows.Forms.Panel PnlCloseOptions;
        private System.Windows.Forms.RadioButton RbCloseNo;
        private System.Windows.Forms.RadioButton RbCloseYes;
        private System.Windows.Forms.Label LblMinimize;
        private System.Windows.Forms.Panel PnlMinimizeOptions;
        private System.Windows.Forms.RadioButton RbMinimizeNo;
        private System.Windows.Forms.RadioButton RbMinimizeYes;
        private System.Windows.Forms.Panel PnlBottom;
        private System.Windows.Forms.Button BtnSave;
    }
}