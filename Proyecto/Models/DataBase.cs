using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace Proyecto.Models
{
    
    public class DataBase
    {
        private SqlConnection Conection;

        public DataBase()
        {
            Conection = new SqlConnection("server=INT21698\\MSSQLSERVER01; database=Personas; integrated security = true");
            Conection.Open();
        }

        public SqlDataReader Read()
        {
            return Query("SELECT * FROM Persona");
        }

        private SqlDataReader Query(String Query)
        {
            return new SqlCommand(Query, Conection).ExecuteReader();
        }




    }
}