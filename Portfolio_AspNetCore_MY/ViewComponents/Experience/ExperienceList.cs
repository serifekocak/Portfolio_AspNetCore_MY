using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio_AspNetCore_MY.ViewComponents.Experience
{
    public class ExperienceList : ViewComponent
    {
        ExperienceManager experienceManager = new ExperienceManager(new EfExperienceDal());

        public IViewComponentResult Invoke()
        {
            var values = experienceManager.TGetList();
            return View(values);    
        }
    }
}
