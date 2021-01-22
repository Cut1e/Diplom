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
    public partial class Change_position : Form
    {
        public Change_position(string text)
        {
            InitializeComponent();
            this.text = text;
        }
        string text;
        private void change()
        {
            Position main = this.Owner as Position;
            if (main != null)
            {
                main.change_position(bunifuTextBox1.Text);
            }
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

        private void Change_position_Load(object sender, EventArgs e)
        {
            bunifuTextBox1.Text = text;
        }
    }
}
