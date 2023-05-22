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
    public class CustomerAccountProcessManager : ICustomerAccountProcessService
    {
        private readonly ICustomerAccountProcessDal _customerAccountProcessDal;

        public CustomerAccountProcessManager(ICustomerAccountProcessDal customerAccountProcessDal)
        {
            _customerAccountProcessDal = customerAccountProcessDal;
        }

        public Task TAddAsync(CustomerAccountProcess entity)
        {
            return _customerAccountProcessDal.AddAsync(entity);
        }

        public Task TDeleteAsync(CustomerAccountProcess entity)
        {
            return _customerAccountProcessDal.DeleteAsync(entity);
        }

        public List<CustomerAccountProcess> TGetAllAsync()
        {
            return  _customerAccountProcessDal.GetAllAsync();
        }

        public CustomerAccountProcess TGetByIdAsync(int id)
        {
            return _customerAccountProcessDal.GetByIdAsync(id);
        }

        public Task TUpdateAsync(CustomerAccountProcess entity)
        {
            return _customerAccountProcessDal.UpdateAsync(entity);
        }
    }
}
