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
    public partial class Change_means : Form
    {
        public Change_means(string text,string text2,string text3,string text4, string text5)
        {
            InitializeComponent();
            this.text = text;
            this.text1 = text2;
            this.text2 = text3;
            this.text3 = text4;
            this.text4 = text5;
        }
        string text;
        string text1;
        string text2;
        string text3;
        string text4;
        private void Change_means_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'measuringDataSet.Responsible' table. You can move, or remove it, as needed.
            this.responsibleTableAdapter.Fill(this.measuringDataSet.Responsible);
            // TODO: This line of code loads data into the 'measuringDataSet.Means_type_code' table. You can move, or remove it, as needed.
            this.means_type_codeTableAdapter.Fill(this.measuringDataSet.Means_type_code);
            // TODO: This line of code loads data into the 'measuringDataSet.Name_of_means' table. You can move, or remove it, as needed.
            this.name_of_meansTableAdapter.Fill(this.measuringDataSet.Name_of_means);
            bunifuTextBox1.Text = text;
            dateTimePicker2.Text = text1;
            comboBox1.Text = text2;
            comboBox4.Text = text3;
            comboBox5.Text = text4;
        }

        private void bunifuFlatButton14_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены что хотите изменить?", "Внмание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int id = (int)comboBox4.SelectedValue;
                int id2 = (int)comboBox5.SelectedValue;
                if (bunifuTextBox1.Text == "")
                {
                    MessageBox.Show("Некорректно введен код средства", "Введите код средства корректно", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Means main = this.Owner as Means;
                if (main != null)
                {
                    main.check_cod2(bunifuTextBox1.Text);
                    int a = main.for_check;
                    if (main.for_check == 0)
                    {
                        main.change_means(bunifuTextBox1.Text, dateTimePicker2.Text, id, id2);
                    }
                    else return;
                }
            }
        }
    }
}
