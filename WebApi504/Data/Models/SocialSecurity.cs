using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi504.Data.Models
{
    [Table("SocialSecurity")]
    public partial class SocialSecurity
    {
        [Key]
        public int SocialId { get; set; }
        public int PersonId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreationDate { get; set; }

        [ForeignKey(nameof(PersonId))]
        [InverseProperty("SocialSecurities")]
        public virtual Person Person { get; set; }
    }
}
