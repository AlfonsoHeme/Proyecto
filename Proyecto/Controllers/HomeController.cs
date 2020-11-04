using Proyecto.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            SqlConnection Conection = new SqlConnection("server=INT21698\\MSSQLSERVER01; database=Personas; integrated security = true");
            var model = new DataBase();
            Conection.Open();
            model.reader = new SqlCommand("SELECT * FROM Persona", Conection).ExecuteReader();

            return View(model);

        }

        [HttpPost]
        public ActionResult Index(Persona p)
        {

            return View(p);
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}