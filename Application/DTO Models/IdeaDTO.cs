using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO_Models
{
    public class IdeaDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int UniqueCode { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
