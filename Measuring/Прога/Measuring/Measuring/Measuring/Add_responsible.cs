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
    public partial class Add_responsible : Form
    {
        public Add_responsible()
        {
            InitializeComponent();
        }

        private void Add_responsible_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'measuringDataSet.Adres' table. You can move, or remove it, as needed.
            this.adresTableAdapter.Fill(this.measuringDataSet.Adres);
            // TODO: This line of code loads data into the 'measuringDataSet.Position' table. You can move, or remove it, as needed.
            this.positionTableAdapter.Fill(this.measuringDataSet.Position);
            // TODO: This line of code loads data into the 'measuringDataSet.Adres' table. You can move, or remove it, as needed.
            this.adresTableAdapter.Fill(this.measuringDataSet.Adres);
            // TODO: This line of code loads data into the 'measuringDataSet.Position' table. You can move, or remove it, as needed.
            this.positionTableAdapter.Fill(this.measuringDataSet.Position);
            dateTimePicker2.Value = DateTime.Now;
        }
        private void add()
        {
            int id = (int)comboBox2.SelectedValue;
            Responsible main = this.Owner as Responsible;
            if (main != null)
            {
                main.add_responsible(bunifuTextBox1.Text, Convert.ToDateTime(dateTimePicker2.Text), id);
            }
        }
        private void bunifuFlatButton14_Click(object sender, EventArgs e)
        {
            if (bunifuTextBox1.Text == "")
            {
                MessageBox.Show("Некорректно введена ФИО ответственного", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }            
            if (MessageBox.Show("Вы уверены что хотите добавить?", "Внмание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                add();
            }
        }
    }
}
