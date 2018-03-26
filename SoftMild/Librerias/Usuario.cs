using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Librerias
{
    public partial class Usuario : Librerias.MainForm
    {
        public Usuario()
        {
            InitializeComponent();
        }

        private void Usuario_Load(object sender, EventArgs e)
        {
            lblWarning.Text = "";
            New();

        }

        public override void Save()
        {

            lblWarning.Text = "";
            DataRow dr = dtUsuario.Rows[0];
            string id = txtIdentificacion.Text;
            string Clave = TryStr(dr["Clave"]);
            string eClave = txtVerContra.Text;
            string query = "SELECT idPersona FROM Persona WHERE Identificacion = " + gsql(id);
            int idPersona = TryInt(ExecuteScalar(query));
            if (Clave != eClave)
            {
                lblWarning.Text = "No Coinciden las contraseñas";
                return;
            }
            else if (idPersona == 0)
            {
                MessageBox.Show("La identificación no existe","Error",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                return;
            }


            dr["idUsuario"] = idPersona;
            dr["Clave"] =  Sha256(Clave) ;
            dr["eClave"] = Sha256(Sha256(eClave) + Sha256(id)) ;
            if (chkAdmin.Checked)
            {
                dr["idPerfil"] = idPerfilAdmin;
            }
            else
            {
                dr["idPerfil"] = idPerfilNoAdmin;
            }


            bs.EndEdit();
           
            try
            {
            Variables.idAbierto = idOpen;
            Update(ds);
            MessageBox.Show("Grabación Exitosa", "Información", MessageBoxButtons.OK);
            ds.Clear();
            
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            New();

        }

    }
}
