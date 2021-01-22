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
    public partial class Adres : Form
    {
        public Adres()
        {
            InitializeComponent();
        }

        private void Adres_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'measuringDataSet.Adres' table. You can move, or remove it, as needed.
            this.adresTableAdapter.Fill(this.measuringDataSet.Adres);
            // TODO: This line of code loads data into the 'measuringDataSet.Adres' table. You can move, or remove it, as needed.
            this.adresTableAdapter.Fill(this.measuringDataSet.Adres);
            // TODO: This line of code loads data into the 'measuringDataSet.Adres' table. You can move, or remove it, as needed.
            this.adresTableAdapter.Fill(this.measuringDataSet.Adres);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = bunifuDataGridView1.RowCount.ToString();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            bunifuTextBox1.Text = "";
            adresBindingSource.Filter = null;
        }

        private void bunifuTextBox1_TextChange(object sender, EventArgs e)
        {
            adresBindingSource.Filter = "[Title_of_adres] LIKE'" + bunifuTextBox1.Text + "%' or [Title_of_position] LIKE'"+bunifuTextBox1.Text+"%'";
        }
        public void delete_adres()
        {
            adresTableAdapter.DeleteQuery((int)bunifuDataGridView1.SelectedCells[0].Value);
            this.adresTableAdapter.Fill(this.measuringDataSet.Adres);
        }
        public void update_adres()
        {
            this.adresTableAdapter.Fill(this.measuringDataSet.Adres);
        }
        public void add_adres(string text1,int text2)
        {
            adresTableAdapter.InsertQuery(text1,text2);
            this.adresTableAdapter.Fill(this.measuringDataSet.Adres);
        }
        public void change_adres(string text1,int text2)
        {
            adresTableAdapter.UpdateQuery(text1,text2, (int)bunifuDataGridView1.SelectedCells[0].Value);
            int i = bunifuDataGridView1.SelectedCells[1].RowIndex;
            this.adresTableAdapter.Fill(this.measuringDataSet.Adres);
            bunifuDataGridView1.CurrentCell = bunifuDataGridView1.Rows[i].Cells[1];
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены что хотите удалить?", "Внмание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                delete_adres();
            }
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены что хотите обновить?", "Внмание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                update_adres();
            }
        }

        private void asd_Click(object sender, EventArgs e)
        {
            Add_adres f = new Add_adres();
            f.Owner = this;
            f.ShowDialog();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            var b1 = (string)bunifuDataGridView1.SelectedCells[3].Value;
            var b = (string)bunifuDataGridView1.SelectedCells[1].Value;
            Change_adres f = new Change_adres(b,b1);
            f.Owner = this;
            f.ShowDialog();
        }
    }
}
