namespace Measuring
{
    partial class Print_reports
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.MeansBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MeasuringDataSet = new Measuring.MeasuringDataSet();
            this.verificationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MeansTableAdapter = new Measuring.MeasuringDataSetTableAdapters.MeansTableAdapter();
            this.tableAdapterManager = new Measuring.MeasuringDataSetTableAdapters.TableAdapterManager();
            this.verificationTableAdapter = new Measuring.MeasuringDataSetTableAdapters.VerificationTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.measuringDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MeansBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MeasuringDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verificationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.measuringDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MeansBindingSource
            // 
            this.MeansBindingSource.DataMember = "Means";
            this.MeansBindingSource.DataSource = this.MeasuringDataSet;
            // 
            // MeasuringDataSet
            // 
            this.MeasuringDataSet.DataSetName = "MeasuringDataSet";
            this.MeasuringDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // verificationBindingSource
            // 
            this.verificationBindingSource.DataMember = "Verification";
            this.verificationBindingSource.DataSource = this.MeasuringDataSet;
            // 
            // MeansTableAdapter
            // 
            this.MeansTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.GraphTableAdapter = null;
            this.tableAdapterManager.Name_of_meansTableAdapter = null;
            this.tableAdapterManager.PositionTableAdapter = null;
            this.tableAdapterManager.ResultTableAdapter = null;
            this.tableAdapterManager.The_witnessTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Measuring.MeasuringDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // verificationTableAdapter
            // 
            this.verificationTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.verificationBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Measuring.On_the_verification.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(739, 602);
            this.reportViewer1.TabIndex = 0;
            // 
            // measuringDataSetBindingSource
            // 
            this.measuringDataSetBindingSource.DataSource = this.MeasuringDataSet;
            this.measuringDataSetBindingSource.Position = 0;
            // 
            // Print_reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 602);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Print_reports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Предпросмотр отчёта";
            this.Load += new System.EventHandler(this.Print_reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MeansBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MeasuringDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verificationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.measuringDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource MeansBindingSource;
        private MeasuringDataSet MeasuringDataSet;
        private MeasuringDataSetTableAdapters.MeansTableAdapter MeansTableAdapter;
        private MeasuringDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource verificationBindingSource;
        private MeasuringDataSetTableAdapters.VerificationTableAdapter verificationTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource measuringDataSetBindingSource;
    }
}