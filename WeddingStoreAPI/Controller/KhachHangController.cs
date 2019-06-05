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
    public class KhachHangController : ControllerBase
    {
        private readonly IDataService<KhachHangModel> _khachHang;
        public KhachHangController(IDataService<KhachHangModel> khachHang)
        {
            _khachHang = khachHang;
        }

        [HttpGet]
        public IEnumerable<KhachHangModel> Get()
        {
            return _khachHang.GetData();
        }

        [HttpPost]
        public void Post(KhachHangModel khachHang)
        {
            _khachHang.InsertData(khachHang);
        }

        [HttpPut]
        public void Put(KhachHangModel khachHang)
        {
            _khachHang.UpdateData(khachHang);
        }

        [HttpDelete]
        public void Delete(KhachHangModel khachHang)
        {
            _khachHang.MyDeleteData(khachHang);
        }
    }
}
