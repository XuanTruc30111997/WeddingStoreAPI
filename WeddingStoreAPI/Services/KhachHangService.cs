using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeddingStoreAPI.Models;
using WeddingStoreAPI.Context;
using WeddingStoreAPI.Interfaces;

namespace WeddingStoreAPI.Services
{
    public class KhachHangService : IDataService<KhachHangModel>
    {
        private readonly WeddingStoreContext _context;
        public KhachHangService(WeddingStoreContext context)
        {
            _context = context;
        }

        public void DeleteData(string id)
        {
            var myDelete = _context.KhachHang.Find(id);
            if (myDelete != null)
            {
                _context.KhachHang.Remove(myDelete);
                _context.SaveChanges();
            }
        }

        public List<KhachHangModel> GetData()
        {
            return _context.KhachHang.ToList();
        }

        public void InsertData(KhachHangModel obj)
        {
            _context.KhachHang.Add(obj);
            _context.SaveChanges();
        }

        public void MyDeleteData(KhachHangModel obj)
        {
            var myDelete = _context.KhachHang.Find(obj.MaKH);
            if(myDelete!=null)
            {
                _context.KhachHang.Remove(myDelete);
                _context.SaveChanges();
            }
        }

        public void UpdateData(KhachHangModel obj)
        {
            var myUpdate = _context.KhachHang.Find(obj.MaKH);
            if (myUpdate != null)
            {
                myUpdate.TenKH = obj.TenKH;
                myUpdate.SoDT = obj.SoDT;
                myUpdate.DiaChi = obj.DiaChi;

                _context.KhachHang.Update(myUpdate);
                _context.SaveChanges();
            }
        }
    }
}
