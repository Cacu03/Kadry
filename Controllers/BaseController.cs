using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kadry.ApDbContext;

namespace Kadry.Controllers
{
    public class BaseController : Controller
    {
       protected AplicationDbContext _db = new AplicationDbContext();

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
            base.Dispose(disposing);
        }
    }
}