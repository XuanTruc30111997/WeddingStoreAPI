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
    public class TaiKhoanController : ControllerBase
    {
        private readonly IDataService<TaiKhoanModel> _taiKhoan;
        public TaiKhoanController(IDataService<TaiKhoanModel> taiKhoan)
        {
            _taiKhoan = taiKhoan;
        }

        [HttpGet]
        public IEnumerable<TaiKhoanModel> Get()
        {
            return _taiKhoan.GetData();
        }

        [HttpPost]
        public void Post(TaiKhoanModel taiKhoan)
        {
            _taiKhoan.InsertData(taiKhoan);
        }

        [HttpPut]
        public void Put(TaiKhoanModel taiKhoan)
        {
            _taiKhoan.UpdateData(taiKhoan);
        }

        [HttpDelete]
        public void Delete(TaiKhoanModel taiKhoan)
        {
            _taiKhoan.MyDeleteData(taiKhoan);
        }
    }
}
