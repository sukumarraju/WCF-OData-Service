﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]

namespace ODataService.Data
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class pubsEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new pubsEntities object using the connection string found in the 'pubsEntities' section of the application configuration file.
        /// </summary>
        public pubsEntities() : base("name=pubsEntities", "pubsEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new pubsEntities object.
        /// </summary>
        public pubsEntities(string connectionString) : base(connectionString, "pubsEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new pubsEntities object.
        /// </summary>
        public pubsEntities(EntityConnection connection) : base(connection, "pubsEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<employee> employees
        {
            get
            {
                if ((_employees == null))
                {
                    _employees = base.CreateObjectSet<employee>("employees");
                }
                return _employees;
            }
        }
        private ObjectSet<employee> _employees;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the employees EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToemployees(employee employee)
        {
            base.AddObject("employees", employee);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="pubsModel", Name="employee")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class employee : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new employee object.
        /// </summary>
        /// <param name="emp_id">Initial value of the emp_id property.</param>
        /// <param name="fname">Initial value of the fname property.</param>
        /// <param name="lname">Initial value of the lname property.</param>
        /// <param name="job_id">Initial value of the job_id property.</param>
        /// <param name="pub_id">Initial value of the pub_id property.</param>
        /// <param name="hire_date">Initial value of the hire_date property.</param>
        public static employee Createemployee(global::System.String emp_id, global::System.String fname, global::System.String lname, global::System.Int16 job_id, global::System.String pub_id, global::System.DateTime hire_date)
        {
            employee employee = new employee();
            employee.emp_id = emp_id;
            employee.fname = fname;
            employee.lname = lname;
            employee.job_id = job_id;
            employee.pub_id = pub_id;
            employee.hire_date = hire_date;
            return employee;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String emp_id
        {
            get
            {
                return _emp_id;
            }
            set
            {
                if (_emp_id != value)
                {
                    Onemp_idChanging(value);
                    ReportPropertyChanging("emp_id");
                    _emp_id = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("emp_id");
                    Onemp_idChanged();
                }
            }
        }
        private global::System.String _emp_id;
        partial void Onemp_idChanging(global::System.String value);
        partial void Onemp_idChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String fname
        {
            get
            {
                return _fname;
            }
            set
            {
                OnfnameChanging(value);
                ReportPropertyChanging("fname");
                _fname = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("fname");
                OnfnameChanged();
            }
        }
        private global::System.String _fname;
        partial void OnfnameChanging(global::System.String value);
        partial void OnfnameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String minit
        {
            get
            {
                return _minit;
            }
            set
            {
                OnminitChanging(value);
                ReportPropertyChanging("minit");
                _minit = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("minit");
                OnminitChanged();
            }
        }
        private global::System.String _minit;
        partial void OnminitChanging(global::System.String value);
        partial void OnminitChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String lname
        {
            get
            {
                return _lname;
            }
            set
            {
                OnlnameChanging(value);
                ReportPropertyChanging("lname");
                _lname = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("lname");
                OnlnameChanged();
            }
        }
        private global::System.String _lname;
        partial void OnlnameChanging(global::System.String value);
        partial void OnlnameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int16 job_id
        {
            get
            {
                return _job_id;
            }
            set
            {
                Onjob_idChanging(value);
                ReportPropertyChanging("job_id");
                _job_id = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("job_id");
                Onjob_idChanged();
            }
        }
        private global::System.Int16 _job_id;
        partial void Onjob_idChanging(global::System.Int16 value);
        partial void Onjob_idChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Byte> job_lvl
        {
            get
            {
                return _job_lvl;
            }
            set
            {
                Onjob_lvlChanging(value);
                ReportPropertyChanging("job_lvl");
                _job_lvl = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("job_lvl");
                Onjob_lvlChanged();
            }
        }
        private Nullable<global::System.Byte> _job_lvl;
        partial void Onjob_lvlChanging(Nullable<global::System.Byte> value);
        partial void Onjob_lvlChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String pub_id
        {
            get
            {
                return _pub_id;
            }
            set
            {
                Onpub_idChanging(value);
                ReportPropertyChanging("pub_id");
                _pub_id = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("pub_id");
                Onpub_idChanged();
            }
        }
        private global::System.String _pub_id;
        partial void Onpub_idChanging(global::System.String value);
        partial void Onpub_idChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime hire_date
        {
            get
            {
                return _hire_date;
            }
            set
            {
                Onhire_dateChanging(value);
                ReportPropertyChanging("hire_date");
                _hire_date = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("hire_date");
                Onhire_dateChanged();
            }
        }
        private global::System.DateTime _hire_date;
        partial void Onhire_dateChanging(global::System.DateTime value);
        partial void Onhire_dateChanged();

        #endregion
    
    }

    #endregion
    
}