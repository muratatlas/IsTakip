//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Account
    {
        public int Ac_Id { get; set; }
        public string Ac_Name { get; set; }
        public string Ac_Password { get; set; }
        public Nullable<System.DateTime> Ac_Create_date { get; set; }
        public Nullable<System.DateTime> Ac_Lastup_date { get; set; }
        public Nullable<bool> Ac_Online { get; set; }
        public Nullable<int> Ac_Login_tipi { get; set; }
        public Nullable<bool> Ac_Aktif { get; set; }
    }
}