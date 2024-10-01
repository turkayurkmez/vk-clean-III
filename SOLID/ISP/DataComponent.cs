using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    internal class DataComponent
    {
        public void  Search<T>(ISearchable<T> repository,string name) where T : class
        {
            repository.Search(name);
        }
    }
}
