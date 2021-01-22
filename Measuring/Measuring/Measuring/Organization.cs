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
    public partial class Organization : Form
    {
        string writePath = @"org.dat";
        public Organization()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {          
            File.Delete(writePath);
            using (StreamWriter sw = File.AppendText(writePath))
            {

                sw.WriteLine(bunifuTextBox3.Text);
            }
            Measuring_form main = this.Owner as Measuring_form;
            if (main != null)
            {
                main.add_organization();
                MessageBox.Show("Организация успешно изменена", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
        }
        private void Organization_Load(object sender, EventArgs e)
        {
            if (File.Exists(writePath))
            {
                using (StreamReader sr = new StreamReader(writePath))
                {
                    bunifuTextBox3.Text = sr.ReadLine();
                }
            }
        }
    }
}
