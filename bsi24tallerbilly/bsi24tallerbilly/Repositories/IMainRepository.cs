using bsi24tallerbilly.Models;
using bsi24tallerbilly.Models.WorkshopServicesViewModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bsi24tallerbilly.Repositories
{
    public interface IMainRepository
    {
        List<TTypes> List<TTypes>();
        void Add(AddWorkshopServiceViewModel model);
        void Update(AddWorkshopServiceViewModel model);
        void Delete(int ID);
    }
}
