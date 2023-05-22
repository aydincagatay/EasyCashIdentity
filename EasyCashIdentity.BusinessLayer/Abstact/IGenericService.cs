using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentity.BusinessLayer.Abstact
{
    public interface IGenericService<T> where T : class
    {
        Task TAddAsync(T entity);
        Task TUpdateAsync(T entity);
        Task TDeleteAsync(T entity);
        List<T> TGetAllAsync();
        T TGetByIdAsync(int id);
    }
}
