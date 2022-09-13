using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.Encryption
{
    public class SigningCredentialsHelper
    {
        //Credentials== Bir sisteme girmek için elinizde olanlar.
        //Anahtar anlamına geliyor.
        public static SigningCredentials CreateSigningCredentials( SecurityKey securityKey)
        {
            return new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha512Signature);
        }
    }
}
