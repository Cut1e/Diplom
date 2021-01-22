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
    public partial class Change_responsible : Form
    {
        public Change_responsible(string text,DateTime text2,string text3,string text4)
        {
            InitializeComponent();
            this.text = text;
            this.text2 = text2;
            this.text3 = text3;
            this.text4 = text4;
        }
        string text;
        DateTime text2;
        string text3;
        string text4;

        private void Change_responsible_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'measuringDataSet.Adres' table. You can move, or remove it, as needed.
            this.adresTableAdapter.Fill(this.measuringDataSet.Adres);
            // TODO: This line of code loads data into the 'measuringDataSet.Position' table. You can move, or remove it, as needed.
            this.positionTableAdapter.Fill(this.measuringDataSet.Position);
            bunifuTextBox1.Text = text;
            dateTimePicker2.Text = Convert.ToString(text2);
            comboBox1.Text = text4;
            comboBox2.Text = text3;

        }
        private void change()
        {
            int id2 = (int)comboBox2.SelectedValue;
            Responsible main = this.Owner as Responsible;
            if (main != null)
            {
                main.change_responsible(bunifuTextBox1.Text, dateTimePicker2.Text, id2);
                main.change();
            }
        }
        private void bunifuFlatButton14_Click(object sender, EventArgs e)
        {
           if (bunifuTextBox1.Text == "")
            {
                MessageBox.Show("Некорректно введена ФИО ответственного", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }            
            if (MessageBox.Show("Вы уверены что хотите изменить?", "Внмание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                change();
            } 
        }
    }
}
