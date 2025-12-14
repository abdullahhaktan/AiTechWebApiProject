using AiTech.Entity.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiTech.Entity.Entities
{
    public class Project: BaseEntity
    {
        public string Title { get; set; }
        public string ImageUrl { get; set; }

        public Category Category { get; set; }
        public int CategoryId { get; set; }
    }
}
