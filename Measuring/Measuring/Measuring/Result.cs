using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Measuring
{
    public partial class Result : Form
    {
        public Result()
        {
            InitializeComponent();
        }
        
        private void resultBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.resultBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.measuringDataSet);
        }

        private void Add_result_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'measuringDataSet.Result' table. You can move, or remove it, as needed.
            this.resultTableAdapter.Fill(this.measuringDataSet.Result);
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            resultBindingSource.Filter = null;
            bunifuTextBox1.Text = null;
            bunifuDataGridView1.Focus();
        }
        public void add_result(string text)
        {
            this.resultTableAdapter.InsertQuery(text);
            this.resultTableAdapter.Fill(this.measuringDataSet.Result);
        }
        public void del_result(int text)
        {
            this.resultTableAdapter.DeleteQuery(text);
            this.resultTableAdapter.Fill(this.measuringDataSet.Result);
        }
        public void change_result(string text)
        {
            this.resultTableAdapter.UpdateQuery(text, Convert.ToInt32(bunifuDataGridView1.SelectedCells[0].Value));
            int i = bunifuDataGridView1.SelectedCells[1].RowIndex;
            this.resultTableAdapter.Fill(this.measuringDataSet.Result);
            bunifuDataGridView1.CurrentCell = bunifuDataGridView1.Rows[i].Cells[1];
        }
        public void update_result()
        {
            this.resultTableAdapter.Fill(this.measuringDataSet.Result);
        }      
        private void bunifuFlatButton14_Click(object sender, EventArgs e)
        {
            Add_result f = new Add_result();
            f.Owner = this;
            f.ShowDialog();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены что хотите удалить?", "Внмание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                del_result(Convert.ToInt32(bunifuDataGridView1.SelectedCells[0].Value));
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            var b = Convert.ToString(bunifuDataGridView1.SelectedCells[1].Value);
            Change_result f = new Change_result(b);
            f.Owner = this;
            f.ShowDialog();
        }
        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены что хотите обновить?", "Внмание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                update_result();
            }
        }
        private void bunifuTextBox1_TextChange(object sender, EventArgs e)
        {
            resultBindingSource.Filter = "[title_of_result] LIKE'" + bunifuTextBox1.Text + "%'";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
             label4.Text = bunifuDataGridView1.RowCount.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
