using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeddingStoreAPI.Interfaces
{
    public interface IMyDataService<T>
    {
        void MyDeleteData(T obj);
    }
}
