using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class IdeaHomeViewModel
    {
        public IEnumerable<IdeaViewModel> Ideas { get; set; }

        public IdeaHomeViewModel()
        {
            Ideas = new List<IdeaViewModel>();
        }
    }
}
