using paymentSystemAPI.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paymentSystemAPI.Application.Interfaces.IServices
{
    public interface IMerchant
    {
        Task<MerchantDTO> GetMerchantByPhoneNumberAsync(int phonenumber);
        Task<IEnumerable<MerchantDTO>> GetAllMerchantAsync();
        Task<bool> AddMerchantAsync(MerchantDTO merchantdto);
        Task UpdateMerchantAsync(int phonenumber, MerchantDTO merchantdto);
        Task DeleteMerchant(int phonenumber);
    }
}
