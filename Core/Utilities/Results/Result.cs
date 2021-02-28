using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
   
        //get= read only dir.
        //ancak constructor içinde set edilebilirler.
        //ÖNEMLİ, kafaya göre kodlamayı engelleriz.
        //This yollarsan , otomatik olarak diğer satır kod da çalışır.

        public Result(bool success, string message):this(success)
        {
            Message = message;
           
        }
        public Result(bool success)
        {
            
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
