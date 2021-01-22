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
    public partial class Responsible : Form
    {
        DateTime d1;
        DateTime d2=DateTime.Today;
        int delta;
        public Responsible()
        {
            InitializeComponent();
        }
       
        private void Responsible_Load(object sender, EventArgs e)
        {
            this.measuringDataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'measuringDataSet.Responsible' table. You can move, or remove it, as needed.
            this.responsibleTableAdapter.Fill(this.measuringDataSet.Responsible);
            // TODO: This line of code loads data into the 'measuringDataSet.Responsible' table. You can move, or remove it, as needed.
            this.responsibleTableAdapter.Fill(this.measuringDataSet.Responsible);       
            // TODO: This line of code loads data into the 'measuringDataSet.Responsible' table. You can move, or remove it, as needed.
            this.responsibleTableAdapter.Fill(this.measuringDataSet.Responsible);
            // TODO: This line of code loads data into the 'measuringDataSet.Responsible' table. You can move, or remove it, as needed.
            this.responsibleTableAdapter.Fill(this.measuringDataSet.Responsible);
            change();
            dateTimePicker2.Value = DateTime.Today;
            responsibleBindingSource.Filter = null;
        }
       
        private void bunifuDataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
        
        }
        public void add_responsible(string text,DateTime text2,int text3)
        {
            this.responsibleTableAdapter.InsertQuery(text, Convert.ToString(text2), text3);
            this.responsibleTableAdapter.Fill(this.measuringDataSet.Responsible);
            change();
        }
        public void delete_responsible()
        {
            this.responsibleTableAdapter.DeleteQuery((int)bunifuDataGridView1.SelectedCells[0].Value);
            this.responsibleTableAdapter.Fill(this.measuringDataSet.Responsible);
            change();
        }
        public void update_responsible()
        {
            this.responsibleTableAdapter.Fill(this.measuringDataSet.Responsible);
            change();
        }
        public void change_responsible(string text, string text2, int text3)
        {
            this.responsibleTableAdapter.UpdateQuery(text, text2, text3,  (int)bunifuDataGridView1.SelectedCells[0].Value);
            this.responsibleTableAdapter.Fill(this.measuringDataSet.Responsible);
            change();
        }
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены что хотите удалить?", "Внмание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                delete_responsible();
            }
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены что хотите обновить?", "Внмание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                update_responsible();
            }
        }
        public void change()
        {
            for (int i = 0; i < bunifuDataGridView1.RowCount; i++)
            {
                d1 = Convert.ToDateTime(bunifuDataGridView1.Rows[i].Cells[2].Value);
                delta = d2.Year - d1.Year;
                if (d1 > d2.AddYears(-delta)) delta--;
                bunifuDataGridView1.Rows[i].Cells[6].Value = delta;
            }
        }
        private void bunifuFlatButton14_Click(object sender, EventArgs e)
        {
   
            Add_responsible f = new Add_responsible();
            f.Owner = this;
            f.ShowDialog();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            var b = (string)bunifuDataGridView1.SelectedCells[1].Value;
            var b1 = (DateTime)bunifuDataGridView1.SelectedCells[2].Value;
            var b2 = (string)bunifuDataGridView1.SelectedCells[4].Value;
            var b3 = (string)bunifuDataGridView1.SelectedCells[5].Value;
            Change_responsible f = new Change_responsible(b,b1,b2,b3);
            f.Owner = this;
            f.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = bunifuDataGridView1.RowCount.ToString();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            bunifuTextBox1.Text = "";
            dateTimePicker2.Value = DateTime.Today;
            responsibleBindingSource.Filter = null;
      
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            responsibleBindingSource.Filter = "[Startdate]=\'" + dateTimePicker2.Text + "\'";
            change();
        }

        private void bunifuTextBox1_TextChange(object sender, EventArgs e)
        {
            responsibleBindingSource.Filter = "[Full_name] LIKE'" + bunifuTextBox1.Text + "%' or [Title_of_position] LIKE'" + bunifuTextBox1.Text + "%'  or [title_of_adres] LIKE'"+bunifuTextBox1.Text+"%'";
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            var b = "";
            var b1 = "";
            Print_reports f = new Print_reports(b, b1);
            f.Owner = this;
            f.book(Convert.ToString(bunifuDataGridView1.SelectedCells[1].Value));
            f.ShowDialog();
        }
    }
}
