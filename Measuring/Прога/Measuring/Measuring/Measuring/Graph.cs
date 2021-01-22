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
    public partial class Graph : Form
    {
        public Graph()
        {
            InitializeComponent();
        }

        private void Graph_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'measuringDataSet.Graph' table. You can move, or remove it, as needed.
            this.graphTableAdapter.Fill(this.measuringDataSet.Graph);
            // TODO: This line of code loads data into the 'measuringDataSet.Graph' table. You can move, or remove it, as needed.
            this.graphTableAdapter.Fill(this.measuringDataSet.Graph);
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
            dataBuff.DataSource = graphBindingSource;
            for (int i = 1; i < 31; i++)
            {
               //int a = this.graphTableAdapter.FillBy1(this.measuringDataSet.Graph, Convert.ToDateTime(dataGridView1.Columns[i].HeaderText));
                this.graphTableAdapter.FillBy(this.measuringDataSet.Graph,Convert.ToDateTime(dataGridView1.Columns[i].HeaderText));
                //if (a==0)
               
                if (dataBuff.RowCount > 0)
                {
                    for (int j = 0; j <dataGridView1.RowCount; j++)
                    {
                        for (int c = 0; c < dataBuff.RowCount; c++)
                            if (dataBuff.Rows[c].Cells[5].Value.ToString().Equals(dataGridView1.Rows[j].Cells[0].Value.ToString()))
                            {
                              dataGridView1.Rows[j].Cells[i].Style.BackColor = Color.LawnGreen;

                            }
                    }

                }
            }
            for (int i = 1; i < 31; i++)
            {
                this.graphTableAdapter.FillBy1(this.measuringDataSet.Graph, Convert.ToDateTime(dataGridView1.Columns[i].HeaderText));
                if (dataBuff.RowCount > 0)
                {
                    for (int j = 0; j < dataGridView1.RowCount; j++)
                    {
                        for (int c = 0; c < dataBuff.RowCount; c++)
                            if (dataBuff.Rows[c].Cells[5].Value.ToString().Equals(dataGridView1.Rows[j].Cells[0].Value.ToString()))
                            {
                                dataGridView1.Rows[j].Cells[i].Style.BackColor = Color.LawnGreen;

                            }
                    }

                }
            }
        }
    }
}
