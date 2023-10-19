using KimDuc.DataAccess;
using KimDuc.Entity;
using KimDuc.Model.VatLieu;
using KimDuc.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimDuc.Services.Implementations
{
    public class VatLieuServices : IVatLieuServices
    {
        private IVatLieuRepository _vatLieuRepository;
        private ApplicationDbContex _appContext;

        public async Task<VatLieuCreateResponse> CreateVatLieu(VatLieuCreateRequest request)
        {
            if (request.Id == 0)
            {
                var vatLieu = new VatLieu
                {
                    Name=request.Name,
                };
                _vatLieuRepository.Add(vatLieu);
                _vatLieuRepository.SaveChanges();

                var vatLieuRespose = new VatLieuCreateResponse
                {
                    Id = vatLieu.Id,
                    Name = vatLieu.Name
                };
                return await Task.FromResult(vatLieuRespose);
            }
            else
            {
                return new VatLieuCreateResponse();
            }

        }

        public Task<bool> DeleteValieu(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<VatlieuGetResponse>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<VatlieuGetResponse> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<VatLieuUpdateResponse> UpdateVatLieu(VatLieuUpdateRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
