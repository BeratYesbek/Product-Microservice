using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Modals
{
    public class Color : IEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? HexCode { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public virtual List<Product>? Products{ get; set; }
    }
}
