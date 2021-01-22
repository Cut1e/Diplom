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
    public partial class Means : Form
    {
        public Means()
        {
            InitializeComponent();
        }

        private void Means_Load(object sender, EventArgs e)
        {
            
            this.meansTableAdapter.Fill(this.measuringDataSet.Means);
            dateTimePicker2.Value = DateTime.Today;
            meansBindingSource.Filter = null;
        }
        public void verifivation()
        {
            DateTime d1;
            DateTime delta;
            for (int i = 0; i < bunifuDataGridView1.RowCount; i++)
            {
                string s = Convert.ToString(bunifuDataGridView1.Rows[i].Cells[3].Value);
                {
                    d1 = Convert.ToDateTime(bunifuDataGridView1.Rows[i].Cells[3].Value);
                    delta = d1.AddMonths((int)bunifuDataGridView1.Rows[i].Cells[12].Value);
                    bunifuDataGridView1.Rows[i].Cells[4].Value = Convert.ToDateTime(delta);
                }
            }
        }
        public void add_means(string text, string date, int text2, int text3)
        {
            this.meansTableAdapter.InsertQuery(text, date, text2, text3);
            this.meansTableAdapter.Fill(this.measuringDataSet.Means);
        }
        public void delete_means()
        {
            this.meansTableAdapter.DeleteQuery((string)bunifuDataGridView1.SelectedCells[0].Value);
            this.meansTableAdapter.Fill(this.measuringDataSet.Means);
        }
        public void update_means()
        {
            this.meansTableAdapter.Fill(this.measuringDataSet.Means);
        }
        public void change_means(string prev, string date, int text2, int text3)
        {
            this.meansTableAdapter.UpdateQuery(prev, date, text2, text3, (string)bunifuDataGridView1.SelectedCells[0].Value);
            int i = bunifuDataGridView1.SelectedCells[0].RowIndex;  
            this.meansTableAdapter.Fill(this.measuringDataSet.Means);
            bunifuDataGridView1.CurrentCell =bunifuDataGridView1.Rows[i].Cells[0];
        }
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены что хотите удалить?", "Внмание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                delete_means();
            }
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены что хотите обновить?", "Внмание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                update_means();
            }
        }
       public int for_check = 0;
        public void check_cod2(string text)
        {
            int i2 = bunifuDataGridView1.SelectedCells[0].RowIndex;
            text = text.ToUpper();
            for_check = 0;
            for (int i = 0; i < bunifuDataGridView1.RowCount; i++)
            {
                if (i == i2)
                {
                    return;
                }
                string a = null;
                a = Convert.ToString(bunifuDataGridView1.Rows[i].Cells[0].Value);
                a = a.ToUpper();
                if (a == text)
                {
                    MessageBox.Show("Такой код уже существует", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    for_check = 1;
                }
            }
        }
        public void check_cod(string text)
        {
            text=text.ToUpper();
            for_check = 0;
            for (int i = 0; i < bunifuDataGridView1.RowCount; i++)
            {
                string a = null;
                a = Convert.ToString(bunifuDataGridView1.Rows[i].Cells[0].Value);
                a=a.ToUpper();
                if (a == text)
                {
                    MessageBox.Show("Такой код уже существует", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    for_check = 1;
                }
            }
        }
        private void bunifuFlatButton14_Click(object sender, EventArgs e)
        {
            Add_means f = new Add_means();
            f.Owner = this;
            f.ShowDialog();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            var b = (string)bunifuDataGridView1.SelectedCells[0].Value;
            var b1 = (DateTime)bunifuDataGridView1.SelectedCells[1].Value;
            var b2 = (string)bunifuDataGridView1.SelectedCells[3].Value;
            var b3 = (string)bunifuDataGridView1.SelectedCells[4].Value;
            var b4 = (string)bunifuDataGridView1.SelectedCells[6].Value;
            Change_means f = new Change_means(b, Convert.ToString(b1),b2, b3,b4);
            f.Owner = this;
            f.ShowDialog();
        }

        private void bunifuTextBox1_TextChange(object sender, EventArgs e)
        {
            meansBindingSource.Filter = "[id_means] LIKE'" + bunifuTextBox1.Text + "%' or [title_of_means] LIKE'"+bunifuTextBox1.Text+"%' or [tytle_of_type_means] LIKE'"+bunifuTextBox1.Text+"%' or [limit_of_measurement] LIKE'"+bunifuTextBox1.Text+"%'or [Full_name] LIKE'"+bunifuTextBox1.Text+"%' or [Title_of_position] LIKE'"+bunifuTextBox1.Text+"%' or [Title_of_adres] LIKE'"+bunifuTextBox1.Text+"%'";
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            dateTimePicker2.Value = DateTime.Today;
            meansBindingSource.Filter = null;
            bunifuTextBox1.Text = "";
            bunifuDataGridView1.Focus();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            meansBindingSource.Filter = "[startdate]=\'" + dateTimePicker2.Text + "\'";
        }
        public void date_fill(string text,string text2)
        {
            this.meansTableAdapter.DateSearch(this.measuringDataSet.Means,text, text2);
        }
        //public void check(string text)
        //{
        //    for (int i = 0; i < this.bunifuDataGridView1.RowCount; i++)
        //    {
        //        string s = Convert.ToString(bunifuDataGridView1.Rows[i].Cells[0].Value);
        //        if (text == s)
        //        {
        //            MessageBox.Show("123");
        //        }
        //    }
        //    }
        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            inquiries_for_means f = new inquiries_for_means();
            f.Owner = this;
            f.ShowDialog();
        }
        public void date_fill_name(string text, string text2,string text3)
        {
            this.meansTableAdapter.DateSearch_Name(this.measuringDataSet.Means, text, text2, text3);
        }
        public void date_fill_type(string text, string text2, string text3,string text4)
        {
            this.meansTableAdapter.DateSearch_Type(this.measuringDataSet.Means, text, text2, text3,text4);
        }
        public void responsible(string text)
        {
            this.meansTableAdapter.ResponsibleSearch(this.measuringDataSet.Means, text);
        }
        public void responsible_name(string text,string text2)
        {
            this.meansTableAdapter.ResponsibleSearchName(this.measuringDataSet.Means, text,text2);
        }
        public void place(string text)
        {
            this.meansTableAdapter.PlaceSearch(this.measuringDataSet.Means, text);
        }
        public void place_name(string text,string text2)
        {
            this.meansTableAdapter.PlaceNameSearch(this.measuringDataSet.Means, text,text2);
        }
        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = bunifuDataGridView1.RowCount.ToString();
        }
    }
}
