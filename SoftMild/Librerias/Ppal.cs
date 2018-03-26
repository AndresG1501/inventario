using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Librerias
{
    public partial class Ppal : Form
    {
        private int childFormNumber = 0;
        int timeInactivity;
        int idPerfilAdministrador = 10001;
        int idPermUsuario;
        public Ppal()
        {
            InitializeComponent();
            
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            
            if(idPerfilAdministrador == Variables.idPerfilUsuarioActual)
            { 
            Abrir();
            }
            else
            {
                
                MessageBox.Show("No estas certificado para abrir documentos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
#region "Eventos personalizados"
        private void Ppal_Load(object sender, EventArgs e)
        {
            
            fun.ShowfrmDialog("Login",this);
            this.Text = Variables.nomEmpresa;
        }

        private void tec_KeyDown(object sender,KeyEventArgs e)
        {
            var value = e.KeyCode;
            if (value == Keys.F12)
            {
                int aux = 0;
                foreach(Form child in this.MdiChildren)
                {
                    if (child.Text == "Login") aux++;
                                                                                   
                }
                if (!fun.TryBool(aux))
                {
                    fun.ShowfrmDialog("Login", this);
                    
                }
                idPermUsuario = Variables.idPerfilUsuarioActual;
            }
        }
        #endregion

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void registroDeFamiliaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            fun.Showfrm("regFamilia", this);
        }

        private void registroDeColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void registroDeProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fun.Showfrm("Producto", this);
        }

      
        private void registroDePersonasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fun.Showfrm("Persona", this);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void Guardar()
        {
            Form activeChild = ActiveMdiChild;
            Type classType = activeChild.GetType();
            MethodInfo metodo = classType.GetMethod("Save");
            metodo.Invoke(activeChild, null);
        }

        private void Abrir()
        {
            string finder;
            Form activeChild = ActiveMdiChild;
           
            if(fun.TryStr(ActiveMdiChild.Tag) != "")
            {
                finder = "BuscarDoc";
                Type typeBR = fun.getType(finder); //Averiguar forma de que tambien sea dinamico dependiendo de los parametros del constructor.
                ConstructorInfo ctor = typeBR.GetConstructor(new[] { typeof(Form) });
                object finderF = ctor.Invoke(new object[] {activeChild });
                Form form = (Form)finderF;
                form.ShowDialog(activeChild);
            }
            else
            {
                finder = "BuscarReg";
                Type classType = activeChild.GetType();
                MethodInfo metodo = classType.GetMethod("getNameMainRow");
                string nameTable = fun.TryStr(metodo.Invoke(activeChild, null));
                string nameClass = activeChild.Name;

                Type typeBR = fun.getType(finder); //Averiguar forma de que tambien sea dinamico dependiendo de los parametros del constructor.
                ConstructorInfo ctor = typeBR.GetConstructor(new[] { typeof(string), typeof(string), typeof(Form) });
                object fFinal = ctor.Invoke(new object[] { nameTable, nameClass, activeChild });
                Form form = (Form)fFinal;
                form.ShowDialog(activeChild);
            }
                
           
        }

        private void creaciónUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(idPerfilAdministrador == Variables.idPerfilUsuarioActual)
            { 
            fun.Showfrm("Usuario", this);
            }
            else
            {
                MessageBox.Show("No estas certificado para abrir este formulario", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void ingresoInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

            fun.Showfrm("Inv", this);
        }

        private void registroTallasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fun.Showfrm("Talla", this);
        }

        private void timerInactive_Tick(object sender, EventArgs e)
        {
            
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fun.Showfrm("Reporte", this);
        }

        private void facturaDeVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fun.Showfrm("FacturaVenta", this);
        }

        private void registroDeColorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            fun.Showfrm("regCualidad", this);



        }
    }
}
