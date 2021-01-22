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
    public partial class Add_varification : Form
    {
        public Add_varification()
        {
            InitializeComponent();
        }

        private void Add_varification_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'measuringDataSet.Means' table. You can move, or remove it, as needed.
            this.meansTableAdapter.Fill(this.measuringDataSet.Means);
            // TODO: This line of code loads data into the 'measuringDataSet.Means_type_code' table. You can move, or remove it, as needed.
            this.means_type_codeTableAdapter.Fill(this.measuringDataSet.Means_type_code);
            // TODO: This line of code loads data into the 'measuringDataSet.Name_of_means' table. You can move, or remove it, as needed.
            this.name_of_meansTableAdapter.Fill(this.measuringDataSet.Name_of_means);
            // TODO: This line of code loads data into the 'measuringDataSet.Means_type_code' table. You can move, or remove it, as needed.
            this.means_type_codeTableAdapter.Fill(this.measuringDataSet.Means_type_code);
            // TODO: This line of code loads data into the 'measuringDataSet.Means' table. You can move, or remove it, as needed.
            this.meansTableAdapter.Fill(this.measuringDataSet.Means);
            // TODO: This line of code loads data into the 'measuringDataSet.The_witness' table. You can move, or remove it, as needed.
            this.the_witnessTableAdapter.Fill(this.measuringDataSet.The_witness);
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
        }
        private void add()
        {
            if (checkBox1.Checked == true)
            {
                int id = (int)comboBox1.SelectedValue;
                string id2 = (string)comboBox4.SelectedValue;
                Verification main = this.Owner as Verification;
                if (main != null)
                {
                    main.add_verification(dateTimePicker2.Text, dateTimePicker1.Text, id, id2);
                }
            }
            else
            {
                int id = (int)comboBox1.SelectedValue;
                string id2 = (string)comboBox4.SelectedValue;
                Verification main = this.Owner as Verification;
                if (main != null)
                {
                    main.add_verification(dateTimePicker2.Text, null, id, id2);
                }
            }

        }
        private void bunifuFlatButton14_Click(object sender, EventArgs e)
        {
            if(comboBox4.Text=="")
                {
                MessageBox.Show("Некорректно введен код средства", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Вы уверены что хотите добавить?", "Внмание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                add();
            }
            else return;
        }
    }
}
