using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Abstracts;

namespace Core.Utilities.Concretes
{
    public class DataResult<T> : IDataResult<T>
    {
        public string? Message { get; set; }
        public bool Success { get; set; }
        public T? Data { get; set; }

        public DataResult(T data, string message, bool success)
        {
            Data = data;
            Message = message;
            Success = success;
        }

        public DataResult(T data, bool success)
        {
            Data = data;
            Success = success;
        }
    }
}
