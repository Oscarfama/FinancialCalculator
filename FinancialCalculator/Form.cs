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
    public partial class Form :  MetroFramework.Forms.MetroForm
    {
        public Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (txtINTFP.Text == "" || txtPERFP.Text == "" || txtPRESFP.Text == "")
            {
                errorMessage();
                return;
            }
            double interes = (Convert.ToDouble(txtINTFP.Text) / 100);
            int NumPeriodos = Convert.ToInt16(txtPERFP.Text);
            double ValorPresente = Convert.ToDouble(txtPRESFP.Text);
            double Res = ValorPresente * (Math.Pow(1 + interes, NumPeriodos));
            lblFP.Text = $" $ {Math.Round(Res, 3).ToString()}";
        }

        private void btn_FA_Click(object sender, EventArgs e)
        {
            if (txtINTFA.Text == "" || txtPERFA.Text == "" || txtANFA.Text == "")
            {
                errorMessage();
                return;
            }
            double interes = (Convert.ToDouble(txtINTFA.Text) / 100);
            int NumPeriodos = Convert.ToInt16(txtPERFA.Text);
            double ValorAnual = Convert.ToDouble(txtANFA.Text);
            double Res = ValorAnual * ((Math.Pow(1 + interes, NumPeriodos) - 1) / interes);
            lblFA.Text = $" $ {Math.Round(Res, 3).ToString()}";
        }

        private void btn_PF_Click(object sender, EventArgs e)
        {
            if (txtINTPF.Text == "" || txtPERPF.Text == "" || txtFUTPF.Text == "")
            {
                errorMessage();
                return;
            }
            double interes = (Convert.ToDouble(txtINTPF.Text) / 100);
            int NumPeriodos = Convert.ToInt16(txtPERPF.Text);
            double ValorFuturo = Convert.ToDouble(txtFUTPF.Text);
            double Res = ValorFuturo * (Math.Pow(1 + interes, -NumPeriodos));
            lblPF.Text = $" $ {Math.Round(Res, 3).ToString()}";
        }

        private void btn_PA_Click(object sender, EventArgs e)
        {
            if (txtINTPA.Text == "" || txtPERPA.Text == "" || txtANPA.Text == "")
            {
                errorMessage();
                return;
            }
            double interes = (Convert.ToDouble(txtINTPA.Text) / 100);
            int NumPeriodos = Convert.ToInt16(txtPERPA.Text);
            double ValorAnual = Convert.ToDouble(txtANPA.Text);
            double Res = ValorAnual * ((Math.Pow(1 + interes, NumPeriodos) - 1) / (interes * Math.Pow(1 + interes, NumPeriodos)));
            lblPA.Text = $" $ {Math.Round(Res, 3).ToString()}";

        }

        private void btn_AF_Click(object sender, EventArgs e)
        {
            if (txtINTAF.Text == "" || txtPERAF.Text == "" || txtFUTAF.Text == "")
            {
                errorMessage();
                return;
            }
            double interes = (Convert.ToDouble(txtINTAF.Text) / 100);
            int NumPeriodos = Convert.ToInt16(txtPERAF.Text);
            double ValorFuturo = Convert.ToDouble(txtFUTAF.Text);
            double Res = ValorFuturo * (interes / (Math.Pow(1 + interes, NumPeriodos) - 1));
            lblAF.Text =$" $ {Math.Round(Res, 3).ToString()}";
        }

        private void btn_AP_Click(object sender, EventArgs e)
        {
            if (txtINTAP.Text == "" || txtPERAP.Text == "" || txtPRESAP.Text == "")
            {
                errorMessage();
                return;
            }
            double interes = (Convert.ToDouble(txtINTAP.Text) / 100);
            int NumPeriodos = Convert.ToInt16(txtPERAP.Text);
            double ValorPresente = Convert.ToDouble(txtPRESAP.Text);
            double Res = ValorPresente * ((interes * (Math.Pow(1 + interes, NumPeriodos))) / (Math.Pow(1 + interes, NumPeriodos) - 1));
            lblAP.Text = $" $ {Math.Round(Res, 3).ToString()}";
        }
        public void errorMessage()
        {
            MessageBox.Show("Algun dato requerido esta vacio");
        }

        private void btn_Factores_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            tab1.Visible = true;

        }

        private void btn_Interes_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            tab1.Visible = false;
        }

        private void btn_Inversiones_Click(object sender, EventArgs e)
        {
            tab1.Visible = false;

        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            if(txt_tasaNom.Text == "" || txt_Peranio.Text == "")
            {
                errorMessage();
                return;
            }
            double tasaNom = (Convert.ToDouble(txt_tasaNom.Text) / 100);
            int NumPeriodos = Convert.ToInt16(txt_Peranio.Text);
            var Res = (Math.Pow(1 + (tasaNom/NumPeriodos), NumPeriodos) - 1) *100;
            lbl_IEF.Text = $"{Math.Round(Res,2).ToString()} %";
        }
    }
}
