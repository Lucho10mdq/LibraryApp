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
    public partial class FormEditorial : Form
    {
        ControladorEditoriales cEditorial = new ControladorEditoriales();
        int idEditorial = 0;
        public FormEditorial()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var message = String.Empty;
            var result = false;

            string nombre;
            nombre = txtEditorial.Text;

            if (!String.IsNullOrEmpty(txtEditorial.Text))
            {
                idEditorial = idEditorial + 1;
                result = cEditorial.AgregarEditorial(idEditorial, nombre);
                

            }
            else
                message = "Complete el campo nombre";
            if (!result && String.IsNullOrEmpty(message))
                message = "La editorial ya existe en la base de datos";
            else if (result)
                message = "Se guardo con exito";


            MessageBox.Show(message);
            txtEditorial.Clear();

        }

        private void btnListaEdit_Click(object sender, EventArgs e)
        {
            dtgEditoriales.Rows.Clear();
            foreach (Editoriales oEdit in cEditorial.DevolverEditoriales())
            {
               // dtgEditoriales.Rows.Clear();
                dtgEditoriales.Rows.Add(oEdit.IdEditorial, oEdit.Nombre);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre;
                nombre = txtEditorial.Text;
                Editoriales edi;

                edi = cEditorial.BuscarEditorial(nombre);

                dtgEditoriales.Rows.Clear();
                dtgEditoriales.Rows.Add(edi.IdEditorial, edi.Nombre);

            }
            catch(Exception ex)
            {
                MessageBox.Show("No existe la editorial");
            }
           

        }

        private void FormEditorial_Load(object sender, EventArgs e)
        {

        }
    }
}
