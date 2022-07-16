using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class PersonalVacunadoEntidad
    {
        public int Id { get; set; }
        public int Id_Genero { get; set; }
        public string Nombre_Genero { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public int NumeroDosis { get; set; }
        public  DateTime FechaNacimiento { get; set; }
        public string Direccion { get; set; }

        public PersonalVacunadoEntidad()
        {

        }

        public PersonalVacunadoEntidad(int id, int id_Genero, string nombre_Genero, string nombre, string apellido, string cedula, string telefono, int numeroDosis, DateTime fechaNacimiento, string direccion)
        {
            Id = id;
            Id_Genero = id_Genero;
            Nombre_Genero = nombre_Genero;
            Nombre = nombre;
            Apellido = apellido;
            Cedula = cedula;
            Telefono = telefono;
            NumeroDosis = numeroDosis;
            FechaNacimiento = fechaNacimiento;
            Direccion = direccion;
        }
    }
}
