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
    public class BillController : ApiController
    {
        [Route("api/Bill/AllList")]
        [HttpGet]
        public HttpResponseMessage GetBillList()
        {
            return Request.CreateResponse(HttpStatusCode.OK,BillService.GetBill());
        }

        [Route("api/Bill/ListId/{Id}")]
        [HttpGet]
        public HttpResponseMessage GetBillId(int Id)
        {
            return Request.CreateResponse(HttpStatusCode.OK,BillService.GetBillId(Id));
        }


        [Route("api/Bill/AddBillbyId/{Id}")]
        [HttpPost]
        public HttpResponseMessage AddBill(BillModel e,int Id)
        {
            
            var data = BillService.AddBill(e,Id);
                return Request.CreateResponse(data?HttpStatusCode.OK:HttpStatusCode.BadRequest);
        }

        [Route("api/Bill/EditBill")]
        [HttpPost]
        public HttpResponseMessage EditBill(BillModel e)
        {
            var data = BillService.EditBill(e);
            return Request.CreateResponse(data ? HttpStatusCode.OK : HttpStatusCode.BadRequest);
        }


        [Route("api/Bill/DeleteBill/{Id}")]
        [HttpGet]
        public HttpResponseMessage DeleteBill(int Id)
        {
            var data = BillService.DeleteBill(Id);
            return Request.CreateResponse(data ? HttpStatusCode.OK : HttpStatusCode.BadRequest);
        }

        [Route("api/Bill/OwnerTanetAllList/{Id}")]
        [HttpGet]
        public HttpResponseMessage GetBillList(int Id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, BillService.OwnerTanentBill(Id));
        }
    }
}
