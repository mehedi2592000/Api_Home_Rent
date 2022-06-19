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
    [EnableCors("*", "*", "*")]
    public class userController : ApiController
    {
        [Route("api/user/userList")]
        [HttpGet]
        public HttpResponseMessage Getuser()
        {
            var data = userService.GetAll();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/user/userLogin")]
        [HttpPost]
        public HttpResponseMessage Adduser(userModel e)
        {
            var data = userService.Adduser(e);
            return Request.CreateResponse(data ? HttpStatusCode.OK : HttpStatusCode.BadRequest);

        }

    }
}
