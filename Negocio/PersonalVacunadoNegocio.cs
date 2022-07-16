using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidad;
//using Datos;
//using DatosLinq;
using DatosEF;

namespace Negocio
{
    public static class PersonalVacunadoNegocio
    {
        public static PersonalVacunadoEntidad Guardar(PersonalVacunadoEntidad personalVacunado)
        {
            if (personalVacunado.Id == 0)
            {
                //Crea un nuevo registro
                return PersonalVacunadoDatos.Nuevo(personalVacunado);
            }
            else
            {
                //Actualiza el registro
                return PersonalVacunadoDatos.Actualizar(personalVacunado);
            }
        }

        public static List<PersonalVacunadoEntidad> DevolverListaPersonasVacunadas()
        {
            return PersonalVacunadoDatos.DevolverListaPersonasVacunadas();
        }

        public static PersonalVacunadoEntidad DevolverPersonalVacunadoPorId(int identificador)
        {
            return PersonalVacunadoDatos.DevolverPersonalVacunadoPorId(identificador);
        }

        public static bool ElimminarPersonalVacunado(int identificador)
        {
            return PersonalVacunadoDatos.ElimminarPersonalVacunado(identificador);
        }

        public static double DevolverSumatoriaCantidadDosis(List<PersonalVacunadoEntidad> listaPVEntidad)
        {
            double sumatoria = 0;
            foreach (var item in listaPVEntidad)
            {
                sumatoria += item.NumeroDosis;
            }
            return sumatoria;
        }
    }
}
