using Core.Entities.Concrate;
using Core.Utilities.Result.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public  interface IOperationClaimService
    {
        IDataResult<List<OperationClaim>> GetAll();
        IDataResult<OperationClaim> Get(User user); 
    }
}
