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
    public class BillService
    {
        public static List<BillModel>GetBill()
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<Bill, BillModel>())).Map<List<BillModel>>(DataAccessFactory.BillDataAccessFactory().GetAll());
            return data;
        }

        public static BillModel GetBillId(int id)
        {
            var model = new Mapper(new MapperConfiguration(cfg=>cfg.CreateMap<Bill,BillModel>())).Map<BillModel>(DataAccessFactory.BillDataAccessFactory().Get(id));
            return model;
        }

        public static bool AddBill(BillModel e,int Id)
        {
            e.login_id = Id;
            
            e.Total_bill = e.Home_rent + e.Water_bill + e.Dirty_bill + e.Service_Charge + e.Gas_bill + e.Other_bill + e.Prevous_bill;
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<BillModel, Bill>())).Map<Bill>(e);

            try
            {
                DataAccessFactory.BillDataAccessFactory().Add(data);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool EditBill(BillModel e)
        {
            var data=new Mapper(new MapperConfiguration(cfg=>cfg.CreateMap<BillModel,Bill>())).Map<Bill>(e);

            try
            {
                DataAccessFactory.BillDataAccessFactory().Edit(data);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool DeleteBill(int id)
        {
            try
            {
                DataAccessFactory.BillDataAccessFactory().Delete(id);
                return true;
            }
            catch { return false; }
        }

        public static List<BillModel> OwnerTanentBill(int Id)
        {
            var dat = DataAccessFactory.BillDataAccessFactory().GetAll().Where(x => x.login_id == Id);
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<Bill, BillModel>())).Map<List<BillModel>>(dat);
            return data;
        }

    }
}
