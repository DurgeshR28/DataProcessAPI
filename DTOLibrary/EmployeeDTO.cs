using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLibrary
{
    public class EmployeeDTO
    {
        public System.Guid guid { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
      
        public System.DateTime date_of_birth { get; set; }
        public System.DateTime date_in_service { get; set; }
        public System.DateTime date_out_service { get; set; }
     
        public long wage_per_day { get; set; }
        public string address { get; set; }
        public string telephone_fix_number { get; set; }
        public string mobile_number { get; set; }

        public string gender_name { get; set; }   
        public string department_name { get; set; }   
    }
}
