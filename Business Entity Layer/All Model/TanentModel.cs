using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Entity_Layer.All_Model
{
    public class TanentModel
    {
        public int Id { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public int Login_id { get; set; }
        public Nullable<int> Owner_id { get; set; }

    }
}
