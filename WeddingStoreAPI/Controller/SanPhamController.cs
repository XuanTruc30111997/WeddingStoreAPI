using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using WeddingStoreAPI.Services;
using WeddingStoreAPI.Models;
using WeddingStoreAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WeddingStoreAPI.Controller
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SanPhamController : ControllerBase
    {
        private IDataService<SanPhamModel> _sanPham;
        public SanPhamController(IDataService<SanPhamModel> sanPham)
        {
            _sanPham = sanPham;
        }

        [HttpGet]
        public IEnumerable<SanPhamModel> Get()
        {
            return _sanPham.GetData();
        }

        [HttpPost]
        public void Post(SanPhamModel sanPham)
        {
            _sanPham.InsertData(sanPham);
        }

        [HttpPut]
        public void Put(SanPhamModel sanPham)
        {
            _sanPham.UpdateData(sanPham);
        }

        [HttpDelete]
        public void Delete(SanPhamModel sanPham)
        {
            _sanPham.MyDeleteData(sanPham);
        }
    }
}
