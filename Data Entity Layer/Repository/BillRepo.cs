using Data_Entity_Layer.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Entity_Layer.Repository
{
    public class BillRepo : IRepository<Bill, int>
    {
        Api_Home_RentEntities db;

        public BillRepo(Api_Home_RentEntities db)
        {
            this.db = db;
        }

        public void Add(Bill e)
        {
            db.Bills.Add(e);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var d=db.Bills.FirstOrDefault(e=>e.Id==id);
            db.Bills.Remove(d);
            db.SaveChanges();
        }

        public void Edit(Bill e)
        {
            var d=db.Bills.FirstOrDefault(q=>q.Id==e.Id);
            db.Entry(d).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public Bill Get(int id)
        {
            return db.Bills.FirstOrDefault(q => q.Id == id);

        }

        public List<Bill> GetAll()
        {
            return db.Bills.ToList();
        }
    }
}
