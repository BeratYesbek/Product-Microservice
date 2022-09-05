using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace Core.Utilities.Cloud.Entities
{
    public abstract class CloudFile
    {
        public string? Url { get; set; }
        public string? FileName { get; set; }
        public string? FileType { get; set; }
        public IFormFile? File { get; set; }
    }
}
