using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidad;

namespace DatosEF
{
    public static class PersonalVacunadoDatos
    {
        public static PersonalVacunadoEntidad Nuevo(PersonalVacunadoEntidad personalVacunadoEntidad)
        {
            try
            {
                PersonalVacunado personalVacunadoEF = new PersonalVacunado();
                personalVacunadoEF.id = personalVacunadoEntidad.Id;
                personalVacunadoEF.id_Genero = personalVacunadoEntidad.Id_Genero;
                personalVacunadoEF.nombre = personalVacunadoEntidad.Nombre;
                personalVacunadoEF.apellido = personalVacunadoEntidad.Apellido;
                personalVacunadoEF.cedula = personalVacunadoEntidad.Cedula;
                personalVacunadoEF.telefono = personalVacunadoEntidad.Telefono;
                personalVacunadoEF.numeroDosis = personalVacunadoEntidad.NumeroDosis;
                personalVacunadoEF.fechaNacimiento = personalVacunadoEntidad.FechaNacimiento;
                personalVacunadoEF.direccion = personalVacunadoEntidad.Direccion;

                using (var contexto = new VacunacionEntities())
                {
                    contexto.PersonalVacunado.Add(personalVacunadoEF);
                    contexto.SaveChanges();
                }

                personalVacunadoEntidad.Id = personalVacunadoEF.id;
                return personalVacunadoEntidad;
            }
            catch (Exception e)
            {
                var error = e.Message;
                throw;
            }
        }

        public static PersonalVacunadoEntidad Actualizar(PersonalVacunadoEntidad personalVacunadoEntidad)
        {
            try
            {
                PersonalVacunado personalVacunadoEF = new PersonalVacunado();
                personalVacunadoEF.id = personalVacunadoEntidad.Id;
                personalVacunadoEF.id_Genero = personalVacunadoEntidad.Id_Genero;
                personalVacunadoEF.nombre = personalVacunadoEntidad.Nombre;
                personalVacunadoEF.apellido = personalVacunadoEntidad.Apellido;
                personalVacunadoEF.cedula = personalVacunadoEntidad.Cedula;
                personalVacunadoEF.telefono = personalVacunadoEntidad.Telefono;
                personalVacunadoEF.numeroDosis = personalVacunadoEntidad.NumeroDosis;
                personalVacunadoEF.fechaNacimiento = personalVacunadoEntidad.FechaNacimiento;
                personalVacunadoEF.direccion = personalVacunadoEntidad.Direccion;

                using (var contexto = new VacunacionEntities())
                {
                    contexto.PersonalVacunado.AddOrUpdate(personalVacunadoEF);
                    contexto.SaveChanges();
                }

                return personalVacunadoEntidad;
            }
            catch (Exception e)
            {
                var error = e.Message;
                throw;
            }
        }

        public static List<PersonalVacunadoEntidad> DevolverListaPersonasVacunadas()
        {
            try
            {
                List<PersonalVacunadoEntidad> listaPersonalVacunado = new List<PersonalVacunadoEntidad>();
                using (var contexto = new VacunacionEntities())
                {
                    var listaPersonalVacunadoEF = contexto.PersonalVacunado
                                                  .Include("Genero")
                                                  .ToList();

                    foreach (var item in listaPersonalVacunadoEF)
                    {
                        listaPersonalVacunado.Add(new PersonalVacunadoEntidad(
                                                  item.id,
                                                  item.id_Genero,
                                                  //GeneroDatos.DevolverNombreGenero(item.id_Genero),
                                                  item.Genero.nombre,
                                                  item.nombre,
                                                  item.apellido,
                                                  item.cedula,
                                                  item.telefono,
                                                  item.numeroDosis,
                                                  item.fechaNacimiento,
                                                  item.direccion
                            ));
                    }
                    return listaPersonalVacunado;
                }
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
                PersonalVacunadoEntidad personalVacunadoEntidad = new PersonalVacunadoEntidad();
                using (var contexto = new VacunacionEntities())
                {
                    var personalVacunadoEF = contexto.PersonalVacunado.FirstOrDefault(x => x.id == identificador);

                    personalVacunadoEntidad.Id = personalVacunadoEF.id;
                    personalVacunadoEntidad.Id_Genero = personalVacunadoEF.id_Genero;
                    //personalVacunadoEntidad.Nombre_Genero = GeneroDatos.DevolverNombreGenero(personalVacunadoEF.id_Genero);
                    personalVacunadoEntidad.Nombre_Genero = personalVacunadoEF.Genero.nombre;
                    personalVacunadoEntidad.Nombre = personalVacunadoEF.nombre;
                    personalVacunadoEntidad.Apellido = personalVacunadoEF.apellido;
                    personalVacunadoEntidad.Cedula = personalVacunadoEF.cedula;
                    personalVacunadoEntidad.Telefono = personalVacunadoEF.telefono;
                    personalVacunadoEntidad.NumeroDosis = personalVacunadoEF.numeroDosis;
                    personalVacunadoEntidad.FechaNacimiento = personalVacunadoEF.fechaNacimiento;
                    personalVacunadoEntidad.Direccion = personalVacunadoEF.direccion;

                    return personalVacunadoEntidad;
                }
            }
            catch (Exception e)
            {
                var error = e.Message;
                throw;
            }
        }

        public static bool ElimminarPersonalVacunado(int identificador)
        {
            try
            {
                using (var contexto = new VacunacionEntities())
                {
                    var personalVacunadoEF = contexto.PersonalVacunado.FirstOrDefault(x => x.id == identificador);
                    contexto.PersonalVacunado.Remove(personalVacunadoEF);
                    contexto.SaveChanges();
                    return true;
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
                return 1234;
            }
            catch (Exception e)
            {
                var error = e.Message;
                throw;
            }
        }
    }
}
