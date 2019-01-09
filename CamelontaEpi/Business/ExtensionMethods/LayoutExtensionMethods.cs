using CamelontaEpi.Models.Pages;
using EPiServer;
using EPiServer.Core;
using EPiServer.ServiceLocation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CamelontaEpi.Business.ExtensionMethods
{
    public static class LayoutExtensionMethods
    {
        public static string RenderFooterText(this HtmlHelper helper)
        {
            var loader = ServiceLocator.Current.GetInstance<IContentLoader>();
            var startPage = loader.Get<StartPage>(ContentReference.StartPage);
            return startPage.FooterText.ToString();
        }
    }
}