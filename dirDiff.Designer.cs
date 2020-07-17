namespace dirDiff_GUI {
    partial class dirDiff {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folder1Btn = new System.Windows.Forms.Button();
            this.folder2Btn = new System.Windows.Forms.Button();
            this.sharedBtn = new System.Windows.Forms.Button();
            this.checkedBoxFiles = new System.Windows.Forms.CheckedListBox();
            this.selectAllBtn = new System.Windows.Forms.Button();
            this.differentBtn = new System.Windows.Forms.Button();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.moveItemsBtn = new System.Windows.Forms.Button();
            this.folder1TxtBox = new System.Windows.Forms.TextBox();
            this.folder2TxtBox = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog3 = new System.Windows.Forms.FolderBrowserDialog();
            this.itemsLbl = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(534, 109);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dir Diff";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // folder1Btn
            // 
            this.folder1Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.folder1Btn.Location = new System.Drawing.Point(445, 104);
            this.folder1Btn.Name = "folder1Btn";
            this.folder1Btn.Size = new System.Drawing.Size(75, 23);
            this.folder1Btn.TabIndex = 1;
            this.folder1Btn.Text = "Select folder";
            this.folder1Btn.UseVisualStyleBackColor = true;
            this.folder1Btn.Click += new System.EventHandler(this.folder1Btn_Click);
            // 
            // folder2Btn
            // 
            this.folder2Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.folder2Btn.Location = new System.Drawing.Point(445, 147);
            this.folder2Btn.Name = "folder2Btn";
            this.folder2Btn.Size = new System.Drawing.Size(75, 23);
            this.folder2Btn.TabIndex = 3;
            this.folder2Btn.Text = "Select folder";
            this.folder2Btn.UseVisualStyleBackColor = true;
            this.folder2Btn.Click += new System.EventHandler(this.folder2Btn_Click);
            // 
            // sharedBtn
            // 
            this.sharedBtn.Location = new System.Drawing.Point(13, 196);
            this.sharedBtn.Name = "sharedBtn";
            this.sharedBtn.Size = new System.Drawing.Size(107, 34);
            this.sharedBtn.TabIndex = 5;
            this.sharedBtn.Text = "Find Shared files";
            this.sharedBtn.UseVisualStyleBackColor = true;
            this.sharedBtn.Click += new System.EventHandler(this.sharedBtn_Click);
            // 
            // checkedBoxFiles
            // 
            this.checkedBoxFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedBoxFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedBoxFiles.FormattingEnabled = true;
            this.checkedBoxFiles.Location = new System.Drawing.Point(13, 246);
            this.checkedBoxFiles.Name = "checkedBoxFiles";
            this.checkedBoxFiles.ScrollAlwaysVisible = true;
            this.checkedBoxFiles.Size = new System.Drawing.Size(507, 298);
            this.checkedBoxFiles.TabIndex = 8;
            // 
            // selectAllBtn
            // 
            this.selectAllBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.selectAllBtn.Location = new System.Drawing.Point(300, 553);
            this.selectAllBtn.Name = "selectAllBtn";
            this.selectAllBtn.Size = new System.Drawing.Size(107, 34);
            this.selectAllBtn.TabIndex = 9;
            this.selectAllBtn.Text = "Select All";
            this.selectAllBtn.UseVisualStyleBackColor = true;
            this.selectAllBtn.Click += new System.EventHandler(this.selectAllBtn_Click);
            // 
            // differentBtn
            // 
            this.differentBtn.Location = new System.Drawing.Point(126, 196);
            this.differentBtn.Name = "differentBtn";
            this.differentBtn.Size = new System.Drawing.Size(107, 34);
            this.differentBtn.TabIndex = 10;
            this.differentBtn.Text = "Find Different files";
            this.differentBtn.UseVisualStyleBackColor = true;
            this.differentBtn.Click += new System.EventHandler(this.differentBtn_Click);
            // 
            // moveItemsBtn
            // 
            this.moveItemsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.moveItemsBtn.Location = new System.Drawing.Point(413, 553);
            this.moveItemsBtn.Name = "moveItemsBtn";
            this.moveItemsBtn.Size = new System.Drawing.Size(107, 34);
            this.moveItemsBtn.TabIndex = 11;
            this.moveItemsBtn.Text = "Move Selected Items";
            this.moveItemsBtn.UseVisualStyleBackColor = true;
            this.moveItemsBtn.Click += new System.EventHandler(this.moveItemsBtn_Click);
            // 
            // folder1TxtBox
            // 
            this.folder1TxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.folder1TxtBox.Location = new System.Drawing.Point(13, 106);
            this.folder1TxtBox.Name = "folder1TxtBox";
            this.folder1TxtBox.Size = new System.Drawing.Size(424, 20);
            this.folder1TxtBox.TabIndex = 1;
            // 
            // folder2TxtBox
            // 
            this.folder2TxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.folder2TxtBox.Location = new System.Drawing.Point(13, 147);
            this.folder2TxtBox.Name = "folder2TxtBox";
            this.folder2TxtBox.Size = new System.Drawing.Size(424, 20);
            this.folder2TxtBox.TabIndex = 2;
            // 
            // itemsLbl
            // 
            this.itemsLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.itemsLbl.Location = new System.Drawing.Point(382, 208);
            this.itemsLbl.Name = "itemsLbl";
            this.itemsLbl.Size = new System.Drawing.Size(138, 22);
            this.itemsLbl.TabIndex = 15;
            this.itemsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(13, 554);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(280, 33);
            this.progressBar.TabIndex = 16;
            // 
            // dirDiff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 611);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.itemsLbl);
            this.Controls.Add(this.folder2TxtBox);
            this.Controls.Add(this.folder1TxtBox);
            this.Controls.Add(this.moveItemsBtn);
            this.Controls.Add(this.differentBtn);
            this.Controls.Add(this.selectAllBtn);
            this.Controls.Add(this.checkedBoxFiles);
            this.Controls.Add(this.sharedBtn);
            this.Controls.Add(this.folder2Btn);
            this.Controls.Add(this.folder1Btn);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(550, 650);
            this.Name = "dirDiff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DirDiff";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button folder1Btn;
        private System.Windows.Forms.Button folder2Btn;
        private System.Windows.Forms.Button sharedBtn;
        private System.Windows.Forms.CheckedListBox checkedBoxFiles;
        private System.Windows.Forms.Button selectAllBtn;
        private System.Windows.Forms.Button differentBtn;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.Button moveItemsBtn;
        private System.Windows.Forms.TextBox folder1TxtBox;
        private System.Windows.Forms.TextBox folder2TxtBox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog3;
        private System.Windows.Forms.Label itemsLbl;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

