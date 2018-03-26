using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace grInv
{
    public partial class regCualidad : Librerias.MainForm
    {
        public regCualidad()
        {
            InitializeComponent();
        }

        private void regCualidad_Load(object sender, EventArgs e)
        {
            New();
        }

        
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string codSug = getMaxString("Cualidad","codCualidad");
           
            txtCod.Text = codSug;
        }
    }
}
