using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeddingStoreAPI.Models;

namespace WeddingStoreAPI.Interfaces
{
    public interface IVatLieuService
    {
        List<VatLieuModel> GetTenItems(int num);
    }
}
