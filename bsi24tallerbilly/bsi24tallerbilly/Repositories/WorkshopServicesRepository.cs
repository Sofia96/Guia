using bsi24tallerbilly.Models;
using bsi24tallerbilly.Data.Entities;
using System.Linq;
using System.Collections.Generic;
using bsi24tallerbilly.Models.WorkshopServicesViewModel;

namespace bsi24tallerbilly.Repositories
{
    public class WorkshopServicesRepository
    {
        public ApplicationDbContext db = new ApplicationDbContext();

        public List<WorkshopServices> List()
        {
            return db.WorkshopServices.ToList();
        }

        public AddWorkshopServiceViewModel GetByID (int id)
        {
            WorkshopServices CurrentService = db.WorkshopServices.SingleOrDefault(x => x.WorkshopServicesID == id);
            AddWorkshopServiceViewModel NewModel = new AddWorkshopServiceViewModel()
            {
                WorkshopServicesID = CurrentService.WorkshopServicesID,
                Title = CurrentService.Title,
                ImageURL = CurrentService.ImageURL,
                Description = CurrentService.Description
            };
            return NewModel;
        }

        public void Add(AddWorkshopServiceViewModel model)
        {
            WorkshopServices NewService = new WorkshopServices()
            {
                ImageURL = model.ImageURL,
                Title = model.Title,
                Description = model.Description
            };

            db.WorkshopServices.Add(NewService);
            db.SaveChanges();
        }

        public void Update(AddWorkshopServiceViewModel model)
        {
            WorkshopServices CurrentService = db.WorkshopServices.SingleOrDefault(x => x.WorkshopServicesID == model.WorkshopServicesID);
            CurrentService.ImageURL = model.ImageURL;
            CurrentService.Title = model.Title;
            CurrentService.Description = model.Description;
            db.Entry(CurrentService).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(int ID)
        {
            WorkshopServices CurrentService = db.WorkshopServices.SingleOrDefault(x => x.WorkshopServicesID == ID);
            db.WorkshopServices.Attach(CurrentService);
            db.WorkshopServices.Remove(CurrentService);
            db.SaveChanges();
        }
    }
}