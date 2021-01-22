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
    public partial class Add_type_of_measring : Form
    {
        public Add_type_of_measring()
        {
            InitializeComponent();
        }

        private void Add_type_of_measring_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'measuringDataSet.Name_of_means' table. You can move, or remove it, as needed.
            this.name_of_meansTableAdapter.Fill(this.measuringDataSet.Name_of_means);

        }
        private void add()
        {
            type_of_measuring main = this.Owner as type_of_measuring;
            if (main != null)
            {
                int id = (int)comboBox1.SelectedValue;
                main.add_type_of_measuring(bunifuTextBox1.Text, bunifuTextBox2.Text, id);
            }
        }
        private void bunifuFlatButton14_Click(object sender, EventArgs e)
        {
            if ( bunifuTextBox2.Text == "" || bunifuTextBox1.Text == "")
            {
                if (MessageBox.Show("Не заполнены все поля. Добавить?", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    add();
                    return;
                }
                else return;
            }
            if (MessageBox.Show("Вы уверены что хотите добавить?", "Внмание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                add();
            }
        }
    }
}
