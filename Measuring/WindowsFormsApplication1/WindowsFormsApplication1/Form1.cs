using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'measuringDataSet.Means' table. You can move, or remove it, as needed.
            this.meansTableAdapter.Fill(this.measuringDataSet.Means);
            // TODO: This line of code loads data into the 'measuringDataSet.Verification' table. You can move, or remove it, as needed.
            this.verificationTableAdapter.Fill(this.measuringDataSet.Verification);
            dataBuff.DataSource = null;
            dataBuff.DataSource = meansBindingSource;
            for (int i = 1; i < 31; i++)
                dataGridView1.Columns[i].HeaderText = DateTime.Now.AddDays(i - 1).ToShortDateString();

            for (int i = 0; i < dataBuff.RowCount; i++)
                dataGridView1.Rows.Add(dataBuff.Rows[i].Cells[0].Value.ToString());

            dataBuff.DataSource = null;
            dataBuff.DataSource = verificationBindingSource;
            for (int i = 1; i < 31; i++)
            {
                this.verificationTableAdapter.FillBy(this.measuringDataSet.Verification, dataGridView1.Columns[i].HeaderText);
                if(dataBuff.RowCount>0)
                {
                    for(int j=0;j<dataGridView1.RowCount;j++)
                    {
                        for(int c=0;c<dataBuff.RowCount;c++)                        
                        if(dataBuff.Rows[c].Cells[5].Value.ToString().Equals(dataGridView1.Rows[j].Cells[0].Value.ToString()))
                            {
                                //dataGridView1.Rows[j].Cells[i].Value += dataBuff.Rows[c].Cells[0].Value.ToString();
                                dataGridView1.Rows[j].Cells[i].Style.BackColor = Color.LawnGreen;

                            }
                    }
                }
            }

            //for (int b = 0; b < dataBuff.RowCount; b++)
            //    for (int c = 0; c < dataGridView1.RowCount; c++)
            //        MessageBox.Show(dataBuff.Rows[b].Cells[2].Value.ToString());
            //if (dataGridView1.Rows[c].Cells[0].Value.ToString().Equals(dataBuff.Rows[b].Cells[18].Value.ToString()))
            //{
            //    dataGridView1.Rows[c].Cells[i].Value += dataBuff.Rows[b].Cells[15].Value.ToString();
            //    dataGridView1.Rows[c].Cells[i].Value += " " + dataBuff.Rows[b].Cells[12].Value.ToString() + "\n";
            //    dataGridView1.Rows[c].Cells[i].Style.BackColor = Color.LawnGreen;

            //}
        }

        private void verificationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.verificationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.measuringDataSet);

        }
    }
}
