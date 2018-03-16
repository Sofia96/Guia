using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using static bsi24tallerbilly.Models.ContactUsViewModels;

namespace bsi24tallerbilly.Controllers
{
    public class ContactUsController : Controller
    {
        [HttpPost]
        public ActionResult SendInformation(SendEmailViewModel model)
        {
            //implemets the repository send email
            return View(model);
        }
    }
}
