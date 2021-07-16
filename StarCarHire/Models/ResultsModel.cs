using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Umbraco.Web.Models;

namespace StarCarHire.Models
{
    public class ContentModel
    {
        [Required]
        [MaxLength(8)]
        public string Postcode { get; set; }
    }
}