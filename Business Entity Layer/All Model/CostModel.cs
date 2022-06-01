using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Entity_Layer.All_Model
{
    public  class CostModel
    {
        public int Id { get; set; }
        public string Month { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string Reason { get; set; }
        public Nullable<long> Amount { get; set; }
        public int Owner_id { get; set; }
    }
}
