using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CamelontaEpi.Models.Blocks;
using CamelontaEpi.Models.ViewModels;
using EPiServer;
using EPiServer.Core;
using EPiServer.Filters;
using EPiServer.Web;
using EPiServer.Web.Mvc;

namespace CamelontaEpi.Controllers
{
    public class CustomerListingBlockController : BlockController<CustomerListingBlock>
    {
        private readonly IContentLoader loader;
        public CustomerListingBlockController(IContentLoader loader)
        {
            this.loader = loader;
        }
        public override ActionResult Index(CustomerListingBlock currentBlock)
        {
            var viewmodel = new ListingBlockViewModel

            {
                Heading = currentBlock.Heading
            };
            if (currentBlock.ChildrenOfThisPage != null)
            {
                IEnumerable<PageData> children = loader.GetChildren<PageData>(
                currentBlock.ChildrenOfThisPage);
                // Remove pages:
                // 1. that are not published
                // 2. that the visitor does not have Read access to
                // 3. that do not have a page template
                IEnumerable<IContent> filteredChildren =
                FilterForVisitor.Filter(children);
                // 4. that do not have "Display in navigation" selected
                viewmodel.Pages = filteredChildren.Cast<PageData>()
                .Where(page => page.VisibleInMenu);
            }
            return PartialView(viewmodel);
        }
    }
}
