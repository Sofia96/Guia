using bsi24tallerbilly.Models;
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
        void Add(WorkShopServicesViewModel model);
        void Update(WorkShopServicesViewModel model);
        void Delete(int ID);
    }
}
