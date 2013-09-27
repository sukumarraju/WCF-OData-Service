//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1008
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Original file name:
// Generation date: 10/09/2013 16:26:19
namespace ODataService.PubServiceReference
{
    
    /// <summary>
    /// There are no comments for pubsEntities in the schema.
    /// </summary>
    public partial class pubsEntities : global::System.Data.Services.Client.DataServiceContext
    {
        /// <summary>
        /// Initialize a new pubsEntities object.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public pubsEntities(global::System.Uri serviceRoot) : 
                base(serviceRoot)
        {
            this.ResolveName = new global::System.Func<global::System.Type, string>(this.ResolveNameFromType);
            this.ResolveType = new global::System.Func<string, global::System.Type>(this.ResolveTypeFromName);
            this.OnContextCreated();
        }
        partial void OnContextCreated();
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected global::System.Type ResolveTypeFromName(string typeName)
        {
            if (typeName.StartsWith("pubsModel", global::System.StringComparison.Ordinal))
            {
                return this.GetType().Assembly.GetType(string.Concat("ODataService.PubServiceReference", typeName.Substring(9)), false);
            }
            return null;
        }
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected string ResolveNameFromType(global::System.Type clientType)
        {
            if (clientType.Namespace.Equals("ODataService.PubServiceReference", global::System.StringComparison.Ordinal))
            {
                return string.Concat("pubsModel.", clientType.Name);
            }
            return null;
        }
        /// <summary>
        /// There are no comments for employees in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<employee> employees
        {
            get
            {
                if ((this._employees == null))
                {
                    this._employees = base.CreateQuery<employee>("employees");
                }
                return this._employees;
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<employee> _employees;
        /// <summary>
        /// There are no comments for employees in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToemployees(employee employee)
        {
            base.AddObject("employees", employee);
        }
    }
    /// <summary>
    /// There are no comments for pubsModel.employee in the schema.
    /// </summary>
    /// <KeyProperties>
    /// emp_id
    /// </KeyProperties>
    [global::System.Data.Services.Common.DataServiceKeyAttribute("emp_id")]
    public partial class employee
    {
        /// <summary>
        /// Create a new employee object.
        /// </summary>
        /// <param name="emp_id">Initial value of emp_id.</param>
        /// <param name="fname">Initial value of fname.</param>
        /// <param name="lname">Initial value of lname.</param>
        /// <param name="job_id">Initial value of job_id.</param>
        /// <param name="pub_id">Initial value of pub_id.</param>
        /// <param name="hire_date">Initial value of hire_date.</param>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static employee Createemployee(string emp_id, string fname, string lname, short job_id, string pub_id, global::System.DateTime hire_date)
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
        /// <summary>
        /// There are no comments for Property emp_id in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string emp_id
        {
            get
            {
                return this._emp_id;
            }
            set
            {
                this.Onemp_idChanging(value);
                this._emp_id = value;
                this.Onemp_idChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _emp_id;
        partial void Onemp_idChanging(string value);
        partial void Onemp_idChanged();
        /// <summary>
        /// There are no comments for Property fname in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string fname
        {
            get
            {
                return this._fname;
            }
            set
            {
                this.OnfnameChanging(value);
                this._fname = value;
                this.OnfnameChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _fname;
        partial void OnfnameChanging(string value);
        partial void OnfnameChanged();
        /// <summary>
        /// There are no comments for Property minit in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string minit
        {
            get
            {
                return this._minit;
            }
            set
            {
                this.OnminitChanging(value);
                this._minit = value;
                this.OnminitChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _minit;
        partial void OnminitChanging(string value);
        partial void OnminitChanged();
        /// <summary>
        /// There are no comments for Property lname in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string lname
        {
            get
            {
                return this._lname;
            }
            set
            {
                this.OnlnameChanging(value);
                this._lname = value;
                this.OnlnameChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _lname;
        partial void OnlnameChanging(string value);
        partial void OnlnameChanged();
        /// <summary>
        /// There are no comments for Property job_id in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public short job_id
        {
            get
            {
                return this._job_id;
            }
            set
            {
                this.Onjob_idChanging(value);
                this._job_id = value;
                this.Onjob_idChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private short _job_id;
        partial void Onjob_idChanging(short value);
        partial void Onjob_idChanged();
        /// <summary>
        /// There are no comments for Property job_lvl in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<byte> job_lvl
        {
            get
            {
                return this._job_lvl;
            }
            set
            {
                this.Onjob_lvlChanging(value);
                this._job_lvl = value;
                this.Onjob_lvlChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<byte> _job_lvl;
        partial void Onjob_lvlChanging(global::System.Nullable<byte> value);
        partial void Onjob_lvlChanged();
        /// <summary>
        /// There are no comments for Property pub_id in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string pub_id
        {
            get
            {
                return this._pub_id;
            }
            set
            {
                this.Onpub_idChanging(value);
                this._pub_id = value;
                this.Onpub_idChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _pub_id;
        partial void Onpub_idChanging(string value);
        partial void Onpub_idChanged();
        /// <summary>
        /// There are no comments for Property hire_date in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.DateTime hire_date
        {
            get
            {
                return this._hire_date;
            }
            set
            {
                this.Onhire_dateChanging(value);
                this._hire_date = value;
                this.Onhire_dateChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.DateTime _hire_date;
        partial void Onhire_dateChanging(global::System.DateTime value);
        partial void Onhire_dateChanged();
    }
}
