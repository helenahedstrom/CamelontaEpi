using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace CamelontaEpi.Models.Blocks
{
    [ContentType(DisplayName = "FactsBlock", GUID = "03158db7-e110-4c70-9a03-a666cc754d0f", Description = "Use this for facts like number of happy customers.")]
    public class FactsBlock : BlockData
    {

        [CultureSpecific]
        [Display(
        Name = "Fact Number",
        Description = "Number of the fact.",
        GroupName = SystemTabNames.Content,
        Order = 1)]
        public virtual int FactNumber { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Fact Name",
            Description = "Name field's description",
            GroupName = SystemTabNames.Content,
            Order = 2)]
        public virtual string FactName { get; set; }

        [CultureSpecific]
        [Display(
      Name = "Fact Description",
      Description = "Describe",
      GroupName = SystemTabNames.Content,
      Order = 3)]
        public virtual string FactDescription { get; set; }


    }
}