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
    public partial class type_of_measuring : Form
    {
        public type_of_measuring()
        {
            InitializeComponent();
        }

        private void type_of_measring_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'measuringDataSet.Means_type_code' table. You can move, or remove it, as needed.
            this.means_type_codeTableAdapter.Fill(this.measuringDataSet.Means_type_code);

        }
        public void add_type_of_measuring(string text,string text2,int text3)
        {
            this.means_type_codeTableAdapter.InsertQuery(text, text2, text3);
            this.means_type_codeTableAdapter.Fill(this.measuringDataSet.Means_type_code);
        }
        public void delete_type_of_measuring()
        {
            this.means_type_codeTableAdapter.DeleteQuery(Convert.ToInt32(bunifuDataGridView1.SelectedCells[0].Value));
            this.means_type_codeTableAdapter.Fill(this.measuringDataSet.Means_type_code);
        }
        public void update_type_of_measuring()
        {
            this.means_type_codeTableAdapter.Fill(this.measuringDataSet.Means_type_code);
        }
        public void change_type_of_measuring(string text, string text2, int text3)
        {
            this.means_type_codeTableAdapter.UpdateQuery(text,text2,text3, Convert.ToInt32(bunifuDataGridView1.SelectedCells[0].Value));
            int i = bunifuDataGridView1.SelectedCells[1].RowIndex;
            this.means_type_codeTableAdapter.Fill(this.measuringDataSet.Means_type_code);
            bunifuDataGridView1.CurrentCell = bunifuDataGridView1.Rows[i].Cells[1];
        }
        private void bunifuFlatButton14_Click(object sender, EventArgs e)
        {
            Add_type_of_measring f = new Add_type_of_measring();
            f.Owner = this;
            f.ShowDialog();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены что хотите удалить?", "Внмание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                delete_type_of_measuring();
            }
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены что хотите обновить?", "Внмание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                update_type_of_measuring();
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            var b = Convert.ToString(bunifuDataGridView1.SelectedCells[1].Value);
            var b1 = Convert.ToString(bunifuDataGridView1.SelectedCells[2].Value);
            var b2 = Convert.ToString(bunifuDataGridView1.SelectedCells[3].Value);
            Change_type_of_measuring f = new Change_type_of_measuring(b,b1,b2);
            f.Owner = this;
            f.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = bunifuDataGridView1.RowCount.ToString();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            meanstypecodeBindingSource.Filter = null;
            bunifuTextBox1.Text = ""; 
        }

        private void bunifuTextBox1_TextChange(object sender, EventArgs e)
        {
            meanstypecodeBindingSource.Filter = "[tytle_of_type_means] LIKE'" + bunifuTextBox1.Text + "%' or [limit_of_measurement] LIKE'" + bunifuTextBox1.Text + "%' or [title_of_means] LIKE'" + bunifuTextBox1.Text + "%'";
        }
    }
    }
