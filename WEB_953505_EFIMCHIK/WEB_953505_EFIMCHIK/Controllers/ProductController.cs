using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEB_953505_EFIMCHIK.Data;
using WEB_953505_EFIMCHIK.Entities;
using WEB_953505_EFIMCHIK.Extensions;
using WEB_953505_EFIMCHIK.Models;

namespace WEB_953505_EFIMCHIK.Controllers
{
    public class ProductController : Controller
    {
        ApplicationDbContext _context;
        //List<Auto> _cars;
        //List<AutoGroup> _autoGroups;
        int _pageSize;
        public ProductController(ApplicationDbContext context)
        {
            _pageSize = 3;
            _context = context;
            //SetupData();
        }

        [Route("Catalog")]
        [Route("Catalog/Page_{pageNo}")]
        public IActionResult Index(int? group, int pageNo=1)
        {
            var autoFiltered = _context.Cars.Where(d => !group.HasValue ||
            d.AutoGroupId == group.Value);

            ViewData["Groups"] = _context.AutoGroups;
            ViewData["CurrentGroup"] = group ?? 0;

            var model = ListViewModel<Auto>.GetModel(autoFiltered, pageNo, _pageSize);
            if (Request.IsAjaxRequest())
                return PartialView("_listpartial", model);
            else
                return View(model);
                //return View(ListViewModel<Auto>.GetModel(autoFiltered, pageNo, _pageSize));
        }

        /*private void SetupData()
        {
            _autoGroups = new List<AutoGroup>
            {
                new AutoGroup {AutoGroupId=1, GroupName="Седан"},
                new AutoGroup {AutoGroupId=2, GroupName="Универсал"},
                new AutoGroup {AutoGroupId=3, GroupName="Внедорожник"},
                new AutoGroup {AutoGroupId=4, GroupName="Купе"},
            };

            _cars = new List<Auto>
            {
                new Auto{AutoId=1, AutoName="Audi A8 D4",
                Description="Б/У, год: 2015, объем: 4.0, пробег: 110000, расход 20л/100km",
                Price=21000, AutoGroupId=1, Image="AUDI_A8_D4.jpg"},

                new Auto{AutoId=2, AutoName="Volkswagen Touareg |||",
                Description="Новый, год: 2020, объем: 3.0, пробег: 7200, расход 10л/100km",
                Price=30000, AutoGroupId=3, Image="VW_Touareg3.jpg"},

                new Auto{AutoId=3, AutoName="Porsche 911 GT3 992",
                Description="Новый, год: 2021, объем: 4.0, пробег: 1000, расход 35л/100km",
                Price=280000, AutoGroupId=4, Image="PORSCHE_911.jpg"},

                new Auto{AutoId=3, AutoName="Audi A6 C7 Allroad",
                Description="Б/У, год: 2015, объем: 3.0, пробег: 56000, расход 15л/100km",
                Price=28000, AutoGroupId=2, Image="AUDI_A6_C7_Allroad.jpg"}
            };
        }*/
    }
}
