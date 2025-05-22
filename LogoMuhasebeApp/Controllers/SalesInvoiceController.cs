using LogoMuhasebeApp.Application.Dto;
using LogoMuhasebeApp.Application.Interfaces;
using LogoMuhasebeApp.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace LogoMuhasebeApp.API.Controllers
{
    /// <summary>
    /// Satış fişi oluşturma isteklerinin karşılandığı controller
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class SalesInvoiceController : ControllerBase
    {
        private readonly ISalesInvoiceService _salesInvoiceService;

        public SalesInvoiceController(ISalesInvoiceService salesInvoiceService)
        {
            _salesInvoiceService = salesInvoiceService;
        }

        /// <summary>
        /// POST api/salesinvoice
        /// Satış fişi oluşturma endpoint'i
        /// </summary>
        /// <param name="invoiceDto">Satış fişi detayları</param>
        /// <returns>Başarı durumuna göre HTTP sonucu</returns>
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Create([FromBody] SalesInvoice invoiceDto)
        {
            if (invoiceDto == null)
                return BadRequest("Gönderilen veri boş.");

            var success = await _salesInvoiceService.CreateSalesInvoiceAsync(invoiceDto);

            if (success)
                return Ok(new { message = "Satış fişi oluşturuldu." });
            else
                return StatusCode(500, "Satış fişi oluşturulurken hata oluştu.");
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<List<SalesInvoice>>> GetAll()
        {
            var invoices = await _salesInvoiceService.GetAllInvoicesAsync();
            return Ok(invoices);
        }
    }
}
