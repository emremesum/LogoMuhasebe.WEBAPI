using LogoMuhasebeApp.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogoMuhasebeApp.Application.Interfaces
{
    /// <summary>
    /// Logo REST API ile iletişim için arayüz
    /// </summary>
    public interface ILogoApiClient
    {
        /// <summary>
        /// Satış fişi bilgilerini Logo REST API'ye gönderir
        /// </summary>
        /// <param name="invoiceDto">Satış fişi DTO</param>
        /// <returns>İşlem sonucu</returns>
        Task<bool> SendSalesInvoiceAsync(SalesInvoiceDto invoiceDto);
    }
}
