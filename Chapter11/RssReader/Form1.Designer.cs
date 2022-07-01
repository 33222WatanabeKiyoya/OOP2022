
namespace RssReader {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.cbRssUrl = new System.Windows.Forms.ComboBox();
            this.bpRssGet = new System.Windows.Forms.Button();
            this.lbRssTitle_Click = new System.Windows.Forms.ListBox();
            this.wbBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // cbRssUrl
            // 
            this.cbRssUrl.FormattingEnabled = true;
            this.cbRssUrl.Location = new System.Drawing.Point(28, 37);
            this.cbRssUrl.Name = "cbRssUrl";
            this.cbRssUrl.Size = new System.Drawing.Size(814, 20);
            this.cbRssUrl.TabIndex = 0;
            // 
            // bpRssGet
            // 
            this.bpRssGet.Location = new System.Drawing.Point(936, 26);
            this.bpRssGet.Name = "bpRssGet";
            this.bpRssGet.Size = new System.Drawing.Size(82, 40);
            this.bpRssGet.TabIndex = 1;
            this.bpRssGet.Text = "取得";
            this.bpRssGet.UseVisualStyleBackColor = true;
            this.bpRssGet.Click += new System.EventHandler(this.bpRssGet_Click);
            // 
            // lbRssTitle_Click
            // 
            this.lbRssTitle_Click.FormattingEnabled = true;
            this.lbRssTitle_Click.ItemHeight = 12;
            this.lbRssTitle_Click.Location = new System.Drawing.Point(28, 98);
            this.lbRssTitle_Click.Name = "lbRssTitle_Click";
            this.lbRssTitle_Click.Size = new System.Drawing.Size(814, 160);
            this.lbRssTitle_Click.TabIndex = 2;
           
            // 
            // wbBrowser
            // 
            this.wbBrowser.Location = new System.Drawing.Point(28, 283);
            this.wbBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbBrowser.Name = "wbBrowser";
            this.wbBrowser.Size = new System.Drawing.Size(814, 250);
            this.wbBrowser.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 609);
            this.Controls.Add(this.wbBrowser);
            this.Controls.Add(this.lbRssTitle_Click);
            this.Controls.Add(this.bpRssGet);
            this.Controls.Add(this.cbRssUrl);
            this.Name = "Form1";
            this.Text = "RssReader";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbRssUrl;
        private System.Windows.Forms.Button bpRssGet;
        private System.Windows.Forms.ListBox lbRssTitle_Click;
        private System.Windows.Forms.WebBrowser wbBrowser;
    }
}

