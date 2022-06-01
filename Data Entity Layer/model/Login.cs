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
    
    public partial class Login
    {
        public Login()
        {
            this.Bills = new HashSet<Bill>();
            this.Tanents = new HashSet<Tanent>();
            this.Tokens = new HashSet<Token>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public long Phone { get; set; }
        public Nullable<long> Nid_number { get; set; }
        public string Father_name { get; set; }
        public string Mother_name { get; set; }
        public string Status { get; set; }
        public string House_no { get; set; }
        public string Road_no { get; set; }
        public string Sector { get; set; }
        public string Present_add { get; set; }
        public string Fixed_add { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Profession { get; set; }
        public string Picture { get; set; }
        public string Nid_picture { get; set; }
        public string Month { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<int> Owner_id { get; set; }
    
        public virtual ICollection<Bill> Bills { get; set; }
        public virtual ICollection<Tanent> Tanents { get; set; }
        public virtual ICollection<Token> Tokens { get; set; }
    }
}