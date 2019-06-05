using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using WeddingStoreAPI.Models;
using WeddingStoreAPI.Interfaces;

namespace WeddingStoreAPI.Controller
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class VatLieuController : ControllerBase
    {
        private IDataService<VatLieuModel> _vatLieu;
        public VatLieuController(IDataService<VatLieuModel> vatLieu)
        {
            _vatLieu = vatLieu;
        }

        [HttpGet]
        public IEnumerable<VatLieuModel> Get()
        {
            return _vatLieu.GetData();
        }

        [HttpPost]
        public void Post(VatLieuModel vatLieu)
        {
            _vatLieu.InsertData(vatLieu);
        }

        [HttpPut]
        public void Put(VatLieuModel vatLieu)
        {
            _vatLieu.UpdateData(vatLieu);
        }

        [HttpDelete]
        public void Delete(VatLieuModel vatLieu)
        {
            _vatLieu.MyDeleteData(vatLieu);
        }
    }
}
