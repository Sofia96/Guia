using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace bsi24tallerbilly.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            try
            {
                //var userDetails = db.Users.Single(x => x.idUser == userModel.idUser && x.pass == userModel.pass);

                Session["Username"] = "Usuario anónimo";
                //Session["idUser"] = string.Join("", userDetails.idUser.ToString());
                //Session["name"] = userDetails.Personas.nombre;
                //Session["idPersona"] = userDetails.idPersona;


                //if (userModel.idUser == "Admin" || userModel.idUser == "admin")
                //{
                //    Session["Admin"] = 0;
                //    return RedirectToAction("Index", "Home");
                //}
                //else
                //{
                //    Session["Admin"] = 1;
                //    return RedirectToAction("Index", "Jueceos");

                //}


            }
            catch (InvalidOperationException e)
            {
                ModelState.AddModelError("", "Nombre de usuario o contraseña incorrecta" + " " + e);
            }
            return View();
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