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
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public int NumeroDosis { get; set; }
        public PersonalVacunadoEntidad()
        {

        }

        public PersonalVacunadoEntidad(int id, string nombre, string apellido, string cedula, string telefono, int numeroDosis)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Cedula = cedula;
            Telefono = telefono;
            NumeroDosis = numeroDosis;
        }
    }
}
