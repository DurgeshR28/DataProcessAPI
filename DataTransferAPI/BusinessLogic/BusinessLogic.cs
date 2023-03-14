
using DTOLibrary;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataTransferAPI.BusinessLogic
{
    public class BusinessLogic
    {
        EmployeeDBEntities1 employeeDBEntities = new EmployeeDBEntities1();

        public ReturnFormat GetEmployeeByGuid(DataDTO dataDTO)
        {
            try
            {
             

               // Guid employee_guid = Guid.Parse(value);
                var employeeList = (from emp in employeeDBEntities.employees
                                  join gen in employeeDBEntities.genders on emp.gender_guid equals gen.guid
                                  join dep in employeeDBEntities.departments on emp.department_guid equals dep.guid

                                  where emp.guid == dataDTO.employeeDTO.guid

                                    select new EmployeeDTO
                                    {
                                      name = emp.name,
                                      gender_name = gen.gender_name,
                                      surname = emp.surname,
                                      department_name = dep.department_name,
                                      wage_per_day = emp.wage_per_day,
                                      address = emp.address,
                                      date_in_service = emp.date_in_service,
                                      date_of_birth = emp.date_of_birth,
                                    
                                      mobile_number = emp.mobile_number,
                                      telephone_fix_number = emp.telephone_fix_number
                                      
                                      
                                      
                                  }).ToList();


                if (employeeList.Count == 0 || employeeList == null)
                {
                    return ReturnFormat.InstanceReturnFormat(new ReturnFormat { success = false, output = "No Value Found", exceptiontrace = " " });

                }
                else
                {
                    return ReturnFormat.InstanceReturnFormat(new ReturnFormat { success = true, output = JsonConvert.SerializeObject(employeeList), exceptiontrace = " " });

                }
              


            }
            catch (Exception ex)
            {

                return ReturnFormat.InstanceReturnFormat(new ReturnFormat { success = false, output = "Error!", exceptiontrace = ex.ToString() });

            }

        }

        public ReturnFormat GetEmployeeAbsencesForLeaveByGuid(DataDTO dataDTO)
        {
            try
            {


                // Guid employee_guid = Guid.Parse(value);
                var employeeList = (from abs in employeeDBEntities.absences
                                    join abstype  in employeeDBEntities.absence_type on abs.absence_type_guid equals abstype.guid
                                    join emp in employeeDBEntities.employees on abs.employee_guid equals emp.guid
                                   
                                    where emp.guid == dataDTO.employeeDTO.guid
                                    where abstype.absence_type_name == "Local Leave"


                                    select new EmployeeAbsenceDTO
                                    {
                                        employee_guid = emp.guid,
                                        employee_name = emp.name,
                                        employee_surname = emp.surname,
                                        absence_date = abs.absence_date,
                                        absence_type = abstype.absence_type_name,
                                     


                                    }).ToList();


                if (employeeList.Count == 0 || employeeList == null)
                {
                    return ReturnFormat.InstanceReturnFormat(new ReturnFormat { success = false, output = "No Value Found", exceptiontrace = " " });

                }
                else
                {
                    return ReturnFormat.InstanceReturnFormat(new ReturnFormat { success = true, output = JsonConvert.SerializeObject(employeeList), exceptiontrace = " " });

                }



            }
            catch (Exception ex)
            {

                return ReturnFormat.InstanceReturnFormat(new ReturnFormat { success = false, output = "Error!", exceptiontrace = ex.ToString() });

            }

        }

        public ReturnFormat GetEmployeeWorkingPeriodByGuid(DataDTO dataDTO)
        {
            try
            {


                // Guid employee_guid = Guid.Parse(value);
                var employeeList = (from wk in employeeDBEntities.working_period
                                    join emp in employeeDBEntities.employees on wk.employee_guid equals emp.guid

                                    where emp.guid == dataDTO.employeeDTO.guid

                                    select new EmployeeWorkingPeriodDTO
                                    {
                                        employee_guid = emp.guid,
                                        employee_name = emp.name,
                                        employee_surname = emp.surname,
                                        begin_date = wk.begin_date,
                                        end_date = wk.end_date,



                                    }).ToList();


                if (employeeList.Count == 0 || employeeList == null)
                {
                    return ReturnFormat.InstanceReturnFormat(new ReturnFormat { success = false, output = "No Value Found", exceptiontrace = " " });

                }
                else
                {
                    return ReturnFormat.InstanceReturnFormat(new ReturnFormat { success = true, output = JsonConvert.SerializeObject(employeeList), exceptiontrace = " " });

                }



            }
            catch (Exception ex)
            {

                return ReturnFormat.InstanceReturnFormat(new ReturnFormat { success = false, output = "Error!", exceptiontrace = ex.ToString() });

            }

        }
        //public void test()
        //{
        //    employee employeess = new employee();
        //    employeess.guid = Guid.NewGuid();
        //    employeess.name = "Samantha";
        //    employeess.surname = "Goodoor";
        //    employeess.gender_guid = Guid.Parse("58A9BAA0-93C0-460D-8595-F6000E464F6F");
        //    employeess.date_of_birth = DateTime.Parse("1991/02/30"); 
        //    employeess.date_in_service = DateTime.Parse("2020/09/01");
        //    employeess.department_guid= Guid.Parse("A6993CE4-6C7C-4C34-9863-16740DC0E2AC");
        //    employeess.wage_per_day = 1500;
        //    employeess.address = "Port Louis";
        //    employeess.telephone_fix_number = "58963415";
        //    employeess.mobile_number = "6247852";
        //    employeeDBEntities.employees.Add(employeess);

        //    employeeDBEntities.SaveChanges();





        //}
    }
}