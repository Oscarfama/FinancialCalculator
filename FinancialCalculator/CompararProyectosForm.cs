using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialCalculator
{
    public partial class CompararProyectosForm : MetroFramework.Forms.MetroForm
    {
        public CompararProyectosForm()
        {
            InitializeComponent();
        }

        private void CompararProyectosForm_Load(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Hide();
        }

        private void btn_Cargar1_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Ingresos");
            table.Columns.Add("Egresos");
            int nper = Convert.ToInt32(txt_Per1.Text);
            for (int i = 0; i < nper - 1; i++)
            {
                table.Rows.Add();

            }
            metroGrid1.DataSource = table;
            foreach (DataGridViewRow row in metroGrid1.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
            }
        }

        private void cargar2_btn_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Ingresos");
            table.Columns.Add("Egresos");
            int nper = Convert.ToInt32(txt_Per2.Text);
            for (int i = 0; i < nper - 1; i++)
            {
                table.Rows.Add();

            }
            metroGrid2.DataSource = table;
            foreach (DataGridViewRow row in metroGrid2.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            //First project
            double trema = Convert.ToDouble(txt_TREMA1.Text);
            int nper = Convert.ToInt16(txt_Per1.Text);
            double[] flow1 = new double[nper];
            int cont = 0;
            foreach (DataGridViewRow row in metroGrid1.Rows)
            {
                if (cont < nper)
                {
                    flow1[cont] = Convert.ToDouble(row.Cells["Ingresos"].Value) - Convert.ToDouble(row.Cells["Egresos"].Value);
                    cont++;
                }
            }
            flow1[nper - 1] += Convert.ToDouble(txt_ValRec1.Text);
            double inicial = Convert.ToDouble(txt_CostoIn1.Text);
            Proyecto producto1 = new Proyecto(nper, trema, flow1, inicial);
            producto1.calcularVNA();
            producto1.calcularVAE();
            lbl_VNA1.Text = Convert.ToString(producto1.vna);
            lbl_VAE1.Text = Convert.ToString(producto1.vae);

            //Second Project
            trema = Convert.ToDouble(txt_TREMA2.Text);
            nper = Convert.ToInt16(txt_Per2.Text);
            double[] flow2 = new double[nper];
            cont = 0;
            foreach (DataGridViewRow row in metroGrid2.Rows)
            {
                if (cont < nper)
                {
                    flow2[cont] = Convert.ToDouble(row.Cells["Ingresos"].Value) - Convert.ToDouble(row.Cells["Egresos"].Value);
                    cont++;
                }
            }
            flow2[nper - 1] += Convert.ToDouble(txt_ValRec2.Text);
            inicial = Convert.ToDouble(txt_CostoIn2.Text);
            Proyecto producto2 = new Proyecto(nper, trema, flow2, inicial);
            producto2.calcularVNA();
            producto2.calcularVAE();
            lbl_VNA2.Text = Convert.ToString(producto2.vna);
            lbl_VAE2.Text = Convert.ToString(producto2.vae);
        }
    }
}
