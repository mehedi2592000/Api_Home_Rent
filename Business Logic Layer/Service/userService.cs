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
    public class userService
    {
        public static List<userModel> GetAll()
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<user, userModel>())).Map<List<userModel>>(DataAccessFactory.userDataAccessFactory().GetAll());
            return data;
        }
        public static bool Adduser(userModel e)
        {
            
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<userModel, user>())).Map<user>(e);
            try
            {
                DataAccessFactory.userDataAccessFactory().Add(data);
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
