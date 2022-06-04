using Business_Logic_Layer.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace API_House_Rent.Auth
{
    public class CustomerAuth:AuthorizationFilterAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            var authHeader = actionContext.Request.Headers.Authorization;
            if (authHeader == null)
            {
                actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.NotFound, "Not found data");
            }
            else
            {
                string token=authHeader.ToString();
                var rs = AuthService.CheckValidityToken(token);
                if(!rs)
                {
                    actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized, "sory found data");
                }
            }

            base.OnAuthorization(actionContext);
        }
    }
}