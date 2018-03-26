using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Librerias
{
    public partial class Persona : Librerias.MainForm
    {
        public Persona()
        {
            InitializeComponent();
        }

        DataTable dtMunicipio = new DataTable();
        DataTable dtTipoPersona = new DataTable();

        private void Persona_Load(object sender, EventArgs e)
        {
            dtFill(dtMunicipio,"SELECT idMunicipio,nomMunicipio FROM Municipio");
            dtFill(dtTipoPersona, "SELECT idTipoPersona,nomTipoPersona FROM TipoPersona");
            cboCiu.DataSource = dtMunicipio;
            cboTipoP.DataSource = dtTipoPersona;
        }

        private void txtNom1_TextChanged(object sender, EventArgs e)
        {
            DataRow drPersona = dtPersona.Rows[0];
            drPersona["nomPersona"] = TryStr(txtNom1.Text) + " " + TryStr(txtNom2.Text) + " " + TryStr(txtApe1.Text) + " " + TryStr(txtApe2.Text);
        }
    }
}
