using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ExperienceManager : IExperienceService
    {
        IExperienceDal _exerienceDal;

        public ExperienceManager(IExperienceDal exerienceDal)
        {
            _exerienceDal = exerienceDal;
        }

        public void TAdd(Experience t)
        {
            _exerienceDal.Insert(t);
        }

        public void TDelete(Experience t)
        {
            _exerienceDal.Delete(t);
        }

        public Experience TGetByID(int id)
        {
            return _exerienceDal.GetByID(id);
        }

        public List<Experience> TGetList()
        {
            return _exerienceDal.GetList();
        }

        public void TUpdate(Experience t)
        {
            _exerienceDal.Update(t);
        }
    }
}
