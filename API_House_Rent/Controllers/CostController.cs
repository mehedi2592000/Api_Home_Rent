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
    public class CostController : ApiController
    {
        [Route("api/Cost/GetAll")]
        [HttpGet]
        public HttpResponseMessage GetAll()
        {
            return Request.CreateResponse(HttpStatusCode.OK,CostService.GetCost());
        }

        [Route("api/Cost/GetAllId/{Id}")]
        [HttpGet]
        public HttpResponseMessage GetAllId(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK,CostService.GetIdCost(id));
        }

        [Route("api/Cost/AddCost/{Id}")]
        [HttpPost]
        public HttpResponseMessage AddCost(CostModel c,int Id)
        {
            var data = CostService.AddCost(c,Id);

            return Request.CreateResponse(data?HttpStatusCode.OK:HttpStatusCode.BadRequest);

        }
        [Route("api/Cost/EditCost")]
        [HttpPost]
        public HttpResponseMessage EditCost(CostModel c)
        {
            var data = CostService.EditCost(c);

            return Request.CreateResponse(data ? HttpStatusCode.OK : HttpStatusCode.BadRequest);

        }

        [Route("api/Cost/DeleteCost/{Id}")]
        [HttpGet]
        public HttpResponseMessage DeleteCost(int Id)
        {
            var data = CostService.DeletCost(Id);

            return Request.CreateResponse(data ? HttpStatusCode.OK : HttpStatusCode.BadRequest);

        }

        [Route("api/Cost/SumOfamountById/{Id}")]
        [HttpGet]
        public HttpResponseMessage GetAll(int Id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, CostService.SumOfamountById(Id));
        }
    }
}
