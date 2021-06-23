using JUSTMOVE.Models;
using JUSTMOVE.Services.SaleQRCodeService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JUSTMOVE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaleQRCodeController : ControllerBase
    {
        private readonly ISaleQRCodeService _qrCodeService;
        public SaleQRCodeController(ISaleQRCodeService qrCodeService)
        {
            _qrCodeService = qrCodeService;

        }
        [HttpGet]
        public ICollection<SaleQRCode> GetQRCodes()
        {

            return _qrCodeService.GetQRCodes();

        }
    }
}
