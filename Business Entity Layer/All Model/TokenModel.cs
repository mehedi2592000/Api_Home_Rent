using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Entity_Layer.All_Model
{
    public  class TokenModel
    {
        public int Id { get; set; }
        public int Login_id { get; set; }
        public string Token1 { get; set; }
        public System.DateTime Create_at { get; set; }
        public System.DateTime Update_at { get; set; }

    }
}
