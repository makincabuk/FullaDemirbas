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
    public class SubCategoryManager : ISubCategoryService
    {
        ISubCategoryDal _subCategoryDal;

        public SubCategoryManager(ISubCategoryDal subCategoryDal)
        {
            _subCategoryDal = subCategoryDal;
        }

        public SubCategory GetByID(int id)
        {
            return _subCategoryDal.Get(x => x.SubCategoryID == id);
        }

        public List<SubCategory> GetList()
        {
            return _subCategoryDal.List();
        }

        public void SubCategoryAdd(SubCategory subcategory)
        {
             _subCategoryDal.Insert(subcategory);
        }

        public void SubCategoryDelete(SubCategory subcategory) 
        {
             _subCategoryDal.Delete(subcategory);
        }

        public void SubCategoryUpdate(SubCategory subcategory)
        {
            _subCategoryDal.Update(subcategory);
        }
    }
}
