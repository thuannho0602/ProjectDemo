using KimDuc.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace KimDuc.DataAccess
{
    public class ApplicationDbContex:IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContex(DbContextOptions <ApplicationDbContex> context) : base(context)
        {

        }
        public virtual DbSet<VatLieu> VatLieus { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
    }
}
