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
    public partial class Add_result : Form
    {
        public Add_result()
        {
            InitializeComponent();
         
        }      
        public void add()
        {
            Result main = this.Owner as Result;
            if (main != null)
            {
                main.add_result(bunifuTextBox1.Text);
            }
        }
        private void bunifuFlatButton14_Click(object sender, EventArgs e)
        {
            if ( bunifuTextBox1.Text == "" )
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
        private void bunifuTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                add();
            }
        }
    }
}
