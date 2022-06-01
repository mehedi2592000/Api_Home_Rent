using System;
using Data_Entity_Layer.model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Entity_Layer.Repository
{
    public class CostRepo : IRepository<Cost, int>
    {

        Api_Home_RentEntities db;
        public CostRepo(Api_Home_RentEntities db)
        {
            this.db = db;
        }

        public void Add(Cost e)
        {
            db.Costs.Add(e);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var d=db.Costs.FirstOrDefault(q => q.Id == id);
            db.Costs.Remove(d);
            db.SaveChanges();
            
        }

        public void Edit(Cost e)
        {
            var d = db.Costs.FirstOrDefault(q => q.Id == e.Id);
            db.Entry(d).CurrentValues.SetValues(d);
            db.SaveChanges();

        }

        public Cost Get(int id)
        {
            return db.Costs.FirstOrDefault(q => q.Id == id);

        }

        public List<Cost> GetAll()
        {
            return db.Costs.ToList();
        }
    }
}
