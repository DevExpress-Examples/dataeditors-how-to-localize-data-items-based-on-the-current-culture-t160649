// Developer Express Code Central Example:
// Best practices to change the current Culture in ASP.NET MVC Application using ComboBox Extension
// 
// This code example implements the approaches described in the
// http://www.devexpress.com/scid=T108044 knowledge base article. Please refer to
// the article above for implementation details.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=T108173

using Localization.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace Localization.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            var model = new Data { ID = 0, Name = string.Empty };
            return View(model);
        }

        [HttpPost]
        public ActionResult Post(Data model) {
            return View("Index", model);
        }
    }
}
