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
        Settings settings = new Settings();

        //管理用リスト
        BindingList<CarReport> listCar = new BindingList<CarReport>();


        int mode = 0;

        public Form1() {
            InitializeComponent();
            dataGridView1.DataSource = listCar;
        }

        private void btExit_Click(object sender, EventArgs e) {
            //アプリケーションの終了
            Application.Exit();
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

            using (var writer = XmlWriter.Create("settings.xml")) {

                var serializer = new XmlSerializer(settings.GetType());
                serializer.Serialize(writer, settings);
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            try {
                using (var reader = XmlReader.Create("settings.xml")) {

                    var serializer = new XmlSerializer(typeof(Settings));
                    settings = serializer.Deserialize(reader) as Settings;

                }
            }
            catch (Exception) {
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
            var newCar = new CarReport
            {
                Auther = cbAuthor.Text,
                CarName = cbCarName.Text,
                Report = tbReport.Text,
                Date = dtpDate.Value,
                Maker = GetCarMaker()

            };

            listCar.Add(newCar);
            dataGridView1.Rows[dataGridView1.RowCount - 1].Selected = true;

            //JudgeMask();
            setcbAuthor(cbAuthor.Text);
            setCbCarName(cbCarName.Text);


        }


        private void setcbAuthor(string author) {
            if (!cbAuthor.Items.Contains(author)) {


                cbAuthor.Items.Add(author);
            }
        }

        private void setCbCarName(string maker) {
            if (!cbCarName.Items.Contains(maker)) {


                cbCarName.Items.Add(maker);
            }
        }


        private CarReport.MakerGroup GetCarMaker() {

            if (rbToyota.Checked) {
                return CarReport.MakerGroup.トヨタ;
            }
            if (rbNissan.Checked) {
                return CarReport.MakerGroup.日産;
            }
            if (rbHonda.Checked) {
                return CarReport.MakerGroup.ホンダ;
            }
            if (rbSubaru.Checked) {
                return CarReport.MakerGroup.スバル;
            }
            if (rbImport.Checked) {
                return CarReport.MakerGroup.外国車;
            }
            return CarReport.MakerGroup.その他;

        }

        private void btRevision_Click(object sender, EventArgs e) {
            listCar[dataGridView1.CurrentRow.Index].Date = dtpDate.Value;
            listCar[dataGridView1.CurrentRow.Index].Auther = cbAuthor.Text;
            listCar[dataGridView1.CurrentRow.Index].Maker = GetCarMaker();
            listCar[dataGridView1.CurrentRow.Index].CarName = cbCarName.Text;
            listCar[dataGridView1.CurrentRow.Index].Report = tbReport.Text;
            listCar[dataGridView1.CurrentRow.Index].Picture = pictureBox1.Image;
            dataGridView1.Refresh();
        }

        //データグリッドビューに追加
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (dataGridView1.CurrentRow == null) return;

            int index = dataGridView1.CurrentRow.Index;

            cbCarName.Text = listCar[index].CarName;
            cbAuthor.Text = listCar[index].Auther;
            tbReport.Text = listCar[index].Report;
            pictureBox1.Image = listCar[index].Picture;


        }

        //削除
        private void btDelete2_Click(object sender, EventArgs e) {

            listCar.RemoveAt(dataGridView1.CurrentRow.Index);


            if (dataGridView1.CurrentRow == null) {
                btAdd.Enabled = false;
                btDelete.Enabled = false;

            }
        }




        //開く
        private void btOpen_Click_1(object sender, EventArgs e) {

            if (ofdCarReportOpen.ShowDialog() == DialogResult.OK) {

                try {
                    var bf = new BinaryFormatter();
                    using (FileStream fs = File.Open(ofdCarReportOpen.FileName, FileMode.Open, FileAccess.Read)) {

                        listCar = (BindingList<CarReport>)bf.Deserialize(fs);
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = listCar;

                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
                cbAuthor.Items.Clear();
                cbCarName.Items.Clear();

                foreach (var item in listCar.Select(p => p.Auther)) {
                    setcbAuthor(item);
                }

                foreach (var item in listCar.Select(p => p.CarName)) {
                    setCbCarName(item);
                }
            }
        }



        //保存
        private void btSave_Click(object sender, EventArgs e) {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) {

                try {
                    var bf = new BinaryFormatter();
                    using (FileStream fs = File.Open(ofdCarReportOpen.FileName, FileMode.Open, FileAccess.Read)) {

                        bf.Serialize(fs, listCar);
                    }

                }
                catch (Exception ex) {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void carReportDBBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.carReportDBBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202220DataSet);

        }

        private void Form1_Load_1(object sender, EventArgs e) {
            // TODO: このコード行はデータを 'infosys202220DataSet.CarReportDB' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.carReportDBTableAdapter.Fill(this.infosys202220DataSet.CarReportDB);

        }

        private void carReportDBBindingSource_CurrentChanged(object sender, EventArgs e) {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {

        }

        private void データベース接続ToolStripMenuItem_Click(object sender, EventArgs e) {
            // TODO: このコード行はデータを 'infosys202200DataSet.AddressTable' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.carReportDBTableAdapter.Fill(this.infosys202220DataSet.CarReportDB);
       }
    }
}


