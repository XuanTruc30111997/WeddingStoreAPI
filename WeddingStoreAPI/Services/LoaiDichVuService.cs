using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeddingStoreAPI.Models;
using WeddingStoreAPI.Context;
using WeddingStoreAPI.Interfaces;

namespace WeddingStoreAPI.Services
{
    public class LoaiDichVuService : IDataService<LoaiDichVuModel>
    {
        private readonly WeddingStoreContext _context;
        public LoaiDichVuService(WeddingStoreContext context)
        {
            _context = context;
        }

        public void DeleteData(string id)
        {
            var myDelete = _context.LoaiDichVu.Find(id);
            if (myDelete != null)
            {
                _context.LoaiDichVu.Remove(myDelete);
                _context.SaveChanges();
            }
        }

        public List<LoaiDichVuModel> GetData()
        {
            return _context.LoaiDichVu.ToList();
        }

        public void InsertData(LoaiDichVuModel obj)
        {
            _context.LoaiDichVu.Add(obj);
            _context.SaveChanges();
        }

        public void MyDeleteData(LoaiDichVuModel obj)
        {
            var myDelete = _context.LoaiDichVu.Find(obj.MaLoaiDV);
            if(myDelete!=null)
            {
                _context.LoaiDichVu.Remove(myDelete);
                _context.SaveChanges();
            }
        }

        public void UpdateData(LoaiDichVuModel obj)
        {
            var myUpdate = _context.LoaiDichVu.Find(obj.MaLoaiDV);
            if (myUpdate != null)
            {
                myUpdate.TenLoaiDV = obj.TenLoaiDV;

                _context.LoaiDichVu.Update(myUpdate);
                _context.SaveChanges();
            }
        }
    }
}
