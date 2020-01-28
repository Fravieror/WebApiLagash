using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiLagash.Models
{
    public class Response<T>
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public T Object { get; set; }
    }
}