using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace grInv
{
    public partial class Talla : Librerias.MainForm
    {
        public Talla()
        {
            InitializeComponent();
        }

        private void Talla_Load(object sender, EventArgs e)
        {
            New();
        }
    }
}
