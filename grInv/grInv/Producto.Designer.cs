namespace grInv
{
    partial class Producto
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
            System.Data.DataColumn dcProducto_Nom;
            System.Data.DataColumn dcProducto_Familia;
            System.Data.DataColumn dcProducto_Cua;
            System.Data.DataColumn dcProducto_desPro;
            System.Data.DataColumn dcProducto_esActivo;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Producto));
            this.lblRef = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblDes = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cboColor = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dtProducto = new System.Data.DataTable();
            this.cboFam = new System.Windows.Forms.ComboBox();
            dcProducto_Nom = new System.Data.DataColumn();
            dcProducto_Familia = new System.Data.DataColumn();
            dcProducto_Cua = new System.Data.DataColumn();
            dcProducto_desPro = new System.Data.DataColumn();
            dcProducto_esActivo = new System.Data.DataColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // ds
            // 
            this.ds.Tables.AddRange(new System.Data.DataTable[] {
            this.dtProducto});
            // 
            // bs
            // 
            this.bs.DataMember = "Producto";
            this.bs.DataSource = this.ds;
            // 
            // dcProducto_Nom
            // 
            dcProducto_Nom.ColumnName = "nomProducto";
            // 
            // dcProducto_Familia
            // 
            dcProducto_Familia.ColumnName = "idFamilia";
            dcProducto_Familia.DataType = typeof(int);
            // 
            // dcProducto_Cua
            // 
            dcProducto_Cua.ColumnName = "idCualidad";
            dcProducto_Cua.DataType = typeof(int);
            // 
            // dcProducto_desPro
            // 
            dcProducto_desPro.ColumnName = "desProducto";
            // 
            // dcProducto_esActivo
            // 
            dcProducto_esActivo.AllowDBNull = false;
            dcProducto_esActivo.ColumnName = "esActivo";
            dcProducto_esActivo.DataType = typeof(bool);
            dcProducto_esActivo.DefaultValue = true;
            // 
            // lblRef
            // 
            this.lblRef.AutoSize = true;
            this.lblRef.Location = new System.Drawing.Point(12, 59);
            this.lblRef.Name = "lblRef";
            this.lblRef.Size = new System.Drawing.Size(39, 13);
            this.lblRef.TabIndex = 2;
            this.lblRef.Text = "Familia";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 9);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(12, 109);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(31, 13);
            this.lblColor.TabIndex = 4;
            this.lblColor.Text = "Color";
            // 
            // lblDes
            // 
            this.lblDes.AutoSize = true;
            this.lblDes.Location = new System.Drawing.Point(234, 9);
            this.lblDes.Name = "lblDes";
            this.lblDes.Size = new System.Drawing.Size(63, 13);
            this.lblDes.TabIndex = 6;
            this.lblDes.Text = "Descripción";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "nomProducto", true));
            this.textBox1.Location = new System.Drawing.Point(15, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 20);
            this.textBox1.TabIndex = 1;
            // 
            // cboColor
            // 
            this.cboColor.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bs, "idCualidad", true));
            this.cboColor.DisplayMember = "nomCualidad";
            this.cboColor.FormattingEnabled = true;
            this.cboColor.Location = new System.Drawing.Point(15, 126);
            this.cboColor.Name = "cboColor";
            this.cboColor.Size = new System.Drawing.Size(189, 21);
            this.cboColor.TabIndex = 5;
            this.cboColor.ValueMember = "idCualidad";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "desProducto", true));
            this.textBox3.Location = new System.Drawing.Point(237, 25);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(250, 69);
            this.textBox3.TabIndex = 7;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bs, "esActivo", true));
            this.checkBox1.Location = new System.Drawing.Point(237, 109);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(56, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Activo";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // dtProducto
            // 
            this.dtProducto.Columns.AddRange(new System.Data.DataColumn[] {
            dcProducto_Nom,
            dcProducto_Familia,
            dcProducto_Cua,
            dcProducto_desPro,
            dcProducto_esActivo});
            this.dtProducto.TableName = "Producto";
            // 
            // cboFam
            // 
            this.cboFam.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bs, "idFamilia", true));
            this.cboFam.DisplayMember = "nomFamilia";
            this.cboFam.FormattingEnabled = true;
            this.cboFam.Location = new System.Drawing.Point(15, 75);
            this.cboFam.Name = "cboFam";
            this.cboFam.Size = new System.Drawing.Size(189, 21);
            this.cboFam.TabIndex = 3;
            this.cboFam.ValueMember = "idFamilia";
            // 
            // Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(509, 159);
            this.Controls.Add(this.cboFam);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.cboColor);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblDes);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblRef);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Item";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Producto";
            this.Load += new System.EventHandler(this.Item_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRef;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblDes;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cboColor;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Data.DataTable dtProducto;
        private System.Windows.Forms.ComboBox cboFam;
    }
}
