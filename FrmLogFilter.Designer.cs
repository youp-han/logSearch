namespace logFilter
{
    partial class FrmLogFilter
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchKeyword = new System.Windows.Forms.TextBox();
            this.txtLogFileLocation = new System.Windows.Forms.TextBox();
            this.lstResult = new System.Windows.Forms.ListBox();
            this.btnDropFile = new System.Windows.Forms.Button();
            this.lblLogFileLocation = new System.Windows.Forms.Label();
            this.lblKeyWord = new System.Windows.Forms.Label();
            this.txtFileSearch = new System.Windows.Forms.Button();
            this.lblSaveFile = new System.Windows.Forms.Label();
            this.txtSaveLocation = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(439, 124);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(146, 56);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchKeyword
            // 
            this.txtSearchKeyword.Location = new System.Drawing.Point(123, 141);
            this.txtSearchKeyword.Name = "txtSearchKeyword";
            this.txtSearchKeyword.Size = new System.Drawing.Size(287, 28);
            this.txtSearchKeyword.TabIndex = 1;
            // 
            // txtLogFileLocation
            // 
            this.txtLogFileLocation.Location = new System.Drawing.Point(123, 72);
            this.txtLogFileLocation.Name = "txtLogFileLocation";
            this.txtLogFileLocation.ReadOnly = true;
            this.txtLogFileLocation.Size = new System.Drawing.Size(1123, 28);
            this.txtLogFileLocation.TabIndex = 2;
            // 
            // lstResult
            // 
            this.lstResult.FormattingEnabled = true;
            this.lstResult.HorizontalScrollbar = true;
            this.lstResult.ItemHeight = 18;
            this.lstResult.Location = new System.Drawing.Point(41, 214);
            this.lstResult.Name = "lstResult";
            this.lstResult.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lstResult.ScrollAlwaysVisible = true;
            this.lstResult.Size = new System.Drawing.Size(1378, 274);
            this.lstResult.TabIndex = 3;
            // 
            // btnDropFile
            // 
            this.btnDropFile.Location = new System.Drawing.Point(1274, 520);
            this.btnDropFile.Name = "btnDropFile";
            this.btnDropFile.Size = new System.Drawing.Size(146, 56);
            this.btnDropFile.TabIndex = 4;
            this.btnDropFile.Text = "Open File";
            this.btnDropFile.UseVisualStyleBackColor = true;
            this.btnDropFile.Click += new System.EventHandler(this.btnDropFile_Click);
            // 
            // lblLogFileLocation
            // 
            this.lblLogFileLocation.AutoSize = true;
            this.lblLogFileLocation.Location = new System.Drawing.Point(39, 75);
            this.lblLogFileLocation.Name = "lblLogFileLocation";
            this.lblLogFileLocation.Size = new System.Drawing.Size(69, 18);
            this.lblLogFileLocation.TabIndex = 5;
            this.lblLogFileLocation.Text = "Log File";
            // 
            // lblKeyWord
            // 
            this.lblKeyWord.AutoSize = true;
            this.lblKeyWord.Location = new System.Drawing.Point(39, 152);
            this.lblKeyWord.Name = "lblKeyWord";
            this.lblKeyWord.Size = new System.Drawing.Size(65, 18);
            this.lblKeyWord.TabIndex = 6;
            this.lblKeyWord.Text = "Search";
            // 
            // txtFileSearch
            // 
            this.txtFileSearch.Location = new System.Drawing.Point(1274, 56);
            this.txtFileSearch.Name = "txtFileSearch";
            this.txtFileSearch.Size = new System.Drawing.Size(146, 56);
            this.txtFileSearch.TabIndex = 7;
            this.txtFileSearch.Text = "Log File";
            this.txtFileSearch.UseVisualStyleBackColor = true;
            this.txtFileSearch.Click += new System.EventHandler(this.txtFileSearch_Click);
            // 
            // lblSaveFile
            // 
            this.lblSaveFile.AutoSize = true;
            this.lblSaveFile.Location = new System.Drawing.Point(49, 540);
            this.lblSaveFile.Name = "lblSaveFile";
            this.lblSaveFile.Size = new System.Drawing.Size(124, 18);
            this.lblSaveFile.TabIndex = 9;
            this.lblSaveFile.Text = "Save Location";
            // 
            // txtSaveLocation
            // 
            this.txtSaveLocation.Location = new System.Drawing.Point(187, 537);
            this.txtSaveLocation.Name = "txtSaveLocation";
            this.txtSaveLocation.ReadOnly = true;
            this.txtSaveLocation.Size = new System.Drawing.Size(1070, 28);
            this.txtSaveLocation.TabIndex = 8;
            // 
            // FrmLogFilter
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1461, 590);
            this.Controls.Add(this.lblSaveFile);
            this.Controls.Add(this.txtSaveLocation);
            this.Controls.Add(this.txtFileSearch);
            this.Controls.Add(this.lblKeyWord);
            this.Controls.Add(this.lblLogFileLocation);
            this.Controls.Add(this.btnDropFile);
            this.Controls.Add(this.lstResult);
            this.Controls.Add(this.txtLogFileLocation);
            this.Controls.Add(this.txtSearchKeyword);
            this.Controls.Add(this.btnSearch);
            this.Name = "FrmLogFilter";
            this.Text = "Log Filter";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FrmLogFilter_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FrmLogFilter_DragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchKeyword;
        private System.Windows.Forms.TextBox txtLogFileLocation;
        private System.Windows.Forms.ListBox lstResult;
        private System.Windows.Forms.Button btnDropFile;
        private System.Windows.Forms.Label lblLogFileLocation;
        private System.Windows.Forms.Label lblKeyWord;
        private System.Windows.Forms.Button txtFileSearch;
        private System.Windows.Forms.Label lblSaveFile;
        private System.Windows.Forms.TextBox txtSaveLocation;
    }
}

