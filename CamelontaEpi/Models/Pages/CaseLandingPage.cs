using System;
using System.ComponentModel.DataAnnotations;
using CamelontaEpi.Models.Blocks;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace CamelontaEpi.Models.Pages
{
    [ContentType(DisplayName = "Case Landing Page", GUID = "02ecff9c-c016-43ee-b5f0-21b73ab045cc", Description = "Use this as a landing page for customer cases")]
    [SitePageIcon]
    public class CaseLandingPage : StandardPage
    {
        [Display(Name = "Customer listing", Order = 315)]
        public virtual CustomerListingBlock CustomerListing { get; set; }
    }
}