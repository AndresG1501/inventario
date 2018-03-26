namespace grInv
{
    partial class regCualidad
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
            System.Data.DataColumn dcCualidad_cod;
            System.Data.DataColumn dcCualidad_nomCualidad;
            System.Data.DataColumn dcCualidad_desC;
            System.Data.DataColumn dcCualidad_esActivo;
            this.lblCod = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblDes = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.chkEsActivo = new System.Windows.Forms.CheckBox();
            this.dtCualidad = new System.Data.DataTable();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            dcCualidad_cod = new System.Data.DataColumn();
            dcCualidad_nomCualidad = new System.Data.DataColumn();
            dcCualidad_desC = new System.Data.DataColumn();
            dcCualidad_esActivo = new System.Data.DataColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCualidad)).BeginInit();
            this.SuspendLayout();
            // 
            // ds
            // 
            this.ds.Tables.AddRange(new System.Data.DataTable[] {
            this.dtCualidad});
            // 
            // bs
            // 
            this.bs.DataMember = "Cualidad";
            this.bs.DataSource = this.ds;
            // 
            // dcCualidad_cod
            // 
            dcCualidad_cod.ColumnName = "codCualidad";
            // 
            // dcCualidad_nomCualidad
            // 
            dcCualidad_nomCualidad.ColumnName = "nomCualidad";
            // 
            // dcCualidad_desC
            // 
            dcCualidad_desC.ColumnName = "desCualidad";
            // 
            // dcCualidad_esActivo
            // 
            dcCualidad_esActivo.AllowDBNull = false;
            dcCualidad_esActivo.ColumnName = "esActivo";
            dcCualidad_esActivo.DataType = typeof(bool);
            dcCualidad_esActivo.DefaultValue = true;
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(13, 13);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(40, 13);
            this.lblCod.TabIndex = 0;
            this.lblCod.Text = "Código";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(132, 13);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(31, 13);
            this.lblColor.TabIndex = 1;
            this.lblColor.Text = "Color";
            // 
            // lblDes
            // 
            this.lblDes.AutoSize = true;
            this.lblDes.Location = new System.Drawing.Point(13, 73);
            this.lblDes.Name = "lblDes";
            this.lblDes.Size = new System.Drawing.Size(63, 13);
            this.lblDes.TabIndex = 2;
            this.lblDes.Text = "Descripción";
            // 
            // txtCod
            // 
            this.txtCod.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "codCualidad", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtCod.Location = new System.Drawing.Point(16, 30);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(110, 20);
            this.txtCod.TabIndex = 3;
            // 
            // txtColor
            // 
            this.txtColor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "nomCualidad", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtColor.Location = new System.Drawing.Point(132, 29);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(100, 20);
            this.txtColor.TabIndex = 4;
            // 
            // txtDes
            // 
            this.txtDes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "desCualidad", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtDes.Location = new System.Drawing.Point(16, 89);
            this.txtDes.Multiline = true;
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(216, 45);
            this.txtDes.TabIndex = 5;
            // 
            // chkEsActivo
            // 
            this.chkEsActivo.AutoSize = true;
            this.chkEsActivo.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bs, "esActivo", true));
            this.chkEsActivo.Location = new System.Drawing.Point(238, 33);
            this.chkEsActivo.Name = "chkEsActivo";
            this.chkEsActivo.Size = new System.Drawing.Size(56, 17);
            this.chkEsActivo.TabIndex = 6;
            this.chkEsActivo.Text = "Activo";
            this.chkEsActivo.UseVisualStyleBackColor = true;
            // 
            // dtCualidad
            // 
            this.dtCualidad.Columns.AddRange(new System.Data.DataColumn[] {
            dcCualidad_cod,
            dcCualidad_nomCualidad,
            dcCualidad_desC,
            dcCualidad_esActivo});
            this.dtCualidad.TableName = "Cualidad";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(50, 13);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(76, 13);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Sugerir Código";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // regCualidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(306, 143);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.chkEsActivo);
            this.Controls.Add(this.txtDes);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.lblDes);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblCod);
            this.Name = "regCualidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Color";
            this.Load += new System.EventHandler(this.regCualidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCualidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblDes;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.CheckBox chkEsActivo;
        private System.Data.DataTable dtCualidad;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}
