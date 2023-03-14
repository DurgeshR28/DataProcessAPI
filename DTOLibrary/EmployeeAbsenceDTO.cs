using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLibrary
{
    public class EmployeeAbsenceDTO
    {
      
        public System.Guid employee_guid { get; set; }
        public string employee_name { get; set; }
        public string employee_surname { get; set; }
        public System.DateTime absence_date { get; set; }
       
        public virtual string absence_type { get; set; }
       
    }
}
