using Controlador;
using Modelo;
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
    public partial class FormBuscarSocio : Form
    {
        ControladoraSocios cSocio = new ControladoraSocios();

        public FormBuscarSocio()
        {
            InitializeComponent();
        }

        private void FormBuscarSocio_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           try
            {
                var message = String.Empty;

                dtgSocio.Rows.Clear();
                string dni;
                dni = txtDni.Text;
                Socios s;

                if (!String.IsNullOrEmpty(txtDni.Text))
                {
                    s = cSocio.BuscarPorDni(dni);
                    dtgSocio.Rows.Add(s.IdSocios, s.Apellido, s.Nombre, s.Dni, s.Direccion, s.Telefono);
                }
                else
                    message = "Debe llenar los campos vacios";

                MessageBox.Show(message);
                txtDni.Clear();

            }
            
            catch(Exception ex)
            {
                MessageBox.Show("el socio no existe");

            }
  
        }
    }
}
