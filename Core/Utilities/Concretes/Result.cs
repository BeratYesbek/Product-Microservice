using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Abstracts;

namespace Core.Utilities.Concretes
{
    public class Result : IResult
    {
        public string? Message { get; set; }
        public bool Success { get; set; }
        public Result(string message, bool success)
        {
            Message = message;
            Success = success;
        }

        public Result(bool success)
        {
            Success = success;
        }
    }
}
