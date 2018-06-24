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
    public partial class FormListaPrestamos : Form
    {
        ControladoraLibro cLibros = new ControladoraLibro();
        ControladoraSocios cSocios = new ControladoraSocios();
        ControladoraIsbn cIsbn = new ControladoraIsbn();
        ControladoraPrestamo cPrestamo = new ControladoraPrestamo();
        public FormListaPrestamos()
        {
            InitializeComponent();
        }

        private void FormListaPrestamos_Load(object sender, EventArgs e)
        {
           /* foreach (Libro oLibros in cLibros.DevolverLibros())
            {
                foreach (Isbn oIsbn in cIsbn.DevolverIsbn())
                {
                    foreach (Prestamos oPrestamo in cPrestamo.DevolverTodos())
                    {
                        foreach (Socios oSocio in cSocios.DevolverSocios())
                        {
                            if ((oPrestamo.IdLibro1 == oIsbn.Nisbn) && (oPrestamo.IdSocio1 == oSocio.IdSocios))
                            {
                                dtgListaPrestamos.Rows.Add(oIsbn.Titulo, oSocio.Apellido, oSocio.Nombre, oPrestamo.FechaEntrega, oPrestamo.FechaTope, oPrestamo.Valor);
                            }
                        }
                    }
                }
            }*/
        }
    }
}
