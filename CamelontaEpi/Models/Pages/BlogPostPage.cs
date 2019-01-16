using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace CamelontaEpi.Models.Pages
{
    [ContentType(DisplayName = "BlogPostPage", GUID = "c746bb76-3546-4501-af7d-df1958c69be8", Description = "Use this to add blog posts.", GroupName = SiteGroupNames.Blog)]
    public class BlogPostPage : StandardPage
    {
        [CultureSpecific]
        [Display(Name = "Teaser", Description =
        "Teaser for the blog post",
        GroupName = SystemTabNames.Content, Order = 15)]
        public virtual string Teaser { get; set; }
    }
}