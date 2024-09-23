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
    public class SocialMediaManager : ISocialMediaService
    {
        ISocialMediaDal _socialMedyaDal;

        public SocialMediaManager(ISocialMediaDal socialMedyaDal)
        {
            _socialMedyaDal = socialMedyaDal;
        }

        public void TAdd(SocialMedia t)
        {
            _socialMedyaDal.Insert(t);
        }

        public void TDelete(SocialMedia t)
        {
            _socialMedyaDal.Delete(t);
        }

        public SocialMedia TGetByID(int id)
        {
            return _socialMedyaDal.GetByID(id);
        }

        public List<SocialMedia> TGetList()
        {
            return _socialMedyaDal.GetList();
        }

        public void TUpdate(SocialMedia t)
        {
            _socialMedyaDal.Update(t);
        }
    }
}
