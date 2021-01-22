using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Measuring
{
    public partial class Add_witness : Form
    {
        public Add_witness()
        {
            InitializeComponent();
        }
        private void add()
        {
            witness main = this.Owner as witness;
            if (main != null)
            {
                if (radioButton1.Checked == true)
                {
                    main.add_witness(bunifuTextBox1.Text, bunifuTextBox2.Text, bunifuTextBox3.Text, maskedTextBox1.Text,bunifuTextBox4.Text);
                }
                else
                {
                    main.add_witness(bunifuTextBox1.Text, bunifuTextBox2.Text, bunifuTextBox3.Text, maskedTextBox2.Text, bunifuTextBox4.Text);
                }
            }
        }
        private void bunifuFlatButton14_Click(object sender, EventArgs e)
        {
            string a = maskedTextBox1.Text;
            string a1 = maskedTextBox2.Text;
            if (bunifuTextBox1.Text=="")
            {
                MessageBox.Show("Введите ФИО поверителя", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           if(a.Length==16 && a1.Length==16 ||  bunifuTextBox2.Text == "" || bunifuTextBox4.Text == "" || bunifuTextBox3.Text == "" || radioButton1.Checked==false && radioButton2.Checked==false )
            {
                    if (MessageBox.Show("Не заполнены все поля. Добавить?", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        add();
                        return;
                    }
                    else return;
                }          
            if (MessageBox.Show("Вы уверены что хотите добавить?", "Внмание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                add();
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false)
            {
                maskedTextBox1.Text = "";
                maskedTextBox1.ReadOnly = true;
            }
            if (radioButton1.Checked == true)
            {
                maskedTextBox1.ReadOnly = false;
            }
            if (radioButton2.Checked == false)
            {
                maskedTextBox2.Text = "";
                maskedTextBox2.ReadOnly = true;
            }
            if (radioButton2.Checked == true)
            {
                maskedTextBox2.ReadOnly = false;
            }
        }

        private void Add_witness_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
        }
    }
}
