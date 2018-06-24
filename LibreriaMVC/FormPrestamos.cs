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
    public partial class FormPrestamos : Form
    {
        ControladoraLibro cLibros = new ControladoraLibro();
        ControladoraSocios cSocios = new ControladoraSocios();
        ControladoraIsbn cIsbn = new ControladoraIsbn();
        ControladoraPrestamo cPrestamo = new ControladoraPrestamo();

        public FormPrestamos()
        {
            InitializeComponent();
        }

        private void FormPrestamos_Load(object sender, EventArgs e)
        {
           /* foreach (Socios Osoc in cSocios.DevolverSocios())
            {
                cmbSocios.Items.Add(Osoc.Apellido);
            }
            foreach (Isbn oIsbn in cIsbn.DevolverIsbn())
            {
                cmbLibros.Items.Add(oIsbn.Titulo);
            }
            mskAlquilerFecha.Text = Convert.ToString(DateTime.Now);
            mskFechaEntrega.Text = Convert.ToString(DateTime.Now.AddDays(15));*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormListaPrestamos ListaPrestamos =new  FormListaPrestamos();
            ListaPrestamos.Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int idLibro = cmbLibros.SelectedIndex;
            int idSocio = cmbSocios.SelectedIndex;
            DateTime nulo = Convert.ToDateTime(null);
            DateTime Hoy = DateTime.Now;
            DateTime Devolucion = DateTime.Now.AddDays(15);
            var message = String.Empty;

            if (idLibro == 0 && idSocio == 00)
            {
                cPrestamo.AgregarPrestamo(idLibro, idSocio, Hoy, nulo, 20, Devolucion);
                message = "Guardo con exito";
            }
            else
                message = "Debe llenar los campos";

            MessageBox.Show(message);
        }
    }
}
