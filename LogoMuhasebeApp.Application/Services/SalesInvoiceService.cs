using LogoMuhasebeApp.Application.Dto;
using LogoMuhasebeApp.Application.Interfaces;
using LogoMuhasebeApp.Application.Repositories;
using LogoMuhasebeApp.Domain.Entities;

namespace LogoMuhasebeApp.Application.Services
{
    /// <summary>
    /// Satış fişi servis implementasyonu
    /// İş mantığını içerir ve altyapı servisine çağrı yapar
    /// </summary>
    public class SalesInvoiceService : ISalesInvoiceService
    {
        private readonly ILogoApiClient _logoApiClient;
        private readonly ISalesInvoiceRepository _salesInvoiceRepository;
        private readonly List<SalesInvoice> _invoices = new();
       public SalesInvoiceService(ILogoApiClient logoApiClient, ISalesInvoiceRepository salesInvoiceRepository)
        {
            _logoApiClient = logoApiClient;
            _salesInvoiceRepository = salesInvoiceRepository;

            _invoices = _salesInvoiceRepository.GetAllInvoicesAsync().Result;
        }
        /// <summary>
        /// Satış fişi oluşturulması için Logo API client'ını çağırır
        /// </summary>
        /// <returns>İşlem sonucu (başarılı/başarısız)</returns>
        public async Task<bool> CreateSalesInvoiceAsync(SalesInvoice invoiceDto)
        {
            // Burada gerekli iş kuralları eklenebilir (validasyon, dönüşüm vs.)
            
            // Mock olarak listeye ekle
            _invoices.Add(invoiceDto);

            // Logo API'ye gönderme işlemi (isteğe bağlı, simüle olabilir)
            // return await _logoApiClient.SendSalesInvoiceAsync(invoiceDto);
            await Task.CompletedTask;
            return true;
        }

        public async Task<List<SalesInvoice>> GetAllInvoicesAsync()
        {
            return await Task.FromResult(_invoices);
        }
    }

}
