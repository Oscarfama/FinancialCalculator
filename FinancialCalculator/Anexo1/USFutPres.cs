using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialCalculator
{
    public partial class USAnnPres : MetroFramework.Controls.MetroUserControl
    {
        public USAnnPres()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            double interes = (Convert.ToInt16(Interesttxt.Text)/100);
            int NumPeriodos = Convert.ToInt16(PeriodosTxt.Text);
            double ValorPresente = Convert.ToDouble(ValorPresentetxt.Text);
            double Res = ValorPresente * (Math.Pow(1+interes,NumPeriodos));
            ResultadoLabel.Text = Res.ToString();            
        }
    }
}
