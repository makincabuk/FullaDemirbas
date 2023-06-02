using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    interface IStoreService
    {
        List<Store> GetList();
        void UserAdd(Store store);
        void UserDelete(Store store);
        void UserUpdate(Store store);
        Store GetByID(int id);
    }
}
