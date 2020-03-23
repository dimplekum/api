using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseObjects
{
    public class EmployeeDB
    {

        employeeEntities DB = new employeeEntities();

        public void Save(EMPLOYEE eMPLOYEE)
        {
            try
            {
                DB.EMPLOYEEs.Add(eMPLOYEE);
                DB.SaveChanges(); 
            }
            catch (Exception ex)
            {

                throw;
            }
            
        }


        public void Update(EMPLOYEE EMPLOYEE)
        {
            DB.EMPLOYEEs.Add(EMPLOYEE);
            DB.SaveChanges();

        }

        //Retrieve by Id
        public EMPLOYEE getDetail(int Id)
        {
            return DB.EMPLOYEEs.Find(Id); 
            
        }
        //get List 
        //Delete 
        public void Remove(int Id)
        {
            EMPLOYEE EMPLOYEE = DB.EMPLOYEEs.Find(Id);
            DB.EMPLOYEEs.Remove(EMPLOYEE);
            DB.SaveChanges();
        }


        public List<EMPLOYEE> GetAll()
        {
            List<EMPLOYEE> lst = null;
            using (employeeEntities DB = new employeeEntities())
            {
                lst = (from u in DB.EMPLOYEEs select u).ToList();
            }
            return lst;
        }


    }
}
