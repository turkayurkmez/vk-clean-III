using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    public interface ISearchable<T> where T : class
    {
        public IList<T> Search(string name);
    }
}
