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
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Producto_Click(object sender, EventArgs e)
        {
            CompararProductosForm form = new CompararProductosForm();
            form.Owner = this;
            form.Show();
            this.Hide();
        }

        private void btn_Proyecto_Click(object sender, EventArgs e)
        {
            CompararProyectosForm form = new CompararProyectosForm();
            form.Owner = this;
            form.Show();
            this.Hide();
        }
    }
}
