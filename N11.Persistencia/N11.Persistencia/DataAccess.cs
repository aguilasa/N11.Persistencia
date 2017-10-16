using SQLite.Net;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace N11.Persistencia
{
    public class DataAccess
    {
        SQLiteConnection dbConn;
        public DataAccess()
        {
            dbConn = DependencyService.Get<ISQLite>().GetConnection();
            // create the table(s)
            dbConn.CreateTable<Employee>();
        }

        public List<Employee> GetAllEmployees()
        {
            return dbConn.Query<Employee>("Select * From [Employee]");
        }

        public int SaveEmployee(Employee aEmployee)
        {
            try
            {
                return dbConn.Insert(aEmployee);
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public int DeleteEmployee(Employee aEmployee)
        {
            return dbConn.Delete(aEmployee);
        }

        public int EditEmployee(Employee aEmployee)
        {
            return dbConn.Update(aEmployee);
        }
    }
}
