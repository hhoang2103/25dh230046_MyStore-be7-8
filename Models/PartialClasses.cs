using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _25dh230046_MyStore.Models
{
    [MetadataType(typeof(UserMetadata))]
    public partial class User
    {
        [NotMapped]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

    }

    [MetadataType(typeof(CategoryMetadata))]
    public partial class Category
    {

    }
}