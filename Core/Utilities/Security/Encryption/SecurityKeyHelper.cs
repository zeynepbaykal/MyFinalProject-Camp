using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace Core.Utilities.Security.Encryption
{
    //işin içerinde şifreleme olan sistemlerde herşeyi bir byte array formatında olusturmamız gerekir basıt bır strıng formatında key olusturamayız. bunları asp .net in anlayacağı şekle JWT anlayacağı şekle getirmemiz lazım.bu yuzden aşağıdakı operasyonları yazarız.
    public class SecurityKeyHelper
    {
        public static SecurityKey CreateSecurityKey(string securityKey)
        {
            return new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKey));
                
        }
    }
}
