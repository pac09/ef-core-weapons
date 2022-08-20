using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApi504.Data.Models
{
    public partial class User
    {
        [Key]
        public int UserId { get; set; }
        public int PersonId { get; set; }
        [Required]
        [StringLength(25)]
        public string UserName { get; set; }
        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        [ForeignKey("PersonId")]
        [InverseProperty("Users")]
        public virtual Person Person { get; set; }
    }
}
