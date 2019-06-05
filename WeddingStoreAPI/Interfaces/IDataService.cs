using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeddingStoreAPI.Interfaces
{
    public interface IDataService<T>
    {
        List<T> GetData();
        void InsertData(T obj);
        void UpdateData(T obj);
        void DeleteData(string id);
        void MyDeleteData(T obj);
    }
}
