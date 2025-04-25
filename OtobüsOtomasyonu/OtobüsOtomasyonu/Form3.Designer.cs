namespace OtobüsOtomasyonu
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxBusPlate = new System.Windows.Forms.TextBox();
            this.textBoxRoute = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerDepartureDate = new System.Windows.Forms.DateTimePicker();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxBusType = new System.Windows.Forms.ComboBox();
            this.comboBoxDepartureTime = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.seferIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otobusPlakasiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seferGuzergahiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seferTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otobusTuruDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seferSaatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seferlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otobusfirmasi2DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otobusfirmasi2DataSet = new OtobüsOtomasyonu.otobusfirmasi2DataSet();
            this.seferlerTableAdapter = new OtobüsOtomasyonu.otobusfirmasi2DataSetTableAdapters.SeferlerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seferlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otobusfirmasi2DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otobusfirmasi2DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OtobüsOtomasyonu.Properties.Resources.hero_image_kamil_koc_mobile;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(803, 458);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxId
            // 
            this.textBoxId.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.textBoxId.Location = new System.Drawing.Point(255, 38);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(163, 22);
            this.textBoxId.TabIndex = 1;
            // 
            // textBoxBusPlate
            // 
            this.textBoxBusPlate.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.textBoxBusPlate.Location = new System.Drawing.Point(255, 93);
            this.textBoxBusPlate.Name = "textBoxBusPlate";
            this.textBoxBusPlate.Size = new System.Drawing.Size(163, 22);
            this.textBoxBusPlate.TabIndex = 2;
            // 
            // textBoxRoute
            // 
            this.textBoxRoute.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.textBoxRoute.Location = new System.Drawing.Point(255, 151);
            this.textBoxRoute.Name = "textBoxRoute";
            this.textBoxRoute.Size = new System.Drawing.Size(163, 22);
            this.textBoxRoute.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label1.Location = new System.Drawing.Point(86, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sefer ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label2.Location = new System.Drawing.Point(86, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Otobüs Plakası ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label3.Location = new System.Drawing.Point(84, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sefer Güzergahı";
            // 
            // dateTimePickerDepartureDate
            // 
            this.dateTimePickerDepartureDate.CalendarMonthBackground = System.Drawing.Color.PaleGoldenrod;
            this.dateTimePickerDepartureDate.CalendarTitleBackColor = System.Drawing.Color.PaleGoldenrod;
            this.dateTimePickerDepartureDate.CalendarTitleForeColor = System.Drawing.Color.PaleGoldenrod;
            this.dateTimePickerDepartureDate.Location = new System.Drawing.Point(255, 198);
            this.dateTimePickerDepartureDate.Name = "dateTimePickerDepartureDate";
            this.dateTimePickerDepartureDate.Size = new System.Drawing.Size(163, 22);
            this.dateTimePickerDepartureDate.TabIndex = 9;
            this.dateTimePickerDepartureDate.ValueChanged += new System.EventHandler(this.dateTimePickerDepartureDate_ValueChanged);
            // 
            // buttonEkle
            // 
            this.buttonEkle.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.buttonEkle.Location = new System.Drawing.Point(71, 268);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(130, 67);
            this.buttonEkle.TabIndex = 10;
            this.buttonEkle.Text = "Veri Ekle";
            this.buttonEkle.UseVisualStyleBackColor = false;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.buttonSil.Location = new System.Drawing.Point(270, 268);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(148, 65);
            this.buttonSil.TabIndex = 11;
            this.buttonSil.Text = "Veri Sil";
            this.buttonSil.UseVisualStyleBackColor = false;
            this.buttonSil.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.buttonUpdate.Location = new System.Drawing.Point(481, 268);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(161, 65);
            this.buttonUpdate.TabIndex = 12;
            this.buttonUpdate.Text = "Güncelle";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label5.Location = new System.Drawing.Point(108, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Sefer Tarihi ";
            // 
            // comboBoxBusType
            // 
            this.comboBoxBusType.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.comboBoxBusType.FormattingEnabled = true;
            this.comboBoxBusType.Items.AddRange(new object[] {
            "Standart",
            "Lüks"});
            this.comboBoxBusType.Location = new System.Drawing.Point(527, 50);
            this.comboBoxBusType.Name = "comboBoxBusType";
            this.comboBoxBusType.Size = new System.Drawing.Size(145, 24);
            this.comboBoxBusType.TabIndex = 14;
            // 
            // comboBoxDepartureTime
            // 
            this.comboBoxDepartureTime.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.comboBoxDepartureTime.FormattingEnabled = true;
            this.comboBoxDepartureTime.Items.AddRange(new object[] {
            "08:00",
            "10:00",
            "12:00"});
            this.comboBoxDepartureTime.Location = new System.Drawing.Point(527, 107);
            this.comboBoxDepartureTime.Name = "comboBoxDepartureTime";
            this.comboBoxDepartureTime.Size = new System.Drawing.Size(145, 24);
            this.comboBoxDepartureTime.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label6.Location = new System.Drawing.Point(696, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Otobüs Türü";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label7.Location = new System.Drawing.Point(700, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Sefer Saati ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.seferIDDataGridViewTextBoxColumn,
            this.otobusPlakasiDataGridViewTextBoxColumn,
            this.seferGuzergahiDataGridViewTextBoxColumn,
            this.seferTarihiDataGridViewTextBoxColumn,
            this.otobusTuruDataGridViewTextBoxColumn,
            this.seferSaatiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.seferlerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 366);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(789, 72);
            this.dataGridView1.TabIndex = 18;
            // 
            // seferIDDataGridViewTextBoxColumn
            // 
            this.seferIDDataGridViewTextBoxColumn.DataPropertyName = "SeferID";
            this.seferIDDataGridViewTextBoxColumn.HeaderText = "SeferID";
            this.seferIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.seferIDDataGridViewTextBoxColumn.Name = "seferIDDataGridViewTextBoxColumn";
            this.seferIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.seferIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // otobusPlakasiDataGridViewTextBoxColumn
            // 
            this.otobusPlakasiDataGridViewTextBoxColumn.DataPropertyName = "OtobusPlakasi";
            this.otobusPlakasiDataGridViewTextBoxColumn.HeaderText = "OtobusPlakasi";
            this.otobusPlakasiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.otobusPlakasiDataGridViewTextBoxColumn.Name = "otobusPlakasiDataGridViewTextBoxColumn";
            this.otobusPlakasiDataGridViewTextBoxColumn.Width = 125;
            // 
            // seferGuzergahiDataGridViewTextBoxColumn
            // 
            this.seferGuzergahiDataGridViewTextBoxColumn.DataPropertyName = "SeferGuzergahi";
            this.seferGuzergahiDataGridViewTextBoxColumn.HeaderText = "SeferGuzergahi";
            this.seferGuzergahiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.seferGuzergahiDataGridViewTextBoxColumn.Name = "seferGuzergahiDataGridViewTextBoxColumn";
            this.seferGuzergahiDataGridViewTextBoxColumn.Width = 125;
            // 
            // seferTarihiDataGridViewTextBoxColumn
            // 
            this.seferTarihiDataGridViewTextBoxColumn.DataPropertyName = "SeferTarihi";
            this.seferTarihiDataGridViewTextBoxColumn.HeaderText = "SeferTarihi";
            this.seferTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.seferTarihiDataGridViewTextBoxColumn.Name = "seferTarihiDataGridViewTextBoxColumn";
            this.seferTarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // otobusTuruDataGridViewTextBoxColumn
            // 
            this.otobusTuruDataGridViewTextBoxColumn.DataPropertyName = "OtobusTuru";
            this.otobusTuruDataGridViewTextBoxColumn.HeaderText = "OtobusTuru";
            this.otobusTuruDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.otobusTuruDataGridViewTextBoxColumn.Name = "otobusTuruDataGridViewTextBoxColumn";
            this.otobusTuruDataGridViewTextBoxColumn.Width = 125;
            // 
            // seferSaatiDataGridViewTextBoxColumn
            // 
            this.seferSaatiDataGridViewTextBoxColumn.DataPropertyName = "SeferSaati";
            this.seferSaatiDataGridViewTextBoxColumn.HeaderText = "SeferSaati";
            this.seferSaatiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.seferSaatiDataGridViewTextBoxColumn.Name = "seferSaatiDataGridViewTextBoxColumn";
            this.seferSaatiDataGridViewTextBoxColumn.Width = 125;
            // 
            // seferlerBindingSource
            // 
            this.seferlerBindingSource.DataMember = "Seferler";
            this.seferlerBindingSource.DataSource = this.otobusfirmasi2DataSetBindingSource;
            // 
            // otobusfirmasi2DataSetBindingSource
            // 
            this.otobusfirmasi2DataSetBindingSource.DataSource = this.otobusfirmasi2DataSet;
            this.otobusfirmasi2DataSetBindingSource.Position = 0;
            // 
            // otobusfirmasi2DataSet
            // 
            this.otobusfirmasi2DataSet.DataSetName = "otobusfirmasi2DataSet";
            this.otobusfirmasi2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // seferlerTableAdapter
            // 
            this.seferlerTableAdapter.ClearBeforeFill = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxDepartureTime);
            this.Controls.Add(this.comboBoxBusType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.buttonEkle);
            this.Controls.Add(this.dateTimePickerDepartureDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRoute);
            this.Controls.Add(this.textBoxBusPlate);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seferlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otobusfirmasi2DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otobusfirmasi2DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxBusPlate;
        private System.Windows.Forms.TextBox textBoxRoute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerDepartureDate;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxBusType;
        private System.Windows.Forms.ComboBox comboBoxDepartureTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource otobusfirmasi2DataSetBindingSource;
        private otobusfirmasi2DataSet otobusfirmasi2DataSet;
        private System.Windows.Forms.BindingSource seferlerBindingSource;
        private otobusfirmasi2DataSetTableAdapters.SeferlerTableAdapter seferlerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn seferIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otobusPlakasiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seferGuzergahiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seferTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otobusTuruDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seferSaatiDataGridViewTextBoxColumn;
    }
}