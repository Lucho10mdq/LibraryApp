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
    public partial class FormAutores : Form
    {
        ControladorAutores cAutor = new ControladorAutores();
        int idAutor = 0;
        public FormAutores()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var result = false;
            var message = String.Empty;
            string nombre;
            nombre = txtNombre.Text;

            if (!String.IsNullOrEmpty(txtNombre.Text))
            {
                idAutor = idAutor + 1;
                result = cAutor.AgregarAutor(idAutor, nombre);

            }
            else
                message = "Complete el campo nombre";
            if (!result && String.IsNullOrEmpty(message))
                message = "El autor ya existe en la base de datos";
            else if (result)
                message = "El autor fue guardado correctamente";

            MessageBox.Show(message);

           

            txtNombre.Clear();
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            foreach(Autor a in cAutor.DevolverAutores())
            {
                dtgAutor.Rows.Clear();
                dtgAutor.Rows.Add(a.IdAutor, a.Nombre);
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            try
            {
                string nombre;
                nombre = txtNombre.Text;
                Autor a;
                dtgAutor.Rows.Clear();
                a = cAutor.BuscarAutorPorNombre(nombre);
                dtgAutor.Rows.Add(a.IdAutor, a.Nombre);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Autor no encontrado");
            }
           

        }

        private void dtgAutor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
