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
    public partial class Add_means : Form
    {
        public Add_means()
        {
            InitializeComponent();
        }
        private void Add_means_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'measuringDataSet.Responsible' table. You can move, or remove it, as needed.
            this.responsibleTableAdapter.Fill(this.measuringDataSet.Responsible);
            // TODO: This line of code loads data into the 'measuringDataSet.Responsible' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'measuringDataSet.Means_type_code' table. You can move, or remove it, as needed.
            this.means_type_codeTableAdapter.Fill(this.measuringDataSet.Means_type_code);
            // TODO: This line of code loads data into the 'measuringDataSet.Name_of_means' table. You can move, or remove it, as needed.
            this.name_of_meansTableAdapter.Fill(this.measuringDataSet.Name_of_means);
            // TODO: This line of code loads data into the 'measuringDataSet.Means_type_code' table. You can move, or remove it, as needed.
            this.means_type_codeTableAdapter.Fill(this.measuringDataSet.Means_type_code);
            // TODO: This line of code loads data into the 'measuringDataSet.Name_of_means' table. You can move, or remove it, as needed.
            this.name_of_meansTableAdapter.Fill(this.measuringDataSet.Name_of_means);
            // TODO: This line of code loads data into the 'measuringDataSet.Name_of_means' table. You can move, or remove it, as needed.
            this.name_of_meansTableAdapter.Fill(this.measuringDataSet.Name_of_means);
            // TODO: This line of code loads data into the 'measuringDataSet.Means_type_code' table. You can move, or remove it, as needed.
            this.means_type_codeTableAdapter.Fill(this.measuringDataSet.Means_type_code);
            dateTimePicker2.Value = DateTime.Today;        
                

        }

        private void bunifuFlatButton14_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены что хотите добавить?", "Внмание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int id = (int)comboBox4.SelectedValue;
                int id2 = (int)comboBox5.SelectedValue;
                if (bunifuTextBox1.Text == "")
                {
                    MessageBox.Show("Некорректно введен код средства", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Means main = this.Owner as Means;
                if (main != null)
                {
                    main.check_cod(bunifuTextBox1.Text);
                    int a = main.for_check;
                    if (main.for_check == 0)
                    {
                        main.add_means(bunifuTextBox1.Text, dateTimePicker2.Text, id, id2);
                    }
                    else return;
                }
            }
        }
    }
}
