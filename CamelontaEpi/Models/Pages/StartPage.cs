﻿using System;
using System.Collections.Generic;
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
    [SiteStartIcon]
    [AvailableContentTypes(Include = new[] { typeof(StandardPage) })]
    public class StartPage : SitePageData
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

        [CultureSpecific]
        [Display(Name = "Footer text",
        Description = "The footer text will be shown at the bottom of every page.",
        GroupName = SiteTabNames.SiteSettings, Order = 10)]
        public virtual XhtmlString FooterText { get; set; }

        [CultureSpecific]
        [Display(
                   Name = "Hero Text",
                   Description = "The hero text will be shown at the bottom of every page.",
                   GroupName = SiteTabNames.SiteSettings,
                   Order = 320)]
        [Required]
        public virtual IList<string> HeroText { get; set; }

        [CultureSpecific]
        [Display(Name = "Main content area",
        Description = "Drag and drop images, blocks, folders, and pages with partial templates.",
        GroupName = SystemTabNames.Content,
        Order = 30)]
        [AllowedTypes(typeof(StandardPage), typeof(BlockData),
        typeof(ImageData), typeof(ContentFolder))]
        public virtual ContentArea MainContentArea { get; set; }
    }
}