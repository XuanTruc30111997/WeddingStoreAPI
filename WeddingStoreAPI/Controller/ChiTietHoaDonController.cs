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
    public class ChiTietHoaDonController : ControllerBase
    {
        private readonly IDataService<ChiTietHoaDonModel> _chiTietHoaDon;
        public ChiTietHoaDonController(IDataService<ChiTietHoaDonModel> chiTietHoaDon)
        {
            _chiTietHoaDon = chiTietHoaDon;
        }

        [HttpGet]
        public IEnumerable<ChiTietHoaDonModel> Get()
        {
            return _chiTietHoaDon.GetData();
        }

        [HttpPost]
        public void Post(ChiTietHoaDonModel chiTietHoaDon)
        {
            _chiTietHoaDon.InsertData(chiTietHoaDon);
        }

        [HttpPut]
        public void Put(ChiTietHoaDonModel chiTietHoaDon)
        {
            _chiTietHoaDon.UpdateData(chiTietHoaDon);
        }

        [HttpDelete]
        public void Delete(ChiTietHoaDonModel chiTietHoaDon)
        {
            _chiTietHoaDon.MyDeleteData(chiTietHoaDon);
        }
    }
}
