using AutoMapper;
using Business_Entity_Layer.All_Model;
using Data_Entity_Layer.AccessFactory;
using Data_Entity_Layer.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer.Service
{
    public class LoginService
    {
        public static List<LoginModel> GetAll()
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<Login, LoginModel>())).Map<List<LoginModel>>(DataAccessFactory.LoginDataAccessFactory().GetAll());
            return data;
        }

        public static  LoginModel GetId(int id)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<Login, LoginModel>())).Map<LoginModel>(DataAccessFactory.LoginDataAccessFactory().Get(id));
            return data;
        }

        public static bool AddLogin(LoginModel e)
        {
            e.Date = DateTime.Now;
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<LoginModel, Login>())).Map<Login>(e);
            try
            {
                DataAccessFactory.LoginDataAccessFactory().Add(data);
                return true;
            }
            catch 
            {
                return false;
            }
        }

        public static bool EditLogic(LoginModel e)
        {
            
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<LoginModel, Login>())).Map<Login>(e);
            try
            {
                DataAccessFactory.LoginDataAccessFactory().Edit(data);
                return true;
            }
            catch
            {
                return false;
            }
        }


        public static bool AcceptedTanentEditLogic(LoginModel e,int Id)
        {
            e.Owner_id = Id;
            var data=new Mapper(new MapperConfiguration(cfg=>cfg.CreateMap<LoginModel,Login>())).Map<Login>(e);
            try
            {
                DataAccessFactory.LoginDataAccessFactory().Edit(data);
                return true;
            }
            catch
            {
                return false;
            }
        } 

        public static bool DeleteLogic(int id)
        {
            try
            {
                DataAccessFactory.LoginDataAccessFactory().Delete(id);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool OwnerAddTanent(LoginModel e,int Id)
        {

            e.Date=DateTime.Now;
            e.Owner_id = Id;
            var dat = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<LoginModel, Login>())).Map<Login>(e);
            try
            {
                DataAccessFactory.LoginDataAccessFactory().Add(dat);
                return true;
            }
            catch
            {
                return false;
            }

        }

        public static bool OwnerAddCaretaker(LoginModel e,int Id)
        {
            e.Date = DateTime.Now;
            e.Owner_id = Id;
            var dat = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<LoginModel, Login>())).Map<Login>(e);
            try
            {
                DataAccessFactory.LoginDataAccessFactory().Add(dat);
                return true;
            }
            catch
            {
                return false;
            }

        }

        public static List<LoginModel> OwnerTanetAllList(int Id)
        {
            var dat = DataAccessFactory.LoginDataAccessFactory().GetAll().Where(x => x.Owner_id == Id && x.Status.Equals("Tanent"));
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<Login, LoginModel>())).Map<List<LoginModel>>(dat);
            return data;
        }
        public static List<LoginModel> OwnerCaretakerAllList(int Id)
        {
            var dat = DataAccessFactory.LoginDataAccessFactory().GetAll().Where(x => x.Owner_id == Id && x.Status.Equals("Caretaker"));
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<Login, LoginModel>())).Map<List<LoginModel>>(dat);
            return data;
        }


        public static bool AccaptedTanentLogic(LoginModel e,int Idd)
        {
            TanentModel tn = new TanentModel();
            tn.Login_id = e.Id;
            tn.Date = new DateTime();
            tn.Owner_id = e.Owner_id;
            var dat = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<TanentModel, Tanent>())).Map<Tanent>(e);
            DataAccessFactory.TanentDataAccessFactory().Add(dat);


            e.Owner_id = Idd;

            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<LoginModel, Login>())).Map<Login>(e);

            try
            {
                DataAccessFactory.LoginDataAccessFactory().Edit(data);
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
