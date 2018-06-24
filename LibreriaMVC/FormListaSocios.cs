using Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibreriaMVC
{
    public partial class FormListaSocios : Form
    {
        ControladoraSocios cSocio = new ControladoraSocios();
        public FormListaSocios()
        {
            InitializeComponent();
        }

        private void lblListaSocios_Click(object sender, EventArgs e)
        {

        }

        private void FormListaSocios_Load(object sender, EventArgs e)
        {
            ControladoraSocios cSocio = new ControladoraSocios();

           dtgListaSocios.DataSource = null;
            dtgListaSocios.DataSource =cSocio.DevolverSocios();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
               var message = String.Empty;
            var resul = 0;
                string dni;
                dni = txtEliminar.Text;
                if (!String.IsNullOrEmpty(dni))
                    resul= cSocio.EliminarSocio(dni);
                else
                    message = "Debe llenar los campos vacios";
                 if (resul==0 && String.IsNullOrEmpty(message))
                 message = "Socio no existe";
                 else if(resul!=0)
                    message = "Socio eliminado correctamente";
                 MessageBox.Show(message);
               // this.Close();
        }
    }
}
