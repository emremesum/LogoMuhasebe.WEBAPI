using LogoMuhasebeApp.Application.Dto;
using LogoMuhasebeApp.Domain.Entities;

namespace LogoMuhasebeApp.Application.Interfaces
{
    /// <summary>
    /// Satış fişi servis arayüzü
    /// Satış fişi oluşturma işlemi burada tanımlanır
    /// </summary>
    public interface ISalesInvoiceService
    {
        /// <summary>
        /// Logo API'ye satış fişi oluşturma isteği gönderir
        /// </summary>
        /// <param name="invoiceDto">Satış fişi DTO</param>
        /// <returns>İşlem sonucu (başarılı/başarısız)</returns>
        Task<bool> CreateSalesInvoiceAsync(SalesInvoice invoiceDto);
        public Task<List<SalesInvoice>> GetAllInvoicesAsync();
    }
}
