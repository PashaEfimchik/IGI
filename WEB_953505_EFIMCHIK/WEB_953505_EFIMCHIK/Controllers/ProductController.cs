using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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
        private ILogger _logger;
        public ProductController(ApplicationDbContext context, ILogger<ProductController> logger)
        {
            _pageSize = 3;
            _context = context;
            _logger = logger;
            //SetupData();
        }

        [Route("Catalog")]
        [Route("Catalog/Page_{pageNo}")]
        public IActionResult Index(int? group, int pageNo = 1)
        {
            var autoFiltered = _context.Cars.Where(d => !group.HasValue ||
            d.AutoGroupId == group.Value);

            ViewData["Groups"] = _context.AutoGroups;
            ViewData["CurrentGroup"] = group ?? 0;

            //_logger.LogInformation($"info: group={group}, page={pageNo}");

            var model = ListViewModel<Auto>.GetModel(autoFiltered, pageNo, _pageSize);
            if (Request.IsAjaxRequest())
                return PartialView("_listpartial", model);
            else
                return View(model);
            //return View(ListViewModel<Auto>.GetModel(autoFiltered, pageNo, _pageSize));
        }
    }
}
