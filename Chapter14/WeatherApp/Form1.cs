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



            var wc = new WebClient()
            {
                Encoding = Encoding.UTF8
            };



            //var dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/"+getCode()+".json");
            string strings = "https://www.jma.go.jp/bosai/forecast/data/forecast/" + getCode() + ".json";
            var dStrings = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/forecast/" + getCode() + ".json");
            var json = JsonConvert.DeserializeObject<Rootobject.Forecast>(dStrings);
            var ss = json.temperature.max;
            tbWeatherInfo.Text = ss.ToString();



            var list = new List<string>();





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
            using (var sr = new StreamReader(@"C:\Users\infosys\OneDrive - 学校法人太田アカデミー\ドキュメント\areacode.csv", Encoding.GetEncoding("Shift_JIS")))
            using (var csv = new CsvReader(sr, csvConfig)) {
                var record = csv.GetRecords<area>().ToList();
                var code = 0;
                foreach (var item in record) {
                    if (cbArea.SelectedItem.ToString() == item.areas.ToString()) {
                        tbWeatherInfo.Text = item.code.ToString();
                        code = item.code;
                    }
                }
                return code;

            }


            
        }
    }
}



