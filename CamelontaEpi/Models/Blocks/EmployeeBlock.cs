using System;
using System.ComponentModel.DataAnnotations;
using CamelontaEpi.Models.Media;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace CamelontaEpi.Models.Blocks
{
    [ContentType(DisplayName = "EmployeeBlock", GUID = "60c61772-1346-44d7-9bb5-f05ad45dd0d7", Description = "")]
    public class EmployeeBlock : BlockData
    {

        [CultureSpecific]
        [Display(
            Name = "Name",
            Description = "Name of Employee",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual string Name { get; set; }

        [CultureSpecific]
        [Display(
    Name = "Title",
    Description = "Title of Employee",
    GroupName = SystemTabNames.Content,
    Order = 10)]
        public virtual string Title { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Description",
            Description = "Description of employee",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        public virtual string Description { get; set; }

        [CultureSpecific]
        [Display(
    Name = "Image",
    Description = "Image of employee",
    GroupName = SystemTabNames.Content,
    Order = 30)]
        public virtual ContentReference Image { get; set; }


    }
}