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
    public partial class inquiries_for_means : Form
    {
        public inquiries_for_means()
        {
            InitializeComponent();
        }

        private void inquiries_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'measuringDataSet.Adres' table. You can move, or remove it, as needed.
            this.adresTableAdapter.Fill(this.measuringDataSet.Adres);
            // TODO: This line of code loads data into the 'measuringDataSet.Responsible' table. You can move, or remove it, as needed.
            this.responsibleTableAdapter.Fill(this.measuringDataSet.Responsible);
            // TODO: This line of code loads data into the 'measuringDataSet.Means_type_code' table. You can move, or remove it, as needed.
            this.means_type_codeTableAdapter.Fill(this.measuringDataSet.Means_type_code);
            // TODO: This line of code loads data into the 'measuringDataSet.Name_of_means' table. You can move, or remove it, as needed.
            this.name_of_meansTableAdapter.Fill(this.measuringDataSet.Name_of_means);
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            dateTimePicker3.Value = DateTime.Now;
            dateTimePicker4.Value = DateTime.Now;
            dateTimePicker6.Value = DateTime.Now;
            dateTimePicker5.Value = DateTime.Now;
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            this.Size = new Size(291, 365);
        }


        private void сброситьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Means main = this.Owner as Means;
            if (main != null)
            {
                main.update_means();
            }
        }


        private void меньшеЗаданнойДатыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            this.Size = new Size(291, 365);
        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            var b = dateTimePicker2.Text;
            var b1 = dateTimePicker1.Text;
            Print_reports f = new Print_reports(b, b1);
            f.Owner = this;
            f.go();
            f.ShowDialog();

        }

        private void bunifuFlatButton14_Click_1(object sender, EventArgs e)
        {
            Means main = this.Owner as Means;
            if (main != null)
            {
                main.date_fill(dateTimePicker2.Text, dateTimePicker1.Text);
            }
        }

        private void сгрупированнаяДатаПоступленияВВыбранныхДатахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel7.Visible = false;
            this.Size=new Size(291, 423);
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            var b = dateTimePicker2.Text;
            var b1 = dateTimePicker1.Text;  
            Print_reports f = new Print_reports(b, b1);
            f.Owner = this;
            f.go_group();
            f.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            Means main = this.Owner as Means;
            if (main != null)
            {
                main.date_fill_name(dateTimePicker4.Text, dateTimePicker3.Text,comboBox1.Text);
            }
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            var b = dateTimePicker4.Text;
            var b1 = dateTimePicker3.Text;
            Print_reports f = new Print_reports(b, b1);
            f.Owner = this;
            f.go_name(comboBox1.Text);
            f.ShowDialog();
        }

        private void bunifuFlatButton3_Click_1(object sender, EventArgs e)
        {
            var b = dateTimePicker4.Text;
            var b1 = dateTimePicker3.Text;
            Print_reports f = new Print_reports(b, b1);
            f.Owner = this;
            f.go_group_name(comboBox1.Text);
            f.ShowDialog();
        }

        private void датаПоступленияОпределенногоСредстваВВыбранныхДатахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = true;
            panel1.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel7.Visible = false;
            panel6.Visible = false;
            this.Size = new Size(291, 497);
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            Means main = this.Owner as Means;
            if (main != null)
            {
                main.date_fill_type(dateTimePicker6.Text, dateTimePicker5.Text, comboBox2.Text,comboBox3.Text);
            }
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            var b = dateTimePicker6.Text;
            var b1 = dateTimePicker5.Text;
            Print_reports f = new Print_reports(b, b1);
            f.Owner = this;
            f.go_name_type(comboBox2.Text,comboBox3.Text);
            f.ShowDialog();
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            var b = dateTimePicker6.Text;
            var b1 = dateTimePicker5.Text;
            Print_reports f = new Print_reports(b, b1);
            f.Owner = this;
            f.go_name_type_group(comboBox2.Text, comboBox3.Text);
            f.ShowDialog();
        }

        private void сресдтваУОпределенногоОтветсвенногоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel4.Visible = true;
            panel1.Visible = false;
            panel3.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            this.Size = new Size(291, 236);
        }

        private void bunifuFlatButton11_Click(object sender, EventArgs e)
        {
            Means main = this.Owner as Means;
            if (main != null)
            {
                main.responsible( comboBox5.Text);
            }
        }

        private void bunifuFlatButton10_Click(object sender, EventArgs e)
        {
            var b = dateTimePicker6.Text;
            var b1 = dateTimePicker5.Text;
            Print_reports f = new Print_reports(b, b1);
            f.Owner = this;
            f.responsible(comboBox5.Text);
            f.ShowDialog();
        }

        private void определенноеСредствоУОпределенногоОтветственногоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel5.Visible = true;
            panel1.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            this.Size = new Size(291, 307);
        }

        private void bunifuFlatButton12_Click(object sender, EventArgs e)
        {
            Means main = this.Owner as Means;
            if (main != null)
            {
                main.responsible_name(comboBox4.Text,comboBox6.Text);
            }
        }

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {
            var b = dateTimePicker6.Text;
            var b1 = dateTimePicker5.Text;
            Print_reports f = new Print_reports(b, b1);
            f.Owner = this;
            f.responsible_name(comboBox4.Text,comboBox6.Text);
            f.ShowDialog();
        }

        private void местоположениеСредстваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel6.Visible = true;
            panel1.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel7.Visible = false;
            this.Size = new Size(291, 246);
        }

        private void bunifuFlatButton15_Click(object sender, EventArgs e)
        {
            Means main = this.Owner as Means;
            if (main != null)
            {
                main.place(comboBox8.Text);
            }
        }

        private void bunifuFlatButton13_Click(object sender, EventArgs e)
        {
            var b = dateTimePicker6.Text;
            var b1 = dateTimePicker5.Text;
            Print_reports f = new Print_reports(b, b1);
            f.Owner = this;
            f.place(comboBox8.Text);
            f.ShowDialog();
        }


        private void местоположениеОпределенногоСредстваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel7.Visible = true;
            panel1.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            this.Size = new Size(291, 310);
        }

        private void bunifuFlatButton17_Click_1(object sender, EventArgs e)
        {
            Means main = this.Owner as Means;
            if (main != null)
            {
                main.place_name(comboBox9.Text, comboBox7.Text);
            }
        }

        private void bunifuFlatButton16_Click_1(object sender, EventArgs e)
        {
            var b = dateTimePicker6.Text;
            var b1 = dateTimePicker5.Text;
            Print_reports f = new Print_reports(b, b1);
            f.Owner = this;
            f.place_name(comboBox9.Text, comboBox7.Text);
            f.ShowDialog();
        }
    }
}
