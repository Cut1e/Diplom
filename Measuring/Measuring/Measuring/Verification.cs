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
    public partial class Verification : Form
    {

        public Verification()
        {
            InitializeComponent();
        }
        private void Verification_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'measuringDataSet.Verification' table. You can move, or remove it, as needed.
            this.verificationTableAdapter.Fill(this.measuringDataSet.Verification);
            // TODO: This line of code loads data into the 'measuringDataSet1.Means' table. You can move, or remove it, as needed.
            this.meansTableAdapter.Fill(this.measuringDataSet.Means);
            // TODO: This line of code loads data into the 'measuringDataSet.Verification' table. You can move, or remove it, as needed.
            this.verificationTableAdapter.Fill(this.measuringDataSet.Verification);
            // TODO: This line of code loads data into the 'measuringDataSet.Verification' table. You can move, or remove it, as needed.
            this.verificationTableAdapter.Fill(this.measuringDataSet.Verification);
            // TODO: This line of code loads data into the 'measuringDataSet.Verification' table. You can move, or remove it, as needed.
            this.verificationTableAdapter.Fill(this.measuringDataSet.Verification);
            // TODO: This line of code loads data into the 'measuringDataSet.Verification' table. You can move, or remove it, as needed.
            this.verificationTableAdapter.Fill(this.measuringDataSet.Verification);
            verifivation();
            dateTimePicker2.Value = DateTime.Now;
            verificationBindingSource.Filter = null;
            panel2.Visible = true;
            panel3.Visible = false;
        }
        public void verifivation()
        {
            DateTime d1;
            DateTime delta;
            for (int i = 0; i < bunifuDataGridView1.RowCount; i++)
            {
                string s = Convert.ToString(bunifuDataGridView1.Rows[i].Cells[3].Value);
                if (s == "")
                {
                    d1 = Convert.ToDateTime(bunifuDataGridView1.Rows[i].Cells[1].Value);
                    delta = d1.AddMonths((int)bunifuDataGridView1.Rows[i].Cells[12].Value);
                    bunifuDataGridView1.Rows[i].Cells[4].Value = Convert.ToDateTime(delta);
                }
                else
                {
                    d1 = Convert.ToDateTime(bunifuDataGridView1.Rows[i].Cells[3].Value);
                    delta = d1.AddMonths((int)bunifuDataGridView1.Rows[i].Cells[12].Value);
                    bunifuDataGridView1.Rows[i].Cells[4].Value = Convert.ToDateTime(delta);
                }
            }
        }
     
        public void add_verification(string text,string text1, int text2, string text3)
        {
            this.verificationTableAdapter.InsertQuery(text,text1, text2, text3);
            this.verificationTableAdapter.Fill(this.measuringDataSet.Verification);
            this.meansTableAdapter.Fill(this.measuringDataSet.Means);
            verifivation();
            color();
        }
        public void delete_verification()
        {
            this.verificationTableAdapter.DeleteQuery((int)bunifuDataGridView1.SelectedCells[0].Value);
            this.verificationTableAdapter.Fill(this.measuringDataSet.Verification);
            verifivation();
            color();
        }
        public void cahnge_verification(string text, string text2, bool text3, int text4, string text5, int text6)
        {
            this.verificationTableAdapter.UpdateQuery(text, text2, text3, text4, text5, text6, (int)bunifuDataGridView1.SelectedCells[0].Value);
            int i = bunifuDataGridView1.SelectedCells[1].RowIndex;
            this.verificationTableAdapter.Fill(this.measuringDataSet.Verification);
            bunifuDataGridView1.CurrentCell = bunifuDataGridView1.Rows[i].Cells[1];
            verifivation();
            color();
        }
        public void update_verification()
        {
            this.verificationTableAdapter.Fill(this.measuringDataSet.Verification);
            verifivation();
            color();
        }
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены что хотите удалить?", "Внмание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                delete_verification();
            }
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены что хотите обновить?", "Внмание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                update_verification();
            }
        }


        private void bunifuFlatButton14_Click(object sender, EventArgs e)
        {
            Add_varification f = new Add_varification();
            f.Owner = this;
            f.ShowDialog();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            string b1 ="";
            string b2 = "";
            var b = (DateTime)bunifuDataGridView1.SelectedCells[1].Value;
            if (bunifuDataGridView1.SelectedCells[3].Value != null)
            {
                b1 = Convert.ToString(bunifuDataGridView1.SelectedCells[3].Value);
            }
            if (bunifuDataGridView1.SelectedCells[2].Value != null)
            {
                b2 = Convert.ToString(bunifuDataGridView1.SelectedCells[2].Value);
            }
            var b3 = (string)bunifuDataGridView1.SelectedCells[5].Value;
            var b4 = Convert.ToString(bunifuDataGridView1.SelectedCells[6].Value);
            var b5 = (string)bunifuDataGridView1.SelectedCells[8].Value;
            var b6 = (string)bunifuDataGridView1.SelectedCells[9].Value;
            var b7 = (string)bunifuDataGridView1.SelectedCells[7].Value;

            Change_verification f = new Change_verification(Convert.ToString(b), Convert.ToString(b1), b2, b3, b4, b5, b6, b7);
            f.Owner = this;
            f.ShowDialog();
        }


        private void bunifuDataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }
        public void color()
        {
            foreach (DataGridViewRow row in bunifuDataGridView1.Rows) //цикл
            {
                int days = (DateTime.Parse(row.Cells[4].Value.ToString()) - DateTime.Now).Days; //дней осталось
                if (days > 30)
                    row.Cells[4].Style.BackColor = System.Drawing.Color.Green; //красим зеленым
                else if (days > -1)
                    row.Cells[4].Style.BackColor = System.Drawing.Color.Yellow;
                else
                    row.Cells[4].Style.BackColor = System.Drawing.Color.Red;
            }
            return;
        }
        public void color2()
        {
            foreach (DataGridViewRow row in bunifuDataGridView2.Rows) //цикл
            {
                int days = (DateTime.Parse(row.Cells[4].Value.ToString()) - DateTime.Now).Days; //дней осталось
                if (days > 30)
                    row.Cells[4].Style.BackColor = System.Drawing.Color.Green; //красим зеленым
                else if (days > -1)
                    row.Cells[4].Style.BackColor = System.Drawing.Color.Yellow;
                else
                    row.Cells[4].Style.BackColor = System.Drawing.Color.Red;
            }
            return;
        }
        private void label1_Click(object sender, EventArgs e)
        {
            color();
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                panel3.Visible = true;
                panel2.Visible = false;
                checkBox1.Checked = true;
                panel4.Visible = true;
            }
            else
            {
                panel2.Visible = true;
                panel3.Visible = false;
                checkBox1.Checked = false;
            }
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = bunifuDataGridView1.RowCount.ToString();
            color();
            color2();
        }

        private void bunifuTextBox1_TextChange(object sender, EventArgs e)
        {
            verificationBindingSource.Filter = "[Full_name] LIKE'" + bunifuTextBox1.Text + "%' or [title_of_result] LIKE'" + bunifuTextBox1.Text + "%' or [title_of_means] LIKE'" + bunifuTextBox1.Text + "%' or [tytle_of_type_means] LIKE'" + bunifuTextBox1.Text + "%'";
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            dateTimePicker2.Value = DateTime.Now;
            bunifuTextBox1.Text = "";
            verificationBindingSource.Filter = null;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            verificationBindingSource.Filter = "[start_verification]=\'" + dateTimePicker2.Text + "\' or [end_verification]=\'"+dateTimePicker2.Text+"\' or [123]=\'"+dateTimePicker2.Text+"\'";
        }

        private void bunifuFlatButton4_Click_1(object sender, EventArgs e)
        {
            if (bunifuDataGridView1.SelectedCells[10].Value.ToString() != "")
            {
                var data_pover = Convert.ToDateTime(bunifuDataGridView1.SelectedCells[1].Value);
                var goden_do = Convert.ToDateTime(bunifuDataGridView1.SelectedCells[4].Value);
                var sredstvo = (string)bunifuDataGridView1.SelectedCells[8].Value;
                var tip_sr = (string)bunifuDataGridView1.SelectedCells[9].Value;
                var nomer_sr = (string)bunifuDataGridView1.SelectedCells[7].Value;
                var result = (string)bunifuDataGridView1.SelectedCells[6].Value;
                var poveritel = (string)bunifuDataGridView1.SelectedCells[5].Value;
                var adres = (string)bunifuDataGridView1.SelectedCells[13].Value;
                var nomer = (string)bunifuDataGridView1.SelectedCells[16].Value;
                var email = (string)bunifuDataGridView1.SelectedCells[15].Value;
                var org_pov = (string)bunifuDataGridView1.SelectedCells[17].Value;
                Print_verification f = new Print_verification(Convert.ToString(data_pover), Convert.ToString(goden_do), sredstvo, tip_sr, nomer_sr, result, poveritel, adres, nomer, email, org_pov);
                f.Owner = this;
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Неизвестен результат поверки", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            Graph f = new Graph();
            f.Owner = this;
            f.ShowDialog();
        }
       
        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {                 
            var b = "";
            var b1 = "";
            Print_reports f = new Print_reports(b, b1);
            f.Owner = this;
            f.repair();
            f.ShowDialog();
        

        }

        private void bunifuFlatButton12_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                panel3.Visible = true;
                panel2.Visible = false;
                checkBox1.Checked = true;
            }
            else
            {
                panel2.Visible = true;
                panel3.Visible = false;
                checkBox1.Checked = false;
                panel4.Visible = false;
            }
        }

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {
           
        }
    }
}
