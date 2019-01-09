using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Security;
using CamelontaEpi.Business.ExtensionMethods;
using CamelontaEpi.Models.Pages;
using CamelontaEpi.Models.ViewModels;
using EPiServer;
using EPiServer.Core;
using EPiServer.Filters;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;

namespace CamelontaEpi.Controllers
{
    public abstract class PageControllerBase<T>
  : PageController<T> where T : SitePageData
    {
        protected readonly IContentLoader loader;
        public PageControllerBase(IContentLoader loader)
        {
            this.loader = loader;
        }
        //public ActionResult Logout()
        //{
        //    FormsAuthentication.SignOut();
        //    return RedirectToAction("Index");
        //}
        protected IPageViewModel<TPage> CreatePageViewModel<TPage>(
        TPage currentPage) where TPage : SitePageData
        {
            var viewmodel = PageViewModel.Create(currentPage);
            viewmodel.StartPage = loader.Get<StartPage>(ContentReference.StartPage);
            viewmodel.MenuPages = FilterForVisitor.Filter(
            loader.GetChildren<SitePageData>(ContentReference.StartPage))
            .Cast<SitePageData>().Where(page => page.VisibleInMenu);
            viewmodel.Section = currentPage.ContentLink.GetSection();
            return viewmodel;
        }
    }
}