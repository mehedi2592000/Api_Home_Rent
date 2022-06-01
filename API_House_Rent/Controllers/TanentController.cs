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
    public class TanentController : ApiController
    {
        [Route("api/Tenant/GetAll")]
        [HttpGet]
        public HttpResponseMessage GetTanent()
        {
            return Request.CreateResponse(HttpStatusCode.OK,TanentService.GetAll());
        }

        [Route("api/Tanent/GetIdTanent")]
        [HttpGet]
        public HttpResponseMessage GetIdTanent(int Id)
        {
            return Request.CreateResponse(HttpStatusCode.OK,TanentService.GetId(Id));
        }

        [Route("api/Tanent/Addtanent")]
        [HttpPost]
        public HttpResponseMessage AddTanent(TanentModel e)
        {
            var data = TanentService.AddTanent(e);
            return Request.CreateResponse(data ? HttpStatusCode.OK : HttpStatusCode.BadRequest);
        }

        [Route("api/Tanent/Edittanent")]
        [HttpPost]
        public HttpResponseMessage EditTanent(TanentModel e)
        {
            var data = TanentService.EditTanent(e);
            return Request.CreateResponse(data ? HttpStatusCode.OK : HttpStatusCode.BadRequest);
        }

        [Route("api/Tanent/Deletetanent/{Id}")]
        [HttpGet]
        public HttpResponseMessage DeleteTanent(int Id)
        {
            var data = TanentService.DeleteTanent(Id);
            return Request.CreateResponse(data ? HttpStatusCode.OK : HttpStatusCode.BadRequest);
        }






    }
}
