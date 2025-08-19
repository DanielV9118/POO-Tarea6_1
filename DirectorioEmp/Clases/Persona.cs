using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectorioEmp.Clases
{
    public class Persona
    {
        private string numeroID;
        private string nombres;
        private string apellidos;
        private DateTime fechaNacimiento;
        private string telefono;
        private string celular;
        private string pais;
        private string ciudad;
        private string direccion;
        private string profesion;

        private List<Grado> grados;
        private List<Cargo> cargos;

        public string NumeroID { get; set; } 
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Pais { get; set; }
        public string Ciudad { get; set; }
        public string Direccion { get; set; }
        public string Profesion { get; set; }

        public List<Grado> Grados
        {
            get { return grados; }
            set { grados = value; }
        }

        public List<Cargo> Cargos
        {
            get { return cargos; }
            set { cargos = value; }
        }


        public Persona()
        {
            
            grados = new List<Grado>();
            cargos = new List<Cargo>();
        }

           public Persona(string numeroID, 
                          string nombres, 
                          string apellidos, 
                          DateTime fechaNacimiento,
                          string telefono,
                          string celular, 
                          string pais, 
                          string ciudad, 
                          string direccion, 
                          string profesion)
        {
            numeroID = numeroID;
            nombres = nombres;
            apellidos = apellidos;
            fechaNacimiento = fechaNacimiento;
            telefono = telefono;
            celular = celular;
            pais = pais;
            ciudad = ciudad;
            direccion = direccion;
            profesion = profesion;

           grados = new List<Grado>();
           cargos = new List<Cargo>();
        }
    }
}
