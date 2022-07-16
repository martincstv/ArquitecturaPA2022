using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidad;

namespace DatosLinq
{
    public static class GeneroDatos
    {
        public static List<GeneroEntidad> DevolverListaGeneros()
        {
            try
            {
                List<GeneroEntidad> listaGeneroEntidad = new List<GeneroEntidad>();
                List<Genero> listaGeneroLinq = new List<Genero>();
                using (DataClasses1DataContext contexto = new DataClasses1DataContext())
                {
                    var resultado = from g in contexto.Genero
                                    select g;
                    listaGeneroLinq = resultado.ToList();
                }
                foreach (var item in listaGeneroLinq)
                {
                    listaGeneroEntidad.Add(new GeneroEntidad(item.id, item.nombre));
                }
                return listaGeneroEntidad;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static string DevolverNombreGenero(int id_Genero)
        {
            try
            {
                using (DataClasses1DataContext contexto = new DataClasses1DataContext())
                {
                    var resultado = contexto.Genero.FirstOrDefault(x => x.id == id_Genero);
                    return resultado.nombre;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
