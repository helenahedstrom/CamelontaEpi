using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace CamelontaEpi.Models.Blocks
{
    [ContentType(DisplayName = "Map", GUID = "34fea7df-ff91-4b6a-a524-a271e96d0f3a", Description = "Use this to display a map")]
    public class MapBlock : BlockData
    {
        [Display(
             Name = "Latitude",
             Description = "Latitude",
             GroupName = SystemTabNames.Content,
             Order = 1)]
        public virtual string Latitude { get; set; }
        [Display(
            Name = "Longitude",
            Description = "Longitude",
            GroupName = SystemTabNames.Content,
            Order = 2)]
        public virtual string Longitude { get; set; }
        [CultureSpecific]
        [Display(
            Name = "Description",
            Description = "Localtion description",
            GroupName = SystemTabNames.Content,
            Order = 3)]
        public virtual string Description { get; set; }
    }
}