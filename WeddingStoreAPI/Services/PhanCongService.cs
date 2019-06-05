using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeddingStoreAPI.Models;
using WeddingStoreAPI.Context;
using WeddingStoreAPI.Interfaces;

namespace WeddingStoreAPI.Services
{
    public class PhanCongService : IDataService<PhanCongModel>
    {
        private readonly WeddingStoreContext _context;
        public PhanCongService(WeddingStoreContext context)
        {
            _context = context;
        }

        public void DeleteData(string id)
        {
            throw new NotImplementedException();
        }

        public List<PhanCongModel> GetData()
        {
            return _context.PhanCong.ToList();
        }

        public void InsertData(PhanCongModel obj)
        {
            _context.PhanCong.Add(obj);
            _context.SaveChanges();
        }

        public void MyDeleteData(PhanCongModel obj)
        {
            var myDelete = _context.PhanCong.FirstOrDefault(pc => pc.MaHD == obj.MaHD
                                                                    && pc.MaNV == obj.MaNV
                                                                    && pc.Ngay == obj.Ngay);
            if(myDelete!=null)
            {
                _context.PhanCong.Remove(myDelete);
                _context.SaveChanges();
            }
        }

        public void UpdateData(PhanCongModel obj)
        {
            var myUpdate = _context.PhanCong.FirstOrDefault(pc => pc.MaHD == obj.MaHD
                                                                    && pc.MaNV == obj.MaNV
                                                                    && pc.Ngay == obj.Ngay);
            if (myUpdate != null)
            {
                myUpdate.ThoiGianDen = obj.ThoiGianDen;
                myUpdate.ThoiGianDi = obj.ThoiGianDi;

                _context.PhanCong.Update(myUpdate);
                _context.SaveChanges();
            }
        }
    }
}
