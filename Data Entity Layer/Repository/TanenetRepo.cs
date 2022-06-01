using Data_Entity_Layer.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Entity_Layer.Repository
{
    public class TanenetRepo:IRepository<Tanent,int>
    {
        Api_Home_RentEntities db;
        public TanenetRepo(Api_Home_RentEntities db)
        {
            this.db = db;
        }

        public List<Tanent> GetAll()
        {
            return db.Tanents.ToList();
        }

        public Tanent Get(int id)
        {
            return db.Tanents.FirstOrDefault(q=>q.Id == id);
        }

        public void Delete(int id)
        {
            var d=db.Tanents.FirstOrDefault(q=>q.Id==id);
            db.Tanents.Remove(d);
            db.SaveChanges();
        }

        public void Edit(Tanent e)
        {
            var d = db.Tanents.FirstOrDefault(q => q.Id == e.Id);
            db.Entry(d).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public void Add(Tanent e)
        {
            db.Tanents.Add(e);
            db.SaveChanges();

        }

        
    }
}
