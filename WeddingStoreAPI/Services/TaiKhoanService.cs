using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeddingStoreAPI.Context;
using WeddingStoreAPI.Interfaces;
using WeddingStoreAPI.Models;

namespace WeddingStoreAPI.Services
{
    public class TaiKhoanService : IDataService<TaiKhoanModel>
    {
        private readonly WeddingStoreContext _context;
        public TaiKhoanService(WeddingStoreContext context)
        {
            _context = context;
        }

        public void DeleteData(string id)
        {
            throw new NotImplementedException();
        }

        public List<TaiKhoanModel> GetData()
        {
            return _context.TaiKhoan.ToList();
        }

        public void InsertData(TaiKhoanModel obj)
        {
            _context.TaiKhoan.Add(obj);
            _context.SaveChanges();
        }

        public void MyDeleteData(TaiKhoanModel obj)
        {
            var myDelete = _context.TaiKhoan.FirstOrDefault(tk => tk.MaNV == obj.MaNV);
            if (myDelete != null)
            {
                _context.TaiKhoan.Remove(myDelete);
                _context.SaveChanges();
            }
        }

        public void UpdateData(TaiKhoanModel obj)
        {
            var myUpdate = _context.TaiKhoan.FirstOrDefault(tk => tk.MaNV == obj.MaNV);
            if (myUpdate != null)
            {
                myUpdate.UserName = obj.UserName;
                myUpdate.PassWord = obj.PassWord;

                _context.TaiKhoan.Update(myUpdate);
                _context.SaveChanges();
            }
        }
    }
}
