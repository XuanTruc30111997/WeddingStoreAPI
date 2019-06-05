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
    public class LoaiDichVuController : ControllerBase
    {
        private readonly IDataService<LoaiDichVuModel> _loaiDichVu;
        public LoaiDichVuController(IDataService<LoaiDichVuModel> loaiDichVu)
        {
            _loaiDichVu = loaiDichVu;
        }

        [HttpGet]
        public IEnumerable<LoaiDichVuModel> Get()
        {
            return _loaiDichVu.GetData();
        }

        [HttpPost]
        public void Post(LoaiDichVuModel loaiDichVu)
        {
            _loaiDichVu.InsertData(loaiDichVu);
        }

        [HttpPut]
        public void Put(LoaiDichVuModel loaiDichVu)
        {
            _loaiDichVu.UpdateData(loaiDichVu);
        }

        [HttpDelete]
        public void Delete(LoaiDichVuModel loaiDichVu)
        {
            _loaiDichVu.MyDeleteData(loaiDichVu);
        }
    }
}
