using Core.Entities.Concrate;
using Core.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EfOperationClaimDal: EfEntityRepositoryBase<OperationClaim, NorthwindContext>,IOperationClaimDal
    {
    }
}
