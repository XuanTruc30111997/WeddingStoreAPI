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
    public class HoaDonController : ControllerBase
    {
        private readonly IDataService<HoaDonModel> _hoaDon;
        public HoaDonController(IDataService<HoaDonModel> hoaDon)
        {
            _hoaDon = hoaDon;
        }

        [HttpGet]
        public IEnumerable<HoaDonModel> Get()
        {
            return _hoaDon.GetData();
        }

        [HttpPost]
        public void Post(HoaDonModel hoaDon)
        {
            _hoaDon.InsertData(hoaDon);
        }

        [HttpPut]
        public void Put(HoaDonModel hoaDon)
        {
            _hoaDon.UpdateData(hoaDon);
        }

        [HttpDelete]
        public void Delete(HoaDonModel hoaDon)
        {
            _hoaDon.MyDeleteData(hoaDon);
        }
    }
}
