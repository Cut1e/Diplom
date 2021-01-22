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
    public partial class Change_name_of_measuring : Form
    {
        public Change_name_of_measuring(string text,int text1)
        {
            InitializeComponent();
            this.text = text;
            this.text1 = text1;
        }
        string text;
        int text1;
        private void change()
        {
            Name_of_measuring main = this.Owner as Name_of_measuring;
            if (main != null)
            {
                main.change_name_of_measuring(bunifuTextBox1.Text, Convert.ToInt32(bunifuTextBox2.Text));
            }
        }
        private void bunifuFlatButton14_Click(object sender, EventArgs e)
        {
            if (bunifuTextBox1.Text == "" || bunifuTextBox2.Text == "")
            {
                if (MessageBox.Show("Не заполнены все поля. Добавить?", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    change();
                    return;
                }
                else return;
            }
            if (MessageBox.Show("Вы уверены что хотите добавить?", "Внмание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
               change();
            }
        }

        private void Change_name_of_measuring_Load(object sender, EventArgs e)
        {
            bunifuTextBox1.Text = text;
            bunifuTextBox2.Text = Convert.ToString(text1);
        }

        private void bunifuTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }
    }
}
