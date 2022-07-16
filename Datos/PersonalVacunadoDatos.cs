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
    public static class PersonalVacunadoDatos
    {

        public static PersonalVacunadoEntidad Nuevo(PersonalVacunadoEntidad personalVacunado)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"INSERT INTO [dbo].[PersonalVacunado]
                                               ([id_Genero]
                                               ,[nombre]
                                               ,[apellido]
                                               ,[cedula]
                                               ,[telefono]
                                               ,[numeroDosis]
                                               ,[fechaNacimiento]
                                               ,[direccion])
                                         VALUES(@id_Genero, @nombre, @apellido, @cedula, @telefono, @numeroDosis, @fechaNacimiento, @direccion);
                                         SELECT SCOPE_IDENTITY()";

                cmd.Parameters.AddWithValue("@id_Genero", personalVacunado.Id_Genero);
                cmd.Parameters.AddWithValue("@nombre", personalVacunado.Nombre);
                cmd.Parameters.AddWithValue("@apellido", personalVacunado.Apellido);
                cmd.Parameters.AddWithValue("@cedula", personalVacunado.Cedula);
                cmd.Parameters.AddWithValue("@telefono", personalVacunado.Telefono);
                cmd.Parameters.AddWithValue("@numeroDosis", personalVacunado.NumeroDosis);
                cmd.Parameters.AddWithValue("@fechaNacimiento", personalVacunado.FechaNacimiento);
                cmd.Parameters.AddWithValue("@direccion", personalVacunado.Direccion);

                int idPersonaVacunada = Convert.ToInt32(cmd.ExecuteScalar());
                personalVacunado.Id = idPersonaVacunada;
                conexion.Close();
                return personalVacunado;
            }
            catch (Exception e)
            {
                var error = e.Message;
                return null;
                throw;
            }
        }

        public static PersonalVacunadoEntidad Actualizar(PersonalVacunadoEntidad personalVacunado)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"UPDATE PersonalVacunado
                                       SET id_Genero = @id_Genero
                                          ,nombre = @nombre
                                          ,apellido = @apellido
                                          ,cedula = @cedula
                                          ,telefono = @telefono
                                          ,numeroDosis = @numeroDosis
                                          ,fechaNacimiento = @fechaNacimiento
                                          ,direccion = @direccion
                                     WHERE id = @id";

                cmd.Parameters.AddWithValue("@id", personalVacunado.Id);
                cmd.Parameters.AddWithValue("@id_Genero", personalVacunado.Id_Genero);
                cmd.Parameters.AddWithValue("@nombre", personalVacunado.Nombre);
                cmd.Parameters.AddWithValue("@apellido", personalVacunado.Apellido);
                cmd.Parameters.AddWithValue("@cedula", personalVacunado.Cedula);
                cmd.Parameters.AddWithValue("@telefono", personalVacunado.Telefono);
                cmd.Parameters.AddWithValue("@numeroDosis", personalVacunado.NumeroDosis);
                cmd.Parameters.AddWithValue("@fechaNacimiento", personalVacunado.FechaNacimiento);
                cmd.Parameters.AddWithValue("@direccion", personalVacunado.Direccion);

                cmd.ExecuteNonQuery();
                conexion.Close();
                return personalVacunado;
            }
            catch (Exception e)
            {
                var error = e.Message;
                return null;
                throw;
            }
        }

        public static List<PersonalVacunadoEntidad> DevolverListaPersonasVacunadas()
        {
            try
            {
                //Lista de objeto en el cual vamos a devolver la informacion
                List<PersonalVacunadoEntidad> listaPersonasVacunadas = new List<PersonalVacunadoEntidad>();

                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"SELECT pv.id
                                          ,pv.id_Genero
	                                      ,g.nombre AS nombreGenero
                                          ,pv.nombre
                                          ,pv.apellido
                                          ,pv.cedula
                                          ,pv.telefono
                                          ,pv.numeroDosis
                                          ,pv.fechaNacimiento
                                          ,pv.direccion
                                      FROM PersonalVacunado pv
                                      INNER JOIN Genero g ON pv.id_Genero = g.id";

                //DataTable OR DataSet NOO se usa en esta arquitectura en capas
                using (var dr = cmd.ExecuteReader())//Trae todos los datos de la base
                {
                    //dr == dataReader variable para entender Ok
                    while (dr.Read())//Lee fila por fila todos los objetos de dr
                    {
                        //Convertir de SqlDataReader ==> PersonalVacunadoEntidad
                        PersonalVacunadoEntidad personalVacunado = new PersonalVacunadoEntidad();

                        personalVacunado.Id = Convert.ToInt32(dr["id"].ToString());
                        personalVacunado.Id_Genero = Convert.ToInt32(dr["id_Genero"].ToString());
                        personalVacunado.Nombre_Genero = dr["nombreGenero"].ToString();
                        personalVacunado.Nombre = dr["nombre"].ToString();
                        personalVacunado.Apellido = dr["apellido"].ToString();
                        personalVacunado.Cedula = dr["cedula"].ToString();
                        personalVacunado.Telefono = dr["telefono"].ToString();
                        personalVacunado.NumeroDosis = Convert.ToInt32(dr["numeroDosis"].ToString());
                        personalVacunado.FechaNacimiento = Convert.ToDateTime(dr["fechaNacimiento"].ToString());
                        personalVacunado.Direccion = dr["direccion"].ToString();

                        //Cargar los datos ==> listaPersonasVacunadas
                        listaPersonasVacunadas.Add(personalVacunado);
                    }
                }
                conexion.Close();
                return listaPersonasVacunadas;
            }
            catch (Exception e)
            {
                var error = e.Message;
                throw;
            }
        }

        public static PersonalVacunadoEntidad DevolverPersonalVacunadoPorId(int identificador)
        {
            try
            {
                PersonalVacunadoEntidad personalVacunado = new PersonalVacunadoEntidad();

                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"SELECT pv.id
                                          ,pv.id_Genero
	                                      ,g.nombre AS nombreGenero
                                          ,pv.nombre
                                          ,pv.apellido
                                          ,pv.cedula
                                          ,pv.telefono
                                          ,pv.numeroDosis
                                          ,pv.fechaNacimiento
                                          ,pv.direccion
                                      FROM PersonalVacunado pv
                                      INNER JOIN Genero g ON pv.id_Genero = g.id
                                      WHERE pv.id = @id";

                cmd.Parameters.AddWithValue("@id", identificador);
                using (var dr = cmd.ExecuteReader())
                {
                    dr.Read();
                    if (dr.HasRows)
                    {
                        personalVacunado.Id = Convert.ToInt32(dr["id"].ToString());
                        personalVacunado.Id_Genero = Convert.ToInt32(dr["id_Genero"].ToString());
                        personalVacunado.Nombre_Genero = dr["nombreGenero"].ToString();
                        personalVacunado.Nombre = dr["nombre"].ToString();
                        personalVacunado.Apellido = dr["apellido"].ToString();
                        personalVacunado.Cedula = dr["cedula"].ToString();
                        personalVacunado.Telefono = dr["telefono"].ToString();
                        personalVacunado.NumeroDosis = Convert.ToInt32(dr["numeroDosis"].ToString());
                        personalVacunado.FechaNacimiento = Convert.ToDateTime(dr["fechaNacimiento"].ToString());
                        personalVacunado.Direccion = dr["direccion"].ToString();
                    }
                }
                conexion.Close();
                return personalVacunado;
            }
            catch (Exception e)
            {
                var error = e.Message;
                return null;
            }
        }

        public static bool ElimminarPersonalVacunado(int identificador)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"DELETE FROM PersonalVacunado
                                          WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", identificador);
                var filasAfectadas = Convert.ToInt32(cmd.ExecuteNonQuery());
                conexion.Close();
                if (filasAfectadas > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                var error = e.Message;
                throw;
            }
        }

        public static double DevolverSumatoriaCantidadDosis()
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"SELECT SUM(numeroDosis) AS SUMA
                                        FROM PersonalVacunado";

                double resultado = Convert.ToDouble(cmd.ExecuteScalar());
                conexion.Close();
                return resultado;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
