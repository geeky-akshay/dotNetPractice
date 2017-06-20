namespace UITest
{
    partial class Form1
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
            this.olvAttachments = new BrightIdeasSoftware.ObjectListView();
            this.olvColumnName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.btnAddAttachments = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.olvAttachments)).BeginInit();
            this.SuspendLayout();
            // 
            // olvAttachments
            // 
            this.olvAttachments.AllColumns.Add(this.olvColumnName);
            this.olvAttachments.CellEditUseWholeCell = false;
            this.olvAttachments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnName});
            this.olvAttachments.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvAttachments.HasCollapsibleGroups = false;
            this.olvAttachments.Location = new System.Drawing.Point(12, 41);
            this.olvAttachments.Name = "olvAttachments";
            this.olvAttachments.ShowGroups = false;
            this.olvAttachments.ShowHeaderInAllViews = false;
            this.olvAttachments.Size = new System.Drawing.Size(260, 63);
            this.olvAttachments.TabIndex = 0;
            this.olvAttachments.UseCompatibleStateImageBehavior = false;
            this.olvAttachments.View = System.Windows.Forms.View.LargeIcon;
            this.olvAttachments.CellClick += new System.EventHandler<BrightIdeasSoftware.CellClickEventArgs>(this.olvAttachments_CellClick);
            // 
            // olvColumnName
            // 
            this.olvColumnName.AspectName = "Name";
            this.olvColumnName.Hideable = false;
            this.olvColumnName.ImageAspectName = "";
            this.olvColumnName.IsTileViewColumn = true;
            this.olvColumnName.ShowTextInHeader = false;
            this.olvColumnName.Text = "Name";
            this.olvColumnName.Width = 160;
            // 
            // btnAddAttachments
            // 
            this.btnAddAttachments.Location = new System.Drawing.Point(12, 12);
            this.btnAddAttachments.Name = "btnAddAttachments";
            this.btnAddAttachments.Size = new System.Drawing.Size(97, 23);
            this.btnAddAttachments.TabIndex = 1;
            this.btnAddAttachments.Text = "Add Attachment";
            this.btnAddAttachments.UseVisualStyleBackColor = true;
            this.btnAddAttachments.Click += new System.EventHandler(this.btnAddAttachments_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(278, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(224, 250);
            this.webBrowser1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 265);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.btnAddAttachments);
            this.Controls.Add(this.olvAttachments);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.olvAttachments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView olvAttachments;
        private System.Windows.Forms.Button btnAddAttachments;
        private BrightIdeasSoftware.OLVColumn olvColumnName;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

