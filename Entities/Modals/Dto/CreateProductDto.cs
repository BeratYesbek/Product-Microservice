using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Entities.Modals.Dto
{
    public class CreateProductDto
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        public int CategoryId { get; set; }
        public int ColorId { get; set; }
        public IFormFile[]? Files { get; set; }
    }
}
