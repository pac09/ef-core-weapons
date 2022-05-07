using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi504.Data.Models
{
    public partial class Credit
    {
        [Key]
        public int CreditId { get; set; }
        public int PersonId { get; set; }
        public long Amount { get; set; }
        [Required]
        [StringLength(50)]
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreationDate { get; set; }

        [ForeignKey(nameof(PersonId))]
        [InverseProperty("Credits")]
        public virtual Person Person { get; set; }
    }
}
