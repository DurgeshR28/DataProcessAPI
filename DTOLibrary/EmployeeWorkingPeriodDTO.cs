using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLibrary
{
    public class EmployeeWorkingPeriodDTO
    {
      
        public System.Guid employee_guid { get; set; }
        public string employee_name { get; set; }
        public string employee_surname { get; set; }
        public System.DateTime begin_date { get; set; }
        public System.DateTime end_date { get; set; }

        
    }
}
