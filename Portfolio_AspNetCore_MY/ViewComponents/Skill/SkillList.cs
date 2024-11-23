using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio_AspNetCore_MY.ViewComponents.Skill
{
    public class SkillList : ViewComponent
    {
        // Manager sınıfı iş kurallarını uygulamak için ISkillDal nesnesi ister.
        // Entity Framework nesnesi verilir çünkü hem generik hem de özel metodlar barındırır.
        // EfSkillDal IGenericDal ve ISkillDal sınıflarından miras alır.
        SkillManager skillManager = new SkillManager(new EfSkillDal());

        public IViewComponentResult Invoke()
        {
            var values = skillManager.TGetList();
            return View(values);
        }
    }
}
