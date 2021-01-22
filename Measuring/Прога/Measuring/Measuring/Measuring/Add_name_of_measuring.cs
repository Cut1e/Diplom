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
    public partial class Add_name_of_measuring : Form
    {
        public Add_name_of_measuring()
        {
            InitializeComponent();
        }
        private void add()
        {
            Name_of_measuring main = this.Owner as Name_of_measuring;
            if (main != null)
            {
                main.add_name_of_measuring(bunifuTextBox1.Text, Convert.ToInt32(bunifuTextBox2.Text));
            }
        }
        private void bunifuFlatButton14_Click(object sender, EventArgs e)
        {
           
            if (bunifuTextBox1.Text == "" || bunifuTextBox2.Text == "")
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

        private void bunifuTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
 
        }
    }
}
