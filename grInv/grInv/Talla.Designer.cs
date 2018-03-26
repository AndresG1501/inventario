namespace grInv
{
    partial class Talla
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTalla = new System.Windows.Forms.TextBox();
            this.dtTalla = new System.Data.DataTable();
            this.dcTalla_nomTalla = new System.Data.DataColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTalla)).BeginInit();
            this.SuspendLayout();
            // 
            // bs
            // 
            this.bs.DataMember = "Talla";
            this.bs.DataSource = this.ds;
            // 
            // ds
            // 
            this.ds.Tables.AddRange(new System.Data.DataTable[] {
            this.dtTalla});
            // 
            // txtTalla
            // 
            this.txtTalla.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "nomTalla", true));
            this.txtTalla.Location = new System.Drawing.Point(12, 24);
            this.txtTalla.Name = "txtTalla";
            this.txtTalla.Size = new System.Drawing.Size(100, 20);
            this.txtTalla.TabIndex = 0;
            // 
            // dtTalla
            // 
            this.dtTalla.Columns.AddRange(new System.Data.DataColumn[] {
            this.dcTalla_nomTalla});
            this.dtTalla.TableName = "Talla";
            // 
            // dcTalla_nomTalla
            // 
            this.dcTalla_nomTalla.ColumnName = "nomTalla";
            // 
            // Talla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(219, 65);
            this.Controls.Add(this.txtTalla);
            this.Name = "Talla";
            this.Text = "Registro de Talla";
            this.Load += new System.EventHandler(this.Talla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTalla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTalla;
        private System.Data.DataTable dtTalla;
        private System.Data.DataColumn dcTalla_nomTalla;
    }
}
