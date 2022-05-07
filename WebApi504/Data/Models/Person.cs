using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApi504.Data.Models
{
    [Table("Person")]
    public partial class Person
    {
        public Person()
        {
            Credits = new HashSet<Credit>();
            Loans = new HashSet<Loan>();
            SocialSecurities = new HashSet<SocialSecurity>();
        }

        [Key]
        public int PersonId { get; set; }
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required]
        [StringLength(10)]
        public string Id { get; set; }
        [Required]
        [StringLength(45)]
        public string Address { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreationDate { get; set; }

        [InverseProperty(nameof(Credit.Person))]
        public virtual ICollection<Credit> Credits { get; set; }
        [InverseProperty(nameof(Loan.Person))]
        public virtual ICollection<Loan> Loans { get; set; }
        [InverseProperty(nameof(SocialSecurity.Person))]
        public virtual ICollection<SocialSecurity> SocialSecurities { get; set; }
    }
}
