using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidad;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public static class GeneroDatos
    {
        public static List<GeneroEntidad> DevolverListaGeneros()
        {
            try
            {
                List<GeneroEntidad> listaGeneros = new List<GeneroEntidad>();

                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"SELECT id
                                          ,nombre
                                      FROM Genero";

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        GeneroEntidad genero = new GeneroEntidad();

                        genero.Id = Convert.ToInt32(dr["id"].ToString());
                        genero.Nombre = dr["nombre"].ToString();

                        listaGeneros.Add(genero);
                    }
                }
                conexion.Close();
                return listaGeneros;
            }
            catch (Exception e)
            {
                var error = e.Message;
                throw;
            }
        }
    }
}
