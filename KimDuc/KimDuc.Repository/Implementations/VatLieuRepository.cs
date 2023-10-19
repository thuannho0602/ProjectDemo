using KimDuc.DataAccess;
using KimDuc.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimDuc.Repository.Implementations
{
    public class VatLieuRepository:RepositoryBase<VatLieu, ApplicationDbContex>,IVatLieuRepository
    {
        public VatLieuRepository(ApplicationDbContex contex) : base(contex)
        {

        }
    }
}
