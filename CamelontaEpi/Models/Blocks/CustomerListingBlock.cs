using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace CamelontaEpi.Models.Blocks
{
    [ContentType(DisplayName = "CustomerListingBlock", GUID = "1d3a31dd-a2d7-4791-8cb7-a0ee2d2fe236", Description = "Choose a page in the tree, and its children will be listed, with a heading")]
    public class CustomerListingBlock : BlockData
    {
        [Display(Name = "Heading", Order = 10)]
        public virtual string Heading { get; set; }
        [Display(Name = "Show children of this page", Order = 20)]
        public virtual PageReference ChildrenOfThisPage { get; set; }
    }
}