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
    public partial class Change_witness : Form
    {
        public Change_witness(string data,string data1,string data2,string data3,string data4)
        {
            InitializeComponent();
            this.data = data;
            this.data1 = data1;
            this.data2 = data2;
            this.data3 = data3;
            this.data4 = data4;
        }
        string data;
        string data1;
        string data2;
        string data3;
        string data4;
        private void change()
        {
            witness main = this.Owner as witness;
            if (main != null)
            {
                if (radioButton1.Checked == true)
                    main.change_witness(bunifuTextBox1.Text, bunifuTextBox2.Text, bunifuTextBox3.Text, maskedTextBox1.Text,bunifuTextBox4.Text);
                else
                    main.change_witness(bunifuTextBox1.Text, bunifuTextBox2.Text, bunifuTextBox3.Text, maskedTextBox2.Text,bunifuTextBox4.Text);
            }
        }
        private void bunifuFlatButton14_Click(object sender, EventArgs e)
        {
            string a = maskedTextBox1.Text;
            string a1 = maskedTextBox2.Text;
            if (bunifuTextBox1.Text == "")
            {
                MessageBox.Show("Введите ФИО поверителя", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (a.Length == 16 && a1.Length == 16 || bunifuTextBox2.Text == "" || bunifuTextBox3.Text == "" || radioButton1.Checked == false && radioButton2.Checked == false)
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

        private void Change_witness_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'measuringDataSet.The_witness' table. You can move, or remove it, as needed.
            this.the_witnessTableAdapter.Fill(this.measuringDataSet.The_witness);
            bunifuTextBox1.Text = data;
            bunifuTextBox2.Text = data1;
            bunifuTextBox3.Text = data2;
            bunifuTextBox4.Text = data4;
            if (data3[5] == '1')
            {
                maskedTextBox1.Text = data3;
                radioButton1.Checked = true;
            }
            else
            {
                maskedTextBox2.Text = data3;
                radioButton2.Checked = true;
            }
            
        }
    }
}
