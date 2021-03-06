﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LaunchKey.Examples.AspMvc
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="aspnet-LaunchKey.Examples.AspMvc-20130820225740")]
	public partial class LkExampleDatabaseDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    #endregion
		
		public LkExampleDatabaseDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["aspnet_LaunchKey_Examples_AspMvc_20130820225740ConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public LkExampleDatabaseDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LkExampleDatabaseDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LkExampleDatabaseDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LkExampleDatabaseDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[User]")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _FirstName;
		
		private string _LaunchKeyUserHash;
		
		private string _LastAuthRequest;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnLaunchKeyUserHashChanging(string value);
    partial void OnLaunchKeyUserHashChanged();
    partial void OnLastAuthRequestChanging(string value);
    partial void OnLastAuthRequestChanged();
    #endregion
		
		public User()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this.OnFirstNameChanging(value);
					this.SendPropertyChanging();
					this._FirstName = value;
					this.SendPropertyChanged("FirstName");
					this.OnFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LaunchKeyUserHash", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string LaunchKeyUserHash
		{
			get
			{
				return this._LaunchKeyUserHash;
			}
			set
			{
				if ((this._LaunchKeyUserHash != value))
				{
					this.OnLaunchKeyUserHashChanging(value);
					this.SendPropertyChanging();
					this._LaunchKeyUserHash = value;
					this.SendPropertyChanged("LaunchKeyUserHash");
					this.OnLaunchKeyUserHashChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastAuthRequest", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string LastAuthRequest
		{
			get
			{
				return this._LastAuthRequest;
			}
			set
			{
				if ((this._LastAuthRequest != value))
				{
					this.OnLastAuthRequestChanging(value);
					this.SendPropertyChanging();
					this._LastAuthRequest = value;
					this.SendPropertyChanged("LastAuthRequest");
					this.OnLastAuthRequestChanged();
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
}
#pragma warning restore 1591
