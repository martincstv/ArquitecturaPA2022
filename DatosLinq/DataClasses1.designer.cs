﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatosLinq
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Vacunacion")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void InsertGenero(Genero instance);
    partial void UpdateGenero(Genero instance);
    partial void DeleteGenero(Genero instance);
    partial void InsertPersonalVacunado(PersonalVacunado instance);
    partial void UpdatePersonalVacunado(PersonalVacunado instance);
    partial void DeletePersonalVacunado(PersonalVacunado instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::DatosLinq.Properties.Settings.Default.VacunacionConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Genero> Genero
		{
			get
			{
				return this.GetTable<Genero>();
			}
		}
		
		public System.Data.Linq.Table<PersonalVacunado> PersonalVacunado
		{
			get
			{
				return this.GetTable<PersonalVacunado>();
			}
		}
		
		public System.Data.Linq.Table<View_SumatoriaNumeroDosis> View_SumatoriaNumeroDosis
		{
			get
			{
				return this.GetTable<View_SumatoriaNumeroDosis>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Genero")]
	public partial class Genero : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _nombre;
		
		private EntitySet<PersonalVacunado> _PersonalVacunado;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnombreChanging(string value);
    partial void OnnombreChanged();
    #endregion
		
		public Genero()
		{
			this._PersonalVacunado = new EntitySet<PersonalVacunado>(new Action<PersonalVacunado>(this.attach_PersonalVacunado), new Action<PersonalVacunado>(this.detach_PersonalVacunado));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombre", DbType="NVarChar(50)")]
		public string nombre
		{
			get
			{
				return this._nombre;
			}
			set
			{
				if ((this._nombre != value))
				{
					this.OnnombreChanging(value);
					this.SendPropertyChanging();
					this._nombre = value;
					this.SendPropertyChanged("nombre");
					this.OnnombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Genero_PersonalVacunado", Storage="_PersonalVacunado", ThisKey="id", OtherKey="id_Genero")]
		public EntitySet<PersonalVacunado> PersonalVacunado
		{
			get
			{
				return this._PersonalVacunado;
			}
			set
			{
				this._PersonalVacunado.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_PersonalVacunado(PersonalVacunado entity)
		{
			this.SendPropertyChanging();
			entity.Genero = this;
		}
		
		private void detach_PersonalVacunado(PersonalVacunado entity)
		{
			this.SendPropertyChanging();
			entity.Genero = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PersonalVacunado")]
	public partial class PersonalVacunado : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private int _id_Genero;
		
		private string _nombre;
		
		private string _apellido;
		
		private string _cedula;
		
		private string _telefono;
		
		private int _numeroDosis;
		
		private System.DateTime _fechaNacimiento;
		
		private string _direccion;
		
		private EntityRef<Genero> _Genero;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void Onid_GeneroChanging(int value);
    partial void Onid_GeneroChanged();
    partial void OnnombreChanging(string value);
    partial void OnnombreChanged();
    partial void OnapellidoChanging(string value);
    partial void OnapellidoChanged();
    partial void OncedulaChanging(string value);
    partial void OncedulaChanged();
    partial void OntelefonoChanging(string value);
    partial void OntelefonoChanged();
    partial void OnnumeroDosisChanging(int value);
    partial void OnnumeroDosisChanged();
    partial void OnfechaNacimientoChanging(System.DateTime value);
    partial void OnfechaNacimientoChanged();
    partial void OndireccionChanging(string value);
    partial void OndireccionChanged();
    #endregion
		
		public PersonalVacunado()
		{
			this._Genero = default(EntityRef<Genero>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_Genero", DbType="Int")]
		public int id_Genero
		{
			get
			{
				return this._id_Genero;
			}
			set
			{
				if ((this._id_Genero != value))
				{
					if (this._Genero.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onid_GeneroChanging(value);
					this.SendPropertyChanging();
					this._id_Genero = value;
					this.SendPropertyChanged("id_Genero");
					this.Onid_GeneroChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombre", DbType="NVarChar(50)")]
		public string nombre
		{
			get
			{
				return this._nombre;
			}
			set
			{
				if ((this._nombre != value))
				{
					this.OnnombreChanging(value);
					this.SendPropertyChanging();
					this._nombre = value;
					this.SendPropertyChanged("nombre");
					this.OnnombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_apellido", DbType="NVarChar(50)")]
		public string apellido
		{
			get
			{
				return this._apellido;
			}
			set
			{
				if ((this._apellido != value))
				{
					this.OnapellidoChanging(value);
					this.SendPropertyChanging();
					this._apellido = value;
					this.SendPropertyChanged("apellido");
					this.OnapellidoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cedula", DbType="NVarChar(10)")]
		public string cedula
		{
			get
			{
				return this._cedula;
			}
			set
			{
				if ((this._cedula != value))
				{
					this.OncedulaChanging(value);
					this.SendPropertyChanging();
					this._cedula = value;
					this.SendPropertyChanged("cedula");
					this.OncedulaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_telefono", DbType="NVarChar(10)")]
		public string telefono
		{
			get
			{
				return this._telefono;
			}
			set
			{
				if ((this._telefono != value))
				{
					this.OntelefonoChanging(value);
					this.SendPropertyChanging();
					this._telefono = value;
					this.SendPropertyChanged("telefono");
					this.OntelefonoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_numeroDosis", DbType="Int")]
		public int numeroDosis
		{
			get
			{
				return this._numeroDosis;
			}
			set
			{
				if ((this._numeroDosis != value))
				{
					this.OnnumeroDosisChanging(value);
					this.SendPropertyChanging();
					this._numeroDosis = value;
					this.SendPropertyChanged("numeroDosis");
					this.OnnumeroDosisChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fechaNacimiento", DbType="Date")]
		public System.DateTime fechaNacimiento
		{
			get
			{
				return this._fechaNacimiento;
			}
			set
			{
				if ((this._fechaNacimiento != value))
				{
					this.OnfechaNacimientoChanging(value);
					this.SendPropertyChanging();
					this._fechaNacimiento = value;
					this.SendPropertyChanged("fechaNacimiento");
					this.OnfechaNacimientoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_direccion", DbType="NVarChar(100)")]
		public string direccion
		{
			get
			{
				return this._direccion;
			}
			set
			{
				if ((this._direccion != value))
				{
					this.OndireccionChanging(value);
					this.SendPropertyChanging();
					this._direccion = value;
					this.SendPropertyChanged("direccion");
					this.OndireccionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Genero_PersonalVacunado", Storage="_Genero", ThisKey="id_Genero", OtherKey="id", IsForeignKey=true)]
		public Genero Genero
		{
			get
			{
				return this._Genero.Entity;
			}
			set
			{
				Genero previousValue = this._Genero.Entity;
				if (((previousValue != value) 
							|| (this._Genero.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Genero.Entity = null;
						previousValue.PersonalVacunado.Remove(this);
					}
					this._Genero.Entity = value;
					if ((value != null))
					{
						value.PersonalVacunado.Add(this);
						this._id_Genero = value.id;
					}
					else
					{
						this._id_Genero = default(int);
					}
					this.SendPropertyChanged("Genero");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.View_SumatoriaNumeroDosis")]
	public partial class View_SumatoriaNumeroDosis
	{
		
		private System.Nullable<int> _SUMA;
		
		public View_SumatoriaNumeroDosis()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SUMA", DbType="Int")]
		public System.Nullable<int> SUMA
		{
			get
			{
				return this._SUMA;
			}
			set
			{
				if ((this._SUMA != value))
				{
					this._SUMA = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
