//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data_Entity_Layer.model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Token
    {
        public int Id { get; set; }
        public int Login_id { get; set; }
        public string Token1 { get; set; }
        public System.DateTime Create_at { get; set; }
        public System.DateTime Update_at { get; set; }
    
        public virtual Login Login { get; set; }
    }
}