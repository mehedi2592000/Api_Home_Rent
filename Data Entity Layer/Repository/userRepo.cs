using Data_Entity_Layer.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Entity_Layer.Repository
{
    public class userRepo : IRepository<user, int>
    {

        Api_Home_RentEntities db;

        public userRepo(Api_Home_RentEntities db)
        {
            this.db = db;
        }

        public void Add(user e)
        {
            db.users.Add(e);
            db.SaveChanges();   
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(user e)
        {
            throw new NotImplementedException();
        }

        public user Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<user> GetAll()
        {
            
            return db.users.ToList();
        }
    }

}
