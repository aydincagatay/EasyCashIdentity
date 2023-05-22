using EasyCashIdentity.BusinessLayer.Abstact;
using EasyCashIdentity.DataAccessLayer.Abstract;
using EasyCashIdentity.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentity.BusinessLayer.Concrete
{
    public class CustomerAccountManager : ICustomerAccountService
    {

        private readonly ICustomerAccountDal _customerAccountDal;

        public CustomerAccountManager(ICustomerAccountDal customerAccountDal)
        {
            _customerAccountDal = customerAccountDal;
        }

        public Task TAddAsync(CustomerAccount entity)
        {
            return _customerAccountDal.AddAsync(entity);
        }

        public Task TDeleteAsync(CustomerAccount entity)
        {
            return _customerAccountDal.DeleteAsync(entity);
        }

        public List<CustomerAccount> TGetAllAsync()
        {
            return _customerAccountDal.GetAllAsync();
        }

        public CustomerAccount TGetByIdAsync(int id)
        {
            return _customerAccountDal.GetByIdAsync(id);
        }

        public Task TUpdateAsync(CustomerAccount entity)
        {
            return _customerAccountDal.UpdateAsync(entity);
        }
    }
}
