﻿using AutoMapper;
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
    public class MoneyService
    {
        public static List<MoneyModel>GetAll()
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<Money, MoneyModel>())).Map<List<MoneyModel>>(DataAccessFactory.MoneyDataAccessFactory().GetAll());
            return data;
        }

        public static MoneyModel GetId(int id)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<Money, MoneyModel>())).Map<MoneyModel>(DataAccessFactory.MoneyDataAccessFactory().Get(id));
            return data;
        }

        public static bool AddMoney(MoneyModel e)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<MoneyModel, Money>())).Map<Money>(e);

            try
            {
                DataAccessFactory.MoneyDataAccessFactory().Add(data);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool EditMoney(MoneyModel e)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<MoneyModel, Money>())).Map<Money>(e);

            try
            {
                DataAccessFactory.MoneyDataAccessFactory().Edit(data);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool DeleteMoney(int id)
        {
            try
            {
                DataAccessFactory.MoneyDataAccessFactory().Delete(id);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
