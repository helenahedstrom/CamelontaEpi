using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using CamelontaEpi.Models.Pages;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;

namespace CamelontaEpi.Controllers
{
    public class BlogLandingPageController : PageControllerBase<BlogLandingPage>
    {
        public BlogLandingPageController(IContentLoader loader) : base(loader)
        {
        }

        public ActionResult Index(BlogLandingPage currentPage)
        {
            /* Implementation of action. You can create your own view model class that you pass to the view or
             * you can pass the page type for simpler templates */

            return View(CreatePageViewModel(currentPage));
        }
    }
}