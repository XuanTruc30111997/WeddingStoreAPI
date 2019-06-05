using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using WeddingStoreAPI.Models;
using WeddingStoreAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WeddingStoreAPI.Controller
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class NhanVienController : ControllerBase
    {
        private readonly IDataService<NhanVienModel> _nhanVien;
        public NhanVienController(IDataService<NhanVienModel> nhanVien)
        {
            _nhanVien = nhanVien;
        }

        [HttpGet]
        public IEnumerable<NhanVienModel> Get()
        {
            return _nhanVien.GetData();
        }

        [HttpPost]
        public void Post(NhanVienModel nhanVien)
        {
            _nhanVien.InsertData(nhanVien);
        }

        [HttpPut]
        public void Put(NhanVienModel nhanVien)
        {
            _nhanVien.UpdateData(nhanVien);
        }

        [HttpDelete]
        public void Delete(NhanVienModel nhanVien)
        {
            _nhanVien.MyDeleteData(nhanVien);
        }
    }
}
