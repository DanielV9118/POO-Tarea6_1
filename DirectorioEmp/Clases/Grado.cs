using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectorioEmp.Clases
{
    public class Grado
    {
        private int numeroGrado;
        private string nivelEducativo;
        private string institucion;
        private string nombreTitulo;
        private DateTime fechaInicio;
        private DateTime fechaFinal;
        private string tipoGrado;
        private DateTime fechaExpiracion;
        private string pais;

        public int NumeroGrado 
        {
            get { return numeroGrado; }
            set { numeroGrado = value; }
        }

        public string NivelEducativo
        {
            get { return nivelEducativo; }
            set { nivelEducativo = value; }
        }

        public string Institucion
        {
            get { return institucion; }
            set { institucion = value; }
        }

        public string NombreTitulo
        {
            get { return nombreTitulo; }
            set { nombreTitulo = value; }
        }

        public DateTime FechaInicio
        {
            get { return fechaInicio; }
            set { fechaInicio = value; }
        }

        public DateTime FechaFinal
        {
            get { return fechaFinal; }
            set { fechaFinal = value; }
        }

        public string TipoGrado
        {
            get { return tipoGrado; }
            set { tipoGrado = value; }
        }

        public DateTime FechaExpiracion
        {
            get { return fechaExpiracion; }
            set { fechaExpiracion = value; }
        }

        public string Pais
        {
            get { return pais; }
            set { pais = value; }
        }
        //Constructor vacio
        public Grado() { }

        public Grado(int numeroGrado,
                    string nivelEducativo,
                    string institucion,
                    string nombreTitulo,
                    DateTime fechaInicio,
                    DateTime fechaFinal,
                    string tipoGrado,
                    DateTime fechaExpiracion,
                    string pais)
        {
            numeroGrado = numeroGrado;
            nivelEducativo = nivelEducativo;
            institucion = institucion;
            nombreTitulo = nombreTitulo;
            fechaInicio = fechaInicio;
            fechaFinal = fechaFinal;
            tipoGrado = tipoGrado;
            fechaExpiracion = fechaExpiracion;
            pais = pais;

        }
    }
}




