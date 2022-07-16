using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidad;

namespace DatosEF
{
    public static class GeneroDatos
    {
        public static List<GeneroEntidad> DevolverListaGeneros()
        {
            try
            {
                List<GeneroEntidad> listaGenero = new List<GeneroEntidad>();
                using (var contexto = new VacunacionEntities()) //nombre de la base de datos
                {
                    var listaGeneroEF = contexto.Genero.ToList();
                    foreach (var item in listaGeneroEF)
                    {
                        listaGenero.Add(new GeneroEntidad(item.id,item.nombre));
                    }
                }
                return listaGenero;
            }
            catch (Exception e)
            {
                var error = e.Message;
                throw;
            }
        }

        public static string DevolverNombreGenero(int id_Genero)
        {
            try
            {
                using (var contexto = new VacunacionEntities())
                {
                    var resultado = contexto.Genero.FirstOrDefault(x => x.id == id_Genero);
                    return resultado.nombre;
                }
            }
            catch (Exception e)
            {
                var error = e.Message;
                throw;
            }
        }
    }
}
