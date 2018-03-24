using bsi24tallerbilly.Models;
using bsi24tallerbilly.Models.WorkshopServicesViewModel;
using bsi24tallerbilly.Repositories;
using System.Linq;
using System.Web.Mvc;

namespace bsi24tallerbilly.Controllers
{
    public class WorkshopServicesController : Controller
    {

        private WorkshopServicesRepository workshopServicesRepository = new WorkshopServicesRepository();

        public ActionResult Show()
        {
            WorkshopServicesListViewModel model = new WorkshopServicesListViewModel
            {
                ListOfServices = workshopServicesRepository.List()
            };
            return View(model);
        }

        public ActionResult List()
        {
            WorkshopServicesListViewModel model = new WorkshopServicesListViewModel
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
        public ActionResult Add(AddWorkshopServiceViewModel model)
        {
            workshopServicesRepository.Add(model);
            return RedirectToAction("List");
        }

        public ActionResult Update (int id)
        {
            return View("Add", workshopServicesRepository.GetByID(id));
        }

        [HttpPost]
        public ActionResult Update(AddWorkshopServiceViewModel model)
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
