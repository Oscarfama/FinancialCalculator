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
            double res = FP(interes,NumPeriodos,ValorPresente);
            lblFP.Text = $" $ {Math.Round(res, 3).ToString()}";
        }
        public double FP(double interes,int NumPeriodos, double ValorPresente)
        {
            double Res = ValorPresente * (Math.Pow(1 + interes, NumPeriodos));
            return Res;
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
            lblFA.Text = $" $ {Math.Round(FA(interes, NumPeriodos, ValorAnual), 3).ToString()}";
        }
        public double FA(double interes, int NumPeriodos, double ValorAnual)
        {
            double Res = ValorAnual * ((Math.Pow(1 + interes, NumPeriodos) - 1) / interes);
            return Res;
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
            lblPF.Text = $" $ {Math.Round(PF(interes,NumPeriodos,ValorFuturo), 3).ToString()}";
        }

        public double PF(double interes, int NumPeriodos, double ValorFuturo)
        {
            double Res = ValorFuturo * (Math.Pow(1 + interes, -NumPeriodos));
            return Res;

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
            lblPA.Text = $" $ {Math.Round(PA(interes,NumPeriodos,ValorAnual), 3).ToString()}";
        }
        public double PA(double interes, int NumPeriodos, double ValorAnual)
        {
            double Res = ValorAnual * ((Math.Pow(1 + interes, NumPeriodos) - 1) / (interes * Math.Pow(1 + interes, NumPeriodos)));
            return Res;
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
            lblAF.Text =$" $ {Math.Round(AF(interes,NumPeriodos,ValorFuturo), 3).ToString()}";
        }
        public double AF(double interes, int NumPeriodos, double ValorFuturo)
        {
            double Res = ValorFuturo * (interes / (Math.Pow(1 + interes, NumPeriodos) - 1));
            return Res;
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
            lblAP.Text = $" $ {Math.Round(AP(interes,NumPeriodos,ValorPresente), 3).ToString()}";
        }
        public double AP(double interes, int NumPeriodos, double ValorPresente)
        {
            double Res = ValorPresente * ((interes * (Math.Pow(1 + interes, NumPeriodos))) / (Math.Pow(1 + interes, NumPeriodos) - 1));
            return Res;
        }

        public void errorMessage()
        {
            MessageBox.Show("Algun dato requerido esta vacio");
        }

        private void btn_Factores_Click(object sender, EventArgs e)
        {
            tab1.Visible = true;
            panel1.Visible = false;
            metroTabControl1.Visible = false;


        }

        private void btn_Interes_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            tab1.Visible = false;
            metroTabControl1.Visible = false;

        }

        private void btn_Inversiones_Click(object sender, EventArgs e)
        {
            metroTabControl1.Visible = true;
            tab1.Visible = false;
            panel1.Visible = false;

        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            if(txt_tasaNom.Text == "" || txt_Peranio.Text == "")
            {
                errorMessage();
                return;
            }
            double tasaNom = (Convert.ToDouble(txt_tasaNom.Text));
            int NumPeriodos = Convert.ToInt16(txt_Peranio.Text);
            var Res = (Math.Pow(1 + (tasaNom/NumPeriodos), NumPeriodos) - 1);
            lbl_IEF.Text = $"{Math.Round(Res,2).ToString()} %";
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (txt_IntFP.Text== "" || txt_ValPresFP.Text== "" || txt_ValFutFP.Text == "")
            {
                errorMessage();
                return;
            }
            double interes = (Convert.ToDouble(txt_IntFP.Text) /100);
            double ValorPresente = Convert.ToDouble(txt_ValPresFP.Text);
            double ValorFuturo = Convert.ToDouble(txt_ValFutFP.Text);

            double res = (Math.Log(ValorFuturo / ValorPresente)) / (Math.Log(1+ interes));
            lbl_anFP.Text = Math.Round(res, 2).ToString();


        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            if (txt_IntPA.Text == "" || txt_ValPresPA.Text == "" || txt_ValAnPA.Text == "")
            {
                errorMessage();
                return;
            }
            double interes = (Convert.ToDouble(txt_IntPA.Text) / 100);
            double ValorPresente = Convert.ToDouble(txt_ValPresPA.Text);
            double ValorAnual = Convert.ToDouble(txt_ValAnPA.Text);

            double res = -(Math.Log(1 - interes * (ValorPresente / ValorAnual))) / (Math.Log(1 + interes));

            lbl_anPA.Text = Math.Round(res, 2).ToString();

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            if (txt_IntFA.Text == "" || txt_ValFutFA.Text == "" || txt_ValAnFA.Text == "")
            {
                errorMessage();
                return;
            }
            double interes = (Convert.ToDouble(txt_IntFA.Text) /100);
            double ValorFuturo = Convert.ToDouble(txt_ValFutFA.Text);
            double ValorAnual = Convert.ToDouble(txt_ValAnFA.Text);

            double res =(Math.Log(1 + interes * (ValorFuturo / ValorAnual))) / (Math.Log(1 + interes));
            lbl_anFA.Text = Math.Round(res, 2).ToString();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Hide();
        }

        private void Form_Load(object sender, EventArgs e)
        {

        }
    }
}
