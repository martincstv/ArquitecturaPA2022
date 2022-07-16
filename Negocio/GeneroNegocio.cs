using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidad;
//using Datos;
using DatosLinq;

namespace Negocio
{
    public static class GeneroNegocio
    {
        public static List<GeneroEntidad> DevolverListaGeneros()
        {
            return GeneroDatos.DevolverListaGeneros();
        }
    }
}
