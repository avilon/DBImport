namespace DBImport
{
    partial class ShowProcessView
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
            this.tvProcessList = new System.Windows.Forms.TreeView();
            this.lbTableName = new System.Windows.Forms.Label();
            this.lbCopyFileName = new System.Windows.Forms.Label();
            this.lbProcess = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tvProcessList
            // 
            this.tvProcessList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvProcessList.Location = new System.Drawing.Point(12, 85);
            this.tvProcessList.Name = "tvProcessList";
            this.tvProcessList.Size = new System.Drawing.Size(260, 165);
            this.tvProcessList.TabIndex = 0;
            // 
            // lbTableName
            // 
            this.lbTableName.AutoSize = true;
            this.lbTableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTableName.Location = new System.Drawing.Point(12, 9);
            this.lbTableName.Name = "lbTableName";
            this.lbTableName.Size = new System.Drawing.Size(110, 13);
            this.lbTableName.TabIndex = 1;
            this.lbTableName.Text = "Копируется файл";
            // 
            // lbCopyFileName
            // 
            this.lbCopyFileName.AutoSize = true;
            this.lbCopyFileName.Location = new System.Drawing.Point(12, 32);
            this.lbCopyFileName.Name = "lbCopyFileName";
            this.lbCopyFileName.Size = new System.Drawing.Size(35, 13);
            this.lbCopyFileName.TabIndex = 2;
            this.lbCopyFileName.Text = "label1";
            // 
            // lbProcess
            // 
            this.lbProcess.AutoSize = true;
            this.lbProcess.Location = new System.Drawing.Point(12, 56);
            this.lbProcess.Name = "lbProcess";
            this.lbProcess.Size = new System.Drawing.Size(35, 13);
            this.lbProcess.TabIndex = 3;
            this.lbProcess.Text = "label1";
            // 
            // ShowProcessView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lbProcess);
            this.Controls.Add(this.lbCopyFileName);
            this.Controls.Add(this.lbTableName);
            this.Controls.Add(this.tvProcessList);
            this.Name = "ShowProcessView";
            this.Text = "ShowProcessView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvProcessList;
        private System.Windows.Forms.Label lbTableName;
        private System.Windows.Forms.Label lbCopyFileName;
        private System.Windows.Forms.Label lbProcess;
    }
}