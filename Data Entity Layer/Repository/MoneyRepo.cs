using Data_Entity_Layer.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Entity_Layer.Repository
{
    public class MoneyRepo:IRepository<Money,int>
    {
        Api_Home_RentEntities db;

        public MoneyRepo(Api_Home_RentEntities db)
        {
            this.db = db;
        }

        public void Add(Money e)
        {
            db.Moneys.Add(e);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var d = db.Moneys.FirstOrDefault(q => q.Id == id);
            db.Moneys.Remove(d);
            db.SaveChanges();
        }

        public void Edit(Money e)
        {
            var d = db.Moneys.FirstOrDefault(q => q.Id == e.Id);
            db.Entry(d).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public Money Get(int id)
        {
            return  db.Moneys.FirstOrDefault(q => q.Id == id);
        }

        public List<Money> GetAll()
        {
            return db.Moneys.ToList();

        }
    }
}
