namespace FinancialCalculator
{
    partial class Form1
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
            this.btn_Producto = new MetroFramework.Controls.MetroButton();
            this.btn_Proyecto = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btn_Producto
            // 
            this.btn_Producto.Location = new System.Drawing.Point(153, 107);
            this.btn_Producto.Name = "btn_Producto";
            this.btn_Producto.Size = new System.Drawing.Size(154, 74);
            this.btn_Producto.TabIndex = 0;
            this.btn_Producto.Text = "Comparar Producto";
            this.btn_Producto.UseSelectable = true;
            this.btn_Producto.Click += new System.EventHandler(this.btn_Producto_Click);
            // 
            // btn_Proyecto
            // 
            this.btn_Proyecto.Location = new System.Drawing.Point(442, 107);
            this.btn_Proyecto.Name = "btn_Proyecto";
            this.btn_Proyecto.Size = new System.Drawing.Size(154, 74);
            this.btn_Proyecto.TabIndex = 1;
            this.btn_Proyecto.Text = "Comparar Proyecto";
            this.btn_Proyecto.UseSelectable = true;
            this.btn_Proyecto.Click += new System.EventHandler(this.btn_Proyecto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 267);
            this.Controls.Add(this.btn_Proyecto);
            this.Controls.Add(this.btn_Producto);
            this.Name = "Form1";
            this.Text = "Comparación";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btn_Producto;
        private MetroFramework.Controls.MetroButton btn_Proyecto;
    }
}