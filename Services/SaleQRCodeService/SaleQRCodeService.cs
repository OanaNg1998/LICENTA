using JUSTMOVE.Models;
using JUSTMOVE.Repositories.QRCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JUSTMOVE.Services.SaleQRCodeService
{
    public class SaleQRCodeService : ISaleQRCodeService
    {
        private readonly ISaleQRCodeRepository _qrCodeRepository;
        public SaleQRCodeService(ISaleQRCodeRepository qrCodeRepository)
        {
            _qrCodeRepository = qrCodeRepository;
          
        }
        public ICollection<SaleQRCode> GetQRCodes()
        {
           
           return _qrCodeRepository.GetAll();
           
        }

    }
}
