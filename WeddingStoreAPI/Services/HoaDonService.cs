using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeddingStoreAPI.Models;
using WeddingStoreAPI.Context;
using WeddingStoreAPI.Interfaces;

namespace WeddingStoreAPI.Services
{
    public class HoaDonService : IDataService<HoaDonModel>
    {
        private readonly WeddingStoreContext _context;
        public HoaDonService(WeddingStoreContext context)
        {
            _context = context;
        }

        public void DeleteData(string id)
        {
            throw new NotImplementedException();
        }

        public List<HoaDonModel> GetData()
        {
            return _context.HoaDon.ToList();
        }

        public void InsertData(HoaDonModel obj)
        {
            _context.HoaDon.Add(obj);
            _context.SaveChanges();
        }

        public void MyDeleteData(HoaDonModel obj)
        {
            var myDelete = _context.HoaDon.FirstOrDefault(hd => hd.MaHD == obj.MaHD
                                                              && hd.MaKH == obj.MaKH);
            if (myDelete != null)
            {
                _context.HoaDon.Remove(myDelete);
                _context.SaveChanges();
            }
        }

        public void UpdateData(HoaDonModel obj)
        {
            var myUpdate = _context.HoaDon.FirstOrDefault(hd => hd.MaHD == obj.MaHD
                                                              && hd.MaKH == obj.MaKH);
            if (myUpdate != null)
            {
                myUpdate.NgayLap = obj.NgayLap;
                myUpdate.NgayThaoDo = obj.NgayThaoDo;
                myUpdate.NgayTrangTri = obj.NgayTrangTri;
                myUpdate.TongTien = obj.TongTien;
                myUpdate.TinhTrang = obj.TinhTrang;
                myUpdate.TienCoc = obj.TienCoc;
                myUpdate.IsThanhToan = obj.IsThanhToan;

                _context.HoaDon.Update(myUpdate);
                _context.SaveChanges();
            }
        }
    }
}
