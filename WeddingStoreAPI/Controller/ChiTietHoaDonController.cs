using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeddingStoreAPI.Models;
using WeddingStoreAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using WeddingStoreAPI.Hubs;

namespace WeddingStoreAPI.Controller
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ChiTietHoaDonController : ControllerBase
    {
        private readonly IDataService<ChiTietHoaDonModel> _chiTietHoaDon;
        IHubContext<MessagesHub> Hub;
        public ChiTietHoaDonController(IDataService<ChiTietHoaDonModel> chiTietHoaDon,IHubContext<MessagesHub> hub)
        {
            _chiTietHoaDon = chiTietHoaDon;
            Hub = hub;
        }

        [HttpGet]
        public IEnumerable<ChiTietHoaDonModel> Get()
        {
            return _chiTietHoaDon.GetData();
        }

        [HttpPost]
        public void Post(ChiTietHoaDonModel chiTietHoaDon)
        {
            _chiTietHoaDon.InsertData(chiTietHoaDon);
        }

        [HttpPost]
        public async Task<IActionResult> PostSignalR(ChiTietHoaDonModel chiTietHoaDon)
        {
            try
            {
                _chiTietHoaDon.InsertData(chiTietHoaDon);
                await Hub.Clients.All.SendAsync("NewChiTiet", chiTietHoaDon);
            }
            catch (Exception ex)
            {
                return BadRequest("Error while creating");
            }
            return Ok(chiTietHoaDon);
        }

        [HttpPut]
        public void Put(ChiTietHoaDonModel chiTietHoaDon)
        {
            _chiTietHoaDon.UpdateData(chiTietHoaDon);
        }

        [HttpDelete]
        public void Delete(ChiTietHoaDonModel chiTietHoaDon)
        {
            _chiTietHoaDon.MyDeleteData(chiTietHoaDon);
        }
    }
}
