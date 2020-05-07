using EFRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly UnitOfWork db;
        public HomeController()
        {
            db = new UnitOfWork();
        }
        // GET: Home
        public ActionResult Index()
        {
            var students = db.StudentRepository.Get(includeProperties: "Class");

            Model.Student stu= new Model.Student {
                Age = 20,
                Id_Class = 2,
                Name = "Andrea",
                LastName = "Legal"

        };



            db.StudentRepository.Insert(stu);
            db.StudentRepository.Delete(db.StudentRepository.GetByID(1));
            db.Save();


           // var students = db.StudentRepository.Get();

            return View();
        }
    }
}