
namespace WeatherApp {
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
            this.tbWeatherInfo = new System.Windows.Forms.TextBox();
            this.btWeatherGet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbArea = new System.Windows.Forms.ComboBox();
            this.pbImageFirst = new System.Windows.Forms.PictureBox();
            this.pbImageSecond = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMaxTempFirst = new System.Windows.Forms.TextBox();
            this.tbMinTempFirst = new System.Windows.Forms.TextBox();
            this.tbMaxTempSecond = new System.Windows.Forms.TextBox();
            this.tbMinTempSecond = new System.Windows.Forms.TextBox();
            this.lbDayFirst = new System.Windows.Forms.Label();
            this.lbDaySecond = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbWindDirection = new System.Windows.Forms.TextBox();
            this.lbDayThird = new System.Windows.Forms.Label();
            this.tbMinTempThird = new System.Windows.Forms.TextBox();
            this.tbMaxTempThird = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pbImageThird = new System.Windows.Forms.PictureBox();
            this.lbDateFirst = new System.Windows.Forms.Label();
            this.lbDateSecond = new System.Windows.Forms.Label();
            this.lbDateThird = new System.Windows.Forms.Label();
            this.lbWeatherFirst = new System.Windows.Forms.Label();
            this.lbWeatherSecond = new System.Windows.Forms.Label();
            this.lbWeatherThird = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageFirst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageThird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbWeatherInfo
            // 
            this.tbWeatherInfo.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbWeatherInfo.Location = new System.Drawing.Point(262, 454);
            this.tbWeatherInfo.Multiline = true;
            this.tbWeatherInfo.Name = "tbWeatherInfo";
            this.tbWeatherInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbWeatherInfo.Size = new System.Drawing.Size(477, 164);
            this.tbWeatherInfo.TabIndex = 0;
            // 
            // btWeatherGet
            // 
            this.btWeatherGet.Location = new System.Drawing.Point(384, 14);
            this.btWeatherGet.Name = "btWeatherGet";
            this.btWeatherGet.Size = new System.Drawing.Size(102, 31);
            this.btWeatherGet.TabIndex = 1;
            this.btWeatherGet.Text = "取得";
            this.btWeatherGet.UseVisualStyleBackColor = true;
            this.btWeatherGet.Click += new System.EventHandler(this.btWeatherGet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(46, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "地域選択";
            // 
            // cbArea
            // 
            this.cbArea.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cbArea.FormattingEnabled = true;
            this.cbArea.Items.AddRange(new object[] {
            "北海道",
            "青森県",
            "岩手県",
            "宮城県",
            "秋田県",
            "山形県",
            "福島県",
            "茨城県",
            "栃木県",
            "群馬県",
            "埼玉県",
            "千葉県",
            "東京都",
            "神奈川県",
            "山梨県",
            "長野県",
            "岐阜県",
            "静岡県",
            "愛知県",
            "三重県",
            "新潟県",
            "富山県",
            "石川県",
            "福井県",
            "滋賀県",
            "京都府",
            "大阪府",
            "兵庫県",
            "奈良県",
            "和歌山県",
            "鳥取県",
            "島根県",
            "岡山県",
            "広島県",
            "徳島県",
            "香川県",
            "愛媛県",
            "高知県",
            "山口県",
            "福岡県",
            "佐賀県",
            "長崎県",
            "熊本県",
            "大分県",
            "宮崎県",
            "鹿児島県",
            "沖縄県"});
            this.cbArea.Location = new System.Drawing.Point(132, 10);
            this.cbArea.Name = "cbArea";
            this.cbArea.Size = new System.Drawing.Size(228, 32);
            this.cbArea.TabIndex = 3;
            // 
            // pbImageFirst
            // 
            this.pbImageFirst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImageFirst.Location = new System.Drawing.Point(13, 93);
            this.pbImageFirst.Name = "pbImageFirst";
            this.pbImageFirst.Size = new System.Drawing.Size(223, 164);
            this.pbImageFirst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImageFirst.TabIndex = 4;
            this.pbImageFirst.TabStop = false;
            // 
            // pbImageSecond
            // 
            this.pbImageSecond.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImageSecond.Location = new System.Drawing.Point(263, 93);
            this.pbImageSecond.Name = "pbImageSecond";
            this.pbImageSecond.Size = new System.Drawing.Size(223, 164);
            this.pbImageSecond.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImageSecond.TabIndex = 5;
            this.pbImageSecond.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(14, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "最高気温";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(14, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "最低気温";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(264, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "最高気温";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(264, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "最低気温";
            // 
            // tbMaxTempFirst
            // 
            this.tbMaxTempFirst.Location = new System.Drawing.Point(106, 330);
            this.tbMaxTempFirst.Name = "tbMaxTempFirst";
            this.tbMaxTempFirst.Size = new System.Drawing.Size(100, 19);
            this.tbMaxTempFirst.TabIndex = 10;
            // 
            // tbMinTempFirst
            // 
            this.tbMinTempFirst.Location = new System.Drawing.Point(106, 366);
            this.tbMinTempFirst.Name = "tbMinTempFirst";
            this.tbMinTempFirst.Size = new System.Drawing.Size(100, 19);
            this.tbMinTempFirst.TabIndex = 11;
            // 
            // tbMaxTempSecond
            // 
            this.tbMaxTempSecond.Location = new System.Drawing.Point(370, 330);
            this.tbMaxTempSecond.Name = "tbMaxTempSecond";
            this.tbMaxTempSecond.Size = new System.Drawing.Size(100, 19);
            this.tbMaxTempSecond.TabIndex = 12;
            // 
            // tbMinTempSecond
            // 
            this.tbMinTempSecond.Location = new System.Drawing.Point(370, 366);
            this.tbMinTempSecond.Name = "tbMinTempSecond";
            this.tbMinTempSecond.Size = new System.Drawing.Size(100, 19);
            this.tbMinTempSecond.TabIndex = 13;
            // 
            // lbDayFirst
            // 
            this.lbDayFirst.AutoSize = true;
            this.lbDayFirst.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbDayFirst.Location = new System.Drawing.Point(11, 61);
            this.lbDayFirst.Name = "lbDayFirst";
            this.lbDayFirst.Size = new System.Drawing.Size(28, 19);
            this.lbDayFirst.TabIndex = 14;
            this.lbDayFirst.Text = "水";
            // 
            // lbDaySecond
            // 
            this.lbDaySecond.AutoSize = true;
            this.lbDaySecond.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbDaySecond.Location = new System.Drawing.Point(260, 61);
            this.lbDaySecond.Name = "lbDaySecond";
            this.lbDaySecond.Size = new System.Drawing.Size(28, 19);
            this.lbDaySecond.TabIndex = 15;
            this.lbDaySecond.Text = "木";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(14, 424);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 19);
            this.label8.TabIndex = 17;
            this.label8.Text = "風向";
            // 
            // tbWindDirection
            // 
            this.tbWindDirection.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbWindDirection.Location = new System.Drawing.Point(16, 454);
            this.tbWindDirection.Multiline = true;
            this.tbWindDirection.Name = "tbWindDirection";
            this.tbWindDirection.Size = new System.Drawing.Size(220, 164);
            this.tbWindDirection.TabIndex = 18;
            // 
            // lbDayThird
            // 
            this.lbDayThird.AutoSize = true;
            this.lbDayThird.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbDayThird.Location = new System.Drawing.Point(514, 61);
            this.lbDayThird.Name = "lbDayThird";
            this.lbDayThird.Size = new System.Drawing.Size(28, 19);
            this.lbDayThird.TabIndex = 24;
            this.lbDayThird.Text = "金";
            // 
            // tbMinTempThird
            // 
            this.tbMinTempThird.Location = new System.Drawing.Point(623, 366);
            this.tbMinTempThird.Name = "tbMinTempThird";
            this.tbMinTempThird.Size = new System.Drawing.Size(100, 19);
            this.tbMinTempThird.TabIndex = 23;
            // 
            // tbMaxTempThird
            // 
            this.tbMaxTempThird.Location = new System.Drawing.Point(623, 330);
            this.tbMaxTempThird.Name = "tbMaxTempThird";
            this.tbMaxTempThird.Size = new System.Drawing.Size(100, 19);
            this.tbMaxTempThird.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label10.Location = new System.Drawing.Point(517, 367);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 19);
            this.label10.TabIndex = 21;
            this.label10.Text = "最低気温";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label11.Location = new System.Drawing.Point(517, 330);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 19);
            this.label11.TabIndex = 20;
            this.label11.Text = "最高気温";
            // 
            // pbImageThird
            // 
            this.pbImageThird.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImageThird.Location = new System.Drawing.Point(517, 93);
            this.pbImageThird.Name = "pbImageThird";
            this.pbImageThird.Size = new System.Drawing.Size(223, 164);
            this.pbImageThird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImageThird.TabIndex = 19;
            this.pbImageThird.TabStop = false;
            // 
            // lbDateFirst
            // 
            this.lbDateFirst.AutoSize = true;
            this.lbDateFirst.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbDateFirst.Location = new System.Drawing.Point(192, 61);
            this.lbDateFirst.Name = "lbDateFirst";
            this.lbDateFirst.Size = new System.Drawing.Size(48, 19);
            this.lbDateFirst.TabIndex = 25;
            this.lbDateFirst.Text = "22日";
            // 
            // lbDateSecond
            // 
            this.lbDateSecond.AutoSize = true;
            this.lbDateSecond.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbDateSecond.Location = new System.Drawing.Point(442, 61);
            this.lbDateSecond.Name = "lbDateSecond";
            this.lbDateSecond.Size = new System.Drawing.Size(48, 19);
            this.lbDateSecond.TabIndex = 26;
            this.lbDateSecond.Text = "22日";
            // 
            // lbDateThird
            // 
            this.lbDateThird.AutoSize = true;
            this.lbDateThird.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbDateThird.Location = new System.Drawing.Point(696, 61);
            this.lbDateThird.Name = "lbDateThird";
            this.lbDateThird.Size = new System.Drawing.Size(48, 19);
            this.lbDateThird.TabIndex = 27;
            this.lbDateThird.Text = "22日";
            // 
            // lbWeatherFirst
            // 
            this.lbWeatherFirst.AutoSize = true;
            this.lbWeatherFirst.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbWeatherFirst.Location = new System.Drawing.Point(74, 270);
            this.lbWeatherFirst.Name = "lbWeatherFirst";
            this.lbWeatherFirst.Size = new System.Drawing.Size(55, 24);
            this.lbWeatherFirst.TabIndex = 28;
            this.lbWeatherFirst.Text = "晴れ";
            // 
            // lbWeatherSecond
            // 
            this.lbWeatherSecond.AutoSize = true;
            this.lbWeatherSecond.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbWeatherSecond.Location = new System.Drawing.Point(330, 270);
            this.lbWeatherSecond.Name = "lbWeatherSecond";
            this.lbWeatherSecond.Size = new System.Drawing.Size(55, 24);
            this.lbWeatherSecond.TabIndex = 29;
            this.lbWeatherSecond.Text = "晴れ";
            // 
            // lbWeatherThird
            // 
            this.lbWeatherThird.AutoSize = true;
            this.lbWeatherThird.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbWeatherThird.Location = new System.Drawing.Point(586, 270);
            this.lbWeatherThird.Name = "lbWeatherThird";
            this.lbWeatherThird.Size = new System.Drawing.Size(55, 24);
            this.lbWeatherThird.TabIndex = 30;
            this.lbWeatherThird.Text = "晴れ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(264, 424);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 19);
            this.label6.TabIndex = 31;
            this.label6.Text = "天気概況";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WeatherApp.Properties.Resources.OIP__1_;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(749, 648);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 646);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbWeatherThird);
            this.Controls.Add(this.lbWeatherSecond);
            this.Controls.Add(this.lbWeatherFirst);
            this.Controls.Add(this.lbDateThird);
            this.Controls.Add(this.lbDateSecond);
            this.Controls.Add(this.lbDateFirst);
            this.Controls.Add(this.lbDayThird);
            this.Controls.Add(this.tbMinTempThird);
            this.Controls.Add(this.tbMaxTempThird);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pbImageThird);
            this.Controls.Add(this.tbWindDirection);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbDaySecond);
            this.Controls.Add(this.lbDayFirst);
            this.Controls.Add(this.tbMinTempSecond);
            this.Controls.Add(this.tbMaxTempSecond);
            this.Controls.Add(this.tbMinTempFirst);
            this.Controls.Add(this.tbMaxTempFirst);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbImageSecond);
            this.Controls.Add(this.pbImageFirst);
            this.Controls.Add(this.cbArea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btWeatherGet);
            this.Controls.Add(this.tbWeatherInfo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImageFirst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageThird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbWeatherInfo;
        private System.Windows.Forms.Button btWeatherGet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbArea;
        private System.Windows.Forms.PictureBox pbImageFirst;
        private System.Windows.Forms.PictureBox pbImageSecond;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMaxTempFirst;
        private System.Windows.Forms.TextBox tbMinTempFirst;
        private System.Windows.Forms.TextBox tbMaxTempSecond;
        private System.Windows.Forms.TextBox tbMinTempSecond;
        private System.Windows.Forms.Label lbDayFirst;
        private System.Windows.Forms.Label lbDaySecond;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbWindDirection;
        private System.Windows.Forms.Label lbDayThird;
        private System.Windows.Forms.TextBox tbMinTempThird;
        private System.Windows.Forms.TextBox tbMaxTempThird;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pbImageThird;
        private System.Windows.Forms.Label lbDateFirst;
        private System.Windows.Forms.Label lbDateSecond;
        private System.Windows.Forms.Label lbDateThird;
        private System.Windows.Forms.Label lbWeatherFirst;
        private System.Windows.Forms.Label lbWeatherSecond;
        private System.Windows.Forms.Label lbWeatherThird;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

