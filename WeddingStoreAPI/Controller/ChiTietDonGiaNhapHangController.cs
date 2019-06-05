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
    public class ChiTietDonGiaNhapHangController : ControllerBase
    {
        private readonly IDataService<ChiTietDonGiaNhapHangModel> _chiTietDonGiaNhapHang;
        public ChiTietDonGiaNhapHangController(IDataService<ChiTietDonGiaNhapHangModel> chiTietDonGiaNhapHang)
        {
            _chiTietDonGiaNhapHang = chiTietDonGiaNhapHang;
        }

        [HttpGet]
        public IEnumerable<ChiTietDonGiaNhapHangModel> Get()
        {
            return _chiTietDonGiaNhapHang.GetData();
        }

        [HttpPost]
        public void Post(ChiTietDonGiaNhapHangModel chiTietDGNhapHang)
        {
            _chiTietDonGiaNhapHang.InsertData(chiTietDGNhapHang);
        }

        [HttpPut]
        public void Put(ChiTietDonGiaNhapHangModel chiTietDGNhapHang)
        {
            _chiTietDonGiaNhapHang.UpdateData(chiTietDGNhapHang);
        }

        [HttpDelete]
        public void Delete(ChiTietDonGiaNhapHangModel chiTietDGNhapHang)
        {
            _chiTietDonGiaNhapHang.MyDeleteData(chiTietDGNhapHang);
        }
    }
}
