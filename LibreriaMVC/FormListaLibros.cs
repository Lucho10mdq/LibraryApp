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
    public partial class FormListaLibros : Form
    {
        ControladoraLibro cLibros = new ControladoraLibro();
        ControladorEditoriales cEditoriales = new ControladorEditoriales();
        ControladoraIsbn cIsbn = new ControladoraIsbn();
        public FormListaLibros()
        {
            InitializeComponent();
        }

        private void FormListaLibros_Load(object sender, EventArgs e)
        {
            foreach (Libro oLibro in cLibros.DevolverLibros())
            {
                foreach (Editoriales oEditorial in cEditoriales.DevolverEditoriales())
                {
                    foreach (Isbn oIsbn in cIsbn.DevolverIsbn())
                    {
                        if ((oLibro.IdEditorial1 == oEditorial.IdEditorial) && (oLibro.Idisnb == oIsbn.Nisbn))
                        {
                            dtgListaLibros.Rows.Add(oIsbn.Titulo, oEditorial.Nombre, oIsbn.IdIsbn, oLibro.AnioEdicion, oLibro.Estado, oLibro.Disponibilidad);
                        }
                    }
                }
            }
        }
    }
}
