namespace Measuring
{
    partial class Add_means
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_means));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.nameofmeansBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.measuringDataSet = new Measuring.MeasuringDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuFlatButton14 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuTextBox1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.fKMeanstypidna145C0A3FBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.responsibleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.name_of_meansTableAdapter = new Measuring.MeasuringDataSetTableAdapters.Name_of_meansTableAdapter();
            this.means_type_codeTableAdapter = new Measuring.MeasuringDataSetTableAdapters.Means_type_codeTableAdapter();
            this.meansBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.meansTableAdapter = new Measuring.MeasuringDataSetTableAdapters.MeansTableAdapter();
            this.responsibleTableAdapter = new Measuring.MeasuringDataSetTableAdapters.ResponsibleTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.nameofmeansBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.measuringDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKMeanstypidna145C0A3FBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.responsibleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meansBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox1.DataSource = this.nameofmeansBindingSource;
            this.comboBox1.DisplayMember = "title_of_means";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.Location = new System.Drawing.Point(9, 170);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(532, 29);
            this.comboBox1.TabIndex = 75;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.label3.Location = new System.Drawing.Point(5, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 21);
            this.label3.TabIndex = 74;
            this.label3.Text = "Наименование средства";
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
            this.bunifuFlatButton14.Location = new System.Drawing.Point(9, 337);
            this.bunifuFlatButton14.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bunifuFlatButton14.Name = "bunifuFlatButton14";
            this.bunifuFlatButton14.Normalcolor = System.Drawing.Color.White;
            this.bunifuFlatButton14.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(179)))), ((int)(((byte)(225)))));
            this.bunifuFlatButton14.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton14.selected = false;
            this.bunifuFlatButton14.Size = new System.Drawing.Size(532, 49);
            this.bunifuFlatButton14.TabIndex = 73;
            this.bunifuFlatButton14.Tag = "0";
            this.bunifuFlatButton14.Text = "Добавить";
            this.bunifuFlatButton14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton14.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.bunifuFlatButton14.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuFlatButton14.Click += new System.EventHandler(this.bunifuFlatButton14_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.label2.Location = new System.Drawing.Point(5, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 21);
            this.label2.TabIndex = 80;
            this.label2.Text = "Код средства";
            // 
            // bunifuTextBox1
            // 
            this.bunifuTextBox1.AcceptsReturn = false;
            this.bunifuTextBox1.AcceptsTab = false;
            this.bunifuTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuTextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuTextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuTextBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuTextBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextBox1.BackgroundImage")));
            this.bunifuTextBox1.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(179)))), ((int)(((byte)(225)))));
            this.bunifuTextBox1.BorderColorDisabled = System.Drawing.Color.Black;
            this.bunifuTextBox1.BorderColorHover = System.Drawing.Color.Black;
            this.bunifuTextBox1.BorderColorIdle = System.Drawing.SystemColors.ControlDark;
            this.bunifuTextBox1.BorderRadius = 1;
            this.bunifuTextBox1.BorderThickness = 1;
            this.bunifuTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuTextBox1.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuTextBox1.DefaultText = "";
            this.bunifuTextBox1.FillColor = System.Drawing.Color.Gainsboro;
            this.bunifuTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.bunifuTextBox1.HideSelection = true;
            this.bunifuTextBox1.IconLeft = null;
            this.bunifuTextBox1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTextBox1.IconPadding = 0;
            this.bunifuTextBox1.IconRight = null;
            this.bunifuTextBox1.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTextBox1.Location = new System.Drawing.Point(9, 28);
            this.bunifuTextBox1.MaxLength = 32767;
            this.bunifuTextBox1.MinimumSize = new System.Drawing.Size(100, 35);
            this.bunifuTextBox1.Modified = false;
            this.bunifuTextBox1.Name = "bunifuTextBox1";
            this.bunifuTextBox1.PasswordChar = '\0';
            this.bunifuTextBox1.ReadOnly = false;
            this.bunifuTextBox1.SelectedText = "";
            this.bunifuTextBox1.SelectionLength = 0;
            this.bunifuTextBox1.SelectionStart = 0;
            this.bunifuTextBox1.ShortcutsEnabled = true;
            this.bunifuTextBox1.Size = new System.Drawing.Size(532, 35);
            this.bunifuTextBox1.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.bunifuTextBox1.TabIndex = 79;
            this.bunifuTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuTextBox1.TextMarginLeft = 5;
            this.bunifuTextBox1.TextPlaceholder = "Код средства...";
            this.bunifuTextBox1.UseSystemPasswordChar = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker2.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.dateTimePicker2.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(9, 102);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4, 3, 3, 3);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(532, 30);
            this.dateTimePicker2.TabIndex = 82;
            this.dateTimePicker2.Value = new System.DateTime(2020, 5, 22, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.label4.Location = new System.Drawing.Point(5, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 21);
            this.label4.TabIndex = 81;
            this.label4.Text = "Дата поступления";
            // 
            // comboBox4
            // 
            this.comboBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox4.DataSource = this.fKMeanstypidna145C0A3FBindingSource;
            this.comboBox4.DisplayMember = "tytle_of_type_means";
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.comboBox4.IntegralHeight = false;
            this.comboBox4.Location = new System.Drawing.Point(9, 235);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(532, 29);
            this.comboBox4.TabIndex = 86;
            this.comboBox4.ValueMember = "id_means_type_code";
            // 
            // fKMeanstypidna145C0A3FBindingSource
            // 
            this.fKMeanstypidna145C0A3FBindingSource.DataMember = "FK__Means_typ__id_na__145C0A3F";
            this.fKMeanstypidna145C0A3FBindingSource.DataSource = this.nameofmeansBindingSource;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.label6.Location = new System.Drawing.Point(7, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 21);
            this.label6.TabIndex = 85;
            this.label6.Text = "Тип средства";
            // 
            // comboBox5
            // 
            this.comboBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox5.DataSource = this.responsibleBindingSource;
            this.comboBox5.DisplayMember = "Full_name";
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.comboBox5.IntegralHeight = false;
            this.comboBox5.Location = new System.Drawing.Point(9, 302);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(532, 29);
            this.comboBox5.TabIndex = 88;
            this.comboBox5.ValueMember = "id_responsible";
            // 
            // responsibleBindingSource
            // 
            this.responsibleBindingSource.DataMember = "Responsible";
            this.responsibleBindingSource.DataSource = this.measuringDataSet;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.label7.Location = new System.Drawing.Point(5, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 21);
            this.label7.TabIndex = 87;
            this.label7.Text = "Ответственный";
            // 
            // name_of_meansTableAdapter
            // 
            this.name_of_meansTableAdapter.ClearBeforeFill = true;
            // 
            // means_type_codeTableAdapter
            // 
            this.means_type_codeTableAdapter.ClearBeforeFill = true;
            // 
            // meansBindingSource
            // 
            this.meansBindingSource.DataMember = "Means";
            this.meansBindingSource.DataSource = this.measuringDataSet;
            // 
            // meansTableAdapter
            // 
            this.meansTableAdapter.ClearBeforeFill = true;
            // 
            // responsibleTableAdapter
            // 
            this.responsibleTableAdapter.ClearBeforeFill = true;
            // 
            // Add_means
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(545, 392);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bunifuTextBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bunifuFlatButton14);
            this.Name = "Add_means";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить средство";
            this.Load += new System.EventHandler(this.Add_means_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nameofmeansBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.measuringDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKMeanstypidna145C0A3FBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.responsibleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meansBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        public Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton14;
        private System.Windows.Forms.Label label2;
        public Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox bunifuTextBox1;
        public System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label7;
        private MeasuringDataSet measuringDataSet;
        private System.Windows.Forms.BindingSource nameofmeansBindingSource;
        private MeasuringDataSetTableAdapters.Name_of_meansTableAdapter name_of_meansTableAdapter;
        private System.Windows.Forms.BindingSource fKMeanstypidna145C0A3FBindingSource;
        private MeasuringDataSetTableAdapters.Means_type_codeTableAdapter means_type_codeTableAdapter;
        private System.Windows.Forms.BindingSource meansBindingSource;
        private MeasuringDataSetTableAdapters.MeansTableAdapter meansTableAdapter;
        private System.Windows.Forms.BindingSource responsibleBindingSource;
        private MeasuringDataSetTableAdapters.ResponsibleTableAdapter responsibleTableAdapter;
    }
}