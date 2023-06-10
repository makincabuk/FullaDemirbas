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
    public class ModelManeger : IModelService
    {
        IModelDal _modeldal;
        public ModelManeger(IModelDal modelDal)
        {
            _modeldal = modelDal;
        }
        public Model GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Model> GetList()
        {
            throw new NotImplementedException();
        }

        public void ModelAdd(Model admin)
        {
            throw new NotImplementedException();
        }

        public void ModelDisable(Model admin)
        {
            throw new NotImplementedException();
        }

        public void ModelEnable(Model admin)
        {
            throw new NotImplementedException();
        }

        public void ModelUpdate(Model admin)
        {
            throw new NotImplementedException();
        }
    }
}
