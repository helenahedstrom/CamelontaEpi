using System;
using System.ComponentModel.DataAnnotations;
using CamelontaEpi.Models.Blocks;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace CamelontaEpi.Models.Pages
{
    [ContentType(DisplayName = "Blog", GUID = "07b01187-8665-4ef2-a3db-21ea00c9a9a8", Description = "Use this as a landing page for a list of blog posts", GroupName = SiteGroupNames.Blog)]
    [SitePageIcon]
    public class BlogLandingPage : StandardPage
    {
        [Display(Name = "Blog listing", Order = 315)]
        public virtual ListingBlock BlogPostListing { get; set; }
    }
}