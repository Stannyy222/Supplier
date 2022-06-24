using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huerto___ENTPROG___OTIS1.Repository
{
    public interface IGenericRepo<T> where T : class
{
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task DeleteAsync(int id);
        Task<List<T>> GetAllAsync();
        Task<List<T>> GetAsync(int id);
        Task<bool> Exists(int id);
}
}
