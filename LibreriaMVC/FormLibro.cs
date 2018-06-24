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
    public partial class FormLibro : Form
    {
        ControladorEditoriales cControlador = new ControladorEditoriales();
        ControladoraIsbn cIsbn = new ControladoraIsbn();
        ControladoraLibro cLibro = new ControladoraLibro();
        int  idLibro=0;
        public FormLibro()
        {
            InitializeComponent();
            foreach (Editoriales Oed in cControlador.DevolverEditoriales())
            {
                cmbEditorial.Items.Add(Oed.Nombre);
            }

            foreach (Isbn Oisbn in cIsbn.DevolverIsbn())
            {
                cmbIsbn.Items.Add(Oisbn.IdIsbn);
            }
        }

        private void FormLibro_Load(object sender, EventArgs e)
        {
           
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int idEditorial = cmbEditorial.SelectedIndex;
            int idIsbn = cmbIsbn.SelectedIndex;
            string datos = "";
            var message = String.Empty;

            if (idEditorial == 0 && idIsbn == 0 && !String.IsNullOrEmpty(mskAnio.Text))
            {

                if (rdbNuevo.Checked)
                {
                    datos = "Nuevo";

                }
                if (rdbUsado.Checked)
                {
                    datos = "Usado";

                }
                idLibro = idLibro + 1;
                cLibro.Agregar(Convert.ToDateTime(mskAnio.Text), idEditorial, idIsbn, datos, true, idLibro);
                message = "Se guardo con exito";
            }
            else
                message = "Debe llenar los campos";

            MessageBox.Show(message);
                    
       }

        private void button2_Click(object sender, EventArgs e)
        {
            FormListaLibros listalibros = new FormListaLibros();
            listalibros.Show();
                
        }
    }
  }

