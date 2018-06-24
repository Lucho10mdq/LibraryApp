using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Prestamos
    {
        int IdLibro;
        int IdSocio;
        int idPrestamos;
        DateTime fechaEntrega;
        DateTime fechaR;
        double valor;
        DateTime fechaTope;

        public int IdPrestamos
        {
            get
            {
                return idPrestamos;
            }
            set
            {
                idPrestamos = value;

            }

        }
        public int IdLibro1
        {
            get
            {
                return IdLibro;
            }

            set
            {
                IdLibro = value;
            }
        }

        public int IdSocio1
        {
            get
            {
                return IdSocio;
            }

            set
            {
                IdSocio = value;
            }
        }

        public DateTime FechaEntrega
        {
            get
            {
                return fechaEntrega;
            }

            set
            {
                fechaEntrega = value;
            }
        }

        public DateTime FechaR
        {
            get
            {
                return fechaR;
            }

            set
            {
                fechaR = value;
            }
        }

        public double Valor
        {
            get
            {
                return valor;
            }

            set
            {
                valor = value;
            }
        }

        public DateTime FechaTope
        {
            get
            {
                return fechaTope;
            }

            set
            {
                fechaTope = value;
            }
        }

        public Prestamos(int pIdLibro, int pIdSocio, DateTime pFechaEntrega, DateTime pFechaR, double pValor, DateTime pFechaTope)
        {
            IdLibro1 = pIdLibro;
            IdSocio1 = pIdSocio;
            fechaEntrega = pFechaEntrega;
            fechaR = pFechaR;
            valor = pValor;
            fechaTope = pFechaTope;
        }
    }

}

