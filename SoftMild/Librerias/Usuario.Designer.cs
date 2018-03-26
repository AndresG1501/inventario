namespace Librerias
{
    partial class Usuario
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
            System.Data.DataColumn dcUsuario_esActivo;
            System.Data.DataColumn dcUsuario_Alias;
            System.Data.DataColumn dcUsuario_Login;
            System.Data.DataColumn dcUsuario_Clave;
            System.Data.DataColumn dcUsuario_eClave;
            this.dtUsuario = new System.Data.DataTable();
            this.dcUsuario_idU = new System.Data.DataColumn();
            this.lblAlias = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblContra = new System.Windows.Forms.Label();
            this.txtAlias = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.lblVerContra = new System.Windows.Forms.Label();
            this.txtVerContra = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lblWarning = new System.Windows.Forms.Label();
            this.lblIdentificacion = new System.Windows.Forms.Label();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.chkAdmin = new System.Windows.Forms.CheckBox();
            this.dcUsuario_idPerfil = new System.Data.DataColumn();
            dcUsuario_esActivo = new System.Data.DataColumn();
            dcUsuario_Alias = new System.Data.DataColumn();
            dcUsuario_Login = new System.Data.DataColumn();
            dcUsuario_Clave = new System.Data.DataColumn();
            dcUsuario_eClave = new System.Data.DataColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // bs
            // 
            this.bs.DataMember = "Usuario";
            this.bs.DataSource = this.ds;
            // 
            // ds
            // 
            this.ds.Tables.AddRange(new System.Data.DataTable[] {
            this.dtUsuario});
            // 
            // dcUsuario_esActivo
            // 
            dcUsuario_esActivo.ColumnName = "esActivo";
            dcUsuario_esActivo.DefaultValue = "1";
            // 
            // dcUsuario_Alias
            // 
            dcUsuario_Alias.ColumnName = "Alias";
            // 
            // dcUsuario_Login
            // 
            dcUsuario_Login.ColumnName = "Login";
            // 
            // dcUsuario_Clave
            // 
            dcUsuario_Clave.ColumnName = "Clave";
            // 
            // dcUsuario_eClave
            // 
            dcUsuario_eClave.ColumnName = "eClave";
            // 
            // dtUsuario
            // 
            this.dtUsuario.Columns.AddRange(new System.Data.DataColumn[] {
            this.dcUsuario_idU,
            dcUsuario_esActivo,
            dcUsuario_Alias,
            dcUsuario_Login,
            dcUsuario_Clave,
            dcUsuario_eClave,
            this.dcUsuario_idPerfil});
            this.dtUsuario.TableName = "Usuario";
            // 
            // dcUsuario_idU
            // 
            this.dcUsuario_idU.ColumnName = "idUsuario";
            this.dcUsuario_idU.DataType = typeof(int);
            // 
            // lblAlias
            // 
            this.lblAlias.AutoSize = true;
            this.lblAlias.Location = new System.Drawing.Point(13, 13);
            this.lblAlias.Name = "lblAlias";
            this.lblAlias.Size = new System.Drawing.Size(72, 13);
            this.lblAlias.TabIndex = 0;
            this.lblAlias.Text = "Nombre Corto";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(13, 57);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(78, 13);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Usuario (Login)";
            // 
            // lblContra
            // 
            this.lblContra.AutoSize = true;
            this.lblContra.Location = new System.Drawing.Point(13, 102);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(61, 13);
            this.lblContra.TabIndex = 2;
            this.lblContra.Text = "Contraseña";
            // 
            // txtAlias
            // 
            this.txtAlias.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "Alias", true));
            this.txtAlias.Location = new System.Drawing.Point(16, 29);
            this.txtAlias.Name = "txtAlias";
            this.txtAlias.Size = new System.Drawing.Size(100, 20);
            this.txtAlias.TabIndex = 3;
            // 
            // txtLogin
            // 
            this.txtLogin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "Login", true));
            this.txtLogin.Location = new System.Drawing.Point(16, 73);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(100, 20);
            this.txtLogin.TabIndex = 4;
            // 
            // txtContra
            // 
            this.txtContra.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "Clave", true));
            this.txtContra.Location = new System.Drawing.Point(16, 118);
            this.txtContra.Name = "txtContra";
            this.txtContra.PasswordChar = '*';
            this.txtContra.Size = new System.Drawing.Size(100, 20);
            this.txtContra.TabIndex = 5;
            // 
            // lblVerContra
            // 
            this.lblVerContra.AutoSize = true;
            this.lblVerContra.Location = new System.Drawing.Point(13, 150);
            this.lblVerContra.Name = "lblVerContra";
            this.lblVerContra.Size = new System.Drawing.Size(102, 13);
            this.lblVerContra.TabIndex = 6;
            this.lblVerContra.Text = "Verificar Contraseña";
            // 
            // txtVerContra
            // 
            this.txtVerContra.Location = new System.Drawing.Point(16, 166);
            this.txtVerContra.Name = "txtVerContra";
            this.txtVerContra.PasswordChar = '*';
            this.txtVerContra.Size = new System.Drawing.Size(100, 20);
            this.txtVerContra.TabIndex = 7;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bs, "esActivo", true));
            this.checkBox1.Location = new System.Drawing.Point(11, 243);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(56, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Activo";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Location = new System.Drawing.Point(122, 169);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(10, 13);
            this.lblWarning.TabIndex = 9;
            this.lblWarning.Text = "r";
            // 
            // lblIdentificacion
            // 
            this.lblIdentificacion.AutoSize = true;
            this.lblIdentificacion.Location = new System.Drawing.Point(13, 201);
            this.lblIdentificacion.Name = "lblIdentificacion";
            this.lblIdentificacion.Size = new System.Drawing.Size(70, 13);
            this.lblIdentificacion.TabIndex = 10;
            this.lblIdentificacion.Text = "Identificación";
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(16, 217);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(100, 20);
            this.txtIdentificacion.TabIndex = 9;
            // 
            // chkAdmin
            // 
            this.chkAdmin.AutoSize = true;
            this.chkAdmin.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bs, "esActivo", true));
            this.chkAdmin.Location = new System.Drawing.Point(89, 243);
            this.chkAdmin.Name = "chkAdmin";
            this.chkAdmin.Size = new System.Drawing.Size(89, 17);
            this.chkAdmin.TabIndex = 11;
            this.chkAdmin.Text = "Administrador";
            this.chkAdmin.UseVisualStyleBackColor = true;
            // 
            // dcUsuario_idPerfil
            // 
            this.dcUsuario_idPerfil.ColumnName = "idPerfil";
            this.dcUsuario_idPerfil.DataType = typeof(int);
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(228, 285);
            this.Controls.Add(this.chkAdmin);
            this.Controls.Add(this.txtIdentificacion);
            this.Controls.Add(this.lblIdentificacion);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtVerContra);
            this.Controls.Add(this.lblVerContra);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.txtAlias);
            this.Controls.Add(this.lblContra);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblAlias);
            this.Name = "Usuario";
            this.Text = "Creación Usuario";
            this.Load += new System.EventHandler(this.Usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.DataTable dtUsuario;
        private System.Data.DataColumn dcUsuario_idU;
        private System.Windows.Forms.Label lblAlias;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblContra;
        private System.Windows.Forms.TextBox txtAlias;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.Label lblVerContra;
        private System.Windows.Forms.TextBox txtVerContra;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Label lblIdentificacion;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.CheckBox chkAdmin;
        private System.Data.DataColumn dcUsuario_idPerfil;
    }
}
