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
    public class MoneyController : ApiController
    {
        [Route("api/Money/GetALl")]
        [HttpGet]
        public HttpResponseMessage GetMoney()
        {
            return Request.CreateResponse(HttpStatusCode.OK,MoneyService.GetAll());
        }

        [Route("api/Money/GetALlId/{Id}")]
        [HttpGet]
        public HttpResponseMessage GetMoneyId(int Id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, MoneyService.GetId(Id));
        }

        [Route("api/Money/AddMoney")]
        [HttpPost]
        public HttpResponseMessage AddMoney(MoneyModel m)
        {
            var data = MoneyService.AddMoney(m);
            return Request.CreateResponse(data ? HttpStatusCode.OK : HttpStatusCode.BadRequest);
        }

        [Route("api/Money/EditMoney")]
        [HttpPost]
        public HttpResponseMessage EditMoney(MoneyModel m)
        {
            var data = MoneyService.EditMoney(m);
            return Request.CreateResponse(data ? HttpStatusCode.OK : HttpStatusCode.BadRequest);
        }


        [Route("api/Money/DeleteMoney/{Id}")]
        [HttpGet]
        public HttpResponseMessage DeleteMoney(int Id)
        {
            var data = MoneyService.DeleteMoney(Id);
            return Request.CreateResponse(data ? HttpStatusCode.OK : HttpStatusCode.BadRequest);
        }

    }
}
