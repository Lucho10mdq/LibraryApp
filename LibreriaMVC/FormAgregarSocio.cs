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
    public partial class FormAgregarSocio : Form
    {
        ControladoraSocios cSocios = new ControladoraSocios();
       
        public FormAgregarSocio()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void grbSocio_Enter(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var message = String.Empty;
            var result = false;

            string nombre, apellido, direccion, telefono, dni;
            

            nombre = txtNombre.Text;
            apellido = txtApellido.Text;
            direccion = txtDireccion.Text;
            telefono = txtTelefono.Text;
            dni = txtDni.Text;


            if (!String.IsNullOrEmpty(txtNombre.Text) && !String.IsNullOrEmpty(txtApellido.Text) && !String.IsNullOrEmpty(txtDni.Text) && !String.IsNullOrEmpty(txtDireccion.Text) && !String.IsNullOrEmpty(txtTelefono.Text))
            {
               
                result = cSocios.Agregar(nombre, apellido, direccion, telefono, dni);
            } 
            
            else
                message = "No pueden quedar campos vacios";
            if (!result && String.IsNullOrEmpty(message))
                message = "Ya existe socio";
            else if (result)
                message = "Se guardo con exito";

            MessageBox.Show(message);
            txtNombre.Clear();
            txtApellido.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtDni.Clear();

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            FormListaSocios listaSocios = new FormListaSocios();
            listaSocios.Show();

        }

        private void FormAgregarSocio_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FormBuscarSocio BuscarSocio = new FormBuscarSocio();
            BuscarSocio.Show();
        }
    }
}
