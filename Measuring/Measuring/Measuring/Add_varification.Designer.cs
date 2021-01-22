namespace Measuring
{
    partial class Add_varification
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
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.fKMeanstypidna145C0A3FBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameofmeansBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.measuringDataSet = new Measuring.MeasuringDataSet();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.thewitnessBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuFlatButton14 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.the_witnessTableAdapter = new Measuring.MeasuringDataSetTableAdapters.The_witnessTableAdapter();
            this.name_of_meansTableAdapter = new Measuring.MeasuringDataSetTableAdapters.Name_of_meansTableAdapter();
            this.means_type_codeTableAdapter = new Measuring.MeasuringDataSetTableAdapters.Means_type_codeTableAdapter();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.meanstypecodeMeansBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.meansTableAdapter = new Measuring.MeasuringDataSetTableAdapters.MeansTableAdapter();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.fKMeanstypidna145C0A3FBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameofmeansBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.measuringDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thewitnessBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meanstypecodeMeansBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox3
            // 
            this.comboBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox3.DataSource = this.fKMeanstypidna145C0A3FBindingSource;
            this.comboBox3.DisplayMember = "tytle_of_type_means";
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.comboBox3.IntegralHeight = false;
            this.comboBox3.Location = new System.Drawing.Point(6, 247);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(338, 29);
            this.comboBox3.TabIndex = 75;
            // 
            // fKMeanstypidna145C0A3FBindingSource
            // 
            this.fKMeanstypidna145C0A3FBindingSource.DataMember = "FK__Means_typ__id_na__145C0A3F";
            this.fKMeanstypidna145C0A3FBindingSource.DataSource = this.nameofmeansBindingSource;
            // 
            // nameofmeansBindingSource
            // 
            this.nameofmeansBindingSource.DataMember = "Name_of_means";
            this.nameofmeansBindingSource.DataSource = this.measuringDataSet;
            // 
            // measuringDataSet
            // 
            this.measuringDataSet.DataSetName = "MeasuringDataSet";
            this.measuringDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox2.DataSource = this.nameofmeansBindingSource;
            this.comboBox2.DisplayMember = "title_of_means";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.comboBox2.IntegralHeight = false;
            this.comboBox2.Location = new System.Drawing.Point(6, 212);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(338, 29);
            this.comboBox2.TabIndex = 74;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.label4.Location = new System.Drawing.Point(2, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 21);
            this.label4.TabIndex = 73;
            this.label4.Text = "Средство";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker2.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.dateTimePicker2.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(6, 30);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(338, 30);
            this.dateTimePicker2.TabIndex = 72;
            this.dateTimePicker2.Value = new System.DateTime(2019, 12, 4, 0, 0, 0, 0);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox1.DataSource = this.thewitnessBindingSource;
            this.comboBox1.DisplayMember = "Full_name";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.Location = new System.Drawing.Point(6, 156);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(338, 29);
            this.comboBox1.TabIndex = 71;
            this.comboBox1.ValueMember = "id_witness";
            // 
            // thewitnessBindingSource
            // 
            this.thewitnessBindingSource.DataMember = "The_witness";
            this.thewitnessBindingSource.DataSource = this.measuringDataSet;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.label3.Location = new System.Drawing.Point(2, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 21);
            this.label3.TabIndex = 70;
            this.label3.Text = "Поверитель";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.label1.Location = new System.Drawing.Point(2, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 21);
            this.label1.TabIndex = 68;
            this.label1.Text = "Старт поверки";
            // 
            // bunifuFlatButton14
            // 
            this.bunifuFlatButton14.Active = false;
            this.bunifuFlatButton14.Activecolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuFlatButton14.BackColor = System.Drawing.Color.White;
            this.bunifuFlatButton14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton14.BorderRadius = 1;
            this.bunifuFlatButton14.ButtonText = "Добавить";
            this.bunifuFlatButton14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton14.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton14.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuFlatButton14.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton14.Iconimage = global::Measuring.Properties.Resources.add_40px1;
            this.bunifuFlatButton14.Iconimage_right = null;
            this.bunifuFlatButton14.Iconimage_right_Selected = null;
            this.bunifuFlatButton14.Iconimage_Selected = null;
            this.bunifuFlatButton14.IconMarginLeft = 5;
            this.bunifuFlatButton14.IconMarginRight = 0;
            this.bunifuFlatButton14.IconRightVisible = true;
            this.bunifuFlatButton14.IconRightZoom = 0D;
            this.bunifuFlatButton14.IconVisible = true;
            this.bunifuFlatButton14.IconZoom = 65D;
            this.bunifuFlatButton14.IsTab = true;
            this.bunifuFlatButton14.Location = new System.Drawing.Point(1, 319);
            this.bunifuFlatButton14.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bunifuFlatButton14.Name = "bunifuFlatButton14";
            this.bunifuFlatButton14.Normalcolor = System.Drawing.Color.White;
            this.bunifuFlatButton14.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(179)))), ((int)(((byte)(225)))));
            this.bunifuFlatButton14.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton14.selected = false;
            this.bunifuFlatButton14.Size = new System.Drawing.Size(343, 49);
            this.bunifuFlatButton14.TabIndex = 66;
            this.bunifuFlatButton14.Tag = "0";
            this.bunifuFlatButton14.Text = "Добавить";
            this.bunifuFlatButton14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton14.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.bunifuFlatButton14.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuFlatButton14.Click += new System.EventHandler(this.bunifuFlatButton14_Click);
            // 
            // the_witnessTableAdapter
            // 
            this.the_witnessTableAdapter.ClearBeforeFill = true;
            // 
            // name_of_meansTableAdapter
            // 
            this.name_of_meansTableAdapter.ClearBeforeFill = true;
            // 
            // means_type_codeTableAdapter
            // 
            this.means_type_codeTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox4
            // 
            this.comboBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox4.DataSource = this.meanstypecodeMeansBindingSource;
            this.comboBox4.DisplayMember = "id_means";
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.comboBox4.IntegralHeight = false;
            this.comboBox4.Location = new System.Drawing.Point(6, 282);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(338, 29);
            this.comboBox4.TabIndex = 76;
            this.comboBox4.ValueMember = "id_means";
            // 
            // meanstypecodeMeansBindingSource
            // 
            this.meanstypecodeMeansBindingSource.DataMember = "Means_type_code_Means";
            this.meanstypecodeMeansBindingSource.DataSource = this.fKMeanstypidna145C0A3FBindingSource;
            // 
            // meansTableAdapter
            // 
            this.meansTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 91);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(338, 30);
            this.dateTimePicker1.TabIndex = 78;
            this.dateTimePicker1.Value = new System.DateTime(2019, 12, 4, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.label2.Location = new System.Drawing.Point(23, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 21);
            this.label2.TabIndex = 77;
            this.label2.Text = "Предположительный конец поверки";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 73);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 79;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Add_varification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(351, 375);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuFlatButton14);
            this.Name = "Add_varification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить поверку";
            this.Load += new System.EventHandler(this.Add_varification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fKMeanstypidna145C0A3FBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameofmeansBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.measuringDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thewitnessBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meanstypecodeMeansBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        public Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton14;
        private MeasuringDataSet measuringDataSet;
        private System.Windows.Forms.BindingSource thewitnessBindingSource;
        private MeasuringDataSetTableAdapters.The_witnessTableAdapter the_witnessTableAdapter;
        private System.Windows.Forms.BindingSource nameofmeansBindingSource;
        private MeasuringDataSetTableAdapters.Name_of_meansTableAdapter name_of_meansTableAdapter;
        private System.Windows.Forms.BindingSource fKMeanstypidna145C0A3FBindingSource;
        private MeasuringDataSetTableAdapters.Means_type_codeTableAdapter means_type_codeTableAdapter;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.BindingSource meanstypecodeMeansBindingSource;
        private MeasuringDataSetTableAdapters.MeansTableAdapter meansTableAdapter;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}