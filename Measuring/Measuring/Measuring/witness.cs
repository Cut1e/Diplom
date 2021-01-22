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
    public partial class witness : Form
    {
        public witness()
        {
            InitializeComponent();
        }

        private void witness_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'measuringDataSet.The_witness' table. You can move, or remove it, as needed.
            this.the_witnessTableAdapter.Fill(this.measuringDataSet.The_witness);
            // TODO: This line of code loads data into the 'measuringDataSet.The_witness' table. You can move, or remove it, as needed.
            this.the_witnessTableAdapter.Fill(this.measuringDataSet.The_witness);

        }
        public void add_witness(string text,string text2,string text3,string text4,string text5)
        {
            this.the_witnessTableAdapter.InsertQuery(text, text2, text3, text4,text5);
            this.the_witnessTableAdapter.Fill(this.measuringDataSet.The_witness);
        }
        public void change_witness(string text, string text2, string text3, string text4,string text5)
        {
            this.the_witnessTableAdapter.UpdateQuery(text, text2, text3, text4,text5, Convert.ToInt32(bunifuDataGridView1.SelectedCells[0].Value));
            int i = bunifuDataGridView1.SelectedCells[1].RowIndex;
            this.the_witnessTableAdapter.Fill(this.measuringDataSet.The_witness);
            bunifuDataGridView1.CurrentCell = bunifuDataGridView1.Rows[i].Cells[1];
        }
        public void delete_witness()
        {
            this.the_witnessTableAdapter.DeleteQuery(Convert.ToInt32(bunifuDataGridView1.SelectedCells[0].Value));
            this.the_witnessTableAdapter.Fill(this.measuringDataSet.The_witness);
        }
        public void update_witness()
        {
            this.the_witnessTableAdapter.Fill(this.measuringDataSet.The_witness);
        }
        private void bunifuFlatButton14_Click(object sender, EventArgs e)
        {
            Add_witness f = new Add_witness();
            f.Owner = this;
            f.ShowDialog();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены что хотите удалить?", "Внмание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                delete_witness();
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            var b = Convert.ToString(bunifuDataGridView1.SelectedCells[1].Value);
            var b1 = Convert.ToString(bunifuDataGridView1.SelectedCells[2].Value);
            var b2 = Convert.ToString(bunifuDataGridView1.SelectedCells[3].Value);
            var b3 = Convert.ToString(bunifuDataGridView1.SelectedCells[4].Value);
            var b4 = Convert.ToString(bunifuDataGridView1.SelectedCells[5].Value);
            Change_witness f = new Change_witness(b,b1,b2,b3,b4);
            f.Owner = this;
            f.ShowDialog();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены что хотите обновить?", "Внмание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                update_witness();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = bunifuDataGridView1.RowCount.ToString();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            thewitnessBindingSource.Filter = null;
            bunifuTextBox1.Text = "";
        }

        private void bunifuTextBox1_TextChange(object sender, EventArgs e)
        {
            thewitnessBindingSource.Filter = "[Full_name] LIKE'" + bunifuTextBox1.Text + "%' or [The_address] LIKE'" + bunifuTextBox1.Text + "%' or [E_mail] LIKE'" + bunifuTextBox1.Text + "%' or [Phone_number] LIKE'" + bunifuTextBox1.Text + "%'";
        }
    }
}
