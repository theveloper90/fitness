//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class User
    {
        public int PK_users_Id { get; set; }
        public string users_FirstName { get; set; }
        public string users_LastName { get; set; }
        public string users_PhoneNumber { get; set; }
        public string users_Address { get; set; }
        public string users_CreateUserTime { get; set; }
        public Nullable<byte> users_Status { get; set; }
        public string users_Description { get; set; }
    
        public virtual User_Auth User_Auth { get; set; }
        public virtual UsersInfoFitness UsersInfoFitness { get; set; }
    }
}
