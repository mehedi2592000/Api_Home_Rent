using Data_Entity_Layer.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Entity_Layer.Repository
{
    public class LoginRepo : IRepository<Login, int>
    {
        Api_Home_RentEntities db;

       public LoginRepo(Api_Home_RentEntities db)
        {
            this.db = db;
        }

        public void Add(Login e)
        {
            db.Logins.Add(e);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var d=db.Logins.FirstOrDefault(x=>x.Id==id);
            db.Logins.Remove(d);
            db.SaveChanges();
        }

        public void Edit(Login e)
        {
            var d = db.Logins.FirstOrDefault(x => x.Id == e.Id);
            db.Entry(d).CurrentValues.SetValues(e);
            db.SaveChanges();

        }

        public Login Get(int id)
        {
            return db.Logins.FirstOrDefault(x => x.Id == id);
        }

        public List<Login> GetAll()
        {
            return db.Logins.ToList();
        }
    }
}
