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
    public class NhaCungCapController : ControllerBase
    {
        private readonly IDataService<NhaCungCapModel> _nhaCungCap;
        public NhaCungCapController(IDataService<NhaCungCapModel> nhaCungCap)
        {
            _nhaCungCap = nhaCungCap;
        }

        [HttpGet]
        public IEnumerable<NhaCungCapModel> Get()
        {
            return _nhaCungCap.GetData();
        }

        [HttpPost]
        public void Post(NhaCungCapModel nhaCungCap)
        {
            _nhaCungCap.InsertData(nhaCungCap);
        }

        [HttpPut]
        public void Put(NhaCungCapModel nhaCungCap)
        {
            _nhaCungCap.UpdateData(nhaCungCap);
        }

        [HttpDelete]
        public void Delete(NhaCungCapModel nhaCungCap)
        {
            _nhaCungCap.MyDeleteData(nhaCungCap);
        }
    }
}
