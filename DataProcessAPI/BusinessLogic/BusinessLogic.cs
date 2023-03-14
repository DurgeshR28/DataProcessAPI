using DTOLibrary;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace DataProcessAPI.BusinessLogic
{
    public class BusinessLogic
    {
        public ReturnFormat CreateDataTable()
        {
            try
            {
                //get employee details by api data -- api/Employee/PostEmployeeDetailsByGuid
                //return data inform of employee dto
                List<EmployeeDTO> employeeDTO = null;//suppose to be returned data

                if (employeeDTO != null)
                {
                    // Create a DataTable and add two Columns to it
                    DataTable dt = new ListtoDataTableConverter().ToDataTable(employeeDTO);
                    dt.Columns.Add("MonthlyTotalWage", typeof(int));


                    // Create a DataRow, add MonthlyTotalWage value
                    DataRow dr = dt.NewRow();
                    dr["MonthlyTotalWage"] = CalculateMonthlyWagesPerEmployee();

                    dt.Rows.Add(dr);
                    return ReturnFormat.InstanceReturnFormat(new ReturnFormat { success = true, output = JsonConvert.SerializeObject(dt), exceptiontrace = " " });


                }


                return ReturnFormat.InstanceReturnFormat(new ReturnFormat { success = false, output = "No value found", exceptiontrace = " " });

            }
            catch (Exception ex)
            {

                return ReturnFormat.InstanceReturnFormat(new ReturnFormat { success = false, output = "Error!", exceptiontrace = ex.ToString() });

            }





        }

        public int CalculateMonthlyWagesPerEmployee()
        {
            int amountPerMonth = 0;
            //get wages per employee - need to connect to api

            //sample data
            //string employeeDetails = "'[{\"guid\":\"00000000-0000-0000-0000-000000000000\",\"name\":\"Samantha\",\"surname\":\"Goodoor\",\"date_of_birth\":\"1991-02-28T00:00:00\",\"date_in_service\":\"2020-09-01T00:00:00\",\"date_out_service\":\"0001-01-01T00:00:00\",\"wage_per_day\":1500,\"address\":\"Port Louis\",\"telephone_fix_number\":\"589796415\",\"mobile_number\":\"6247852\",\"gender_name\":\"Female\",\"department_name\":\"IT\"}]'";
            // EmployeeDTO employeeDTO = JsonConvert.DeserializeObject<EmployeeDTO>(employeeDetails);

            return amountPerMonth;

        }
    }
}