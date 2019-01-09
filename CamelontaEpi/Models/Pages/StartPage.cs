using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace CamelontaEpi.Models.Pages
{
    [ContentType(DisplayName = "Start", GUID = "19b3908c-a881-4062-8daa-357c9be3726c", 
        Description = "The home page",
        GroupName = SiteGroupNames.Specialized,
        Order = 10)]
    public class StartPage : PageData
    {
        [CultureSpecific]
        [Display(Name = "Heading", Description =
        "If the Heading is not set, the page falls back to showing the Name.",
        GroupName = SystemTabNames.Content, Order = 10)]
        public virtual string Heading { get; set; }

        [CultureSpecific]
        [Display(Name = "Main body",
        Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
        GroupName = SystemTabNames.Content, Order = 20)]
        public virtual XhtmlString MainBody { get; set; }
    }
}