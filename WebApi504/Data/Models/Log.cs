using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApi504.Data.Models
{
    public partial class Log
    {
        [Key]
        public int LogId { get; set; }
        [StringLength(250)]
        public string Activity { get; set; }
    }
}
