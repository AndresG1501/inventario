namespace grInv
{
    partial class Inv
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inv));
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.bsDoc = new System.Windows.Forms.BindingSource(this.components);
            this.dgvInv = new System.Windows.Forms.DataGridView();
            this.dgvcDI_idProducto = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvcDI_idCualidad = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvcDI_idTalla = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.idDocInvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idInvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblDes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dtDoc = new System.Data.DataTable();
            this.dcDoc_idDoc = new System.Data.DataColumn();
            this.dcDoc_codDoc = new System.Data.DataColumn();
            this.dcDoc_numDoc = new System.Data.DataColumn();
            this.dcDoc_fechaDoc = new System.Data.DataColumn();
            this.dcDoc_idCreador = new System.Data.DataColumn();
            this.dcDoc_Detalle = new System.Data.DataColumn();
            this.dtInv = new System.Data.DataTable();
            this.dcInv_idPK = new System.Data.DataColumn();
            this.dcInv_idProducto = new System.Data.DataColumn();
            this.dcInv_idU = new System.Data.DataColumn();
            this.dcInv_Existencia = new System.Data.DataColumn();
            this.dcInv_idTalla = new System.Data.DataColumn();
            this.dcInv_idCualidad = new System.Data.DataColumn();
            this.dtDoc_Inv = new System.Data.DataTable();
            this.dcDI_idPK = new System.Data.DataColumn();
            this.dcDI_idInv = new System.Data.DataColumn();
            this.dcDI_idDoc = new System.Data.DataColumn();
            this.dcDI_Cantidad = new System.Data.DataColumn();
            this.dcDI_CostoU = new System.Data.DataColumn();
            this.dcDI_CostoT = new System.Data.DataColumn();
            this.dcDI_Dcto = new System.Data.DataColumn();
            this.dcDI_idTalla = new System.Data.DataColumn();
            this.dcDI_idProducto = new System.Data.DataColumn();
            this.dcDI_idEstado = new System.Data.DataColumn();
            this.dcDI_idCualidad = new System.Data.DataColumn();
            this.txtNumDoc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDoc_Inv)).BeginInit();
            this.SuspendLayout();
            // 
            // bs
            // 
            this.bs.DataMember = "Doc_Inv";
            this.bs.DataSource = this.ds;
            // 
            // ds
            // 
            this.ds.Tables.AddRange(new System.Data.DataTable[] {
            this.dtDoc,
            this.dtInv,
            this.dtDoc_Inv});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsDoc, "fechaDoc", true));
            this.dateTimePicker1.Location = new System.Drawing.Point(16, 30);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // bsDoc
            // 
            this.bsDoc.DataMember = "Doc";
            this.bsDoc.DataSource = this.ds;
            // 
            // dgvInv
            // 
            this.dgvInv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInv.AutoGenerateColumns = false;
            this.dgvInv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcDI_idProducto,
            this.dgvcDI_idCualidad,
            this.dgvcDI_idTalla,
            this.idDocInvDataGridViewTextBoxColumn,
            this.idInvDataGridViewTextBoxColumn,
            this.idDocDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.costoUDataGridViewTextBoxColumn,
            this.descuentoDataGridViewTextBoxColumn,
            this.costoTDataGridViewTextBoxColumn});
            this.dgvInv.DataSource = this.bs;
            this.dgvInv.Location = new System.Drawing.Point(16, 57);
            this.dgvInv.Name = "dgvInv";
            this.dgvInv.Size = new System.Drawing.Size(869, 356);
            this.dgvInv.TabIndex = 2;
            this.dgvInv.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvInv_CellBeginEdit);
            this.dgvInv.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInv_CellValueChanged);
            this.dgvInv.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvInv_UserDeletingRow);
            // 
            // dgvcDI_idProducto
            // 
            this.dgvcDI_idProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvcDI_idProducto.DataPropertyName = "_idProducto";
            this.dgvcDI_idProducto.HeaderText = "Producto";
            this.dgvcDI_idProducto.Name = "dgvcDI_idProducto";
            this.dgvcDI_idProducto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcDI_idProducto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dgvcDI_idCualidad
            // 
            this.dgvcDI_idCualidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvcDI_idCualidad.DataPropertyName = "_idCualidad";
            this.dgvcDI_idCualidad.HeaderText = "Color";
            this.dgvcDI_idCualidad.Name = "dgvcDI_idCualidad";
            // 
            // dgvcDI_idTalla
            // 
            this.dgvcDI_idTalla.DataPropertyName = "_idTalla";
            this.dgvcDI_idTalla.HeaderText = "Talla";
            this.dgvcDI_idTalla.Name = "dgvcDI_idTalla";
            // 
            // idDocInvDataGridViewTextBoxColumn
            // 
            this.idDocInvDataGridViewTextBoxColumn.DataPropertyName = "idDoc_Inv";
            this.idDocInvDataGridViewTextBoxColumn.HeaderText = "idDoc_Inv";
            this.idDocInvDataGridViewTextBoxColumn.Name = "idDocInvDataGridViewTextBoxColumn";
            this.idDocInvDataGridViewTextBoxColumn.Visible = false;
            // 
            // idInvDataGridViewTextBoxColumn
            // 
            this.idInvDataGridViewTextBoxColumn.DataPropertyName = "idInv";
            this.idInvDataGridViewTextBoxColumn.HeaderText = "idInv";
            this.idInvDataGridViewTextBoxColumn.Name = "idInvDataGridViewTextBoxColumn";
            this.idInvDataGridViewTextBoxColumn.Visible = false;
            // 
            // idDocDataGridViewTextBoxColumn
            // 
            this.idDocDataGridViewTextBoxColumn.DataPropertyName = "idDoc";
            this.idDocDataGridViewTextBoxColumn.HeaderText = "idDoc";
            this.idDocDataGridViewTextBoxColumn.Name = "idDocDataGridViewTextBoxColumn";
            this.idDocDataGridViewTextBoxColumn.Visible = false;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            // 
            // costoUDataGridViewTextBoxColumn
            // 
            this.costoUDataGridViewTextBoxColumn.DataPropertyName = "CostoU";
            this.costoUDataGridViewTextBoxColumn.HeaderText = "CostoU";
            this.costoUDataGridViewTextBoxColumn.Name = "costoUDataGridViewTextBoxColumn";
            // 
            // descuentoDataGridViewTextBoxColumn
            // 
            this.descuentoDataGridViewTextBoxColumn.DataPropertyName = "Descuento";
            this.descuentoDataGridViewTextBoxColumn.HeaderText = "Descuento";
            this.descuentoDataGridViewTextBoxColumn.Name = "descuentoDataGridViewTextBoxColumn";
            // 
            // costoTDataGridViewTextBoxColumn
            // 
            this.costoTDataGridViewTextBoxColumn.DataPropertyName = "CostoT";
            this.costoTDataGridViewTextBoxColumn.HeaderText = "Costo Total";
            this.costoTDataGridViewTextBoxColumn.Name = "costoTDataGridViewTextBoxColumn";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDoc, "Detalle", true));
            this.textBox1.Location = new System.Drawing.Point(16, 432);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(358, 76);
            this.textBox1.TabIndex = 3;
            // 
            // lblDes
            // 
            this.lblDes.AutoSize = true;
            this.lblDes.Location = new System.Drawing.Point(13, 416);
            this.lblDes.Name = "lblDes";
            this.lblDes.Size = new System.Drawing.Size(63, 13);
            this.lblDes.TabIndex = 4;
            this.lblDes.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(562, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "TOTAL";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(688, 434);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(15, 16);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "0";
            // 
            // dtDoc
            // 
            this.dtDoc.Columns.AddRange(new System.Data.DataColumn[] {
            this.dcDoc_idDoc,
            this.dcDoc_codDoc,
            this.dcDoc_numDoc,
            this.dcDoc_fechaDoc,
            this.dcDoc_idCreador,
            this.dcDoc_Detalle});
            this.dtDoc.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "idDoc"}, true)});
            this.dtDoc.PrimaryKey = new System.Data.DataColumn[] {
        this.dcDoc_idDoc};
            this.dtDoc.TableName = "Doc";
            // 
            // dcDoc_idDoc
            // 
            this.dcDoc_idDoc.AllowDBNull = false;
            this.dcDoc_idDoc.AutoIncrement = true;
            this.dcDoc_idDoc.ColumnName = "idDoc";
            this.dcDoc_idDoc.DataType = typeof(int);
            // 
            // dcDoc_codDoc
            // 
            this.dcDoc_codDoc.ColumnName = "codDoc";
            this.dcDoc_codDoc.DefaultValue = "Inv";
            // 
            // dcDoc_numDoc
            // 
            this.dcDoc_numDoc.ColumnName = "numDoc";
            // 
            // dcDoc_fechaDoc
            // 
            this.dcDoc_fechaDoc.ColumnName = "fechaDoc";
            this.dcDoc_fechaDoc.DataType = typeof(System.DateTime);
            // 
            // dcDoc_idCreador
            // 
            this.dcDoc_idCreador.ColumnName = "idCreador";
            this.dcDoc_idCreador.DataType = typeof(int);
            // 
            // dcDoc_Detalle
            // 
            this.dcDoc_Detalle.ColumnName = "Detalle";
            // 
            // dtInv
            // 
            this.dtInv.Columns.AddRange(new System.Data.DataColumn[] {
            this.dcInv_idPK,
            this.dcInv_idProducto,
            this.dcInv_idU,
            this.dcInv_Existencia,
            this.dcInv_idTalla,
            this.dcInv_idCualidad});
            this.dtInv.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "idInv"}, true)});
            this.dtInv.PrimaryKey = new System.Data.DataColumn[] {
        this.dcInv_idPK};
            this.dtInv.TableName = "Inv";
            // 
            // dcInv_idPK
            // 
            this.dcInv_idPK.AllowDBNull = false;
            this.dcInv_idPK.AutoIncrement = true;
            this.dcInv_idPK.ColumnName = "idInv";
            this.dcInv_idPK.DataType = typeof(int);
            // 
            // dcInv_idProducto
            // 
            this.dcInv_idProducto.ColumnName = "idProducto";
            this.dcInv_idProducto.DataType = typeof(int);
            // 
            // dcInv_idU
            // 
            this.dcInv_idU.ColumnName = "idUnidad";
            this.dcInv_idU.DataType = typeof(int);
            // 
            // dcInv_Existencia
            // 
            this.dcInv_Existencia.ColumnName = "Existencia";
            this.dcInv_Existencia.DataType = typeof(decimal);
            this.dcInv_Existencia.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // dcInv_idTalla
            // 
            this.dcInv_idTalla.ColumnName = "idTalla";
            this.dcInv_idTalla.DataType = typeof(int);
            // 
            // dcInv_idCualidad
            // 
            this.dcInv_idCualidad.ColumnName = "idCualidad";
            this.dcInv_idCualidad.DataType = typeof(int);
            // 
            // dtDoc_Inv
            // 
            this.dtDoc_Inv.Columns.AddRange(new System.Data.DataColumn[] {
            this.dcDI_idPK,
            this.dcDI_idInv,
            this.dcDI_idDoc,
            this.dcDI_Cantidad,
            this.dcDI_CostoU,
            this.dcDI_CostoT,
            this.dcDI_Dcto,
            this.dcDI_idTalla,
            this.dcDI_idProducto,
            this.dcDI_idEstado,
            this.dcDI_idCualidad});
            this.dtDoc_Inv.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "idDoc_Inv"}, true)});
            this.dtDoc_Inv.PrimaryKey = new System.Data.DataColumn[] {
        this.dcDI_idPK};
            this.dtDoc_Inv.TableName = "Doc_Inv";
            // 
            // dcDI_idPK
            // 
            this.dcDI_idPK.AllowDBNull = false;
            this.dcDI_idPK.AutoIncrement = true;
            this.dcDI_idPK.ColumnName = "idDoc_Inv";
            this.dcDI_idPK.DataType = typeof(int);
            // 
            // dcDI_idInv
            // 
            this.dcDI_idInv.ColumnName = "idInv";
            this.dcDI_idInv.DataType = typeof(int);
            // 
            // dcDI_idDoc
            // 
            this.dcDI_idDoc.ColumnName = "idDoc";
            this.dcDI_idDoc.DataType = typeof(int);
            // 
            // dcDI_Cantidad
            // 
            this.dcDI_Cantidad.ColumnName = "Cantidad";
            this.dcDI_Cantidad.DataType = typeof(decimal);
            // 
            // dcDI_CostoU
            // 
            this.dcDI_CostoU.ColumnName = "CostoU";
            this.dcDI_CostoU.DataType = typeof(decimal);
            // 
            // dcDI_CostoT
            // 
            this.dcDI_CostoT.ColumnName = "CostoT";
            this.dcDI_CostoT.DataType = typeof(decimal);
            // 
            // dcDI_Dcto
            // 
            this.dcDI_Dcto.ColumnName = "Descuento";
            this.dcDI_Dcto.DataType = typeof(decimal);
            // 
            // dcDI_idTalla
            // 
            this.dcDI_idTalla.ColumnName = "_idTalla";
            this.dcDI_idTalla.DataType = typeof(int);
            // 
            // dcDI_idProducto
            // 
            this.dcDI_idProducto.ColumnName = "_idProducto";
            this.dcDI_idProducto.DataType = typeof(int);
            // 
            // dcDI_idEstado
            // 
            this.dcDI_idEstado.ColumnName = "idEstado";
            this.dcDI_idEstado.DataType = typeof(int);
            this.dcDI_idEstado.DefaultValue = 10001;
            // 
            // dcDI_idCualidad
            // 
            this.dcDI_idCualidad.ColumnName = "_idCualidad";
            this.dcDI_idCualidad.DataType = typeof(int);
            // 
            // txtNumDoc
            // 
            this.txtNumDoc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDoc, "numDoc", true));
            this.txtNumDoc.Enabled = false;
            this.txtNumDoc.Location = new System.Drawing.Point(443, 30);
            this.txtNumDoc.Name = "txtNumDoc";
            this.txtNumDoc.Size = new System.Drawing.Size(100, 20);
            this.txtNumDoc.TabIndex = 7;
            // 
            // Inv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(897, 520);
            this.Controls.Add(this.txtNumDoc);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDes);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgvInv);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inv";
            this.Tag = "Inv";
            this.Text = "Ingreso Inventario";
            this.Load += new System.EventHandler(this.Inv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDoc_Inv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dgvInv;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblDes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotal;
        private System.Data.DataTable dtDoc;
        private System.Data.DataColumn dcDoc_idDoc;
        private System.Data.DataColumn dcDoc_codDoc;
        private System.Data.DataColumn dcDoc_numDoc;
        private System.Data.DataColumn dcDoc_fechaDoc;
        private System.Data.DataColumn dcDoc_idCreador;
        private System.Data.DataColumn dcDoc_Detalle;
        private System.Data.DataTable dtInv;
        private System.Data.DataColumn dcInv_idPK;
        private System.Data.DataColumn dcInv_idProducto;
        private System.Data.DataColumn dcInv_idU;
        private System.Data.DataColumn dcInv_Existencia;
        private System.Data.DataColumn dcInv_idTalla;
        private System.Data.DataTable dtDoc_Inv;
        private System.Data.DataColumn dcDI_idPK;
        private System.Data.DataColumn dcDI_idInv;
        private System.Data.DataColumn dcDI_idDoc;
        private System.Data.DataColumn dcDI_Cantidad;
        private System.Data.DataColumn dcDI_CostoU;
        private System.Data.DataColumn dcDI_CostoT;
        private System.Data.DataColumn dcDI_Dcto;
        private System.Windows.Forms.BindingSource bsDoc;
        private System.Data.DataColumn dcDI_idTalla;
        private System.Data.DataColumn dcDI_idProducto;
        private System.Windows.Forms.TextBox txtNumDoc;
        private System.Data.DataColumn dcDI_idEstado;
        private System.Data.DataColumn dcDI_idCualidad;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvcDI_idProducto;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvcDI_idCualidad;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvcDI_idTalla;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDocInvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idInvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoTDataGridViewTextBoxColumn;
        private System.Data.DataColumn dcInv_idCualidad;
    }
}
