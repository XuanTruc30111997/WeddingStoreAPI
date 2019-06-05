using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeddingStoreAPI.Models;
using WeddingStoreAPI.Context;
using WeddingStoreAPI.Interfaces;

namespace WeddingStoreAPI.Services
{
    public class NhanVienService : IDataService<NhanVienModel>
    {
        private readonly WeddingStoreContext _context;
        public NhanVienService(WeddingStoreContext context)
        {
            _context = context;
        }

        public void DeleteData(string id)
        {
            var myDelete = _context.NhanVien.Find(id);
            if(myDelete!=null)
            {
                _context.NhanVien.Remove(myDelete);
                _context.SaveChanges();
            }
        }

        public List<NhanVienModel> GetData()
        {
            return _context.NhanVien.ToList();
        }

        public void InsertData(NhanVienModel obj)
        {
            _context.NhanVien.Add(obj);
            _context.SaveChanges();
        }

        public void MyDeleteData(NhanVienModel obj)
        {
            var myDelete = _context.NhanVien.Find(obj.MaNV);
            if (myDelete != null)
            {
                _context.NhanVien.Remove(myDelete);
                _context.SaveChanges();
            }
        }

        public void UpdateData(NhanVienModel obj)
        {
            var myUpdate = _context.NhanVien.Find(obj.MaNV);
            if(myUpdate!=null)
            {
                myUpdate.TenNV = obj.TenNV;
                myUpdate.GioiTinh = obj.GioiTinh;
                myUpdate.SoDT = obj.SoDT;
                myUpdate.DiaChi = obj.DiaChi;
                myUpdate.NgaySinh = obj.NgaySinh;
                myUpdate.Luong = obj.Luong;
                myUpdate.Avatar = obj.Avatar;

                _context.NhanVien.Update(myUpdate);
                _context.SaveChanges();
            }
        }
    }
}
