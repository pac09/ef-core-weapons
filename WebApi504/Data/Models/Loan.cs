using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi504.Data.Models
{
    public partial class Loan
    {
        [Key]
        public int LoanId { get; set; }
        public int PersonId { get; set; }
        public long Amount { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EndDate { get; set; }

        [ForeignKey(nameof(PersonId))]
        [InverseProperty("Loans")]
        public virtual Person Person { get; set; }
    }
}
