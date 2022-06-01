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
    public class CostService
    {
        public static List<CostModel>GetCost()
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<Cost, CostModel>())).Map<List<CostModel>>(DataAccessFactory.CostDataAccessFactory().GetAll());
            return data;
        }

        public static CostModel GetIdCost(int id)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<Cost, CostModel>())).Map<CostModel>(DataAccessFactory.CostDataAccessFactory().Get(id));
            return data;
        }

        public static bool AddCost(CostModel c)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<CostModel, Cost>())).Map<Cost>(c);

            try
            {
                DataAccessFactory.CostDataAccessFactory().Add(data);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool EditCost(CostModel c)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<CostModel, Cost>())).Map<Cost>(c);

            try
            {
                DataAccessFactory.CostDataAccessFactory().Edit(data);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool DeletCost(int id)
        {
            try
            {
                DataAccessFactory.CostDataAccessFactory().Delete(id);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
