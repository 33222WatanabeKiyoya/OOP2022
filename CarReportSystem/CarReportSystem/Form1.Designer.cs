﻿
namespace CarReportSystem
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cbAuthor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rbToyota = new System.Windows.Forms.RadioButton();
            this.rbNissan = new System.Windows.Forms.RadioButton();
            this.rbHonda = new System.Windows.Forms.RadioButton();
            this.rbSubaru = new System.Windows.Forms.RadioButton();
            this.rbImport = new System.Windows.Forms.RadioButton();
            this.rbOther = new System.Windows.Forms.RadioButton();
            this.cbCarName = new System.Windows.Forms.ComboBox();
            this.tbReport = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btOpenPic = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.btRevision = new System.Windows.Forms.Button();
            this.btDeleteReport = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.ofdCarReportOpen = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.終了ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.色設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.データベース接続ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cdColorSelect = new System.Windows.Forms.ColorDialog();
            this.carReportDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.infosys202220DataSet = new CarReportSystem.infosys202220DataSet();
            this.carReportDBDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btNameSearch = new System.Windows.Forms.Button();
            this.btNameDelete = new System.Windows.Forms.Button();
            this.carReportDBTableAdapter = new CarReportSystem.infosys202220DataSetTableAdapters.CarReportDBTableAdapter();
            this.tableAdapterManager = new CarReportSystem.infosys202220DataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carReportDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202220DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carReportDBDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "日付：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "記録者：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "メーカー：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "車名：";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(78, 62);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 19);
            this.dtpDate.TabIndex = 1;
            // 
            // cbAuthor
            // 
            this.cbAuthor.FormattingEnabled = true;
            this.cbAuthor.Location = new System.Drawing.Point(78, 93);
            this.cbAuthor.Name = "cbAuthor";
            this.cbAuthor.Size = new System.Drawing.Size(267, 20);
            this.cbAuthor.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "レポート：";
            // 
            // rbToyota
            // 
            this.rbToyota.AutoSize = true;
            this.rbToyota.Location = new System.Drawing.Point(78, 136);
            this.rbToyota.Name = "rbToyota";
            this.rbToyota.Size = new System.Drawing.Size(47, 16);
            this.rbToyota.TabIndex = 3;
            this.rbToyota.TabStop = true;
            this.rbToyota.Text = "トヨタ";
            this.rbToyota.UseVisualStyleBackColor = true;
            // 
            // rbNissan
            // 
            this.rbNissan.AutoSize = true;
            this.rbNissan.Location = new System.Drawing.Point(131, 136);
            this.rbNissan.Name = "rbNissan";
            this.rbNissan.Size = new System.Drawing.Size(47, 16);
            this.rbNissan.TabIndex = 3;
            this.rbNissan.TabStop = true;
            this.rbNissan.Text = "日産";
            this.rbNissan.UseVisualStyleBackColor = true;
            // 
            // rbHonda
            // 
            this.rbHonda.AutoSize = true;
            this.rbHonda.Location = new System.Drawing.Point(184, 136);
            this.rbHonda.Name = "rbHonda";
            this.rbHonda.Size = new System.Drawing.Size(51, 16);
            this.rbHonda.TabIndex = 3;
            this.rbHonda.TabStop = true;
            this.rbHonda.Text = "ホンダ";
            this.rbHonda.UseVisualStyleBackColor = true;
            // 
            // rbSubaru
            // 
            this.rbSubaru.AutoSize = true;
            this.rbSubaru.Location = new System.Drawing.Point(241, 136);
            this.rbSubaru.Name = "rbSubaru";
            this.rbSubaru.Size = new System.Drawing.Size(52, 16);
            this.rbSubaru.TabIndex = 3;
            this.rbSubaru.TabStop = true;
            this.rbSubaru.Text = "スバル";
            this.rbSubaru.UseVisualStyleBackColor = true;
            // 
            // rbImport
            // 
            this.rbImport.AutoSize = true;
            this.rbImport.Location = new System.Drawing.Point(299, 136);
            this.rbImport.Name = "rbImport";
            this.rbImport.Size = new System.Drawing.Size(59, 16);
            this.rbImport.TabIndex = 3;
            this.rbImport.TabStop = true;
            this.rbImport.Text = "外国車";
            this.rbImport.UseVisualStyleBackColor = true;
            // 
            // rbOther
            // 
            this.rbOther.AutoSize = true;
            this.rbOther.Location = new System.Drawing.Point(363, 136);
            this.rbOther.Name = "rbOther";
            this.rbOther.Size = new System.Drawing.Size(54, 16);
            this.rbOther.TabIndex = 3;
            this.rbOther.TabStop = true;
            this.rbOther.Text = "その他";
            this.rbOther.UseVisualStyleBackColor = true;
            // 
            // cbCarName
            // 
            this.cbCarName.FormattingEnabled = true;
            this.cbCarName.Location = new System.Drawing.Point(78, 178);
            this.cbCarName.Name = "cbCarName";
            this.cbCarName.Size = new System.Drawing.Size(267, 20);
            this.cbCarName.TabIndex = 2;
            // 
            // tbReport
            // 
            this.tbReport.Location = new System.Drawing.Point(65, 225);
            this.tbReport.Multiline = true;
            this.tbReport.Name = "tbReport";
            this.tbReport.Size = new System.Drawing.Size(341, 127);
            this.tbReport.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(421, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "画像";
            // 
            // btOpenPic
            // 
            this.btOpenPic.Location = new System.Drawing.Point(666, 70);
            this.btOpenPic.Name = "btOpenPic";
            this.btOpenPic.Size = new System.Drawing.Size(75, 23);
            this.btOpenPic.TabIndex = 5;
            this.btOpenPic.Text = "開く...";
            this.btOpenPic.UseVisualStyleBackColor = true;
            this.btOpenPic.Click += new System.EventHandler(this.btOpenPic_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(666, 115);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 5;
            this.btDelete.Text = "削除";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Location = new System.Drawing.Point(423, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 199);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(423, 267);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 34);
            this.btAdd.TabIndex = 5;
            this.btAdd.Text = "追加";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btRevision
            // 
            this.btRevision.Location = new System.Drawing.Point(504, 267);
            this.btRevision.Name = "btRevision";
            this.btRevision.Size = new System.Drawing.Size(75, 34);
            this.btRevision.TabIndex = 5;
            this.btRevision.Text = "修正";
            this.btRevision.UseVisualStyleBackColor = true;
            this.btRevision.Click += new System.EventHandler(this.btRevision_Click);
            // 
            // btDeleteReport
            // 
            this.btDeleteReport.Location = new System.Drawing.Point(585, 267);
            this.btDeleteReport.Name = "btDeleteReport";
            this.btDeleteReport.Size = new System.Drawing.Size(75, 34);
            this.btDeleteReport.TabIndex = 5;
            this.btDeleteReport.Text = "削除";
            this.btDeleteReport.UseVisualStyleBackColor = true;
            this.btDeleteReport.Click += new System.EventHandler(this.btDeleteReport_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(12, 434);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(59, 34);
            this.btExit.TabIndex = 5;
            this.btExit.Text = "終了";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // ofdCarReportOpen
            // 
            this.ofdCarReportOpen.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルToolStripMenuItem
            // 
            this.ファイルToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.終了ToolStripMenuItem,
            this.色設定ToolStripMenuItem,
            this.データベース接続ToolStripMenuItem});
            this.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            this.ファイルToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ファイルToolStripMenuItem.Text = "ファイル";
            // 
            // 終了ToolStripMenuItem
            // 
            this.終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
            this.終了ToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.終了ToolStripMenuItem.Text = "終了";
            this.終了ToolStripMenuItem.Click += new System.EventHandler(this.終了ToolStripMenuItem_Click);
            // 
            // 色設定ToolStripMenuItem
            // 
            this.色設定ToolStripMenuItem.Name = "色設定ToolStripMenuItem";
            this.色設定ToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.色設定ToolStripMenuItem.Text = "色設定";
            this.色設定ToolStripMenuItem.Click += new System.EventHandler(this.色設定ToolStripMenuItem_Click);
            // 
            // データベース接続ToolStripMenuItem
            // 
            this.データベース接続ToolStripMenuItem.Name = "データベース接続ToolStripMenuItem";
            this.データベース接続ToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.データベース接続ToolStripMenuItem.Text = "データベース接続";
            this.データベース接続ToolStripMenuItem.Click += new System.EventHandler(this.データベース接続ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // carReportDBBindingSource
            // 
            this.carReportDBBindingSource.DataMember = "CarReportDB";
            this.carReportDBBindingSource.DataSource = this.infosys202220DataSet;
            // 
            // infosys202220DataSet
            // 
            this.infosys202220DataSet.DataSetName = "infosys202220DataSet";
            this.infosys202220DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carReportDBDataGridView
            // 
            this.carReportDBDataGridView.AllowUserToAddRows = false;
            this.carReportDBDataGridView.AutoGenerateColumns = false;
            this.carReportDBDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carReportDBDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.makerDataGridViewTextBoxColumn,
            this.carNameDataGridViewTextBoxColumn,
            this.reportDataGridViewTextBoxColumn,
            this.imageDataGridViewImageColumn});
            this.carReportDBDataGridView.DataSource = this.carReportDBBindingSource;
            this.carReportDBDataGridView.Location = new System.Drawing.Point(76, 434);
            this.carReportDBDataGridView.Name = "carReportDBDataGridView";
            this.carReportDBDataGridView.ReadOnly = true;
            this.carReportDBDataGridView.RowTemplate.Height = 21;
            this.carReportDBDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.carReportDBDataGridView.Size = new System.Drawing.Size(710, 138);
            this.carReportDBDataGridView.TabIndex = 29;
            this.carReportDBDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.carReportDBDataGridView_DataError);
            this.carReportDBDataGridView.Click += new System.EventHandler(this.carReportDBDataGridView_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            this.authorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // makerDataGridViewTextBoxColumn
            // 
            this.makerDataGridViewTextBoxColumn.DataPropertyName = "Maker";
            this.makerDataGridViewTextBoxColumn.HeaderText = "Maker";
            this.makerDataGridViewTextBoxColumn.Name = "makerDataGridViewTextBoxColumn";
            this.makerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carNameDataGridViewTextBoxColumn
            // 
            this.carNameDataGridViewTextBoxColumn.DataPropertyName = "CarName";
            this.carNameDataGridViewTextBoxColumn.HeaderText = "CarName";
            this.carNameDataGridViewTextBoxColumn.Name = "carNameDataGridViewTextBoxColumn";
            this.carNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reportDataGridViewTextBoxColumn
            // 
            this.reportDataGridViewTextBoxColumn.DataPropertyName = "Report";
            this.reportDataGridViewTextBoxColumn.HeaderText = "Report";
            this.reportDataGridViewTextBoxColumn.Name = "reportDataGridViewTextBoxColumn";
            this.reportDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imageDataGridViewImageColumn
            // 
            this.imageDataGridViewImageColumn.DataPropertyName = "Image";
            this.imageDataGridViewImageColumn.HeaderText = "Image";
            this.imageDataGridViewImageColumn.Name = "imageDataGridViewImageColumn";
            this.imageDataGridViewImageColumn.ReadOnly = true;
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(92, 376);
            this.tbSearch.Multiline = true;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(275, 33);
            this.tbSearch.TabIndex = 30;
            // 
            // btNameSearch
            // 
            this.btNameSearch.Location = new System.Drawing.Point(12, 374);
            this.btNameSearch.Name = "btNameSearch";
            this.btNameSearch.Size = new System.Drawing.Size(63, 35);
            this.btNameSearch.TabIndex = 32;
            this.btNameSearch.Text = "検索";
            this.btNameSearch.UseVisualStyleBackColor = true;
            this.btNameSearch.Click += new System.EventHandler(this.btNameSearch_Click);
            // 
            // btNameDelete
            // 
            this.btNameDelete.Location = new System.Drawing.Point(404, 376);
            this.btNameDelete.Name = "btNameDelete";
            this.btNameDelete.Size = new System.Drawing.Size(74, 33);
            this.btNameDelete.TabIndex = 33;
            this.btNameDelete.Text = "クリア";
            this.btNameDelete.UseVisualStyleBackColor = true;
            this.btNameDelete.Click += new System.EventHandler(this.btNameDelete_Click);
            // 
            // carReportDBTableAdapter
            // 
            this.carReportDBTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarReportDBTableAdapter = this.carReportDBTableAdapter;
            this.tableAdapterManager.UpdateOrder = CarReportSystem.infosys202220DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 654);
            this.Controls.Add(this.btNameDelete);
            this.Controls.Add(this.btNameSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.carReportDBDataGridView);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btDeleteReport);
            this.Controls.Add(this.btRevision);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btOpenPic);
            this.Controls.Add(this.tbReport);
            this.Controls.Add(this.rbOther);
            this.Controls.Add(this.rbImport);
            this.Controls.Add(this.rbSubaru);
            this.Controls.Add(this.rbHonda);
            this.Controls.Add(this.rbNissan);
            this.Controls.Add(this.rbToyota);
            this.Controls.Add(this.cbCarName);
            this.Controls.Add(this.cbAuthor);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carReportDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202220DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carReportDBDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cbAuthor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbToyota;
        private System.Windows.Forms.RadioButton rbNissan;
        private System.Windows.Forms.RadioButton rbHonda;
        private System.Windows.Forms.RadioButton rbSubaru;
        private System.Windows.Forms.RadioButton rbImport;
        private System.Windows.Forms.RadioButton rbOther;
        private System.Windows.Forms.ComboBox cbCarName;
        private System.Windows.Forms.TextBox tbReport;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btOpenPic;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btRevision;
        private System.Windows.Forms.Button btDeleteReport;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.OpenFileDialog ofdCarReportOpen;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ColorDialog cdColorSelect;
        private System.Windows.Forms.ToolStripMenuItem ファイルToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 終了ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 色設定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private infosys202220DataSet infosys202220DataSet;
        private System.Windows.Forms.BindingSource carReportDBBindingSource;
        private infosys202220DataSetTableAdapters.CarReportDBTableAdapter carReportDBTableAdapter;
        private infosys202220DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView carReportDBDataGridView;
        private System.Windows.Forms.ToolStripMenuItem データベース接続ToolStripMenuItem;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btNameSearch;
        private System.Windows.Forms.Button btNameDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn makerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
    }
}
