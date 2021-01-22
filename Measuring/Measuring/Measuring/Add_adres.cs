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
    public partial class Add_adres : Form
    {
        public Add_adres()
        {
            InitializeComponent();
        }
        private void add()
        {
            int a = (int)comboBox1.SelectedValue;
            Adres main = this.Owner as Adres;
            if (main != null)
            {
                main.add_adres(bunifuTextBox1.Text,a);
            }
        }
        private void bunifuFlatButton14_Click(object sender, EventArgs e)
        {
            if(bunifuTextBox1.Text == "")
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

        private void bunifuFlatButton14_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                add();
            }
        }

        private void Add_adres_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'measuringDataSet.Position' table. You can move, or remove it, as needed.
            this.positionTableAdapter.Fill(this.measuringDataSet.Position);

        }
    }
}
