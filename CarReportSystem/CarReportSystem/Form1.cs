using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace CarReportSystem {
    public partial class Form1 : Form {

        //設定所法保存用オブジェクト
        Settings settings = Settings.getInstance();

        //管理用リスト
        BindingList<CarReport> listCar = new BindingList<CarReport>();


        int mode = 0;

        public Form1() {
            InitializeComponent();
        }


        private void 設定ToolStripMenuItem_Click(object sender, EventArgs e) {
            if (cdColorSelect.ShowDialog() == DialogResult.OK) {
                BackColor = cdColorSelect.Color;
                settings.MainFormColor = cdColorSelect.Color.ToArgb();
            }
        }

        private void pbModeSelect_Click(object sender, EventArgs e) {
            pictureBox1.SizeMode = (PictureBoxSizeMode)mode;
            mode = mode < 4 ? ++mode : 0;
        }


        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {

            /*using (var writer = XmlWriter.Create("settings.xml")) {

                var serializer = new XmlSerializer(settings.GetType());
                serializer.Serialize(writer, settings);
            }*/
        }




        private void btExit_Click(object sender, EventArgs e) {
            //アプリケーションの終了
            Application.Exit();
        }


       

        private void Form1_Load(object sender, EventArgs e) {
            try {
                //設定ファイルを逆シリアル化（P307）して背景の色を設定
                using (var reader = XmlReader.Create("settings.xml")) {
                    var serializer = new XmlSerializer(typeof(Settings));
                    settings = serializer.Deserialize(reader) as Settings;
                    BackColor = Color.FromArgb(settings.MainFormColor);
                }
            }
            catch (Exception) {

            }

            EnabledCheck(); //マスク処理呼び出し

        }


        private string GetRadioButtonMaker() {

            if (rbToyota.Checked) {
                return "トヨタ";
            }

            if (rbNissan.Checked) {
                return "日産";
            }
            if (rbHonda.Checked) {
                return "ホンダ";
            }
            if (rbSubaru.Checked) {
                return "スバル";
            }
            if (rbOther.Checked) {
                return "外国車";
            }
            return "その他";

        }


        private void EnabledCheck() {
            if (carReportDBDataGridView.CurrentRow == null) {
                btRevision.Enabled = false;
                btDeleteReport.Enabled = false;
                btSave.Enabled = false;
            }
            else {
                btRevision.Enabled = true;
                btDeleteReport.Enabled = true;
                btSave.Enabled = true;
   
        }
    }

        private void setcbAuther(string company) {
            if (!cbAuthor.Items.Contains(company)) {
                cbAuthor.Items.Add(company);
            }
        }


        private void setcbCarName(string company) {
            if (!cbCarName.Items.Contains(company)) {
                cbCarName.Items.Add(company);
            }
        }


        //写真追加
        private void btOpenPic_Click(object sender, EventArgs e) {
            if (ofdCarReportOpen.ShowDialog() == DialogResult.OK) {
                pictureBox1.Image = Image.FromFile(ofdCarReportOpen.FileName);
            }
        }

        //写真削除
        private void btDelete_Click(object sender, EventArgs e) {
            pictureBox1.Image = null;
        }


        private void btAdd_Click(object sender, EventArgs e) {
            DataRow newRow = infosys202220DataSet.CarReportDB.NewRow();
            newRow[1] = dtpDate.Text;
            newRow[2] = cbAuthor.Text;
            newRow[3] = GetRadioButtonMaker();
            newRow[4] = cbCarName.Text;
            newRow[5] = tbReport.Text;



            newRow[6] = ImageToByteArray(pictureBox1.Image);


            infosys202220DataSet.CarReportDB.Rows.Add(newRow);

            this.carReportDBTableAdapter.Update(this.infosys202220DataSet.CarReportDB);

        }
            
        //バイト配列をImageオブジェクトに変換
        public static Image ByteArrayToImage(byte[] b) {

            ImageConverter imgconv = new ImageConverter();
            Image img = (Image)imgconv.ConvertFrom(b);
            return img;

        }
        //Imageオブジェクトをバイト配列に変換
        public static byte[] ImageToByteArray(Image img) {

            ImageConverter imgconv = new ImageConverter();
            byte[] b = (byte[])imgconv.ConvertTo(img, typeof(byte[]));

            return b;
        }


        private void btRevision_Click(object sender, EventArgs e) {
            carReportDBDataGridView.CurrentRow.Cells[1].Value = dtpDate.Value;
            carReportDBDataGridView.CurrentRow.Cells[2].Value = cbAuthor.Text;
            carReportDBDataGridView.CurrentRow.Cells[3].Value = GetRadioButtonMaker();
            carReportDBDataGridView.CurrentRow.Cells[4].Value = cbCarName.Text;
            carReportDBDataGridView.CurrentRow.Cells[5].Value = tbReport.Text;
            carReportDBDataGridView.CurrentRow.Cells[6].Value = pictureBox1.Image;


            this.Validate();
            this.carReportDBBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202220DataSet);

        }


        private void btDeleteReport_Click(object sender, EventArgs e) {
            carReportDBBindingSource.RemoveAt(carReportDBDataGridView.CurrentRow.Index);

        }

        private void データベース接続ToolStripMenuItem_Click(object sender, EventArgs e) {
            // TODO: このコード行はデータを 'infosys202200DataSet.AddressTable' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.carReportDBTableAdapter.Fill(this.infosys202220DataSet.CarReportDB);
        }

        //エラー回避
        private void carReportDBDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e) {

        }

        private void carReportDBDataGridView_Click(object sender, EventArgs e) {
            if (carReportDBDataGridView.CurrentRow == null) {
                return;
            }
            else {
                //データグリッドビューの選択レコードを各テキストボックスへ設定
                dtpDate.Value = (DateTime)carReportDBDataGridView.CurrentRow.Cells[1].Value;
                cbAuthor.Text = carReportDBDataGridView.CurrentRow.Cells[2].Value.ToString();
                setMakerRadioSet(carReportDBDataGridView.CurrentRow.Cells[3].Value.ToString());
                cbCarName.Text = carReportDBDataGridView.CurrentRow.Cells[4].Value.ToString();
                tbReport.Text = carReportDBDataGridView.CurrentRow.Cells[5].Value.ToString();

                //画像表示処理  DBNullじゃなかったら真
                if (!(carReportDBDataGridView.CurrentRow.Cells[6].Value is DBNull)) {
                    pictureBox1.Image = ByteArrayToImage((byte[])carReportDBDataGridView.CurrentRow.Cells[6].Value);
                }
                else {
                    pictureBox1.Image = null;
                }
            }

        }

        private void setMakerRadioSet(string maker) {

            switch (maker) {
                case "トヨタ":
                rbToyota.Checked = true;
                break;
                case "日産":
                rbNissan.Checked = true;
                break;
                case "ホンダ":
                rbHonda.Checked = true;
                break;
                case "スバル":
                rbSubaru.Checked = true;
                break;
                case "外国車":
                rbImport.Checked = true;
                break;
                case "その他":
                rbOther.Checked = true;
                break;
            }
        }


        private void btNameSarch_Click(object sender, EventArgs e) {
            carReportDBTableAdapter.FillByName(infosys202220DataSet.CarReportDB, tbSearch.Text);

        }


        private void btNameDelete_Click(object sender, EventArgs e) {
            tbSearch.Text = null;
            this.carReportDBTableAdapter.Fill(this.infosys202220DataSet.CarReportDB);
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.carReportDBBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202220DataSet);
        }

        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void 色設定ToolStripMenuItem_Click(object sender, EventArgs e) {
            if (cdColorSelect.ShowDialog() == DialogResult.OK) {
                BackColor = cdColorSelect.Color;
                settings.MainFormColor = cdColorSelect.Color.ToArgb();   //設定オブジェクトへセット
            }
        }

    }
}


