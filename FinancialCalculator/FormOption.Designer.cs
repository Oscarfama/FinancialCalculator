namespace FinancialCalculator
{
    partial class FormOption
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Formulas = new MetroFramework.Controls.MetroButton();
            this.btn_comparation = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btn_Formulas
            // 
            this.btn_Formulas.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_Formulas.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_Formulas.Location = new System.Drawing.Point(75, 109);
            this.btn_Formulas.Name = "btn_Formulas";
            this.btn_Formulas.Size = new System.Drawing.Size(130, 52);
            this.btn_Formulas.TabIndex = 0;
            this.btn_Formulas.Text = "Formulas";
            this.btn_Formulas.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btn_Formulas.UseSelectable = true;
            this.btn_Formulas.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // btn_comparation
            // 
            this.btn_comparation.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_comparation.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_comparation.Location = new System.Drawing.Point(282, 109);
            this.btn_comparation.Name = "btn_comparation";
            this.btn_comparation.Size = new System.Drawing.Size(130, 52);
            this.btn_comparation.TabIndex = 1;
            this.btn_comparation.Text = "Comparación";
            this.btn_comparation.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btn_comparation.UseSelectable = true;
            this.btn_comparation.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // FormOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 239);
            this.Controls.Add(this.btn_comparation);
            this.Controls.Add(this.btn_Formulas);
            this.Name = "FormOption";
            this.Text = "Bienvenido, por favor seleccione una opción:";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btn_Formulas;
        private MetroFramework.Controls.MetroButton btn_comparation;
    }
}