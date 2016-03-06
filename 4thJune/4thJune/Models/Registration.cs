using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _4thJune.Models
{
    public class Registration
    {
        public Guid Id { get; set; }
        public DateTime Created { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
    }
}