using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Idea
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100,MinimumLength = 3)]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public int UniqueCode { get; set; }   
        public DateTime DateCreated { get; set; }
    }
}
