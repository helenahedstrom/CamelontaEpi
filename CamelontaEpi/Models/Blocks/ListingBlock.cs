using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace CamelontaEpi.Models.Blocks
{
    [ContentType(DisplayName = "Listing", GUID = "cdb0ebcf-755b-4077-b11a-039e265bd2db", Description = "Choose a page in the tree, and its children will be listed, with a heading")]
    [SiteBlockIcon]
    public class ListingBlock : BlockData
    {
        [Display(Name = "Heading", Order = 10)]
        public virtual string Heading { get; set; }
        [Display(Name = "Show children of this page", Order = 20)]
        public virtual PageReference ShowChildrenOfThisPage { get; set; }
    }
}