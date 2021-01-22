using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Reporting.WinForms;

namespace Measuring
{
    public partial class Print_reports : Form
    {
        string writePath = @"org.dat";
        string org;
        public Print_reports(string text,string text1)
        {
            InitializeComponent();
            this.text = text;
            this.text1 = text1;
        }
        string text;
        string text1;
        private void Print_reports_Load(object sender, EventArgs e)
        {


        }
        public void go()
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", MeansBindingSource));
            organization();
            reportViewer1.LocalReport.ReportEmbeddedResource = "Measuring.Means_date.rdlc";
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("firstdate", text));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("seconddate", text1));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("organizarion", org));
            this.MeansTableAdapter.DateSearch(this.MeasuringDataSet.Means, text, text1);
            this.reportViewer1.RefreshReport();
        }
        public void go_group()
        {
            organization();
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", MeansBindingSource));
            reportViewer1.LocalReport.ReportEmbeddedResource = "Measuring.Group_means_date.rdlc";
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("firstdate", text));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("seconddate", text1));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("organizarion", org));
            this.MeansTableAdapter.DateSearch(this.MeasuringDataSet.Means, text, text1);
            this.reportViewer1.RefreshReport();
        }
        public void go_name(string text2)
        {
            organization();
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", MeansBindingSource));
            reportViewer1.LocalReport.ReportEmbeddedResource = "Measuring.Means_date_name.rdlc";
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("firstdate", text));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("seconddate", text1));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("organizarion", org));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("sredstvo", text2));
            this.MeansTableAdapter.DateSearch_Name(this.MeasuringDataSet.Means, text, text1, text2);
            this.reportViewer1.RefreshReport();
        }
        public void go_group_name(string text2)
        {
            organization();
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", MeansBindingSource));
            reportViewer1.LocalReport.ReportEmbeddedResource = "Measuring.Means_date_name_group.rdlc";
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("firstdate", text));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("seconddate", text1));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("organizarion", org));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("sredstvo", text2));
            this.MeansTableAdapter.DateSearch_Name(this.MeasuringDataSet.Means, text, text1, text2);
            this.reportViewer1.RefreshReport();
        }
        public void go_name_type(string text2,string text3)
        {
            organization();
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", MeansBindingSource));
            reportViewer1.LocalReport.ReportEmbeddedResource = "Measuring.Means_date_type.rdlc";
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("firstdate", text));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("seconddate", text1));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("organizarion", org));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("sredstvo", text2));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("type", text3));
            this.MeansTableAdapter.DateSearch_Type(this.MeasuringDataSet.Means, text, text1, text2,text3);
            this.reportViewer1.RefreshReport();
        }
        public void go_name_type_group(string text2, string text3)
        {
            organization();
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", MeansBindingSource));
            reportViewer1.LocalReport.ReportEmbeddedResource = "Measuring.Group_means_date_type.rdlc";
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("firstdate", text));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("seconddate", text1));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("organizarion", org));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("sredstvo", text2));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("type", text3));
            this.MeansTableAdapter.DateSearch_Type(this.MeasuringDataSet.Means, text, text1, text2, text3);
            this.reportViewer1.RefreshReport();
        }
        public void responsible(string text2)
        {
            organization();
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", MeansBindingSource));
            reportViewer1.LocalReport.ReportEmbeddedResource = "Measuring.Responsible.rdlc";
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("organizarion", org));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("responsible", text2));
            this.MeansTableAdapter.ResponsibleSearch(this.MeasuringDataSet.Means, text2);
            this.reportViewer1.RefreshReport();
        }
        public void responsible_name(string text2,string text3)
        {
            organization();
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", MeansBindingSource));
            reportViewer1.LocalReport.ReportEmbeddedResource = "Measuring.Responsible_name.rdlc";
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("organizarion", org));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("responsible", text2));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("name_means", text3));
            this.MeansTableAdapter.ResponsibleSearchName(this.MeasuringDataSet.Means, text2,text3);
            this.reportViewer1.RefreshReport();
        }
        public void place(string text2)
        {
            organization();
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", MeansBindingSource));
            reportViewer1.LocalReport.ReportEmbeddedResource = "Measuring.Means_place.rdlc";
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("organizarion", org));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("place", text2));
            this.MeansTableAdapter.PlaceSearch(this.MeasuringDataSet.Means, text2);
            this.reportViewer1.RefreshReport();
        }
        public void place_name(string text2, string text3)
        {
            organization();
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", MeansBindingSource));
            reportViewer1.LocalReport.ReportEmbeddedResource = "Measuring.Means_place_name.rdlc";
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("organizarion", org));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("place", text2));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("name_title", text3));
            this.MeansTableAdapter.PlaceNameSearch(this.MeasuringDataSet.Means, text2, text3);
            this.reportViewer1.RefreshReport();
        }
        public void verification_main(string nomer_svid,string data_prover,string goden_do,string sredstvo,string type_sr,string nomer_sr,string result,string poveritel,string adres,string nomer,string mail,string org_pov)
        {
            organization();
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", verificationBindingSource));
            reportViewer1.LocalReport.ReportEmbeddedResource = "Measuring.Verification_result.rdlc";
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("org", org));

            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("nomer_svid", nomer_svid));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("data_pover", data_prover));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("goden_do", goden_do));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("sredstvo", sredstvo));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("tip_sr", type_sr));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("nomer_sr", nomer_sr));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("result", result));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("poveritel", poveritel));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("adres", adres));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("nomer", nomer));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("mail", mail));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("orgpov", org_pov));
            this.reportViewer1.RefreshReport();

        }
        public void verification_main2(string nomer_svid,  string sredstvo, string type_sr, string nomer_sr, string result, string poveritel, string adres, string nomer, string mail,string org_pov)
        {
            organization();
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", verificationBindingSource));
            reportViewer1.LocalReport.ReportEmbeddedResource = "Measuring.Verification_drop.rdlc";
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("org", org));

            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("nomer_svid", nomer_svid));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("sredstvo", sredstvo));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("tip_sr", type_sr));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("nomer_sr", nomer_sr));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("result", result));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("poveritel", poveritel));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("adres", adres));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("nomer", nomer));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("mail", mail));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("orgpov", org_pov));
            this.reportViewer1.RefreshReport();
        }
        public void repair()
        {
            organization();
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", verificationBindingSource));
            reportViewer1.LocalReport.ReportEmbeddedResource = "Measuring.On_the_verification.rdlc";
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("organizarion", org));
            this.verificationTableAdapter.Date(this.MeasuringDataSet.Verification);
            this.reportViewer1.RefreshReport();
        }       
        public void book(string text)
        {
            this.MeasuringDataSet.EnforceConstraints = false;
            organization();
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", MeansBindingSource));
            reportViewer1.LocalReport.ReportEmbeddedResource = "Measuring.Books.rdlc";
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("organizarion", org));
            this.MeansTableAdapter.BookM(this.MeasuringDataSet.Means, text);
            this.reportViewer1.RefreshReport();
        }
        public void organization()
        {
            if (File.Exists(writePath))
            {
                using (StreamReader sr = new StreamReader(writePath))
                {
                    org = sr.ReadLine();
                }
            }
        }     
    }
}
