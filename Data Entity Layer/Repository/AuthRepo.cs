using Data_Entity_Layer.InterfaceRepo;
using Data_Entity_Layer.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Entity_Layer.Repository
{
    public class AuthRepo:IAuth
    {

        Api_Home_RentEntities db;

        public AuthRepo(Api_Home_RentEntities db)
        {
            this.db = db;   
        }

        public Token Authenticate(Login login)
        {

            Token t = null;
            var qw=db.Logins.FirstOrDefault(x=>x.Username==login.Username && x.Password==login.Password);
            if (qw!=null)
            {
                var g = Guid.NewGuid();
                var token = g.ToString();
                t = new Token()
                {
                    Login_id = login.Id,
                    Token1 = token,
                    Create_at = DateTime.Now

                };
                db.Tokens.Add(t);
                db.SaveChanges();
            }
            return t;
        }

        public bool isAuthenticated(string token)
        {
            var data = db.Tokens.FirstOrDefault(x => x.Token1.Equals(token) && x.Update_at == null);

            if (data != null)
                return true;

            return false; 
        }

        public bool Logout(string login)
        {
            var data = db.Tokens.FirstOrDefault(x => x.Token1.Equals(login));
            if(data != null)
            {
                data.Update_at = DateTime.Now;
                db.SaveChanges();
                return true;
            }
            return false;
        }

        
    }
}
