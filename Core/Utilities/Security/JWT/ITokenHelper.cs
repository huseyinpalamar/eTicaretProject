using Core.Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.JWT
{
    public  interface ITokenHelper
    {
        // veri tabanına gidip kullanıcı için onun sahip olduğu claimleri kullanarak
        // token üretme işlemi
        AccessToken CreateToken(User user,List<OperationClaim> operationClaims);
    }
}
