using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    public interface IRepository<T> where T : class
    {
        T Get(int id);
        IList<T> GetAll();

       // IList<T> SearchByName(string name);

        void Create(T entity);
        void Update(T entity);
        void Delete(int id);




    }
}
