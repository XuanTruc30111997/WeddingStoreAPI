using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using WeddingStoreAPI.Models;
using WeddingStoreAPI.Interfaces;
using WeddingStoreAPI.Context;

namespace WeddingStoreAPI.Controller
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PhatSinhController : ControllerBase
    {
        private readonly IDataService<PhatSinhModel> _phatSinh;
        public PhatSinhController(IDataService<PhatSinhModel> phatSinh)
        {
            _phatSinh = phatSinh;
        }

        [HttpGet]
        public IEnumerable<PhatSinhModel> Get()
        {
            return _phatSinh.GetData();
        }

        [HttpPost]
        public void Post(PhatSinhModel phatSinh)
        {
            _phatSinh.InsertData(phatSinh);
        }

        [HttpPut]
        public void Put(PhatSinhModel phatSinh)
        {
            _phatSinh.UpdateData(phatSinh);
        }

        [HttpDelete]
        public void Delete(PhatSinhModel phatSinh)
        {
            _phatSinh.MyDeleteData(phatSinh);
        }
    }
}
