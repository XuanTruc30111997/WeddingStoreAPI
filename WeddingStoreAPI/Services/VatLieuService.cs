using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using WeddingStoreAPI.Interfaces;
using WeddingStoreAPI.Models;
using WeddingStoreAPI.Context;

namespace WeddingStoreAPI.Services
{
    public class VatLieuService : IDataService<VatLieuModel>
    {
        private readonly WeddingStoreContext _context;
        public VatLieuService(WeddingStoreContext context)
        {
            _context = context;
        }

        public void DeleteData(string id)
        {
            var myDelete = _context.KhoVatLieu.Find(id);

            if (myDelete != null)
            {
                _context.KhoVatLieu.Remove(myDelete);
                _context.SaveChanges();
            }
        }

        public List<VatLieuModel> GetData()
        {
            return _context.KhoVatLieu.ToList();
        }

        public void InsertData(VatLieuModel obj)
        {
            _context.KhoVatLieu.Add(obj);
            _context.SaveChanges();
        }

        public void MyDeleteData(VatLieuModel obj)
        {
            var myDelete = _context.KhoVatLieu.Find(obj.MaVL);

            if (myDelete != null)
            {
                _context.KhoVatLieu.Remove(myDelete);
                _context.SaveChanges();
            }
        }

        public void UpdateData(VatLieuModel obj)
        {
            var myUpdate = _context.KhoVatLieu.Find(obj.MaVL);
            if (myUpdate != null)
            {
                myUpdate.TenVL = obj.TenVL;
                myUpdate.SoLuongTon = obj.SoLuongTon;
                myUpdate.GiaTien = obj.GiaTien;
                myUpdate.DonVi = obj.DonVi;
                myUpdate.AnhMoTa = obj.AnhMoTa;
                myUpdate.IsNhap = obj.IsNhap;

                _context.KhoVatLieu.Update(myUpdate);
                _context.SaveChanges();
            }
        }
    }
}
