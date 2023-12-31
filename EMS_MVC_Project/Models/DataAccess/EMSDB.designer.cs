﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EMS_MVC_Project.Models.DataAccess
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QuickXpert")]
	public partial class EMSDBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertTCategory(TCategory instance);
    partial void UpdateTCategory(TCategory instance);
    partial void DeleteTCategory(TCategory instance);
    partial void InsertTCourse(TCourse instance);
    partial void UpdateTCourse(TCourse instance);
    partial void DeleteTCourse(TCourse instance);
    partial void InsertTStudent(TStudent instance);
    partial void UpdateTStudent(TStudent instance);
    partial void DeleteTStudent(TStudent instance);
    #endregion
		
		public EMSDBDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["QuickXpertConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public EMSDBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public EMSDBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public EMSDBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public EMSDBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<TCategory> TCategories
		{
			get
			{
				return this.GetTable<TCategory>();
			}
		}
		
		public System.Data.Linq.Table<TCourse> TCourses
		{
			get
			{
				return this.GetTable<TCourse>();
			}
		}
		
		public System.Data.Linq.Table<TStudent> TStudents
		{
			get
			{
				return this.GetTable<TStudent>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TCategory")]
	public partial class TCategory : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CategoryId;
		
		private string _CategoryName;
		
		private EntitySet<TCourse> _TCourses;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCategoryIdChanging(int value);
    partial void OnCategoryIdChanged();
    partial void OnCategoryNameChanging(string value);
    partial void OnCategoryNameChanged();
    #endregion
		
		public TCategory()
		{
			this._TCourses = new EntitySet<TCourse>(new Action<TCourse>(this.attach_TCourses), new Action<TCourse>(this.detach_TCourses));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CategoryId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int CategoryId
		{
			get
			{
				return this._CategoryId;
			}
			set
			{
				if ((this._CategoryId != value))
				{
					this.OnCategoryIdChanging(value);
					this.SendPropertyChanging();
					this._CategoryId = value;
					this.SendPropertyChanged("CategoryId");
					this.OnCategoryIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CategoryName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string CategoryName
		{
			get
			{
				return this._CategoryName;
			}
			set
			{
				if ((this._CategoryName != value))
				{
					this.OnCategoryNameChanging(value);
					this.SendPropertyChanging();
					this._CategoryName = value;
					this.SendPropertyChanged("CategoryName");
					this.OnCategoryNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TCategory_TCourse", Storage="_TCourses", ThisKey="CategoryId", OtherKey="CourseCategoryId")]
		public EntitySet<TCourse> TCourses
		{
			get
			{
				return this._TCourses;
			}
			set
			{
				this._TCourses.Assign(value);
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
		
		private void attach_TCourses(TCourse entity)
		{
			this.SendPropertyChanging();
			entity.TCategory = this;
		}
		
		private void detach_TCourses(TCourse entity)
		{
			this.SendPropertyChanging();
			entity.TCategory = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TCourse")]
	public partial class TCourse : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CourseId;
		
		private string _CourseName;
		
		private int _CourseDuration;
		
		private int _CourseFee;
		
		private int _CourseCategoryId;
		
		private EntitySet<TStudent> _TStudents;
		
		private EntityRef<TCategory> _TCategory;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCourseIdChanging(int value);
    partial void OnCourseIdChanged();
    partial void OnCourseNameChanging(string value);
    partial void OnCourseNameChanged();
    partial void OnCourseDurationChanging(int value);
    partial void OnCourseDurationChanged();
    partial void OnCourseFeeChanging(int value);
    partial void OnCourseFeeChanged();
    partial void OnCourseCategoryIdChanging(int value);
    partial void OnCourseCategoryIdChanged();
    #endregion
		
		public TCourse()
		{
			this._TStudents = new EntitySet<TStudent>(new Action<TStudent>(this.attach_TStudents), new Action<TStudent>(this.detach_TStudents));
			this._TCategory = default(EntityRef<TCategory>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CourseId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int CourseId
		{
			get
			{
				return this._CourseId;
			}
			set
			{
				if ((this._CourseId != value))
				{
					this.OnCourseIdChanging(value);
					this.SendPropertyChanging();
					this._CourseId = value;
					this.SendPropertyChanged("CourseId");
					this.OnCourseIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CourseName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string CourseName
		{
			get
			{
				return this._CourseName;
			}
			set
			{
				if ((this._CourseName != value))
				{
					this.OnCourseNameChanging(value);
					this.SendPropertyChanging();
					this._CourseName = value;
					this.SendPropertyChanged("CourseName");
					this.OnCourseNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CourseDuration", DbType="Int NOT NULL")]
		public int CourseDuration
		{
			get
			{
				return this._CourseDuration;
			}
			set
			{
				if ((this._CourseDuration != value))
				{
					this.OnCourseDurationChanging(value);
					this.SendPropertyChanging();
					this._CourseDuration = value;
					this.SendPropertyChanged("CourseDuration");
					this.OnCourseDurationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CourseFee", DbType="Int NOT NULL")]
		public int CourseFee
		{
			get
			{
				return this._CourseFee;
			}
			set
			{
				if ((this._CourseFee != value))
				{
					this.OnCourseFeeChanging(value);
					this.SendPropertyChanging();
					this._CourseFee = value;
					this.SendPropertyChanged("CourseFee");
					this.OnCourseFeeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CourseCategoryId", DbType="Int NOT NULL")]
		public int CourseCategoryId
		{
			get
			{
				return this._CourseCategoryId;
			}
			set
			{
				if ((this._CourseCategoryId != value))
				{
					if (this._TCategory.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCourseCategoryIdChanging(value);
					this.SendPropertyChanging();
					this._CourseCategoryId = value;
					this.SendPropertyChanged("CourseCategoryId");
					this.OnCourseCategoryIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TCourse_TStudent", Storage="_TStudents", ThisKey="CourseId", OtherKey="CourseId")]
		public EntitySet<TStudent> TStudents
		{
			get
			{
				return this._TStudents;
			}
			set
			{
				this._TStudents.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TCategory_TCourse", Storage="_TCategory", ThisKey="CourseCategoryId", OtherKey="CategoryId", IsForeignKey=true)]
		public TCategory TCategory
		{
			get
			{
				return this._TCategory.Entity;
			}
			set
			{
				TCategory previousValue = this._TCategory.Entity;
				if (((previousValue != value) 
							|| (this._TCategory.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._TCategory.Entity = null;
						previousValue.TCourses.Remove(this);
					}
					this._TCategory.Entity = value;
					if ((value != null))
					{
						value.TCourses.Add(this);
						this._CourseCategoryId = value.CategoryId;
					}
					else
					{
						this._CourseCategoryId = default(int);
					}
					this.SendPropertyChanged("TCategory");
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
		
		private void attach_TStudents(TStudent entity)
		{
			this.SendPropertyChanging();
			entity.TCourse = this;
		}
		
		private void detach_TStudents(TStudent entity)
		{
			this.SendPropertyChanging();
			entity.TCourse = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TStudent")]
	public partial class TStudent : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _StudentId;
		
		private string _StudentName;
		
		private System.Nullable<char> _Gender;
		
		private string _ContactNumber;
		
		private string _EmailAddress;
		
		private System.Nullable<System.DateTime> _EnrollementDate;
		
		private int _CourseId;
		
		private EntityRef<TCourse> _TCourse;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnStudentIdChanging(int value);
    partial void OnStudentIdChanged();
    partial void OnStudentNameChanging(string value);
    partial void OnStudentNameChanged();
    partial void OnGenderChanging(System.Nullable<char> value);
    partial void OnGenderChanged();
    partial void OnContactNumberChanging(string value);
    partial void OnContactNumberChanged();
    partial void OnEmailAddressChanging(string value);
    partial void OnEmailAddressChanged();
    partial void OnEnrollementDateChanging(System.Nullable<System.DateTime> value);
    partial void OnEnrollementDateChanged();
    partial void OnCourseIdChanging(int value);
    partial void OnCourseIdChanged();
    #endregion
		
		public TStudent()
		{
			this._TCourse = default(EntityRef<TCourse>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StudentId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int StudentId
		{
			get
			{
				return this._StudentId;
			}
			set
			{
				if ((this._StudentId != value))
				{
					this.OnStudentIdChanging(value);
					this.SendPropertyChanging();
					this._StudentId = value;
					this.SendPropertyChanged("StudentId");
					this.OnStudentIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StudentName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string StudentName
		{
			get
			{
				return this._StudentName;
			}
			set
			{
				if ((this._StudentName != value))
				{
					this.OnStudentNameChanging(value);
					this.SendPropertyChanging();
					this._StudentName = value;
					this.SendPropertyChanged("StudentName");
					this.OnStudentNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gender", DbType="Char(1)")]
		public System.Nullable<char> Gender
		{
			get
			{
				return this._Gender;
			}
			set
			{
				if ((this._Gender != value))
				{
					this.OnGenderChanging(value);
					this.SendPropertyChanging();
					this._Gender = value;
					this.SendPropertyChanged("Gender");
					this.OnGenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ContactNumber", DbType="VarChar(10)")]
		public string ContactNumber
		{
			get
			{
				return this._ContactNumber;
			}
			set
			{
				if ((this._ContactNumber != value))
				{
					this.OnContactNumberChanging(value);
					this.SendPropertyChanging();
					this._ContactNumber = value;
					this.SendPropertyChanged("ContactNumber");
					this.OnContactNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmailAddress", DbType="VarChar(50)")]
		public string EmailAddress
		{
			get
			{
				return this._EmailAddress;
			}
			set
			{
				if ((this._EmailAddress != value))
				{
					this.OnEmailAddressChanging(value);
					this.SendPropertyChanging();
					this._EmailAddress = value;
					this.SendPropertyChanged("EmailAddress");
					this.OnEmailAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EnrollementDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> EnrollementDate
		{
			get
			{
				return this._EnrollementDate;
			}
			set
			{
				if ((this._EnrollementDate != value))
				{
					this.OnEnrollementDateChanging(value);
					this.SendPropertyChanging();
					this._EnrollementDate = value;
					this.SendPropertyChanged("EnrollementDate");
					this.OnEnrollementDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CourseId", DbType="Int NOT NULL")]
		public int CourseId
		{
			get
			{
				return this._CourseId;
			}
			set
			{
				if ((this._CourseId != value))
				{
					if (this._TCourse.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCourseIdChanging(value);
					this.SendPropertyChanging();
					this._CourseId = value;
					this.SendPropertyChanged("CourseId");
					this.OnCourseIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TCourse_TStudent", Storage="_TCourse", ThisKey="CourseId", OtherKey="CourseId", IsForeignKey=true)]
		public TCourse TCourse
		{
			get
			{
				return this._TCourse.Entity;
			}
			set
			{
				TCourse previousValue = this._TCourse.Entity;
				if (((previousValue != value) 
							|| (this._TCourse.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._TCourse.Entity = null;
						previousValue.TStudents.Remove(this);
					}
					this._TCourse.Entity = value;
					if ((value != null))
					{
						value.TStudents.Add(this);
						this._CourseId = value.CourseId;
					}
					else
					{
						this._CourseId = default(int);
					}
					this.SendPropertyChanged("TCourse");
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
