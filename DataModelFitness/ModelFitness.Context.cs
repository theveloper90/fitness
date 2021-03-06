﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataModelFitness
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class fitnessEntities : DbContext
    {
        public fitnessEntities(string ConnectionString)
            : base(ConnectionString)
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<system_Component> system_Component { get; set; }
        public virtual DbSet<User_Auth> User_Auth { get; set; }
        public virtual DbSet<User_Role_Access> User_Role_Access { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UsersInfoFitness> UsersInfoFitnesses { get; set; }
        public virtual DbSet<VW_members> VW_members { get; set; }
        public virtual DbSet<vw_AuthUsers> vw_AuthUsers { get; set; }
    
        public virtual int addMember(string fName, string lName, string phone, string address, string createDate, Nullable<byte> status, string description)
        {
            var fNameParameter = fName != null ?
                new ObjectParameter("FName", fName) :
                new ObjectParameter("FName", typeof(string));
    
            var lNameParameter = lName != null ?
                new ObjectParameter("LName", lName) :
                new ObjectParameter("LName", typeof(string));
    
            var phoneParameter = phone != null ?
                new ObjectParameter("Phone", phone) :
                new ObjectParameter("Phone", typeof(string));
    
            var addressParameter = address != null ?
                new ObjectParameter("Address", address) :
                new ObjectParameter("Address", typeof(string));
    
            var createDateParameter = createDate != null ?
                new ObjectParameter("CreateDate", createDate) :
                new ObjectParameter("CreateDate", typeof(string));
    
            var statusParameter = status.HasValue ?
                new ObjectParameter("Status", status) :
                new ObjectParameter("Status", typeof(byte));
    
            var descriptionParameter = description != null ?
                new ObjectParameter("Description", description) :
                new ObjectParameter("Description", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("addMember", fNameParameter, lNameParameter, phoneParameter, addressParameter, createDateParameter, statusParameter, descriptionParameter);
        }
    
        public virtual int AddmemberInfo(Nullable<int> id, Nullable<double> height, Nullable<double> weight, Nullable<double> waistMeasure, string startDate, string endDate, string birthday, Nullable<int> age, Nullable<decimal> monthlyAmount, Nullable<double> bMI, Nullable<double> bMR, string createDate, Nullable<int> exerciesLevel, string exerciesLevelStr)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var heightParameter = height.HasValue ?
                new ObjectParameter("Height", height) :
                new ObjectParameter("Height", typeof(double));
    
            var weightParameter = weight.HasValue ?
                new ObjectParameter("Weight", weight) :
                new ObjectParameter("Weight", typeof(double));
    
            var waistMeasureParameter = waistMeasure.HasValue ?
                new ObjectParameter("WaistMeasure", waistMeasure) :
                new ObjectParameter("WaistMeasure", typeof(double));
    
            var startDateParameter = startDate != null ?
                new ObjectParameter("StartDate", startDate) :
                new ObjectParameter("StartDate", typeof(string));
    
            var endDateParameter = endDate != null ?
                new ObjectParameter("EndDate", endDate) :
                new ObjectParameter("EndDate", typeof(string));
    
            var birthdayParameter = birthday != null ?
                new ObjectParameter("Birthday", birthday) :
                new ObjectParameter("Birthday", typeof(string));
    
            var ageParameter = age.HasValue ?
                new ObjectParameter("Age", age) :
                new ObjectParameter("Age", typeof(int));
    
            var monthlyAmountParameter = monthlyAmount.HasValue ?
                new ObjectParameter("MonthlyAmount", monthlyAmount) :
                new ObjectParameter("MonthlyAmount", typeof(decimal));
    
            var bMIParameter = bMI.HasValue ?
                new ObjectParameter("BMI", bMI) :
                new ObjectParameter("BMI", typeof(double));
    
            var bMRParameter = bMR.HasValue ?
                new ObjectParameter("BMR", bMR) :
                new ObjectParameter("BMR", typeof(double));
    
            var createDateParameter = createDate != null ?
                new ObjectParameter("CreateDate", createDate) :
                new ObjectParameter("CreateDate", typeof(string));
    
            var exerciesLevelParameter = exerciesLevel.HasValue ?
                new ObjectParameter("exerciesLevel", exerciesLevel) :
                new ObjectParameter("exerciesLevel", typeof(int));
    
            var exerciesLevelStrParameter = exerciesLevelStr != null ?
                new ObjectParameter("exerciesLevelStr", exerciesLevelStr) :
                new ObjectParameter("exerciesLevelStr", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddmemberInfo", idParameter, heightParameter, weightParameter, waistMeasureParameter, startDateParameter, endDateParameter, birthdayParameter, ageParameter, monthlyAmountParameter, bMIParameter, bMRParameter, createDateParameter, exerciesLevelParameter, exerciesLevelStrParameter);
        }
    
        public virtual int DeleteFromMemberInfo(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteFromMemberInfo", idParameter);
        }
    
        public virtual int DeleteFromUsers(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteFromUsers", idParameter);
        }
    
        public virtual int updateMember(Nullable<int> id, string fName, string lName, string phone, string address, Nullable<byte> status, string description)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var fNameParameter = fName != null ?
                new ObjectParameter("FName", fName) :
                new ObjectParameter("FName", typeof(string));
    
            var lNameParameter = lName != null ?
                new ObjectParameter("LName", lName) :
                new ObjectParameter("LName", typeof(string));
    
            var phoneParameter = phone != null ?
                new ObjectParameter("Phone", phone) :
                new ObjectParameter("Phone", typeof(string));
    
            var addressParameter = address != null ?
                new ObjectParameter("Address", address) :
                new ObjectParameter("Address", typeof(string));
    
            var statusParameter = status.HasValue ?
                new ObjectParameter("Status", status) :
                new ObjectParameter("Status", typeof(byte));
    
            var descriptionParameter = description != null ?
                new ObjectParameter("Description", description) :
                new ObjectParameter("Description", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("updateMember", idParameter, fNameParameter, lNameParameter, phoneParameter, addressParameter, statusParameter, descriptionParameter);
        }
    
        public virtual int updateMemberInfo(Nullable<int> id, Nullable<double> height, Nullable<double> weight, Nullable<double> waistMeasure, string startDate, string endDate, string birthday, Nullable<int> age, Nullable<decimal> monthlyAmount, Nullable<double> bMI, Nullable<double> bMR, Nullable<int> exerciesLevel, string exerciesLevelStr)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var heightParameter = height.HasValue ?
                new ObjectParameter("Height", height) :
                new ObjectParameter("Height", typeof(double));
    
            var weightParameter = weight.HasValue ?
                new ObjectParameter("Weight", weight) :
                new ObjectParameter("Weight", typeof(double));
    
            var waistMeasureParameter = waistMeasure.HasValue ?
                new ObjectParameter("WaistMeasure", waistMeasure) :
                new ObjectParameter("WaistMeasure", typeof(double));
    
            var startDateParameter = startDate != null ?
                new ObjectParameter("StartDate", startDate) :
                new ObjectParameter("StartDate", typeof(string));
    
            var endDateParameter = endDate != null ?
                new ObjectParameter("EndDate", endDate) :
                new ObjectParameter("EndDate", typeof(string));
    
            var birthdayParameter = birthday != null ?
                new ObjectParameter("Birthday", birthday) :
                new ObjectParameter("Birthday", typeof(string));
    
            var ageParameter = age.HasValue ?
                new ObjectParameter("Age", age) :
                new ObjectParameter("Age", typeof(int));
    
            var monthlyAmountParameter = monthlyAmount.HasValue ?
                new ObjectParameter("MonthlyAmount", monthlyAmount) :
                new ObjectParameter("MonthlyAmount", typeof(decimal));
    
            var bMIParameter = bMI.HasValue ?
                new ObjectParameter("BMI", bMI) :
                new ObjectParameter("BMI", typeof(double));
    
            var bMRParameter = bMR.HasValue ?
                new ObjectParameter("BMR", bMR) :
                new ObjectParameter("BMR", typeof(double));
    
            var exerciesLevelParameter = exerciesLevel.HasValue ?
                new ObjectParameter("exerciesLevel", exerciesLevel) :
                new ObjectParameter("exerciesLevel", typeof(int));
    
            var exerciesLevelStrParameter = exerciesLevelStr != null ?
                new ObjectParameter("exerciesLevelStr", exerciesLevelStr) :
                new ObjectParameter("exerciesLevelStr", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("updateMemberInfo", idParameter, heightParameter, weightParameter, waistMeasureParameter, startDateParameter, endDateParameter, birthdayParameter, ageParameter, monthlyAmountParameter, bMIParameter, bMRParameter, exerciesLevelParameter, exerciesLevelStrParameter);
        }
    
        public virtual int disableUserMember(Nullable<int> id, Nullable<byte> status)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var statusParameter = status.HasValue ?
                new ObjectParameter("Status", status) :
                new ObjectParameter("Status", typeof(byte));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("disableUserMember", idParameter, statusParameter);
        }
    }
}
