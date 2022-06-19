using Data_Entity_Layer.InterfaceRepo;
using Data_Entity_Layer.model;
using Data_Entity_Layer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Entity_Layer.AccessFactory
{
    public  class DataAccessFactory
    {
        static Api_Home_RentEntities db;

        static DataAccessFactory()
        {
            db= new Api_Home_RentEntities();    
        }

        public static IRepository<Bill,int>BillDataAccessFactory()
        {
           return new BillRepo(db);
        }

        public static IRepository<Cost, int> CostDataAccessFactory()
        {
            return new CostRepo(db);
        }

        public static IRepository<Login, int> LoginDataAccessFactory()
        {
            return new LoginRepo(db);
        }

        public static IRepository<Money, int> MoneyDataAccessFactory()
        {
            return new MoneyRepo(db);
        }
        public static IRepository<Tanent, int> TanentDataAccessFactory()
        {
            return new TanentRepo(db);
        }
        public static IRepository<user, int> userDataAccessFactory()
        {
            return new userRepo(db);
        }

        public static IAuth AuthDataAccessFactory()
        {
            return new AuthRepo(db);
        }
    }
}
