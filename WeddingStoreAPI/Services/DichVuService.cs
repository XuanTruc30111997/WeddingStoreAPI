using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeddingStoreAPI.Models;
using WeddingStoreAPI.Context;
using WeddingStoreAPI.Interfaces;

namespace WeddingStoreAPI.Services
{
    public class DichVuService : IDataService<DichVuModel>
    {
        private readonly WeddingStoreContext _context;
        public DichVuService(WeddingStoreContext context)
        {
            _context = context;
        }

        public void DeleteData(string id)
        {
            var myDelete = _context.DichVu.Find(id);
            if (myDelete != null)
            {
                _context.DichVu.Remove(myDelete);
                _context.SaveChanges();
            }
        }

        public List<DichVuModel> GetData()
        {
            return _context.DichVu.ToList();
        }

        public void InsertData(DichVuModel obj)
        {
            _context.DichVu.Add(obj);
            _context.SaveChanges();
        }

        public void MyDeleteData(DichVuModel obj)
        {
            var myDelete= _context.DichVu.FirstOrDefault(dv => dv.MaDV == obj.MaDV);
            if(myDelete!=null)
            {
                _context.DichVu.Remove(myDelete);
                _context.SaveChanges();
            }
        }

        public void UpdateData(DichVuModel obj)
        {
            var myUpdate = _context.DichVu.FirstOrDefault(dv => dv.MaDV == obj.MaDV);
            if (myUpdate != null)
            {
                myUpdate.TenDV = obj.TenDV;
                myUpdate.LoaiDV = obj.LoaiDV;

                _context.DichVu.Update(myUpdate);
                _context.SaveChanges();
            }
        }
    }
}
