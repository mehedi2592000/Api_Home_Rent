using Business_Entity_Layer.All_Model;
using Business_Logic_Layer.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace API_House_Rent.Controllers
{
    [EnableCors("*","*","*")]
    public class LoginController : ApiController
    {
        [Route("api/Login/LoginList")]
        [HttpGet]
        public HttpResponseMessage GetLogin()
        {
            var data = LoginService.GetAll();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/Login/LoginId/{Id}")]
        [HttpGet]
        public HttpResponseMessage GetIdLogin(int id)
        {
            var data = LoginService.GetId(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/Login/AddLogin")]
        [HttpPost]
        public HttpResponseMessage AddLogin(LoginModel e)
        {
            var data=LoginService.AddLogin(e);
            return Request.CreateResponse(data?HttpStatusCode.OK : HttpStatusCode.BadRequest);

        }
        [Route("api/Login/OwnerAddTanent/{Id}")]
        [HttpPost]
        public HttpResponseMessage OwnerAddTanent(LoginModel e,int Id)
        {
            var data = LoginService.OwnerAddTanent(e,Id);
            return Request.CreateResponse(data ? HttpStatusCode.OK : HttpStatusCode.BadRequest);

        }
        [Route("api/Login/OwnerAddCaretaker/{Id}")]
        [HttpPost]
        public HttpResponseMessage OwnerAddCaretaker(LoginModel e, int Id)
        {
            var data = LoginService.OwnerAddCaretaker(e, Id);
            return Request.CreateResponse(data ? HttpStatusCode.OK : HttpStatusCode.BadRequest);

        }

        [Route("api/Login/EditLogin")]
        [HttpPost]
        public HttpResponseMessage EditLogin(LoginModel e)
        {
            var data=LoginService.EditLogic(e);

            return Request.CreateResponse(data?HttpStatusCode.OK: HttpStatusCode.BadRequest);
        }

        [Route("api/Login/AcceptedTanentEdit/{Id}")]
        [HttpPost]
        public HttpResponseMessage EditLogin(LoginModel e,int Id)
        {
            var data = LoginService.AcceptedTanentEditLogic(e,Id);

            return Request.CreateResponse(data ? HttpStatusCode.OK : HttpStatusCode.BadRequest);
        }

        [Route("api/Login/DeleteLOgin/{Id}")]
        [HttpGet]
        public HttpResponseMessage DeleteLogin(int Id)
        {
            var data= LoginService.DeleteLogic(Id);
            return Request.CreateResponse(data?HttpStatusCode.OK:HttpStatusCode.BadRequest);
        }

        [Route("api/Login/OwnerTanetAllList/{Id}")]
        [HttpGet]
        public HttpResponseMessage OwnerTanetAllList(int Id)
        {
            var data = LoginService.OwnerTanetAllList(Id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/Login/OwnerCaretakerAllList/{Id}")]
        [HttpGet]
        public HttpResponseMessage OwnerCaretakerAllList(int Id)
        {
            var data = LoginService.OwnerTanetAllList(Id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}
