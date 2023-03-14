using DTOLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace DataProcessAPI.Controllers
{
    public class DataTableProcessController : ApiController
    {
        // post: DataTableProcess
        [System.Web.Http.Route("api/DataTableProcess/PostEmployeeMonthlyWages")]
        [System.Web.Http.HttpPost]
        public HttpResponseMessage PostEmployeeMonthlyWages(DataDTO dataDTO)
        {
            ReturnFormat returnFormat =  new BusinessLogic.BusinessLogic().CreateDataTable();

            
            return Request.CreateResponse(HttpStatusCode.OK, returnFormat);
        }
    }
}