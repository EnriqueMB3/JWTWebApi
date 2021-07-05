using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTWebApi
{
    public class LoginRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }

    }
}
