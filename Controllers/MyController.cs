using Dropdown.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dropdown.Controllers
{
    public class MyController : Controller
    {
        public MyContext _DBCONN { get; }
            public MyController(MyContext DBCONN)
            {
                this._DBCONN = DBCONN;
            }

            public IActionResult Index()
            {
            List<Emp1> data = _DBCONN.emp1s.ToList();
            //var data = _DBCONN.emp1s.ToList();
            return View(data);
            }

            public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Emp1 e)
        {
            _DBCONN.emp1s.Add(e);
            _DBCONN.SaveChanges();
           
            return RedirectToAction("Index");
        }



        public IActionResult Delete(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var data = _DBCONN.emp1s.SingleOrDefault(x => x.Id == id);
            _DBCONN.emp1s.Remove(data);
            _DBCONN.SaveChanges();
            return RedirectToAction("Index");

        }




        public IActionResult Update(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var data = _DBCONN.emp1s.SingleOrDefault(x => x.Id == id);
            return View(data);
        }


        [HttpPost]
        public IActionResult Update( Emp1 u)
        {
            if (u == null)
            {
                return NotFound();
            }

            _DBCONN.emp1s.Update(u);
            _DBCONN.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult RegistrationDetails()
        {
            return View("RegisterView");
        }
        [HttpPost]
        public IActionResult RegistrationDetails(Registration r)
        {
            if (ModelState.IsValid == true)
            {
                _DBCONN.registrations.Add(r);
                _DBCONN.SaveChanges();
            if (r!= null)
            {
                ViewBag.message = "<script> alert('Registration Successfull')</script>";
                ModelState.Clear();
                return RedirectToAction("Index");

                }
        }
            else 
            ViewBag.message = "<script> alert('Registration unSuccessfull')</script>";
            return RedirectToAction("RegisterView");
        }


        //public IActionResult LoginDetails()
        //{


        //    return View("LoginView");
        //}

        //public IActionResult Login(Registration r)
        //{


        //    return View();
        //}

        public IActionResult GetCountry()
        {

            var data1 = _DBCONN.countries.ToList();
            return Json(data1);
        }

        public IActionResult GetState()
        {

            var data2 = _DBCONN.states.ToList();
            return Json(data2);
        }



    }
}
