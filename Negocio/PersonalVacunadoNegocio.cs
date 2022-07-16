using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidad;
using Datos;

namespace Negocio
{
    public static class PersonalVacunadoNegocio
    {
        public static PersonalVacunadoEntidad Guardar(PersonalVacunadoEntidad personalVacunado)
        {
            if (personalVacunado.Id == 0)
            {
                return PersonalVacunadoDatos.Nuevo(personalVacunado);
            }
            else
            {
                return null;
            }
        }
    }
}
