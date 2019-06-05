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
    public class ChiTietSanPhamController : ControllerBase
    {
        private readonly IDataService<ChiTietSanPhamModel> _chiTietSanPham;
        public ChiTietSanPhamController(IDataService<ChiTietSanPhamModel> chiTietSanPham)
        {
            _chiTietSanPham = chiTietSanPham;
        }

        [HttpGet]
        public IEnumerable<ChiTietSanPhamModel> Get()
        {
            return _chiTietSanPham.GetData();
        }

        [HttpPost]
        public void Post(ChiTietSanPhamModel chiTietSanPham)
        {
            _chiTietSanPham.InsertData(chiTietSanPham);
        }

        [HttpPut]
        public void Put(ChiTietSanPhamModel chiTietSanPham)
        {
            _chiTietSanPham.UpdateData(chiTietSanPham);
        }

        [HttpDelete]
        public void Delete(ChiTietSanPhamModel chiTietSanPham)
        {
            _chiTietSanPham.MyDeleteData(chiTietSanPham);
        }
    }
}
