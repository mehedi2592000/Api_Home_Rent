using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Entity_Layer.All_Model
{
    public class LoginModel
    {
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

    }
}
