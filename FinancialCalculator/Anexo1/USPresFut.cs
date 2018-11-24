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
    public partial class USPresFut : MetroFramework.Controls.MetroUserControl
    {
        public USPresFut()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            double interes = (Convert.ToInt16(Interesttxt.Text) / 100);
            int NumPeriodos = Convert.ToInt16(PeriodosTxt.Text);
            double ValorFuturo = Convert.ToDouble(ValorFuturotxt.Text);
            double Res = ValorFuturo * (Math.Pow(1 + interes,-NumPeriodos));
            ResultadoLabel.Text = Res.ToString();
        }
    }
}
