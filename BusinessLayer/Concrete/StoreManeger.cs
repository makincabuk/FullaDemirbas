using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class StoreManeger : IStoreService
    {
        IStoreDal _storeDal;

        public StoreManeger(IStoreDal storeDal)
        {
            _storeDal = storeDal;
        }

        public Store GetByID(int id)
        {
            return _storeDal.Get(x => x.StoreID == id);
        }

        public List<Store> GetList()
        {
            return _storeDal.List();
        }

        public void UserAdd(Store store)
        {
            _storeDal.Insert(store);
        }

        public void UserDelete(Store store)
        {
            throw new NotImplementedException();
        }

        public void UserUpdate(Store store)
        {
            _storeDal.Update(store);
        }
    }
}
