using Core.Entities.Concrate;
using Core.EntityFramework;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public class EfUserOperationClaim: EfEntityRepositoryBase<UserOperationClaim,NorthwindContext>
    {
    }
}
