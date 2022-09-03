using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Modals
{
    public class ProductImage : IEntity
    {
        public int Id { get; set; }
        public string? Url { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
