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
                                               ([nombre]
                                               ,[apellido]
                                               ,[cedula]
                                               ,[telefono]
                                               ,[numeroDosis])
                                         VALUES(@nombre, @apellido, @cedula, @telefono, @numeroDosis);
                                         SELECT SCOPE_IDENTITY()";
                cmd.Parameters.AddWithValue("@nombre",personalVacunado.Nombre);
                cmd.Parameters.AddWithValue("@apellido",personalVacunado.Apellido);
                cmd.Parameters.AddWithValue("@cedula",personalVacunado.Cedula);
                cmd.Parameters.AddWithValue("@telefono",personalVacunado.Telefono);
                cmd.Parameters.AddWithValue("@numeroDosis",personalVacunado.NumeroDosis);

                int idPersonaVacunada = Convert.ToInt32(cmd.ExecuteScalar());
                personalVacunado.Id = idPersonaVacunada;
                conexion.Close();
                return personalVacunado;
            }
            catch (Exception e)
            {
                var error = e.Message;
                throw;
            }
        }
    }
}
