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
    public partial class Position : Form
    {
        public Position()
        {
            InitializeComponent();
        }

        private void Position_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'measuringDataSet.Position' table. You can move, or remove it, as needed.
            this.positionTableAdapter.Fill(this.measuringDataSet.Position);
            // TODO: This line of code loads data into the 'measuringDataSet.Position' table. You can move, or remove it, as needed.
            this.positionTableAdapter.Fill(this.measuringDataSet.Position);
            // TODO: This line of code loads data into the 'measuringDataSet.Position' table. You can move, or remove it, as needed.
            this.positionTableAdapter.Fill(this.measuringDataSet.Position);

        }
        public void add_position(string text)
        {
            this.positionTableAdapter.InsertQuery(text);
            this.positionTableAdapter.Fill(this.measuringDataSet.Position);
        }
        public void delete_position()
        {
            this.positionTableAdapter.DeleteQuery((int)bunifuDataGridView1.SelectedCells[0].Value);
            this.positionTableAdapter.Fill(this.measuringDataSet.Position);
        }
        public void update_position()
        {
            this.positionTableAdapter.Fill(this.measuringDataSet.Position);
        }
        public void change_position(string text)
        {
            this.positionTableAdapter.UpdateQuery(text,(int)bunifuDataGridView1.SelectedCells[0].Value);
            int i = bunifuDataGridView1.SelectedCells[1].RowIndex;
            this.positionTableAdapter.Fill(this.measuringDataSet.Position);
            bunifuDataGridView1.CurrentCell = bunifuDataGridView1.Rows[i].Cells[1];
        }
        private void bunifuFlatButton14_Click(object sender, EventArgs e)
        {
            Add_position f = new Add_position();
            f.Owner = this;
            f.ShowDialog();
                }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены что хотите удалить?", "Внмание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                delete_position();
            }
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены что хотите удалить?", "Внмание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                update_position();
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            var b = (string)bunifuDataGridView1.SelectedCells[1].Value;
            Change_position f = new Change_position(b);
            f.Owner = this;
            f.ShowDialog();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            bunifuTextBox1.Text = "";
            positionBindingSource.Filter = null;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = bunifuDataGridView1.RowCount.ToString();
        }

        private void bunifuTextBox1_TextChange(object sender, EventArgs e)
        {
            positionBindingSource.Filter = "[Title_of_position] LIKE'" + bunifuTextBox1.Text + "%' or [Title_of_place] LIKE'" + bunifuTextBox1.Text + "%'";
        }
    }
}
