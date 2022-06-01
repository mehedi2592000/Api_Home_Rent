using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Entity_Layer.All_Model
{
    public class BillModel
    {
        public int Id { get; set; }
        public string Month { get; set; }
        public Nullable<int> Home_rent { get; set; }
        public Nullable<int> Water_bill { get; set; }
        public Nullable<int> Dirty_bill { get; set; }
        public Nullable<int> Service_Charge { get; set; }
        public Nullable<int> Gas_bill { get; set; }
        public Nullable<int> Other_bill { get; set; }
        public Nullable<int> Prevous_bill { get; set; }
        public Nullable<int> Total_bill { get; set; }
        public Nullable<int> Give_money { get; set; }
        public Nullable<int> Rest_off_bill { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public int login_id { get; set; }

    }
}
