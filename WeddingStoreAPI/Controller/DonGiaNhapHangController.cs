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
    public class DonGiaNhapHangController : ControllerBase
    {
        private readonly IDataService<DonGiaNhapHangModel> _donGiaNhapHang;
        public DonGiaNhapHangController(IDataService<DonGiaNhapHangModel> donGiaNhapHang)
        {
            _donGiaNhapHang = donGiaNhapHang;
        }

        [HttpGet]
        public IEnumerable<DonGiaNhapHangModel> Get()
        {
            return _donGiaNhapHang.GetData();
        }

        [HttpPost]
        public void Post(DonGiaNhapHangModel donGiaNhapHang)
        {
            _donGiaNhapHang.InsertData(donGiaNhapHang);
        }

        [HttpPut]
        public void Put(DonGiaNhapHangModel donGiaNhapHang)
        {
            _donGiaNhapHang.UpdateData(donGiaNhapHang);
        }

        [HttpDelete]
        public void Delete (DonGiaNhapHangModel donGiaNhapHang)
        {
            _donGiaNhapHang.MyDeleteData(donGiaNhapHang);
        }
    }
}
