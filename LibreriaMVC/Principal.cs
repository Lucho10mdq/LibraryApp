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
    
    public partial class Principal : Form
    {
        ControladoraIsbn cIsbn = new ControladoraIsbn();
        int ideditorial1 = 1;
        string titulo1 ="El Hobit";
        int idisbn1 = 14896;
        int nroIsbn = 1;

        int ideditorial2 = 2;
        string titulo2= "El Principito";
        int idisbn2 = 45689;
        int nroIsbn2=3;

        int ideditorial3 = 3;
        string titulo3 = "Capelucita";
        int idisbn3 = 56233;
        int nroIsb3 = 3;

        public Principal()
        {
            InitializeComponent();
           // cIsbn.AgregarIsbn(ideditorial1, titulo1, idisbn1, nroIsbn, ideditorial2, titulo2, idisbn2, nroIsbn2, ideditorial3, titulo3, idisbn3, nroIsb3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAgregarSocio AgregarSocio = new FormAgregarSocio();
            AgregarSocio.Show();
            
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void btnAutores_Click(object sender, EventArgs e)
        {
            FormAutores Autores = new FormAutores();
            Autores.Show();
        }

        private void btnEditoriales_Click(object sender, EventArgs e)
        {
            FormEditorial Editoriales = new FormEditorial();
            Editoriales.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLibros_Click(object sender, EventArgs e)
        {
            FormLibro Libros = new FormLibro();
            Libros.Show();
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            FormPrestamos Prestamos = new FormPrestamos();
            Prestamos.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void agregarAutorTSM_Click(object sender, EventArgs e)
        {
            FormAutores Autores = new FormAutores();
            Autores.Show();
        }

        private void buscarAutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAutores Autores = new FormAutores();
            Autores.Show();
        }

        private void listaDeAutoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAutores Autores = new FormAutores();
            Autores.Show();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditorial Editoriales = new FormEditorial();
            Editoriales.Show();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditorial Editoriales = new FormEditorial();
            Editoriales.Show();
        }

        private void listaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditorial Editoriales = new FormEditorial();
            Editoriales.Show();
        }

        private void agregarLibroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLibro Libros = new FormLibro();
            Libros.Show();
        }

        private void listaDeLibrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListaLibros listalibros = new FormListaLibros();
            listalibros.Show();
        }

        private void agregarPrestamoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPrestamos Prestamos = new FormPrestamos();
            Prestamos.Show();
        }

        private void listaDePrestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListaPrestamos ListaPrestamos = new FormListaPrestamos();
            ListaPrestamos.Show();
        }

        private void agregarSocioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAgregarSocio AgregarSocio = new FormAgregarSocio();
            AgregarSocio.Show();
        }

        private void buscarSocioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBuscarSocio BuscarSocio = new FormBuscarSocio();
            BuscarSocio.Show();
        }

        private void listarSocioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListaSocios listaSocios = new FormListaSocios();
            listaSocios.Show();
        }
    }
}
