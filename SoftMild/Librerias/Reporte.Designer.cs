namespace Librerias
{
    partial class Reporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reporte));
            this.cboReporte = new System.Windows.Forms.ComboBox();
            this.lblReporte = new System.Windows.Forms.Label();
            this.dtReporte = new System.Data.DataTable();
            this.dcReporte_nomReporte = new System.Data.DataColumn();
            this.dcReporte_SQL = new System.Data.DataColumn();
            this.dgvReporte = new System.Windows.Forms.DataGridView();
            this.dcReporte_idPK = new System.Data.DataColumn();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtReporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).BeginInit();
            this.SuspendLayout();
            // 
            // ds
            // 
            this.ds.DataSetName = "yo la esper";
            this.ds.Tables.AddRange(new System.Data.DataTable[] {
            this.dtReporte});
            // 
            // cboReporte
            // 
            this.cboReporte.DisplayMember = "nomReporte";
            this.cboReporte.FormattingEnabled = true;
            this.cboReporte.Location = new System.Drawing.Point(15, 30);
            this.cboReporte.Name = "cboReporte";
            this.cboReporte.Size = new System.Drawing.Size(168, 21);
            this.cboReporte.TabIndex = 0;
            this.cboReporte.Tag = resources.GetString("cboReporte.Tag");
            this.cboReporte.ValueMember = "idReporte";
            this.cboReporte.SelectionChangeCommitted += new System.EventHandler(this.cboReporte_SelectionChangeCommitted);
            // 
            // lblReporte
            // 
            this.lblReporte.AutoSize = true;
            this.lblReporte.Location = new System.Drawing.Point(12, 14);
            this.lblReporte.Name = "lblReporte";
            this.lblReporte.Size = new System.Drawing.Size(45, 13);
            this.lblReporte.TabIndex = 1;
            this.lblReporte.Text = "Reporte";
            // 
            // dtReporte
            // 
            this.dtReporte.Columns.AddRange(new System.Data.DataColumn[] {
            this.dcReporte_nomReporte,
            this.dcReporte_SQL,
            this.dcReporte_idPK});
            this.dtReporte.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "idReporte"}, true)});
            this.dtReporte.PrimaryKey = new System.Data.DataColumn[] {
        this.dcReporte_idPK};
            this.dtReporte.TableName = "Reporte";
            // 
            // dcReporte_nomReporte
            // 
            this.dcReporte_nomReporte.ColumnName = "nomReporte";
            // 
            // dcReporte_SQL
            // 
            this.dcReporte_SQL.ColumnName = "SQL";
            // 
            // dgvReporte
            // 
            this.dgvReporte.AllowUserToAddRows = false;
            this.dgvReporte.AllowUserToDeleteRows = false;
            this.dgvReporte.AllowUserToOrderColumns = true;
            this.dgvReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporte.Location = new System.Drawing.Point(15, 75);
            this.dgvReporte.Name = "dgvReporte";
            this.dgvReporte.ReadOnly = true;
            this.dgvReporte.Size = new System.Drawing.Size(659, 331);
            this.dgvReporte.TabIndex = 2;
            this.dgvReporte.Visible = false;
            // 
            // dcReporte_idPK
            // 
            this.dcReporte_idPK.AllowDBNull = false;
            this.dcReporte_idPK.ColumnName = "idReporte";
            this.dcReporte_idPK.DataType = typeof(int);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(189, 15);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(35, 13);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Hasta";
            this.lblFecha.Visible = false;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(189, 31);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(200, 20);
            this.dtpHasta.TabIndex = 4;
            this.dtpHasta.Visible = false;
            // 
            // Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(686, 418);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dgvReporte);
            this.Controls.Add(this.lblReporte);
            this.Controls.Add(this.cboReporte);
            this.KeyPreview = true;
            this.Name = "Reporte";
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.Reporte_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Reporte_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtReporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboReporte;
        private System.Windows.Forms.Label lblReporte;
        private System.Data.DataTable dtReporte;
        private System.Data.DataColumn dcReporte_nomReporte;
        private System.Data.DataColumn dcReporte_SQL;
        private System.Windows.Forms.DataGridView dgvReporte;
        private System.Data.DataColumn dcReporte_idPK;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpHasta;
    }
}
