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

        public static bool AddCost(CostModel c,int Id)
        {
            c.Month = DateTime.Now.ToString("MM");
            c.Date = DateTime.Now;
            c.Owner_id = Id;
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
        public static List<CostModel> SumOfamountById(int Id)
        {
            var data = from fm in DataAccessFactory.CostDataAccessFactory().GetAll()
                       group fm by fm.Month into g
                       select new CostModel
                       {
                           Month = g.First().Month,
                           Amount = g.Where(x => x.Owner_id == Id).Sum(p => p.Amount),
                       };


            return data.ToList();
        }
    }
}
