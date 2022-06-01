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
    public  class TanentService
    {

        public static List<TanentModel>GetAll()
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<Tanent, TanentModel>())).Map<List<TanentModel>>(DataAccessFactory.TanentDataAccessFactory().GetAll());
            return data;
        }

        public static TanentModel GetId(int id)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<Tanent, TanentModel>())).Map<TanentModel>(DataAccessFactory.TanentDataAccessFactory().Get(id));
            return data;
        }

        public static bool AddTanent(TanentModel e)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<TanentModel, Tanent>())).Map<Tanent>(e);

            try
            {
                DataAccessFactory.TanentDataAccessFactory().Add(data);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool EditTanent(TanentModel e)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<TanentModel, Tanent>())).Map<Tanent>(e);

            try
            {
                DataAccessFactory.TanentDataAccessFactory().Edit(data);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool DeleteTanent(int id)
        {
            try
            {
                DataAccessFactory.TanentDataAccessFactory().Delete(id);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
