using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeddingStoreAPI.Models;
using WeddingStoreAPI.Context;
using WeddingStoreAPI.Interfaces;

namespace WeddingStoreAPI.Services
{
    public class PhatSinhService : IDataService<PhatSinhModel>
    {
        private readonly WeddingStoreContext _context;
        public PhatSinhService(WeddingStoreContext context)
        {
            _context = context;
        }

        public void DeleteData(string id)
        {
            throw new NotImplementedException();
        }

        public List<PhatSinhModel> GetData()
        {
            return _context.PhatSinh.ToList();
        }

        public void InsertData(PhatSinhModel obj)
        {
            _context.PhatSinh.Add(obj);
            _context.SaveChanges();
        }

        public void MyDeleteData(PhatSinhModel obj)
        {
            var myDelete = _context.PhatSinh.FirstOrDefault(ps => ps.MaHD == obj.MaHD && ps.MaVL == obj.MaVL);
            if(myDelete!=null)
            {
                _context.PhatSinh.Remove(myDelete);
                _context.SaveChanges();
            }
        }

        public void UpdateData(PhatSinhModel obj)
        {
            var myUpdate = _context.PhatSinh.FirstOrDefault(ps => ps.MaHD == obj.MaHD && ps.MaVL == obj.MaVL);
            if(myUpdate!=null)
            {
                myUpdate.SoLuong = obj.SoLuong;
                myUpdate.ThanhTien = obj.ThanhTien;

                _context.PhatSinh.Update(myUpdate);
                _context.SaveChanges();
            }
        }
    }
}
