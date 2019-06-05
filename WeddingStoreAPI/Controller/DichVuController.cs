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
    public class DichVuController : ControllerBase
    {
        private readonly IDataService<DichVuModel> _dichVu;
        public DichVuController(IDataService<DichVuModel> dichVu)
        {
            _dichVu = dichVu;
        }

        [HttpGet]
        public IEnumerable<DichVuModel> Get()
        {
            return _dichVu.GetData();
        }

        [HttpPost]
        public void Post(DichVuModel dichVu)
        {
            _dichVu.InsertData(dichVu);
        }

        [HttpPut]
        public void Put(DichVuModel dichVu)
        {
            _dichVu.UpdateData(dichVu);
        }

        [HttpDelete]
        public void Delete(DichVuModel dichVu)
        {
            _dichVu.MyDeleteData(dichVu);
        }
    }
}
