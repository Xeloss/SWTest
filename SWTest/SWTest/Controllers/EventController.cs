using SWTest.Data.Context;
using SWTest.Data.Entities;
using SWTest.Data.Repositories;
using SWTest.Models.Datatable;
using SWTest.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace SWTest.Controllers
{
    public class EventController : Controller
    {
        [OutputCacheProfile("CacheEvents")]
        public JsonResult List(DataTableQuery query)
        {
            using (var repository = new Repository<Event>())
            {
                var events = repository.GetAll();

                var total = events.Count();
                var filtered = total;

                IQueryable<Event> result = events.OrderBy(e => e.Id);

                if (!string.IsNullOrEmpty(query.sSearch))
                {
                    result = result.Where(e => e.Title.Contains(query.sSearch));
                    filtered = result.Count();
                }
                
                result = result.Skip(query.iDisplayStart)
                               .Take(query.iDisplayLength);

                return Json(new DataTableResponse<Event>(result.ToList(), total, filtered), JsonRequestBehavior.AllowGet);
            }
        }
    }
}