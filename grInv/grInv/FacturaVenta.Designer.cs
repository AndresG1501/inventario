namespace grInv
{
    partial class FacturaVenta
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
            this.dgvInv = new System.Windows.Forms.DataGridView();
            this.idDocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcDI_idProducto = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvcDI_idCualidad = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvcDI_idTalla = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.idInvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEstadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNumDoc = new System.Windows.Forms.Label();
            this.txtNumDoc = new System.Windows.Forms.TextBox();
            this.bsDoc = new System.Windows.Forms.BindingSource(this.components);
            this.dtDoc = new System.Data.DataTable();
            this.dcDoc_idPK = new System.Data.DataColumn();
            this.dcDoc_codDoc = new System.Data.DataColumn();
            this.dcDoc_numDoc = new System.Data.DataColumn();
            this.dcDoc_idPersona = new System.Data.DataColumn();
            this.dcDoc_idEstado = new System.Data.DataColumn();
            this.dcDoc_idCreador = new System.Data.DataColumn();
            this.dcDoc_Texto = new System.Data.DataColumn();
            this.dcDoc_fechaDoc = new System.Data.DataColumn();
            this.dcDoc_esActivo = new System.Data.DataColumn();
            this.dcDoc_Total = new System.Data.DataColumn();
            this.dcDoc_Saldo = new System.Data.DataColumn();
            this.dtInv = new System.Data.DataTable();
            this.dcInv_idPK = new System.Data.DataColumn();
            this.dcInv_idProducto = new System.Data.DataColumn();
            this.dcInv_Existencia = new System.Data.DataColumn();
            this.dcInv_idTalla = new System.Data.DataColumn();
            this.dcInv_idEstado = new System.Data.DataColumn();
            this.dcInv_idCualidad = new System.Data.DataColumn();
            this.dtDoc_Inv = new System.Data.DataTable();
            this.dcDoc_Inv_idDoc = new System.Data.DataColumn();
            this.dcDoc_Inv_idInv = new System.Data.DataColumn();
            this.dcDoc_Inv_Cantidad = new System.Data.DataColumn();
            this.dcDoc_Inv_CostoU = new System.Data.DataColumn();
            this.dcDoc_Inv_CostoT = new System.Data.DataColumn();
            this.dcDoc_Inv_idEstado = new System.Data.DataColumn();
            this.dcDoc_Inv_Descuento = new System.Data.DataColumn();
            this.dcDoc_Inv_idProducto = new System.Data.DataColumn();
            this.dcDoc_Inv_idTalla = new System.Data.DataColumn();
            this.dcDoc_Inv_idCualidad = new System.Data.DataColumn();
            this.dtpFechaDoc = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.chkPS = new System.Windows.Forms.CheckBox();
            this.lblAbono = new System.Windows.Forms.Label();
            this.txtAbono = new System.Windows.Forms.TextBox();
            this.dtDNI = new System.Data.DataTable();
            this.dcDNI_idDoc = new System.Data.DataColumn();
            this.dcDNI_Cantidad = new System.Data.DataColumn();
            this.dcDNI_Saldo = new System.Data.DataColumn();
            this.dcDNI_idEstado = new System.Data.DataColumn();
            this.dcDNI_idPK = new System.Data.DataColumn();
            this.dcDoc_Inv_idPK = new System.Data.DataColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDoc_Inv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDNI)).BeginInit();
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
            this.dtDoc_Inv,
            this.dtDNI});
            // 
            // dgvInv
            // 
            this.dgvInv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInv.AutoGenerateColumns = false;
            this.dgvInv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDocDataGridViewTextBoxColumn,
            this.dgvcDI_idProducto,
            this.dgvcDI_idCualidad,
            this.dgvcDI_idTalla,
            this.idInvDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.costoUDataGridViewTextBoxColumn,
            this.idEstadoDataGridViewTextBoxColumn,
            this.descuentoDataGridViewTextBoxColumn,
            this.costoTDataGridViewTextBoxColumn});
            this.dgvInv.DataSource = this.bs;
            this.dgvInv.Location = new System.Drawing.Point(13, 62);
            this.dgvInv.Name = "dgvInv";
            this.dgvInv.Size = new System.Drawing.Size(812, 355);
            this.dgvInv.TabIndex = 0;
            this.dgvInv.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvInv_CellBeginEdit);
            this.dgvInv.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dgvInv.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // idDocDataGridViewTextBoxColumn
            // 
            this.idDocDataGridViewTextBoxColumn.DataPropertyName = "idDoc";
            this.idDocDataGridViewTextBoxColumn.HeaderText = "idDoc";
            this.idDocDataGridViewTextBoxColumn.Name = "idDocDataGridViewTextBoxColumn";
            this.idDocDataGridViewTextBoxColumn.Visible = false;
            // 
            // dgvcDI_idProducto
            // 
            this.dgvcDI_idProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvcDI_idProducto.DataPropertyName = "_idProducto";
            this.dgvcDI_idProducto.HeaderText = "Referencia";
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
            this.dgvcDI_idTalla.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvcDI_idTalla.DataPropertyName = "_idTalla";
            this.dgvcDI_idTalla.HeaderText = "Talla";
            this.dgvcDI_idTalla.Name = "dgvcDI_idTalla";
            this.dgvcDI_idTalla.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcDI_idTalla.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // idInvDataGridViewTextBoxColumn
            // 
            this.idInvDataGridViewTextBoxColumn.DataPropertyName = "idInv";
            this.idInvDataGridViewTextBoxColumn.HeaderText = "idInv";
            this.idInvDataGridViewTextBoxColumn.Name = "idInvDataGridViewTextBoxColumn";
            this.idInvDataGridViewTextBoxColumn.Visible = false;
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
            // idEstadoDataGridViewTextBoxColumn
            // 
            this.idEstadoDataGridViewTextBoxColumn.DataPropertyName = "idEstado";
            this.idEstadoDataGridViewTextBoxColumn.HeaderText = "idEstado";
            this.idEstadoDataGridViewTextBoxColumn.Name = "idEstadoDataGridViewTextBoxColumn";
            this.idEstadoDataGridViewTextBoxColumn.Visible = false;
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
            this.costoTDataGridViewTextBoxColumn.HeaderText = "CostoT";
            this.costoTDataGridViewTextBoxColumn.Name = "costoTDataGridViewTextBoxColumn";
            // 
            // lblNumDoc
            // 
            this.lblNumDoc.AutoSize = true;
            this.lblNumDoc.Location = new System.Drawing.Point(13, 13);
            this.lblNumDoc.Name = "lblNumDoc";
            this.lblNumDoc.Size = new System.Drawing.Size(77, 13);
            this.lblNumDoc.TabIndex = 1;
            this.lblNumDoc.Text = "N° Documento";
            // 
            // txtNumDoc
            // 
            this.txtNumDoc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDoc, "numDoc", true));
            this.txtNumDoc.Enabled = false;
            this.txtNumDoc.Location = new System.Drawing.Point(13, 30);
            this.txtNumDoc.Name = "txtNumDoc";
            this.txtNumDoc.Size = new System.Drawing.Size(143, 20);
            this.txtNumDoc.TabIndex = 2;
            // 
            // bsDoc
            // 
            this.bsDoc.DataMember = "Doc";
            this.bsDoc.DataSource = this.ds;
            // 
            // dtDoc
            // 
            this.dtDoc.Columns.AddRange(new System.Data.DataColumn[] {
            this.dcDoc_idPK,
            this.dcDoc_codDoc,
            this.dcDoc_numDoc,
            this.dcDoc_idPersona,
            this.dcDoc_idEstado,
            this.dcDoc_idCreador,
            this.dcDoc_Texto,
            this.dcDoc_fechaDoc,
            this.dcDoc_esActivo,
            this.dcDoc_Total,
            this.dcDoc_Saldo});
            this.dtDoc.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "idDoc"}, true)});
            this.dtDoc.PrimaryKey = new System.Data.DataColumn[] {
        this.dcDoc_idPK};
            this.dtDoc.TableName = "Doc";
            // 
            // dcDoc_idPK
            // 
            this.dcDoc_idPK.AllowDBNull = false;
            this.dcDoc_idPK.AutoIncrement = true;
            this.dcDoc_idPK.ColumnName = "idDoc";
            this.dcDoc_idPK.DataType = typeof(int);
            // 
            // dcDoc_codDoc
            // 
            this.dcDoc_codDoc.ColumnName = "codDoc";
            this.dcDoc_codDoc.DefaultValue = "FV";
            // 
            // dcDoc_numDoc
            // 
            this.dcDoc_numDoc.ColumnName = "numDoc";
            // 
            // dcDoc_idPersona
            // 
            this.dcDoc_idPersona.ColumnName = "idPersona";
            this.dcDoc_idPersona.DataType = typeof(int);
            // 
            // dcDoc_idEstado
            // 
            this.dcDoc_idEstado.ColumnName = "idEstado";
            this.dcDoc_idEstado.DataType = typeof(int);
            // 
            // dcDoc_idCreador
            // 
            this.dcDoc_idCreador.ColumnName = "idCreador";
            this.dcDoc_idCreador.DataType = typeof(int);
            // 
            // dcDoc_Texto
            // 
            this.dcDoc_Texto.ColumnName = "Texto";
            // 
            // dcDoc_fechaDoc
            // 
            this.dcDoc_fechaDoc.ColumnName = "fechaDoc";
            this.dcDoc_fechaDoc.DataType = typeof(System.DateTime);
            // 
            // dcDoc_esActivo
            // 
            this.dcDoc_esActivo.ColumnName = "esActivo";
            this.dcDoc_esActivo.DataType = typeof(bool);
            this.dcDoc_esActivo.DefaultValue = false;
            // 
            // dcDoc_Total
            // 
            this.dcDoc_Total.ColumnName = "Total";
            this.dcDoc_Total.DataType = typeof(decimal);
            // 
            // dcDoc_Saldo
            // 
            this.dcDoc_Saldo.ColumnName = "Saldo";
            this.dcDoc_Saldo.DataType = typeof(decimal);
            this.dcDoc_Saldo.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // dtInv
            // 
            this.dtInv.Columns.AddRange(new System.Data.DataColumn[] {
            this.dcInv_idPK,
            this.dcInv_idProducto,
            this.dcInv_Existencia,
            this.dcInv_idTalla,
            this.dcInv_idEstado,
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
            this.dcInv_idPK.ColumnName = "idInv";
            this.dcInv_idPK.DataType = typeof(int);
            // 
            // dcInv_idProducto
            // 
            this.dcInv_idProducto.ColumnName = "idProducto";
            this.dcInv_idProducto.DataType = typeof(int);
            // 
            // dcInv_Existencia
            // 
            this.dcInv_Existencia.ColumnName = "Existencia";
            this.dcInv_Existencia.DataType = typeof(decimal);
            // 
            // dcInv_idTalla
            // 
            this.dcInv_idTalla.ColumnName = "idTalla";
            this.dcInv_idTalla.DataType = typeof(int);
            // 
            // dcInv_idEstado
            // 
            this.dcInv_idEstado.ColumnName = "idEstado";
            this.dcInv_idEstado.DataType = typeof(int);
            // 
            // dcInv_idCualidad
            // 
            this.dcInv_idCualidad.ColumnName = "idCualidad";
            this.dcInv_idCualidad.DataType = typeof(int);
            // 
            // dtDoc_Inv
            // 
            this.dtDoc_Inv.Columns.AddRange(new System.Data.DataColumn[] {
            this.dcDoc_Inv_idDoc,
            this.dcDoc_Inv_idInv,
            this.dcDoc_Inv_Cantidad,
            this.dcDoc_Inv_CostoU,
            this.dcDoc_Inv_CostoT,
            this.dcDoc_Inv_idEstado,
            this.dcDoc_Inv_Descuento,
            this.dcDoc_Inv_idProducto,
            this.dcDoc_Inv_idTalla,
            this.dcDoc_Inv_idCualidad,
            this.dcDoc_Inv_idPK});
            this.dtDoc_Inv.TableName = "Doc_Inv";
            // 
            // dcDoc_Inv_idDoc
            // 
            this.dcDoc_Inv_idDoc.ColumnName = "idDoc";
            this.dcDoc_Inv_idDoc.DataType = typeof(int);
            // 
            // dcDoc_Inv_idInv
            // 
            this.dcDoc_Inv_idInv.ColumnName = "idInv";
            this.dcDoc_Inv_idInv.DataType = typeof(int);
            // 
            // dcDoc_Inv_Cantidad
            // 
            this.dcDoc_Inv_Cantidad.ColumnName = "Cantidad";
            this.dcDoc_Inv_Cantidad.DataType = typeof(int);
            // 
            // dcDoc_Inv_CostoU
            // 
            this.dcDoc_Inv_CostoU.ColumnName = "CostoU";
            this.dcDoc_Inv_CostoU.DataType = typeof(decimal);
            // 
            // dcDoc_Inv_CostoT
            // 
            this.dcDoc_Inv_CostoT.ColumnName = "CostoT";
            this.dcDoc_Inv_CostoT.DataType = typeof(decimal);
            // 
            // dcDoc_Inv_idEstado
            // 
            this.dcDoc_Inv_idEstado.ColumnName = "idEstado";
            this.dcDoc_Inv_idEstado.DataType = typeof(int);
            // 
            // dcDoc_Inv_Descuento
            // 
            this.dcDoc_Inv_Descuento.ColumnName = "Descuento";
            this.dcDoc_Inv_Descuento.DataType = typeof(decimal);
            // 
            // dcDoc_Inv_idProducto
            // 
            this.dcDoc_Inv_idProducto.ColumnName = "_idProducto";
            this.dcDoc_Inv_idProducto.DataType = typeof(int);
            // 
            // dcDoc_Inv_idTalla
            // 
            this.dcDoc_Inv_idTalla.ColumnName = "_idTalla";
            this.dcDoc_Inv_idTalla.DataType = typeof(int);
            // 
            // dcDoc_Inv_idCualidad
            // 
            this.dcDoc_Inv_idCualidad.ColumnName = "_idCualidad";
            this.dcDoc_Inv_idCualidad.DataType = typeof(int);
            // 
            // dtpFechaDoc
            // 
            this.dtpFechaDoc.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsDoc, "fechaDoc", true));
            this.dtpFechaDoc.Location = new System.Drawing.Point(162, 30);
            this.dtpFechaDoc.Name = "dtpFechaDoc";
            this.dtpFechaDoc.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaDoc.TabIndex = 3;
            this.dtpFechaDoc.ValueChanged += new System.EventHandler(this.dtpFechaDoc_ValueChanged);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(162, 13);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha";
            // 
            // txtObs
            // 
            this.txtObs.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDoc, "Texto", true));
            this.txtObs.Location = new System.Drawing.Point(12, 438);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(346, 63);
            this.txtObs.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(487, 438);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "TOTAL";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(13, 422);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(63, 13);
            this.lblDesc.TabIndex = 7;
            this.lblDesc.Text = "Descripción";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(597, 441);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(13, 13);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "0";
            // 
            // chkPS
            // 
            this.chkPS.AutoSize = true;
            this.chkPS.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsDoc, "esActivo", true));
            this.chkPS.Location = new System.Drawing.Point(369, 32);
            this.chkPS.Name = "chkPS";
            this.chkPS.Size = new System.Drawing.Size(84, 17);
            this.chkPS.TabIndex = 9;
            this.chkPS.Text = "Plan Separe";
            this.chkPS.UseVisualStyleBackColor = true;
            this.chkPS.CheckedChanged += new System.EventHandler(this.chkPS_CheckedChanged);
            // 
            // lblAbono
            // 
            this.lblAbono.AutoSize = true;
            this.lblAbono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbono.Location = new System.Drawing.Point(369, 422);
            this.lblAbono.Name = "lblAbono";
            this.lblAbono.Size = new System.Drawing.Size(47, 15);
            this.lblAbono.TabIndex = 10;
            this.lblAbono.Text = "Abonó";
            this.lblAbono.Visible = false;
            // 
            // txtAbono
            // 
            this.txtAbono.Location = new System.Drawing.Point(372, 438);
            this.txtAbono.Name = "txtAbono";
            this.txtAbono.Size = new System.Drawing.Size(100, 20);
            this.txtAbono.TabIndex = 11;
            this.txtAbono.Visible = false;
            // 
            // dtDNI
            // 
            this.dtDNI.Columns.AddRange(new System.Data.DataColumn[] {
            this.dcDNI_idDoc,
            this.dcDNI_Cantidad,
            this.dcDNI_Saldo,
            this.dcDNI_idEstado,
            this.dcDNI_idPK});
            this.dtDNI.TableName = "Doc_NoInv";
            // 
            // dcDNI_idDoc
            // 
            this.dcDNI_idDoc.ColumnName = "idDoc";
            this.dcDNI_idDoc.DataType = typeof(int);
            // 
            // dcDNI_Cantidad
            // 
            this.dcDNI_Cantidad.ColumnName = "Cantidad";
            this.dcDNI_Cantidad.DataType = typeof(decimal);
            // 
            // dcDNI_Saldo
            // 
            this.dcDNI_Saldo.ColumnName = "Saldo";
            this.dcDNI_Saldo.DataType = typeof(decimal);
            // 
            // dcDNI_idEstado
            // 
            this.dcDNI_idEstado.ColumnName = "idEstado";
            this.dcDNI_idEstado.DataType = typeof(int);
            // 
            // dcDNI_idPK
            // 
            this.dcDNI_idPK.AutoIncrement = true;
            this.dcDNI_idPK.ColumnName = "idDoc_NoInv";
            this.dcDNI_idPK.DataType = typeof(int);
            // 
            // dcDoc_Inv_idPK
            // 
            this.dcDoc_Inv_idPK.AutoIncrement = true;
            this.dcDoc_Inv_idPK.ColumnName = "idDoc_Inv";
            this.dcDoc_Inv_idPK.DataType = typeof(int);
            // 
            // FacturaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(837, 513);
            this.Controls.Add(this.txtAbono);
            this.Controls.Add(this.lblAbono);
            this.Controls.Add(this.chkPS);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dtpFechaDoc);
            this.Controls.Add(this.txtNumDoc);
            this.Controls.Add(this.lblNumDoc);
            this.Controls.Add(this.dgvInv);
            this.Name = "FacturaVenta";
            this.Tag = "FV";
            this.Text = "Factura de Venta";
            this.Load += new System.EventHandler(this.FacturaVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDoc_Inv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDNI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInv;
        private System.Windows.Forms.Label lblNumDoc;
        private System.Windows.Forms.TextBox txtNumDoc;
        private System.Data.DataTable dtDoc;
        private System.Data.DataColumn dcDoc_idPK;
        private System.Data.DataColumn dcDoc_codDoc;
        private System.Data.DataColumn dcDoc_numDoc;
        private System.Data.DataColumn dcDoc_idPersona;
        private System.Data.DataColumn dcDoc_idEstado;
        private System.Data.DataColumn dcDoc_idCreador;
        private System.Data.DataColumn dcDoc_Texto;
        private System.Data.DataTable dtInv;
        private System.Data.DataColumn dcInv_idPK;
        private System.Data.DataColumn dcInv_idProducto;
        private System.Data.DataColumn dcInv_Existencia;
        private System.Data.DataColumn dcInv_idTalla;
        private System.Data.DataColumn dcInv_idEstado;
        private System.Data.DataTable dtDoc_Inv;
        private System.Data.DataColumn dcDoc_Inv_idDoc;
        private System.Data.DataColumn dcDoc_Inv_idInv;
        private System.Data.DataColumn dcDoc_Inv_Cantidad;
        private System.Data.DataColumn dcDoc_Inv_CostoU;
        private System.Data.DataColumn dcDoc_Inv_CostoT;
        private System.Data.DataColumn dcDoc_Inv_idEstado;
        private System.Data.DataColumn dcDoc_Inv_Descuento;
        private System.Data.DataColumn dcDoc_Inv_idProducto;
        private System.Data.DataColumn dcDoc_Inv_idTalla;
        private System.Windows.Forms.DateTimePicker dtpFechaDoc;
        private System.Windows.Forms.Label lblFecha;
        private System.Data.DataColumn dcDoc_fechaDoc;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblTotal;
        private System.Data.DataColumn dcInv_idCualidad;
        private System.Data.DataColumn dcDoc_Inv_idCualidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvcDI_idProducto;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvcDI_idCualidad;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvcDI_idTalla;
        private System.Windows.Forms.DataGridViewTextBoxColumn idInvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEstadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoTDataGridViewTextBoxColumn;
        private System.Windows.Forms.CheckBox chkPS;
        private System.Windows.Forms.Label lblAbono;
        private System.Windows.Forms.TextBox txtAbono;
        private System.Data.DataColumn dcDoc_esActivo;
        private System.Windows.Forms.BindingSource bsDoc;
        private System.Data.DataTable dtDNI;
        private System.Data.DataColumn dcDNI_idDoc;
        private System.Data.DataColumn dcDNI_Cantidad;
        private System.Data.DataColumn dcDNI_Saldo;
        private System.Data.DataColumn dcDoc_Total;
        private System.Data.DataColumn dcDoc_Saldo;
        private System.Data.DataColumn dcDNI_idEstado;
        private System.Data.DataColumn dcDNI_idPK;
        private System.Data.DataColumn dcDoc_Inv_idPK;
    }
}
