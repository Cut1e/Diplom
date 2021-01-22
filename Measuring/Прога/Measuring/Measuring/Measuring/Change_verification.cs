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
    public partial class Change_verification : Form
    {
        public Change_verification(string text, string text1, string text2, string text3, string text4, string text5, string text6, string text7)
        {
            InitializeComponent();
            this.text = text;
            this.text1 = text1;
            this.text2 = text2;
            this.text3 = text3;
            this.text4 = text4;
            this.text5 = text5;
            this.text6 = text6;
            this.text7 = text7;
        }
        string text;
        string text1;
        string text2;
        string text3;
        string text4;
        string text5;
        string text6;
        string text7;
        private void Change_verification_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'measuringDataSet.Means' table. You can move, or remove it, as needed.
            this.meansTableAdapter.Fill(this.measuringDataSet.Means);
            // TODO: This line of code loads data into the 'measuringDataSet.Means_type_code' table. You can move, or remove it, as needed.
            this.means_type_codeTableAdapter.Fill(this.measuringDataSet.Means_type_code);
            // TODO: This line of code loads data into the 'measuringDataSet.Means_type_code' table. You can move, or remove it, as needed.
            this.means_type_codeTableAdapter.Fill(this.measuringDataSet.Means_type_code);
            // TODO: This line of code loads data into the 'measuringDataSet.Means' table. You can move, or remove it, as needed.
            this.meansTableAdapter.Fill(this.measuringDataSet.Means);
            // TODO: This line of code loads data into the 'measuringDataSet.Means_type_code' table. You can move, or remove it, as needed.
            this.means_type_codeTableAdapter.Fill(this.measuringDataSet.Means_type_code);
            // TODO: This line of code loads data into the 'measuringDataSet.Name_of_means' table. You can move, or remove it, as needed.
            this.name_of_meansTableAdapter.Fill(this.measuringDataSet.Name_of_means);
            // TODO: This line of code loads data into the 'measuringDataSet.The_witness' table. You can move, or remove it, as needed.
            this.the_witnessTableAdapter.Fill(this.measuringDataSet.The_witness);
            // TODO: This line of code loads data into the 'measuringDataSet.Result' table. You can move, or remove it, as needed.
            this.resultTableAdapter.Fill(this.measuringDataSet.Result);
            dateTimePicker2.Text = text;
            dateTimePicker1.Text = text1;
            comboBox1.Text = text3;
            comboBox2.Text = text5;
            comboBox3.Text = text6;
            comboBox4.Text = text7;
            comboBox5.Text = text4;
            if (text2 != "")
                checkBox1.Checked = Convert.ToBoolean(text2);
        }
        private void change()
        {
            int id = (int)comboBox1.SelectedValue;
            int id2 = (int)comboBox5.SelectedValue;
            Verification main = this.Owner as Verification;
            if (main != null)
            {
                main.cahnge_verification(dateTimePicker2.Text, dateTimePicker1.Text, Convert.ToBoolean(checkBox1.CheckState), id, comboBox4.Text, id2);
                main.verifivation();
            }
        }

        private void bunifuFlatButton14_Click(object sender, EventArgs e)
        {
            if (comboBox4.Text == "")
            {
                MessageBox.Show("Некорректно введен код средства", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Вы уверены что хотите изменить?", "Внмание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                change();
            }
            else return;
        }
    }
}
