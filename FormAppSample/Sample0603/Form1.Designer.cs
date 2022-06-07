
namespace Sample0603 {
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
            this.btPush = new System.Windows.Forms.Button();
            this.tbSuu1 = new System.Windows.Forms.TextBox();
            this.tbSuu2 = new System.Windows.Forms.TextBox();
            this.tbAns = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btPush
            // 
            this.btPush.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btPush.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btPush.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btPush.Location = new System.Drawing.Point(393, 208);
            this.btPush.Name = "btPush";
            this.btPush.Size = new System.Drawing.Size(132, 71);
            this.btPush.TabIndex = 0;
            this.btPush.Text = "計算";
            this.btPush.UseVisualStyleBackColor = false;
            this.btPush.Click += new System.EventHandler(this.btPush_Click);
            // 
            // tbSuu1
            // 
            this.tbSuu1.Location = new System.Drawing.Point(12, 64);
            this.tbSuu1.Multiline = true;
            this.tbSuu1.Name = "tbSuu1";
            this.tbSuu1.Size = new System.Drawing.Size(112, 64);
            this.tbSuu1.TabIndex = 1;
            this.tbSuu1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbSuu2
            // 
            this.tbSuu2.Location = new System.Drawing.Point(199, 64);
            this.tbSuu2.Multiline = true;
            this.tbSuu2.Name = "tbSuu2";
            this.tbSuu2.Size = new System.Drawing.Size(112, 64);
            this.tbSuu2.TabIndex = 1;
            this.tbSuu2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbAns
            // 
            this.tbAns.Location = new System.Drawing.Point(393, 64);
            this.tbAns.Multiline = true;
            this.tbAns.Name = "tbAns";
            this.tbAns.Size = new System.Drawing.Size(112, 64);
            this.tbAns.TabIndex = 1;
            this.tbAns.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(140, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "+";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(337, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "=";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 331);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAns);
            this.Controls.Add(this.tbSuu2);
            this.Controls.Add(this.tbSuu1);
            this.Controls.Add(this.btPush);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.textBox1_TextChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btPush;
        private System.Windows.Forms.TextBox tbSuu1;
        private System.Windows.Forms.TextBox tbSuu2;
        private System.Windows.Forms.TextBox tbAns;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

