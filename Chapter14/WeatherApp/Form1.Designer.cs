
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbArea = new System.Windows.Forms.ComboBox();
            this.btWeatherGet = new System.Windows.Forms.Button();
            this.lbDayFirst = new System.Windows.Forms.Label();
            this.lbDateFirst = new System.Windows.Forms.Label();
            this.lbDaySecond = new System.Windows.Forms.Label();
            this.lbDateSecond = new System.Windows.Forms.Label();
            this.lbDayThird = new System.Windows.Forms.Label();
            this.lbDateThird = new System.Windows.Forms.Label();
            this.ImageFirst = new System.Windows.Forms.PictureBox();
            this.ImageSecond = new System.Windows.Forms.PictureBox();
            this.ImageThird = new System.Windows.Forms.PictureBox();
            this.WeatherFirst = new System.Windows.Forms.Label();
            this.WeatherSecond = new System.Windows.Forms.Label();
            this.WeatherThird = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.MaxTemp1 = new System.Windows.Forms.TextBox();
            this.MinTemp1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.MaxTemp2 = new System.Windows.Forms.TextBox();
            this.MinTemp2 = new System.Windows.Forms.TextBox();
            this.MaxTemp3 = new System.Windows.Forms.TextBox();
            this.MinTemp3 = new System.Windows.Forms.TextBox();
            this.WindDirection = new System.Windows.Forms.TextBox();
            this.WeatherInfo = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImageFirst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageThird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(31, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "地域選択";
            // 
            // cbArea
            // 
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
            this.cbArea.Location = new System.Drawing.Point(109, 28);
            this.cbArea.Name = "cbArea";
            this.cbArea.Size = new System.Drawing.Size(169, 20);
            this.cbArea.TabIndex = 1;
            // 
            // btWeatherGet
            // 
            this.btWeatherGet.Location = new System.Drawing.Point(315, 20);
            this.btWeatherGet.Name = "btWeatherGet";
            this.btWeatherGet.Size = new System.Drawing.Size(92, 45);
            this.btWeatherGet.TabIndex = 2;
            this.btWeatherGet.Text = "取得";
            this.btWeatherGet.UseVisualStyleBackColor = true;
            this.btWeatherGet.Click += new System.EventHandler(this.btWeatherGet_Click);
            // 
            // lbDayFirst
            // 
            this.lbDayFirst.AutoSize = true;
            this.lbDayFirst.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbDayFirst.Location = new System.Drawing.Point(32, 90);
            this.lbDayFirst.Name = "lbDayFirst";
            this.lbDayFirst.Size = new System.Drawing.Size(0, 16);
            this.lbDayFirst.TabIndex = 3;
            // 
            // lbDateFirst
            // 
            this.lbDateFirst.AutoSize = true;
            this.lbDateFirst.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbDateFirst.Location = new System.Drawing.Point(185, 90);
            this.lbDateFirst.Name = "lbDateFirst";
            this.lbDateFirst.Size = new System.Drawing.Size(0, 16);
            this.lbDateFirst.TabIndex = 4;
            // 
            // lbDaySecond
            // 
            this.lbDaySecond.AutoSize = true;
            this.lbDaySecond.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbDaySecond.Location = new System.Drawing.Point(313, 90);
            this.lbDaySecond.Name = "lbDaySecond";
            this.lbDaySecond.Size = new System.Drawing.Size(0, 16);
            this.lbDaySecond.TabIndex = 5;
            // 
            // lbDateSecond
            // 
            this.lbDateSecond.AutoSize = true;
            this.lbDateSecond.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbDateSecond.Location = new System.Drawing.Point(405, 90);
            this.lbDateSecond.Name = "lbDateSecond";
            this.lbDateSecond.Size = new System.Drawing.Size(0, 16);
            this.lbDateSecond.TabIndex = 6;
            // 
            // lbDayThird
            // 
            this.lbDayThird.AutoSize = true;
            this.lbDayThird.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbDayThird.Location = new System.Drawing.Point(567, 90);
            this.lbDayThird.Name = "lbDayThird";
            this.lbDayThird.Size = new System.Drawing.Size(0, 16);
            this.lbDayThird.TabIndex = 7;
            // 
            // lbDateThird
            // 
            this.lbDateThird.AutoSize = true;
            this.lbDateThird.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbDateThird.Location = new System.Drawing.Point(635, 90);
            this.lbDateThird.Name = "lbDateThird";
            this.lbDateThird.Size = new System.Drawing.Size(0, 16);
            this.lbDateThird.TabIndex = 8;
            // 
            // ImageFirst
            // 
            this.ImageFirst.Location = new System.Drawing.Point(34, 122);
            this.ImageFirst.Name = "ImageFirst";
            this.ImageFirst.Size = new System.Drawing.Size(226, 169);
            this.ImageFirst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageFirst.TabIndex = 9;
            this.ImageFirst.TabStop = false;
            // 
            // ImageSecond
            // 
            this.ImageSecond.Location = new System.Drawing.Point(281, 122);
            this.ImageSecond.Name = "ImageSecond";
            this.ImageSecond.Size = new System.Drawing.Size(202, 169);
            this.ImageSecond.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageSecond.TabIndex = 10;
            this.ImageSecond.TabStop = false;
            // 
            // ImageThird
            // 
            this.ImageThird.Location = new System.Drawing.Point(525, 122);
            this.ImageThird.Name = "ImageThird";
            this.ImageThird.Size = new System.Drawing.Size(210, 169);
            this.ImageThird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageThird.TabIndex = 11;
            this.ImageThird.TabStop = false;
            // 
            // WeatherFirst
            // 
            this.WeatherFirst.AutoSize = true;
            this.WeatherFirst.Location = new System.Drawing.Point(107, 294);
            this.WeatherFirst.Name = "WeatherFirst";
            this.WeatherFirst.Size = new System.Drawing.Size(0, 12);
            this.WeatherFirst.TabIndex = 12;
            // 
            // WeatherSecond
            // 
            this.WeatherSecond.AutoSize = true;
            this.WeatherSecond.Location = new System.Drawing.Point(349, 294);
            this.WeatherSecond.Name = "WeatherSecond";
            this.WeatherSecond.Size = new System.Drawing.Size(0, 12);
            this.WeatherSecond.TabIndex = 13;
            // 
            // WeatherThird
            // 
            this.WeatherThird.AutoSize = true;
            this.WeatherThird.Location = new System.Drawing.Point(605, 294);
            this.WeatherThird.Name = "WeatherThird";
            this.WeatherThird.Size = new System.Drawing.Size(0, 12);
            this.WeatherThird.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label11.Location = new System.Drawing.Point(18, 332);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 16);
            this.label11.TabIndex = 15;
            this.label11.Text = "最高気温";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label12.Location = new System.Drawing.Point(18, 393);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 16);
            this.label12.TabIndex = 16;
            this.label12.Text = "最低気温";
            // 
            // MaxTemp1
            // 
            this.MaxTemp1.Location = new System.Drawing.Point(96, 329);
            this.MaxTemp1.Name = "MaxTemp1";
            this.MaxTemp1.Size = new System.Drawing.Size(100, 19);
            this.MaxTemp1.TabIndex = 17;
            // 
            // MinTemp1
            // 
            this.MinTemp1.Location = new System.Drawing.Point(96, 393);
            this.MinTemp1.Name = "MinTemp1";
            this.MinTemp1.Size = new System.Drawing.Size(100, 19);
            this.MinTemp1.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label13.Location = new System.Drawing.Point(297, 332);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 16);
            this.label13.TabIndex = 19;
            this.label13.Text = "最高気温";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label14.Location = new System.Drawing.Point(297, 392);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 16);
            this.label14.TabIndex = 20;
            this.label14.Text = "最低気温";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label15.Location = new System.Drawing.Point(569, 329);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 16);
            this.label15.TabIndex = 21;
            this.label15.Text = "最高気温";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label16.Location = new System.Drawing.Point(566, 392);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 16);
            this.label16.TabIndex = 22;
            this.label16.Text = "最低気温";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label17.Location = new System.Drawing.Point(19, 463);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 16);
            this.label17.TabIndex = 23;
            this.label17.Text = "風向";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label18.Location = new System.Drawing.Point(306, 456);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 16);
            this.label18.TabIndex = 24;
            this.label18.Text = "天気概況";
            // 
            // MaxTemp2
            // 
            this.MaxTemp2.Location = new System.Drawing.Point(394, 329);
            this.MaxTemp2.Name = "MaxTemp2";
            this.MaxTemp2.Size = new System.Drawing.Size(100, 19);
            this.MaxTemp2.TabIndex = 25;
            // 
            // MinTemp2
            // 
            this.MinTemp2.Location = new System.Drawing.Point(394, 389);
            this.MinTemp2.Name = "MinTemp2";
            this.MinTemp2.Size = new System.Drawing.Size(100, 19);
            this.MinTemp2.TabIndex = 26;
            // 
            // MaxTemp3
            // 
            this.MaxTemp3.Location = new System.Drawing.Point(662, 326);
            this.MaxTemp3.Name = "MaxTemp3";
            this.MaxTemp3.Size = new System.Drawing.Size(100, 19);
            this.MaxTemp3.TabIndex = 27;
            // 
            // MinTemp3
            // 
            this.MinTemp3.Location = new System.Drawing.Point(662, 389);
            this.MinTemp3.Name = "MinTemp3";
            this.MinTemp3.Size = new System.Drawing.Size(100, 19);
            this.MinTemp3.TabIndex = 28;
            // 
            // WindDirection
            // 
            this.WindDirection.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.WindDirection.Location = new System.Drawing.Point(79, 463);
            this.WindDirection.Multiline = true;
            this.WindDirection.Name = "WindDirection";
            this.WindDirection.Size = new System.Drawing.Size(171, 87);
            this.WindDirection.TabIndex = 29;
            // 
            // WeatherInfo
            // 
            this.WeatherInfo.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.WeatherInfo.Location = new System.Drawing.Point(407, 460);
            this.WeatherInfo.Multiline = true;
            this.WeatherInfo.Name = "WeatherInfo";
            this.WeatherInfo.Size = new System.Drawing.Size(416, 100);
            this.WeatherInfo.TabIndex = 30;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WeatherApp.Properties.Resources.R;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(908, 582);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 585);
            this.Controls.Add(this.WeatherInfo);
            this.Controls.Add(this.WindDirection);
            this.Controls.Add(this.MinTemp3);
            this.Controls.Add(this.MaxTemp3);
            this.Controls.Add(this.MinTemp2);
            this.Controls.Add(this.MaxTemp2);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.MinTemp1);
            this.Controls.Add(this.MaxTemp1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.WeatherThird);
            this.Controls.Add(this.WeatherSecond);
            this.Controls.Add(this.WeatherFirst);
            this.Controls.Add(this.ImageThird);
            this.Controls.Add(this.ImageSecond);
            this.Controls.Add(this.ImageFirst);
            this.Controls.Add(this.lbDateThird);
            this.Controls.Add(this.lbDayThird);
            this.Controls.Add(this.lbDateSecond);
            this.Controls.Add(this.lbDaySecond);
            this.Controls.Add(this.lbDateFirst);
            this.Controls.Add(this.lbDayFirst);
            this.Controls.Add(this.btWeatherGet);
            this.Controls.Add(this.cbArea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImageFirst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageThird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbArea;
        private System.Windows.Forms.Button btWeatherGet;
        private System.Windows.Forms.Label lbDayFirst;
        private System.Windows.Forms.Label lbDateFirst;
        private System.Windows.Forms.Label lbDaySecond;
        private System.Windows.Forms.Label lbDateSecond;
        private System.Windows.Forms.Label lbDayThird;
        private System.Windows.Forms.Label lbDateThird;
        private System.Windows.Forms.PictureBox ImageFirst;
        private System.Windows.Forms.PictureBox ImageSecond;
        private System.Windows.Forms.PictureBox ImageThird;
        private System.Windows.Forms.Label WeatherFirst;
        private System.Windows.Forms.Label WeatherSecond;
        private System.Windows.Forms.Label WeatherThird;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox MaxTemp1;
        private System.Windows.Forms.TextBox MinTemp1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox MaxTemp2;
        private System.Windows.Forms.TextBox MinTemp2;
        private System.Windows.Forms.TextBox MaxTemp3;
        private System.Windows.Forms.TextBox MinTemp3;
        private System.Windows.Forms.TextBox WindDirection;
        private System.Windows.Forms.TextBox WeatherInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

