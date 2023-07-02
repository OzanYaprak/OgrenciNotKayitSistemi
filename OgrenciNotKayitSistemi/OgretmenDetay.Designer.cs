namespace OgrenciNotKayitSistemi
{
    partial class OgretmenDetay
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TBSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MaskedTBNumara = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TBVize = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.TBBütünleme = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TBFinal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.notKayitDBDataSet = new OgrenciNotKayitSistemi.NotKayitDBDataSet();
            this.dersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dersTableAdapter = new OgrenciNotKayitSistemi.NotKayitDBDataSetTableAdapters.DersTableAdapter();
            this.ogrenciIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciVizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciFinalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciButunlemeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notOrtalamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.LBLOgrenciOrtalama = new System.Windows.Forms.Label();
            this.LBLKalanOgrenci = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LBLGecenOgrenci = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notKayitDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dersBindingSource)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.TBSoyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TBAd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.MaskedTBNumara);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(20, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(266, 263);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Ekle";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGreen;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(65, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TBSoyad
            // 
            this.TBSoyad.BackColor = System.Drawing.SystemColors.Control;
            this.TBSoyad.Location = new System.Drawing.Point(105, 132);
            this.TBSoyad.Name = "TBSoyad";
            this.TBSoyad.Size = new System.Drawing.Size(117, 27);
            this.TBSoyad.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(37, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Soyad:";
            // 
            // TBAd
            // 
            this.TBAd.BackColor = System.Drawing.SystemColors.Control;
            this.TBAd.Location = new System.Drawing.Point(105, 88);
            this.TBAd.Name = "TBAd";
            this.TBAd.Size = new System.Drawing.Size(117, 27);
            this.TBAd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(61, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ad:";
            // 
            // MaskedTBNumara
            // 
            this.MaskedTBNumara.BackColor = System.Drawing.SystemColors.Control;
            this.MaskedTBNumara.Location = new System.Drawing.Point(105, 47);
            this.MaskedTBNumara.Mask = "0000";
            this.MaskedTBNumara.Name = "MaskedTBNumara";
            this.MaskedTBNumara.Size = new System.Drawing.Size(117, 27);
            this.MaskedTBNumara.TabIndex = 1;
            this.MaskedTBNumara.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(21, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numara:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox2.Controls.Add(this.TBVize);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.TBBütünleme);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TBFinal);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(345, 19);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(266, 263);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Not Ekle";
            // 
            // TBVize
            // 
            this.TBVize.BackColor = System.Drawing.SystemColors.Control;
            this.TBVize.Location = new System.Drawing.Point(105, 50);
            this.TBVize.Name = "TBVize";
            this.TBVize.Size = new System.Drawing.Size(117, 27);
            this.TBVize.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkOrange;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(65, 181);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 32);
            this.button2.TabIndex = 6;
            this.button2.Text = "Güncelle";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TBBütünleme
            // 
            this.TBBütünleme.BackColor = System.Drawing.SystemColors.Control;
            this.TBBütünleme.Location = new System.Drawing.Point(105, 132);
            this.TBBütünleme.Name = "TBBütünleme";
            this.TBBütünleme.Size = new System.Drawing.Size(117, 27);
            this.TBBütünleme.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(55, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Büt.:";
            // 
            // TBFinal
            // 
            this.TBFinal.BackColor = System.Drawing.SystemColors.Control;
            this.TBFinal.Location = new System.Drawing.Point(105, 88);
            this.TBFinal.Name = "TBFinal";
            this.TBFinal.Size = new System.Drawing.Size(117, 27);
            this.TBFinal.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(50, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Final:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(54, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Vize:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(20, 299);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(913, 408);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sınav Notları";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogrenciIDDataGridViewTextBoxColumn,
            this.ogrenciNumberDataGridViewTextBoxColumn,
            this.ogrenciNameDataGridViewTextBoxColumn,
            this.ogrenciSurnameDataGridViewTextBoxColumn,
            this.ogrenciVizeDataGridViewTextBoxColumn,
            this.ogrenciFinalDataGridViewTextBoxColumn,
            this.ogrenciButunlemeDataGridViewTextBoxColumn,
            this.notOrtalamaDataGridViewTextBoxColumn,
            this.durumDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.dersBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(907, 382);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // notKayitDBDataSet
            // 
            this.notKayitDBDataSet.DataSetName = "NotKayitDBDataSet";
            this.notKayitDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dersBindingSource
            // 
            this.dersBindingSource.DataMember = "Ders";
            this.dersBindingSource.DataSource = this.notKayitDBDataSet;
            // 
            // dersTableAdapter
            // 
            this.dersTableAdapter.ClearBeforeFill = true;
            // 
            // ogrenciIDDataGridViewTextBoxColumn
            // 
            this.ogrenciIDDataGridViewTextBoxColumn.DataPropertyName = "OgrenciID";
            this.ogrenciIDDataGridViewTextBoxColumn.HeaderText = "OgrenciID";
            this.ogrenciIDDataGridViewTextBoxColumn.Name = "ogrenciIDDataGridViewTextBoxColumn";
            this.ogrenciIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ogrenciNumberDataGridViewTextBoxColumn
            // 
            this.ogrenciNumberDataGridViewTextBoxColumn.DataPropertyName = "OgrenciNumber";
            this.ogrenciNumberDataGridViewTextBoxColumn.HeaderText = "OgrenciNumber";
            this.ogrenciNumberDataGridViewTextBoxColumn.Name = "ogrenciNumberDataGridViewTextBoxColumn";
            // 
            // ogrenciNameDataGridViewTextBoxColumn
            // 
            this.ogrenciNameDataGridViewTextBoxColumn.DataPropertyName = "OgrenciName";
            this.ogrenciNameDataGridViewTextBoxColumn.HeaderText = "OgrenciName";
            this.ogrenciNameDataGridViewTextBoxColumn.Name = "ogrenciNameDataGridViewTextBoxColumn";
            // 
            // ogrenciSurnameDataGridViewTextBoxColumn
            // 
            this.ogrenciSurnameDataGridViewTextBoxColumn.DataPropertyName = "OgrenciSurname";
            this.ogrenciSurnameDataGridViewTextBoxColumn.HeaderText = "OgrenciSurname";
            this.ogrenciSurnameDataGridViewTextBoxColumn.Name = "ogrenciSurnameDataGridViewTextBoxColumn";
            // 
            // ogrenciVizeDataGridViewTextBoxColumn
            // 
            this.ogrenciVizeDataGridViewTextBoxColumn.DataPropertyName = "OgrenciVize";
            this.ogrenciVizeDataGridViewTextBoxColumn.HeaderText = "OgrenciVize";
            this.ogrenciVizeDataGridViewTextBoxColumn.Name = "ogrenciVizeDataGridViewTextBoxColumn";
            // 
            // ogrenciFinalDataGridViewTextBoxColumn
            // 
            this.ogrenciFinalDataGridViewTextBoxColumn.DataPropertyName = "OgrenciFinal";
            this.ogrenciFinalDataGridViewTextBoxColumn.HeaderText = "OgrenciFinal";
            this.ogrenciFinalDataGridViewTextBoxColumn.Name = "ogrenciFinalDataGridViewTextBoxColumn";
            // 
            // ogrenciButunlemeDataGridViewTextBoxColumn
            // 
            this.ogrenciButunlemeDataGridViewTextBoxColumn.DataPropertyName = "OgrenciButunleme";
            this.ogrenciButunlemeDataGridViewTextBoxColumn.HeaderText = "OgrenciButunleme";
            this.ogrenciButunlemeDataGridViewTextBoxColumn.Name = "ogrenciButunlemeDataGridViewTextBoxColumn";
            // 
            // notOrtalamaDataGridViewTextBoxColumn
            // 
            this.notOrtalamaDataGridViewTextBoxColumn.DataPropertyName = "NotOrtalama";
            this.notOrtalamaDataGridViewTextBoxColumn.HeaderText = "NotOrtalama";
            this.notOrtalamaDataGridViewTextBoxColumn.Name = "notOrtalamaDataGridViewTextBoxColumn";
            // 
            // durumDataGridViewCheckBoxColumn
            // 
            this.durumDataGridViewCheckBoxColumn.DataPropertyName = "Durum";
            this.durumDataGridViewCheckBoxColumn.HeaderText = "Durum";
            this.durumDataGridViewCheckBoxColumn.Name = "durumDataGridViewCheckBoxColumn";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox4.Controls.Add(this.LBLGecenOgrenci);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.LBLKalanOgrenci);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.LBLOgrenciOrtalama);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(667, 19);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox4.Size = new System.Drawing.Size(266, 263);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Genel Durum";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Teal;
            this.label9.Location = new System.Drawing.Point(12, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "Öğrenci Ortalaması:";
            // 
            // LBLOgrenciOrtalama
            // 
            this.LBLOgrenciOrtalama.AutoSize = true;
            this.LBLOgrenciOrtalama.ForeColor = System.Drawing.Color.Black;
            this.LBLOgrenciOrtalama.Location = new System.Drawing.Point(185, 72);
            this.LBLOgrenciOrtalama.Name = "LBLOgrenciOrtalama";
            this.LBLOgrenciOrtalama.Size = new System.Drawing.Size(28, 21);
            this.LBLOgrenciOrtalama.TabIndex = 5;
            this.LBLOgrenciOrtalama.Text = "00";
            // 
            // LBLKalanOgrenci
            // 
            this.LBLKalanOgrenci.AutoSize = true;
            this.LBLKalanOgrenci.ForeColor = System.Drawing.Color.Black;
            this.LBLKalanOgrenci.Location = new System.Drawing.Point(185, 154);
            this.LBLKalanOgrenci.Name = "LBLKalanOgrenci";
            this.LBLKalanOgrenci.Size = new System.Drawing.Size(28, 21);
            this.LBLKalanOgrenci.TabIndex = 7;
            this.LBLKalanOgrenci.Text = "00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(83, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 21);
            this.label8.TabIndex = 6;
            this.label8.Text = "Kalan Öğr.:";
            // 
            // LBLGecenOgrenci
            // 
            this.LBLGecenOgrenci.AutoSize = true;
            this.LBLGecenOgrenci.ForeColor = System.Drawing.Color.Black;
            this.LBLGecenOgrenci.Location = new System.Drawing.Point(185, 110);
            this.LBLGecenOgrenci.Name = "LBLGecenOgrenci";
            this.LBLGecenOgrenci.Size = new System.Drawing.Size(28, 21);
            this.LBLGecenOgrenci.TabIndex = 9;
            this.LBLGecenOgrenci.Text = "00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Teal;
            this.label11.Location = new System.Drawing.Point(73, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 21);
            this.label11.TabIndex = 8;
            this.label11.Text = "Geçen Öğr.:";
            // 
            // OgretmenDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 719);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "OgretmenDetay";
            this.Text = "OgretmenDetay";
            this.Load += new System.EventHandler(this.OgretmenDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notKayitDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dersBindingSource)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TBSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox MaskedTBNumara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TBVize;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TBBütünleme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBFinal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private NotKayitDBDataSet notKayitDBDataSet;
        private System.Windows.Forms.BindingSource dersBindingSource;
        private NotKayitDBDataSetTableAdapters.DersTableAdapter dersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciVizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciFinalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciButunlemeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notOrtalamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn durumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label LBLGecenOgrenci;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LBLKalanOgrenci;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LBLOgrenciOrtalama;
        private System.Windows.Forms.Label label9;
    }
}