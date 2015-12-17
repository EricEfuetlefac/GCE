using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GCE.Models
{
    public class GCEresult
    {
        public virtual int GCEresultID { get; set; }
        [Required]
        public string Name { get; set; }
    }
}