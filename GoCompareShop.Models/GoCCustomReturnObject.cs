using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoCompareShop.Models
{
    public class Error
    {
        public string Field { get; set; }
        public string Message { get; set; }

        public object data { get; set; }    
    }
    public class GoCCustomReturnObject
    {
   
        public GoCCustomReturnObject()
        {
            Messages = new List<Error>();
            Errors = new List<Error>();

            ExceptionErrors = new List<string>();

        }
        public List<Error> Messages { get; set; }

        public List<Error> Errors { get; set; }

        public List<string> ExceptionErrors { get; set; }

        public bool? Succeeded { get; set; }

        public string Field { get; set; }
        public string CustomMessage { get; set; }
        public Exception Exception { get; set; }

        public Object Data { get; set; }
    }

}
