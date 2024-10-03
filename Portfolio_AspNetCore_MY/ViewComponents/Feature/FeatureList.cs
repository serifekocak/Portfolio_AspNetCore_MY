using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio_AspNetCore_MY.ViewComponents.Feature
{
    public class FeatureList: ViewComponent 
    {
        //FeatureManager veri erişim sınıfını (EfFeatureDal) kullanarak iş kurallarını uygular
        // Entity Framework sınıfının kullanılma sebebi generic ve özel metotları birden içinde barındırmasıdır.
        FeatureManager featureManager = new FeatureManager(new EfFeatureDal());
        public IViewComponentResult Invoke()
        {
            var values = featureManager.TGetList();
            return View(values);
        }
    }
}
