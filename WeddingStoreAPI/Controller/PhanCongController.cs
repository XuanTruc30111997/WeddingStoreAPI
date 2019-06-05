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
    public class PhanCongController : ControllerBase
    {
        private readonly IDataService<PhanCongModel> _phanCong;
        public PhanCongController(IDataService<PhanCongModel> phanCong)
        {
            _phanCong = phanCong;
        }

        [HttpGet]
        public IEnumerable<PhanCongModel> Get()
        {
            return _phanCong.GetData();
        }

        [HttpPost]
        public void Post(PhanCongModel phanCong)
        {
            _phanCong.InsertData(phanCong);
        }

        [HttpPut]
        public void Put(PhanCongModel phanCong)
        {
            _phanCong.UpdateData(phanCong);
        }

        [HttpDelete]
        public void Delete(PhanCongModel phanCong)
        {
            _phanCong.MyDeleteData(phanCong);
        }
    }
}
