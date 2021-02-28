using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorDataResult : Result
    {
        public ErrorDataResult(string message) : base(false, message)
        {
        }
        public ErrorDataResult() : base(false)
        {

        }
    }
}
