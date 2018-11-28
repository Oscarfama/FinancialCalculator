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
    public partial class CompararProductosForm :MetroFramework.Forms.MetroForm
    {
        public CompararProductosForm()
        {
            InitializeComponent();
        }

        private void CompararProductosForm_Load(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Hide();
        }

        private void btn_Comparar_Click(object sender, EventArgs e)
        {
            double trema = Convert.ToDouble(Prod1Trema.Text);
            int nper = Convert.ToInt16(Prod1Per.Text);
            double[] flow1 = new double[nper];
            double mantenimiento = Convert.ToDouble(Prod1Mant.Text);
            for (int i = 0; i < nper; i++)
            {
                flow1[i] = -mantenimiento;
            }
            flow1[nper - 1] += Convert.ToDouble(Prod1ValRec.Text);
            double inicial = Convert.ToDouble(Prod1CostInicial.Text);
            Proyecto producto1 = new Proyecto(nper, trema, flow1, inicial);
            producto1.calcularVNA();
            producto1.calcularVAE();
            lbl_VNA1.Text = Convert.ToString(producto1.vna);
            lbl_VAE1.Text = Convert.ToString(producto1.vae);

            //Second Project
            trema = Convert.ToDouble(Prod2Trema.Text);
            nper = Convert.ToInt16(Prod2Per.Text);
            double[] flow2 = new double[nper];
            mantenimiento = Convert.ToDouble(Prod2Mant.Text);
            for (int i = 0; i < nper; i++)
            {
                flow2[i] = -mantenimiento;
            }
            flow2[nper - 1] += Convert.ToDouble(Prod2ValRec.Text);
            inicial = Convert.ToDouble(Prod2CostInicial.Text);
            Proyecto producto2 = new Proyecto(nper, trema, flow2, inicial);
            producto2.calcularVNA();
            producto2.calcularVAE();
            lbl_VNA2.Text = Convert.ToString(producto2.vna);
            lbl_VAE2.Text = Convert.ToString(producto2.vae);
        }
    }
}
