using KimDuc.Model.VatLieu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimDuc.Services
{
    public interface IVatLieuServices
    {
        Task<List<VatlieuGetResponse>> GetAll();
        Task<VatlieuGetResponse> GetById(int id);
        Task<VatLieuCreateResponse> CreateVatLieu(VatLieuCreateRequest request);
        Task<VatLieuUpdateResponse> UpdateVatLieu(VatLieuUpdateRequest request);
        Task<bool>DeleteValieu(int id);
    }
}
