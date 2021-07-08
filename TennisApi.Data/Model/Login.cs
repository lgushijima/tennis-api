using System;
using System.Collections.Generic;

namespace TennisApi.Data.Model
{
    public partial class Login
    {
        public Guid ID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Code { get; set; }
        public string Status { get; set; }
    }
}
