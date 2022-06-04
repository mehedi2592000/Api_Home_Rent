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
    public class AuthService
    {
        public static TokenModel Auth(LoginModel log )
        {
             var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<LoginModel, Login>())).Map<Login>(log);
            var dat = DataAccessFactory.AuthDataAccessFactory().Authenticate(data);
            var tokenmodel=new Mapper(new MapperConfiguration(cfg=>cfg.CreateMap<Token,TokenModel>())).Map<TokenModel>(dat);
            return tokenmodel;

        }

        public static bool CheckValidityToken(string tok)
        {
            var rs = DataAccessFactory.AuthDataAccessFactory().isAuthenticated(tok);
            return rs;
        }

        public static bool Logout(string token)
        {
            DataAccessFactory.AuthDataAccessFactory().Logout(token);
            return true;
        }
    }
}
