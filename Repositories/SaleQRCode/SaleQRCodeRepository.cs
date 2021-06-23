using JUSTMOVE.Data;
using JUSTMOVE.Models;
using JUSTMOVE.Repositories.GenericRepository;
using JUSTMOVE.Repositories.QRCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JUSTMOVE.Repositories.QRCodeRepository
{
    public class SaleQRCodeRepository : GenericRepository<SaleQRCode>, ISaleQRCodeRepository
    {
        public SaleQRCodeRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
