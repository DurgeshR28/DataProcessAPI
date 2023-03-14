
using DTOLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;


namespace DataTransferAPI.Controllers
{
    public class EmployeeController : ApiController
    {

        // post: Employee
        [System.Web.Http.Route("api/Employee/PostEmployeeDetailsByGuid")]
        [System.Web.Http.HttpPost]
        public HttpResponseMessage PostEmployeeDetailsByGuid(DataDTO dataDTO)
        {


            ReturnFormat returnFormat = new BusinessLogic.BusinessLogic().GetEmployeeByGuid(dataDTO);


            return Request.CreateResponse(HttpStatusCode.OK, returnFormat);
        }

        [System.Web.Http.Route("api/Employee/PostEmployeeAbsencesForLeaveByGuid")]
        [System.Web.Http.HttpPost]
        public HttpResponseMessage PostEmployeeAbsencesForLeaveByGuid(DataDTO dataDTO)
        {

           
            ReturnFormat returnFormat = new BusinessLogic.BusinessLogic().GetEmployeeAbsencesForLeaveByGuid(dataDTO);


            return Request.CreateResponse(HttpStatusCode.OK, returnFormat);
        }

        [System.Web.Http.Route("api/Employee/PostEmployeeWorkingPeriodByGuid")]
        [System.Web.Http.HttpPost]
        public HttpResponseMessage PostEmployeeWorkingPeriodByGuid(DataDTO dataDTO)
        {

            ReturnFormat returnFormat = new BusinessLogic.BusinessLogic().GetEmployeeWorkingPeriodByGuid(dataDTO);


            return Request.CreateResponse(HttpStatusCode.OK, returnFormat);
        }


    }
}