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
    public partial class Change_adres : Form
    {
        public Change_adres( string text,string text2)
        {
            InitializeComponent();
            this.text = text;
            this.text2 = text2;
        }
        string text;
        string text2;
        private void change()
        {
            int a = (int)comboBox1.SelectedValue;
            Adres main = this.Owner as Adres;
            if (main != null)
            {
                main.change_adres(bunifuTextBox1.Text,a);
            }
        }
        private void Change_adres_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'measuringDataSet.Position' table. You can move, or remove it, as needed.
            this.positionTableAdapter.Fill(this.measuringDataSet.Position);
            bunifuTextBox1.Text = text; 
            comboBox1.Text = text2;
        }

        private void bunifuFlatButton14_Click(object sender, EventArgs e)
        {
            if (bunifuTextBox1.Text == "")
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
