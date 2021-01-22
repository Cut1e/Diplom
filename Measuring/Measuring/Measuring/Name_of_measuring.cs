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
    public partial class Name_of_measuring : Form
    {
        public Name_of_measuring()
        {
            InitializeComponent();
        }

        private void Name_of_measuring_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'measuringDataSet.Name_of_means' table. You can move, or remove it, as needed.
            this.name_of_meansTableAdapter.Fill(this.measuringDataSet.Name_of_means);
  
        }
        public void add_name_of_measuring(string text,int text1)
        {
            this.name_of_meansTableAdapter.InsertQuery(text, text1);
            this.name_of_meansTableAdapter.Fill(this.measuringDataSet.Name_of_means);
        }
        public void delete_name_of_measuring()
        {
            this.name_of_meansTableAdapter.DeleteQuery(Convert.ToInt32(this.bunifuDataGridView1.SelectedCells[0].Value));
            this.name_of_meansTableAdapter.Fill(this.measuringDataSet.Name_of_means);
        }
        public void update_name_of_measuring()
        {
            this.name_of_meansTableAdapter.Update(this.measuringDataSet.Name_of_means);
        }
        public void change_name_of_measuring(string text, int text1)
        {
            this.name_of_meansTableAdapter.UpdateQuery(text, text1, (Convert.ToInt32(this.bunifuDataGridView1.SelectedCells[0].Value)));
            int i = bunifuDataGridView1.SelectedCells[1].RowIndex;
            this.name_of_meansTableAdapter.Fill(this.measuringDataSet.Name_of_means);
            bunifuDataGridView1.CurrentCell = bunifuDataGridView1.Rows[i].Cells[1];
        }
        private void bunifuFlatButton14_Click(object sender, EventArgs e)
        {          
            Add_name_of_measuring f = new Add_name_of_measuring();
            f.Owner = this;
            f.ShowDialog();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            var b = Convert.ToString(bunifuDataGridView1.SelectedCells[1].Value);
            var b1 = Convert.ToString(bunifuDataGridView1.SelectedCells[2].Value);
            Change_name_of_measuring f = new Change_name_of_measuring(b,Convert.ToInt32(b1));
            f.Owner = this;
            f.ShowDialog();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены что хотите удалить?", "Внмание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                delete_name_of_measuring();
            }
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены что хотите обновить?", "Внмание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                update_name_of_measuring();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = bunifuDataGridView1.RowCount.ToString();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            nameofmeansBindingSource.Filter = null;
            bunifuTextBox1.Text = "";
        }

        private void bunifuTextBox1_TextChange(object sender, EventArgs e)
        {
            nameofmeansBindingSource.Filter = "[title_of_means] LIKE'" + bunifuTextBox1.Text + "%'";
        }
    }
}
