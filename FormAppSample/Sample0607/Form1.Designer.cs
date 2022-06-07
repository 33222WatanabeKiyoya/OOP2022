
namespace Sample0607 {
    partial class 乱数アプリ {
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
            this.pb1 = new System.Windows.Forms.Button();
            this.Number = new System.Windows.Forms.NumericUpDown();
            this.max = new System.Windows.Forms.NumericUpDown();
            this.min = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Number)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.min)).BeginInit();
            this.SuspendLayout();
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(299, 119);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(122, 100);
            this.pb1.TabIndex = 0;
            this.pb1.Text = "乱数";
            this.pb1.UseVisualStyleBackColor = true;
            this.pb1.Click += new System.EventHandler(this.pb1_Click);
            // 
            // Number
            // 
            this.Number.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Number.Location = new System.Drawing.Point(48, 130);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(178, 55);
            this.Number.TabIndex = 1;
            // 
            // max
            // 
            this.max.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.max.Location = new System.Drawing.Point(734, 214);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(142, 55);
            this.max.TabIndex = 1;
            // 
            // min
            // 
            this.min.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.min.Location = new System.Drawing.Point(734, 80);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(142, 55);
            this.min.TabIndex = 1;
            this.min.ValueChanged += new System.EventHandler(this.min_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox1.Location = new System.Drawing.Point(540, 80);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 55);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "最小値";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox2.Location = new System.Drawing.Point(540, 214);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(140, 55);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "最大値";
            // 
            // 乱数アプリ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.min);
            this.Controls.Add(this.max);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.pb1);
            this.Name = "乱数アプリ";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Number)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.min)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pb1;
        private System.Windows.Forms.NumericUpDown Number;
        private System.Windows.Forms.NumericUpDown max;
        private System.Windows.Forms.NumericUpDown min;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

