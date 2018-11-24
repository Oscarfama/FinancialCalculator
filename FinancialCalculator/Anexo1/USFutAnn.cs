using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialCalculator.Anexo1
{
    public partial class USFutAnn : MetroFramework.Controls.MetroUserControl
    {
        public USFutAnn()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            double interes = (Convert.ToInt16(Interesttxt.Text) / 100);
            int NumPeriodos = Convert.ToInt16(PeriodosTxt.Text);
            double ValorAnual = Convert.ToDouble(ValorAnualtxt.Text);
            double Res = ValorAnual * ((Math.Pow(1+interes,NumPeriodos)-1)/interes);
            ResultadoLabel.Text = Res.ToString();
        }
    }
}
