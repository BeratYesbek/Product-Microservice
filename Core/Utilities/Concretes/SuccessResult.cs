using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Concretes
{
    public class SuccessResult : Result
    {
        public SuccessResult(string message) : base(message, true)
        {

        }
    }
}
