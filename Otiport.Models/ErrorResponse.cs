using System;
using System.Collections.Generic;
using System.Text;

namespace Otiport.Models
{
    public class ErrorResponse
    {
        public int ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
        public List<Error> Errors { get; set; } = new List<Error>();
    }

    public class Error
    {
        public string Title { get; set; }
        public string Detail { get; set; }
    }
}
