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
    
    public partial class Tanent
    {
        public int Id { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public int Login_id { get; set; }
        public Nullable<int> Owner_id { get; set; }
    
        public virtual Login Login { get; set; }
    }
}
