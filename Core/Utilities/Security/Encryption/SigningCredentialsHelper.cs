using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Encryption
{
    //web api de JWT olusturulabılmesı için
    public class SigningCredentialsHelper
    {
        public static SigningCredentials CreateSigningCredentials(SecurityKey security)
        {
            //hangi anahtar hangi doğrulamayı kullanacak onu belirtiyoruz.
            return new SigningCredentials(security, SecurityAlgorithms.HmacSha512Signature);
        }
    }
}
