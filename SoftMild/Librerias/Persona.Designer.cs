namespace Librerias
{
    partial class Persona
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
            System.Data.DataColumn dcPersona_nomP;
            System.Data.DataColumn dcPersona_Nom1;
            System.Data.DataColumn dcPersona_Nom2;
            System.Data.DataColumn dcPersona_Ape1;
            System.Data.DataColumn dcPersona_Ape2;
            System.Data.DataColumn dcPersona_Id;
            System.Data.DataColumn dcPersona_Dir;
            System.Data.DataColumn dcPersona_IdMun;
            System.Data.DataColumn dcPersona_Email;
            System.Data.DataColumn dcPersona_Tel1;
            System.Data.DataColumn dcPersona_Tel2;
            System.Data.DataColumn dcPersona_Cel;
            System.Data.DataColumn dcPersona_Fax;
            this.lblNom1 = new System.Windows.Forms.Label();
            this.lblNom2 = new System.Windows.Forms.Label();
            this.lblApe1 = new System.Windows.Forms.Label();
            this.lblApe2 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblDir = new System.Windows.Forms.Label();
            this.lblCiu = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNom1 = new System.Windows.Forms.TextBox();
            this.txtNom2 = new System.Windows.Forms.TextBox();
            this.txtApe1 = new System.Windows.Forms.TextBox();
            this.txtApe2 = new System.Windows.Forms.TextBox();
            this.lblTel1 = new System.Windows.Forms.Label();
            this.lblTel2 = new System.Windows.Forms.Label();
            this.lblCel = new System.Windows.Forms.Label();
            this.lblFax = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.cboCiu = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTel1 = new System.Windows.Forms.TextBox();
            this.txtTel2 = new System.Windows.Forms.TextBox();
            this.txtCel = new System.Windows.Forms.TextBox();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.dtPersona = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.lblTipoP = new System.Windows.Forms.Label();
            this.cboTipoP = new System.Windows.Forms.ComboBox();
            dcPersona_nomP = new System.Data.DataColumn();
            dcPersona_Nom1 = new System.Data.DataColumn();
            dcPersona_Nom2 = new System.Data.DataColumn();
            dcPersona_Ape1 = new System.Data.DataColumn();
            dcPersona_Ape2 = new System.Data.DataColumn();
            dcPersona_Id = new System.Data.DataColumn();
            dcPersona_Dir = new System.Data.DataColumn();
            dcPersona_IdMun = new System.Data.DataColumn();
            dcPersona_Email = new System.Data.DataColumn();
            dcPersona_Tel1 = new System.Data.DataColumn();
            dcPersona_Tel2 = new System.Data.DataColumn();
            dcPersona_Cel = new System.Data.DataColumn();
            dcPersona_Fax = new System.Data.DataColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPersona)).BeginInit();
            this.SuspendLayout();
            // 
            // bs
            // 
            this.bs.DataMember = "Persona";
            this.bs.DataSource = this.ds;
            // 
            // ds
            // 
            this.ds.Tables.AddRange(new System.Data.DataTable[] {
            this.dtPersona});
            // 
            // dcPersona_nomP
            // 
            dcPersona_nomP.ColumnName = "nomPersona";
            dcPersona_nomP.DefaultValue = "\"\"";
            // 
            // dcPersona_Nom1
            // 
            dcPersona_Nom1.ColumnName = "Nombre1";
            // 
            // dcPersona_Nom2
            // 
            dcPersona_Nom2.ColumnName = "Nombre2";
            // 
            // dcPersona_Ape1
            // 
            dcPersona_Ape1.ColumnName = "Apellido1";
            // 
            // dcPersona_Ape2
            // 
            dcPersona_Ape2.ColumnName = "Apellido2";
            // 
            // dcPersona_Id
            // 
            dcPersona_Id.ColumnName = "Identificacion";
            // 
            // dcPersona_Dir
            // 
            dcPersona_Dir.ColumnName = "Direccion";
            // 
            // dcPersona_IdMun
            // 
            dcPersona_IdMun.ColumnName = "idMunicipio";
            dcPersona_IdMun.DataType = typeof(int);
            dcPersona_IdMun.DefaultValue = 5001;
            // 
            // dcPersona_Email
            // 
            dcPersona_Email.ColumnName = "Email";
            // 
            // dcPersona_Tel1
            // 
            dcPersona_Tel1.ColumnName = "Telefono";
            // 
            // dcPersona_Tel2
            // 
            dcPersona_Tel2.ColumnName = "Telefono2";
            // 
            // dcPersona_Cel
            // 
            dcPersona_Cel.ColumnName = "Celular";
            // 
            // dcPersona_Fax
            // 
            dcPersona_Fax.ColumnName = "Fax";
            // 
            // lblNom1
            // 
            this.lblNom1.AutoSize = true;
            this.lblNom1.Location = new System.Drawing.Point(13, 13);
            this.lblNom1.Name = "lblNom1";
            this.lblNom1.Size = new System.Drawing.Size(76, 13);
            this.lblNom1.TabIndex = 0;
            this.lblNom1.Text = "Primer Nombre";
            // 
            // lblNom2
            // 
            this.lblNom2.AutoSize = true;
            this.lblNom2.Location = new System.Drawing.Point(163, 13);
            this.lblNom2.Name = "lblNom2";
            this.lblNom2.Size = new System.Drawing.Size(90, 13);
            this.lblNom2.TabIndex = 1;
            this.lblNom2.Text = "Segundo Nombre";
            // 
            // lblApe1
            // 
            this.lblApe1.AutoSize = true;
            this.lblApe1.Location = new System.Drawing.Point(314, 14);
            this.lblApe1.Name = "lblApe1";
            this.lblApe1.Size = new System.Drawing.Size(76, 13);
            this.lblApe1.TabIndex = 2;
            this.lblApe1.Text = "Primer Apellido";
            // 
            // lblApe2
            // 
            this.lblApe2.AutoSize = true;
            this.lblApe2.Location = new System.Drawing.Point(465, 13);
            this.lblApe2.Name = "lblApe2";
            this.lblApe2.Size = new System.Drawing.Size(90, 13);
            this.lblApe2.TabIndex = 3;
            this.lblApe2.Text = "Segundo Apellido";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(13, 72);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(44, 13);
            this.lblId.TabIndex = 4;
            this.lblId.Text = "NIT/CC";
            // 
            // lblDir
            // 
            this.lblDir.AutoSize = true;
            this.lblDir.Location = new System.Drawing.Point(163, 72);
            this.lblDir.Name = "lblDir";
            this.lblDir.Size = new System.Drawing.Size(52, 13);
            this.lblDir.TabIndex = 5;
            this.lblDir.Text = "Dirección";
            // 
            // lblCiu
            // 
            this.lblCiu.AutoSize = true;
            this.lblCiu.Location = new System.Drawing.Point(314, 72);
            this.lblCiu.Name = "lblCiu";
            this.lblCiu.Size = new System.Drawing.Size(40, 13);
            this.lblCiu.TabIndex = 6;
            this.lblCiu.Text = "Ciudad";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(465, 72);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(94, 13);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Correo Electrónico";
            // 
            // txtNom1
            // 
            this.txtNom1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "Nombre1", true));
            this.txtNom1.Location = new System.Drawing.Point(15, 30);
            this.txtNom1.Name = "txtNom1";
            this.txtNom1.Size = new System.Drawing.Size(145, 20);
            this.txtNom1.TabIndex = 9;
            this.txtNom1.TextChanged += new System.EventHandler(this.txtNom1_TextChanged);
            // 
            // txtNom2
            // 
            this.txtNom2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "Nombre2", true));
            this.txtNom2.Location = new System.Drawing.Point(166, 30);
            this.txtNom2.Name = "txtNom2";
            this.txtNom2.Size = new System.Drawing.Size(145, 20);
            this.txtNom2.TabIndex = 10;
            // 
            // txtApe1
            // 
            this.txtApe1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "Apellido1", true));
            this.txtApe1.Location = new System.Drawing.Point(317, 30);
            this.txtApe1.Name = "txtApe1";
            this.txtApe1.Size = new System.Drawing.Size(145, 20);
            this.txtApe1.TabIndex = 11;
            // 
            // txtApe2
            // 
            this.txtApe2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "Apellido2", true));
            this.txtApe2.Location = new System.Drawing.Point(468, 30);
            this.txtApe2.Name = "txtApe2";
            this.txtApe2.Size = new System.Drawing.Size(145, 20);
            this.txtApe2.TabIndex = 12;
            // 
            // lblTel1
            // 
            this.lblTel1.AutoSize = true;
            this.lblTel1.Location = new System.Drawing.Point(13, 136);
            this.lblTel1.Name = "lblTel1";
            this.lblTel1.Size = new System.Drawing.Size(58, 13);
            this.lblTel1.TabIndex = 13;
            this.lblTel1.Text = "Teléfono 1";
            // 
            // lblTel2
            // 
            this.lblTel2.AutoSize = true;
            this.lblTel2.Location = new System.Drawing.Point(163, 136);
            this.lblTel2.Name = "lblTel2";
            this.lblTel2.Size = new System.Drawing.Size(58, 13);
            this.lblTel2.TabIndex = 14;
            this.lblTel2.Text = "Teléfono 2";
            // 
            // lblCel
            // 
            this.lblCel.AutoSize = true;
            this.lblCel.Location = new System.Drawing.Point(314, 136);
            this.lblCel.Name = "lblCel";
            this.lblCel.Size = new System.Drawing.Size(39, 13);
            this.lblCel.TabIndex = 15;
            this.lblCel.Text = "Celular";
            // 
            // lblFax
            // 
            this.lblFax.AutoSize = true;
            this.lblFax.Location = new System.Drawing.Point(465, 136);
            this.lblFax.Name = "lblFax";
            this.lblFax.Size = new System.Drawing.Size(24, 13);
            this.lblFax.TabIndex = 16;
            this.lblFax.Text = "Fax";
            // 
            // txtId
            // 
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "Identificacion", true));
            this.txtId.Location = new System.Drawing.Point(16, 88);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(145, 20);
            this.txtId.TabIndex = 17;
            // 
            // txtDir
            // 
            this.txtDir.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "Direccion", true));
            this.txtDir.Location = new System.Drawing.Point(166, 88);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(145, 20);
            this.txtDir.TabIndex = 18;
            // 
            // cboCiu
            // 
            this.cboCiu.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bs, "idMunicipio", true));
            this.cboCiu.DisplayMember = "nomMunicipio";
            this.cboCiu.FormattingEnabled = true;
            this.cboCiu.Location = new System.Drawing.Point(317, 87);
            this.cboCiu.Name = "cboCiu";
            this.cboCiu.Size = new System.Drawing.Size(145, 21);
            this.cboCiu.TabIndex = 19;
            this.cboCiu.ValueMember = "idMunicipio";
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "Email", true));
            this.txtEmail.Location = new System.Drawing.Point(468, 88);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(145, 20);
            this.txtEmail.TabIndex = 20;
            // 
            // txtTel1
            // 
            this.txtTel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "Telefono", true));
            this.txtTel1.Location = new System.Drawing.Point(15, 152);
            this.txtTel1.Name = "txtTel1";
            this.txtTel1.Size = new System.Drawing.Size(145, 20);
            this.txtTel1.TabIndex = 21;
            // 
            // txtTel2
            // 
            this.txtTel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "Telefono2", true));
            this.txtTel2.Location = new System.Drawing.Point(166, 152);
            this.txtTel2.Name = "txtTel2";
            this.txtTel2.Size = new System.Drawing.Size(145, 20);
            this.txtTel2.TabIndex = 22;
            // 
            // txtCel
            // 
            this.txtCel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "Celular", true));
            this.txtCel.Location = new System.Drawing.Point(316, 152);
            this.txtCel.Name = "txtCel";
            this.txtCel.Size = new System.Drawing.Size(145, 20);
            this.txtCel.TabIndex = 23;
            // 
            // txtFax
            // 
            this.txtFax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "Fax", true));
            this.txtFax.Location = new System.Drawing.Point(468, 152);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(145, 20);
            this.txtFax.TabIndex = 24;
            // 
            // dtPersona
            // 
            this.dtPersona.Columns.AddRange(new System.Data.DataColumn[] {
            dcPersona_nomP,
            dcPersona_Nom1,
            dcPersona_Nom2,
            dcPersona_Ape1,
            dcPersona_Ape2,
            dcPersona_Id,
            dcPersona_Dir,
            dcPersona_IdMun,
            dcPersona_Email,
            dcPersona_Tel1,
            dcPersona_Tel2,
            dcPersona_Cel,
            dcPersona_Fax,
            this.dataColumn1});
            this.dtPersona.TableName = "Persona";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "idTipoPersona";
            // 
            // lblTipoP
            // 
            this.lblTipoP.AutoSize = true;
            this.lblTipoP.Location = new System.Drawing.Point(12, 198);
            this.lblTipoP.Name = "lblTipoP";
            this.lblTipoP.Size = new System.Drawing.Size(70, 13);
            this.lblTipoP.TabIndex = 25;
            this.lblTipoP.Text = "Tipo Persona";
            // 
            // cboTipoP
            // 
            this.cboTipoP.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bs, "idTipoPersona", true));
            this.cboTipoP.DisplayMember = "nomTipoPersona";
            this.cboTipoP.FormattingEnabled = true;
            this.cboTipoP.Location = new System.Drawing.Point(15, 214);
            this.cboTipoP.Name = "cboTipoP";
            this.cboTipoP.Size = new System.Drawing.Size(145, 21);
            this.cboTipoP.TabIndex = 26;
            this.cboTipoP.ValueMember = "idTipoPersona";
            // 
            // Persona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(633, 259);
            this.Controls.Add(this.cboTipoP);
            this.Controls.Add(this.lblTipoP);
            this.Controls.Add(this.txtFax);
            this.Controls.Add(this.txtCel);
            this.Controls.Add(this.txtTel2);
            this.Controls.Add(this.txtTel1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.cboCiu);
            this.Controls.Add(this.txtDir);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblFax);
            this.Controls.Add(this.lblCel);
            this.Controls.Add(this.lblTel2);
            this.Controls.Add(this.lblTel1);
            this.Controls.Add(this.txtApe2);
            this.Controls.Add(this.txtApe1);
            this.Controls.Add(this.txtNom2);
            this.Controls.Add(this.txtNom1);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblCiu);
            this.Controls.Add(this.lblDir);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblApe2);
            this.Controls.Add(this.lblApe1);
            this.Controls.Add(this.lblNom2);
            this.Controls.Add(this.lblNom1);
            this.Name = "Persona";
            this.Text = "Registro de Persona";
            this.Load += new System.EventHandler(this.Persona_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPersona)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNom1;
        private System.Windows.Forms.Label lblNom2;
        private System.Windows.Forms.Label lblApe1;
        private System.Windows.Forms.Label lblApe2;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblDir;
        private System.Windows.Forms.Label lblCiu;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtNom1;
        private System.Windows.Forms.TextBox txtNom2;
        private System.Windows.Forms.TextBox txtApe1;
        private System.Windows.Forms.TextBox txtApe2;
        private System.Windows.Forms.Label lblTel1;
        private System.Windows.Forms.Label lblTel2;
        private System.Windows.Forms.Label lblCel;
        private System.Windows.Forms.Label lblFax;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtDir;
        private System.Windows.Forms.ComboBox cboCiu;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTel1;
        private System.Windows.Forms.TextBox txtTel2;
        private System.Windows.Forms.TextBox txtCel;
        private System.Windows.Forms.TextBox txtFax;
        private System.Data.DataTable dtPersona;
        private System.Data.DataColumn dataColumn1;
        private System.Windows.Forms.Label lblTipoP;
        private System.Windows.Forms.ComboBox cboTipoP;
    }
}
