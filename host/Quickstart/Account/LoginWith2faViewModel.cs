
using System;
using System.Collections.Generic;
using System.Linq;

namespace IdentityServer4.Quickstart.UI
{
    public class LoginWith2faViewModel : LoginInputModel
    {
        public string loginCode { get; set; }
    }
}