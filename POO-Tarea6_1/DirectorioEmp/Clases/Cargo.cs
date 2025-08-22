using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectorioEmp.Clases
{
    public class Cargo
    {
        private int numeroCargo;
        private string titulo;
        private DateTime fechaInicio;
        private DateTime fechaFinal;
        private bool empleoActual;
        private string empresa;
        private decimal salario;
        private string detalles;

        public int NumeroCargo
        {
            get { return numeroCargo; }
            set { numeroCargo = value; }
        }

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
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

        public bool EmpleoActual
        {
            get { return empleoActual; }
            set { empleoActual = value; }
        }

        public string Empresa
        {
            get { return empresa; }
            set { empresa = value; }
        }

        public decimal Salario
        {
            get { return salario; }
            set { salario = value; }
        }

        public string Detalles
        {
            get { return detalles; }
            set { detalles = value; }
        }

        // Constructor vacío
        public Cargo() { }

        // Constructor con parámetros
        public Cargo(int numeroCargo, string titulo, DateTime fechaInicio, DateTime fechaFinal,
                     bool empleoActual, string empresa, decimal salario, string detalles)
        {
            this.numeroCargo = numeroCargo;
            this.titulo = titulo;
            this.fechaInicio = fechaInicio;
            this.fechaFinal = fechaFinal;
            this.empleoActual = empleoActual;
            this.empresa = empresa;
            this.salario = salario;
            this.detalles = detalles;
        }
    }
}