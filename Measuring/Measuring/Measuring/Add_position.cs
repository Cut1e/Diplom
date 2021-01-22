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
    public partial class Add_position : Form
    {
        public Add_position()
        {
            InitializeComponent();
        }
        private void add()
        {
            Position main = this.Owner as Position;
            if (main != null)
            {
                main.add_position(bunifuTextBox1.Text);
            }   
        }
        private void bunifuFlatButton14_Click(object sender, EventArgs e)
        {
            if (bunifuTextBox1.Text == "")
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

        private void App_position_Load(object sender, EventArgs e)
        {


        }
    }
}
