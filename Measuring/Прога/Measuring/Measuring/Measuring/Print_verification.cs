using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Measuring
{
    public partial class Print_verification : Form
    {
        public Print_verification(string data_pover,string goden_do,string sredstvo,string tip_sr, string nomer_sr,string result,string poveritel,string adres,string nomer,string email,string org_pov)
        {
            InitializeComponent();
            this.data_pover = data_pover;
            this.goden_do = goden_do;
            this.sredstvo = sredstvo;
            this.tip_sr = tip_sr;
            this.nomer_sr = nomer_sr;
            this.result = result;
            this.poveritel = poveritel;
            this.adres = adres;
            this.nomer = nomer;
            this.email = email;
            this.org_pov = org_pov;
        }
        string data_pover; string goden_do; string sredstvo; string tip_sr; string nomer_sr; string result; string poveritel; string adres; string nomer; string email; string org_pov;

        private void bunifuFlatButton14_Click_1(object sender, EventArgs e)
        {
            var b = "";
            var b1 = "";
            Print_reports f = new Print_reports(b, b1);
            f.Owner = this;
            f.verification_main(bunifuTextBox1.Text, data_pover, goden_do, sredstvo, tip_sr, nomer_sr, result, poveritel, adres, nomer, email,org_pov);
            f.ShowDialog();
        }

        private void меньшеЗаданнойДатыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            this.Size = new Size(309, 188);
        }

        private void Print_verification_Load(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            this.Size = new Size(309, 188);
        }

        private void заключениеОНепригодностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
            panel3.Visible = false;
            this.Size = new Size(360, 269);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            var b = "";
            var b1 = "";
            Print_reports f = new Print_reports(b, b1);
            f.Owner = this;
            f.verification_main2(bunifuTextBox2.Text, sredstvo, tip_sr, nomer_sr, bunifuTextBox3.Text, poveritel, adres, nomer, email,org_pov);
            f.ShowDialog();
        }
    }
}
