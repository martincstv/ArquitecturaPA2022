using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidad;

namespace DatosLinq
{
    public static class PersonalVacunadoDatos
    {
        public static PersonalVacunadoEntidad Nuevo(PersonalVacunadoEntidad personalVacunadoEntidad)
        {
            try
            {
                PersonalVacunado personalVacunadoLinq = new PersonalVacunado();
                personalVacunadoLinq.id = personalVacunadoEntidad.Id;
                personalVacunadoLinq.id_Genero = personalVacunadoEntidad.Id_Genero;
                personalVacunadoLinq.nombre = personalVacunadoEntidad.Nombre;
                personalVacunadoLinq.apellido = personalVacunadoEntidad.Apellido;
                personalVacunadoLinq.cedula = personalVacunadoEntidad.Cedula;
                personalVacunadoLinq.telefono = personalVacunadoEntidad.Telefono;
                personalVacunadoLinq.numeroDosis = personalVacunadoEntidad.NumeroDosis;
                personalVacunadoLinq.fechaNacimiento = personalVacunadoEntidad.FechaNacimiento;
                personalVacunadoLinq.direccion = personalVacunadoEntidad.Direccion;

                using (DataClasses1DataContext contexto = new DataClasses1DataContext())
                {
                    contexto.PersonalVacunado.InsertOnSubmit(personalVacunadoLinq);
                    contexto.SubmitChanges();
                }

                personalVacunadoEntidad.Id = personalVacunadoLinq.id;
                return personalVacunadoEntidad;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static PersonalVacunadoEntidad Actualizar(PersonalVacunadoEntidad personalVacunadoEntidad)
        {
            try
            {
                using (DataClasses1DataContext contexto = new DataClasses1DataContext())
                {
                    PersonalVacunado personalVacunadoLinq = new PersonalVacunado();
                    personalVacunadoLinq = contexto.PersonalVacunado.FirstOrDefault(x => x.id == personalVacunadoEntidad.Id);
                    personalVacunadoLinq.id = personalVacunadoEntidad.Id;
                    personalVacunadoLinq.id_Genero = personalVacunadoEntidad.Id_Genero;
                    personalVacunadoLinq.nombre = personalVacunadoEntidad.Nombre;
                    personalVacunadoLinq.apellido = personalVacunadoEntidad.Apellido;
                    personalVacunadoLinq.cedula = personalVacunadoEntidad.Cedula;
                    personalVacunadoLinq.telefono = personalVacunadoEntidad.Telefono;
                    personalVacunadoLinq.numeroDosis = personalVacunadoEntidad.NumeroDosis;
                    personalVacunadoLinq.fechaNacimiento = personalVacunadoEntidad.FechaNacimiento;
                    personalVacunadoLinq.direccion = personalVacunadoEntidad.Direccion;

                    contexto.SubmitChanges();
                    return personalVacunadoEntidad;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<PersonalVacunadoEntidad> DevolverListaPersonasVacunadas()
        {
            try
            {
                List<PersonalVacunadoEntidad> listaPersonalVacunadoEntidad = new List<PersonalVacunadoEntidad>();
                List<PersonalVacunado> listaPersonalVacunadoLinq = new List<PersonalVacunado>();

                using (DataClasses1DataContext contexto = new DataClasses1DataContext())
                {
                    var resultado = from p in contexto.PersonalVacunado
                                    select p;
                    listaPersonalVacunadoLinq = resultado.ToList();
                }
                foreach (var item in listaPersonalVacunadoLinq)
                {
                    listaPersonalVacunadoEntidad.Add(new PersonalVacunadoEntidad(
                                                     item.id,
                                                     item.id_Genero,
                                                     GeneroDatos.DevolverNombreGenero(item.id_Genero),
                                                     item.nombre,
                                                     item.apellido,
                                                     item.cedula,
                                                     item.telefono,
                                                     item.numeroDosis,
                                                     item.fechaNacimiento,
                                                     item.direccion
                       ));
                }
                return listaPersonalVacunadoEntidad;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static PersonalVacunadoEntidad DevolverPersonalVacunadoPorId(int identificador)
        {
            try
            {
                PersonalVacunadoEntidad personalVacunadoEntidad = new PersonalVacunadoEntidad();
                PersonalVacunado personalVacunadoLinq = new PersonalVacunado();

                using (DataClasses1DataContext contexto = new DataClasses1DataContext())
                {
                    personalVacunadoLinq = contexto.PersonalVacunado.FirstOrDefault(x => x.id == identificador);
                }
                personalVacunadoEntidad.Id = personalVacunadoLinq.id;
                personalVacunadoEntidad.Id_Genero = personalVacunadoLinq.id_Genero;
                personalVacunadoEntidad.Nombre_Genero = GeneroDatos.DevolverNombreGenero(personalVacunadoLinq.id_Genero);
                personalVacunadoEntidad.Nombre = personalVacunadoLinq.nombre;
                personalVacunadoEntidad.Apellido = personalVacunadoLinq.apellido;
                personalVacunadoEntidad.Cedula = personalVacunadoLinq.cedula;
                personalVacunadoEntidad.Telefono = personalVacunadoLinq.telefono;
                personalVacunadoEntidad.NumeroDosis = personalVacunadoLinq.numeroDosis;
                personalVacunadoEntidad.FechaNacimiento = personalVacunadoLinq.fechaNacimiento;
                personalVacunadoEntidad.Direccion = personalVacunadoLinq.direccion;

                return personalVacunadoEntidad;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool ElimminarPersonalVacunado(int identificador)
        {
            try
            {
                using (DataClasses1DataContext contexto = new DataClasses1DataContext())
                {
                    var personalVacunadoLinq = contexto.PersonalVacunado.FirstOrDefault(x => x.id == identificador);
                    contexto.PersonalVacunado.DeleteOnSubmit(personalVacunadoLinq);
                    contexto.SubmitChanges();
                    return true;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static double DevolverSumatoriaCantidadDosis()
        {
            try
            {
                using (DataClasses1DataContext contexto = new DataClasses1DataContext())
                {
                    var resultado = contexto.View_SumatoriaNumeroDosis.FirstOrDefault();
                    return (double) resultado.SUMA;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
