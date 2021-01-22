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
    public partial class Change_type_of_measuring : Form
    {
        public Change_type_of_measuring(string text,string text2,string text3)
        {
            InitializeComponent();
            this.text = text;
            this.text2 = text2;
            this.text3 = text3;
        }
        string text;
        string text2;
        string text3;

        private void Change_type_of_measuring_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'measuringDataSet.Name_of_means' table. You can move, or remove it, as needed.
            this.name_of_meansTableAdapter.Fill(this.measuringDataSet.Name_of_means);
            bunifuTextBox1.Text = text;
            bunifuTextBox2.Text = text2;
            comboBox1.Text = text3;
        }
        private void change()
        {
            type_of_measuring main = this.Owner as type_of_measuring;
            if (main != null)
            {
                int id = (int)comboBox1.SelectedValue;
                main.change_type_of_measuring(bunifuTextBox1.Text, bunifuTextBox2.Text, id);
            }
        }
        private void bunifuFlatButton14_Click(object sender, EventArgs e)
        {
            if (bunifuTextBox2.Text == "" || bunifuTextBox1.Text == "")
            {
                if (MessageBox.Show("Не заполнены все поля. Изменить?", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    change();
                    return;
                }
                else return;
            }
            if (MessageBox.Show("Вы уверены что хотите изменить?", "Внмание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                change();
            }
        }
    }
}
