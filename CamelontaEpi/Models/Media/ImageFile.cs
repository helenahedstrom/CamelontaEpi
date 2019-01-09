using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Framework.DataAnnotations;

namespace CamelontaEpi.Models.Media
{
    [ContentType(DisplayName = "Image File", GUID = "b9e5c290-d9d1-4fb6-b226-e7f215b63bb4", Description = "Use this to upload image files")]
    [MediaDescriptor(ExtensionString = "png,gif,jpg,jpeg")]
    public class ImageFile : ImageData
    {

        [CultureSpecific]
        [Editable(true)]
        public virtual string Description { get; set; }

    }
}