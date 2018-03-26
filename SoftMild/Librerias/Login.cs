using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Xml;



namespace Librerias
{
    public partial class Login : Form



    {
        
        public Login()
        {
            InitializeComponent();
        }
#region "variables y constantes"
        string strCn;
        afgCon cnn;
        DataTable dtCnx;
#endregion


        #region "Eventos"
        private void Login_Load(object sender, EventArgs e)
        {
            cboEmpresa.DisplayMember = "nomEmpresa";
            cboEmpresa.ValueMember = "nomEmpresa";
            dtCnx = fun.GetXml("Empresas", "Empresa", "nomEmpresa,ConStr");
            cboEmpresa.DataSource = new DataView(dtCnx);
            Variables.nomEmpresa = fun.TryStr(dtCnx.Rows[0]["nomEmpresa"]);
            cboEmpresa.SelectedValue = dtCnx.Rows[0]["nomEmpresa"];

            Variables.strCon = (string)dtCnx.Rows[0]["ConStr"];
            strCn = Variables.strCon;
            cnn = new afgCon(strCn);
        }

        private void cboEmpresa_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataRow dr = ((DataRowView)cboEmpresa.SelectedValue).Row;
            Variables.strCon = fun.TryStr(dr["ConStr"]);
            strCn = Variables.strCon;
            cnn = new afgCon(strCn);
        }

   
        private void btIni_Click(object sender, EventArgs e)
        {
            if (chkLog(txtUsuario.Text, txtPsw.Text))
            {

                MessageBox.Show("Has Iniciado Sesión","",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
                
            }
            else
            {
                MessageBox.Show("Datos Incorrectos o Usuario inactivo");
            }
        }

        private void me_Enter(object sender, EventArgs e)
        {
            this.Enabled = true;
        }



        

        private void btCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_FormClosed(object sender,FormClosedEventArgs e)
        {
           
        }


        #endregion

#region "Métodos"

        public bool chkLog(string Login,string psw)
        {
            cnn.Open();
            string query = "SELECT Persona.Identificacion FROM Usuario INNER JOIN Persona ON Persona.idPersona = Usuario.idUsuario WHERE Usuario.Login = " + fun.gsql(Login);
            string id = fun.TryStr(cnn.ExecuteScalar(query));
            DataTable dtU = new DataTable("Usuario");
            string validate = "SELECT idUsuario,idPerfil FROM Usuario WHERE esActivo = 1 AND Login = " + fun.gsql(Login) + " AND eClave = " + fun.gsql(fun.Sha256(fun.Sha256(psw) + fun.Sha256(id))) + " AND Clave = " + fun.gsql(fun.Sha256(psw));
            cnn.dtFill(dtU,validate);
            bool rt = fun.TryBool(dtU);
            if (rt)
            {
                DataRow drU = dtU.Rows[0];
                Variables.idUsuarioActual = fun.TryInt(drU["idUsuario"]);
                Variables.idPerfilUsuarioActual = fun.TryInt(drU["idPerfil"]);
            }
                
            cnn.Close();
            return rt;
        }

        #endregion

      
    }
}
