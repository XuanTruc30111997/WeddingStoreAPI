using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeddingStoreAPI.Models;
using WeddingStoreAPI.Context;
using WeddingStoreAPI.Interfaces;

namespace WeddingStoreAPI.Services
{
    public class DonGiaNhapHangService : IDataService<DonGiaNhapHangModel>
    {
        private readonly WeddingStoreContext _context;
        public DonGiaNhapHangService(WeddingStoreContext context)
        {
            _context = context;
        }

        public void DeleteData(string id)
        {
            throw new NotImplementedException();
        }

        public List<DonGiaNhapHangModel> GetData()
        {
            return _context.DonGiaNhapHang.ToList();
        }

        public void InsertData(DonGiaNhapHangModel obj)
        {
            _context.DonGiaNhapHang.Add(obj);
            _context.SaveChanges();
        }

        public void MyDeleteData(DonGiaNhapHangModel obj)
        {
            var myDelete = _context.DonGiaNhapHang.FirstOrDefault(dg => dg.MaDG == obj.MaDG && dg.MaNCC == obj.MaNCC);
            if (myDelete != null)
            {
                _context.DonGiaNhapHang.Remove(myDelete);
                _context.SaveChanges();
            }
        }

        public void UpdateData(DonGiaNhapHangModel obj)
        {
            var myUpdate = _context.DonGiaNhapHang.FirstOrDefault(dg => dg.MaDG == obj.MaDG && dg.MaNCC == obj.MaNCC);
            if (myUpdate != null)
            {
                myUpdate.NgayLap = obj.NgayLap;
                myUpdate.TongTien = obj.TongTien;

                _context.DonGiaNhapHang.Update(myUpdate);
                _context.SaveChanges();
            }
        }
    }
}
