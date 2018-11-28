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

        }
    }
}
