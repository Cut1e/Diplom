using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Measuring
{
    public partial class Measuring_form : Form
    {
        public Measuring_form()
        {
            InitializeComponent();
        }
        bool mnuExpanded = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!bunifuTransition1.IsCompleted) return;
            if (panel1.ClientRectangle.Contains(PointToClient(Control.MousePosition)))
            {
                if (!mnuExpanded)
                {
                    mnuExpanded = true;
                    panel1.Width = 233;
                }
            }
            else
            {
                if (mnuExpanded)
                {
                    mnuExpanded = false;
                    panel1.Visible = false;
                    panel1.Width = 45;
                    bunifuTransition1.Show(panel1);
                }
            }
        }
        private void DropDown()
        {
            panel4.Visible = false;
        }
        private void hideDropDown()
        {
            if (panel4.Visible == true)
                panel4.Visible = false;
        }
        private void showDropDown(Panel drop)
        {
            if (drop.Visible == false)
            {
                drop.Visible = true;
            }
            else
                drop.Visible = false;
        }
        private void dropDown(Panel drop)
        {
                drop.Visible = false;
        }

        private void tab1_Click(object sender, EventArgs e)
        {

        }
        private void tab1_Click_1(object sender, EventArgs e)
        {
            showDropDown(panel4);
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            hideDropDown();
            openChildFrom(new Verification());
        }
        private Form activeFrom = null;
        private void openChildFrom(Form childForm)
        {
            if (activeFrom != null)
                activeFrom.Close();
            activeFrom = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel3.Controls.Add(childForm);
            panel3.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {
            openChildFrom(new Result());
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            openChildFrom(new witness());
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            openChildFrom(new type_of_measuring());
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            openChildFrom(new Name_of_measuring());
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
    
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            openChildFrom(new Position());
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            openChildFrom(new Responsible());
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
        }
        private void bunifuFlatButton10_Click(object sender, EventArgs e)
        {
           
        }
        public void add_organization()
        {
            if (File.Exists(writePath2))
            {
                using (StreamReader sr = new StreamReader(writePath2))
                {
                    label1.Text = sr.ReadLine();
                }
            }     
        }
        string writePath2 = @"org.dat";
        private void Measuring_form_Load(object sender, EventArgs e)
        {
            if (File.Exists(writePath2))
            {
                add_organization();
            }
            else
            {
                Organization f = new Organization();
                f.Owner = this;
                f.ShowDialog();
            }
            openChildFrom(new Verification());
            dropDown(panel4);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Organization f = new Organization();
            f.Owner = this;
            f.ShowDialog();
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.Font = new Font("Segoe UI Semibold", 16);
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.Font = new Font("Segoe UI Semibold", 12);
        }

        private void bunifuFlatButton4_Click_1(object sender, EventArgs e)
        {
            openChildFrom(new Adres());
        }

        private void bunifuFlatButton10_Click_1(object sender, EventArgs e)
        {
            openChildFrom(new Means());
        }
    }
}
