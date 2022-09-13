using Business.Abstract;
using Business.Constants;
using Core.Entities.Concrate;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrate;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class OperationClaimManager : IOperationClaimService
    {
        IOperationClaimDal _operationDal;

        public OperationClaimManager(IOperationClaimDal operationDal)
        {
            _operationDal = operationDal;
        }

        public IDataResult<OperationClaim> Get(User user)
        {
            return new SuccessDataResult<OperationClaim>(_operationDal.Get(o=>o.Id== user.Id));
        }

        public IDataResult<List<OperationClaim>> GetAll()
        {
            return new SuccessDataResult<List<OperationClaim>>(_operationDal.GetAll(),Messages.ListingSuccessful);
        }
    }
}
