using CsvHelper;
using CsvHelper.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;


namespace WeatherApp {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btWeatherGet_Click(object sender, EventArgs e) {
            try {
                lbDateFirst.Text = getJsonData().forecasts[0].date.Substring(8, 2) + "日";
                lbDateSecond.Text = getJsonData().forecasts[1].date.Substring(8, 2) + "日";
                lbDateThird.Text = getJsonData().forecasts[2].date.Substring(8, 2) + "日";

                lbDayFirst.Text = DateTime.Today.ToString("dddd");
                lbDaySecond.Text = DateTime.Today.AddDays(1).ToString("dddd");
                lbDayThird.Text = DateTime.Today.AddDays(2).ToString("dddd");

                lbWeatherFirst.Text = getJsonData().forecasts[0].telop;
                lbWeatherSecond.Text = getJsonData().forecasts[1].telop;
                lbWeatherThird.Text = getJsonData().forecasts[2].telop;

                pbImageFirst.ImageLocation = getJsonData().forecasts[0].image.url.Replace("svg", "png");
                pbImageSecond.ImageLocation = getJsonData().forecasts[1].image.url.Replace("svg", "png");
                pbImageThird.ImageLocation = getJsonData().forecasts[2].image.url.Replace("svg", "png");

                tbMaxTempFirst.Text = getJsonData().forecasts[0].temperature.max.celsius;
                tbMaxTempSecond.Text = getJsonData().forecasts[1].temperature.max.celsius;
                tbMaxTempThird.Text = getJsonData().forecasts[2].temperature.max.celsius;

                tbMinTempFirst.Text = getJsonData().forecasts[0].temperature.min.celsius;
                tbMinTempSecond.Text = getJsonData().forecasts[1].temperature.min.celsius;
                tbMinTempThird.Text = getJsonData().forecasts[2].temperature.min.celsius;

                tbWeatherInfo.Text = getJsonData().description.text;

                tbWindDirection.Text = getJsonData().forecasts[0].detail.wind;
            }
            catch (Exception) {

                MessageBox.Show("地域を選択してください");
            }     
        }


        public Rootobject getJsonData() {
            var wc = new WebClient()
            {
                Encoding = Encoding.UTF8
            };

            string code = getCode().ToString();

            switch (getCode()) {
                case
                    16010:
                code = "0" + code;
                break;

                case
                    20010:
                code = "0" + code;
                break;

                case
                    30010:
                code = "0" + code;
                break;

                case
                    40010:
                code = "0" + code;
                break;

                case
                    50010:
                code = "0" + code;
                break;

                case
                    60010:
                code = "0" + code;
                break;

                case
                    70010:
                code = "0" + code;
                break;

                case
                    80010:
                code = "0" + code;
                break;

                case
                    90010:
                code = "0" + code;
                break;
             
            }

            var dStrings = wc.DownloadString("https://weather.tsukumijima.net/api/forecast?city=" + code);
            var json = JsonConvert.DeserializeObject<Rootobject>(dStrings);
            return json;


           

        }
        

        private int getCode() {
            var csvConfig = new CsvConfiguration(CultureInfo.CurrentCulture)
            {
                HasHeaderRecord = false,
                Comment = '#',
                AllowComments = true,
                Delimiter = ",",
            };

            //読み込むCSVファイルを開く
            using (var sr = new StreamReader(@"areacode.csv", Encoding.GetEncoding("Shift_JIS")))
            using (var csv = new CsvReader(sr, csvConfig)) {
                var record = csv.GetRecords<area>().ToList();
                var code = 0;
                foreach (var item in record) {
                    if (cbArea.SelectedItem.ToString()  == item.areas.ToString()) {
                        code = item.code;
                    }
                }
                return code;
            }  
        }

        private void Form1_Load(object sender, EventArgs e) {
            this.Text = "天気";
        }
    }
}



