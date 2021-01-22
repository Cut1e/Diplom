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
    public partial class Change_result : Form
    {
        public Change_result(string data)
        {
            InitializeComponent();
            this.data = data;
        }
        string data;
        public void change()
        {
            Result main = this.Owner as Result;
            if (main != null)
            {
                main.change_result(bunifuTextBox1.Text);
            }
        }
        private void Change_result_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'measuringDataSet.Result' table. You can move, or remove it, as needed.
            this.resultTableAdapter.Fill(this.measuringDataSet.Result);
            bunifuTextBox1.Text = data;
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

        private void bunifuTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                change();
            }
        }
    }
}
