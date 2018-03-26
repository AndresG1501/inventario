namespace grInv
{
    partial class regFamilia
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
            this.lblNom = new System.Windows.Forms.Label();
            this.txtNomF = new System.Windows.Forms.TextBox();
            this.dtFamilia = new System.Data.DataTable();
            this.dcFamilia_Nombre = new System.Data.DataColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFamilia)).BeginInit();
            this.SuspendLayout();
            // 
            // bs
            // 
            this.bs.DataMember = "Familia";
            this.bs.DataSource = this.ds;
            // 
            // ds
            // 
            this.ds.Tables.AddRange(new System.Data.DataTable[] {
            this.dtFamilia});
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(13, 13);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(44, 13);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nombre";
            // 
            // txtNomF
            // 
            this.txtNomF.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "nomFamilia", true));
            this.txtNomF.Location = new System.Drawing.Point(12, 29);
            this.txtNomF.Name = "txtNomF";
            this.txtNomF.Size = new System.Drawing.Size(214, 20);
            this.txtNomF.TabIndex = 1;
            // 
            // dtFamilia
            // 
            this.dtFamilia.Columns.AddRange(new System.Data.DataColumn[] {
            this.dcFamilia_Nombre});
            this.dtFamilia.TableName = "Familia";
            // 
            // dcFamilia_Nombre
            // 
            this.dcFamilia_Nombre.ColumnName = "nomFamilia";
            // 
            // regFamilia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(238, 74);
            this.Controls.Add(this.txtNomF);
            this.Controls.Add(this.lblNom);
            this.Name = "regFamilia";
            this.Text = "Registro de Familia";
            this.Load += new System.EventHandler(this.regFamilia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFamilia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.DataTable dtFamilia;
        private System.Data.DataColumn dcFamilia_Nombre;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtNomF;
    }
}
