using bsi24tallerbilly.Models;
using bsi24tallerbilly.Repositories;
using System.Linq;
using System.Web.Mvc;

namespace bsi24tallerbilly.Controllers
{
    public class ServicesController : Controller
    {

        private WorkshopServicesRepository workshopServicesRepository = new WorkshopServicesRepository();

        public ActionResult Show ()
        {
            WorkShopServicesList model = new WorkShopServicesList
            {
                ListOfServices = workshopServicesRepository.List()
            };
            return View(model);
        }

        public ActionResult List ()
        {
            WorkShopServicesList model = new WorkShopServicesList
            {
                ListOfServices = workshopServicesRepository.List()
            };
            return View(model);
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(WorkShopServicesViewModel model)
        {
            workshopServicesRepository.Add(model);
            return RedirectToAction("List");
        }

        [HttpPost]
        public ActionResult Update(WorkShopServicesViewModel model)
        {
            workshopServicesRepository.Update(model);
            return RedirectToAction("List");
        }

        public ActionResult Delete(int ID)
        {
            workshopServicesRepository.Delete(ID);
            return RedirectToAction("List");
        }
    }
}
