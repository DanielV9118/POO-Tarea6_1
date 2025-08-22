using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectorioEmp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instancia de la clase Persona
            Clases.Persona persona = new Clases.Persona
            {
                NumeroID = "123456789",
                Nombres = "Juan",
                Apellidos = "Pérez",
                FechaNacimiento = new DateTime(1990, 1, 1),
                Telefono = "123-456-7890",
                Celular = "987-654-3210",
                Pais = "Honduras",
                Ciudad = "Tegucigalpa",
                Direccion = "Calle Falsa 123",
                Profesion = "Ingeniero de Sistemas"
            };
            Console.WriteLine("Persona: {0} {1}, ID: {2}", persona.Nombres, persona.Apellidos, persona.NumeroID);
            Console.WriteLine("Fecha de nacimiento: {0}, Teléfono: {1}, Celular: {2}",
             persona.FechaNacimiento.ToShortDateString(), persona.Telefono, persona.Celular);
             Console.WriteLine("País: {0}, Ciudad: {1}, Dirección: {2}", persona.Pais, persona.Ciudad, persona.Direccion);
            Console.WriteLine("Profesión: {0}", persona.Profesion);
            Console.WriteLine();
            //instancia de la clase Cargo
            Clases.Cargo cargo = new Clases.Cargo
            {
                NumeroCargo = 1,
                Titulo = "Desarrollador de Software",
                FechaInicio = new DateTime(2020, 2, 15),
                FechaFinal = new DateTime(2022, 5, 30),
                EmpleoActual = false,
                Empresa = "Tech Solutions",
                Salario = 50000.00m,
                Detalles = "Desarrollo de aplicaciones web y móviles."
            };
            Console.WriteLine("Cargo: {0}, Empresa: {1}", cargo.Titulo, cargo.Empresa);
            Console.WriteLine("Fecha de inicio: {0}, Fecha final: {1}",
                cargo.FechaInicio.ToShortDateString(), cargo.FechaFinal.ToShortDateString());
            Console.WriteLine("Empleo actual: {0}, Salario: {1:C}",
                cargo.EmpleoActual ? "Sí" : "No", cargo.Salario);
            Console.WriteLine("Detalles: {0}", cargo.Detalles);
            Console.WriteLine();
            // Agregar el cargo a la lista de cargos de la persona
            persona.Cargos.Add(cargo);
            // Crear una instancia de la clase Grado
            Clases.Grado grado = new Clases.Grado
            {
                NumeroGrado = 1,
                NivelEducativo = "Licenciatura",
                Institucion = "Universidad Nacional Autónoma de Honduras",
                NombreTitulo = "Ingeniería en Sistemas",
                FechaInicio = new DateTime(2015, 8, 1),
                FechaFinal = new DateTime(2020, 2, 15),
                TipoGrado = "Académico",
                FechaExpiracion = new DateTime(2025, 12, 31),
                Pais = "Honduras"
            };
            Console.WriteLine("Grado: {1}, Institución: {UMH}", grado.NumeroGrado, grado.Institucion);
            Console.WriteLine("Nivel educativo: {0}, Nombre del título: {1}",
                grado.NivelEducativo, grado.NombreTitulo);
            Console.WriteLine("Fecha de inicio: {0}, Fecha final: {1}",
                grado.FechaInicio.ToShortDateString(), grado.FechaFinal.ToShortDateString());
            Console.WriteLine("Tipo de grado: {0}, País: {1}", grado.TipoGrado, grado.Pais);
            Console.WriteLine("Fecha de expiración: {0}", grado.FechaExpiracion.ToShortDateString());
            // Agregar el grado a la lista de grados de la persona
            persona.Grados.Add(grado);
            Console.WriteLine();
            // Mostrar los cargos y grados de la persona
            Console.WriteLine("Cargos de {0} {1}:", persona.Nombres, persona.Apellidos);
            Console.WriteLine();
            foreach (var c in persona.Cargos)
            {
                Console.WriteLine("Cargo: {0}, Empresa: {1}", c.Titulo, c.Empresa);
                Console.WriteLine("Fecha de inicio: {0}, Fecha final: {1}",
                    c.FechaInicio.ToShortDateString(), c.FechaFinal.ToShortDateString());
                Console.WriteLine("Empleo actual: {0}, Salario: {1:C}",
                    c.EmpleoActual ? "Sí" : "No", c.Salario);
                Console.WriteLine("Detalles: {0}", c.Detalles);
                Console.WriteLine();
            }
            Console.WriteLine("Grados de {0} {1}:", persona.Nombres, persona.Apellidos);

            Console.WriteLine();    

            Clases.Grado _grado = new Clases.Grado
            {
                NumeroGrado = 1,
                NivelEducativo = "Licenciatura",
                Institucion = "Universidad Ejemplo",
                NombreTitulo = "Ingeniería en Sistemas",
                FechaInicio = new DateTime(2015, 8, 1),
                FechaFinal = new DateTime(2019, 6, 30),
                TipoGrado = "Académico",
                FechaExpiracion = new DateTime(2025, 12, 31),
                Pais = "México"
            };
            Console.WriteLine("Grado: {1}, Institución: {UNAH}");
            Console.WriteLine("Nivel educativo: {Licenciatura}, Nombre del título: {Ingeniería en Sistemas}");
            Console.WriteLine("Fecha de inicio: {2015, 8, 1}, Fecha final: {2020, 2, 15}");
            Console.WriteLine("Tipo de grado: {Academico}, País: {Honduras}");
            Console.WriteLine("Fecha de expiración: {2025, 12, 31}");
            Console.ReadLine();
            
        }
    }
}
