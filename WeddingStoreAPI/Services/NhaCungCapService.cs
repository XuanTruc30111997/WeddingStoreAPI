using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeddingStoreAPI.Models;
using WeddingStoreAPI.Context;
using WeddingStoreAPI.Interfaces;

namespace WeddingStoreAPI.Services
{
    public class NhaCungCapService : IDataService<NhaCungCapModel>
    {
        private readonly WeddingStoreContext _context;
        public NhaCungCapService(WeddingStoreContext context)
        {
            _context = context;
        }

        public void DeleteData(string id)
        {
            throw new NotImplementedException();
        }

        public List<NhaCungCapModel> GetData()
        {
            return _context.NhaCungCap.ToList();
        }

        public void InsertData(NhaCungCapModel obj)
        {
            _context.NhaCungCap.Add(obj);
            _context.SaveChanges();
        }

        public void MyDeleteData(NhaCungCapModel obj)
        {
            var myDelete = _context.NhaCungCap.FirstOrDefault(ncc => ncc.MaNCC==obj.MaNCC);
            if(myDelete!=null)
            {
                _context.NhaCungCap.Remove(myDelete);
                _context.SaveChanges();
            }
        }

        public void UpdateData(NhaCungCapModel obj)
        {
            var myUpdate = _context.NhaCungCap.FirstOrDefault(ncc => ncc.MaNCC == obj.MaNCC);
            if (myUpdate != null)
            {
                myUpdate.TenNCC = obj.TenNCC;
                myUpdate.SoDT = obj.SoDT;
                myUpdate.DiaChi = obj.DiaChi;

                _context.NhaCungCap.Update(myUpdate);
                _context.SaveChanges();
            }
        }
    }
}
